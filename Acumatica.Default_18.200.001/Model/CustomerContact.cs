using Acumatica.RESTClient.Model;
using System.Collections.Generic;
using System.Runtime.Serialization;

namespace Acumatica.Default_18_200_001.Model
{
	[DataContract]
	public class CustomerContact : Entity
	{

		[DataMember(Name="Contact", EmitDefaultValue=false)]
		public Contact Contact { get; set; }

		[DataMember(Name="ContactID", EmitDefaultValue=false)]
		public IntValue ContactID { get; set; }

	}
}