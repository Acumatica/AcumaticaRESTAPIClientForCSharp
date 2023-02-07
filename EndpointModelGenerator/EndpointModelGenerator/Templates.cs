namespace EndpointSchemaGenerator
{
	public static class Templates
	{
		public static string ActionUsingsTemplate = "using Acumatica.RESTClient.Model;\r\nusing System.Runtime.Serialization;\r\n\r\n";

		//{0} = Endpoint namespace (e.g. Acumatica.Default_18_200_001)
		//{1} = ActionName
		//{2} = EntityName
		public static string ActionTemplate = "namespace {0}.Model\r\n{{\r\n\t[DataContract]\r\n\tpublic class {1} : EntityAction<{2}>\r\n\t{{\r\n\t\tpublic {1}({2} entity) : base(entity)\r\n\t\t{{ }}\r\n\t\tpublic {1}() : base()\r\n\t\t{{ }}\r\n\t}}\r\n}}\r\n";

		public static string EntityUsingsTemplate = "using Acumatica.RESTClient.Model;\r\nusing System.Collections.Generic;\r\nusing System.Runtime.Serialization;";

		//{0} = FieldName
		//{1} = FieldType
		public static string FieldTemplate = "\r\n\t\t[DataMember(Name=\"{0}\", EmitDefaultValue=false)]\r\n\t\tpublic {1} {0} {{ get; set; }}\r\n";

		//{0} = Endpoint namespace (e.g. Acumatica.Default_18_200_001)
		//{1} = EntityName
		//{2} = Content
		//{3} = version of System Contract
		public static string EntityTemplate = "\r\n\r\nnamespace {0}.Model\r\n{{\r\n\t[DataContract]\r\n\tpublic class {1} : Entity_v{3}\r\n\t{{\r\n{2}\r\n\t}}\r\n}}";

		//{0} = Endpoint namespace (e.g. Acumatica.Default_18_200_001)
		//{1} = EntityName
		public static string ApiTemplate = "using Acumatica.RESTClient.Api;\r\nusing Acumatica.RESTClient.Client;\r\nusing {0}.Model;\r\n\r\nnamespace {0}.Api\r\n{{\r\n\tpublic class {1}Api : BaseEndpointApi<{1}>\r\n\t{{\r\n\t\tpublic {1}Api(Session session) : base(session)\r\n\t\t{{ }}\r\n\t}}\r\n}}";

		//{0} = Endpoint namespace (e.g. Acumatica.Default_18_200_001)
		//{1} = ActionName
		//{2} = EntityName
		//{3} = Content
		public static string ActionWithParametersTemplate = "namespace {0}.Model\r\n{{\r\n\t[DataContract]\r\n\tpublic class {1} : EntityActionWithParameters<{2}, {1}Parameters>\r\n\t{{\r\n\t\tpublic {1}() : base()\r\n\t\t{{ }}\r\n\t\tpublic {1}({2} entity, {1}Parameters parameters) : base(entity, parameters)\r\n\t\t{{ }}\r\n{3}\r\n\t}}\r\n}}";

		//{0} = Endpoint namespace (e.g. Acumatica.Default_18_200_001)
		//{1} = ActionName
		//{2} = Content
		public static string ActionParametersTemplate = "using Acumatica.RESTClient.Model;\r\nusing Newtonsoft.Json;\r\nusing System.Runtime.Serialization;\r\n\r\nnamespace {0}.Model\r\n{{\r\n\t[DataContract]\r\n\tpublic class {1}Parameters\r\n\t{{\r\n\t\tpublic {1}Parameters() {{ }}\r\n{2}\r\n\t\tpublic virtual string ToJson()\r\n\t\t{{\r\n\t\t\treturn JsonConvert.SerializeObject(this, Formatting.Indented);\r\n\t\t}}\r\n\t}}\r\n}}";
		
		//{0} = Parameter Name
		//{1} = Parameter Type
		public static string ParameterTemplate = "\t\t[DataMember(Name=\"{0}\", EmitDefaultValue=false)]\r\n\t\tpublic {1} {0} {{ get; set; }}";

		//{0} = Parameter Name
		//{1} = Parameter Type
		public static string InActionParameterTemplate = "\r\n\t\tpublic {1} {0}\r\n\t\t{{\r\n\t\t\tget {{ return Parameters.{0}; }}\r\n\t\t\tset {{ Parameters.{0} = value; }}\r\n\t\t}}";

		//{0} = Endpoint namespace (e.g. Acumatica.Default_18_200_001)
		//{1} = Endpoint Path
		public static string BaseEndpointApiTemplate = "using Acumatica.RESTClient.Api;\r\nusing Acumatica.RESTClient.Client;\r\nusing Acumatica.RESTClient.Model;\r\n\r\nnamespace {0}.Api\r\n{{\r\n\tpublic abstract class BaseEndpointApi<EntityType> : EntityAPI<EntityType>\r\n\t\twhere EntityType : Entity\r\n\t{{\r\n\t\tpublic BaseEndpointApi(Session session) : base(session)\r\n\t\t{{ }}\r\n\t\tpublic override string GetEndpointPath()\r\n\t\t{{\r\n\t\t\treturn \"entity/{1}\";\r\n\t\t}}\r\n\t}}\r\n}}";

		public static string ProjectTemplate = "<Project Sdk=\"Microsoft.NET.Sdk\">\r\n\r\n  <PropertyGroup>\r\n	<TargetFramework>netstandard2.0</TargetFramework>\r\n  </PropertyGroup>\r\n\r\n   <ItemGroup>\r\n	<PackageReference Include=\"Newtonsoft.Json\" Version=\"13.0.1\" />\r\n  </ItemGroup> <ItemGroup>\r\n	<ProjectReference Include = \"..\\Acumatica.RESTClient\\Acumatica.RESTClient.csproj\" />\r\n  </ItemGroup >\r\n\r\n</Project >\r\n";


	}
}
