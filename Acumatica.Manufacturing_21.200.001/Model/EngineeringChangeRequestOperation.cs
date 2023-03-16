using Acumatica.RESTClient.Model;
using System.Collections.Generic;
using System.Runtime.Serialization;

namespace Acumatica.Manufacturing_21_200_001.Model
{
	[DataContract]
	public class EngineeringChangeRequestOperation : Entity
	{

		[DataMember(Name="BackflushLabor", EmitDefaultValue=false)]
		public BooleanValue BackflushLabor { get; set; }

		[DataMember(Name="ChangeStatus", EmitDefaultValue=false)]
		public StringValue ChangeStatus { get; set; }

		[DataMember(Name="DropShippedtoVendor", EmitDefaultValue=false)]
		public BooleanValue DropShippedtoVendor { get; set; }

		[DataMember(Name="ECRID", EmitDefaultValue=false)]
		public StringValue ECRID { get; set; }

		[DataMember(Name="FinishTime", EmitDefaultValue=false)]
		public StringValue FinishTime { get; set; }

		[DataMember(Name="MachineTime", EmitDefaultValue=false)]
		public StringValue MachineTime { get; set; }

		[DataMember(Name="MachineUnits", EmitDefaultValue=false)]
		public DecimalValue MachineUnits { get; set; }

		[DataMember(Name="Material", EmitDefaultValue=false)]
		public List<EngineeringChangeRequestMaterial> Material { get; set; }

		[DataMember(Name="OperationID", EmitDefaultValue=false)]
		public StringValue OperationID { get; set; }

		[DataMember(Name="OperDesc", EmitDefaultValue=false)]
		public StringValue OperDesc { get; set; }

		[DataMember(Name="OutsideProcess", EmitDefaultValue=false)]
		public BooleanValue OutsideProcess { get; set; }

		[DataMember(Name="Overheads", EmitDefaultValue=false)]
		public List<EngineeringChangeRequestOverhead> Overheads { get; set; }

		[DataMember(Name="QueueTime", EmitDefaultValue=false)]
		public StringValue QueueTime { get; set; }

		[DataMember(Name="Revision", EmitDefaultValue=false)]
		public StringValue Revision { get; set; }

		[DataMember(Name="RunTime", EmitDefaultValue=false)]
		public StringValue RunTime { get; set; }

		[DataMember(Name="RunUnits", EmitDefaultValue=false)]
		public DecimalValue RunUnits { get; set; }

		[DataMember(Name="ScrapAction", EmitDefaultValue=false)]
		public StringValue ScrapAction { get; set; }

		[DataMember(Name="SetupTime", EmitDefaultValue=false)]
		public StringValue SetupTime { get; set; }

		[DataMember(Name="Steps", EmitDefaultValue=false)]
		public List<EngineeringChangeRequestStep> Steps { get; set; }

		[DataMember(Name="Tools", EmitDefaultValue=false)]
		public List<EngineeringChangeRequestTools> Tools { get; set; }

		[DataMember(Name="Vendor", EmitDefaultValue=false)]
		public StringValue Vendor { get; set; }

		[DataMember(Name="VendorLocation", EmitDefaultValue=false)]
		public StringValue VendorLocation { get; set; }

		[DataMember(Name="WorkCenter", EmitDefaultValue=false)]
		public StringValue WorkCenter { get; set; }

	}
}