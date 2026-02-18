using System;
using System.Collections.Generic;

using Newtonsoft.Json;

using Acumatica.RESTClient.Client;
using Acumatica.RESTClient.ContractBasedApi;
using Acumatica.RESTClient.ContractBasedApi.Model;

namespace Acumatica.Default_25_200_001.Model
{
	/// <summary>
	/// Corresponds to the screen <c>PR301000</c> in the Acumatica ERP
	/// <para>Key Fields: BatchID</para>
	/// </summary>
	public class PayrollBatch : Entity, ITopLevelEntity
	{

		/// <summary>
		/// <para>DAC Field Name: BatchNbr</para>
		/// <para>DAC: PX.Objects.PR.PRBatch</para>
		/// <para>Display Name: Batch ID</para>
		/// <para>SQL Type: nvarchar(15)</para>
		/// Key Field
		/// </summary>
		public StringValue? BatchID { get; set; }

		public List<BatchDeductionOrBenefitDetail>? DeductionsAndBenefitsDetails { get; set; }

		/// <summary>
		/// <para>DAC Field Name: DocDesc</para>
		/// <para>DAC: PX.Objects.PR.PRBatch</para>
		/// <para>SQL Type: nvarchar(128)</para>
		/// </summary>
		public StringValue? Description { get; set; }

		public List<BatchEarningDetail>? EarningDetails { get; set; }

		public List<EmployeePaycheckSummary>? EmployeeSummary { get; set; }

		/// <summary>
		/// When set to true indicates that the document is on hold and thus cannot be released.
		/// <para>DAC: PX.Objects.PR.PRBatch</para>
		/// </summary>
		public BooleanValue? Hold { get; set; }

		public DateTimeValue? LastModifiedDateTime { get; set; }

		/// <summary>
		/// <para>DAC Field Name: NumberOfEmployees</para>
		/// <para>DAC: PX.Objects.PR.PRBatch</para>
		/// <para>Display Name: Number of Employees</para>
		/// </summary>
		public IntValue? NumberofEmployees { get; set; }

		public BatchOvertimeRules? OvertimeRules { get; set; }

		/// <summary>
		/// <para>DAC Field Name: PayGroupID</para>
		/// <para>DAC: PX.Objects.PR.PRBatch</para>
		/// <para>Display Name: Pay Group</para>
		/// <para>SQL Type: nvarchar(15)</para>
		/// </summary>
		public StringValue? PayGroup { get; set; }

		/// <summary>
		/// <para>DAC Field Name: PayPeriodID</para>
		/// <para>DAC: PX.Objects.PR.PRBatch</para>
		/// <para>Display Name: Pay Period</para>
		/// <para>SQL Type: char(6)</para>
		/// </summary>
		public StringValue? PayPeriod { get; set; }

		/// <summary>
		/// <para>DAC: PX.Objects.PR.PRBatchTotalsFilter</para>
		/// <para>Display Name: Total Earnings</para>
		/// </summary>
		public DecimalValue? TotalEarnings { get; set; }

		/// <summary>
		/// <para>DAC: PX.Objects.PR.PRBatchTotalsFilter</para>
		/// <para>Display Name: Total Hour Qty</para>
		/// </summary>
		public DecimalValue? TotalHourQty { get; set; }

		/// <summary>
		/// <para>DAC: PX.Objects.PR.PRBatch</para>
		/// <para>Display Name: Payroll Type</para>
		/// <para>SQL Type: char(3)</para>
		/// </summary>
		public StringValue? PayrollType { get; set; }

		/// <summary>
		/// <para>DAC Field Name: EndDate</para>
		/// <para>DAC: PX.Objects.PR.PRBatch</para>
		/// <para>Display Name: Period End</para>
		/// </summary>
		public DateTimeValue? PeriodEnd { get; set; }

		/// <summary>
		/// <para>DAC Field Name: StartDate</para>
		/// <para>DAC: PX.Objects.PR.PRBatch</para>
		/// <para>Display Name: Period Start</para>
		/// </summary>
		public DateTimeValue? PeriodStart { get; set; }

		/// <summary>
		/// <para>DAC: PX.Objects.PR.PRBatch</para>
		/// <para>SQL Type: char(3)</para>
		/// </summary>
		public StringValue? Status { get; set; }

		/// <summary>
		/// <para>DAC: PX.Objects.PR.PRBatch</para>
		/// <para>Display Name: Transaction Date</para>
		/// </summary>
		public DateTimeValue? TransactionDate { get; set; }

		public static class Expand
		{
			public const string Files = "Files";
			public const string Translations = "Translations";
			public const string DeductionsAndBenefitsDetails = "DeductionsAndBenefitsDetails";
			public const string DeductionsAndBenefitsDetails_Files = "DeductionsAndBenefitsDetails/Files";
			public const string EarningDetails = "EarningDetails";
			public const string EarningDetails_Files = "EarningDetails/Files";
			public const string EmployeeSummary = "EmployeeSummary";
			public const string EmployeeSummary_Files = "EmployeeSummary/Files";
			public const string EmployeeSummary_EmployeePaycheckEarnings = "EmployeeSummary/EmployeePaycheckEarnings";
			public const string OvertimeRules = "OvertimeRules";
			public const string OvertimeRules_OvertimeRulesDetails = "OvertimeRules/OvertimeRulesDetails";
			public const string OvertimeRules_OvertimeRulesDetails_Files = "OvertimeRules/OvertimeRulesDetails/Files";

			//Intentionally excluded
			//public const string All = "Files,Translations,DeductionsAndBenefitsDetails,DeductionsAndBenefitsDetails/Files,EarningDetails,EarningDetails/Files,EmployeeSummary,EmployeeSummary/Files,EmployeeSummary/EmployeePaycheckEarnings,OvertimeRules,OvertimeRules/OvertimeRulesDetails,OvertimeRules/OvertimeRulesDetails/Files";
		}
		public virtual string GetEndpointPath()
		{
			return "entity/Default/25.200.001";
		}
	}
}