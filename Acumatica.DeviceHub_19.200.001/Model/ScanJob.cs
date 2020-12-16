using Acumatica.RESTClient.Model;
using System.Collections.Generic;
using System.Runtime.Serialization;

namespace Acumatica.DeviceHub_19_200_001.Model
{
	[DataContract]
	public class ScanJob : Entity_v3
	{

		[DataMember(Name="Error", EmitDefaultValue=false)]
		public StringValue Error { get; set; }

		[DataMember(Name="ErrorTrace", EmitDefaultValue=false)]
		public StringValue ErrorTrace { get; set; }

		[DataMember(Name="ScanJobID", EmitDefaultValue=false)]
		public IntValue ScanJobID { get; set; }

		[DataMember(Name="DeviceHub", EmitDefaultValue=false)]
		public StringValue DeviceHub { get; set; }

		[DataMember(Name="Scanner", EmitDefaultValue=false)]
		public StringValue Scanner { get; set; }

		[DataMember(Name="Status", EmitDefaultValue=false)]
		public StringValue Status { get; set; }

	}
}