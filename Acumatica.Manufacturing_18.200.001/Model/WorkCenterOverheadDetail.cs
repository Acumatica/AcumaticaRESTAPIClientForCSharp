using Acumatica.RESTClient.Model;
using System.Collections.Generic;
using System.Runtime.Serialization;

namespace Acumatica.Manufacturing_18_200_001.Model
{
	[DataContract]
	public class WorkCenterOverheadDetail : Entity_v3
	{

		[DataMember(Name="Description", EmitDefaultValue=false)]
		public StringValue Description { get; set; }

		[DataMember(Name="Factor", EmitDefaultValue=false)]
		public DecimalValue Factor { get; set; }

		[DataMember(Name="Overhead", EmitDefaultValue=false)]
		public StringValue Overhead { get; set; }

		[DataMember(Name="Type", EmitDefaultValue=false)]
		public StringValue Type { get; set; }

	}
}