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
	/// Corresponds to the screen AM201000 in the Acumatica ERP
	/// </summary>
	[DataContract]
	public class MasterProductionSchedule : Entity, ITopLevelEntity
	{

		/// <summary>
		/// DAC Field Name: ActiveFlg 
		/// DAC: PX.Objects.AM.AMMPS 
		/// </summary>
		[DataMember(Name="Active", EmitDefaultValue=false)]
		public BooleanValue? Active { get; set; }

		/// <summary>
		/// DAC Field Name: BOMID_description 
		/// DAC: PX.Objects.AM.AMMPS 
		/// </summary>
		[DataMember(Name="BOMDescription", EmitDefaultValue=false)]
		public StringValue? BOMDescription { get; set; }

		/// <summary>
		/// DAC: PX.Objects.AM.AMMPS 
		/// Display Name: BOM ID 
		/// SQL Type: nvarchar(15) 
		/// </summary>
		[DataMember(Name="BOMID", EmitDefaultValue=false)]
		public StringValue? BOMID { get; set; }

		/// <summary>
		/// DAC Field Name: BranchID 
		/// DAC: PX.Objects.AM.AMMPS 
		/// </summary>
		[DataMember(Name="Branch", EmitDefaultValue=false)]
		public StringValue? Branch { get; set; }

		/// <summary>
		/// DAC Field Name: InventoryID_description 
		/// DAC: PX.Objects.AM.AMMPS 
		/// </summary>
		[DataMember(Name="Description", EmitDefaultValue=false)]
		public StringValue? Description { get; set; }

		/// <summary>
		/// DAC: PX.Objects.AM.AMMPS 
		/// Display Name: Inventory ID 
		/// </summary>
		[DataMember(Name="InventoryID", EmitDefaultValue=false)]
		public StringValue? InventoryID { get; set; }

		/// <summary>
		/// DAC: PX.Objects.AM.AMMPS 
		/// Display Name: MPS ID 
		/// SQL Type: nvarchar(15) 
		/// Key Field
		/// </summary>
		[DataMember(Name="MPSID", EmitDefaultValue=false)]
		public StringValue? MPSID { get; set; }

		/// <summary>
		/// DAC: PX.Objects.AM.AMMPS 
		/// Display Name: Plan Date 
		/// </summary>
		[DataMember(Name="PlanDate", EmitDefaultValue=false)]
		public DateTimeValue? PlanDate { get; set; }

		/// <summary>
		/// DAC Field Name: Qty 
		/// DAC: PX.Objects.AM.AMMPS 
		/// </summary>
		[DataMember(Name="Quantity", EmitDefaultValue=false)]
		public DecimalValue? Quantity { get; set; }

		/// <summary>
		/// DAC Field Name: SubItemID 
		/// DAC: PX.Objects.AM.AMMPS 
		/// </summary>
		[DataMember(Name="Subitem", EmitDefaultValue=false)]
		public StringValue? Subitem { get; set; }

		/// <summary>
		/// DAC Field Name: MPSTypeID 
		/// DAC: PX.Objects.AM.AMMPS 
		/// SQL Type: nvarchar(20) 
		/// Key Field
		/// </summary>
		[DataMember(Name="Type", EmitDefaultValue=false)]
		public StringValue? Type { get; set; }

		/// <summary>
		/// DAC: PX.Objects.AM.AMMPS 
		/// SQL Type: nvarchar(6) 
		/// </summary>
		[DataMember(Name="UOM", EmitDefaultValue=false)]
		public StringValue? UOM { get; set; }

		/// <summary>
		/// DAC Field Name: SiteID 
		/// DAC: PX.Objects.AM.AMMPS 
		/// </summary>
		[DataMember(Name="Warehouse", EmitDefaultValue=false)]
		public StringValue? Warehouse { get; set; }

		public virtual string GetEndpointPath()
		{
			return "entity/MANUFACTURING/24.200.001";
		}
	}
}