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
	/// Corresponds to the screen AM312000 in the Acumatica ERP
	/// </summary>
	[DataContract]
	public class LateAssignment : Entity, ITopLevelEntity
	{

		[DataMember(Name="AllocatedDetail", EmitDefaultValue=false)]
		public List<LateAssignmentAllocatedDetail>? AllocatedDetail { get; set; }

		/// <summary>
		/// 
		/// Display Name:
		/// DAC Field Name: QtyComplete 
		/// DAC: PX.Objects.AM.AMProdItemSplitPreassign 
		/// </summary>
		/// <remarks>
		/// 
		/// </remarks>
		[DataMember(Name="CompleteQty", EmitDefaultValue=false)]
		public DecimalValue? CompleteQty { get; set; }

		/// <summary>
		/// 
		/// Display Name:
		/// DAC Field Name: InventoryID 
		/// DAC: PX.Objects.AM.AMProdItemSplitPreassign 
		/// </summary>
		/// <remarks>
		/// 
		/// </remarks>
		[DataMember(Name="InventoryID", EmitDefaultValue=false)]
		public StringValue? InventoryID { get; set; }

		/// <summary>
		/// 
		/// Display Name:
		/// DAC Field Name: LotSerialNbr 
		/// DAC: PX.Objects.AM.AMProdItemSplitPreassign 
		/// </summary>
		/// <remarks>
		/// 
		/// </remarks>
		[DataMember(Name="LotSerialNbr", EmitDefaultValue=false)]
		public StringValue? LotSerialNbr { get; set; }

		/// <summary>
		/// 
		/// Display Name:
		/// DAC Field Name: OrderType 
		/// DAC: PX.Objects.AM.AMProdItemSplitPreassign 
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
		/// DAC: PX.Objects.AM.AMProdItemSplitPreassign 
		/// </summary>
		/// <remarks>
		/// 
		/// </remarks>
		[DataMember(Name="ProductionNbr", EmitDefaultValue=false)]
		public StringValue? ProductionNbr { get; set; }

		/// <summary>
		/// 
		/// Display Name:
		/// DAC Field Name: Qty 
		/// DAC: PX.Objects.AM.AMProdItemSplitPreassign 
		/// </summary>
		/// <remarks>
		/// 
		/// </remarks>
		[DataMember(Name="QtytoProduce", EmitDefaultValue=false)]
		public DecimalValue? QtytoProduce { get; set; }

		/// <summary>
		/// 
		/// Display Name:
		/// DAC Field Name: QtyRemaining 
		/// DAC: PX.Objects.AM.AMProdItemSplitPreassign 
		/// </summary>
		/// <remarks>
		/// 
		/// </remarks>
		[DataMember(Name="RemainingQty", EmitDefaultValue=false)]
		public DecimalValue? RemainingQty { get; set; }

		/// <summary>
		/// 
		/// Display Name:
		/// DAC Field Name: QtyScrapped 
		/// DAC: PX.Objects.AM.AMProdItemSplitPreassign 
		/// </summary>
		/// <remarks>
		/// 
		/// </remarks>
		[DataMember(Name="ScrappedQty", EmitDefaultValue=false)]
		public DecimalValue? ScrappedQty { get; set; }

		/// <summary>
		/// 
		/// Display Name:
		/// DAC Field Name: StatusID 
		/// DAC: PX.Objects.AM.AMProdItemSplitPreassign 
		/// </summary>
		/// <remarks>
		/// 
		/// </remarks>
		[DataMember(Name="Status", EmitDefaultValue=false)]
		public StringValue? Status { get; set; }

		[DataMember(Name="UnallocatedDetail", EmitDefaultValue=false)]
		public List<LateAssignmentUnallocatedDetail>? UnallocatedDetail { get; set; }

		/// <summary>
		/// 
		/// Display Name:
		/// DAC Field Name: SiteId 
		/// DAC: PX.Objects.AM.AMProdItemSplitPreassign 
		/// </summary>
		/// <remarks>
		/// 
		/// </remarks>
		[DataMember(Name="Warehouse", EmitDefaultValue=false)]
		public StringValue? Warehouse { get; set; }

		public virtual string GetEndpointPath()
		{
			return "entity/MANUFACTURING/23.100.001";
		}
	}
}