using System;
using System.Collections.Generic;

using Newtonsoft.Json;

using Acumatica.RESTClient.Client;
using Acumatica.RESTClient.ContractBasedApi;
using Acumatica.RESTClient.ContractBasedApi.Model;

namespace Acumatica.Default_23_200_001.Model
{
	/// <summary>
	/// Corresponds to the screen <c>PM309000</c> in the Acumatica ERP
	/// <para>Key Fields: AccountGroup, CostCode, InventoryID, ProjectID, ProjectTaskID</para>
	/// </summary>
	public class ProjectBudget : Entity, ITopLevelEntity
	{

		/// <summary>
		/// The identifier of the Account Group associated with the budget line.
		/// <para>DAC Field Name: AccountGroupID</para>
		/// <para>DAC: PX.Objects.PM.PMBudget</para>
		/// <para>Display Name: Account Group</para>
		/// Key Field
		/// </summary>
		public StringValue? AccountGroup { get; set; }

		/// <summary>
		/// The total amount of the lines of the released accounts receivable invoices that correspond to the budget line.The amount is shown in the project currency.
		/// <para>DAC Field Name: CuryActualAmount</para>
		/// <para>DAC: PX.Objects.PM.PMBudget</para>
		/// <para>Display Name: Actual Amount</para>
		/// </summary>
		public DecimalValue? ActualAmount { get; set; }

		public DecimalValue? ActualPlusOpenCommittedAmount { get; set; }

		/// <summary>
		/// The total quantity of the lines of the released accounts receivable invoices that correspond to the budget line.
		/// <para>DAC: PX.Objects.PM.PMBudget</para>
		/// <para>Display Name: Actual Quantity</para>
		/// </summary>
		public DecimalValue? ActualQty { get; set; }

		public BooleanValue? AutoCompleted { get; set; }

		public DecimalValue? BudgetedCOAmount { get; set; }

		public DecimalValue? BudgetedCOQty { get; set; }

		public DecimalValue? CommittedCOAmount { get; set; }

		public DecimalValue? CommittedCOQty { get; set; }

		/// <summary>
		/// The total invoiced amount of the commitments in the project currency.
		/// <para>DAC Field Name: CuryCommittedInvoicedAmount</para>
		/// <para>DAC: PX.Objects.PM.PMBudget</para>
		/// <para>Display Name: Committed Invoiced Amount</para>
		/// </summary>
		public DecimalValue? CommittedInvoicedAmount { get; set; }

		/// <summary>
		/// The total invoiced quantity of the commitments.
		/// <para>DAC: PX.Objects.PM.PMBudget</para>
		/// <para>Display Name: Committed Invoiced Quantity</para>
		/// </summary>
		public DecimalValue? CommittedInvoicedQty { get; set; }

		/// <summary>
		/// The total open amount of the commitments in the project currency.
		/// <para>DAC Field Name: CuryCommittedOpenAmount</para>
		/// <para>DAC: PX.Objects.PM.PMBudget</para>
		/// <para>Display Name: Committed Open Amount</para>
		/// </summary>
		public DecimalValue? CommittedOpenAmount { get; set; }

		/// <summary>
		/// The total open quantity of the commitments.
		/// <para>DAC: PX.Objects.PM.PMBudget</para>
		/// <para>Display Name: Committed Open Quantity</para>
		/// </summary>
		public DecimalValue? CommittedOpenQty { get; set; }

		/// <summary>
		/// The total received quantity of the commitments.
		/// <para>DAC: PX.Objects.PM.PMBudget</para>
		/// <para>Display Name: Committed Received Quantity</para>
		/// </summary>
		public DecimalValue? CommittedReceivedQty { get; set; }

		public DecimalValue? Completed { get; set; }

		public DecimalValue? CostAtCompletion { get; set; }

		/// <summary>
		/// The identifier of the Cost Code associated with the budget line.
		/// <para>DAC Field Name: CostCodeID</para>
		/// <para>DAC: PX.Objects.PM.PMBudget</para>
		/// <para>Display Name: Cost Code</para>
		/// Key Field
		/// </summary>
		public StringValue? CostCode { get; set; }

		public DecimalValue? CostToComplete { get; set; }

		/// <summary>
		/// The description of the budget line.
		/// <para>DAC: PX.Objects.PM.PMBudget</para>
		/// <para>SQL Type: nvarchar(256)</para>
		/// </summary>
		public StringValue? Description { get; set; }

		public DecimalValue? DraftInvoicesAmount { get; set; }

