using System;
using System.Collections.Generic;
using System.Runtime.Serialization;

using Newtonsoft.Json;

using Acumatica.RESTClient.Client;
using Acumatica.RESTClient.ContractBasedApi;
using Acumatica.RESTClient.ContractBasedApi.Model;

namespace Acumatica.Default_22_200_001.Model
{
	/// <summary>
	/// Corresponds to the screen PR204000 in the Acumatica ERP
	/// </summary>
	[DataContract]
	public class PTOBank : Entity, ITopLevelEntity
	{

		/// <summary>
		/// The upper limit for the bank. Once the hours accumulated in the bank reach the limit, the system stops accruing the hours.
		/// DAC: PX.Objects.PR.PREmployeeClassPTOBank 
		/// Display Name: Balance Limit 
		/// </summary>
		[DataMember(Name="AccrualLimit", EmitDefaultValue=false)]
		public DecimalValue? AccrualLimit { get; set; }

		/// <summary>
		/// The method of PTO hours accrual that defines whether PTO hours should be calculated as a percentage or a specific number should be used for every pay period.
		/// DAC: PX.Objects.PR.PRPTOBank 
		/// Display Name: Accrual Method 
		/// SQL Type: char(3) 
		/// </summary>
		[DataMember(Name="AccrualMethod", EmitDefaultValue=false)]
		public StringValue? AccrualMethod { get; set; }

		/// <summary>
		/// Indicates (if set to true) that hours are accumulated only for the earning lines withthe selected Certified check box in the released paycheck.
		/// DAC Field Name: IsCertifiedJobAccrual 
		/// DAC: PX.Objects.PR.PRPTOBank 
		/// Display Name: Accrue Only on Certified Job 
		/// </summary>
		[DataMember(Name="AccrueonCertifiedJobOnly", EmitDefaultValue=false)]
		public BooleanValue? AccrueonCertifiedJobOnly { get; set; }

		/// <summary>
		/// Indicates (if set to true) that the PTO bank should be accruing during the paycheck process.
		/// DAC Field Name: IsActive 
		/// DAC: PX.Objects.PR.PRPTOBank 
		/// </summary>
		[DataMember(Name="Active", EmitDefaultValue=false)]
		public BooleanValue? Active { get; set; }

		/// <summary>
		/// Indicates (if set to true) that the system does not put restrictions on the disbursing amount.
		/// DAC: PX.Objects.PR.PREmployeeClassPTOBank 
		/// Display Name: Allow Negative Balance 
		/// </summary>
		[DataMember(Name="AllowNegativeBalance", EmitDefaultValue=false)]
		public BooleanValue? AllowNegativeBalance { get; set; }

		/// <summary>
		/// The date at which the system adds the front loading number of hours to an employee PTO bank. You specify the number of hours in the Front Loading Amount box on the General Settings tab.
		/// DAC Field Name: StartDate 
		/// DAC: PX.Objects.PR.PRPTOBank 
		/// Display Name: Transfer Date 
		/// </summary>
		[DataMember(Name="BankStartDate", EmitDefaultValue=false)]
		public DateTimeValue? BankStartDate { get; set; }

		/// <summary>
		/// DAC Field Name: DisburseFromCarryover 
		/// DAC: PX.Objects.PR.PREmployeeClassPTOBank 
		/// Display Name: Disburse Only from Carryover 
		/// </summary>
		[DataMember(Name="CanOnlyDisbursefromCarryover", EmitDefaultValue=false)]
		public BooleanValue? CanOnlyDisbursefromCarryover { get; set; }

		/// <summary>
		/// The number of hours the system carries over to the following year. This box is available only if Partial is selected in the Carryover Type box.
		/// DAC: PX.Objects.PR.PREmployeeClassPTOBank 
		/// Display Name: Carryover Hours 
		/// </summary>
		[DataMember(Name="CarryoverAmount", EmitDefaultValue=false)]
		public DecimalValue? CarryoverAmount { get; set; }

		/// <summary>
		/// The way accruals are to be carried over from year to year starting the date specified in the Start Date box.
		/// DAC: PX.Objects.PR.PRPTOBank 
		/// Display Name: Carryover Type 
		/// SQL Type: char(1) 
		/// </summary>
		[DataMember(Name="CarryoverType", EmitDefaultValue=false)]
		public StringValue? CarryoverType { get; set; }

