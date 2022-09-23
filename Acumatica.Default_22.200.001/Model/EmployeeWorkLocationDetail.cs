using Acumatica.RESTClient.Model;
using System.Collections.Generic;
using System.Runtime.Serialization;

namespace Acumatica.Default_22_200_001.Model
{
	[DataContract]
	public class EmployeeWorkLocationDetail : Entity_v4
	{

		[DataMember(Name="DefaultWorkLocation", EmitDefaultValue=false)]
		public BooleanValue DefaultWorkLocation { get; set; }

		[DataMember(Name="LastModifiedDateTime", EmitDefaultValue=false)]
		public DateTimeValue LastModifiedDateTime { get; set; }

		[DataMember(Name="LocationID", EmitDefaultValue=false)]
		public StringValue LocationID { get; set; }

		[DataMember(Name="LocationName", EmitDefaultValue=false)]
		public StringValue LocationName { get; set; }

	}
}