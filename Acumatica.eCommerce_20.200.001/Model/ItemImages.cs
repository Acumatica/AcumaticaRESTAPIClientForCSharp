using Acumatica.RESTClient.Model;
using System.Collections.Generic;
using System.Runtime.Serialization;

namespace Acumatica.eCommerce_20_200_001.Model
{
	[DataContract]
	public class ItemImages : Entity_v4
	{

		[DataMember(Name="Results", EmitDefaultValue=false)]
		public List<ItemImageDetails> Results { get; set; }

	}
}