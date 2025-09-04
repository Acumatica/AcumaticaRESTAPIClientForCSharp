using System;
using System.Collections.Generic;
using System.Runtime.Serialization;

using Newtonsoft.Json;

using Acumatica.RESTClient.Client;
using Acumatica.RESTClient.ContractBasedApi;
using Acumatica.RESTClient.ContractBasedApi.Model;

namespace Acumatica.Default_24_200_001.Model
{
	[DataContract]
	public class SalesPricesWorksheetDetail : Entity
	{

		/// <summary>
		/// DAC: PX.Objects.AR.ARPriceWorksheetDetail 
		/// Display Name: Break Qty 
		/// </summary>
		[DataMember(Name="BreakQty", EmitDefaultValue=false)]
		public DecimalValue? BreakQty { get; set; }

		/// <summary>
		/// DAC Field Name: CuryID 
		/// DAC: PX.Objects.AR.ARPriceWorksheetDetail 
		/// Display Name: Currency 
		/// SQL Type: nvarchar(5) 
		/// </summary>
		[DataMember(Name="CurrencyID", EmitDefaultValue=false)]
		public StringValue? CurrencyID { get; set; }

		/// <summary>
		/// DAC Field Name: InventoryCD 
		/// DAC: PX.Objects.AR.ARAddItemSelected 
		/// Display Name: Inventory ID 
		/// SQL Type: nvarchar(30) 
		/// </summary>
		[DataMember(Name="Description", EmitDefaultValue=false)]
		public StringValue? Description { get; set; }

		/// <summary>
		/// DAC: PX.Objects.AR.ARPriceWorksheetDetail 
		/// Display Name: Inventory ID 
		/// </summary>
		[DataMember(Name="InventoryID", EmitDefaultValue=false)]
		public StringValue? InventoryID { get; set; }

		[DataMember(Name="LineID", EmitDefaultValue=false)]
		public IntValue? LineID { get; set; }

		/// <summary>
		/// DAC: PX.Objects.AR.ARPriceWorksheetDetail 
		/// Display Name: Pending Price 
		/// </summary>
		[DataMember(Name="PendingPrice", EmitDefaultValue=false)]
		public DecimalValue? PendingPrice { get; set; }

		/// <summary>
		/// DAC: PX.Objects.AR.ARPriceWorksheetDetail 
		/// Display Name: Price Code 
		/// SQL Type: nvarchar(30) 
		/// </summary>
		[DataMember(Name="PriceCode", EmitDefaultValue=false)]
		public StringValue? PriceCode { get; set; }

		/// <summary>
		/// DAC: PX.Objects.AR.ARPriceWorksheetDetail 
		/// Display Name: Price Type 
		/// SQL Type: char(1) 
		/// </summary>
		[DataMember(Name="PriceType", EmitDefaultValue=false)]
		public StringValue? PriceType { get; set; }

		/// <summary>
		/// DAC Field Name: RefNbr 
		/// DAC: PX.Objects.AR.ARPriceWorksheet 
		/// Display Name: Reference Nbr. 
		/// SQL Type: nvarchar(15) 
		/// Key Field
		/// </summary>
		[DataMember(Name="ReferenceNbr", EmitDefaultValue=false)]
		public StringValue? ReferenceNbr { get; set; }

		/// <summary>
		/// DAC Field Name: CurrentPrice 
		/// DAC: PX.Objects.AR.ARPriceWorksheetDetail 
		/// Display Name: Source Price 
		/// </summary>
		[DataMember(Name="SourcePrice", EmitDefaultValue=false)]
		public DecimalValue? SourcePrice { get; set; }

		/// <summary>
		/// DAC Field Name: TaxID 
		/// DAC: PX.Objects.AR.ARPriceWorksheetDetail 
		/// SQL Type: nvarchar(60) 
		/// </summary>
		[DataMember(Name="Tax", EmitDefaultValue=false)]
		public StringValue? Tax { get; set; }

		/// <summary>
		/// DAC: PX.Objects.AR.ARPriceWorksheetDetail 
		/// SQL Type: nvarchar(6) 
		/// </summary>
		[DataMember(Name="UOM", EmitDefaultValue=false)]
		public StringValue? UOM { get; set; }

	}
}