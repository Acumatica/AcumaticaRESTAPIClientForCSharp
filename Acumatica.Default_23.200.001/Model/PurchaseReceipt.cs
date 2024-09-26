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
	/// Corresponds to the screen PO302000 in the Acumatica ERP
	/// </summary>
	[DataContract]
	public class PurchaseReceipt : Entity, ITopLevelEntity
	{

		/// <summary>
		/// 
		/// Display Name:
		/// DAC Field Name: BaseCuryID 
		/// DAC: {} 
		/// </summary>
		/// <remarks>
		/// 
		/// </remarks>
		[DataMember(Name="BaseCurrencyID", EmitDefaultValue=false)]
		public StringValue? BaseCurrencyID { get; set; }

		/// <summary>
		/// 
		/// Display Name:
		/// DAC Field Name: InvoiceDate 
		/// DAC: PX.Objects.PO.POReceipt 
		/// </summary>
		/// <remarks>
		/// 
		/// </remarks>
		[DataMember(Name="BillDate", EmitDefaultValue=false)]
		public DateTimeValue? BillDate { get; set; }

		/// <summary>
		/// 
		/// Display Name:
		/// DAC Field Name: BranchID 
		/// DAC: PX.Objects.PO.POReceipt 
		/// </summary>
		/// <remarks>
		/// 
		/// </remarks>
		[DataMember(Name="Branch", EmitDefaultValue=false)]
		public StringValue? Branch { get; set; }

		/// <summary>
		/// 
		/// Display Name:
		/// DAC Field Name: ControlQty 
		/// DAC: PX.Objects.PO.POReceipt 
		/// </summary>
		/// <remarks>
		/// 
		/// </remarks>
		[DataMember(Name="ControlQty", EmitDefaultValue=false)]
		public DecimalValue? ControlQty { get; set; }

		/// <summary>
		/// 
		/// Display Name:
		/// DAC Field Name: AutoCreateInvoice 
		/// DAC: PX.Objects.PO.POReceipt 
		/// </summary>
		/// <remarks>
		/// 
		/// </remarks>
		[DataMember(Name="CreateBill", EmitDefaultValue=false)]
		public BooleanValue? CreateBill { get; set; }

		/// <summary>
		/// 
		/// Display Name:
		/// DAC Field Name: CuryID 
		/// DAC: PX.Objects.PO.POReceipt 
		/// </summary>
		/// <remarks>
		/// 
		/// </remarks>
		[DataMember(Name="CurrencyID", EmitDefaultValue=false)]
		public StringValue? CurrencyID { get; set; }

		/// <summary>
		/// 
		/// Display Name:
		/// DAC Field Name: CuryEffDate 
		/// DAC: {} 
		/// </summary>
		/// <remarks>
		/// 
		/// </remarks>
		[DataMember(Name="CurrencyEffectiveDate", EmitDefaultValue=false)]
		public DateTimeValue? CurrencyEffectiveDate { get; set; }

		/// <summary>
		/// 
		/// Display Name:
		/// DAC Field Name: SampleCuryRate 
		/// DAC: {} 
		/// </summary>
		/// <remarks>
		/// 
		/// </remarks>
		[DataMember(Name="CurrencyRate", EmitDefaultValue=false)]
		public DecimalValue? CurrencyRate { get; set; }

		/// <summary>
		/// 
		/// Display Name:
		/// DAC Field Name: CuryRateTypeID 
		/// DAC: {} 
		/// </summary>
		/// <remarks>
		/// 
		/// </remarks>
		[DataMember(Name="CurrencyRateTypeID", EmitDefaultValue=false)]
		public StringValue? CurrencyRateTypeID { get; set; }

		/// <summary>
		/// 
		/// Display Name:
		/// DAC Field Name: SampleRecipRate 
		/// DAC: {} 
		/// </summary>
		/// <remarks>
		/// 
		/// </remarks>
		[DataMember(Name="CurrencyReciprocalRate", EmitDefaultValue=false)]
		public DecimalValue? CurrencyReciprocalRate { get; set; }

		/// <summary>
		/// 
		/// Display Name:
		/// DAC Field Name: ReceiptDate 
		/// DAC: PX.Objects.PO.POReceipt 
		/// </summary>
		/// <remarks>
		/// 
		/// </remarks>
		[DataMember(Name="Date", EmitDefaultValue=false)]
		public DateTimeValue? Date { get; set; }

		[DataMember(Name="Details", EmitDefaultValue=false)]
		public List<PurchaseReceiptDetail>? Details { get; set; }

		[DataMember(Name="Hold", EmitDefaultValue=false)]
		public BooleanValue? Hold { get; set; }

		/// <summary>
		/// 
		/// Display Name:
		/// DAC Field Name: InventoryRefNbr 
		/// DAC: PX.Objects.PO.POReceipt 
		/// </summary>
		/// <remarks>
		/// 
		/// </remarks>
		[DataMember(Name="InventoryRefNbr", EmitDefaultValue=false)]
		public StringValue? InventoryRefNbr { get; set; }

		[DataMember(Name="LastModifiedDateTime", EmitDefaultValue=false)]
		public DateTimeValue? LastModifiedDateTime { get; set; }

		/// <summary>
		/// 
		/// Display Name:
		/// DAC Field Name: VendorLocationID 
		/// DAC: PX.Objects.PO.POReceipt 
		/// </summary>
		/// <remarks>
		/// 
		/// </remarks>
		[DataMember(Name="Location", EmitDefaultValue=false)]
		public StringValue? Location { get; set; }

		/// <summary>
		/// 
		/// Display Name:
		/// DAC Field Name: FinPeriodID 
		/// DAC: PX.Objects.PO.POReceipt 
		/// </summary>
		/// <remarks>
		/// 
		/// </remarks>
		[DataMember(Name="PostPeriod", EmitDefaultValue=false)]
		public StringValue? PostPeriod { get; set; }

		[DataMember(Name="ProcessReturnWithOriginalCost", EmitDefaultValue=false)]
		public BooleanValue? ProcessReturnWithOriginalCost { get; set; }

		/// <summary>
		/// 
		/// Display Name:
		/// DAC Field Name: ReceiptNbr 
		/// DAC: PX.Objects.PO.POReceipt 
		/// </summary>
		/// <remarks>
		/// 
		/// </remarks>
		[DataMember(Name="ReceiptNbr", EmitDefaultValue=false)]
		public StringValue? ReceiptNbr { get; set; }

		/// <summary>
		/// 
		/// Display Name:
		/// DAC Field Name: Status 
		/// DAC: PX.Objects.PO.POReceipt 
		/// </summary>
		/// <remarks>
		/// 
		/// </remarks>
		[DataMember(Name="Status", EmitDefaultValue=false)]
		public StringValue? Status { get; set; }

		/// <summary>
		/// 
		/// Display Name:
		/// DAC Field Name: CuryOrderTotal 
		/// DAC: PX.Objects.PO.POReceipt 
		/// </summary>
		/// <remarks>
		/// 
		/// </remarks>
		[DataMember(Name="TotalCost", EmitDefaultValue=false)]
		public DecimalValue? TotalCost { get; set; }

		/// <summary>
		/// 
		/// Display Name:
		/// DAC Field Name: OrderQty 
		/// DAC: PX.Objects.PO.POReceipt 
		/// </summary>
		/// <remarks>
		/// 
		/// </remarks>
		[DataMember(Name="TotalQty", EmitDefaultValue=false)]
		public DecimalValue? TotalQty { get; set; }

		/// <summary>
		/// 
		/// Display Name:
		/// DAC Field Name: ReceiptType 
		/// DAC: PX.Objects.PO.POReceipt 
		/// </summary>
		/// <remarks>
		/// 
		/// </remarks>
		[DataMember(Name="Type", EmitDefaultValue=false)]
		public StringValue? Type { get; set; }

		/// <summary>
		/// 
		/// Display Name:
		/// DAC Field Name: UnbilledQty 
		/// DAC: PX.Objects.PO.POReceipt 
		/// </summary>
		/// <remarks>
		/// 
		/// </remarks>
		[DataMember(Name="UnbilledQuantity", EmitDefaultValue=false)]
		public DecimalValue? UnbilledQuantity { get; set; }

		/// <summary>
		/// 
		/// Display Name:
		/// DAC Field Name: VendorID 
		/// DAC: PX.Objects.PO.POReceipt 
		/// </summary>
		/// <remarks>
		/// 
		/// </remarks>
		[DataMember(Name="VendorID", EmitDefaultValue=false)]
		public StringValue? VendorID { get; set; }

		/// <summary>
		/// 
		/// Display Name:
		/// DAC Field Name: InvoiceNbr 
		/// DAC: PX.Objects.PO.POReceipt 
		/// </summary>
		/// <remarks>
		/// 
		/// </remarks>
		[DataMember(Name="VendorRef", EmitDefaultValue=false)]
		public StringValue? VendorRef { get; set; }

		/// <summary>
		/// 
		/// Display Name:
		/// DAC Field Name: SiteID 
		/// DAC: PX.Objects.PO.POReceipt 
		/// </summary>
		/// <remarks>
		/// 
		/// </remarks>
		[DataMember(Name="Warehouse", EmitDefaultValue=false)]
		public StringValue? Warehouse { get; set; }

		public virtual string GetEndpointPath()
		{
			return "entity/Default/23.200.001";
		}
	}
}