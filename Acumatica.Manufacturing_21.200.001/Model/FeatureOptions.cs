using System.Collections.Generic;
using System.Runtime.Serialization;

using Newtonsoft.Json;

using Acumatica.RESTClient.Client;
using Acumatica.RESTClient.ContractBasedApi;
using Acumatica.RESTClient.ContractBasedApi.Model;

namespace Acumatica.Manufacturing_21_200_001.Model
{
	[DataContract]
	public class FeatureOptions : Entity
	{

		[DataMember(Name="Backflush", EmitDefaultValue=false)]
		public BooleanValue? Backflush { get; set; }

		[DataMember(Name="BatchSize", EmitDefaultValue=false)]
		public DecimalValue? BatchSize { get; set; }

		[DataMember(Name="Description", EmitDefaultValue=false)]
		public StringValue? Description { get; set; }

		[DataMember(Name="FeatureID", EmitDefaultValue=false)]
		public StringValue? FeatureID { get; set; }

		[DataMember(Name="FixedInclude", EmitDefaultValue=false)]
		public BooleanValue? FixedInclude { get; set; }

		[DataMember(Name="InventoryID", EmitDefaultValue=false)]
		public StringValue? InventoryID { get; set; }

		[DataMember(Name="Label", EmitDefaultValue=false)]
		public StringValue? Label { get; set; }

		[DataMember(Name="LineNbr", EmitDefaultValue=false)]
		public IntValue? LineNbr { get; set; }

		[DataMember(Name="LotQty", EmitDefaultValue=false)]
		public StringValue? LotQty { get; set; }

		[DataMember(Name="MaterialType", EmitDefaultValue=false)]
		public StringValue? MaterialType { get; set; }

		[DataMember(Name="MaxQty", EmitDefaultValue=false)]
		public StringValue? MaxQty { get; set; }

		[DataMember(Name="MinQty", EmitDefaultValue=false)]
		public StringValue? MinQty { get; set; }

		[DataMember(Name="PhantomRouting", EmitDefaultValue=false)]
		public StringValue? PhantomRouting { get; set; }

		[DataMember(Name="PriceFactor", EmitDefaultValue=false)]
		public StringValue? PriceFactor { get; set; }

		[DataMember(Name="PrintResults", EmitDefaultValue=false)]
		public BooleanValue? PrintResults { get; set; }

		[DataMember(Name="QtyEnabled", EmitDefaultValue=false)]
		public BooleanValue? QtyEnabled { get; set; }

		[DataMember(Name="QtyRequired", EmitDefaultValue=false)]
		public StringValue? QtyRequired { get; set; }

		[DataMember(Name="QtyRoundUp", EmitDefaultValue=false)]
		public BooleanValue? QtyRoundUp { get; set; }

		[DataMember(Name="ResultsCopy", EmitDefaultValue=false)]
		public BooleanValue? ResultsCopy { get; set; }

		[DataMember(Name="ScrapFactor", EmitDefaultValue=false)]
		public StringValue? ScrapFactor { get; set; }

		[DataMember(Name="SubcontractSource", EmitDefaultValue=false)]
		public StringValue? SubcontractSource { get; set; }

		[DataMember(Name="Subitem", EmitDefaultValue=false)]
		public StringValue? Subitem { get; set; }

		[DataMember(Name="UOM", EmitDefaultValue=false)]
		public StringValue? UOM { get; set; }

	}
}