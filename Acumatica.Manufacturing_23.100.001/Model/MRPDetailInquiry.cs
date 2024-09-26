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
	/// Corresponds to the screen AM404000 in the Acumatica ERP
	/// </summary>
	[DataContract]
	public class MRPDetailInquiry : Entity, ITopLevelEntity
	{

		/// <summary>
		/// 
		/// Display Name:
		/// DAC Field Name: UOM 
		/// DAC: PX.Objects.AM.InvLookup 
		/// </summary>
		/// <remarks>
		/// 
		/// </remarks>
		[DataMember(Name="BaseUnit", EmitDefaultValue=false)]
		public StringValue? BaseUnit { get; set; }

		/// <summary>
		/// 
		/// Display Name:
		/// DAC Field Name: InventoryID 
		/// DAC: PX.Objects.AM.InvLookup 
		/// </summary>
		/// <remarks>
		/// 
		/// </remarks>
		[DataMember(Name="InventoryID", EmitDefaultValue=false)]
		public StringValue? InventoryID { get; set; }

		/// <summary>
		/// 
		/// Display Name:
		/// DAC Field Name: LotQty 
		/// DAC: PX.Objects.AM.InvLookup 
		/// </summary>
		/// <remarks>
		/// 
		/// </remarks>
		[DataMember(Name="LotQty", EmitDefaultValue=false)]
		public DecimalValue? LotQty { get; set; }

		/// <summary>
		/// 
		/// Display Name:
		/// DAC Field Name: MaxOrderQty 
		/// DAC: PX.Objects.AM.InvLookup 
		/// </summary>
		/// <remarks>
		/// 
		/// </remarks>
		[DataMember(Name="MaxOrderQty", EmitDefaultValue=false)]
		public DecimalValue? MaxOrderQty { get; set; }

		/// <summary>
		/// 
		/// Display Name:
		/// DAC Field Name: MinOrderQty 
		/// DAC: PX.Objects.AM.InvLookup 
		/// </summary>
		/// <remarks>
		/// 
		/// </remarks>
		[DataMember(Name="MinOrderQty", EmitDefaultValue=false)]
		public DecimalValue? MinOrderQty { get; set; }

		/// <summary>
		/// 
		/// Display Name:
		/// DAC Field Name: QtyOnHand 
		/// DAC: PX.Objects.AM.InvLookup 
		/// </summary>
		/// <remarks>
		/// 
		/// </remarks>
		[DataMember(Name="QtyOnHand", EmitDefaultValue=false)]
		public DecimalValue? QtyOnHand { get; set; }

		[DataMember(Name="Results", EmitDefaultValue=false)]
		public List<MRPDetailInquiryResult>? Results { get; set; }

		/// <summary>
		/// 
		/// Display Name:
		/// DAC Field Name: SafetyStock 
		/// DAC: PX.Objects.AM.InvLookup 
		/// </summary>
		/// <remarks>
		/// 
		/// </remarks>
		[DataMember(Name="SafetyStock", EmitDefaultValue=false)]
		public DecimalValue? SafetyStock { get; set; }

		/// <summary>
		/// 
		/// Display Name:
		/// DAC Field Name: SubItemID 
		/// DAC: PX.Objects.AM.InvLookup 
		/// </summary>
		/// <remarks>
		/// 
		/// </remarks>
		[DataMember(Name="Subitem", EmitDefaultValue=false)]
		public StringValue? Subitem { get; set; }

		/// <summary>
		/// 
		/// Display Name:
		/// DAC Field Name: SiteID 
		/// DAC: PX.Objects.AM.InvLookup 
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