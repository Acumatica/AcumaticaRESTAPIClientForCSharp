using Acumatica.RESTClient.Model;
using System.Collections.Generic;
using System.Runtime.Serialization;

namespace Acumatica.Default_18_200_001.Model
{
	[DataContract]
	public class TaxZoneDetail : Entity
	{

		[DataMember(Name="DefaultTaxCategory", EmitDefaultValue=false)]
		public StringValue DefaultTaxCategory { get; set; }

		[DataMember(Name="Description", EmitDefaultValue=false)]
		public StringValue Description { get; set; }

		[DataMember(Name="TaxID", EmitDefaultValue=false)]
		public StringValue TaxID { get; set; }

		[DataMember(Name="TaxZoneID", EmitDefaultValue=false)]
		public StringValue TaxZoneID { get; set; }

	}
}