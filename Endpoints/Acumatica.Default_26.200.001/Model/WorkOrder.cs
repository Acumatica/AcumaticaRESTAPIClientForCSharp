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
	/// Corresponds to the screen <c>SV301000</c> in the Acumatica ERP
	/// </summary>
	[DataContract]
	public class WorkOrder : Entity, ITopLevelEntity
	{

		[DataMember(Name="Actuals", EmitDefaultValue=false)]
		public List<WorkOrderActualDetail>? Actuals { get; set; }

		[DataMember(Name="ActualsExtCost", EmitDefaultValue=false)]
		public DecimalValue? ActualsExtCost { get; set; }

		[DataMember(Name="ActualsTotal", EmitDefaultValue=false)]
		public DecimalValue? ActualsTotal { get; set; }

		[DataMember(Name="AppliedPaymentTotal", EmitDefaultValue=false)]
		public DecimalValue? AppliedPaymentTotal { get; set; }

		[DataMember(Name="AvalaraCustomerUsageType", EmitDefaultValue=false)]
		public StringValue? AvalaraCustomerUsageType { get; set; }

		[DataMember(Name="BilledOrderTotal", EmitDefaultValue=false)]
		public DecimalValue? BilledOrderTotal { get; set; }

		[DataMember(Name="BilledPaymentTotal", EmitDefaultValue=false)]
		public DecimalValue? BilledPaymentTotal { get; set; }

		[DataMember(Name="BranchID", EmitDefaultValue=false)]
		public StringValue? BranchID { get; set; }

		[DataMember(Name="CallerContactEmail", EmitDefaultValue=false)]
		public StringValue? CallerContactEmail { get; set; }

		[DataMember(Name="CallerContactID", EmitDefaultValue=false)]
		public IntValue? CallerContactID { get; set; }

		[DataMember(Name="CallerContactPhone", EmitDefaultValue=false)]
		public StringValue? CallerContactPhone { get; set; }

		[DataMember(Name="CreditHold", EmitDefaultValue=false)]
		public BooleanValue? CreditHold { get; set; }

		[DataMember(Name="CurrencyID", EmitDefaultValue=false)]
		public StringValue? CurrencyID { get; set; }

		[DataMember(Name="CustomerID", EmitDefaultValue=false)]
		public StringValue? CustomerID { get; set; }

		[DataMember(Name="CustomerLocationID", EmitDefaultValue=false)]
		public StringValue? CustomerLocationID { get; set; }

		[DataMember(Name="CustomerOrderNbr", EmitDefaultValue=false)]
		public StringValue? CustomerOrderNbr { get; set; }

		[DataMember(Name="Description", EmitDefaultValue=false)]
		public StringValue? Description { get; set; }

		[DataMember(Name="Details", EmitDefaultValue=false)]
		public List<WorkOrderDetail>? Details { get; set; }

		[DataMember(Name="DisableAutomaticDiscountCalculation", EmitDefaultValue=false)]
		public BooleanValue? DisableAutomaticDiscountCalculation { get; set; }

		[DataMember(Name="DiscTotal", EmitDefaultValue=false)]
		public DecimalValue? DiscTotal { get; set; }

		[DataMember(Name="DiscountDetails", EmitDefaultValue=false)]
		public List<WorkOrderDiscountDetail>? DiscountDetails { get; set; }

		[DataMember(Name="DocDate", EmitDefaultValue=false)]
		public DateOnlyValue? DocDate { get; set; }

		[DataMember(Name="DocumentDiscountTotal", EmitDefaultValue=false)]
		public DecimalValue? DocumentDiscountTotal { get; set; }

		[DataMember(Name="ExpectedDate", EmitDefaultValue=false)]
		public DateOnlyValue? ExpectedDate { get; set; }

		[DataMember(Name="ExpenseAcctDefault", EmitDefaultValue=false)]
		public StringValue? ExpenseAcctDefault { get; set; }

		[DataMember(Name="ExpenseSubMask", EmitDefaultValue=false)]
		public StringValue? ExpenseSubMask { get; set; }

		[DataMember(Name="ExtPriceTotal", EmitDefaultValue=false)]
		public DecimalValue? ExtPriceTotal { get; set; }

		[DataMember(Name="ExternalTaxExemptionNumber", EmitDefaultValue=false)]
		public StringValue? ExternalTaxExemptionNumber { get; set; }

		[DataMember(Name="GLAccounts", EmitDefaultValue=false)]
		public List<WorkOrderGLAccountDetail>? GLAccounts { get; set; }

		[DataMember(Name="Invoices", EmitDefaultValue=false)]
		public List<WorkOrderInvoiceDetail>? Invoices { get; set; }

		[DataMember(Name="LineDiscTotal", EmitDefaultValue=false)]
		public DecimalValue? LineDiscTotal { get; set; }

		[DataMember(Name="LineTotal", EmitDefaultValue=false)]
		public DecimalValue? LineTotal { get; set; }

		[DataMember(Name="LocationAddress", EmitDefaultValue=false)]
		public StringValue? LocationAddress { get; set; }

		[DataMember(Name="LocationContactEmail", EmitDefaultValue=false)]
		public StringValue? LocationContactEmail { get; set; }

		[DataMember(Name="LocationContactID", EmitDefaultValue=false)]
		public IntValue? LocationContactID { get; set; }

		[DataMember(Name="LocationContactPhone", EmitDefaultValue=false)]
		public StringValue? LocationContactPhone { get; set; }

		[DataMember(Name="MaterialListDetails", EmitDefaultValue=false)]
		public List<WorkOrderMaterialListDetail>? MaterialListDetails { get; set; }

		[DataMember(Name="OrderNbr", EmitDefaultValue=false)]
		public StringValue? OrderNbr { get; set; }

		[DataMember(Name="OrderTotal", EmitDefaultValue=false)]
		public DecimalValue? OrderTotal { get; set; }

		[DataMember(Name="OrderType", EmitDefaultValue=false)]
		public StringValue? OrderType { get; set; }

		[DataMember(Name="OrderedQty", EmitDefaultValue=false)]
		public DecimalValue? OrderedQty { get; set; }

		[DataMember(Name="OvertimeBillable", EmitDefaultValue=false)]
		public IntValue? OvertimeBillable { get; set; }

		[DataMember(Name="OvertimeSpent", EmitDefaultValue=false)]
		public IntValue? OvertimeSpent { get; set; }

		[DataMember(Name="Payments", EmitDefaultValue=false)]
		public List<WorkOrderPaymentDetail>? Payments { get; set; }

		[DataMember(Name="Priority", EmitDefaultValue=false)]
		public StringSingleSelectValue? Priority { get; set; }

		[DataMember(Name="ProcurementSiteID", EmitDefaultValue=false)]
		public StringValue? ProcurementSiteID { get; set; }

		[DataMember(Name="ProfitMargin", EmitDefaultValue=false)]
		public DecimalValue? ProfitMargin { get; set; }

		[DataMember(Name="ProfitMarginPercent", EmitDefaultValue=false)]
		public DecimalValue? ProfitMarginPercent { get; set; }

		[DataMember(Name="SalesAcctDefault", EmitDefaultValue=false)]
		public StringValue? SalesAcctDefault { get; set; }

		[DataMember(Name="SalesSubMask", EmitDefaultValue=false)]
		public StringValue? SalesSubMask { get; set; }

		[DataMember(Name="ServiceLocationComment", EmitDefaultValue=false)]
		public StringValue? ServiceLocationComment { get; set; }

		[DataMember(Name="ServiceLocationID", EmitDefaultValue=false)]
		public StringValue? ServiceLocationID { get; set; }

		[DataMember(Name="Severity", EmitDefaultValue=false)]
		public StringSingleSelectValue? Severity { get; set; }

		[DataMember(Name="Shipments", EmitDefaultValue=false)]
		public List<WorkOrderShipmentDetail>? Shipments { get; set; }

		[DataMember(Name="Status", EmitDefaultValue=false)]
		public StringSingleSelectValue? Status { get; set; }

		[DataMember(Name="StockItemsExpenseAcctDefault", EmitDefaultValue=false)]
		public StringValue? StockItemsExpenseAcctDefault { get; set; }

		[DataMember(Name="StockItemsExpenseSubMask", EmitDefaultValue=false)]
		public StringValue? StockItemsExpenseSubMask { get; set; }

		[DataMember(Name="Summary", EmitDefaultValue=false)]
		public StringValue? Summary { get; set; }

		[DataMember(Name="Tasks", EmitDefaultValue=false)]
		public List<WorkTaskDetail>? Tasks { get; set; }

		[DataMember(Name="TasksEstimatedDuration", EmitDefaultValue=false)]
		public IntValue? TasksEstimatedDuration { get; set; }

		[DataMember(Name="TaxCalcMode", EmitDefaultValue=false)]
		public StringValue? TaxCalcMode { get; set; }

		[DataMember(Name="TaxDetails", EmitDefaultValue=false)]
		public List<WorkOrderTaxDetail>? TaxDetails { get; set; }

		[DataMember(Name="TaxTotal", EmitDefaultValue=false)]
		public DecimalValue? TaxTotal { get; set; }

		[DataMember(Name="TaxZoneID", EmitDefaultValue=false)]
		public StringValue? TaxZoneID { get; set; }

		[DataMember(Name="TicketDetails", EmitDefaultValue=false)]
		public List<WorkOrderTicketLineDetail>? TicketDetails { get; set; }

		[DataMember(Name="Tickets", EmitDefaultValue=false)]
		public List<WorkOrderTicketDetail>? Tickets { get; set; }

		[DataMember(Name="TicketsTimeSpent", EmitDefaultValue=false)]
		public IntValue? TicketsTimeSpent { get; set; }

		[DataMember(Name="TimeBillable", EmitDefaultValue=false)]
		public IntValue? TimeBillable { get; set; }

		[DataMember(Name="TimeSpent", EmitDefaultValue=false)]
		public IntValue? TimeSpent { get; set; }

		[DataMember(Name="UnbilledOrderTotal", EmitDefaultValue=false)]
		public DecimalValue? UnbilledOrderTotal { get; set; }

		[DataMember(Name="VatExemptTotal", EmitDefaultValue=false)]
		public DecimalValue? VatExemptTotal { get; set; }

		[DataMember(Name="VatTaxableTotal", EmitDefaultValue=false)]
		public DecimalValue? VatTaxableTotal { get; set; }

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