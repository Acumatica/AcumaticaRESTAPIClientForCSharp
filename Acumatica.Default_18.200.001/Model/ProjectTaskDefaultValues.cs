using Acumatica.RESTClient.Model;
using System.Collections.Generic;
using System.Runtime.Serialization;

namespace Acumatica.Default_18_200_001.Model
{
	[DataContract]
	public class ProjectTaskDefaultValues : Entity
	{

		[DataMember(Name="AccrualAccount", EmitDefaultValue=false)]
		public StringValue AccrualAccount { get; set; }

		[DataMember(Name="AccrualSubaccount", EmitDefaultValue=false)]
		public StringValue AccrualSubaccount { get; set; }

		[DataMember(Name="DefaultAccount", EmitDefaultValue=false)]
		public StringValue DefaultAccount { get; set; }

		[DataMember(Name="DefaultSubaccount", EmitDefaultValue=false)]
		public StringValue DefaultSubaccount { get; set; }

		[DataMember(Name="TaxCategory", EmitDefaultValue=false)]
		public StringValue TaxCategory { get; set; }

	}
}