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
	public class VendorPriceWorksheetDetail : Entity
	{

		/// <summary>
		/// <para>DAC: PX.Objects.AP.APPriceWorksheetDetail</para>
		/// <para>Display Name: Break Qty</para>
		/// </summary>
		[DataMember(Name="BreakQty", EmitDefaultValue=false)]
		public DecimalValue? BreakQty { get; set; }

		/// <summary>
		/// <para>DAC Field Name: CuryID</para>
		/// <para>DAC: PX.Objects.AP.APPriceWorksheetDetail</para>
		/// <para>Display Name: Currency</para>
		/// <para>SQL Type: nvarchar(5)</para>
		/// </summary>
		[DataMember(Name="CurrencyID", EmitDefaultValue=false)]
		public StringValue? CurrencyID { get; set; }

		/// <summary>
		/// <para>DAC Field Name: InventoryCD</para>
		/// <para>DAC: PX.Objects.AP.APAddItemSelected</para>
		/// <para>Display Name: Inventory ID</para>
		/// <para>SQL Type: nvarchar(30)</para>
		/// </summary>
		[DataMember(Name="Description", EmitDefaultValue=false)]
		public StringValue? Description { get; set; }

		/// <summary>
		/// <para>DAC: PX.Objects.AP.APPriceWorksheetDetail</para>
		/// <para>Display Name: Inventory ID</para>
		/// </summary>
		[DataMember(Name="InventoryID", EmitDefaultValue=false)]
		public StringValue? InventoryID { get; set; }

		[DataMember(Name="LineID", EmitDefaultValue=false)]
		public IntValue? LineID { get; set; }

		/// <summary>
		/// <para>DAC: PX.Objects.AP.APPriceWorksheetDetail</para>
		/// <para>Display Name: Pending Price</para>
		/// </summary>
		[DataMember(Name="PendingPrice", EmitDefaultValue=false)]
		public DecimalValue? PendingPrice { get; set; }

		/// <summary>
		/// <para>DAC Field Name: RefNbr</para>
		/// <para>DAC: PX.Objects.AP.APPriceWorksheet</para>
		/// <para>Display Name: Reference Nbr.</para>
		/// <para>SQL Type: nvarchar(15)</para>
		/// Key Field
		/// </summary>
		[DataMember(Name="ReferenceNbr", EmitDefaultValue=false)]
		public StringValue? ReferenceNbr { get; set; }

		/// <summary>
		/// <para>DAC Field Name: CurrentPrice</para>
		/// <para>DAC: PX.Objects.AP.APPriceWorksheetDetail</para>
		/// <para>Display Name: Source Price</para>
		/// </summary>
		[DataMember(Name="SourcePrice", EmitDefaultValue=false)]
		public DecimalValue? SourcePrice { get; set; }

		/// <summary>
		/// <para>DAC Field Name: TaxID</para>
		/// <para>DAC: PX.Objects.AP.APPriceWorksheetDetail</para>
		/// <para>SQL Type: nvarchar(60)</para>
		/// </summary>
		[DataMember(Name="Tax", EmitDefaultValue=false)]
		public StringValue? Tax { get; set; }

		/// <summary>
		/// <para>DAC: PX.Objects.AP.APPriceWorksheetDetail</para>
		/// <para>SQL Type: nvarchar(6)</para>
		/// </summary>
		[DataMember(Name="UOM", EmitDefaultValue=false)]
		public StringValue? UOM { get; set; }

		/// <summary>
		/// <para>DAC Field Name: VendorID</para>
		/// <para>DAC: PX.Objects.AP.APPriceWorksheetDetail</para>
		/// </summary>
		[DataMember(Name="Vendor", EmitDefaultValue=false)]
		public StringValue? Vendor { get; set; }

	}
}