		/// <summary>
		/// The identifier of the inventory item associated with the budget line.
		/// <para>DAC: PX.Objects.PM.PMBudget</para>
		/// <para>Display Name: Inventory ID</para>
		/// Key Field
		/// </summary>
		public StringValue? InventoryID { get; set; }

		public DecimalValue? LastCostAtCompletion { get; set; }

		public DecimalValue? LastCostToComplete { get; set; }

		public DateTimeValue? LastModifiedDateTime { get; set; }

		public DecimalValue? LastPercentageOfCompletion { get; set; }

		/// <summary>
		/// The budgeted amount of the budget line in the project currency.
		/// <para>DAC Field Name: CuryAmount</para>
		/// <para>DAC: PX.Objects.PM.PMBudget</para>
		/// <para>Display Name: Original Budgeted Amount</para>
		/// </summary>
		public DecimalValue? OriginalBudgetedAmount { get; set; }

		/// <summary>
		/// The budgeted quantity of the budget line.
		/// <para>DAC Field Name: Qty</para>
		/// <para>DAC: PX.Objects.PM.PMBudget</para>
		/// <para>Display Name: Original Budgeted Quantity</para>
		/// </summary>
		public DecimalValue? OriginalBudgetedQty { get; set; }

		public DecimalValue? OriginalCommittedAmount { get; set; }

		public DecimalValue? OriginalCommittedQty { get; set; }

		public DecimalValue? PendingInvoiceAmount { get; set; }

		public DecimalValue? PercentageOfCompletion { get; set; }

		public DecimalValue? Performance { get; set; }

		/// <summary>
		/// The identifier of the project associated with the budget line.
		/// <para>DAC: PX.Objects.PM.PMBudget</para>
		/// Key Field
		/// </summary>
		public StringValue? ProjectID { get; set; }

		/// <summary>
		/// The identifier of the project task associated with the budget line.
		/// <para>DAC: PX.Objects.PM.PMBudget</para>
		/// Key Field
		/// </summary>
		public StringValue? ProjectTaskID { get; set; }

		public DecimalValue? Retainage { get; set; }

		public IntValue? RevenueTask { get; set; }

		/// <summary>
		/// The revised budgeted amount in the project currency.
		/// <para>DAC Field Name: CuryRevisedAmount</para>
		/// <para>DAC: PX.Objects.PM.PMBudget</para>
		/// <para>Display Name: Revised Budgeted Amount</para>
		/// </summary>
		public DecimalValue? RevisedBudgetedAmount { get; set; }

		/// <summary>
		/// The revised budgeted quantity.
		/// <para>DAC Field Name: RevisedQty</para>
		/// <para>DAC: PX.Objects.PM.PMBudget</para>
		/// <para>Display Name: Revised Budgeted Quantity</para>
		/// </summary>
		public DecimalValue? RevisedBudgetedQty { get; set; }

		/// <summary>
		/// The total amount of the commitments in the project currency.
		/// <para>DAC Field Name: CuryCommittedAmount</para>
		/// <para>DAC: PX.Objects.PM.PMBudget</para>
		/// <para>Display Name: Revised Committed Amount</para>
		/// </summary>
		public DecimalValue? RevisedCommittedAmount { get; set; }

		/// <summary>
		/// The total quantity of the commitments.
		/// <para>DAC Field Name: CommittedQty</para>
		/// <para>DAC: PX.Objects.PM.PMBudget</para>
		/// <para>Display Name: Revised Committed Quantity</para>
		/// </summary>
		public DecimalValue? RevisedCommittedQty { get; set; }

		public StringValue? TaxCategory { get; set; }

		/// <summary>
		/// The type of the budget line.
		/// <para>DAC: PX.Objects.PM.PMBudget</para>
		/// <para>SQL Type: char(1)</para>
		/// </summary>
		public StringValue? Type { get; set; }

		/// <summary>
		/// The price or cost of the specified unit of the budget line in the project currency.
		/// <para>DAC Field Name: CuryUnitRate</para>
		/// <para>DAC: PX.Objects.PM.PMBudget</para>
		/// <para>Display Name: Unit Rate</para>
		/// </summary>
		public DecimalValue? UnitRate { get; set; }

		/// <summary>
		/// The unit of measure of the budget line.
		/// <para>DAC: PX.Objects.PM.PMBudget</para>
		/// <para>SQL Type: nvarchar(6)</para>
		/// </summary>
		public StringValue? UOM { get; set; }

		public DecimalValue? VarianceAmount { get; set; }

		public static class Expand
		{
			public const string Files = "Files";
			public const string Translations = "Translations";

			//Intentionally excluded
			//public const string All = "Files,Translations";
		}
		public virtual string GetEndpointPath()
		{
			return "entity/Default/23.200.001";
		}
	}
}