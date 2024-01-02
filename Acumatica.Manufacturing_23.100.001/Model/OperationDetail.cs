using System.Collections.Generic;
using System.Runtime.Serialization;

using Newtonsoft.Json;

using Acumatica.RESTClient.Client;
using Acumatica.RESTClient.ContractBasedApi;
using Acumatica.RESTClient.ContractBasedApi.Model;

namespace Acumatica.Manufacturing_23_100_001.Model
{
	[DataContract]
	public class OperationDetail : Entity
	{

		[DataMember(Name="BackflushLabor", EmitDefaultValue=false)]
		public BooleanValue? BackflushLabor { get; set; }

		[DataMember(Name="BOMID", EmitDefaultValue=false)]
		public StringValue? BOMID { get; set; }

		[DataMember(Name="ControlPoint", EmitDefaultValue=false)]
		public BooleanValue? ControlPoint { get; set; }

		[DataMember(Name="DropShippedtoVendor", EmitDefaultValue=false)]
		public BooleanValue? DropShippedtoVendor { get; set; }

		[DataMember(Name="FinishTime", EmitDefaultValue=false)]
		public IntValue? FinishTime { get; set; }

		[DataMember(Name="MachineTime", EmitDefaultValue=false)]
		public IntValue? MachineTime { get; set; }

		[DataMember(Name="MachineUnits", EmitDefaultValue=false)]
		public DecimalValue? MachineUnits { get; set; }

		[DataMember(Name="Material", EmitDefaultValue=false)]
		public List<MaterialDetail>? Material { get; set; }

		[DataMember(Name="MoveTime", EmitDefaultValue=false)]
		public IntValue? MoveTime { get; set; }

		[DataMember(Name="OperationDescription", EmitDefaultValue=false)]
		public StringValue? OperationDescription { get; set; }

		[DataMember(Name="OperationNbr", EmitDefaultValue=false)]
		public StringValue? OperationNbr { get; set; }

		[DataMember(Name="OutsideProcess", EmitDefaultValue=false)]
		public BooleanValue? OutsideProcess { get; set; }

		[DataMember(Name="Overheads", EmitDefaultValue=false)]
		public List<BomOverheadDetail>? Overheads { get; set; }

		[DataMember(Name="QueueTime", EmitDefaultValue=false)]
		public IntValue? QueueTime { get; set; }

		[DataMember(Name="Revision", EmitDefaultValue=false)]
		public StringValue? Revision { get; set; }

		[DataMember(Name="RunTime", EmitDefaultValue=false)]
		public IntValue? RunTime { get; set; }

		[DataMember(Name="RunUnits", EmitDefaultValue=false)]
		public DecimalValue? RunUnits { get; set; }

		[DataMember(Name="ScrapAction", EmitDefaultValue=false)]
		public StringValue? ScrapAction { get; set; }

		[DataMember(Name="SetupTime", EmitDefaultValue=false)]
		public IntValue? SetupTime { get; set; }

		[DataMember(Name="Steps", EmitDefaultValue=false)]
		public List<StepDetail>? Steps { get; set; }

		[DataMember(Name="Tools", EmitDefaultValue=false)]
		public List<ToolDetail>? Tools { get; set; }

		[DataMember(Name="Vendor", EmitDefaultValue=false)]
		public StringValue? Vendor { get; set; }

		[DataMember(Name="VendorLocation", EmitDefaultValue=false)]
		public StringValue? VendorLocation { get; set; }

		[DataMember(Name="WorkCenter", EmitDefaultValue=false)]
		public StringValue? WorkCenter { get; set; }

	}
}