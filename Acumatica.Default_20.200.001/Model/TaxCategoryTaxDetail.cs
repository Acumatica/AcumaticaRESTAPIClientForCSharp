using Acumatica.RESTClient.Model;
using System.Collections.Generic;
using System.Runtime.Serialization;

namespace Acumatica.Default_20_200_001.Model
{
	[DataContract]
	public class TaxCategoryTaxDetail : Entity_v4
	{

		[DataMember(Name="CalculateOn", EmitDefaultValue=false)]
		public StringValue CalculateOn { get; set; }

		[DataMember(Name="CashDiscount", EmitDefaultValue=false)]
		public StringValue CashDiscount { get; set; }

		[DataMember(Name="Description", EmitDefaultValue=false)]
		public StringValue Description { get; set; }

		[DataMember(Name="TaxCategory", EmitDefaultValue=false)]
		public StringValue TaxCategory { get; set; }

		[DataMember(Name="TaxID", EmitDefaultValue=false)]
		public StringValue TaxID { get; set; }

		[DataMember(Name="TaxType", EmitDefaultValue=false)]
		public StringValue TaxType { get; set; }

	}
}