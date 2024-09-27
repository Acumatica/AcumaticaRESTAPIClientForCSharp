using System;
using System.Collections.Generic;
using System.Runtime.Serialization;

using Newtonsoft.Json;

using Acumatica.RESTClient.Client;
using Acumatica.RESTClient.ContractBasedApi;
using Acumatica.RESTClient.ContractBasedApi.Model;

namespace Acumatica.Default_23_200_001.Model
{
	[DataContract]
	public class ProjectBalance : Entity
	{

		/// <summary>
		/// DAC: PX.Objects.PM.ProjectEntry+PMProjectBalanceRecord 
		/// </summary>
		[DataMember(Name="AccountGroup", EmitDefaultValue=false)]
		public StringValue? AccountGroup { get; set; }

		/// <summary>
		/// The total amount of the lines of the released accounts receivable invoices that correspond to the budget line.The amount is shown in the project currency.
		/// DAC Field Name: CuryActualAmount 
		/// DAC: PX.Objects.PM.PMCostBudget 
		/// Display Name: Actual Amount 
		/// </summary>
		[DataMember(Name="ActualAmount", EmitDefaultValue=false)]
		public DecimalValue? ActualAmount { get; set; }

		/// <summary>
		/// The sum of the Actual Amount and Committed Open Amount values.The amount is shown in the project currency.
		/// DAC Field Name: CuryActualPlusOpenCommittedAmount 
		/// DAC: PX.Objects.PM.PMCostBudget 
		/// Display Name: Actual + Open Committed Amount 
		/// </summary>
		[DataMember(Name="ActualOpenCommittedAmount", EmitDefaultValue=false)]
		public DecimalValue? ActualOpenCommittedAmount { get; set; }

		/// <summary>
		/// DAC Field Name: CuryBudgetedCOAmount 
		/// DAC: PX.Objects.PM.ProjectEntry+PMProjectBalanceRecord 
		/// </summary>
		[DataMember(Name="BudgetedCOAmount", EmitDefaultValue=false)]
		public DecimalValue? BudgetedCOAmount { get; set; }

		/// <summary>
		/// The total amount of the commitment lines of released change orders.The amount is shown in the project currency.
		/// DAC Field Name: CuryCommittedCOAmount 
		/// DAC: PX.Objects.PM.PMCostBudget 
		/// Display Name: Committed CO Amount 
		/// </summary>
		[DataMember(Name="CommittedCOAmount", EmitDefaultValue=false)]
		public DecimalValue? CommittedCOAmount { get; set; }

		/// <summary>
		/// The total invoiced amount of the commitments in the project currency.
		/// DAC Field Name: CuryCommittedInvoicedAmount 
		/// DAC: PX.Objects.PM.PMCostBudget 
		/// Display Name: Committed Invoiced Amount 
		/// </summary>
		[DataMember(Name="CommittedInvoicedAmount", EmitDefaultValue=false)]
		public DecimalValue? CommittedInvoicedAmount { get; set; }

		/// <summary>
		/// The total open amount of the commitments in the project currency.
		/// DAC Field Name: CuryCommittedOpenAmount 
		/// DAC: PX.Objects.PM.PMCostBudget 
		/// Display Name: Committed Open Amount 
		/// </summary>
		[DataMember(Name="CommittedOpenAmount", EmitDefaultValue=false)]
		public DecimalValue? CommittedOpenAmount { get; set; }

		/// <summary>
		/// The project description.
		/// DAC: PX.Objects.PM.PMProject 
		/// SQL Type: nvarchar(255) 
		/// </summary>
		[DataMember(Name="Description", EmitDefaultValue=false)]
		public StringValue? Description { get; set; }

		/// <summary>
		/// The budgeted amount of the budget line in the project currency.
		/// DAC Field Name: CuryAmount 
		/// DAC: PX.Objects.PM.PMCostBudget 
		/// Display Name: Original Budgeted Amount 
		/// </summary>
		[DataMember(Name="OriginalBudgetedAmount", EmitDefaultValue=false)]
		public DecimalValue? OriginalBudgetedAmount { get; set; }

		/// <summary>
		/// DAC Field Name: CuryOriginalCommittedAmount 
		/// DAC: PX.Objects.PM.ProjectEntry+PMProjectBalanceRecord 
		/// </summary>
		[DataMember(Name="OriginalCommittedAmount", EmitDefaultValue=false)]
		public DecimalValue? OriginalCommittedAmount { get; set; }

		/// <summary>
		/// The task performance measure.
		/// DAC: PX.Objects.PM.PMCostBudget 
		/// Display Name: Performance (%) 
		/// </summary>
		[DataMember(Name="Performance", EmitDefaultValue=false)]
		public DecimalValue? Performance { get; set; }

		/// <summary>
		/// The revised budgeted amount in the project currency.
		/// DAC Field Name: CuryRevisedAmount 
		/// DAC: PX.Objects.PM.PMCostBudget 
		/// Display Name: Revised Budgeted Amount 
		/// </summary>
		[DataMember(Name="RevisedBudgetedAmount", EmitDefaultValue=false)]
		public DecimalValue? RevisedBudgetedAmount { get; set; }

		/// <summary>
		/// The total amount of the commitments in the project currency.
		/// DAC Field Name: CuryCommittedAmount 
		/// DAC: PX.Objects.PM.PMCostBudget 
		/// Display Name: Revised Committed Amount 
		/// </summary>
		[DataMember(Name="RevisedCommittedAmount", EmitDefaultValue=false)]
		public DecimalValue? RevisedCommittedAmount { get; set; }

		/// <summary>
		/// The difference between the Revised Budgeted Amount andActual + Open Committed Amount values.The amount is shown in the project currency.
		/// DAC Field Name: CuryVarianceAmount 
		/// DAC: PX.Objects.PM.PMCostBudget 
		/// Display Name: Variance Amount 
		/// </summary>
		[DataMember(Name="VarianceAmount", EmitDefaultValue=false)]
		public DecimalValue? VarianceAmount { get; set; }

	}
}