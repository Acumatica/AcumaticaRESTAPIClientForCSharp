using Acumatica.RESTClient.Model;
using System.Collections.Generic;
using System.Runtime.Serialization;

namespace Acumatica.eCommerce_20_200_001.Model
{
	[DataContract]
	public class TaxZoneApplicableTaxDetail : Entity
	{

		[DataMember(Name="TaxID", EmitDefaultValue=false)]
		public StringValue TaxID { get; set; }

	}
}