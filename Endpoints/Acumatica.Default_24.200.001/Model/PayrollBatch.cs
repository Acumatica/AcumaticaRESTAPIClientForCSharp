using System;
using System.Collections.Generic;
using System.Runtime.Serialization;

using Newtonsoft.Json;

using Acumatica.RESTClient.Client;
using Acumatica.RESTClient.ContractBasedApi;
using Acumatica.RESTClient.ContractBasedApi.Model;

namespace Acumatica.Default_24_200_001.Model
{
	/// <summary>
	/// Corresponds to the screen PR301000 in the Acumatica ERP
	/// </summary>
	[DataContract]
	public class PayrollBatch : Entity, ITopLevelEntity
	{

		/// <summary>
		/// DAC Field Name: BatchNbr 
		/// DAC: PX.Objects.PR.PRBatch 
		/// Display Name: Batch ID 
		/// SQL Type: nvarchar(15) 
		/// Key Field
		/// </summary>
		[DataMember(Name="BatchID", EmitDefaultValue=false)]
		public StringValue? BatchID { get; set; }

		[DataMember(Name="DeductionsAndBenefitsDetails", EmitDefaultValue=false)]
		public List<BatchDeductionOrBenefitDetail>? DeductionsAndBenefitsDetails { get; set; }

		/// <summary>
		/// DAC Field Name: DocDesc 
		/// DAC: PX.Objects.PR.PRBatch 
		/// SQL Type: nvarchar(128) 
		/// </summary>
		[DataMember(Name="Description", EmitDefaultValue=false)]
		public StringValue? Description { get; set; }

		[DataMember(Name="EarningDetails", EmitDefaultValue=false)]
		public List<BatchEarningDetail>? EarningDetails { get; set; }

		[DataMember(Name="EmployeeSummary", EmitDefaultValue=false)]
		public List<EmployeePaycheckSummary>? EmployeeSummary { get; set; }

		/// <summary>
		/// When set to true indicates that the document is on hold and thus cannot be released.
		/// DAC: PX.Objects.PR.PRBatch 
		/// </summary>
		[DataMember(Name="Hold", EmitDefaultValue=false)]
		public BooleanValue? Hold { get; set; }

		[DataMember(Name="LastModifiedDateTime", EmitDefaultValue=false)]
		public DateTimeValue? LastModifiedDateTime { get; set; }

		/// <summary>
		/// DAC Field Name: NumberOfEmployees 
		/// DAC: PX.Objects.PR.PRBatch 
		/// Display Name: Number of Employees 
		/// </summary>
		[DataMember(Name="NumberofEmployees", EmitDefaultValue=false)]
		public IntValue? NumberofEmployees { get; set; }

		[DataMember(Name="OvertimeRules", EmitDefaultValue=false)]
		public BatchOvertimeRules? OvertimeRules { get; set; }

		/// <summary>
		/// DAC Field Name: PayGroupID 
		/// DAC: PX.Objects.PR.PRBatch 
		/// Display Name: Pay Group 
		/// SQL Type: nvarchar(15) 
		/// </summary>
		[DataMember(Name="PayGroup", EmitDefaultValue=false)]
		public StringValue? PayGroup { get; set; }

		/// <summary>
		/// DAC Field Name: PayPeriodID 
		/// DAC: PX.Objects.PR.PRBatch 
		/// Display Name: Pay Period 
		/// SQL Type: char(6) 
		/// </summary>
		[DataMember(Name="PayPeriod", EmitDefaultValue=false)]
		public StringValue? PayPeriod { get; set; }

		/// <summary>
		/// DAC: PX.Objects.PR.PRBatchTotalsFilter 
		/// Display Name: Total Earnings 
		/// </summary>
		[DataMember(Name="TotalEarnings", EmitDefaultValue=false)]
		public DecimalValue? TotalEarnings { get; set; }

		/// <summary>
		/// DAC: PX.Objects.PR.PRBatchTotalsFilter 
		/// Display Name: Total Hour Qty 
		/// </summary>
		[DataMember(Name="TotalHourQty", EmitDefaultValue=false)]
		public DecimalValue? TotalHourQty { get; set; }

		/// <summary>
		/// DAC: PX.Objects.PR.PRBatch 
		/// Display Name: Payroll Type 
		/// SQL Type: char(3) 
		/// </summary>
		[DataMember(Name="PayrollType", EmitDefaultValue=false)]
		public StringValue? PayrollType { get; set; }

		/// <summary>
		/// DAC Field Name: EndDate 
		/// DAC: PX.Objects.PR.PRBatch 
		/// Display Name: Period End 
		/// </summary>
		[DataMember(Name="PeriodEnd", EmitDefaultValue=false)]
		public DateTimeValue? PeriodEnd { get; set; }

		/// <summary>
		/// DAC Field Name: StartDate 
		/// DAC: PX.Objects.PR.PRBatch 
		/// Display Name: Period Start 
		/// </summary>
		[DataMember(Name="PeriodStart", EmitDefaultValue=false)]
		public DateTimeValue? PeriodStart { get; set; }

		/// <summary>
		/// DAC: PX.Objects.PR.PRBatch 
		/// SQL Type: char(3) 
		/// </summary>
		[DataMember(Name="Status", EmitDefaultValue=false)]
		public StringValue? Status { get; set; }

		/// <summary>
		/// DAC: PX.Objects.PR.PRBatch 
		/// Display Name: Transaction Date 
		/// </summary>
		[DataMember(Name="TransactionDate", EmitDefaultValue=false)]
		public DateTimeValue? TransactionDate { get; set; }

		public virtual string GetEndpointPath()
		{
			return "entity/Default/24.200.001";
		}
	}
}