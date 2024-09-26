using System;
using System.Collections.Generic;
using System.Runtime.Serialization;

using Newtonsoft.Json;

using Acumatica.RESTClient.Client;
using Acumatica.RESTClient.ContractBasedApi;
using Acumatica.RESTClient.ContractBasedApi.Model;

namespace Acumatica.Default_24_200_001.Model
{
	/// <summary>
	/// Corresponds to the screen IN203000 in the Acumatica ERP
	/// </summary>
	[DataContract]
	public class TemplateItems : Entity, ITopLevelEntity
	{

		/// <summary>
		/// 
		/// Display Name:
		/// DAC Field Name: SalesUnit 
		/// DAC: PX.Objects.IN.InventoryItem 
		/// </summary>
		/// <remarks>
		/// 
		/// </remarks>
		[DataMember(Name="SalesUOM", EmitDefaultValue=false)]
		public StringValue? SalesUOM { get; set; }

		/// <summary>
		/// 
		/// Display Name:
		/// DAC Field Name: RecPrice 
		/// DAC: PX.Objects.IN.InventoryItemCurySettings 
		/// </summary>
		/// <remarks>
		/// 
		/// </remarks>
		[DataMember(Name="CurySpecificMSRP", EmitDefaultValue=false)]
		public DecimalValue? CurySpecificMSRP { get; set; }

		/// <summary>
		/// 
		/// Display Name:
		/// DAC Field Name: BasePrice 
		/// DAC: PX.Objects.IN.InventoryItemCurySettings 
		/// </summary>
		/// <remarks>
		/// 
		/// </remarks>
		[DataMember(Name="CurySpecificPrice", EmitDefaultValue=false)]
		public DecimalValue? CurySpecificPrice { get; set; }

		/// <summary>
		/// 
		/// Display Name:
		/// DAC Field Name: ItemClassID 
		/// DAC: PX.Objects.IN.InventoryItem 
		/// </summary>
		/// <remarks>
		/// 
		/// </remarks>
		[DataMember(Name="ItemClass", EmitDefaultValue=false)]
		public StringValue? ItemClass { get; set; }

		/// <summary>
		/// 
		/// Display Name:
		/// DAC Field Name: Availability 
		/// DAC: PX.Objects.IN.InventoryItem 
		/// </summary>
		/// <remarks>
		/// 
		/// </remarks>
		[DataMember(Name="Availability", EmitDefaultValue=false)]
		public StringValue? Availability { get; set; }

		[DataMember(Name="Attributes", EmitDefaultValue=false)]
		public List<AttributeValue>? Attributes { get; set; }

		/// <summary>
		/// 
		/// Display Name:
		/// DAC Field Name: BaseUnit 
		/// DAC: PX.Objects.IN.InventoryItem 
		/// </summary>
		/// <remarks>
		/// 
		/// </remarks>
		[DataMember(Name="BaseUOM", EmitDefaultValue=false)]
		public StringValue? BaseUOM { get; set; }

		[DataMember(Name="Categories", EmitDefaultValue=false)]
		public List<CategoryStockItem>? Categories { get; set; }

		/// <summary>
		/// 
		/// Display Name:
		/// DAC Field Name: Body 
		/// DAC: PX.Objects.IN.InventoryItem 
		/// </summary>
		/// <remarks>
		/// 
		/// </remarks>
		[DataMember(Name="Content", EmitDefaultValue=false)]
		public StringValue? Content { get; set; }

		/// <summary>
		/// 
		/// Display Name:
		/// DAC Field Name: StdCost 
		/// DAC: PX.Objects.IN.InventoryItemCurySettings 
		/// </summary>
		/// <remarks>
		/// 
		/// </remarks>
		[DataMember(Name="CurrentStdCost", EmitDefaultValue=false)]
		public DecimalValue? CurrentStdCost { get; set; }

