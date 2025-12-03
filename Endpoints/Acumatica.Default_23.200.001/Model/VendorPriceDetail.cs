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
	public class VendorPriceDetail : Entity
	{

		/// <summary>
		/// <para>DAC: PX.Objects.AP.APVendorPrice</para>
		/// <para>Display Name: Break Qty</para>
		/// </summary>
		[DataMember(Name="BreakQty", EmitDefaultValue=false)]
		public DecimalValue? BreakQty { get; set; }

		[DataMember(Name="CreatedDateTime", EmitDefaultValue=false)]
		public DateTimeValue? CreatedDateTime { get; set; }

		/// <summary>
		/// <para>DAC Field Name: CuryID</para>
		/// <para>DAC: PX.Objects.AP.APVendorPrice</para>
		/// <para>Display Name: Currency</para>
		/// <para>SQL Type: nvarchar(5)</para>
		/// </summary>
		[DataMember(Name="CurrencyID", EmitDefaultValue=false)]
		public StringValue? CurrencyID { get; set; }

		/// <summary>
		/// <para>DAC Field Name: InventoryID_InventoryItem_Descr</para>
		/// <para>DAC: PX.Objects.AP.APVendorPrice</para>
		/// </summary>
		[DataMember(Name="Description", EmitDefaultValue=false)]
		public StringValue? Description { get; set; }

		/// <summary>
		/// <para>DAC: PX.Objects.AP.APVendorPrice</para>
		/// <para>Display Name: Effective Date</para>
		/// </summary>
		[DataMember(Name="EffectiveDate", EmitDefaultValue=false)]
		public DateTimeValue? EffectiveDate { get; set; }

		/// <summary>
		/// <para>DAC: PX.Objects.AP.APVendorPrice</para>
		/// <para>Display Name: Expiration Date</para>
		/// </summary>
		[DataMember(Name="ExpirationDate", EmitDefaultValue=false)]
		public DateTimeValue? ExpirationDate { get; set; }

		/// <summary>
		/// <para>DAC: PX.Objects.AP.APVendorPriceFilter</para>
		/// <para>Display Name: Inventory ID</para>
		/// </summary>
		[DataMember(Name="InventoryID", EmitDefaultValue=false)]
		public StringValue? InventoryID { get; set; }

		[DataMember(Name="LastModifiedDateTime", EmitDefaultValue=false)]
		public DateTimeValue? LastModifiedDateTime { get; set; }

		/// <summary>
		/// <para>DAC Field Name: SalesPrice</para>
		/// <para>DAC: PX.Objects.AP.APVendorPrice</para>
		/// </summary>
		[DataMember(Name="Price", EmitDefaultValue=false)]
		public DecimalValue? Price { get; set; }

		/// <summary>
		/// <para>DAC Field Name: IsPromotionalPrice</para>
		/// <para>DAC: PX.Objects.AP.APVendorPrice</para>
		/// </summary>
		[DataMember(Name="Promotional", EmitDefaultValue=false)]
		public BooleanValue? Promotional { get; set; }

		[DataMember(Name="RecordID", EmitDefaultValue=false)]
		public IntValue? RecordID { get; set; }

		/// <summary>
		/// <para>DAC: PX.Objects.AP.APVendorPrice</para>
		/// <para>SQL Type: nvarchar(6)</para>
		/// </summary>
		[DataMember(Name="UOM", EmitDefaultValue=false)]
		public StringValue? UOM { get; set; }

		/// <summary>
		/// <para>DAC Field Name: VendorID</para>
		/// <para>DAC: PX.Objects.AP.APVendorPriceFilter</para>
		/// </summary>
		[DataMember(Name="Vendor", EmitDefaultValue=false)]
		public StringValue? Vendor { get; set; }

		/// <summary>
		/// <para>DAC Field Name: VendorID_Vendor_AcctName</para>
		/// <para>DAC: PX.Objects.AP.APVendorPrice</para>
		/// </summary>
		[DataMember(Name="VendorName", EmitDefaultValue=false)]
		public StringValue? VendorName { get; set; }

	}
}