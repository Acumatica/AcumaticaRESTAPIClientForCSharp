using Acumatica.RESTClient.Model;
using System.Collections.Generic;
using System.Runtime.Serialization;

namespace Acumatica.DeviceHub_19_200_001.Model
{
	[DataContract]
	public partial class Printer : Entity
	{

		[DataMember(Name="Description", EmitDefaultValue=false)]
		public StringValue Description { get; set; }

		[DataMember(Name="IsActive", EmitDefaultValue=false)]
		public BooleanValue IsActive { get; set; }

		[DataMember(Name="DeviceHub", EmitDefaultValue=false)]
		public StringValue DeviceHub { get; set; }

		[DataMember(Name="PrinterName", EmitDefaultValue=false)]
		public StringValue PrinterName { get; set; }

	}
}