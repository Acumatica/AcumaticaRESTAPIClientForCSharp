using System;
using System.Collections.Generic;
using System.Runtime.Serialization;

using Newtonsoft.Json;

using Acumatica.RESTClient.Client;
using Acumatica.RESTClient.ContractBasedApi;
using Acumatica.RESTClient.ContractBasedApi.Model;

namespace Acumatica.Default_24_200_001.Model
{
	[DataContract]
	public class ConvertLeadToOpportunityParameters
	{
		public ConvertLeadToOpportunityParameters() { }

		[DataMember(Name="FirstName", EmitDefaultValue=false)]
		public StringValue? FirstName { get; set; }
		[DataMember(Name="LastName", EmitDefaultValue=false)]
		public StringValue? LastName { get; set; }
		[DataMember(Name="AccountName", EmitDefaultValue=false)]
		public StringValue? AccountName { get; set; }
		[DataMember(Name="JobTitle", EmitDefaultValue=false)]
		public StringValue? JobTitle { get; set; }
		[DataMember(Name="Phone1Type", EmitDefaultValue=false)]
		public StringValue? Phone1Type { get; set; }
		[DataMember(Name="Phone1", EmitDefaultValue=false)]
		public StringValue? Phone1 { get; set; }
		[DataMember(Name="Phone2Type", EmitDefaultValue=false)]
		public StringValue? Phone2Type { get; set; }
		[DataMember(Name="Phone2", EmitDefaultValue=false)]
		public StringValue? Phone2 { get; set; }
		[DataMember(Name="Email", EmitDefaultValue=false)]
		public StringValue? Email { get; set; }
		[DataMember(Name="ContactClass", EmitDefaultValue=false)]
		public StringValue? ContactClass { get; set; }
		[DataMember(Name="BusinessAccountID", EmitDefaultValue=false)]
		public StringValue? BusinessAccountID { get; set; }
		[DataMember(Name="BusinessAccountName", EmitDefaultValue=false)]
		public StringValue? BusinessAccountName { get; set; }
		[DataMember(Name="BusinessAccountClass", EmitDefaultValue=false)]
		public StringValue? BusinessAccountClass { get; set; }
		[DataMember(Name="OpportunitySubject", EmitDefaultValue=false)]
		public StringValue? OpportunitySubject { get; set; }
		[DataMember(Name="OpportunityCloseDate", EmitDefaultValue=false)]
		public StringValue? OpportunityCloseDate { get; set; }
		[DataMember(Name="OpportunityClass", EmitDefaultValue=false)]
		public StringValue? OpportunityClass { get; set; }
	}
}