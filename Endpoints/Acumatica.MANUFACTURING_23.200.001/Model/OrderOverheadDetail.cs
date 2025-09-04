using System;
using System.Collections.Generic;
using System.Runtime.Serialization;

using Newtonsoft.Json;

using Acumatica.RESTClient.Client;
using Acumatica.RESTClient.ContractBasedApi;
using Acumatica.RESTClient.ContractBasedApi.Model;

namespace Acumatica.Manufacturing_23_200_001.Model
{
	[DataContract]
	public class OrderOverheadDetail : Entity
	{

		[DataMember(Name="CostRate", EmitDefaultValue=false)]
		public DecimalValue? CostRate { get; set; }

		[DataMember(Name="Description", EmitDefaultValue=false)]
		public StringValue? Description { get; set; }

		[DataMember(Name="Factor", EmitDefaultValue=false)]
		public DecimalValue? Factor { get; set; }

		[DataMember(Name="LineID", EmitDefaultValue=false)]
		public IntValue? LineID { get; set; }

		[DataMember(Name="Overhead", EmitDefaultValue=false)]
		public StringValue? Overhead { get; set; }

		[DataMember(Name="OverheadDescription", EmitDefaultValue=false)]
		public StringValue? OverheadDescription { get; set; }

		[DataMember(Name="OverheadType", EmitDefaultValue=false)]
		public StringValue? OverheadType { get; set; }

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

		[DataMember(Name="TotalActualCost", EmitDefaultValue=false)]
		public DecimalValue? TotalActualCost { get; set; }

		[DataMember(Name="Type", EmitDefaultValue=false)]
		public StringValue? Type { get; set; }

		[DataMember(Name="WCFlag", EmitDefaultValue=false)]
		public BooleanValue? WCFlag { get; set; }

	}
}