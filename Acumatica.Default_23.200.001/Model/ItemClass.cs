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
		/// 
		/// Display Name:
		/// DAC Field Name: AvailabilitySchemeID 
		/// DAC: PX.Objects.IN.INItemClass 
		/// </summary>
		/// <remarks>
		/// 
		/// </remarks>
		[DataMember(Name="AvailabilityCalculationRule", EmitDefaultValue=false)]
		public StringValue? AvailabilityCalculationRule { get; set; }

		/// <summary>
		/// 
		/// Display Name:
		/// DAC Field Name: BaseUnit 
		/// DAC: PX.Objects.IN.INItemClass 
		/// </summary>
		/// <remarks>
		/// 
		/// </remarks>
		[DataMember(Name="BaseUOM", EmitDefaultValue=false)]
		public StringValue? BaseUOM { get; set; }

		/// <summary>
		/// 
		/// Display Name:
		/// DAC Field Name: ItemClassCD 
		/// DAC: PX.Objects.IN.INItemClass 
		/// </summary>
		/// <remarks>
		/// 
		/// </remarks>
		[DataMember(Name="ClassID", EmitDefaultValue=false)]
		public StringValue? ClassID { get; set; }

		/// <summary>
		/// 
		/// Display Name:
		/// DAC Field Name: CountryOfOrigin 
		/// DAC: PX.Objects.IN.INItemClass 
		/// </summary>
		/// <remarks>
		/// 
		/// </remarks>
		[DataMember(Name="CountryOfOrigin", EmitDefaultValue=false)]
		public StringValue? CountryOfOrigin { get; set; }

		/// <summary>
		/// 
		/// Display Name:
		/// DAC Field Name: DfltSiteID 
		/// DAC: PX.Objects.IN.INItemClassCurySettings 
		/// </summary>
		/// <remarks>
		/// 
		/// </remarks>
		[DataMember(Name="DefaultWarehouseID", EmitDefaultValue=false)]
		public StringValue? DefaultWarehouseID { get; set; }

		/// <summary>
		/// 
		/// Display Name:
		/// DAC Field Name: Descr 
		/// DAC: PX.Objects.IN.INItemClass 
		/// </summary>
		/// <remarks>
		/// 
		/// </remarks>
		[DataMember(Name="Description", EmitDefaultValue=false)]
		public StringValue? Description { get; set; }

		/// <summary>
		/// 
		/// Display Name:
		/// DAC Field Name: ItemType 
		/// DAC: PX.Objects.IN.INItemClass 
		/// </summary>
		/// <remarks>
		/// 
		/// </remarks>
		[DataMember(Name="ItemType", EmitDefaultValue=false)]
		public StringValue? ItemType { get; set; }

		[DataMember(Name="LastModifiedDateTime", EmitDefaultValue=false)]
		public DateTimeValue? LastModifiedDateTime { get; set; }

		/// <summary>
		/// 
		/// Display Name:
		/// DAC Field Name: LotSerClassID 
		/// DAC: PX.Objects.IN.INItemClass 
		/// </summary>
		/// <remarks>
		/// 
		/// </remarks>
		[DataMember(Name="LotSerialClass", EmitDefaultValue=false)]
		public StringValue? LotSerialClass { get; set; }

		/// <summary>
		/// 
		/// Display Name:
		/// DAC Field Name: PostClassID 
		/// DAC: PX.Objects.IN.INItemClass 
		/// </summary>
		/// <remarks>
		/// 
		/// </remarks>
		[DataMember(Name="PostingClass", EmitDefaultValue=false)]
		public StringValue? PostingClass { get; set; }

		/// <summary>
		/// 
		/// Display Name:
		/// DAC Field Name: PriceClassID 
		/// DAC: PX.Objects.IN.INItemClass 
		/// </summary>
		/// <remarks>
		/// 
		/// </remarks>
		[DataMember(Name="PriceClass", EmitDefaultValue=false)]
		public StringValue? PriceClass { get; set; }

		/// <summary>
		/// 
		/// Display Name:
		/// DAC Field Name: PurchaseUnit 
		/// DAC: PX.Objects.IN.INItemClass 
		/// </summary>
		/// <remarks>
		/// 
		/// </remarks>
		[DataMember(Name="PurchaseUOM", EmitDefaultValue=false)]
		public StringValue? PurchaseUOM { get; set; }

		/// <summary>
		/// 
		/// Display Name:
		/// DAC Field Name: SalesUnit 
		/// DAC: PX.Objects.IN.INItemClass 
		/// </summary>
		/// <remarks>
		/// 
		/// </remarks>
		[DataMember(Name="SalesUOM", EmitDefaultValue=false)]
		public StringValue? SalesUOM { get; set; }

		/// <summary>
		/// 
		/// Display Name:
		/// DAC Field Name: StkItem 
		/// DAC: PX.Objects.IN.INItemClass 
		/// </summary>
		/// <remarks>
		/// 
		/// </remarks>
		[DataMember(Name="StockItem", EmitDefaultValue=false)]
		public BooleanValue? StockItem { get; set; }

		/// <summary>
		/// 
		/// Display Name:
		/// DAC Field Name: HSTariffCode 
		/// DAC: PX.Objects.IN.INItemClass 
		/// </summary>
		/// <remarks>
		/// 
		/// </remarks>
		[DataMember(Name="TariffCode", EmitDefaultValue=false)]
		public StringValue? TariffCode { get; set; }

		/// <summary>
		/// 
		/// Display Name:
		/// DAC Field Name: TaxCategoryID 
		/// DAC: PX.Objects.IN.INItemClass 
		/// </summary>
		/// <remarks>
		/// 
		/// </remarks>
		[DataMember(Name="TaxCategoryID", EmitDefaultValue=false)]
		public StringValue? TaxCategoryID { get; set; }

		/// <summary>
		/// 
		/// Display Name:
		/// DAC Field Name: ValMethod 
		/// DAC: PX.Objects.IN.INItemClass 
		/// </summary>
		/// <remarks>
		/// 
		/// </remarks>
		[DataMember(Name="ValuationMethod", EmitDefaultValue=false)]
		public StringValue? ValuationMethod { get; set; }

		public virtual string GetEndpointPath()
		{
			return "entity/Default/23.200.001";
		}
	}
}