		/// <summary>
		/// 
		/// Display Name:
		/// DAC Field Name: CustomURL 
		/// DAC: PX.Objects.IN.InventoryItem 
		/// </summary>
		/// <remarks>
		/// 
		/// </remarks>
		[DataMember(Name="CustomURL", EmitDefaultValue=false)]
		public StringValue? CustomURL { get; set; }

		[DataMember(Name="DefaultIssueLocationID", EmitDefaultValue=false)]
		public StringValue? DefaultIssueLocationID { get; set; }

		/// <summary>
		/// 
		/// Display Name:
		/// DAC Field Name: BasePrice 
		/// DAC: PX.Objects.IN.InventoryItemCurySettings 
		/// </summary>
		/// <remarks>
		/// 
		/// </remarks>
		[DataMember(Name="DefaultPrice", EmitDefaultValue=false)]
		public DecimalValue? DefaultPrice { get; set; }

		/// <summary>
		/// 
		/// Display Name:
		/// DAC Field Name: Descr 
		/// DAC: PX.Objects.IN.InventoryItem 
		/// </summary>
		/// <remarks>
		/// 
		/// </remarks>
		[DataMember(Name="Description", EmitDefaultValue=false)]
		public StringValue? Description { get; set; }

		/// <summary>
		/// 
		/// Display Name:
		/// DAC Field Name: BaseItemWeight 
		/// DAC: PX.Objects.IN.InventoryItem 
		/// </summary>
		/// <remarks>
		/// 
		/// </remarks>
		[DataMember(Name="DimensionWeight", EmitDefaultValue=false)]
		public DecimalValue? DimensionWeight { get; set; }

		/// <summary>
		/// 
		/// Display Name:
		/// DAC Field Name: ExportToExternal 
		/// DAC: PX.Objects.IN.InventoryItem 
		/// </summary>
		/// <remarks>
		/// 
		/// </remarks>
		[DataMember(Name="ExportToExternal", EmitDefaultValue=false)]
		public BooleanValue? ExportToExternal { get; set; }

		[DataMember(Name="FileURLs", EmitDefaultValue=false)]
		public List<InventoryFileUrls>? FileURLs { get; set; }

		/// <summary>
		/// 
		/// Display Name:
		/// DAC Field Name: InventoryCD 
		/// DAC: PX.Objects.IN.InventoryItem 
		/// </summary>
		/// <remarks>
		/// 
		/// </remarks>
		[DataMember(Name="InventoryID", EmitDefaultValue=false)]
		public StringValue? InventoryID { get; set; }

		/// <summary>
		/// 
		/// Display Name:
		/// DAC Field Name: StkItem 
		/// DAC: PX.Objects.IN.InventoryItem 
		/// </summary>
		/// <remarks>
		/// 
		/// </remarks>
		[DataMember(Name="IsStockItem", EmitDefaultValue=false)]
		public BooleanValue? IsStockItem { get; set; }

		/// <summary>
		/// 
		/// Display Name:
		/// DAC Field Name: ItemStatus 
		/// DAC: PX.Objects.IN.InventoryItem 
		/// </summary>
		/// <remarks>
		/// 
		/// </remarks>
		[DataMember(Name="ItemStatus", EmitDefaultValue=false)]
		public StringValue? ItemStatus { get; set; }

		/// <summary>
		/// 
		/// Display Name:
		/// DAC Field Name: LastModifiedDateTime 
		/// DAC: PX.Objects.IN.Matrix.DAC.Unbound.MatrixInventoryItem 
		/// </summary>
		/// <remarks>
		/// 
		/// </remarks>
		[DataMember(Name="LastModified", EmitDefaultValue=false)]
		public DateTimeValue? LastModified { get; set; }

		/// <summary>
		/// 
		/// Display Name:
		/// DAC Field Name: LastModifiedDateTime 
		/// DAC: PX.Objects.IN.Matrix.DAC.Unbound.MatrixInventoryItem 
		/// </summary>
		/// <remarks>
		/// 
		/// </remarks>
		[DataMember(Name="LastModifiedDateTime", EmitDefaultValue=false)]
		public DateTimeValue? LastModifiedDateTime { get; set; }

