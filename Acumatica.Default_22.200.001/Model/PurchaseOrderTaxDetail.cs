using Acumatica.RESTClient.Model;
using System.Collections.Generic;
using System.Runtime.Serialization;

namespace Acumatica.Default_22_200_001.Model
{
	[DataContract]
	public class PurchaseOrderTaxDetail : Entity_v4
	{

		[DataMember(Name="RetainedTaxableAmount", EmitDefaultValue=false)]
		public DecimalValue RetainedTaxableAmount { get; set; }

		[DataMember(Name="RetainedTaxAmount", EmitDefaultValue=false)]
		public DecimalValue RetainedTaxAmount { get; set; }

		[DataMember(Name="TaxableAmount", EmitDefaultValue=false)]
		public DecimalValue TaxableAmount { get; set; }

		[DataMember(Name="TaxAmount", EmitDefaultValue=false)]
		public DecimalValue TaxAmount { get; set; }

		[DataMember(Name="TaxID", EmitDefaultValue=false)]
		public StringValue TaxID { get; set; }

		[DataMember(Name="TaxRate", EmitDefaultValue=false)]
		public DecimalValue TaxRate { get; set; }

	}
}