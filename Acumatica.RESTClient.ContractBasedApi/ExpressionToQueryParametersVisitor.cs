using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;

namespace Acumatica.RESTClient.ContractBasedApi
{
    /// <summary>
    /// Visitor that translates LINQ expressions to OData query parameters
    /// </summary>
    internal class ExpressionToQueryParametersVisitor : ExpressionVisitor
    {
        private readonly QueryParameters _parameters = new QueryParameters();
        private readonly StringBuilder _filterBuilder = new StringBuilder();

        public static QueryParameters Translate(Expression expression)
        {
            var visitor = new ExpressionToQueryParametersVisitor();
            visitor.Visit(expression);
            return visitor._parameters;
        }

        protected override Expression VisitMethodCall(MethodCallExpression node)
        {
            if (node.Method.DeclaringType == typeof(Queryable) || 
                node.Method.DeclaringType == typeof(Enumerable))
            {
                switch (node.Method.Name)
                {
                    case "Where":
                        Visit(node.Arguments[0]);
                        var lambda = (LambdaExpression)StripQuotes(node.Arguments[1]);
                        var filter = TranslateWhere(lambda.Body);
                        if (!string.IsNullOrEmpty(_parameters.Filter))
                        {
                            _parameters.Filter = $"({_parameters.Filter}) and ({filter})";
                        }
                        else
                        {
                            _parameters.Filter = filter;
                        }
                        return node;

                    case "Select":
                        Visit(node.Arguments[0]);
                        var selectLambda = (LambdaExpression)StripQuotes(node.Arguments[1]);
                        _parameters.Select = TranslateSelect(selectLambda.Body);
                        return node;

                    case "Take":
                        Visit(node.Arguments[0]);
                        var takeValue = ((ConstantExpression)node.Arguments[1]).Value;
                        if (takeValue != null)
                        {
                            _parameters.Top = (int)takeValue;
                        }
                        return node;

                    case "Skip":
                        Visit(node.Arguments[0]);
                        var skipValue = ((ConstantExpression)node.Arguments[1]).Value;
                        if (skipValue != null)
                        {
                            _parameters.Skip = (int)skipValue;
                        }
                        return node;

                    case "First":
                    case "FirstOrDefault":
                        Visit(node.Arguments[0]);
                        if (node.Arguments.Count > 1)
                        {
                            var firstLambda = (LambdaExpression)StripQuotes(node.Arguments[1]);
                            var firstFilter = TranslateWhere(firstLambda.Body);
                            if (!string.IsNullOrEmpty(_parameters.Filter))
                            {
                                _parameters.Filter = $"({_parameters.Filter}) and ({firstFilter})";
                            }
                            else
                            {
                                _parameters.Filter = firstFilter;
                            }
                        }
                        _parameters.Top = 1;
                        return node;

                    case "Single":
                    case "SingleOrDefault":
                        Visit(node.Arguments[0]);
                        if (node.Arguments.Count > 1)
                        {
                            var singleLambda = (LambdaExpression)StripQuotes(node.Arguments[1]);
                            var singleFilter = TranslateWhere(singleLambda.Body);
                            if (!string.IsNullOrEmpty(_parameters.Filter))
                            {
                                _parameters.Filter = $"({_parameters.Filter}) and ({singleFilter})";
                            }
                            else
                            {
                                _parameters.Filter = singleFilter;
                            }
                        }
                        _parameters.Top = 2; // Take 2 to validate Single
                        return node;

                    case "Count":
                    case "LongCount":
                    case "Any":
                        Visit(node.Arguments[0]);
                        if (node.Arguments.Count > 1)
                        {
                            var countLambda = (LambdaExpression)StripQuotes(node.Arguments[1]);
                            var countFilter = TranslateWhere(countLambda.Body);
                            if (!string.IsNullOrEmpty(_parameters.Filter))
                            {
                                _parameters.Filter = $"({_parameters.Filter}) and ({countFilter})";
                            }
                            else
                            {
                                _parameters.Filter = countFilter;
                            }
                        }
                        return node;
                }
            }

            return base.VisitMethodCall(node);
        }

        private static Expression StripQuotes(Expression expression)
        {
            while (expression.NodeType == ExpressionType.Quote)
            {
                expression = ((UnaryExpression)expression).Operand;
            }
            return expression;
        }

        private string TranslateWhere(Expression expression)
        {
            switch (expression.NodeType)
            {
                case ExpressionType.Equal:
                    return TranslateBinaryExpression((BinaryExpression)expression, "eq");
                case ExpressionType.NotEqual:
                    return TranslateBinaryExpression((BinaryExpression)expression, "ne");
                case ExpressionType.GreaterThan:
                    return TranslateBinaryExpression((BinaryExpression)expression, "gt");
                case ExpressionType.GreaterThanOrEqual:
                    return TranslateBinaryExpression((BinaryExpression)expression, "ge");
                case ExpressionType.LessThan:
                    return TranslateBinaryExpression((BinaryExpression)expression, "lt");
                case ExpressionType.LessThanOrEqual:
                    return TranslateBinaryExpression((BinaryExpression)expression, "le");
                case ExpressionType.AndAlso:
                    var andLeft = TranslateWhere(((BinaryExpression)expression).Left);
                    var andRight = TranslateWhere(((BinaryExpression)expression).Right);
                    return $"({andLeft}) and ({andRight})";
                case ExpressionType.OrElse:
                    var orLeft = TranslateWhere(((BinaryExpression)expression).Left);
                    var orRight = TranslateWhere(((BinaryExpression)expression).Right);
                    return $"({orLeft}) or ({orRight})";
                case ExpressionType.Not:
                    var operand = TranslateWhere(((UnaryExpression)expression).Operand);
                    return $"not ({operand})";
                case ExpressionType.Call:
                    return TranslateMethodCall((MethodCallExpression)expression);
                case ExpressionType.MemberAccess:
                    // Handle boolean properties directly (e.g., entity.IsActive)
                    var memberExpr = (MemberExpression)expression;
                    if (memberExpr.Type == typeof(bool))
                    {
                        return $"{GetMemberName(memberExpr)} eq true";
                    }
                    break;
            }

            throw new NotSupportedException($"Expression node type '{expression.NodeType}' is not supported in Where clause");
        }

