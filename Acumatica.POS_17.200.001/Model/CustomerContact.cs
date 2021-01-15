using Acumatica.RESTClient.Model;
using System.Collections.Generic;
using System.Runtime.Serialization;

namespace Acumatica.POS_17_200_001.Model
{
	[DataContract]
	public class CustomerContact : Entity_v3
	{

		[DataMember(Name="Contact", EmitDefaultValue=false)]
		public Contact Contact { get; set; }

		[DataMember(Name="ContactID", EmitDefaultValue=false)]
		public IntValue ContactID { get; set; }

	}
}