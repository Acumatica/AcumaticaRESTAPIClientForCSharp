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
	/// Corresponds to the screen IN201000 in the Acumatica ERP
	/// </summary>
	[DataContract]
	public class ItemClass : Entity, ITopLevelEntity
	{

		[DataMember(Name="Attributes", EmitDefaultValue=false)]
		public List<ItemClassAtrribute>? Attributes { get; set; }

		/// <summary>
		/// DAC Field Name: AvailabilitySchemeID 
		/// DAC: PX.Objects.IN.INItemClass 
		/// Display Name: Availability Calculation Rule 
		/// SQL Type: nvarchar(10) 
		/// </summary>
		[DataMember(Name="AvailabilityCalculationRule", EmitDefaultValue=false)]
		public StringValue? AvailabilityCalculationRule { get; set; }

		/// <summary>
		/// DAC Field Name: BaseUnit 
		/// DAC: PX.Objects.IN.INItemClass 
		/// Display Name: Base Unit 
		/// SQL Type: nvarchar(6) 
		/// </summary>
		[DataMember(Name="BaseUOM", EmitDefaultValue=false)]
		public StringValue? BaseUOM { get; set; }

		/// <summary>
		/// DAC Field Name: ItemClassCD 
		/// DAC: PX.Objects.IN.INItemClass 
		/// Display Name: Class ID 
		/// SQL Type: nvarchar(30) 
		/// Key Field
		/// </summary>
		[DataMember(Name="ClassID", EmitDefaultValue=false)]
		public StringValue? ClassID { get; set; }

		/// <summary>
		/// DAC: PX.Objects.IN.INItemClass 
		/// Display Name: Country Of Origin 
		/// SQL Type: nvarchar(2) 
		/// </summary>
		[DataMember(Name="CountryOfOrigin", EmitDefaultValue=false)]
		public StringValue? CountryOfOrigin { get; set; }

		/// <summary>
		/// The default Warehouse used to store the items of this kind.Applicable only for Stock Items (see StkItem) and when the Warehouses feature is enabled.
		/// DAC Field Name: DfltSiteID 
		/// DAC: PX.Objects.IN.INItemClassCurySettings 
		/// Display Name: Default Warehouse 
		/// </summary>
		[DataMember(Name="DefaultWarehouseID", EmitDefaultValue=false)]
		public StringValue? DefaultWarehouseID { get; set; }

		/// <summary>
		/// DAC Field Name: Descr 
		/// DAC: PX.Objects.IN.INItemClass 
		/// SQL Type: nvarchar(256) 
		/// </summary>
		[DataMember(Name="Description", EmitDefaultValue=false)]
		public StringValue? Description { get; set; }

		/// <summary>
		/// DAC: PX.Objects.IN.INItemClass 
		/// Display Name: Item Type 
		/// SQL Type: char(1) 
		/// </summary>
		[DataMember(Name="ItemType", EmitDefaultValue=false)]
		public StringValue? ItemType { get; set; }

		[DataMember(Name="LastModifiedDateTime", EmitDefaultValue=false)]
		public DateTimeValue? LastModifiedDateTime { get; set; }

		/// <summary>
		/// DAC Field Name: LotSerClassID 
		/// DAC: PX.Objects.IN.INItemClass 
		/// Display Name: Lot/Serial Class 
		/// SQL Type: nvarchar(10) 
		/// </summary>
		[DataMember(Name="LotSerialClass", EmitDefaultValue=false)]
		public StringValue? LotSerialClass { get; set; }

		/// <summary>
		/// DAC Field Name: PostClassID 
		/// DAC: PX.Objects.IN.INItemClass 
		/// Display Name: Posting Class 
		/// SQL Type: nvarchar(10) 
		/// </summary>
		[DataMember(Name="PostingClass", EmitDefaultValue=false)]
		public StringValue? PostingClass { get; set; }

		/// <summary>
		/// DAC Field Name: PriceClassID 
		/// DAC: PX.Objects.IN.INItemClass 
		/// Display Name: Price Class 
		/// SQL Type: nvarchar(10) 
		/// </summary>
		[DataMember(Name="PriceClass", EmitDefaultValue=false)]
		public StringValue? PriceClass { get; set; }

		/// <summary>
		/// DAC Field Name: PurchaseUnit 
		/// DAC: PX.Objects.IN.INItemClass 
		/// Display Name: Purchase Unit 
		/// SQL Type: nvarchar(6) 
		/// </summary>
		[DataMember(Name="PurchaseUOM", EmitDefaultValue=false)]
		public StringValue? PurchaseUOM { get; set; }

		/// <summary>
		/// DAC Field Name: SalesUnit 
		/// DAC: PX.Objects.IN.INItemClass 
		/// Display Name: Sales Unit 
		/// SQL Type: nvarchar(6) 
		/// </summary>
		[DataMember(Name="SalesUOM", EmitDefaultValue=false)]
		public StringValue? SalesUOM { get; set; }

		/// <summary>
		/// DAC Field Name: StkItem 
		/// DAC: PX.Objects.IN.INItemClass 
		/// Display Name: Stock Item 
		/// </summary>
		[DataMember(Name="StockItem", EmitDefaultValue=false)]
		public BooleanValue? StockItem { get; set; }

		/// <summary>
		/// DAC Field Name: HSTariffCode 
		/// DAC: PX.Objects.IN.INItemClass 
		/// Display Name: Commodity Code 
		/// SQL Type: nvarchar(30) 
		/// </summary>
		[DataMember(Name="TariffCode", EmitDefaultValue=false)]
		public StringValue? TariffCode { get; set; }

		/// <summary>
		/// DAC: PX.Objects.IN.INItemClass 
		/// Display Name: Tax Category 
		/// SQL Type: nvarchar(15) 
		/// </summary>
		[DataMember(Name="TaxCategoryID", EmitDefaultValue=false)]
		public StringValue? TaxCategoryID { get; set; }

		/// <summary>
		/// DAC Field Name: ValMethod 
		/// DAC: PX.Objects.IN.INItemClass 
		/// Display Name: Valuation Method 
		/// SQL Type: char(1) 
		/// </summary>
		[DataMember(Name="ValuationMethod", EmitDefaultValue=false)]
		public StringValue? ValuationMethod { get; set; }

		public virtual string GetEndpointPath()
		{
			return "entity/Default/23.200.001";
		}
	}
}