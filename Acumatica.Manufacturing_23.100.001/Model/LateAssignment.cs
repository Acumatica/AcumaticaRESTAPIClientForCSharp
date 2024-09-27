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
		/// DAC Field Name: QtyComplete 
		/// DAC: PX.Objects.AM.AMProdItemSplitPreassign 
		/// Display Name: Complete Qty. 
		/// </summary>
		[DataMember(Name="CompleteQty", EmitDefaultValue=false)]
		public DecimalValue? CompleteQty { get; set; }

		/// <summary>
		/// DAC: PX.Objects.AM.AMProdItemSplitPreassign 
		/// Display Name: Inventory ID 
		/// </summary>
		[DataMember(Name="InventoryID", EmitDefaultValue=false)]
		public StringValue? InventoryID { get; set; }

		/// <summary>
		/// DAC: PX.Objects.AM.AMProdItemSplitPreassign 
		/// Display Name: Lot/Serial Nbr. 
		/// SQL Type: nvarchar(100) 
		/// Key Field
		/// </summary>
		[DataMember(Name="LotSerialNbr", EmitDefaultValue=false)]
		public StringValue? LotSerialNbr { get; set; }

		/// <summary>
		/// DAC: PX.Objects.AM.AMProdItemSplitPreassign 
		/// Display Name: Order Type 
		/// SQL Type: char(2) 
		/// Key Field
		/// </summary>
		[DataMember(Name="OrderType", EmitDefaultValue=false)]
		public StringValue? OrderType { get; set; }

		/// <summary>
		/// DAC Field Name: ProdOrdID 
		/// DAC: PX.Objects.AM.AMProdItemSplitPreassign 
		/// Display Name: Production Nbr. 
		/// SQL Type: nvarchar(19) 
		/// Key Field
		/// </summary>
		[DataMember(Name="ProductionNbr", EmitDefaultValue=false)]
		public StringValue? ProductionNbr { get; set; }

		/// <summary>
		/// DAC Field Name: Qty 
		/// DAC: PX.Objects.AM.AMProdItemSplitPreassign 
		/// Display Name: Qty. to Produce 
		/// </summary>
		[DataMember(Name="QtytoProduce", EmitDefaultValue=false)]
		public DecimalValue? QtytoProduce { get; set; }

		/// <summary>
		/// Quantity remaining to be completed on the production order
		/// DAC Field Name: QtyRemaining 
		/// DAC: PX.Objects.AM.AMProdItemSplitPreassign 
		/// Display Name: Remaining Qty. 
		/// </summary>
		[DataMember(Name="RemainingQty", EmitDefaultValue=false)]
		public DecimalValue? RemainingQty { get; set; }

		/// <summary>
		/// DAC Field Name: QtyScrapped 
		/// DAC: PX.Objects.AM.AMProdItemSplitPreassign 
		/// Display Name: Scrapped Qty. 
		/// </summary>
		[DataMember(Name="ScrappedQty", EmitDefaultValue=false)]
		public DecimalValue? ScrappedQty { get; set; }

		/// <summary>
		/// DAC Field Name: StatusID 
		/// DAC: PX.Objects.AM.AMProdItemSplitPreassign 
		/// SQL Type: char(1) 
		/// </summary>
		[DataMember(Name="Status", EmitDefaultValue=false)]
		public StringValue? Status { get; set; }

		[DataMember(Name="UnallocatedDetail", EmitDefaultValue=false)]
		public List<LateAssignmentUnallocatedDetail>? UnallocatedDetail { get; set; }

		/// <summary>
		/// DAC Field Name: SiteId 
		/// DAC: PX.Objects.AM.AMProdItemSplitPreassign 
		/// </summary>
		[DataMember(Name="Warehouse", EmitDefaultValue=false)]
		public StringValue? Warehouse { get; set; }

		public virtual string GetEndpointPath()
		{
			return "entity/MANUFACTURING/23.100.001";
		}
	}
}