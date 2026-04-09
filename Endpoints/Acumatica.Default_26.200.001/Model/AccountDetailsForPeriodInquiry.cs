using System;
using System.Collections.Generic;
using System.Runtime.Serialization;

using Newtonsoft.Json;

using Acumatica.RESTClient.Client;
using Acumatica.RESTClient.ContractBasedApi;
using Acumatica.RESTClient.ContractBasedApi.Model;

namespace Acumatica.Default_26_200_001.Model
{
	[DataContract]
	public class AccountDetailsForPeriodInquiry : Entity, ITopLevelEntity
	{

		[DataMember(Name="FromPeriod", EmitDefaultValue=false)]
		public StringValue? FromPeriod { get; set; }

		[DataMember(Name="Ledger", EmitDefaultValue=false)]
		public StringValue? Ledger { get; set; }

		[DataMember(Name="Results", EmitDefaultValue=false)]
		public List<AccountDetailsForPeriodInquiryDetail>? Results { get; set; }

		[DataMember(Name="ToPeriod", EmitDefaultValue=false)]
		public StringValue? ToPeriod { get; set; }

		[DataMember(Name="IncludeUnposted", EmitDefaultValue=false)]
		public BooleanValue? IncludeUnposted { get; set; }

		[DataMember(Name="IncludeUnreleased", EmitDefaultValue=false)]
		public BooleanValue? IncludeUnreleased { get; set; }

		public static class Expand
		{
			public const string Files = "Files";
			public const string Translations = "Translations";
			public const string Results = "Results";
			public const string Results_Files = "Results/Files";

			//Intentionally excluded
			//public const string All = "Files,Translations,Results,Results/Files";
		}
		public virtual string GetEndpointPath()
		{
			return "entity/Default/26.200.001";
		}
	}
}