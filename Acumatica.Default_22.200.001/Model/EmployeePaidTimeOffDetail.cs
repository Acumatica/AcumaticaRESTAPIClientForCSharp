using Acumatica.RESTClient.Model;
using System.Collections.Generic;
using System.Runtime.Serialization;

namespace Acumatica.Default_22_200_001.Model
{
	[DataContract]
	public class EmployeePaidTimeOffDetail : Entity
	{

		[DataMember(Name="AccrualLimit", EmitDefaultValue=false)]
		public DecimalValue AccrualLimit { get; set; }

		[DataMember(Name="AccrualMethod", EmitDefaultValue=false)]
		public StringValue AccrualMethod { get; set; }

		[DataMember(Name="AccrualPercent", EmitDefaultValue=false)]
		public DecimalValue AccrualPercent { get; set; }

		[DataMember(Name="Active", EmitDefaultValue=false)]
		public BooleanValue Active { get; set; }

		[DataMember(Name="AmountAccrued", EmitDefaultValue=false)]
		public DecimalValue AmountAccrued { get; set; }

		[DataMember(Name="AmountAvailable", EmitDefaultValue=false)]
		public DecimalValue AmountAvailable { get; set; }

		[DataMember(Name="AmountUsed", EmitDefaultValue=false)]
		public DecimalValue AmountUsed { get; set; }

		[DataMember(Name="CarryoverAmount", EmitDefaultValue=false)]
		public DecimalValue CarryoverAmount { get; set; }

		[DataMember(Name="CarryoverType", EmitDefaultValue=false)]
		public StringValue CarryoverType { get; set; }

		[DataMember(Name="CreateFinancialTransaction", EmitDefaultValue=false)]
		public BooleanValue CreateFinancialTransaction { get; set; }

		[DataMember(Name="Description", EmitDefaultValue=false)]
		public StringValue Description { get; set; }

		[DataMember(Name="DisbursingType", EmitDefaultValue=false)]
		public StringValue DisbursingType { get; set; }

		[DataMember(Name="EffectiveDate", EmitDefaultValue=false)]
		public DateTimeValue EffectiveDate { get; set; }

		[DataMember(Name="FrontLoadingAmount", EmitDefaultValue=false)]
		public DecimalValue FrontLoadingAmount { get; set; }

		[DataMember(Name="HoursAccrued", EmitDefaultValue=false)]
		public DecimalValue HoursAccrued { get; set; }

		[DataMember(Name="HoursAvailable", EmitDefaultValue=false)]
		public DecimalValue HoursAvailable { get; set; }

		[DataMember(Name="HoursPerYear", EmitDefaultValue=false)]
		public DecimalValue HoursPerYear { get; set; }

		[DataMember(Name="HoursUsed", EmitDefaultValue=false)]
		public DecimalValue HoursUsed { get; set; }

		[DataMember(Name="LastModifiedDateTime", EmitDefaultValue=false)]
		public DateTimeValue LastModifiedDateTime { get; set; }

		[DataMember(Name="PTOBank", EmitDefaultValue=false)]
		public StringValue PTOBank { get; set; }

		[DataMember(Name="UseClassDefaultValues", EmitDefaultValue=false)]
		public BooleanValue UseClassDefaultValues { get; set; }

	}
}