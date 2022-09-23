using Acumatica.RESTClient.Model;
using System.Collections.Generic;
using System.Runtime.Serialization;

namespace Acumatica.Default_22_200_001.Model
{
	[DataContract]
	public class WorkLocation : Entity_v4
	{

		[DataMember(Name="Active", EmitDefaultValue=false)]
		public BooleanValue Active { get; set; }

		[DataMember(Name="AddressInfo", EmitDefaultValue=false)]
		public Address AddressInfo { get; set; }

		[DataMember(Name="LastModifiedDateTime", EmitDefaultValue=false)]
		public DateTimeValue LastModifiedDateTime { get; set; }

		[DataMember(Name="UseAddressfromBranchID", EmitDefaultValue=false)]
		public StringValue UseAddressfromBranchID { get; set; }

		[DataMember(Name="WorkLocationID", EmitDefaultValue=false)]
		public StringValue WorkLocationID { get; set; }

		[DataMember(Name="WorkLocationName", EmitDefaultValue=false)]
		public StringValue WorkLocationName { get; set; }

	}
}