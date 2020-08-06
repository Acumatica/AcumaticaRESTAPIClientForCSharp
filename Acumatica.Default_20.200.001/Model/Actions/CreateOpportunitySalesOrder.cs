using Acumatica.RESTClient.Model;
using System.Runtime.Serialization;

namespace Acumatica.Default_20_200_001.Model
{
	[DataContract]
	public class CreateOpportunitySalesOrder : EntityActionWithParameters<Opportunity, CreateOpportunitySalesOrderParameters>
	{
		public CreateOpportunitySalesOrder() : base()
		{ }
		public CreateOpportunitySalesOrder(Opportunity entity, CreateOpportunitySalesOrderParameters parameters) : base(entity, parameters)
		{ }

		public StringValue OrderType
		{
			get { return Parameters.OrderType; }
			set { Parameters.OrderType = value; }
		}
		public BooleanValue RecalculatePricesandDiscounts
		{
			get { return Parameters.RecalculatePricesandDiscounts; }
			set { Parameters.RecalculatePricesandDiscounts = value; }
		}
	}
}