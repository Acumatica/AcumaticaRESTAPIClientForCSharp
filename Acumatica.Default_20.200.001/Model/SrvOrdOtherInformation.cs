using Acumatica.RESTClient.Model;
using System.Collections.Generic;
using System.Runtime.Serialization;

namespace Acumatica.Default_20_200_001.Model
{
	[DataContract]
	public class SrvOrdOtherInformation : Entity_v4
	{

		[DataMember(Name="BatchNumber", EmitDefaultValue=false)]
		public StringValue BatchNumber { get; set; }

		[DataMember(Name="Description", EmitDefaultValue=false)]
		public StringValue Description { get; set; }

		[DataMember(Name="DocumentType", EmitDefaultValue=false)]
		public StringValue DocumentType { get; set; }

		[DataMember(Name="InvoiceNbr", EmitDefaultValue=false)]
		public StringValue InvoiceNbr { get; set; }

		[DataMember(Name="IssueReferenceNbr", EmitDefaultValue=false)]
		public StringValue IssueReferenceNbr { get; set; }

		[DataMember(Name="ReferenceNbr", EmitDefaultValue=false)]
		public StringValue ReferenceNbr { get; set; }

	}
}