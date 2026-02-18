using System;
using System.Collections.Generic;

using Newtonsoft.Json;

using Acumatica.RESTClient.Client;
using Acumatica.RESTClient.ContractBasedApi;
using Acumatica.RESTClient.ContractBasedApi.Model;

namespace Acumatica.Default_24_200_001.Model
{
	public class PTOBankEmployeeClassSetting : Entity
	{

		/// <summary>
		/// An accrual rate to be used to accumulate hours.
		/// <para>DAC Field Name: AccrualRate</para>
		/// <para>DAC: PX.Objects.PR.PREmployeeClassPTOBank</para>
		/// <para>Display Name: Accrual %</para>
		/// </summary>
		public DecimalValue? AccrualPercent { get; set; }

		/// <summary>
		/// Indicates (if set to true) that the PTO bank should be accruing during the paycheck process.
		/// <para>DAC Field Name: IsActive</para>
		/// <para>DAC: PX.Objects.PR.PRPTOBank</para>
		/// </summary>
		public BooleanValue? Active { get; set; }

		/// <summary>
		/// Indicates (if set to true) that the system does not put restrictions on the disbursing amount.
		/// <para>DAC: PX.Objects.PR.PREmployeeClassPTOBank</para>
		/// <para>Display Name: Allow Negative Balance</para>
		/// </summary>
		public BooleanValue? AllowNegativeBalance { get; set; }

		/// <summary>
		/// The upper limit for the bank. Once the hours accumulated in the bank reach the limit, the system stops accruing the hours.
		/// <para>DAC Field Name: AccrualLimit</para>
		/// <para>DAC: PX.Objects.PR.PREmployeeClassPTOBank</para>
		/// <para>Display Name: Balance Limit</para>
		/// </summary>
		public DecimalValue? BalanceLimit { get; set; }

		/// <summary>
		/// The number of hours the system carries over to the following year. This box is available only if Partial is selected in the Carryover Type box.
		/// <para>DAC Field Name: CarryoverAmount</para>
		/// <para>DAC: PX.Objects.PR.PREmployeeClassPTOBank</para>
		/// <para>Display Name: Carryover Hours</para>
		/// </summary>
		public DecimalValue? CarryoverHours { get; set; }

		/// <summary>
		/// <para>DAC Field Name: DisburseFromCarryover</para>
		/// <para>DAC: PX.Objects.PR.PREmployeeClassPTOBank</para>
		/// <para>Display Name: Disburse Only from Carryover</para>
		/// </summary>
		public BooleanValue? DisburseOnlyfromCarryover { get; set; }

		/// <summary>
		/// The date at which the system adds the front loading number of hours to an employee PTO bank. You specify the number of hours in the Front Loading Amount box on the General Settings tab.
		/// <para>DAC Field Name: StartDate</para>
		/// <para>DAC: PX.Objects.PR.PRPTOBank</para>
		/// <para>Display Name: Transfer Date</para>
		/// </summary>
		public DateTimeValue? EffectiveDate { get; set; }

		/// <summary>
		/// The unique identifier of an Employee Class.
		/// <para>DAC Field Name: EmployeeClassID</para>
		/// <para>DAC: PX.Objects.PR.PREmployeeClassPTOBank</para>
		/// <para>Display Name: Employee Class</para>
		/// <para>SQL Type: nvarchar(10)</para>
		/// </summary>
		public StringValue? EmployeeClass { get; set; }

		/// <summary>
		/// The number of hours the system adds to the bank each year on a date specified in the Start Date box.
		/// <para>DAC Field Name: FrontLoadingAmount</para>
		/// <para>DAC: PX.Objects.PR.PREmployeeClassPTOBank</para>
		/// <para>Display Name: Front Loading Hours</para>
		/// </summary>
		public DecimalValue? FrontLoadingHours { get; set; }

		/// <summary>
		/// The number of hours that an employee may accrue throughout the year.
		/// <para>DAC Field Name: HoursPerYear</para>
		/// <para>DAC: PX.Objects.PR.PREmployeeClassPTOBank</para>
		/// <para>Display Name: Hours per Year</para>
		/// </summary>
		public DecimalValue? HoursperYear { get; set; }

		public DateTimeValue? LastModifiedDateTime { get; set; }

		/// <summary>
		/// The probation period behaviour.
		/// <para>DAC: PX.Objects.PR.PREmployeeClassPTOBank</para>
		/// <para>Display Name: During Probation Period</para>
		/// <para>SQL Type: char(3)</para>
		/// </summary>
		public StringValue? ProbationPeriodBehaviour { get; set; }

	}
}