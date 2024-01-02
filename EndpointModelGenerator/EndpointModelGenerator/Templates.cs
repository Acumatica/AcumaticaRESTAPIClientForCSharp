namespace EndpointSchemaGenerator
{
	public static class Templates
	{
		public static string BaseNamespace = "Acumatica.RESTClient";
		public static string ModelNamespace = $"{BaseNamespace}.ContractBasedApi.Model";
		public static string ApiNamespace = $"{BaseNamespace}.ContractBasedApi";
        public static string ClientNamespace = $"{BaseNamespace}.Client";

        public static string UsingModelNamespace = $"using {ModelNamespace};";
		public static string UsingApiNamespace = $"using {ApiNamespace};";
        public static string UsingClientNamespace = $"using {ClientNamespace};";
		public static string UsingSystem = "using System;";
        public static string UsingSerialization = "using System.Runtime.Serialization;";
        public static string UsingGenericCollections = "using System.Collections.Generic;";
		public static string UsingNewtonsoftJson = "using Newtonsoft.Json;";

        public static string Usings = $"{UsingSystem}\r\n{UsingGenericCollections}\r\n{UsingSerialization}\r\n\r\n{UsingNewtonsoftJson}\r\n\r\n{UsingClientNamespace}\r\n{UsingApiNamespace}\r\n{UsingModelNamespace}\r\n\r\n";

        public static string NewtonsoftJsonVersion = "\"12.0.3\"";


       	//{0} = Endpoint namespace (e.g. Acumatica.Default_22_200_001)
		//{1} = ActionName
		//{2} = EntityName
		public static string ActionTemplate = Usings + "namespace {0}.Model\r\n{{\r\n\t[DataContract]\r\n\tpublic class {1} : EntityAction<{2}>\r\n\t{{\r\n\t\tpublic {1}({2} entity) : base(entity)\r\n\t\t{{ }}\r\n\t\tpublic {1}() : base()\r\n\t\t{{ }}\r\n\t}}\r\n}}\r\n";

	
		//{0} = FieldName
		//{1} = FieldType
		public static string FieldTemplate = "\r\n\t\t[DataMember(Name=\"{0}\", EmitDefaultValue=false)]\r\n\t\tpublic {1}? {0} {{ get; set; }}\r\n";

		//{0} = Endpoint namespace (e.g. Acumatica.Default_22_200_001)
		//{1} = EntityName
		//{2} = Content
		public static string EntityTemplate = Usings + "namespace {0}.Model\r\n{{\r\n\t[DataContract]\r\n\tpublic class {1} : Entity\r\n\t{{\r\n{2}\r\n\t}}\r\n}}";

        //{0} = Endpoint namespace (e.g. Acumatica.Default_22_200_001)
        //{1} = EntityName
        //{2} = Content
        //{3} = EndpointPath
        public static string TopLevelEntityTemplate = Usings + "namespace {0}.Model\r\n{{\r\n\t[DataContract]\r\n\tpublic class {1} : Entity, ITopLevelEntity\r\n\t{{\r\n{2}\r\n\t\tpublic virtual string GetEndpointPath()\r\n\t\t{{\r\n\t\t\treturn \"entity/{3}\";\r\n\t\t}}\r\n\t}}\r\n}}";

		//{0} = Endpoint namespace (e.g. Acumatica.Default_22_200_001)
		//{1} = EntityName
		public static string ApiTemplate = UsingSystem + "\r\n" + UsingClientNamespace + "\r\nusing {0}.Model;\r\n\r\nnamespace {0}.Api\r\n{{\r\n\t[Obsolete(\"For backward compatibility\")]\r\n\tpublic class {1}Api : BaseEndpointApi<{1}>\r\n\t{{\r\n\t\tpublic {1}Api(ApiClient client) : base(client)\r\n\t\t{{ }}\r\n\t}}\r\n}}";

		//{0} = Endpoint namespace (e.g. Acumatica.Default_22_200_001)
		//{1} = ActionName
		//{2} = EntityName
		//{3} = Content
		public static string ActionWithParametersTemplate = Usings + "namespace {0}.Model\r\n{{\r\n\t[DataContract]\r\n\tpublic class {1} : EntityActionWithParameters<{2}, {1}Parameters>\r\n\t{{\r\n\t\tpublic {1}() : base()\r\n\t\t{{ }}\r\n\t\tpublic {1}({2} entity, {1}Parameters parameters) : base(entity, parameters)\r\n\t\t{{ }}\r\n{3}\r\n\t}}\r\n}}";

		//{0} = Endpoint namespace (e.g. Acumatica.Default_22_200_001)
		//{1} = ActionName
		//{2} = Content
		public static string ActionParametersTemplate = Usings + "namespace {0}.Model\r\n{{\r\n\t[DataContract]\r\n\tpublic class {1}Parameters\r\n\t{{\r\n\t\tpublic {1}Parameters() {{ }}\r\n{2}\r\n\t}}\r\n}}";

		//{0} = Parameter Name
		//{1} = Parameter Type
		public static string ParameterTemplate = "\t\t[DataMember(Name=\"{0}\", EmitDefaultValue=false)]\r\n\t\tpublic {1}? {0} {{ get; set; }}";

		//{0} = Parameter Name
		//{1} = Parameter Type
		public static string InActionParameterTemplate = "\r\n\t\tpublic {1}? {0}\r\n\t\t{{\r\n\t\t\tget {{ return Parameters.{0}; }}\r\n\t\t\tset {{ Parameters.{0} = value; }}\r\n\t\t}}";

		//{0} = Endpoint namespace (e.g. Acumatica.Default_22_200_001)
		//{1} = Endpoint Path
		public static string BaseEndpointApiTemplate = Usings + "namespace {0}.Api\r\n{{\r\n\t[Obsolete(\"For backward compatibility\")]\r\n\tpublic abstract class BaseEndpointApi<EntityType> : EntityAPI<EntityType>\r\n\t\twhere EntityType : Entity, ITopLevelEntity, new()\r\n\t{{\r\n\t\tpublic BaseEndpointApi(ApiClient client) : base(client)\r\n\t\t{{ }}\r\n\t\tpublic override string GetEndpointPath()\r\n\t\t{{\r\n\t\t\treturn \"entity/{1}\";\r\n\t\t}}\r\n\t}}\r\n}}";

		public static string ProjectTemplate = "<Project Sdk=\"Microsoft.NET.Sdk\">\r\n\r\n  <PropertyGroup>\r\n	<TargetFramework>netstandard2.0</TargetFramework>\r\n    <LangVersion>8.0</LangVersion>\r\n    <nullable>Enable</nullable>\r\n  </PropertyGroup>\r\n\r\n   <ItemGroup>\r\n	<PackageReference Include=\"Newtonsoft.Json\" Version=" + NewtonsoftJsonVersion+ " />\r\n  </ItemGroup> <ItemGroup>\r\n	<ProjectReference Include = \"..\\Acumatica.RESTClient\\Acumatica.RESTClient.csproj\" />\r\n\t<ProjectReference Include = \"..\\Acumatica.RESTClient.ContractBasedApi\\Acumatica.RESTClient.ContractBasedApi.csproj\" />\r\n  </ItemGroup >\r\n\r\n</Project >\r\n";


	}
}
