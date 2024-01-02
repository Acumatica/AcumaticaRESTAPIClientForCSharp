using System;
using System.Collections.Generic;
using System.Runtime.Serialization;

using Newtonsoft.Json;

using Acumatica.RESTClient.Client;
using Acumatica.RESTClient.ContractBasedApi;
using Acumatica.RESTClient.ContractBasedApi.Model;

namespace Acumatica.eCommerce_22_200_001.Model
{
	[DataContract]
	public class PayrollBatch : Entity, ITopLevelEntity
	{

		[DataMember(Name="BatchID", EmitDefaultValue=false)]
		public StringValue? BatchID { get; set; }

		[DataMember(Name="DeductionsAndBenefitsDetails", EmitDefaultValue=false)]
		public List<BatchDeductionOrBenefitDetail>? DeductionsAndBenefitsDetails { get; set; }

		[DataMember(Name="Description", EmitDefaultValue=false)]
		public StringValue? Description { get; set; }

		[DataMember(Name="EarningDetails", EmitDefaultValue=false)]
		public List<BatchEarningDetail>? EarningDetails { get; set; }

		[DataMember(Name="EmployeeSummary", EmitDefaultValue=false)]
		public List<EmployeePaycheckSummary>? EmployeeSummary { get; set; }

		[DataMember(Name="Hold", EmitDefaultValue=false)]
		public BooleanValue? Hold { get; set; }

		[DataMember(Name="LastModifiedDateTime", EmitDefaultValue=false)]
		public DateTimeValue? LastModifiedDateTime { get; set; }

		[DataMember(Name="NumberofEmployees", EmitDefaultValue=false)]
		public IntValue? NumberofEmployees { get; set; }

		[DataMember(Name="OvertimeRules", EmitDefaultValue=false)]
		public BatchOvertimeRules? OvertimeRules { get; set; }

		[DataMember(Name="PayGroup", EmitDefaultValue=false)]
		public StringValue? PayGroup { get; set; }

		[DataMember(Name="PayPeriod", EmitDefaultValue=false)]
		public StringValue? PayPeriod { get; set; }

		[DataMember(Name="TotalEarnings", EmitDefaultValue=false)]
		public DecimalValue? TotalEarnings { get; set; }

		[DataMember(Name="TotalHourQty", EmitDefaultValue=false)]
		public DecimalValue? TotalHourQty { get; set; }

		[DataMember(Name="PayrollType", EmitDefaultValue=false)]
		public StringValue? PayrollType { get; set; }

		[DataMember(Name="PeriodEnd", EmitDefaultValue=false)]
		public DateTimeValue? PeriodEnd { get; set; }

		[DataMember(Name="PeriodStart", EmitDefaultValue=false)]
		public DateTimeValue? PeriodStart { get; set; }

		[DataMember(Name="Status", EmitDefaultValue=false)]
		public StringValue? Status { get; set; }

		[DataMember(Name="TransactionDate", EmitDefaultValue=false)]
		public DateTimeValue? TransactionDate { get; set; }

		public virtual string GetEndpointPath()
		{
			return "entity/eCommerce/22.200.001";
		}
	}
}