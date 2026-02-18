using System;
using System.Collections.Generic;

using Newtonsoft.Json;

using Acumatica.RESTClient.Client;
using Acumatica.RESTClient.ContractBasedApi;
using Acumatica.RESTClient.ContractBasedApi.Model;

namespace Acumatica.ISVCB_21_200_001.Model
{
	public class ISVSolution : Entity, ITopLevelEntity
	{

		public StringValue? Initials { get; set; }

		public StringValue? SolutionCode { get; set; }

		public StringValue? SolutionClass { get; set; }

		public StringValue? SolutionName { get; set; }

		public StringValue? ISV { get; set; }

		public StringValue? SolutionStage { get; set; }

		public StringValue? TAM { get; set; }

		public StringValue? TAMEmployeeName { get; set; }

		public StringValue? ISVCERTND { get; set; }

		public List<Customers>? Customers { get; set; }

		public List<RepositoryLines>? Repository { get; set; }

		public List<Attribute>? Attributes { get; set; }

		public static class Expand
		{
			public const string Files = "Files";
			public const string Translations = "Translations";
			public const string Customers = "Customers";
			public const string Customers_Files = "Customers/Files";
			public const string Repository = "Repository";
			public const string Repository_Files = "Repository/Files";
			public const string Attributes = "Attributes";

			//Intentionally excluded
			//public const string All = "Files,Translations,Customers,Customers/Files,Repository,Repository/Files,Attributes";
		}
		public virtual string GetEndpointPath()
		{
			return "entity/ISVCB/21.200.001";
		}
	}
}