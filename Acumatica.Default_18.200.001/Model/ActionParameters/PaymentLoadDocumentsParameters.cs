using Acumatica.RESTClient.Model;
using Newtonsoft.Json;
using System.Runtime.Serialization;

namespace Acumatica.Default_18_200_001.Model
{
	[DataContract]
	public class PaymentLoadDocumentsParameters
	{
		public PaymentLoadDocumentsParameters() { }

		[DataMember(Name="EndRefNbr", EmitDefaultValue=false)]
		public StringValue EndRefNbr { get; set; }
		[DataMember(Name="FromDate", EmitDefaultValue=false)]
		public DateTimeValue FromDate { get; set; }
		[DataMember(Name="LoadChildDocuments", EmitDefaultValue=false)]
		public StringValue LoadChildDocuments { get; set; }
		[DataMember(Name="MaxDocs", EmitDefaultValue=false)]
		public IntValue MaxDocs { get; set; }
		[DataMember(Name="OrderBy", EmitDefaultValue=false)]
		public StringValue OrderBy { get; set; }
		[DataMember(Name="StartRefNbr", EmitDefaultValue=false)]
		public StringValue StartRefNbr { get; set; }
		[DataMember(Name="TillDate", EmitDefaultValue=false)]
		public DateTimeValue TillDate { get; set; }
		public virtual string ToJson()
		{
			return JsonConvert.SerializeObject(this, Formatting.Indented);
		}
	}
}