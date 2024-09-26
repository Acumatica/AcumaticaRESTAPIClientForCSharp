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
	/// Corresponds to the screen PR301000 in the Acumatica ERP
	/// </summary>
	[DataContract]
	public class PayrollBatch : Entity, ITopLevelEntity
	{

		/// <summary>
		/// 
		/// Display Name:
		/// DAC Field Name: BatchNbr 
		/// DAC: PX.Objects.PR.PRBatch 
		/// </summary>
		/// <remarks>
		/// 
		/// </remarks>
		[DataMember(Name="BatchID", EmitDefaultValue=false)]
		public StringValue? BatchID { get; set; }

		[DataMember(Name="DeductionsAndBenefitsDetails", EmitDefaultValue=false)]
		public List<BatchDeductionOrBenefitDetail>? DeductionsAndBenefitsDetails { get; set; }

		/// <summary>
		/// 
		/// Display Name:
		/// DAC Field Name: DocDesc 
		/// DAC: PX.Objects.PR.PRBatch 
		/// </summary>
		/// <remarks>
		/// 
		/// </remarks>
		[DataMember(Name="Description", EmitDefaultValue=false)]
		public StringValue? Description { get; set; }

		[DataMember(Name="EarningDetails", EmitDefaultValue=false)]
		public List<BatchEarningDetail>? EarningDetails { get; set; }

		[DataMember(Name="EmployeeSummary", EmitDefaultValue=false)]
		public List<EmployeePaycheckSummary>? EmployeeSummary { get; set; }

		/// <summary>
		/// 
		/// Display Name:
		/// DAC Field Name: Hold 
		/// DAC: PX.Objects.PR.PRBatch 
		/// </summary>
		/// <remarks>
		/// 
		/// </remarks>
		[DataMember(Name="Hold", EmitDefaultValue=false)]
		public BooleanValue? Hold { get; set; }

		[DataMember(Name="LastModifiedDateTime", EmitDefaultValue=false)]
		public DateTimeValue? LastModifiedDateTime { get; set; }

		/// <summary>
		/// 
		/// Display Name:
		/// DAC Field Name: NumberOfEmployees 
		/// DAC: PX.Objects.PR.PRBatch 
		/// </summary>
		/// <remarks>
		/// 
		/// </remarks>
		[DataMember(Name="NumberofEmployees", EmitDefaultValue=false)]
		public IntValue? NumberofEmployees { get; set; }

		[DataMember(Name="OvertimeRules", EmitDefaultValue=false)]
		public BatchOvertimeRules? OvertimeRules { get; set; }

		/// <summary>
		/// 
		/// Display Name:
		/// DAC Field Name: PayGroupID 
		/// DAC: PX.Objects.PR.PRBatch 
		/// </summary>
		/// <remarks>
		/// 
		/// </remarks>
		[DataMember(Name="PayGroup", EmitDefaultValue=false)]
		public StringValue? PayGroup { get; set; }

		/// <summary>
		/// 
		/// Display Name:
		/// DAC Field Name: PayPeriodID 
		/// DAC: PX.Objects.PR.PRBatch 
		/// </summary>
		/// <remarks>
		/// 
		/// </remarks>
		[DataMember(Name="PayPeriod", EmitDefaultValue=false)]
		public StringValue? PayPeriod { get; set; }

		/// <summary>
		/// 
		/// Display Name:
		/// DAC Field Name: TotalEarnings 
		/// DAC: PX.Objects.PR.PRBatchTotalsFilter 
		/// </summary>
		/// <remarks>
		/// 
		/// </remarks>
		[DataMember(Name="TotalEarnings", EmitDefaultValue=false)]
		public DecimalValue? TotalEarnings { get; set; }

		/// <summary>
		/// 
		/// Display Name:
		/// DAC Field Name: TotalHourQty 
		/// DAC: PX.Objects.PR.PRBatchTotalsFilter 
		/// </summary>
		/// <remarks>
		/// 
		/// </remarks>
		[DataMember(Name="TotalHourQty", EmitDefaultValue=false)]
		public DecimalValue? TotalHourQty { get; set; }

		/// <summary>
		/// 
		/// Display Name:
		/// DAC Field Name: PayrollType 
		/// DAC: PX.Objects.PR.PRBatch 
		/// </summary>
		/// <remarks>
		/// 
		/// </remarks>
		[DataMember(Name="PayrollType", EmitDefaultValue=false)]
		public StringValue? PayrollType { get; set; }

		/// <summary>
		/// 
		/// Display Name:
		/// DAC Field Name: EndDate 
		/// DAC: PX.Objects.PR.PRBatch 
		/// </summary>
		/// <remarks>
		/// 
		/// </remarks>
		[DataMember(Name="PeriodEnd", EmitDefaultValue=false)]
		public DateTimeValue? PeriodEnd { get; set; }

		/// <summary>
		/// 
		/// Display Name:
		/// DAC Field Name: StartDate 
		/// DAC: PX.Objects.PR.PRBatch 
		/// </summary>
		/// <remarks>
		/// 
		/// </remarks>
		[DataMember(Name="PeriodStart", EmitDefaultValue=false)]
		public DateTimeValue? PeriodStart { get; set; }

		/// <summary>
		/// 
		/// Display Name:
		/// DAC Field Name: Status 
		/// DAC: PX.Objects.PR.PRBatch 
		/// </summary>
		/// <remarks>
		/// 
		/// </remarks>
		[DataMember(Name="Status", EmitDefaultValue=false)]
		public StringValue? Status { get; set; }

		/// <summary>
		/// 
		/// Display Name:
		/// DAC Field Name: TransactionDate 
		/// DAC: PX.Objects.PR.PRBatch 
		/// </summary>
		/// <remarks>
		/// 
		/// </remarks>
		[DataMember(Name="TransactionDate", EmitDefaultValue=false)]
		public DateTimeValue? TransactionDate { get; set; }

		public virtual string GetEndpointPath()
		{
			return "entity/Default/23.200.001";
		}
	}
}