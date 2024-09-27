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
		/// DAC Field Name: BaseCuryID 
		/// DAC: {} 
		/// </summary>
		[DataMember(Name="BaseCurrencyID", EmitDefaultValue=false)]
		public StringValue? BaseCurrencyID { get; set; }

		/// <summary>
		/// DAC Field Name: InvoiceDate 
		/// DAC: PX.Objects.PO.POReceipt 
		/// Display Name: Bill Date 
		/// </summary>
		[DataMember(Name="BillDate", EmitDefaultValue=false)]
		public DateTimeValue? BillDate { get; set; }

		/// <summary>
		/// DAC Field Name: BranchID 
		/// DAC: PX.Objects.PO.POReceipt 
		/// </summary>
		[DataMember(Name="Branch", EmitDefaultValue=false)]
		public StringValue? Branch { get; set; }

		/// <summary>
		/// DAC: PX.Objects.PO.POReceipt 
		/// Display Name: Control Qty. 
		/// </summary>
		[DataMember(Name="ControlQty", EmitDefaultValue=false)]
		public DecimalValue? ControlQty { get; set; }

		/// <summary>
		/// DAC Field Name: AutoCreateInvoice 
		/// DAC: PX.Objects.PO.POReceipt 
		/// Display Name: Create Bill 
		/// </summary>
		[DataMember(Name="CreateBill", EmitDefaultValue=false)]
		public BooleanValue? CreateBill { get; set; }

		/// <summary>
		/// DAC Field Name: CuryID 
		/// DAC: PX.Objects.PO.POReceipt 
		/// Display Name: Currency 
		/// SQL Type: nvarchar(5) 
		/// </summary>
		[DataMember(Name="CurrencyID", EmitDefaultValue=false)]
		public StringValue? CurrencyID { get; set; }

		/// <summary>
		/// DAC Field Name: CuryEffDate 
		/// DAC: {} 
		/// </summary>
		[DataMember(Name="CurrencyEffectiveDate", EmitDefaultValue=false)]
		public DateTimeValue? CurrencyEffectiveDate { get; set; }

		/// <summary>
		/// DAC Field Name: SampleCuryRate 
		/// DAC: {} 
		/// </summary>
		[DataMember(Name="CurrencyRate", EmitDefaultValue=false)]
		public DecimalValue? CurrencyRate { get; set; }

		/// <summary>
		/// DAC Field Name: CuryRateTypeID 
		/// DAC: {} 
		/// </summary>
		[DataMember(Name="CurrencyRateTypeID", EmitDefaultValue=false)]
		public StringValue? CurrencyRateTypeID { get; set; }

		/// <summary>
		/// DAC Field Name: SampleRecipRate 
		/// DAC: {} 
		/// </summary>
		[DataMember(Name="CurrencyReciprocalRate", EmitDefaultValue=false)]
		public DecimalValue? CurrencyReciprocalRate { get; set; }

		/// <summary>
		/// DAC Field Name: ReceiptDate 
		/// DAC: PX.Objects.PO.POReceipt 
		/// </summary>
		[DataMember(Name="Date", EmitDefaultValue=false)]
		public DateTimeValue? Date { get; set; }

		[DataMember(Name="Details", EmitDefaultValue=false)]
		public List<PurchaseReceiptDetail>? Details { get; set; }

		[DataMember(Name="Hold", EmitDefaultValue=false)]
		public BooleanValue? Hold { get; set; }

		/// <summary>
		/// DAC: PX.Objects.PO.POReceipt 
		/// Display Name: IN Ref. Nbr. 
		/// SQL Type: nvarchar(15) 
		/// </summary>
		[DataMember(Name="InventoryRefNbr", EmitDefaultValue=false)]
		public StringValue? InventoryRefNbr { get; set; }

		[DataMember(Name="LastModifiedDateTime", EmitDefaultValue=false)]
		public DateTimeValue? LastModifiedDateTime { get; set; }

		/// <summary>
		/// DAC Field Name: VendorLocationID 
		/// DAC: PX.Objects.PO.POReceipt 
		/// </summary>
		[DataMember(Name="Location", EmitDefaultValue=false)]
		public StringValue? Location { get; set; }

		/// <summary>
		/// DAC Field Name: FinPeriodID 
		/// DAC: PX.Objects.PO.POReceipt 
		/// Display Name: Post Period 
		/// SQL Type: char(6) 
		/// </summary>
		[DataMember(Name="PostPeriod", EmitDefaultValue=false)]
		public StringValue? PostPeriod { get; set; }

		[DataMember(Name="ProcessReturnWithOriginalCost", EmitDefaultValue=false)]
		public BooleanValue? ProcessReturnWithOriginalCost { get; set; }

		/// <summary>
		/// DAC: PX.Objects.PO.POReceipt 
		/// Display Name: Receipt Nbr. 
		/// SQL Type: nvarchar(15) 
		/// Key Field
		/// </summary>
		[DataMember(Name="ReceiptNbr", EmitDefaultValue=false)]
		public StringValue? ReceiptNbr { get; set; }

		/// <summary>
		/// DAC: PX.Objects.PO.POReceipt 
		/// SQL Type: char(1) 
		/// </summary>
		[DataMember(Name="Status", EmitDefaultValue=false)]
		public StringValue? Status { get; set; }

		/// <summary>
		/// DAC Field Name: CuryOrderTotal 
		/// DAC: PX.Objects.PO.POReceipt 
		/// Display Name: Total Cost 
		/// </summary>
		[DataMember(Name="TotalCost", EmitDefaultValue=false)]
		public DecimalValue? TotalCost { get; set; }

		/// <summary>
		/// DAC Field Name: OrderQty 
		/// DAC: PX.Objects.PO.POReceipt 
		/// Display Name: Total Qty. 
		/// </summary>
		[DataMember(Name="TotalQty", EmitDefaultValue=false)]
		public DecimalValue? TotalQty { get; set; }

		/// <summary>
		/// DAC Field Name: ReceiptType 
		/// DAC: PX.Objects.PO.POReceipt 
		/// SQL Type: char(2) 
		/// Key Field
		/// </summary>
		[DataMember(Name="Type", EmitDefaultValue=false)]
		public StringValue? Type { get; set; }

		/// <summary>
		/// DAC Field Name: UnbilledQty 
		/// DAC: PX.Objects.PO.POReceipt 
		/// Display Name: Unbilled Quantity 
		/// </summary>
		[DataMember(Name="UnbilledQuantity", EmitDefaultValue=false)]
		public DecimalValue? UnbilledQuantity { get; set; }

		/// <summary>
		/// DAC: PX.Objects.PO.POReceipt 
		/// Display Name: Vendor 
		/// </summary>
		[DataMember(Name="VendorID", EmitDefaultValue=false)]
		public StringValue? VendorID { get; set; }

		/// <summary>
		/// DAC Field Name: InvoiceNbr 
		/// DAC: PX.Objects.PO.POReceipt 
		/// Display Name: Vendor Ref. 
		/// SQL Type: nvarchar(40) 
		/// </summary>
		[DataMember(Name="VendorRef", EmitDefaultValue=false)]
		public StringValue? VendorRef { get; set; }

		/// <summary>
		/// DAC Field Name: SiteID 
		/// DAC: PX.Objects.PO.POReceipt 
		/// </summary>
		[DataMember(Name="Warehouse", EmitDefaultValue=false)]
		public StringValue? Warehouse { get; set; }

		public virtual string GetEndpointPath()
		{
			return "entity/Default/23.200.001";
		}
	}
}