using System;
using System.Collections.Generic;
using System.Runtime.Serialization;

using Newtonsoft.Json;

using Acumatica.RESTClient.Client;
using Acumatica.RESTClient.ContractBasedApi;
using Acumatica.RESTClient.ContractBasedApi.Model;

namespace Acumatica.Default_23_200_001.Model
{
	/// <summary>
	/// Corresponds to the screen <c>PR205000</c> in the Acumatica ERP
	/// <para>Key Fields: PayGroupID</para>
	/// </summary>
	[DataContract]
	public class PayGroup : Entity, ITopLevelEntity
	{

		/// <summary>
		/// <para>DAC Field Name: BenefitExpenseAcctID</para>
		/// <para>DAC: PX.Objects.PR.PRPayGroup</para>
		/// <para>Display Name: Benefit Expense Account</para>
		/// </summary>
		[DataMember(Name="BenefitExpenseAccount", EmitDefaultValue=false)]
		public StringValue? BenefitExpenseAccount { get; set; }

		/// <summary>
		/// <para>DAC Field Name: BenefitExpenseSubID</para>
		/// <para>DAC: PX.Objects.PR.PRPayGroup</para>
		/// <para>Display Name: Benefit Expense Sub.</para>
		/// </summary>
		[DataMember(Name="BenefitExpenseSub", EmitDefaultValue=false)]
		public StringValue? BenefitExpenseSub { get; set; }

		/// <summary>
		/// <para>DAC Field Name: BenefitLiabilityAcctID</para>
		/// <para>DAC: PX.Objects.PR.PRPayGroup</para>
		/// <para>Display Name: Benefit Liability Account</para>
		/// </summary>
		[DataMember(Name="BenefitLiabilityAccount", EmitDefaultValue=false)]
		public StringValue? BenefitLiabilityAccount { get; set; }

		/// <summary>
		/// <para>DAC Field Name: BenefitLiabilitySubID</para>
		/// <para>DAC: PX.Objects.PR.PRPayGroup</para>
		/// <para>Display Name: Benefit Liability Sub.</para>
		/// </summary>
		[DataMember(Name="BenefitLiabilitySub", EmitDefaultValue=false)]
		public StringValue? BenefitLiabilitySub { get; set; }

		/// <summary>
		/// <para>DAC Field Name: DedLiabilityAcctID</para>
		/// <para>DAC: PX.Objects.PR.PRPayGroup</para>
		/// <para>Display Name: Deduction Liability Account</para>
		/// </summary>
		[DataMember(Name="DeductionLiabilityAccount", EmitDefaultValue=false)]
		public StringValue? DeductionLiabilityAccount { get; set; }

		/// <summary>
		/// <para>DAC Field Name: DedLiabilitySubID</para>
		/// <para>DAC: PX.Objects.PR.PRPayGroup</para>
		/// <para>Display Name: Deduction Liability Sub.</para>
		/// </summary>
		[DataMember(Name="DeductionLiabilitySub", EmitDefaultValue=false)]
		public StringValue? DeductionLiabilitySub { get; set; }

		/// <summary>
		/// <para>DAC Field Name: EarningsAcctID</para>
		/// <para>DAC: PX.Objects.PR.PRPayGroup</para>
		/// <para>Display Name: Earnings Account</para>
		/// </summary>
		[DataMember(Name="EarningsAccount", EmitDefaultValue=false)]
		public StringValue? EarningsAccount { get; set; }

		/// <summary>
		/// <para>DAC Field Name: EarningsSubID</para>
		/// <para>DAC: PX.Objects.PR.PRPayGroup</para>
		/// <para>Display Name: Earnings Sub.</para>
		/// </summary>
		[DataMember(Name="EarningsSub", EmitDefaultValue=false)]
		public StringValue? EarningsSub { get; set; }

		/// <summary>
		/// <para>DAC: PX.Objects.PR.PRPayGroup</para>
		/// <para>Display Name: Default</para>
		/// </summary>
		[DataMember(Name="IsDefault", EmitDefaultValue=false)]
		public BooleanValue? IsDefault { get; set; }

		[DataMember(Name="LastModifiedDateTime", EmitDefaultValue=false)]
		public DateTimeValue? LastModifiedDateTime { get; set; }

		/// <summary>
		/// <para>DAC: PX.Objects.PR.PRPayGroup</para>
		/// <para>Display Name: Pay Group ID</para>
		/// <para>SQL Type: nvarchar(15)</para>
		/// Key Field
		/// </summary>
		[DataMember(Name="PayGroupID", EmitDefaultValue=false)]
		public StringValue? PayGroupID { get; set; }

		/// <summary>
		/// <para>DAC Field Name: Description</para>
		/// <para>DAC: PX.Objects.PR.PRPayGroup</para>
		/// <para>Display Name: Pay Group Name</para>
		/// <para>SQL Type: nvarchar(60)</para>
		/// </summary>
		[DataMember(Name="PayGroupName", EmitDefaultValue=false)]
		public StringValue? PayGroupName { get; set; }

