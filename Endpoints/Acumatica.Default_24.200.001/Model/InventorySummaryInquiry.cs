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
	/// Corresponds to the screen IN401000 in the Acumatica ERP
	/// </summary>
	[DataContract]
	public class InventorySummaryInquiry : Entity, ITopLevelEntity
	{

		/// <summary>
		/// DAC: PX.Objects.IN.InventorySummaryEnqFilter 
		/// Display Name: Expand by Lot/Serial Numbers 
		/// </summary>
		[DataMember(Name="ExpandByLotSerialNbr", EmitDefaultValue=false)]
		public BooleanValue? ExpandByLotSerialNbr { get; set; }

		/// <summary>
		/// DAC: PX.Objects.IN.InventorySummaryEnqFilter 
		/// Display Name: Inventory ID 
		/// </summary>
		[DataMember(Name="InventoryID", EmitDefaultValue=false)]
		public StringValue? InventoryID { get; set; }

		/// <summary>
		/// DAC: PX.Objects.IN.InventorySummaryEnqFilter 
		/// Display Name: Location 
		/// </summary>
		[DataMember(Name="LocationID", EmitDefaultValue=false)]
		public StringValue? LocationID { get; set; }

		[DataMember(Name="Results", EmitDefaultValue=false)]
		public List<InventorySummaryRow>? Results { get; set; }

		/// <summary>
		/// DAC Field Name: SubItemCD 
		/// DAC: PX.Objects.IN.InventorySummaryEnqFilter 
		/// SQL Type: nvarchar(30) 
		/// </summary>
		[DataMember(Name="Subitem", EmitDefaultValue=false)]
		public StringValue? Subitem { get; set; }

		/// <summary>
		/// DAC Field Name: SiteID 
		/// DAC: PX.Objects.IN.InventorySummaryEnqFilter 
		/// Display Name: Warehouse 
		/// </summary>
		[DataMember(Name="WarehouseID", EmitDefaultValue=false)]
		public StringValue? WarehouseID { get; set; }

		public virtual string GetEndpointPath()
		{
			return "entity/Default/24.200.001";
		}
	}
}