using Acumatica.RESTClient.Model;
using System.Collections.Generic;
using System.Runtime.Serialization;

namespace Acumatica.Default_18_200_001.Model
{
	[DataContract]
	public class AllocationRule : Entity
	{

		[DataMember(Name="AllocationRuleID", EmitDefaultValue=false)]
		public StringValue AllocationRuleID { get; set; }

		[DataMember(Name="Description", EmitDefaultValue=false)]
		public StringValue Description { get; set; }

	}
}