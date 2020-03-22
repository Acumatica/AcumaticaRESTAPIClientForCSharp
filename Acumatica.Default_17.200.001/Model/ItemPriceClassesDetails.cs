using Acumatica.RESTClient.Model;
using System.Collections.Generic;
using System.Runtime.Serialization;

namespace Acumatica.Default_17_200_001.Model
{
	[DataContract]
	public class ItemPriceClassesDetails : Entity
	{

		[DataMember(Name="PriceClassID", EmitDefaultValue=false)]
		public StringValue PriceClassID { get; set; }

	}
}