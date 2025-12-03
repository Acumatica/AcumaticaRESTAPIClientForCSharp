using System;
using System.Collections.Generic;
using System.Runtime.Serialization;

using Newtonsoft.Json;

using Acumatica.RESTClient.Client;
using Acumatica.RESTClient.ContractBasedApi;
using Acumatica.RESTClient.ContractBasedApi.Model;

namespace Acumatica.Manufacturing_24_200_001.Model
{
	/// <summary>
	/// Corresponds to the screen <c>AM510000</c> in the Acumatica ERP
	/// </summary>
	[DataContract]
	public class CreateProductionOrder : Entity, ITopLevelEntity
	{

		/// <summary>
		/// <para>DAC: PX.Objects.AM.CreateProductionOrdersProcess+ProductionOrdersCreateFilter</para>
		/// </summary>
		[DataMember(Name="CreationDate", EmitDefaultValue=false)]
		public DateTimeValue? CreationDate { get; set; }

		/// <summary>
		/// <para>DAC: PX.Objects.AM.CreateProductionOrdersProcess+ProductionOrdersCreateFilter</para>
		/// </summary>
		[DataMember(Name="CreationOrderType", EmitDefaultValue=false)]
		public StringValue? CreationOrderType { get; set; }

		/// <summary>
		/// <para>DAC Field Name: CustomerID</para>
		/// <para>DAC: PX.Objects.AM.CreateProductionOrdersProcess+ProductionOrdersCreateFilter</para>
		/// </summary>
		[DataMember(Name="Customer", EmitDefaultValue=false)]
		public StringValue? Customer { get; set; }

		[DataMember(Name="Documents", EmitDefaultValue=false)]
		public List<CreateProductionDocuments>? Documents { get; set; }

		/// <summary>
		/// <para>DAC: PX.Objects.AM.CreateProductionOrdersProcess+ProductionOrdersCreateFilter</para>
		/// </summary>
		[DataMember(Name="InventoryID", EmitDefaultValue=false)]
		public StringValue? InventoryID { get; set; }

		/// <summary>
		/// <para>DAC Field Name: ItemClassCD</para>
		/// <para>DAC: PX.Objects.AM.CreateProductionOrdersProcess+ProductionOrdersCreateFilter</para>
		/// </summary>
		[DataMember(Name="ItemClassID", EmitDefaultValue=false)]
		public StringValue? ItemClassID { get; set; }

		/// <summary>
		/// <para>DAC Field Name: MyOwner</para>
		/// <para>DAC: PX.Objects.AM.CreateProductionOrdersProcess+ProductionOrdersCreateFilter</para>
		/// </summary>
		[DataMember(Name="Me", EmitDefaultValue=false)]
		public BooleanValue? Me { get; set; }

		/// <summary>
		/// <para>DAC Field Name: MyWorkGroup</para>
		/// <para>DAC: PX.Objects.AM.CreateProductionOrdersProcess+ProductionOrdersCreateFilter</para>
		/// </summary>
		[DataMember(Name="My", EmitDefaultValue=false)]
		public BooleanValue? My { get; set; }

		/// <summary>
		/// <para>DAC Field Name: OrderType</para>
		/// <para>DAC: PX.Objects.AM.CreateProductionOrdersProcess+ProductionOrdersCreateFilter</para>
		/// </summary>
		[DataMember(Name="ProdOrderType", EmitDefaultValue=false)]
		public StringValue? ProdOrderType { get; set; }

		/// <summary>
		/// <para>DAC Field Name: ProdOrdID</para>
		/// <para>DAC: PX.Objects.AM.CreateProductionOrdersProcess+ProductionOrdersCreateFilter</para>
		/// </summary>
		[DataMember(Name="ProductionNbr", EmitDefaultValue=false)]
		public StringValue? ProductionNbr { get; set; }

		/// <summary>
		/// <para>DAC Field Name: OwnerID</para>
		/// <para>DAC: PX.Objects.AM.CreateProductionOrdersProcess+ProductionOrdersCreateFilter</para>
		/// </summary>
		[DataMember(Name="ProductManager", EmitDefaultValue=false)]
		public StringValue? ProductManager { get; set; }

		/// <summary>
		/// <para>DAC Field Name: WorkGroupID</para>
		/// <para>DAC: PX.Objects.AM.CreateProductionOrdersProcess+ProductionOrdersCreateFilter</para>
		/// </summary>
		[DataMember(Name="ProductWorkgroup", EmitDefaultValue=false)]
		public StringValue? ProductWorkgroup { get; set; }

		/// <summary>
		/// <para>DAC: PX.Objects.AM.CreateProductionOrdersProcess+ProductionOrdersCreateFilter</para>
		/// </summary>
		[DataMember(Name="RequestedOnEndDate", EmitDefaultValue=false)]
		public DateTimeValue? RequestedOnEndDate { get; set; }

		/// <summary>
		/// <para>DAC: PX.Objects.AM.CreateProductionOrdersProcess+ProductionOrdersCreateFilter</para>
		/// </summary>
		[DataMember(Name="RequestedOnStartDate", EmitDefaultValue=false)]
		public DateTimeValue? RequestedOnStartDate { get; set; }

		/// <summary>
		/// <para>DAC: PX.Objects.AM.CreateProductionOrdersProcess+ProductionOrdersCreateFilter</para>
		/// </summary>
		[DataMember(Name="SOOrderNbr", EmitDefaultValue=false)]
		public StringValue? SOOrderNbr { get; set; }

		/// <summary>
		/// <para>DAC: PX.Objects.AM.CreateProductionOrdersProcess+ProductionOrdersCreateFilter</para>
		/// </summary>
		[DataMember(Name="SOOrderType", EmitDefaultValue=false)]
		public StringValue? SOOrderType { get; set; }

		/// <summary>
		/// <para>DAC Field Name: SiteID</para>
		/// <para>DAC: PX.Objects.AM.CreateProductionOrdersProcess+ProductionOrdersCreateFilter</para>
		/// </summary>
		[DataMember(Name="WarehouseID", EmitDefaultValue=false)]
		public StringValue? WarehouseID { get; set; }

		public static class Expand
		{
			public const string Files = "Files";
			public const string Documents = "Documents";
			public const string Documents_Files = "Documents/Files";

			//Intentionally excluded
			//public const string All = "Files,Documents,Documents/Files";
		}
		public virtual string GetEndpointPath()
		{
			return "entity/MANUFACTURING/24.200.001";
		}
	}
}