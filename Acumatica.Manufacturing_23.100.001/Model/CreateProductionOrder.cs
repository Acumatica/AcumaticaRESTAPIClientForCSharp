using System;
using System.Collections.Generic;
using System.Runtime.Serialization;

using Newtonsoft.Json;

using Acumatica.RESTClient.Client;
using Acumatica.RESTClient.ContractBasedApi;
using Acumatica.RESTClient.ContractBasedApi.Model;

namespace Acumatica.Manufacturing_23_100_001.Model
{
	/// <summary>
	/// Corresponds to the screen AM510000 in the Acumatica ERP
	/// </summary>
	[DataContract]
	public class CreateProductionOrder : Entity, ITopLevelEntity
	{

		/// <summary>
		/// DAC: PX.Objects.AM.CreateProductionOrdersProcess+ProductionOrdersCreateFilter 
		/// </summary>
		[DataMember(Name="CreationDate", EmitDefaultValue=false)]
		public DateTimeValue? CreationDate { get; set; }

		/// <summary>
		/// DAC: PX.Objects.AM.CreateProductionOrdersProcess+ProductionOrdersCreateFilter 
		/// </summary>
		[DataMember(Name="CreationOrderType", EmitDefaultValue=false)]
		public StringValue? CreationOrderType { get; set; }

		/// <summary>
		/// DAC Field Name: CustomerID 
		/// DAC: PX.Objects.AM.CreateProductionOrdersProcess+ProductionOrdersCreateFilter 
		/// </summary>
		[DataMember(Name="Customer", EmitDefaultValue=false)]
		public StringValue? Customer { get; set; }

		[DataMember(Name="Documents", EmitDefaultValue=false)]
		public List<CreateProductionDocuments>? Documents { get; set; }

		/// <summary>
		/// DAC: PX.Objects.AM.CreateProductionOrdersProcess+ProductionOrdersCreateFilter 
		/// </summary>
		[DataMember(Name="InventoryID", EmitDefaultValue=false)]
		public StringValue? InventoryID { get; set; }

		/// <summary>
		/// DAC Field Name: ItemClassCD 
		/// DAC: PX.Objects.AM.CreateProductionOrdersProcess+ProductionOrdersCreateFilter 
		/// </summary>
		[DataMember(Name="ItemClassID", EmitDefaultValue=false)]
		public StringValue? ItemClassID { get; set; }

		/// <summary>
		/// DAC Field Name: MyOwner 
		/// DAC: PX.Objects.AM.CreateProductionOrdersProcess+ProductionOrdersCreateFilter 
		/// </summary>
		[DataMember(Name="Me", EmitDefaultValue=false)]
		public BooleanValue? Me { get; set; }

		/// <summary>
		/// DAC Field Name: MyWorkGroup 
		/// DAC: PX.Objects.AM.CreateProductionOrdersProcess+ProductionOrdersCreateFilter 
		/// </summary>
		[DataMember(Name="My", EmitDefaultValue=false)]
		public BooleanValue? My { get; set; }

		/// <summary>
		/// DAC Field Name: OrderType 
		/// DAC: PX.Objects.AM.CreateProductionOrdersProcess+ProductionOrdersCreateFilter 
		/// </summary>
		[DataMember(Name="ProdOrderType", EmitDefaultValue=false)]
		public StringValue? ProdOrderType { get; set; }

		/// <summary>
		/// DAC Field Name: ProdOrdID 
		/// DAC: PX.Objects.AM.CreateProductionOrdersProcess+ProductionOrdersCreateFilter 
		/// </summary>
		[DataMember(Name="ProductionNbr", EmitDefaultValue=false)]
		public StringValue? ProductionNbr { get; set; }

		/// <summary>
		/// DAC Field Name: OwnerID 
		/// DAC: PX.Objects.AM.CreateProductionOrdersProcess+ProductionOrdersCreateFilter 
		/// </summary>
		[DataMember(Name="ProductManager", EmitDefaultValue=false)]
		public StringValue? ProductManager { get; set; }

		/// <summary>
		/// DAC Field Name: WorkGroupID 
		/// DAC: PX.Objects.AM.CreateProductionOrdersProcess+ProductionOrdersCreateFilter 
		/// </summary>
		[DataMember(Name="ProductWorkgroup", EmitDefaultValue=false)]
		public StringValue? ProductWorkgroup { get; set; }

		/// <summary>
		/// DAC: PX.Objects.AM.CreateProductionOrdersProcess+ProductionOrdersCreateFilter 
		/// </summary>
		[DataMember(Name="RequestedOnEndDate", EmitDefaultValue=false)]
		public DateTimeValue? RequestedOnEndDate { get; set; }

		/// <summary>
		/// DAC: PX.Objects.AM.CreateProductionOrdersProcess+ProductionOrdersCreateFilter 
		/// </summary>
		[DataMember(Name="RequestedOnStartDate", EmitDefaultValue=false)]
		public DateTimeValue? RequestedOnStartDate { get; set; }

		/// <summary>
		/// DAC: PX.Objects.AM.CreateProductionOrdersProcess+ProductionOrdersCreateFilter 
		/// </summary>
		[DataMember(Name="SOOrderNbr", EmitDefaultValue=false)]
		public StringValue? SOOrderNbr { get; set; }

		/// <summary>
		/// DAC: PX.Objects.AM.CreateProductionOrdersProcess+ProductionOrdersCreateFilter 
		/// </summary>
		[DataMember(Name="SOOrderType", EmitDefaultValue=false)]
		public StringValue? SOOrderType { get; set; }

		/// <summary>
		/// DAC Field Name: SiteID 
		/// DAC: PX.Objects.AM.CreateProductionOrdersProcess+ProductionOrdersCreateFilter 
		/// </summary>
		[DataMember(Name="WarehouseID", EmitDefaultValue=false)]
		public StringValue? WarehouseID { get; set; }

		public virtual string GetEndpointPath()
		{
			return "entity/MANUFACTURING/23.100.001";
		}
	}
}