using Acumatica.RESTClient.Model;
using System.Collections.Generic;
using System.Runtime.Serialization;

namespace Acumatica.Manufacturing_21_200_001.Model
{
	[DataContract]
	public class LaborCodes : Entity_v4
	{

		[DataMember(Name="Description", EmitDefaultValue=false)]
		public StringValue Description { get; set; }

		[DataMember(Name="LaborAccount", EmitDefaultValue=false)]
		public StringValue LaborAccount { get; set; }

		[DataMember(Name="LaborCode", EmitDefaultValue=false)]
		public StringValue LaborCode { get; set; }

		[DataMember(Name="LaborSub", EmitDefaultValue=false)]
		public StringValue LaborSub { get; set; }

		[DataMember(Name="OverheadAccount", EmitDefaultValue=false)]
		public StringValue OverheadAccount { get; set; }

		[DataMember(Name="OverheadSub", EmitDefaultValue=false)]
		public StringValue OverheadSub { get; set; }

		[DataMember(Name="Type", EmitDefaultValue=false)]
		public StringValue Type { get; set; }

	}
}