using System;
using System.Collections.Generic;
using System.Runtime.Serialization;

using Newtonsoft.Json;

using Acumatica.RESTClient.Client;
using Acumatica.RESTClient.ContractBasedApi;
using Acumatica.RESTClient.ContractBasedApi.Model;

namespace Acumatica.Default_22_200_001.Model
{
	/// <summary>
	/// Corresponds to the screen AR202000 in the Acumatica ERP
	/// </summary>
	[DataContract]
	public class SalesPricesInquiry : Entity, ITopLevelEntity
	{

		/// <summary>
		/// DAC Field Name: EffectiveAsOfDate 
		/// DAC: PX.Objects.AR.ARSalesPriceFilter 
		/// Display Name: Effective As Of 
		/// </summary>
		[DataMember(Name="EffectiveAsOf", EmitDefaultValue=false)]
		public DateTimeValue? EffectiveAsOf { get; set; }

		/// <summary>
		/// DAC: PX.Objects.AR.ARSalesPriceFilter 
		/// Display Name: Inventory ID 
		/// </summary>
		[DataMember(Name="InventoryID", EmitDefaultValue=false)]
		public StringValue? InventoryID { get; set; }

		/// <summary>
		/// DAC Field Name: ItemClassCD 
		/// DAC: PX.Objects.AR.ARSalesPriceFilter 
		/// Display Name: Item Class ID 
		/// SQL Type: nvarchar(30) 
		/// </summary>
		[DataMember(Name="ItemClassID", EmitDefaultValue=false)]
		public StringValue? ItemClassID { get; set; }

		/// <summary>
		/// DAC Field Name: InventoryPriceClassID 
		/// DAC: PX.Objects.AR.ARSalesPriceFilter 
		/// Display Name: Price Class 
		/// SQL Type: varchar(10) 
		/// </summary>
		[DataMember(Name="PriceClass", EmitDefaultValue=false)]
		public StringValue? PriceClass { get; set; }

		/// <summary>
		/// DAC: PX.Objects.AR.ARSalesPriceFilter 
		/// Display Name: Price Code 
		/// SQL Type: varchar(30) 
		/// </summary>
		[DataMember(Name="PriceCode", EmitDefaultValue=false)]
		public StringValue? PriceCode { get; set; }

		/// <summary>
		/// DAC Field Name: OwnerID 
		/// DAC: PX.Objects.AR.ARSalesPriceFilter 
		/// Display Name: Price Manager 
		/// </summary>
		[DataMember(Name="PriceManager", EmitDefaultValue=false)]
		public StringValue? PriceManager { get; set; }

		/// <summary>
		/// DAC Field Name: MyOwner 
		/// DAC: PX.Objects.AR.ARSalesPriceFilter 
		/// Display Name: Me 
		/// </summary>
		[DataMember(Name="PriceManagerIsMe", EmitDefaultValue=false)]
		public BooleanValue? PriceManagerIsMe { get; set; }

		/// <summary>
		/// DAC: PX.Objects.AR.ARSalesPriceFilter 
		/// Display Name: Price Type 
		/// SQL Type: char(1) 
		/// </summary>
		[DataMember(Name="PriceType", EmitDefaultValue=false)]
		public StringValue? PriceType { get; set; }

		/// <summary>
		/// DAC Field Name: WorkGroupID 
		/// DAC: PX.Objects.AR.ARSalesPriceFilter 
		/// Display Name: Price Workgroup 
		/// </summary>
		[DataMember(Name="PriceWorkgroup", EmitDefaultValue=false)]
		public StringValue? PriceWorkgroup { get; set; }

		/// <summary>
		/// DAC Field Name: MyWorkGroup 
		/// DAC: PX.Objects.AR.ARSalesPriceFilter 
		/// Display Name: My 
		/// </summary>
		[DataMember(Name="PriceWorkgroupIsMine", EmitDefaultValue=false)]
		public BooleanValue? PriceWorkgroupIsMine { get; set; }

		[DataMember(Name="SalesPriceDetails", EmitDefaultValue=false)]
		public List<SalesPriceDetail>? SalesPriceDetails { get; set; }

		/// <summary>
		/// DAC Field Name: TaxCalcMode 
		/// DAC: PX.Objects.AR.ARSalesPriceFilter 
		/// Display Name: Tax Calculation Mode 
		/// SQL Type: nchar(1) 
		/// </summary>
		[DataMember(Name="TaxCalculationMode", EmitDefaultValue=false)]
		public StringValue? TaxCalculationMode { get; set; }

		public virtual string GetEndpointPath()
		{
			return "entity/Default/22.200.001";
		}
	}
}