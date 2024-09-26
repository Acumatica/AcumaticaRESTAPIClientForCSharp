using System;
using System.Collections.Generic;
using System.Runtime.Serialization;

using Newtonsoft.Json;

using Acumatica.RESTClient.Client;
using Acumatica.RESTClient.ContractBasedApi;
using Acumatica.RESTClient.ContractBasedApi.Model;

namespace Acumatica.Manufacturing_23_200_001.Model
{
	/// <summary>
	/// Corresponds to the screen AM500000 in the Acumatica ERP
	/// </summary>
	[DataContract]
	public class ReleaseProductionOrders : Entity, ITopLevelEntity
	{

		/// <summary>
		/// 
		/// Display Name:
		/// DAC Field Name: BranchID 
		/// DAC: PX.Objects.AM.AMProdItem 
		/// </summary>
		/// <remarks>
		/// 
		/// </remarks>
		[DataMember(Name="Branch", EmitDefaultValue=false)]
		public StringValue? Branch { get; set; }

		/// <summary>
		/// 
		/// Display Name:
		/// DAC Field Name: CostCodeID 
		/// DAC: PX.Objects.AM.AMProdItem 
		/// </summary>
		/// <remarks>
		/// 
		/// </remarks>
		[DataMember(Name="CostCode", EmitDefaultValue=false)]
		public StringValue? CostCode { get; set; }

		/// <summary>
		/// 
		/// Display Name:
		/// DAC Field Name: CustomerID 
		/// DAC: PX.Objects.AM.AMProdItem 
		/// </summary>
		/// <remarks>
		/// 
		/// </remarks>
		[DataMember(Name="Customer", EmitDefaultValue=false)]
		public StringValue? Customer { get; set; }

		/// <summary>
		/// 
		/// Display Name:
		/// DAC Field Name: InventoryID_InventoryItem_descr 
		/// DAC: PX.Objects.AM.AMProdItem 
		/// </summary>
		/// <remarks>
		/// 
		/// </remarks>
		[DataMember(Name="Description", EmitDefaultValue=false)]
		public StringValue? Description { get; set; }

		/// <summary>
		/// 
		/// Display Name:
		/// DAC Field Name: EndDate 
		/// DAC: PX.Objects.AM.AMProdItem 
		/// </summary>
		/// <remarks>
		/// 
		/// </remarks>
		[DataMember(Name="EndDate", EmitDefaultValue=false)]
		public DateTimeValue? EndDate { get; set; }

		/// <summary>
		/// 
		/// Display Name:
		/// DAC Field Name: InventoryID 
		/// DAC: PX.Objects.AM.AMProdItem 
		/// </summary>
		/// <remarks>
		/// 
		/// </remarks>
		[DataMember(Name="InventoryID", EmitDefaultValue=false)]
		public StringValue? InventoryID { get; set; }

		/// <summary>
		/// 
		/// Display Name:
		/// DAC Field Name: ProdDate 
		/// DAC: PX.Objects.AM.AMProdItem 
		/// </summary>
		/// <remarks>
		/// 
		/// </remarks>
		[DataMember(Name="OrderDate", EmitDefaultValue=false)]
		public DateTimeValue? OrderDate { get; set; }

		/// <summary>
		/// 
		/// Display Name:
		/// DAC Field Name: OrderType 
		/// DAC: PX.Objects.AM.AMProdItem 
		/// </summary>
		/// <remarks>
		/// 
		/// </remarks>
		[DataMember(Name="OrderType", EmitDefaultValue=false)]
		public StringValue? OrderType { get; set; }

		/// <summary>
		/// 
		/// Display Name:
		/// DAC Field Name: ProdOrdID 
		/// DAC: PX.Objects.AM.AMProdItem 
		/// </summary>
		/// <remarks>
		/// 
		/// </remarks>
		[DataMember(Name="ProductionNbr", EmitDefaultValue=false)]
		public StringValue? ProductionNbr { get; set; }

