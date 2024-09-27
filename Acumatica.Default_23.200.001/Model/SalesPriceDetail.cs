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
	public class SalesPriceDetail : Entity
	{

		/// <summary>
		/// DAC: PX.Objects.AR.ARSalesPrice 
		/// Display Name: Break Qty 
		/// </summary>
		[DataMember(Name="BreakQty", EmitDefaultValue=false)]
		public DecimalValue? BreakQty { get; set; }

		[DataMember(Name="CreatedDateTime", EmitDefaultValue=false)]
		public DateTimeValue? CreatedDateTime { get; set; }

		/// <summary>
		/// DAC Field Name: CuryID 
		/// DAC: PX.Objects.AR.ARSalesPrice 
		/// Display Name: Currency 
		/// SQL Type: nvarchar(5) 
		/// </summary>
		[DataMember(Name="CurrencyID", EmitDefaultValue=false)]
		public StringValue? CurrencyID { get; set; }

		/// <summary>
		/// DAC: PX.Objects.AR.ARSalesPrice 
		/// SQL Type: nvarchar(256) 
		/// </summary>
		[DataMember(Name="Description", EmitDefaultValue=false)]
		public StringValue? Description { get; set; }

		/// <summary>
		/// DAC: PX.Objects.AR.ARSalesPrice 
		/// Display Name: Effective Date 
		/// </summary>
		[DataMember(Name="EffectiveDate", EmitDefaultValue=false)]
		public DateTimeValue? EffectiveDate { get; set; }

		/// <summary>
		/// DAC: PX.Objects.AR.ARSalesPrice 
		/// Display Name: Expiration Date 
		/// </summary>
		[DataMember(Name="ExpirationDate", EmitDefaultValue=false)]
		public DateTimeValue? ExpirationDate { get; set; }

		/// <summary>
		/// DAC: PX.Objects.AR.ARSalesPriceFilter 
		/// Display Name: Inventory ID 
		/// </summary>
		[DataMember(Name="InventoryID", EmitDefaultValue=false)]
		public StringValue? InventoryID { get; set; }

		[DataMember(Name="LastModifiedDateTime", EmitDefaultValue=false)]
		public DateTimeValue? LastModifiedDateTime { get; set; }

		/// <summary>
		/// DAC Field Name: SalesPrice 
		/// DAC: PX.Objects.AR.ARSalesPrice 
		/// </summary>
		[DataMember(Name="Price", EmitDefaultValue=false)]
		public DecimalValue? Price { get; set; }

		/// <summary>
		/// DAC: PX.Objects.AR.ARSalesPriceFilter 
		/// Display Name: Price Code 
		/// SQL Type: varchar(30) 
		/// </summary>
		[DataMember(Name="PriceCode", EmitDefaultValue=false)]
		public StringValue? PriceCode { get; set; }

		/// <summary>
		/// DAC: PX.Objects.AR.ARSalesPriceFilter 
		/// Display Name: Price Type 
		/// SQL Type: char(1) 
		/// </summary>
		[DataMember(Name="PriceType", EmitDefaultValue=false)]
		public StringValue? PriceType { get; set; }

		/// <summary>
		/// DAC Field Name: IsPromotionalPrice 
		/// DAC: PX.Objects.AR.ARSalesPrice 
		/// </summary>
		[DataMember(Name="Promotion", EmitDefaultValue=false)]
		public BooleanValue? Promotion { get; set; }

		[DataMember(Name="RecordID", EmitDefaultValue=false)]
		public IntValue? RecordID { get; set; }

		/// <summary>
		/// DAC Field Name: TaxID 
		/// DAC: PX.Objects.AR.ARSalesPrice 
		/// SQL Type: nvarchar(60) 
		/// </summary>
		[DataMember(Name="Tax", EmitDefaultValue=false)]
		public StringValue? Tax { get; set; }

		/// <summary>
		/// DAC: PX.Objects.AR.ARSalesPrice 
		/// SQL Type: nvarchar(6) 
		/// </summary>
		[DataMember(Name="UOM", EmitDefaultValue=false)]
		public StringValue? UOM { get; set; }

		[DataMember(Name="NoteID", EmitDefaultValue=false)]
		public GuidValue? NoteID { get; set; }

		[DataMember(Name="Warehouse", EmitDefaultValue=false)]
		public StringValue? Warehouse { get; set; }

		[DataMember(Name="TaxCalculationMode", EmitDefaultValue=false)]
		public StringValue? TaxCalculationMode { get; set; }

	}
}