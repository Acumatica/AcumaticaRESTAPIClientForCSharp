using System.Collections.Generic;
using System.Runtime.Serialization;

using Newtonsoft.Json;

using Acumatica.RESTClient.Client;
using Acumatica.RESTClient.ContractBasedApi;
using Acumatica.RESTClient.ContractBasedApi.Model;

namespace Acumatica.Default_22_200_001.Model
{
	[DataContract]
	public class EmployeePaycheckEarningDetail : Entity
	{

		[DataMember(Name="Account", EmitDefaultValue=false)]
		public StringValue? Account { get; set; }

		[DataMember(Name="Amount", EmitDefaultValue=false)]
		public DecimalValue? Amount { get; set; }

		[DataMember(Name="Branch", EmitDefaultValue=false)]
		public StringValue? Branch { get; set; }

		[DataMember(Name="CertifiedJob", EmitDefaultValue=false)]
		public BooleanValue? CertifiedJob { get; set; }

		[DataMember(Name="Code", EmitDefaultValue=false)]
		public StringValue? Code { get; set; }

		[DataMember(Name="CostCode", EmitDefaultValue=false)]
		public StringValue? CostCode { get; set; }

		[DataMember(Name="Date", EmitDefaultValue=false)]
		public DateTimeValue? Date { get; set; }

		[DataMember(Name="Description", EmitDefaultValue=false)]
		public StringValue? Description { get; set; }

		[DataMember(Name="Hours", EmitDefaultValue=false)]
		public DecimalValue? Hours { get; set; }

		[DataMember(Name="LaborItem", EmitDefaultValue=false)]
		public StringValue? LaborItem { get; set; }

		[DataMember(Name="LastModifiedDateTime", EmitDefaultValue=false)]
		public DateTimeValue? LastModifiedDateTime { get; set; }

		[DataMember(Name="Location", EmitDefaultValue=false)]
		public StringValue? Location { get; set; }

		[DataMember(Name="ManualRate", EmitDefaultValue=false)]
		public BooleanValue? ManualRate { get; set; }

		[DataMember(Name="Project", EmitDefaultValue=false)]
		public StringValue? Project { get; set; }

		[DataMember(Name="Rate", EmitDefaultValue=false)]
		public DecimalValue? Rate { get; set; }

		[DataMember(Name="ShiftCode", EmitDefaultValue=false)]
		public StringValue? ShiftCode { get; set; }

		[DataMember(Name="Subaccount", EmitDefaultValue=false)]
		public StringValue? Subaccount { get; set; }

		[DataMember(Name="Task", EmitDefaultValue=false)]
		public StringValue? Task { get; set; }

		[DataMember(Name="UnionLocal", EmitDefaultValue=false)]
		public StringValue? UnionLocal { get; set; }

		[DataMember(Name="Units", EmitDefaultValue=false)]
		public DecimalValue? Units { get; set; }

		[DataMember(Name="UnitType", EmitDefaultValue=false)]
		public StringValue? UnitType { get; set; }

		[DataMember(Name="WCCCode", EmitDefaultValue=false)]
		public StringValue? WCCCode { get; set; }

	}
}