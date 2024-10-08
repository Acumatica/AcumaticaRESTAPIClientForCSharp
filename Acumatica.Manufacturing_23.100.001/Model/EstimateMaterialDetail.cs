using System;
using System.Collections.Generic;
using System.Runtime.Serialization;

using Newtonsoft.Json;

using Acumatica.RESTClient.Client;
using Acumatica.RESTClient.ContractBasedApi;
using Acumatica.RESTClient.ContractBasedApi.Model;

namespace Acumatica.Manufacturing_23_100_001.Model
{
	[DataContract]
	public class EstimateMaterialDetail : Entity
	{

		/// <summary>
		/// Determine whether user need to release material manually or not 
		/// DAC Field Name: BackFlush 
		/// DAC: PX.Objects.AM.AMEstimateMatl 
		/// Display Name: Backflush Materials 
		/// </summary>
		[DataMember(Name="Backflush", EmitDefaultValue=false)]
		public BooleanValue? Backflush { get; set; }

		/// <summary>
		/// DAC: PX.Objects.AM.AMEstimateMatl 
		/// Display Name: Batch Size 
		/// </summary>
		[DataMember(Name="BatchSize", EmitDefaultValue=false)]
		public DecimalValue? BatchSize { get; set; }

		/// <summary>
		/// DAC Field Name: ItemDesc 
		/// DAC: PX.Objects.AM.AMEstimateMatl 
		/// SQL Type: nvarchar(256) 
		/// </summary>
		[DataMember(Name="Description", EmitDefaultValue=false)]
		public StringValue? Description { get; set; }

		/// <summary>
		/// DAC Field Name: InventoryCD 
		/// DAC: PX.Objects.AM.AMEstimateMatl 
		/// Display Name: Inventory ID 
		/// SQL Type: nvarchar(30) 
		/// </summary>
		[DataMember(Name="InventoryID", EmitDefaultValue=false)]
		public StringValue? InventoryID { get; set; }

		/// <summary>
		/// DAC Field Name: ItemClassID 
		/// DAC: PX.Objects.AM.AMEstimateMatl 
		/// Display Name: Item Class 
		/// </summary>
		[DataMember(Name="ItemClass", EmitDefaultValue=false)]
		public StringValue? ItemClass { get; set; }

		/// <summary>
		/// DAC Field Name: LineID 
		/// DAC: PX.Objects.AM.AMEstimateMatl 
		/// Display Name: Line Nbr. 
		/// Key Field
		/// </summary>
		[DataMember(Name="LineNbr", EmitDefaultValue=false)]
		public IntValue? LineNbr { get; set; }

		[DataMember(Name="LineOrder", EmitDefaultValue=false)]
		public IntValue? LineOrder { get; set; }

		/// <summary>
		/// DAC: PX.Objects.AM.AMEstimateMatl 
		/// Display Name: Material Type 
		/// </summary>
		[DataMember(Name="MaterialType", EmitDefaultValue=false)]
		public StringValue? MaterialType { get; set; }

		/// <summary>
		/// DAC Field Name: IsNonInventory 
		/// DAC: PX.Objects.AM.AMEstimateMatl 
		/// Display Name: Non-Inventory 
		/// </summary>
		[DataMember(Name="NonInventory", EmitDefaultValue=false)]
		public BooleanValue? NonInventory { get; set; }

		/// <summary>
		/// DAC: PX.Objects.AM.AMEstimateMatl 
		/// Display Name: Phantom Routing 
		/// </summary>
		[DataMember(Name="PhantomRouting", EmitDefaultValue=false)]
		public StringValue? PhantomRouting { get; set; }

		/// <summary>
		/// DAC Field Name: QtyReq 
		/// DAC: PX.Objects.AM.AMEstimateMatl 
		/// Display Name: Qty Required 
		/// </summary>
		[DataMember(Name="QtyRequired", EmitDefaultValue=false)]
		public DecimalValue? QtyRequired { get; set; }

		/// <summary>
		/// DAC: PX.Objects.AM.AMEstimateMatl 
		/// Display Name: Qty Round Up 
		/// </summary>
		[DataMember(Name="QtyRoundUp", EmitDefaultValue=false)]
		public BooleanValue? QtyRoundUp { get; set; }

		/// <summary>
		/// DAC: PX.Objects.AM.AMEstimateMatl 
		/// Display Name: Scrap Factor 
		/// </summary>
		[DataMember(Name="ScrapFactor", EmitDefaultValue=false)]
		public DecimalValue? ScrapFactor { get; set; }

		/// <summary>
		/// DAC: PX.Objects.AM.AMEstimateMatl 
		/// Display Name: Subcontract Source 
		/// </summary>
		[DataMember(Name="SubcontractSource", EmitDefaultValue=false)]
		public StringValue? SubcontractSource { get; set; }

		/// <summary>
		/// DAC Field Name: SubItemID 
		/// DAC: PX.Objects.AM.AMEstimateMatl 
		/// </summary>
		[DataMember(Name="Subitem", EmitDefaultValue=false)]
		public StringValue? Subitem { get; set; }

		/// <summary>
		/// DAC Field Name: MaterialOperCost 
		/// DAC: PX.Objects.AM.AMEstimateMatl 
		/// Display Name: Total Cost 
		/// </summary>
		[DataMember(Name="TotalCost", EmitDefaultValue=false)]
		public DecimalValue? TotalCost { get; set; }

		/// <summary>
		/// DAC Field Name: TotalQtyRequired 
		/// DAC: PX.Objects.AM.AMEstimateMatl 
		/// Display Name: Total Required 
		/// </summary>
		[DataMember(Name="TotalRequired", EmitDefaultValue=false)]
		public DecimalValue? TotalRequired { get; set; }

		/// <summary>
		/// DAC: PX.Objects.AM.AMEstimateMatl 
		/// Display Name: Unit Cost 
		/// </summary>
		[DataMember(Name="UnitCost", EmitDefaultValue=false)]
		public DecimalValue? UnitCost { get; set; }

		/// <summary>
		/// DAC: PX.Objects.AM.AMEstimateMatl 
		/// SQL Type: nvarchar(6) 
		/// </summary>
		[DataMember(Name="UOM", EmitDefaultValue=false)]
		public StringValue? UOM { get; set; }

		/// <summary>
		/// DAC Field Name: SiteID 
		/// DAC: PX.Objects.AM.AMEstimateMatl 
		/// </summary>
		[DataMember(Name="Warehouse", EmitDefaultValue=false)]
		public StringValue? Warehouse { get; set; }

	}
}