		/// <summary>
		/// 
		/// Display Name:
		/// DAC Field Name: ProjectID 
		/// DAC: PX.Objects.AM.AMProdItem 
		/// </summary>
		/// <remarks>
		/// 
		/// </remarks>
		[DataMember(Name="Project", EmitDefaultValue=false)]
		public StringValue? Project { get; set; }

		/// <summary>
		/// 
		/// Display Name:
		/// DAC Field Name: TaskID 
		/// DAC: PX.Objects.AM.AMProdItem 
		/// </summary>
		/// <remarks>
		/// 
		/// </remarks>
		[DataMember(Name="ProjectTask", EmitDefaultValue=false)]
		public StringValue? ProjectTask { get; set; }

		/// <summary>
		/// 
		/// Display Name:
		/// DAC Field Name: QtytoProd 
		/// DAC: PX.Objects.AM.AMProdItem 
		/// </summary>
		/// <remarks>
		/// 
		/// </remarks>
		[DataMember(Name="QtytoProduce", EmitDefaultValue=false)]
		public DecimalValue? QtytoProduce { get; set; }

		/// <summary>
		/// 
		/// Display Name:
		/// DAC Field Name: Selected 
		/// DAC: PX.Objects.AM.AMProdItem 
		/// </summary>
		/// <remarks>
		/// 
		/// </remarks>
		[DataMember(Name="Selected", EmitDefaultValue=false)]
		public BooleanValue? Selected { get; set; }

		/// <summary>
		/// 
		/// Display Name:
		/// DAC Field Name: OrdNbr 
		/// DAC: PX.Objects.AM.AMProdItem 
		/// </summary>
		/// <remarks>
		/// 
		/// </remarks>
		[DataMember(Name="SOOrderNbr", EmitDefaultValue=false)]
		public StringValue? SOOrderNbr { get; set; }

		/// <summary>
		/// 
		/// Display Name:
		/// DAC Field Name: OrdTypeRef 
		/// DAC: PX.Objects.AM.AMProdItem 
		/// </summary>
		/// <remarks>
		/// 
		/// </remarks>
		[DataMember(Name="SOOrderType", EmitDefaultValue=false)]
		public StringValue? SOOrderType { get; set; }

		/// <summary>
		/// 
		/// Display Name:
		/// DAC Field Name: DetailSource 
		/// DAC: PX.Objects.AM.AMProdItem 
		/// </summary>
		/// <remarks>
		/// 
		/// </remarks>
		[DataMember(Name="Source", EmitDefaultValue=false)]
		public StringValue? Source { get; set; }

		/// <summary>
		/// 
		/// Display Name:
		/// DAC Field Name: StartDate 
		/// DAC: PX.Objects.AM.AMProdItem 
		/// </summary>
		/// <remarks>
		/// 
		/// </remarks>
		[DataMember(Name="StartDate", EmitDefaultValue=false)]
		public DateTimeValue? StartDate { get; set; }

		/// <summary>
		/// 
		/// Display Name:
		/// DAC Field Name: SubItemID 
		/// DAC: PX.Objects.AM.AMProdItem 
		/// </summary>
		/// <remarks>
		/// 
		/// </remarks>
		[DataMember(Name="Subitem", EmitDefaultValue=false)]
		public StringValue? Subitem { get; set; }

		/// <summary>
		/// 
		/// Display Name:
		/// DAC Field Name: UOM 
		/// DAC: PX.Objects.AM.AMProdItem 
		/// </summary>
		/// <remarks>
		/// 
		/// </remarks>
		[DataMember(Name="UOM", EmitDefaultValue=false)]
		public StringValue? UOM { get; set; }

		/// <summary>
		/// 
		/// Display Name:
		/// DAC Field Name: SiteId 
		/// DAC: PX.Objects.AM.AMProdItem 
		/// </summary>
		/// <remarks>
		/// 
		/// </remarks>
		[DataMember(Name="Warehouse", EmitDefaultValue=false)]
		public StringValue? Warehouse { get; set; }

		public virtual string GetEndpointPath()
		{
			return "entity/MANUFACTURING/23.200.001";
		}
	}
}