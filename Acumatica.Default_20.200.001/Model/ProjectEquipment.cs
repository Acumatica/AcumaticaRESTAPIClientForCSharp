using Acumatica.RESTClient.Model;
using System.Collections.Generic;
using System.Runtime.Serialization;

namespace Acumatica.Default_20_200_001.Model
{
	[DataContract]
	public class ProjectEquipment : Entity_v4
	{

		[DataMember(Name="Active", EmitDefaultValue=false)]
		public BooleanValue Active { get; set; }

		[DataMember(Name="Description", EmitDefaultValue=false)]
		public StringValue Description { get; set; }

		[DataMember(Name="EquipmentID", EmitDefaultValue=false)]
		public StringValue EquipmentID { get; set; }

		[DataMember(Name="RunRate", EmitDefaultValue=false)]
		public DecimalValue RunRate { get; set; }

		[DataMember(Name="RunRateItem", EmitDefaultValue=false)]
		public StringValue RunRateItem { get; set; }

		[DataMember(Name="SetupRate", EmitDefaultValue=false)]
		public DecimalValue SetupRate { get; set; }

		[DataMember(Name="SetupRateItem", EmitDefaultValue=false)]
		public StringValue SetupRateItem { get; set; }

		[DataMember(Name="SuspendRate", EmitDefaultValue=false)]
		public DecimalValue SuspendRate { get; set; }

		[DataMember(Name="SuspendRateItem", EmitDefaultValue=false)]
		public StringValue SuspendRateItem { get; set; }

	}
}