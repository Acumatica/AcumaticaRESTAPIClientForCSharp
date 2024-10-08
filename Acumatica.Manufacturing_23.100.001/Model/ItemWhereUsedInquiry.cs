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
	/// Corresponds to the screen AM402000 in the Acumatica ERP
	/// </summary>
	[DataContract]
	public class ItemWhereUsedInquiry : Entity, ITopLevelEntity
	{

		/// <summary>
		/// DAC: PX.Objects.AM.BomWhereUsedFilter 
		/// Display Name: Inventory ID 
		/// </summary>
		[DataMember(Name="InventoryID", EmitDefaultValue=false)]
		public StringValue? InventoryID { get; set; }

		/// <summary>
		/// DAC Field Name: ItemClassID 
		/// DAC: PX.Objects.AM.BomWhereUsedFilter 
		/// Display Name: Item Class 
		/// </summary>
		[DataMember(Name="ItemClass", EmitDefaultValue=false)]
		public StringValue? ItemClass { get; set; }

		/// <summary>
		/// DAC: PX.Objects.AM.BomWhereUsedFilter 
		/// Display Name: Show Multilevel Results 
		/// </summary>
		[DataMember(Name="MultiLevel", EmitDefaultValue=false)]
		public BooleanValue? MultiLevel { get; set; }

		[DataMember(Name="Results", EmitDefaultValue=false)]
		public List<ItemWhereUsedRow>? Results { get; set; }

		/// <summary>
		/// DAC Field Name: SubItemID 
		/// DAC: PX.Objects.AM.BomWhereUsedFilter 
		/// </summary>
		[DataMember(Name="Subitem", EmitDefaultValue=false)]
		public StringValue? Subitem { get; set; }

		/// <summary>
		/// DAC Field Name: SiteID 
		/// DAC: PX.Objects.AM.BomWhereUsedFilter 
		/// Display Name: BOM Warehouse 
		/// </summary>
		[DataMember(Name="Warehouse", EmitDefaultValue=false)]
		public StringValue? Warehouse { get; set; }

		public virtual string GetEndpointPath()
		{
			return "entity/MANUFACTURING/23.100.001";
		}
	}
}