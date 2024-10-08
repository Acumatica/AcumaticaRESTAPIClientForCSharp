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
	/// Corresponds to the screen AM404000 in the Acumatica ERP
	/// </summary>
	[DataContract]
	public class MRPDetailInquiry : Entity, ITopLevelEntity
	{

		/// <summary>
		/// U o m
		/// DAC Field Name: UOM 
		/// DAC: PX.Objects.AM.InvLookup 
		/// Display Name: Base Unit 
		/// SQL Type: nvarchar(MAX) 
		/// </summary>
		[DataMember(Name="BaseUnit", EmitDefaultValue=false)]
		public StringValue? BaseUnit { get; set; }

		/// <summary>
		/// Inventory ID
		/// DAC: PX.Objects.AM.InvLookup 
		/// Display Name: Inventory ID 
		/// </summary>
		[DataMember(Name="InventoryID", EmitDefaultValue=false)]
		public StringValue? InventoryID { get; set; }

		/// <summary>
		/// Lot qty
		/// DAC: PX.Objects.AM.InvLookup 
		/// Display Name: Lot Qty 
		/// </summary>
		[DataMember(Name="LotQty", EmitDefaultValue=false)]
		public DecimalValue? LotQty { get; set; }

		/// <summary>
		/// Max order qty
		/// DAC: PX.Objects.AM.InvLookup 
		/// Display Name: Max. Order Qty 
		/// </summary>
		[DataMember(Name="MaxOrderQty", EmitDefaultValue=false)]
		public DecimalValue? MaxOrderQty { get; set; }

		/// <summary>
		/// Min order qty
		/// DAC: PX.Objects.AM.InvLookup 
		/// Display Name: Min. Order Qty 
		/// </summary>
		[DataMember(Name="MinOrderQty", EmitDefaultValue=false)]
		public DecimalValue? MinOrderQty { get; set; }

		/// <summary>
		/// Qty on hand
		/// DAC: PX.Objects.AM.InvLookup 
		/// Display Name: Qty On Hand 
		/// </summary>
		[DataMember(Name="QtyOnHand", EmitDefaultValue=false)]
		public DecimalValue? QtyOnHand { get; set; }

		[DataMember(Name="Results", EmitDefaultValue=false)]
		public List<MRPDetailInquiryResult>? Results { get; set; }

		/// <summary>
		/// Safety stock
		/// DAC: PX.Objects.AM.InvLookup 
		/// Display Name: Safety Stock 
		/// </summary>
		[DataMember(Name="SafetyStock", EmitDefaultValue=false)]
		public DecimalValue? SafetyStock { get; set; }

		/// <summary>
		/// Sub item ID
		/// DAC Field Name: SubItemID 
		/// DAC: PX.Objects.AM.InvLookup 
		/// </summary>
		[DataMember(Name="Subitem", EmitDefaultValue=false)]
		public StringValue? Subitem { get; set; }

		/// <summary>
		/// Warehouse
		/// DAC Field Name: SiteID 
		/// DAC: PX.Objects.AM.InvLookup 
		/// </summary>
		[DataMember(Name="Warehouse", EmitDefaultValue=false)]
		public StringValue? Warehouse { get; set; }

		public virtual string GetEndpointPath()
		{
			return "entity/MANUFACTURING/24.200.001";
		}
	}
}