		/// <summary>
		/// Enable the money calculation and the creation of general ledger transaction for paid time off on Paychecks and Adjustments
		/// DAC Field Name: CreateFinancialTransaction 
		/// DAC: PX.Objects.PR.PRPTOBank 
		/// Display Name: Create GL Transactions on Accrual 
		/// </summary>
		[DataMember(Name="CreateFinTransactions", EmitDefaultValue=false)]
		public BooleanValue? CreateFinTransactions { get; set; }

		/// <summary>
		/// An accrual rate to be used to accumulate hours.
		/// DAC Field Name: AccrualRate 
		/// DAC: PX.Objects.PR.PREmployeeClassPTOBank 
		/// Display Name: Accrual % 
		/// </summary>
		[DataMember(Name="DefaultAccrualPercent", EmitDefaultValue=false)]
		public DecimalValue? DefaultAccrualPercent { get; set; }

		/// <summary>
		/// The disbursing type.
		/// DAC Field Name: DisbursingType 
		/// DAC: PX.Objects.PR.PRPTOBank 
		/// Display Name: Default Disbursing Type 
		/// SQL Type: char(1) 
		/// </summary>
		[DataMember(Name="DefaultDisbursingType", EmitDefaultValue=false)]
		public StringValue? DefaultDisbursingType { get; set; }

		/// <summary>
		/// The description.
		/// DAC: PX.Objects.PR.PRPTOBank 
		/// SQL Type: nvarchar(60) 
		/// </summary>
		[DataMember(Name="Description", EmitDefaultValue=false)]
		public StringValue? Description { get; set; }

		/// <summary>
		/// The user-friendly unique identifier of the earning type used for dispersal on a paycheck.The field is included in DisbursingEarningType.
		/// DAC Field Name: EarningTypeCD 
		/// DAC: PX.Objects.PR.PRPTOBank 
		/// Display Name: Disbursing Earning Type 
		/// SQL Type: nvarchar(15) 
		/// </summary>
		[DataMember(Name="DisbursingEarningCode", EmitDefaultValue=false)]
		public StringValue? DisbursingEarningCode { get; set; }

		/// <summary>
		/// The number of hours the system adds to the bank each year on a date specified in the Start Date box.
		/// DAC: PX.Objects.PR.PREmployeeClassPTOBank 
		/// Display Name: Front Loading Hours 
		/// </summary>
		[DataMember(Name="FrontLoadingAmount", EmitDefaultValue=false)]
		public DecimalValue? FrontLoadingAmount { get; set; }

		[DataMember(Name="GLAccounts", EmitDefaultValue=false)]
		public PTOBankGLAccounts? GLAccounts { get; set; }

		[DataMember(Name="LastModifiedDateTime", EmitDefaultValue=false)]
		public DateTimeValue? LastModifiedDateTime { get; set; }

		/// <summary>
		/// The rule that will be applied to the PTO bank when a final paycheck is calculated for an employee who is assigned this PTO bank.
		/// DAC Field Name: SettlementBalanceType 
		/// DAC: PX.Objects.PR.PRPTOBank 
		/// Display Name: On Settlement 
		/// SQL Type: char(3) 
		/// </summary>
		[DataMember(Name="OnSettlement", EmitDefaultValue=false)]
		public StringValue? OnSettlement { get; set; }

		[DataMember(Name="PayCarryoverafterMonths", EmitDefaultValue=false)]
		public IntValue? PayCarryoverafterMonths { get; set; }

		/// <summary>
		/// The unique identifier of a PTO bank to be used for the paid time off calculation.
		/// DAC Field Name: BankID 
		/// DAC: PX.Objects.PR.PRPTOBank 
		/// Display Name: Bank ID 
		/// SQL Type: nvarchar(15) 
		/// Key Field
		/// </summary>
		[DataMember(Name="PTOBankID", EmitDefaultValue=false)]
		public StringValue? PTOBankID { get; set; }

		public virtual string GetEndpointPath()
		{
			return "entity/Default/22.200.001";
		}
	}
}