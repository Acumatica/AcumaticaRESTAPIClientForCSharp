using Acumatica.RESTClient.Model;
using System.Collections.Generic;
using System.Runtime.Serialization;

namespace Acumatica.Default_18_200_001.Model
{
	[DataContract]
	public class SalesInvoiceFinancialDetails : Entity
	{

		[DataMember(Name="BatchNbr", EmitDefaultValue=false)]
		public StringValue BatchNbr { get; set; }

		[DataMember(Name="Branch", EmitDefaultValue=false)]
		public StringValue Branch { get; set; }

		[DataMember(Name="CustomerTaxZone", EmitDefaultValue=false)]
		public StringValue CustomerTaxZone { get; set; }

	}
}