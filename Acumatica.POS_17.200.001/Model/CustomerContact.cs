using Acumatica.RESTClient.Model;
using System.Collections.Generic;
using System.Runtime.Serialization;

namespace Acumatica.POS_17_200_001.Model
{
	[DataContract]
	public partial class CustomerContact : Entity
	{

		[DataMember(Name="Contact", EmitDefaultValue=false)]
		public Contact Contact { get; set; }

		[DataMember(Name="ContactID", EmitDefaultValue=false)]
		public IntValue ContactID { get; set; }

	}
}