using System.Collections.Generic;
using System.Runtime.Serialization;

using Newtonsoft.Json;

using Acumatica.RESTClient.Client;
using Acumatica.RESTClient.ContractBasedApi;
using Acumatica.RESTClient.ContractBasedApi.Model;

namespace Acumatica.Manufacturing_21_200_001.Model
{
	[DataContract]
	public class EngineeringChangeRequestMaterial : Entity
	{

		[DataMember(Name="Backflush", EmitDefaultValue=false)]
		public BooleanValue? Backflush { get; set; }

		[DataMember(Name="BatchSize", EmitDefaultValue=false)]
		public DecimalValue? BatchSize { get; set; }

		[DataMember(Name="BubbleNbr", EmitDefaultValue=false)]
		public StringValue? BubbleNbr { get; set; }

		[DataMember(Name="ChangeStatus", EmitDefaultValue=false)]
		public StringValue? ChangeStatus { get; set; }

		[DataMember(Name="CompBOMID", EmitDefaultValue=false)]
		public StringValue? CompBOMID { get; set; }

		[DataMember(Name="CompBOMRevision", EmitDefaultValue=false)]
		public StringValue? CompBOMRevision { get; set; }

		[DataMember(Name="Description", EmitDefaultValue=false)]
		public StringValue? Description { get; set; }

		[DataMember(Name="ECRID", EmitDefaultValue=false)]
		public StringValue? ECRID { get; set; }

		[DataMember(Name="EffectiveDate", EmitDefaultValue=false)]
		public DateTimeValue? EffectiveDate { get; set; }

		[DataMember(Name="ExpirationDate", EmitDefaultValue=false)]
		public DateTimeValue? ExpirationDate { get; set; }

		[DataMember(Name="InventoryID", EmitDefaultValue=false)]
		public StringValue? InventoryID { get; set; }

		[DataMember(Name="LineNbr", EmitDefaultValue=false)]
		public IntValue? LineNbr { get; set; }

		[DataMember(Name="LineOrder", EmitDefaultValue=false)]
		public IntValue? LineOrder { get; set; }

		[DataMember(Name="Location", EmitDefaultValue=false)]
		public StringValue? Location { get; set; }

		[DataMember(Name="MaterialType", EmitDefaultValue=false)]
		public StringValue? MaterialType { get; set; }

		[DataMember(Name="OperationID", EmitDefaultValue=false)]
		public StringValue? OperationID { get; set; }

		[DataMember(Name="PhantomRouting", EmitDefaultValue=false)]
		public StringValue? PhantomRouting { get; set; }

		[DataMember(Name="PlannedCost", EmitDefaultValue=false)]
		public DecimalValue? PlannedCost { get; set; }

		[DataMember(Name="QtyRequired", EmitDefaultValue=false)]
		public DecimalValue? QtyRequired { get; set; }

		[DataMember(Name="ReferenceDesignators", EmitDefaultValue=false)]
		public List<ECRReferenceDesignator>? ReferenceDesignators { get; set; }

		[DataMember(Name="Revision", EmitDefaultValue=false)]
		public StringValue? Revision { get; set; }

		[DataMember(Name="ScrapFactor", EmitDefaultValue=false)]
		public DecimalValue? ScrapFactor { get; set; }

		[DataMember(Name="SubcontractSource", EmitDefaultValue=false)]
		public StringValue? SubcontractSource { get; set; }

		[DataMember(Name="Subitem", EmitDefaultValue=false)]
		public StringValue? Subitem { get; set; }

		[DataMember(Name="UnitCost", EmitDefaultValue=false)]
		public DecimalValue? UnitCost { get; set; }

		[DataMember(Name="UOM", EmitDefaultValue=false)]
		public StringValue? UOM { get; set; }

		[DataMember(Name="Warehouse", EmitDefaultValue=false)]
		public StringValue? Warehouse { get; set; }

	}
}