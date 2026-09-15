using System;
using System.Collections.Generic;
using System.Runtime.Serialization;

using Newtonsoft.Json;

using Acumatica.RESTClient.Client;
using Acumatica.RESTClient.ContractBasedApi;
using Acumatica.RESTClient.ContractBasedApi.Model;

namespace Acumatica.Default_26_200_001.Model
{
	/// <summary>
	/// Corresponds to the screen <c>PR301000</c> in the Acumatica ERP
	/// <para>Key Fields: BatchID</para>
	/// </summary>
	[DataContract]
	public class PayrollBatch : Entity, ITopLevelEntity
	{

		/// <summary>
		/// <para>DAC Field Name: BatchNbr</para>
		/// <para>DAC: PX.Objects.PR.PRBatch</para>
		/// <para>Display Name: Batch ID</para>
		/// <para>SQL Type: nvarchar(15)</para>
		/// Key Field
		/// </summary>
		[DataMember(Name="BatchID", EmitDefaultValue=false)]
		public StringValue? BatchID { get; set; }

		[DataMember(Name="DeductionsAndBenefitsDetails", EmitDefaultValue=false)]
		public List<BatchDeductionOrBenefitDetail>? DeductionsAndBenefitsDetails { get; set; }

		/// <summary>
		/// <para>DAC Field Name: DocDesc</para>
		/// <para>DAC: PX.Objects.PR.PRBatch</para>
		/// <para>SQL Type: nvarchar(128)</para>
		/// </summary>
		[DataMember(Name="Description", EmitDefaultValue=false)]
		public StringValue? Description { get; set; }

		[DataMember(Name="EarningDetails", EmitDefaultValue=false)]
		public List<BatchEarningDetail>? EarningDetails { get; set; }

		[DataMember(Name="EmployeeSummary", EmitDefaultValue=false)]
		public List<EmployeePaycheckSummary>? EmployeeSummary { get; set; }

		/// <summary>
		/// When set to <c>true</c> indicates that the document is on hold and thus cannot be released.
		/// <para>DAC: PX.Objects.PR.PRBatch</para>
		/// </summary>
		[DataMember(Name="Hold", EmitDefaultValue=false)]
		public BooleanValue? Hold { get; set; }

		[DataMember(Name="LastModifiedDateTime", EmitDefaultValue=false)]
		public DateTimeValue? LastModifiedDateTime { get; set; }

		/// <summary>
		/// <para>DAC Field Name: NumberOfEmployees</para>
		/// <para>DAC: PX.Objects.PR.PRBatch</para>
		/// <para>Display Name: Number of Employees</para>
		/// </summary>
		[DataMember(Name="NumberofEmployees", EmitDefaultValue=false)]
		public IntValue? NumberofEmployees { get; set; }

		[DataMember(Name="OvertimeRules", EmitDefaultValue=false)]
		public BatchOvertimeRules? OvertimeRules { get; set; }

		/// <summary>
		/// <para>DAC Field Name: PayGroupID</para>
		/// <para>DAC: PX.Objects.PR.PRBatch</para>
		/// <para>Display Name: Pay Group</para>
		/// <para>SQL Type: nvarchar(15)</para>
		/// </summary>
		[DataMember(Name="PayGroup", EmitDefaultValue=false)]
		public StringValue? PayGroup { get; set; }

		/// <summary>
		/// <para>DAC Field Name: PayPeriodID</para>
		/// <para>DAC: PX.Objects.PR.PRBatch</para>
		/// <para>Display Name: Pay Period</para>
		/// <para>SQL Type: char(6)</para>
		/// </summary>
		[DataMember(Name="PayPeriod", EmitDefaultValue=false)]
		public StringValue? PayPeriod { get; set; }

		/// <summary>
		/// <para>DAC: PX.Objects.PR.PRBatchTotalsFilter</para>
		/// <para>Display Name: Total Earnings</para>
		/// </summary>
		[DataMember(Name="TotalEarnings", EmitDefaultValue=false)]
		public DecimalValue? TotalEarnings { get; set; }

		/// <summary>
		/// <para>DAC: PX.Objects.PR.PRBatchTotalsFilter</para>
		/// <para>Display Name: Total Hour Qty</para>
		/// </summary>
		[DataMember(Name="TotalHourQty", EmitDefaultValue=false)]
		public DecimalValue? TotalHourQty { get; set; }

		/// <summary>
		/// <para>DAC: PX.Objects.PR.PRBatch</para>
		/// <para>Display Name: Payroll Type</para>
		/// <para>SQL Type: char(3)</para>
		/// </summary>
		[DataMember(Name="PayrollType", EmitDefaultValue=false)]
		public StringValue? PayrollType { get; set; }

		/// <summary>
		/// <para>DAC Field Name: EndDate</para>
		/// <para>DAC: PX.Objects.PR.PRBatch</para>
		/// <para>Display Name: Period End</para>
		/// </summary>
		[DataMember(Name="PeriodEnd", EmitDefaultValue=false)]
		public DateTimeValue? PeriodEnd { get; set; }

		/// <summary>
		/// <para>DAC Field Name: StartDate</para>
		/// <para>DAC: PX.Objects.PR.PRBatch</para>
		/// <para>Display Name: Period Start</para>
		/// </summary>
		[DataMember(Name="PeriodStart", EmitDefaultValue=false)]
		public DateTimeValue? PeriodStart { get; set; }

		/// <summary>
		/// <para>DAC: PX.Objects.PR.PRBatch</para>
		/// <para>SQL Type: char(3)</para>
		/// </summary>
		[DataMember(Name="Status", EmitDefaultValue=false)]
		public StringSingleSelectValue? Status { get; set; }

		/// <summary>
		/// <para>DAC: PX.Objects.PR.PRBatch</para>
		/// <para>Display Name: Transaction Date</para>
		/// </summary>
		[DataMember(Name="TransactionDate", EmitDefaultValue=false)]
		public DateTimeValue? TransactionDate { get; set; }

		/// <summary>
		/// Names that can be passed in the <c>$expand</c> parameter.
		/// <para>This endpoint uses system contract 5, where a nested entity is expanded
		/// as <c>Parent($expand=Child)</c> rather than <c>Parent/Child</c>, so only the names
		/// that can be expanded directly on this entity are listed here. Use the nested
		/// entity's own <c>Expand</c> class for the inner names.</para>
		/// </summary>
		public static class Expand
		{
			public const string Files = "Files";
			public const string Translations = "Translations";
			public const string DeductionsAndBenefitsDetails = "DeductionsAndBenefitsDetails";
			public const string EarningDetails = "EarningDetails";
			public const string EmployeeSummary = "EmployeeSummary";
			public const string OvertimeRules = "OvertimeRules";

			//Intentionally excluded
			//public const string All = "Files,Translations,DeductionsAndBenefitsDetails,EarningDetails,EmployeeSummary,OvertimeRules";
		}
		public virtual string GetEndpointPath()
		{
			return "entity/Default/26.200.001";
		}
	}
}