        private string TranslateBinaryExpression(BinaryExpression expression, string operatorString)
        {
            var left = GetMemberName(expression.Left);
            var right = GetValue(expression.Right);
            return $"{left} {operatorString} {right}";
        }

        private string TranslateMethodCall(MethodCallExpression expression)
        {
            if (expression.Method.Name == "Contains" && expression.Method.DeclaringType == typeof(string))
            {
                var obj = GetMemberName(expression.Object!);
                var value = GetValue(expression.Arguments[0]);
                return $"contains({obj},{value})";
            }

            if (expression.Method.Name == "StartsWith" && expression.Method.DeclaringType == typeof(string))
            {
                var obj = GetMemberName(expression.Object!);
                var value = GetValue(expression.Arguments[0]);
                return $"startswith({obj},{value})";
            }

            if (expression.Method.Name == "EndsWith" && expression.Method.DeclaringType == typeof(string))
            {
                var obj = GetMemberName(expression.Object!);
                var value = GetValue(expression.Arguments[0]);
                return $"endswith({obj},{value})";
            }

            throw new NotSupportedException($"Method '{expression.Method.Name}' is not supported in Where clause");
        }

        private string GetMemberName(Expression expression)
        {
            if (expression is MemberExpression memberExpr)
            {
                // Get the property/field name
                string memberName = memberExpr.Member.Name;
                
                // Check if the member has a DataMember attribute with a custom name
                var dataMemberAttr = memberExpr.Member.GetCustomAttributes(typeof(System.Runtime.Serialization.DataMemberAttribute), false)
                    .OfType<System.Runtime.Serialization.DataMemberAttribute>()
                    .FirstOrDefault();
                
                if (dataMemberAttr != null && !string.IsNullOrEmpty(dataMemberAttr.Name))
                {
                    memberName = dataMemberAttr.Name;
                }
                
                // Handle nested properties
                if (memberExpr.Expression is MemberExpression parentMember)
                {
                    return $"{GetMemberName(parentMember)}/{memberName}";
                }
                
                return memberName;
            }

            if (expression is UnaryExpression unaryExpr && unaryExpr.NodeType == ExpressionType.Convert)
            {
                return GetMemberName(unaryExpr.Operand);
            }

            throw new NotSupportedException($"Expression type '{expression.NodeType}' is not supported for member access");
        }

        private string GetValue(Expression expression)
        {
            if (expression is ConstantExpression constantExpr)
            {
                return FormatValue(constantExpr.Value);
            }

            if (expression is MemberExpression memberExpr)
            {
                var objectMember = Expression.Convert(memberExpr, typeof(object));
                var getterLambda = Expression.Lambda<Func<object>>(objectMember);
                var getter = getterLambda.Compile();
                return FormatValue(getter());
            }

            if (expression is UnaryExpression unaryExpr)
            {
                if (unaryExpr.NodeType == ExpressionType.Convert)
                {
                    return GetValue(unaryExpr.Operand);
                }
            }

            // Try to evaluate the expression
            try
            {
                var objectMember = Expression.Convert(expression, typeof(object));
                var getterLambda = Expression.Lambda<Func<object>>(objectMember);
                var getter = getterLambda.Compile();
                return FormatValue(getter());
            }
            catch
            {
                throw new NotSupportedException($"Cannot get value from expression type '{expression.NodeType}'");
            }
        }

        private string FormatValue(object? value)
        {
            if (value == null)
            {
                return "null";
            }

            if (value is string str)
            {
                return $"'{str.Replace("'", "''")}'";
            }

            if (value is DateTime dateTime)
            {
                return $"'{dateTime:yyyy-MM-ddTHH:mm:ss}'";
            }

            if (value is bool boolValue)
            {
                return boolValue ? "true" : "false";
            }

            if (value is Guid guid)
            {
                return $"guid'{guid}'";
            }

            // Numeric types and other value types
            var strValue = value.ToString();
            return strValue ?? string.Empty;
        }

        private string TranslateSelect(Expression expression)
        {
            // Handle simple member access: x => x.PropertyName
            if (expression is MemberExpression memberExpr)
            {
                return memberExpr.Member.Name;
            }

            // Handle new expression: x => new { x.Prop1, x.Prop2 }
            if (expression is NewExpression newExpr)
            {
                var properties = new List<string>();
                foreach (var arg in newExpr.Arguments)
                {
                    if (arg is MemberExpression member)
                    {
                        properties.Add(member.Member.Name);
                    }
                }
                return string.Join(",", properties);
            }

            throw new NotSupportedException($"Select expression type '{expression.NodeType}' is not supported");
        }
    }
}
