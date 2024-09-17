using System;
using System.Collections.Generic;
using System.Runtime.Serialization;

using Newtonsoft.Json;

using Acumatica.RESTClient.Client;
using Acumatica.RESTClient.ContractBasedApi;
using Acumatica.RESTClient.ContractBasedApi.Model;

namespace Acumatica.Manufacturing_24_200_001.Model
{
	[DataContract]
	public class EstimateMaterialDetail : Entity
	{

		[DataMember(Name="Backflush", EmitDefaultValue=false)]
		public BooleanValue? Backflush { get; set; }

		[DataMember(Name="BatchSize", EmitDefaultValue=false)]
		public DecimalValue? BatchSize { get; set; }

		[DataMember(Name="Description", EmitDefaultValue=false)]
		public StringValue? Description { get; set; }

		[DataMember(Name="InventoryID", EmitDefaultValue=false)]
		public StringValue? InventoryID { get; set; }

		[DataMember(Name="ItemClass", EmitDefaultValue=false)]
		public StringValue? ItemClass { get; set; }

		[DataMember(Name="LineNbr", EmitDefaultValue=false)]
		public IntValue? LineNbr { get; set; }

		[DataMember(Name="LineOrder", EmitDefaultValue=false)]
		public IntValue? LineOrder { get; set; }

		[DataMember(Name="MaterialType", EmitDefaultValue=false)]
		public StringValue? MaterialType { get; set; }

		[DataMember(Name="NonInventory", EmitDefaultValue=false)]
		public BooleanValue? NonInventory { get; set; }

		[DataMember(Name="PhantomRouting", EmitDefaultValue=false)]
		public StringValue? PhantomRouting { get; set; }

		[DataMember(Name="QtyRequired", EmitDefaultValue=false)]
		public DecimalValue? QtyRequired { get; set; }

		[DataMember(Name="QtyRoundUp", EmitDefaultValue=false)]
		public BooleanValue? QtyRoundUp { get; set; }

		[DataMember(Name="ScrapFactor", EmitDefaultValue=false)]
		public DecimalValue? ScrapFactor { get; set; }

		[DataMember(Name="SubcontractSource", EmitDefaultValue=false)]
		public StringValue? SubcontractSource { get; set; }

		[DataMember(Name="Subitem", EmitDefaultValue=false)]
		public StringValue? Subitem { get; set; }

		[DataMember(Name="TotalCost", EmitDefaultValue=false)]
		public DecimalValue? TotalCost { get; set; }

		[DataMember(Name="TotalRequired", EmitDefaultValue=false)]
		public DecimalValue? TotalRequired { get; set; }

		[DataMember(Name="UnitCost", EmitDefaultValue=false)]
		public DecimalValue? UnitCost { get; set; }

		[DataMember(Name="UOM", EmitDefaultValue=false)]
		public StringValue? UOM { get; set; }

		[DataMember(Name="Warehouse", EmitDefaultValue=false)]
		public StringValue? Warehouse { get; set; }

	}
}