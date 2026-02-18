using System;
using System.Collections.Generic;

using Newtonsoft.Json;

using Acumatica.RESTClient.Client;
using Acumatica.RESTClient.ContractBasedApi;
using Acumatica.RESTClient.ContractBasedApi.Model;

namespace Acumatica.Default_23_200_001.Model
{
	public class ProjectBalance : Entity
	{

		/// <summary>
		/// <para>DAC: PX.Objects.PM.ProjectEntry+PMProjectBalanceRecord</para>
		/// </summary>
		public StringValue? AccountGroup { get; set; }

		/// <summary>
		/// The total amount of the lines of the released accounts receivable invoices that correspond to the budget line.The amount is shown in the project currency.
		/// <para>DAC Field Name: CuryActualAmount</para>
		/// <para>DAC: PX.Objects.PM.PMCostBudget</para>
		/// <para>Display Name: Actual Amount</para>
		/// </summary>
		public DecimalValue? ActualAmount { get; set; }

		/// <summary>
		/// The sum of the Actual Amount and Committed Open Amount values.The amount is shown in the project currency.
		/// <para>DAC Field Name: CuryActualPlusOpenCommittedAmount</para>
		/// <para>DAC: PX.Objects.PM.PMCostBudget</para>
		/// <para>Display Name: Actual + Open Committed Amount</para>
		/// </summary>
		public DecimalValue? ActualOpenCommittedAmount { get; set; }

		/// <summary>
		/// <para>DAC Field Name: CuryBudgetedCOAmount</para>
		/// <para>DAC: PX.Objects.PM.ProjectEntry+PMProjectBalanceRecord</para>
		/// </summary>
		public DecimalValue? BudgetedCOAmount { get; set; }

		/// <summary>
		/// The total amount of the commitment lines of released change orders.The amount is shown in the project currency.
		/// <para>DAC Field Name: CuryCommittedCOAmount</para>
		/// <para>DAC: PX.Objects.PM.PMCostBudget</para>
		/// <para>Display Name: Committed CO Amount</para>
		/// </summary>
		public DecimalValue? CommittedCOAmount { get; set; }

		/// <summary>
		/// The total invoiced amount of the commitments in the project currency.
		/// <para>DAC Field Name: CuryCommittedInvoicedAmount</para>
		/// <para>DAC: PX.Objects.PM.PMCostBudget</para>
		/// <para>Display Name: Committed Invoiced Amount</para>
		/// </summary>
		public DecimalValue? CommittedInvoicedAmount { get; set; }

		/// <summary>
		/// The total open amount of the commitments in the project currency.
		/// <para>DAC Field Name: CuryCommittedOpenAmount</para>
		/// <para>DAC: PX.Objects.PM.PMCostBudget</para>
		/// <para>Display Name: Committed Open Amount</para>
		/// </summary>
		public DecimalValue? CommittedOpenAmount { get; set; }

		/// <summary>
		/// The project description.
		/// <para>DAC: PX.Objects.PM.PMProject</para>
		/// <para>SQL Type: nvarchar(255)</para>
		/// </summary>
		public StringValue? Description { get; set; }

		/// <summary>
		/// The budgeted amount of the budget line in the project currency.
		/// <para>DAC Field Name: CuryAmount</para>
		/// <para>DAC: PX.Objects.PM.PMCostBudget</para>
		/// <para>Display Name: Original Budgeted Amount</para>
		/// </summary>
		public DecimalValue? OriginalBudgetedAmount { get; set; }

		/// <summary>
		/// <para>DAC Field Name: CuryOriginalCommittedAmount</para>
		/// <para>DAC: PX.Objects.PM.ProjectEntry+PMProjectBalanceRecord</para>
		/// </summary>
		public DecimalValue? OriginalCommittedAmount { get; set; }

		/// <summary>
		/// The task performance measure.
		/// <para>DAC: PX.Objects.PM.PMCostBudget</para>
		/// <para>Display Name: Performance (%)</para>
		/// </summary>
		public DecimalValue? Performance { get; set; }

		/// <summary>
		/// The revised budgeted amount in the project currency.
		/// <para>DAC Field Name: CuryRevisedAmount</para>
		/// <para>DAC: PX.Objects.PM.PMCostBudget</para>
		/// <para>Display Name: Revised Budgeted Amount</para>
		/// </summary>
		public DecimalValue? RevisedBudgetedAmount { get; set; }

		/// <summary>
		/// The total amount of the commitments in the project currency.
		/// <para>DAC Field Name: CuryCommittedAmount</para>
		/// <para>DAC: PX.Objects.PM.PMCostBudget</para>
		/// <para>Display Name: Revised Committed Amount</para>
		/// </summary>
		public DecimalValue? RevisedCommittedAmount { get; set; }

		/// <summary>
		/// The difference between the Revised Budgeted Amount andActual + Open Committed Amount values.The amount is shown in the project currency.
		/// <para>DAC Field Name: CuryVarianceAmount</para>
		/// <para>DAC: PX.Objects.PM.PMCostBudget</para>
		/// <para>Display Name: Variance Amount</para>
		/// </summary>
		public DecimalValue? VarianceAmount { get; set; }

	}
}