using Acumatica.RESTClient.Model;
using System.Collections.Generic;
using System.Runtime.Serialization;

namespace Acumatica.POS_17_200_001.Model
{
	[DataContract]
	public class DiscountItemPriceClassesDetail : Entity
	{

		[DataMember(Name="PriceClassID", EmitDefaultValue=false)]
		public StringValue PriceClassID { get; set; }

	}
}