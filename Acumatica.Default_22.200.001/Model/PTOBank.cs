using Acumatica.RESTClient.Model;
using System.Collections.Generic;
using System.Runtime.Serialization;

namespace Acumatica.Default_22_200_001.Model
{
	[DataContract]
	public class PTOBank : Entity_v4
	{

		[DataMember(Name="AccrualLimit", EmitDefaultValue=false)]
		public DecimalValue AccrualLimit { get; set; }

		[DataMember(Name="AccrualMethod", EmitDefaultValue=false)]
		public StringValue AccrualMethod { get; set; }

		[DataMember(Name="AccrueonCertifiedJobOnly", EmitDefaultValue=false)]
		public BooleanValue AccrueonCertifiedJobOnly { get; set; }

		[DataMember(Name="Active", EmitDefaultValue=false)]
		public BooleanValue Active { get; set; }

		[DataMember(Name="AllowNegativeBalance", EmitDefaultValue=false)]
		public BooleanValue AllowNegativeBalance { get; set; }

		[DataMember(Name="BankStartDate", EmitDefaultValue=false)]
		public DateTimeValue BankStartDate { get; set; }

		[DataMember(Name="CanOnlyDisbursefromCarryover", EmitDefaultValue=false)]
		public BooleanValue CanOnlyDisbursefromCarryover { get; set; }

		[DataMember(Name="CarryoverAmount", EmitDefaultValue=false)]
		public DecimalValue CarryoverAmount { get; set; }

		[DataMember(Name="CarryoverType", EmitDefaultValue=false)]
		public StringValue CarryoverType { get; set; }

		[DataMember(Name="CreateFinTransactions", EmitDefaultValue=false)]
		public BooleanValue CreateFinTransactions { get; set; }

		[DataMember(Name="DefaultAccrualPercent", EmitDefaultValue=false)]
		public DecimalValue DefaultAccrualPercent { get; set; }

		[DataMember(Name="DefaultDisbursingType", EmitDefaultValue=false)]
		public StringValue DefaultDisbursingType { get; set; }

		[DataMember(Name="Description", EmitDefaultValue=false)]
		public StringValue Description { get; set; }

		[DataMember(Name="DisbursingEarningCode", EmitDefaultValue=false)]
		public StringValue DisbursingEarningCode { get; set; }

		[DataMember(Name="FrontLoadingAmount", EmitDefaultValue=false)]
		public DecimalValue FrontLoadingAmount { get; set; }

		[DataMember(Name="GLAccounts", EmitDefaultValue=false)]
		public PTOBankGLAccounts GLAccounts { get; set; }

		[DataMember(Name="LastModifiedDateTime", EmitDefaultValue=false)]
		public DateTimeValue LastModifiedDateTime { get; set; }

		[DataMember(Name="OnSettlement", EmitDefaultValue=false)]
		public StringValue OnSettlement { get; set; }

		[DataMember(Name="PayCarryoverafterMonths", EmitDefaultValue=false)]
		public IntValue PayCarryoverafterMonths { get; set; }

		[DataMember(Name="PTOBankID", EmitDefaultValue=false)]
		public StringValue PTOBankID { get; set; }

	}
}