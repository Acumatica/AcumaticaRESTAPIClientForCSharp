using System;
using System.Collections.Generic;

using Newtonsoft.Json;

using Acumatica.RESTClient.Client;
using Acumatica.RESTClient.ContractBasedApi;
using Acumatica.RESTClient.ContractBasedApi.Model;

namespace Acumatica.eCommerce_24_200_001.Model
{
	/// <summary>
	/// Corresponds to the screen <c>PO302000</c> in the Acumatica ERP
	/// </summary>
	public class PurchaseReceipt : Entity, ITopLevelEntity
	{

		#region Fields
		public StringValue? BaseCurrencyID { get; set; }

		public DateTimeValue? BillDate { get; set; }

		public StringValue? Branch { get; set; }

		public DecimalValue? ControlQty { get; set; }

		public BooleanValue? CreateBill { get; set; }

		public StringValue? CurrencyID { get; set; }

		public DateTimeValue? CurrencyEffectiveDate { get; set; }

		public DecimalValue? CurrencyRate { get; set; }

		public StringValue? CurrencyRateTypeID { get; set; }

		public DecimalValue? CurrencyReciprocalRate { get; set; }

		public DateTimeValue? Date { get; set; }

		public BooleanValue? Hold { get; set; }

		public StringValue? InventoryRefNbr { get; set; }

		public DateTimeValue? LastModifiedDateTime { get; set; }

		public StringValue? Location { get; set; }

		public StringValue? PostPeriod { get; set; }

		public BooleanValue? ProcessReturnWithOriginalCost { get; set; }

		public StringValue? ReceiptNbr { get; set; }

		public StringValue? Status { get; set; }

		public DecimalValue? TotalCost { get; set; }

		public DecimalValue? TotalQty { get; set; }

		public StringValue? Type { get; set; }

		public DecimalValue? UnbilledQuantity { get; set; }

		public StringValue? VendorID { get; set; }

		public StringValue? VendorRef { get; set; }

		public StringValue? Warehouse { get; set; }

		#endregion

		#region Details
		public List<PurchaseReceiptDetail>? Details { get; set; }

		#endregion

		public static class Expand
		{
			public const string Files = "Files";
			public const string Translations = "Translations";
			public const string Details = "Details";
			public const string Details_Files = "Details/Files";

			//Intentionally excluded
			//public const string All = "Files,Translations,Details,Details/Files";
		}
		public virtual string GetEndpointPath()
		{
			return "entity/eCommerce/24.200.001";
		}
	}
}