using Acumatica.RESTClient.Model;
using System.Collections.Generic;
using System.Runtime.Serialization;

namespace Acumatica.Default_22_200_001.Model
{
	[DataContract]
	public class EarningCodeTaxDetailUS : Entity_v4
	{

		[DataMember(Name="TaxCode", EmitDefaultValue=false)]
		public StringValue TaxCode { get; set; }

		[DataMember(Name="TaxName", EmitDefaultValue=false)]
		public StringValue TaxName { get; set; }

	}
}