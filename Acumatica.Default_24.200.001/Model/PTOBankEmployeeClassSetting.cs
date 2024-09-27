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
	public class PTOBankEmployeeClassSetting : Entity
	{

		/// <summary>
		/// An accrual rate to be used to accumulate hours.
		/// DAC Field Name: AccrualRate 
		/// DAC: PX.Objects.PR.PREmployeeClassPTOBank 
		/// Display Name: Accrual % 
		/// </summary>
		[DataMember(Name="AccrualPercent", EmitDefaultValue=false)]
		public DecimalValue? AccrualPercent { get; set; }

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
		/// The upper limit for the bank. Once the hours accumulated in the bank reach the limit, the system stops accruing the hours.
		/// DAC Field Name: AccrualLimit 
		/// DAC: PX.Objects.PR.PREmployeeClassPTOBank 
		/// Display Name: Balance Limit 
		/// </summary>
		[DataMember(Name="BalanceLimit", EmitDefaultValue=false)]
		public DecimalValue? BalanceLimit { get; set; }

		/// <summary>
		/// The number of hours the system carries over to the following year. This box is available only if Partial is selected in the Carryover Type box.
		/// DAC Field Name: CarryoverAmount 
		/// DAC: PX.Objects.PR.PREmployeeClassPTOBank 
		/// Display Name: Carryover Hours 
		/// </summary>
		[DataMember(Name="CarryoverHours", EmitDefaultValue=false)]
		public DecimalValue? CarryoverHours { get; set; }

		/// <summary>
		/// DAC Field Name: DisburseFromCarryover 
		/// DAC: PX.Objects.PR.PREmployeeClassPTOBank 
		/// Display Name: Disburse Only from Carryover 
		/// </summary>
		[DataMember(Name="DisburseOnlyfromCarryover", EmitDefaultValue=false)]
		public BooleanValue? DisburseOnlyfromCarryover { get; set; }

		/// <summary>
		/// The date at which the system adds the front loading number of hours to an employee PTO bank. You specify the number of hours in the Front Loading Amount box on the General Settings tab.
		/// DAC Field Name: StartDate 
		/// DAC: PX.Objects.PR.PRPTOBank 
		/// Display Name: Transfer Date 
		/// </summary>
		[DataMember(Name="EffectiveDate", EmitDefaultValue=false)]
		public DateTimeValue? EffectiveDate { get; set; }

		/// <summary>
		/// The unique identifier of an Employee Class.
		/// DAC Field Name: EmployeeClassID 
		/// DAC: PX.Objects.PR.PREmployeeClassPTOBank 
		/// Display Name: Employee Class 
		/// SQL Type: nvarchar(10) 
		/// </summary>
		[DataMember(Name="EmployeeClass", EmitDefaultValue=false)]
		public StringValue? EmployeeClass { get; set; }

		/// <summary>
		/// The number of hours the system adds to the bank each year on a date specified in the Start Date box.
		/// DAC Field Name: FrontLoadingAmount 
		/// DAC: PX.Objects.PR.PREmployeeClassPTOBank 
		/// Display Name: Front Loading Hours 
		/// </summary>
		[DataMember(Name="FrontLoadingHours", EmitDefaultValue=false)]
		public DecimalValue? FrontLoadingHours { get; set; }

		/// <summary>
		/// The number of hours that an employee may accrue throughout the year.
		/// DAC Field Name: HoursPerYear 
		/// DAC: PX.Objects.PR.PREmployeeClassPTOBank 
		/// Display Name: Hours per Year 
		/// </summary>
		[DataMember(Name="HoursperYear", EmitDefaultValue=false)]
		public DecimalValue? HoursperYear { get; set; }

		[DataMember(Name="LastModifiedDateTime", EmitDefaultValue=false)]
		public DateTimeValue? LastModifiedDateTime { get; set; }

		/// <summary>
		/// The probation period behaviour.
		/// DAC: PX.Objects.PR.PREmployeeClassPTOBank 
		/// Display Name: During Probation Period 
		/// SQL Type: char(3) 
		/// </summary>
		[DataMember(Name="ProbationPeriodBehaviour", EmitDefaultValue=false)]
		public StringValue? ProbationPeriodBehaviour { get; set; }

	}
}