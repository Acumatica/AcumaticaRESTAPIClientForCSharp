using System.Collections.Generic;
using System.Runtime.Serialization;

using Newtonsoft.Json;

using Acumatica.RESTClient.Client;
using Acumatica.RESTClient.ContractBasedApi;
using Acumatica.RESTClient.ContractBasedApi.Model;

namespace Acumatica.Manufacturing_20_200_001.Model
{
	[DataContract]
	public class OperationDetail : Entity
	{

		[DataMember(Name="BackflushLabor", EmitDefaultValue=false)]
		public BooleanValue BackflushLabor { get; set; }

		[DataMember(Name="DropShippedtoVendor", EmitDefaultValue=false)]
		public BooleanValue DropShippedtoVendor { get; set; }

		[DataMember(Name="MachineTime", EmitDefaultValue=false)]
		public StringValue MachineTime { get; set; }

		[DataMember(Name="MachineUnits", EmitDefaultValue=false)]
		public DecimalValue MachineUnits { get; set; }

		[DataMember(Name="Material", EmitDefaultValue=false)]
		public List<MaterialDetail> Material { get; set; }

		[DataMember(Name="OperationDescription", EmitDefaultValue=false)]
		public StringValue OperationDescription { get; set; }

		[DataMember(Name="OperationNbr", EmitDefaultValue=false)]
		public StringValue OperationNbr { get; set; }

		[DataMember(Name="OutsideProcess", EmitDefaultValue=false)]
		public BooleanValue OutsideProcess { get; set; }

		[DataMember(Name="Overheads", EmitDefaultValue=false)]
		public List<BomOverheadDetail> Overheads { get; set; }

		[DataMember(Name="QueueTime", EmitDefaultValue=false)]
		public StringValue QueueTime { get; set; }

		[DataMember(Name="RunTime", EmitDefaultValue=false)]
		public StringValue RunTime { get; set; }

		[DataMember(Name="RunUnits", EmitDefaultValue=false)]
		public DecimalValue RunUnits { get; set; }

		[DataMember(Name="ScrapAction", EmitDefaultValue=false)]
		public StringValue ScrapAction { get; set; }

		[DataMember(Name="SetupTime", EmitDefaultValue=false)]
		public StringValue SetupTime { get; set; }

		[DataMember(Name="Steps", EmitDefaultValue=false)]
		public List<StepDetail> Steps { get; set; }

		[DataMember(Name="Tools", EmitDefaultValue=false)]
		public List<ToolDetail> Tools { get; set; }

		[DataMember(Name="Vendor", EmitDefaultValue=false)]
		public StringValue Vendor { get; set; }

		[DataMember(Name="VendorLocation", EmitDefaultValue=false)]
		public StringValue VendorLocation { get; set; }

		[DataMember(Name="WorkCenter", EmitDefaultValue=false)]
		public StringValue WorkCenter { get; set; }

	}
}