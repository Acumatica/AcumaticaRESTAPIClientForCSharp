using System;
using System.Collections.Generic;

using Newtonsoft.Json;

using Acumatica.RESTClient.Client;
using Acumatica.RESTClient.ContractBasedApi;
using Acumatica.RESTClient.ContractBasedApi.Model;

namespace Acumatica.Default_26_200_001.Model
{
	/// <summary>
	/// Corresponds to the screen <c>SV301000</c> in the Acumatica ERP
	/// </summary>
	public class WorkOrder : Entity, ITopLevelEntity
	{

		#region Fields
		public DecimalValue? ActualsExtCost { get; set; }

		public DecimalValue? ActualsTotal { get; set; }

		public DecimalValue? AppliedPaymentTotal { get; set; }

		public StringValue? AvalaraCustomerUsageType { get; set; }

		public DecimalValue? BilledOrderTotal { get; set; }

		public DecimalValue? BilledPaymentTotal { get; set; }

		public StringValue? BranchID { get; set; }

		public StringValue? CallerContactEmail { get; set; }

		public IntValue? CallerContactID { get; set; }

		public StringValue? CallerContactPhone { get; set; }

		public BooleanValue? CreditHold { get; set; }

		public StringValue? CurrencyID { get; set; }

		public StringValue? CustomerID { get; set; }

		public StringValue? CustomerLocationID { get; set; }

		public StringValue? CustomerOrderNbr { get; set; }

		public StringValue? Description { get; set; }

		public BooleanValue? DisableAutomaticDiscountCalculation { get; set; }

		public DecimalValue? DiscTotal { get; set; }

		public DateOnlyValue? DocDate { get; set; }

		public DecimalValue? DocumentDiscountTotal { get; set; }

		public DateOnlyValue? ExpectedDate { get; set; }

		public StringValue? ExpenseAcctDefault { get; set; }

		public StringValue? ExpenseSubMask { get; set; }

		public DecimalValue? ExtPriceTotal { get; set; }

		public StringValue? ExternalTaxExemptionNumber { get; set; }

		public DecimalValue? LineDiscTotal { get; set; }

		public DecimalValue? LineTotal { get; set; }

		public StringValue? LocationAddress { get; set; }

		public StringValue? LocationContactEmail { get; set; }

		public IntValue? LocationContactID { get; set; }

		public StringValue? LocationContactPhone { get; set; }

		public StringValue? OrderNbr { get; set; }

		public DecimalValue? OrderTotal { get; set; }

		public StringValue? OrderType { get; set; }

		public DecimalValue? OrderedQty { get; set; }

		public IntValue? OvertimeBillable { get; set; }

		public IntValue? OvertimeSpent { get; set; }

		public StringSingleSelectValue? Priority { get; set; }

		public StringValue? ProcurementSiteID { get; set; }

		public DecimalValue? ProfitMargin { get; set; }

		public DecimalValue? ProfitMarginPercent { get; set; }

		public StringValue? SalesAcctDefault { get; set; }

		public StringValue? SalesSubMask { get; set; }

		public StringValue? ServiceLocationComment { get; set; }

		public StringValue? ServiceLocationID { get; set; }

		public StringSingleSelectValue? Severity { get; set; }

		public StringSingleSelectValue? Status { get; set; }

		public StringValue? StockItemsExpenseAcctDefault { get; set; }

		public StringValue? StockItemsExpenseSubMask { get; set; }

		public StringValue? Summary { get; set; }

		public IntValue? TasksEstimatedDuration { get; set; }

		public StringValue? TaxCalcMode { get; set; }

		public DecimalValue? TaxTotal { get; set; }

		public StringValue? TaxZoneID { get; set; }

		public IntValue? TicketsTimeSpent { get; set; }

		public IntValue? TimeBillable { get; set; }

		public IntValue? TimeSpent { get; set; }

		public DecimalValue? UnbilledOrderTotal { get; set; }

		public DecimalValue? VatExemptTotal { get; set; }

		public DecimalValue? VatTaxableTotal { get; set; }

		#endregion

		#region Details
		public List<WorkOrderActualDetail>? Actuals { get; set; }

		public List<WorkOrderDetail>? Details { get; set; }

		public List<WorkOrderDiscountDetail>? DiscountDetails { get; set; }

		public List<WorkOrderGLAccountDetail>? GLAccounts { get; set; }

		public List<WorkOrderInvoiceDetail>? Invoices { get; set; }

		public List<WorkOrderMaterialListDetail>? MaterialListDetails { get; set; }

		public List<WorkOrderPaymentDetail>? Payments { get; set; }

		public List<WorkOrderShipmentDetail>? Shipments { get; set; }

		public List<WorkTaskDetail>? Tasks { get; set; }

		public List<WorkOrderTaxDetail>? TaxDetails { get; set; }

		public List<WorkOrderTicketLineDetail>? TicketDetails { get; set; }

		public List<WorkOrderTicketDetail>? Tickets { get; set; }

		#endregion

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
			public const string Actuals = "Actuals";
			public const string Details = "Details";
			public const string DiscountDetails = "DiscountDetails";
			public const string GLAccounts = "GLAccounts";
			public const string Invoices = "Invoices";
			public const string MaterialListDetails = "MaterialListDetails";
			public const string Payments = "Payments";
			public const string Shipments = "Shipments";
			public const string Tasks = "Tasks";
			public const string TaxDetails = "TaxDetails";
			public const string TicketDetails = "TicketDetails";
			public const string Tickets = "Tickets";

			//Intentionally excluded
			//public const string All = "Files,Translations,Actuals,Details,DiscountDetails,GLAccounts,Invoices,MaterialListDetails,Payments,Shipments,Tasks,TaxDetails,TicketDetails,Tickets";
		}
		public virtual string GetEndpointPath()
		{
			return "entity/Default/26.200.001";
		}
	}
}