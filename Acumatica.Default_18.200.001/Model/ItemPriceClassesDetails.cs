using Acumatica.RESTClient.Model;
using System.Collections.Generic;
using System.Runtime.Serialization;

namespace Acumatica.Default_18_200_001.Model
{
	[DataContract]
	public class ItemPriceClassesDetails : Entity_v3
	{

		[DataMember(Name="PriceClassID", EmitDefaultValue=false)]
		public StringValue PriceClassID { get; set; }

	}
}