using System.Collections.Generic;
using System.Runtime.Serialization;

using Newtonsoft.Json;

using Acumatica.RESTClient.Client;
using Acumatica.RESTClient.ContractBasedApi;
using Acumatica.RESTClient.ContractBasedApi.Model;

namespace Acumatica.Manufacturing_23_100_001.Model
{
	[DataContract]
	public class OrderToolDetail : Entity
	{

		[DataMember(Name="Description", EmitDefaultValue=false)]
		public StringValue? Description { get; set; }

		[DataMember(Name="LineID", EmitDefaultValue=false)]
		public IntValue? LineID { get; set; }

		[DataMember(Name="PhantomBomID", EmitDefaultValue=false)]
		public StringValue? PhantomBomID { get; set; }

		[DataMember(Name="PhantomBOMLineID", EmitDefaultValue=false)]
		public IntValue? PhantomBOMLineID { get; set; }

		[DataMember(Name="PhantomBOMOperNbr", EmitDefaultValue=false)]
		public StringValue? PhantomBOMOperNbr { get; set; }

		[DataMember(Name="PhantomBOMRevision", EmitDefaultValue=false)]
		public StringValue? PhantomBOMRevision { get; set; }

		[DataMember(Name="PhantomLevel", EmitDefaultValue=false)]
		public IntValue? PhantomLevel { get; set; }

		[DataMember(Name="PhantomMatlBOMID", EmitDefaultValue=false)]
		public StringValue? PhantomMatlBOMID { get; set; }

		[DataMember(Name="PhantomMatlLineID", EmitDefaultValue=false)]
		public IntValue? PhantomMatlLineID { get; set; }

		[DataMember(Name="PhantomMatlOperNbr", EmitDefaultValue=false)]
		public StringValue? PhantomMatlOperNbr { get; set; }

		[DataMember(Name="PhantomMatlRevision", EmitDefaultValue=false)]
		public StringValue? PhantomMatlRevision { get; set; }

		[DataMember(Name="QtyRequired", EmitDefaultValue=false)]
		public DecimalValue? QtyRequired { get; set; }

		[DataMember(Name="ToolID", EmitDefaultValue=false)]
		public StringValue? ToolID { get; set; }

		[DataMember(Name="ToolIDDescription", EmitDefaultValue=false)]
		public StringValue? ToolIDDescription { get; set; }

		[DataMember(Name="ToolIDToolID", EmitDefaultValue=false)]
		public StringValue? ToolIDToolID { get; set; }

		[DataMember(Name="TotalActualCost", EmitDefaultValue=false)]
		public DecimalValue? TotalActualCost { get; set; }

		[DataMember(Name="TotalActualUses", EmitDefaultValue=false)]
		public DecimalValue? TotalActualUses { get; set; }

		[DataMember(Name="UnitCost", EmitDefaultValue=false)]
		public DecimalValue? UnitCost { get; set; }

	}
}