		/// <summary>
		/// <para>DAC Field Name: PTOAssetAcctID</para>
		/// <para>DAC: PX.Objects.PR.PRPayGroup</para>
		/// <para>Display Name: PTO Asset Account</para>
		/// </summary>
		[DataMember(Name="PTOAssetAccount", EmitDefaultValue=false)]
		public StringValue? PTOAssetAccount { get; set; }

		/// <summary>
		/// <para>DAC Field Name: PTOAssetSubID</para>
		/// <para>DAC: PX.Objects.PR.PRPayGroup</para>
		/// <para>Display Name: PTO Asset Sub.</para>
		/// </summary>
		[DataMember(Name="PTOAssetSub", EmitDefaultValue=false)]
		public StringValue? PTOAssetSub { get; set; }

		/// <summary>
		/// <para>DAC Field Name: PTOExpenseAcctID</para>
		/// <para>DAC: PX.Objects.PR.PRPayGroup</para>
		/// <para>Display Name: PTO Expense Account</para>
		/// </summary>
		[DataMember(Name="PTOExpenseAccount", EmitDefaultValue=false)]
		public StringValue? PTOExpenseAccount { get; set; }

		/// <summary>
		/// <para>DAC Field Name: PTOExpenseSubID</para>
		/// <para>DAC: PX.Objects.PR.PRPayGroup</para>
		/// <para>Display Name: PTO Expense Sub.</para>
		/// </summary>
		[DataMember(Name="PTOExpenseSub", EmitDefaultValue=false)]
		public StringValue? PTOExpenseSub { get; set; }

		/// <summary>
		/// <para>DAC Field Name: PTOLiabilityAcctID</para>
		/// <para>DAC: PX.Objects.PR.PRPayGroup</para>
		/// <para>Display Name: PTO Liability Account</para>
		/// </summary>
		[DataMember(Name="PTOLiabilityAccount", EmitDefaultValue=false)]
		public StringValue? PTOLiabilityAccount { get; set; }

		/// <summary>
		/// <para>DAC Field Name: PTOLiabilitySubID</para>
		/// <para>DAC: PX.Objects.PR.PRPayGroup</para>
		/// <para>Display Name: PTO Liability Sub.</para>
		/// </summary>
		[DataMember(Name="PTOLiabilitySub", EmitDefaultValue=false)]
		public StringValue? PTOLiabilitySub { get; set; }

		/// <summary>
		/// <para>DAC Field Name: TaxExpenseAcctID</para>
		/// <para>DAC: PX.Objects.PR.PRPayGroup</para>
		/// <para>Display Name: Tax Expense Account</para>
		/// </summary>
		[DataMember(Name="TaxExpenseAccount", EmitDefaultValue=false)]
		public StringValue? TaxExpenseAccount { get; set; }

		/// <summary>
		/// <para>DAC Field Name: TaxExpenseSubID</para>
		/// <para>DAC: PX.Objects.PR.PRPayGroup</para>
		/// <para>Display Name: Tax Expense Sub.</para>
		/// </summary>
		[DataMember(Name="TaxExpenseSub", EmitDefaultValue=false)]
		public StringValue? TaxExpenseSub { get; set; }

		/// <summary>
		/// <para>DAC Field Name: TaxLiabilityAcctID</para>
		/// <para>DAC: PX.Objects.PR.PRPayGroup</para>
		/// <para>Display Name: Tax Liability Account</para>
		/// </summary>
		[DataMember(Name="TaxLiabilityAccount", EmitDefaultValue=false)]
		public StringValue? TaxLiabilityAccount { get; set; }

		/// <summary>
		/// <para>DAC Field Name: TaxLiabilitySubID</para>
		/// <para>DAC: PX.Objects.PR.PRPayGroup</para>
		/// <para>Display Name: Tax Liability Sub.</para>
		/// </summary>
		[DataMember(Name="TaxLiabilitySub", EmitDefaultValue=false)]
		public StringValue? TaxLiabilitySub { get; set; }

		/// <summary>
		/// The name of the Role to be used to grant users access to the data of the Pay Group.
		/// <para>DAC Field Name: RoleName</para>
		/// <para>DAC: PX.Objects.PR.PRPayGroup</para>
		/// <para>Display Name: User Role</para>
		/// <para>SQL Type: nvarchar(64)</para>
		/// </summary>
		[DataMember(Name="UserRole", EmitDefaultValue=false)]
		public StringValue? UserRole { get; set; }

		public static class Expand
		{
			public const string Files = "Files";

			//Intentionally excluded
			//public const string All = "Files";
		}
		public virtual string GetEndpointPath()
		{
			return "entity/Default/23.200.001";
		}
	}
}