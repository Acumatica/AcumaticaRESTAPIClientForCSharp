using Acumatica.RESTClient.Model;
using Newtonsoft.Json;
using System.Runtime.Serialization;

namespace Acumatica.Default_20_200_001.Model
{
	[DataContract]
	public class SalesOrderAddInvoiceParameters
	{
		public SalesOrderAddInvoiceParameters() { }

		[DataMember(Name="DocumentType", EmitDefaultValue=false)]
		public StringValue DocumentType { get; set; }
		[DataMember(Name="ReferenceNbr", EmitDefaultValue=false)]
		public StringValue ReferenceNbr { get; set; }
		public virtual string ToJson()
		{
			return JsonConvert.SerializeObject(this, Formatting.Indented);
		}
	}
}