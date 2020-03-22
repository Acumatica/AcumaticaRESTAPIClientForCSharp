using Acumatica.RESTClient.Model;
using System.Collections.Generic;
using System.Runtime.Serialization;

namespace Acumatica.Default_18_200_001.Model
{
	[DataContract]
	public class JournalVoucherDetailAPDocumentToApply : Entity
	{

		[DataMember(Name="DocType", EmitDefaultValue=false)]
		public StringValue DocType { get; set; }

		[DataMember(Name="ReferenceNbr", EmitDefaultValue=false)]
		public StringValue ReferenceNbr { get; set; }

		[DataMember(Name="VendorRef", EmitDefaultValue=false)]
		public StringValue VendorRef { get; set; }

		[DataMember(Name="WithTax", EmitDefaultValue=false)]
		public DecimalValue WithTax { get; set; }

		[DataMember(Name="WithTaxBalance", EmitDefaultValue=false)]
		public DecimalValue WithTaxBalance { get; set; }

	}
}