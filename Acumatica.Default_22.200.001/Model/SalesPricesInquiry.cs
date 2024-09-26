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
		/// 
		/// Display Name:
		/// DAC Field Name: EffectiveAsOfDate 
		/// DAC: PX.Objects.AR.ARSalesPriceFilter 
		/// </summary>
		/// <remarks>
		/// 
		/// </remarks>
		[DataMember(Name="EffectiveAsOf", EmitDefaultValue=false)]
		public DateTimeValue? EffectiveAsOf { get; set; }

		/// <summary>
		/// 
		/// Display Name:
		/// DAC Field Name: InventoryID 
		/// DAC: PX.Objects.AR.ARSalesPriceFilter 
		/// </summary>
		/// <remarks>
		/// 
		/// </remarks>
		[DataMember(Name="InventoryID", EmitDefaultValue=false)]
		public StringValue? InventoryID { get; set; }

		/// <summary>
		/// 
		/// Display Name:
		/// DAC Field Name: ItemClassCD 
		/// DAC: PX.Objects.AR.ARSalesPriceFilter 
		/// </summary>
		/// <remarks>
		/// 
		/// </remarks>
		[DataMember(Name="ItemClassID", EmitDefaultValue=false)]
		public StringValue? ItemClassID { get; set; }

		/// <summary>
		/// 
		/// Display Name:
		/// DAC Field Name: InventoryPriceClassID 
		/// DAC: PX.Objects.AR.ARSalesPriceFilter 
		/// </summary>
		/// <remarks>
		/// 
		/// </remarks>
		[DataMember(Name="PriceClass", EmitDefaultValue=false)]
		public StringValue? PriceClass { get; set; }

		/// <summary>
		/// 
		/// Display Name:
		/// DAC Field Name: PriceCode 
		/// DAC: PX.Objects.AR.ARSalesPriceFilter 
		/// </summary>
		/// <remarks>
		/// 
		/// </remarks>
		[DataMember(Name="PriceCode", EmitDefaultValue=false)]
		public StringValue? PriceCode { get; set; }

		/// <summary>
		/// 
		/// Display Name:
		/// DAC Field Name: OwnerID 
		/// DAC: PX.Objects.AR.ARSalesPriceFilter 
		/// </summary>
		/// <remarks>
		/// 
		/// </remarks>
		[DataMember(Name="PriceManager", EmitDefaultValue=false)]
		public StringValue? PriceManager { get; set; }

		/// <summary>
		/// 
		/// Display Name:
		/// DAC Field Name: MyOwner 
		/// DAC: PX.Objects.AR.ARSalesPriceFilter 
		/// </summary>
		/// <remarks>
		/// 
		/// </remarks>
		[DataMember(Name="PriceManagerIsMe", EmitDefaultValue=false)]
		public BooleanValue? PriceManagerIsMe { get; set; }

		/// <summary>
		/// 
		/// Display Name:
		/// DAC Field Name: PriceType 
		/// DAC: PX.Objects.AR.ARSalesPriceFilter 
		/// </summary>
		/// <remarks>
		/// 
		/// </remarks>
		[DataMember(Name="PriceType", EmitDefaultValue=false)]
		public StringValue? PriceType { get; set; }

		/// <summary>
		/// 
		/// Display Name:
		/// DAC Field Name: WorkGroupID 
		/// DAC: PX.Objects.AR.ARSalesPriceFilter 
		/// </summary>
		/// <remarks>
		/// 
		/// </remarks>
		[DataMember(Name="PriceWorkgroup", EmitDefaultValue=false)]
		public StringValue? PriceWorkgroup { get; set; }

		/// <summary>
		/// 
		/// Display Name:
		/// DAC Field Name: MyWorkGroup 
		/// DAC: PX.Objects.AR.ARSalesPriceFilter 
		/// </summary>
		/// <remarks>
		/// 
		/// </remarks>
		[DataMember(Name="PriceWorkgroupIsMine", EmitDefaultValue=false)]
		public BooleanValue? PriceWorkgroupIsMine { get; set; }

		[DataMember(Name="SalesPriceDetails", EmitDefaultValue=false)]
		public List<SalesPriceDetail>? SalesPriceDetails { get; set; }

		/// <summary>
		/// 
		/// Display Name:
		/// DAC Field Name: TaxCalcMode 
		/// DAC: PX.Objects.AR.ARSalesPriceFilter 
		/// </summary>
		/// <remarks>
		/// 
		/// </remarks>
		[DataMember(Name="TaxCalculationMode", EmitDefaultValue=false)]
		public StringValue? TaxCalculationMode { get; set; }

		public virtual string GetEndpointPath()
		{
			return "entity/Default/22.200.001";
		}
	}
}