		[DataMember(Name="Matrix", EmitDefaultValue=false)]
		public List<MatrixItems>? Matrix { get; set; }

		/// <summary>
		/// 
		/// Display Name:
		/// DAC Field Name: MetaDescription 
		/// DAC: PX.Objects.IN.InventoryItem 
		/// </summary>
		/// <remarks>
		/// 
		/// </remarks>
		[DataMember(Name="MetaDescription", EmitDefaultValue=false)]
		public StringValue? MetaDescription { get; set; }

		/// <summary>
		/// 
		/// Display Name:
		/// DAC Field Name: RecPrice 
		/// DAC: PX.Objects.IN.InventoryItemCurySettings 
		/// </summary>
		/// <remarks>
		/// 
		/// </remarks>
		[DataMember(Name="MSRP", EmitDefaultValue=false)]
		public DecimalValue? MSRP { get; set; }

		/// <summary>
		/// 
		/// Display Name:
		/// DAC Field Name: PageTitle 
		/// DAC: PX.Objects.IN.InventoryItem 
		/// </summary>
		/// <remarks>
		/// 
		/// </remarks>
		[DataMember(Name="PageTitle", EmitDefaultValue=false)]
		public StringValue? PageTitle { get; set; }

		/// <summary>
		/// 
		/// Display Name:
		/// DAC Field Name: SearchKeywords 
		/// DAC: PX.Objects.IN.InventoryItem 
		/// </summary>
		/// <remarks>
		/// 
		/// </remarks>
		[DataMember(Name="SearchKeywords", EmitDefaultValue=false)]
		public StringValue? SearchKeywords { get; set; }

		[DataMember(Name="TaxCategory", EmitDefaultValue=false)]
		public StringValue? TaxCategory { get; set; }

		/// <summary>
		/// 
		/// Display Name:
		/// DAC Field Name: Visibility 
		/// DAC: PX.Objects.IN.InventoryItem 
		/// </summary>
		/// <remarks>
		/// 
		/// </remarks>
		[DataMember(Name="Visibility", EmitDefaultValue=false)]
		public StringValue? Visibility { get; set; }

		/// <summary>
		/// 
		/// Display Name:
		/// DAC Field Name: WeightUOM 
		/// DAC: PX.Objects.IN.InventoryItem 
		/// </summary>
		/// <remarks>
		/// 
		/// </remarks>
		[DataMember(Name="WeightUOM", EmitDefaultValue=false)]
		public StringValue? WeightUOM { get; set; }

		/// <summary>
		/// 
		/// Display Name:
		/// DAC Field Name: MetaKeywords 
		/// DAC: PX.Objects.IN.InventoryItem 
		/// </summary>
		/// <remarks>
		/// 
		/// </remarks>
		[DataMember(Name="MetaKeywords", EmitDefaultValue=false)]
		public StringValue? MetaKeywords { get; set; }

		/// <summary>
		/// 
		/// Display Name:
		/// DAC Field Name: NonStockShip 
		/// DAC: PX.Objects.IN.InventoryItem 
		/// </summary>
		/// <remarks>
		/// 
		/// </remarks>
		[DataMember(Name="RequireShipment", EmitDefaultValue=false)]
		public BooleanValue? RequireShipment { get; set; }

		/// <summary>
		/// 
		/// Display Name:
		/// DAC Field Name: NotAvailMode 
		/// DAC: PX.Objects.IN.InventoryItem 
		/// </summary>
		/// <remarks>
		/// 
		/// </remarks>
		[DataMember(Name="NotAvailable", EmitDefaultValue=false)]
		public StringValue? NotAvailable { get; set; }

		[DataMember(Name="VendorDetails", EmitDefaultValue=false)]
		public List<TemplateItemVendorDetail>? VendorDetails { get; set; }

		public virtual string GetEndpointPath()
		{
			return "entity/Default/24.200.001";
		}
	}
}