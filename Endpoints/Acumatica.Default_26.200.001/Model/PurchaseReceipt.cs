using System;
using System.Collections.Generic;

using Newtonsoft.Json;

using Acumatica.RESTClient.Client;
using Acumatica.RESTClient.ContractBasedApi;
using Acumatica.RESTClient.ContractBasedApi.Model;

namespace Acumatica.Default_26_200_001.Model
{
	/// <summary>
	/// Corresponds to the screen <c>PO302000</c> in the Acumatica ERP
	/// <para>Key Fields: Type, ReceiptNbr</para>
	/// </summary>
	public class PurchaseReceipt : Entity, ITopLevelEntity
	{

		#region Fields
		/// <summary>
		/// <para>DAC Field Name: ReceiptType</para>
		/// <para>DAC: PX.Objects.PO.POReceipt</para>
		/// <para>SQL Type: char(2)</para>
		/// Key Field
		/// </summary>
		public StringSingleSelectValue? Type { get; set; }

		/// <summary>
		/// <para>DAC: PX.Objects.PO.POReceipt</para>
		/// <para>Display Name: Receipt Nbr.</para>
		/// <para>SQL Type: nvarchar(15)</para>
		/// Key Field
		/// </summary>
		public StringValue? ReceiptNbr { get; set; }

		/// <summary>
		/// <para>DAC: PX.Objects.PO.POReceipt</para>
		/// <para>SQL Type: char(1)</para>
		/// </summary>
		public StringSingleSelectValue? Status { get; set; }

		/// <summary>
		/// <para>DAC Field Name: ReceiptDate</para>
		/// <para>DAC: PX.Objects.PO.POReceipt</para>
		/// </summary>
		public DateTimeValue? Date { get; set; }

		/// <summary>
		/// <para>DAC Field Name: FinPeriodID</para>
		/// <para>DAC: PX.Objects.PO.POReceipt</para>
		/// <para>Display Name: Post Period</para>
		/// <para>SQL Type: char(6)</para>
		/// </summary>
		public StringValue? PostPeriod { get; set; }

		/// <summary>
		/// <para>DAC: PX.Objects.PO.POReceipt</para>
		/// <para>Display Name: Vendor</para>
		/// </summary>
		public StringValue? VendorID { get; set; }

		/// <summary>
		/// <para>DAC Field Name: VendorLocationID</para>
		/// <para>DAC: PX.Objects.PO.POReceipt</para>
		/// </summary>
		public StringValue? Location { get; set; }

		/// <summary>
		/// <para>DAC Field Name: SiteID</para>
		/// <para>DAC: PX.Objects.PO.POReceipt</para>
		/// </summary>
		public StringValue? Warehouse { get; set; }

		/// <summary>
		/// <para>DAC Field Name: CuryID</para>
		/// <para>DAC: PX.Objects.PO.POReceipt</para>
		/// <para>Display Name: Currency</para>
		/// <para>SQL Type: nvarchar(5)</para>
		/// </summary>
		public StringValue? CurrencyID { get; set; }

		/// <summary>
		/// <para>DAC Field Name: AutoCreateInvoice</para>
		/// <para>DAC: PX.Objects.PO.POReceipt</para>
		/// <para>Display Name: Create Bill</para>
		/// </summary>
		public BooleanValue? CreateBill { get; set; }

		/// <summary>
		/// <para>DAC Field Name: InvoiceNbr</para>
		/// <para>DAC: PX.Objects.PO.POReceipt</para>
		/// <para>Display Name: Vendor Ref.</para>
		/// <para>SQL Type: nvarchar(40)</para>
		/// </summary>
		public StringValue? VendorRef { get; set; }

		/// <summary>
		/// <para>DAC Field Name: OrderQty</para>
		/// <para>DAC: PX.Objects.PO.POReceipt</para>
		/// <para>Display Name: Total Qty.</para>
		/// </summary>
		public DecimalValue? TotalQty { get; set; }

		/// <summary>
		/// <para>DAC: PX.Objects.PO.POReceipt</para>
		/// <para>Display Name: Control Qty.</para>
		/// </summary>
		public DecimalValue? ControlQty { get; set; }

		/// <summary>
		/// <para>DAC Field Name: UnbilledQty</para>
		/// <para>DAC: PX.Objects.PO.POReceipt</para>
		/// <para>Display Name: Unbilled Quantity</para>
		/// </summary>
		public DecimalValue? UnbilledQuantity { get; set; }

		/// <summary>
		/// <para>DAC Field Name: CuryOrderTotal</para>
		/// <para>DAC: PX.Objects.PO.POReceipt</para>
		/// <para>Display Name: Total Cost</para>
		/// </summary>
		public DecimalValue? TotalCost { get; set; }

		/// <summary>
		/// <para>DAC Field Name: CuryRateTypeID</para>
		/// <para>DAC: {}</para>
		/// </summary>
		public StringValue? CurrencyRateTypeID { get; set; }

		/// <summary>
		/// <para>DAC Field Name: CuryEffDate</para>
		/// <para>DAC: {}</para>
		/// </summary>
		public DateTimeValue? CurrencyEffectiveDate { get; set; }

		/// <summary>
		/// <para>DAC Field Name: SampleCuryRate</para>
		/// <para>DAC: {}</para>
		/// </summary>
		public DecimalValue? CurrencyRate { get; set; }

		/// <summary>
		/// <para>DAC Field Name: BaseCuryID</para>
		/// <para>DAC: {}</para>
		/// </summary>
		public StringValue? BaseCurrencyID { get; set; }

		/// <summary>
		/// <para>DAC Field Name: SampleRecipRate</para>
		/// <para>DAC: {}</para>
		/// </summary>
		public DecimalValue? CurrencyReciprocalRate { get; set; }

		/// <summary>
		/// <para>DAC: PX.Objects.PO.POReceipt</para>
		/// <para>Display Name: IN Ref. Nbr.</para>
		/// <para>SQL Type: nvarchar(15)</para>
		/// </summary>
		public StringValue? InventoryRefNbr { get; set; }

		/// <summary>
		/// <para>DAC Field Name: BranchID</para>
		/// <para>DAC: PX.Objects.PO.POReceipt</para>
		/// </summary>
		public StringValue? Branch { get; set; }

		/// <summary>
		/// <para>DAC Field Name: InvoiceDate</para>
		/// <para>DAC: PX.Objects.PO.POReceipt</para>
		/// <para>Display Name: Bill Date</para>
		/// </summary>
		public DateTimeValue? BillDate { get; set; }

		public BooleanValue? Hold { get; set; }

		public DateTimeValue? LastModifiedDateTime { get; set; }

		public BooleanValue? ProcessReturnWithOriginalCost { get; set; }

		#endregion

		#region Details
		public List<PurchaseReceiptDetail>? Details { get; set; }

		#endregion

		protected override string GetDebuggerDisplay()
		{
			return $"{nameof(PurchaseReceipt)} - \"{Type}\" - \"{ReceiptNbr}\"";
		}

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
			public const string Details = "Details";

			//Intentionally excluded
			//public const string All = "Files,Translations,Details";
		}
		public virtual string GetEndpointPath()
		{
			return "entity/Default/26.200.001";
		}
	}
}