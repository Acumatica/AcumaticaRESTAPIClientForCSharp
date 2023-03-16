using Acumatica.RESTClient.Model;
using System.Collections.Generic;
using System.Runtime.Serialization;

namespace Acumatica.Default_22_200_001.Model
{
	[DataContract]
	public class EarningCodeProjectSettings : Entity
	{

		[DataMember(Name="BillableProject", EmitDefaultValue=false)]
		public BooleanValue BillableProject { get; set; }

		[DataMember(Name="DefaultProjectCode", EmitDefaultValue=false)]
		public StringValue DefaultProjectCode { get; set; }

		[DataMember(Name="DefaultProjectTask", EmitDefaultValue=false)]
		public StringValue DefaultProjectTask { get; set; }

	}
}