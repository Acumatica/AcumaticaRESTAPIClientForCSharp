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
	/// Corresponds to the screen <c>PR204000</c> in the Acumatica ERP
	/// <para>Key Fields: PTOBankID</para>
	/// </summary>
	[DataContract]
	public class PTOBank : Entity, ITopLevelEntity
	{

		/// <summary>
		/// The upper limit for the bank. Once the hours accumulated in the bank reach the limit, the system stops accruing the hours.
		/// <para>DAC: PX.Objects.PR.PREmployeeClassPTOBank</para>
		/// <para>Display Name: Balance Limit</para>
		/// </summary>
		[DataMember(Name="AccrualLimit", EmitDefaultValue=false)]
		public DecimalValue? AccrualLimit { get; set; }

		/// <summary>
		/// The method of PTO hours accrual that defines whether PTO hours should be calculated as a percentage or a specific number should be used for every pay period.
		/// <para>DAC: PX.Objects.PR.PRPTOBank</para>
		/// <para>Display Name: Accrual Method</para>
		/// <para>SQL Type: char(3)</para>
		/// </summary>
		[DataMember(Name="AccrualMethod", EmitDefaultValue=false)]
		public StringValue? AccrualMethod { get; set; }

		/// <summary>
		/// Indicates (if set to true) that hours are accumulated only for the earning lines withthe selected Certified check box in the released paycheck.
		/// <para>DAC Field Name: IsCertifiedJobAccrual</para>
		/// <para>DAC: PX.Objects.PR.PRPTOBank</para>
		/// <para>Display Name: Accrue Only on Certified Job</para>
		/// </summary>
		[DataMember(Name="AccrueonCertifiedJobOnly", EmitDefaultValue=false)]
		public BooleanValue? AccrueonCertifiedJobOnly { get; set; }

		/// <summary>
		/// Indicates (if set to true) that the PTO bank should be accruing during the paycheck process.
		/// <para>DAC Field Name: IsActive</para>
		/// <para>DAC: PX.Objects.PR.PRPTOBank</para>
		/// </summary>
		[DataMember(Name="Active", EmitDefaultValue=false)]
		public BooleanValue? Active { get; set; }

		/// <summary>
		/// Indicates (if set to true) that the system does not put restrictions on the disbursing amount.
		/// <para>DAC: PX.Objects.PR.PREmployeeClassPTOBank</para>
		/// <para>Display Name: Allow Negative Balance</para>
		/// </summary>
		[DataMember(Name="AllowNegativeBalance", EmitDefaultValue=false)]
		public BooleanValue? AllowNegativeBalance { get; set; }

		/// <summary>
		/// The date at which the system adds the front loading number of hours to an employee PTO bank. You specify the number of hours in the Front Loading Amount box on the General Settings tab.
		/// <para>DAC Field Name: StartDate</para>
		/// <para>DAC: PX.Objects.PR.PRPTOBank</para>
		/// <para>Display Name: Transfer Date</para>
		/// </summary>
		[DataMember(Name="BankStartDate", EmitDefaultValue=false)]
		public DateTimeValue? BankStartDate { get; set; }

		/// <summary>
		/// <para>DAC Field Name: DisburseFromCarryover</para>
		/// <para>DAC: PX.Objects.PR.PREmployeeClassPTOBank</para>
		/// <para>Display Name: Disburse Only from Carryover</para>
		/// </summary>
		[DataMember(Name="CanOnlyDisbursefromCarryover", EmitDefaultValue=false)]
		public BooleanValue? CanOnlyDisbursefromCarryover { get; set; }

		/// <summary>
		/// The number of hours the system carries over to the following year. This box is available only if Partial is selected in the Carryover Type box.
		/// <para>DAC: PX.Objects.PR.PREmployeeClassPTOBank</para>
		/// <para>Display Name: Carryover Hours</para>
		/// </summary>
		[DataMember(Name="CarryoverAmount", EmitDefaultValue=false)]
		public DecimalValue? CarryoverAmount { get; set; }

		/// <summary>
		/// The way accruals are to be carried over from year to year starting the date specified in the Start Date box.
		/// <para>DAC: PX.Objects.PR.PRPTOBank</para>
		/// <para>Display Name: Carryover Type</para>
		/// <para>SQL Type: char(1)</para>
		/// </summary>
		[DataMember(Name="CarryoverType", EmitDefaultValue=false)]
		public StringValue? CarryoverType { get; set; }

		/// <summary>
		/// Enable the money calculation and the creation of general ledger transaction for paid time off on Paychecks and Adjustments
		/// <para>DAC Field Name: CreateFinancialTransaction</para>
		/// <para>DAC: PX.Objects.PR.PRPTOBank</para>
		/// <para>Display Name: Create GL Transactions on Accrual</para>
		/// </summary>
		[DataMember(Name="CreateFinTransactions", EmitDefaultValue=false)]
		public BooleanValue? CreateFinTransactions { get; set; }

		/// <summary>
		/// An accrual rate to be used to accumulate hours.
		/// <para>DAC Field Name: AccrualRate</para>
		/// <para>DAC: PX.Objects.PR.PREmployeeClassPTOBank</para>
		/// <para>Display Name: Accrual %</para>
		/// </summary>
		[DataMember(Name="DefaultAccrualPercent", EmitDefaultValue=false)]
		public DecimalValue? DefaultAccrualPercent { get; set; }

		/// <summary>
		/// The disbursing type.
		/// <para>DAC Field Name: DisbursingType</para>
		/// <para>DAC: PX.Objects.PR.PRPTOBank</para>
		/// <para>Display Name: Default Disbursing Type</para>
		/// <para>SQL Type: char(1)</para>
		/// </summary>
		[DataMember(Name="DefaultDisbursingType", EmitDefaultValue=false)]
		public StringValue? DefaultDisbursingType { get; set; }

		/// <summary>
		/// The description.
		/// <para>DAC: PX.Objects.PR.PRPTOBank</para>
		/// <para>SQL Type: nvarchar(60)</para>
		/// </summary>
		[DataMember(Name="Description", EmitDefaultValue=false)]
		public StringValue? Description { get; set; }

		/// <summary>
		/// The user-friendly unique identifier of the earning type used for dispersal on a paycheck.The field is included in DisbursingEarningType.
		/// <para>DAC Field Name: EarningTypeCD</para>
		/// <para>DAC: PX.Objects.PR.PRPTOBank</para>
		/// <para>Display Name: Disbursing Earning Type</para>
		/// <para>SQL Type: nvarchar(15)</para>
		/// </summary>
		[DataMember(Name="DisbursingEarningCode", EmitDefaultValue=false)]
		public StringValue? DisbursingEarningCode { get; set; }

		/// <summary>
		/// The number of hours the system adds to the bank each year on a date specified in the Start Date box.
		/// <para>DAC: PX.Objects.PR.PREmployeeClassPTOBank</para>
		/// <para>Display Name: Front Loading Hours</para>
		/// </summary>
		[DataMember(Name="FrontLoadingAmount", EmitDefaultValue=false)]
		public DecimalValue? FrontLoadingAmount { get; set; }

		[DataMember(Name="GLAccounts", EmitDefaultValue=false)]
		public PTOBankGLAccounts? GLAccounts { get; set; }

		[DataMember(Name="LastModifiedDateTime", EmitDefaultValue=false)]
		public DateTimeValue? LastModifiedDateTime { get; set; }

		/// <summary>
		/// The rule that will be applied to the PTO bank when a final paycheck is calculated for an employee who is assigned this PTO bank.
		/// <para>DAC Field Name: SettlementBalanceType</para>
		/// <para>DAC: PX.Objects.PR.PRPTOBank</para>
		/// <para>Display Name: On Settlement</para>
		/// <para>SQL Type: char(3)</para>
		/// </summary>
		[DataMember(Name="OnSettlement", EmitDefaultValue=false)]
		public StringValue? OnSettlement { get; set; }

		[DataMember(Name="PayCarryoverafterMonths", EmitDefaultValue=false)]
		public IntValue? PayCarryoverafterMonths { get; set; }

		/// <summary>
		/// The unique identifier of a PTO bank to be used for the paid time off calculation.
		/// <para>DAC Field Name: BankID</para>
		/// <para>DAC: PX.Objects.PR.PRPTOBank</para>
		/// <para>Display Name: Bank ID</para>
		/// <para>SQL Type: nvarchar(15)</para>
		/// Key Field
		/// </summary>
		[DataMember(Name="PTOBankID", EmitDefaultValue=false)]
		public StringValue? PTOBankID { get; set; }

		public static class Expand
		{
			public const string Files = "Files";
			public const string GLAccounts = "GLAccounts";

			//Intentionally excluded
			//public const string All = "Files,GLAccounts";
		}
		public virtual string GetEndpointPath()
		{
			return "entity/Default/23.200.001";
		}
	}
}