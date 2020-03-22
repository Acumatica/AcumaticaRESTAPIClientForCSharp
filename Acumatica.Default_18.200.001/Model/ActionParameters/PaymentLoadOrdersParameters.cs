using Acumatica.RESTClient.Model;
using Newtonsoft.Json;
using System.Runtime.Serialization;

namespace Acumatica.Default_18_200_001.Model
{
	[DataContract]
	public class PaymentLoadOrdersParameters
	{
		public PaymentLoadOrdersParameters() { }

		[DataMember(Name="EndOrderNbr", EmitDefaultValue=false)]
		public StringValue EndOrderNbr { get; set; }
		[DataMember(Name="FromDate", EmitDefaultValue=false)]
		public DateTimeValue FromDate { get; set; }
		[DataMember(Name="MaxDocs", EmitDefaultValue=false)]
		public IntValue MaxDocs { get; set; }
		[DataMember(Name="SOOrderBy", EmitDefaultValue=false)]
		public StringValue SOOrderBy { get; set; }
		[DataMember(Name="StartOrderNbr", EmitDefaultValue=false)]
		public StringValue StartOrderNbr { get; set; }
		[DataMember(Name="TillDate", EmitDefaultValue=false)]
		public DateTimeValue TillDate { get; set; }
		public virtual string ToJson()
		{
			return JsonConvert.SerializeObject(this, Formatting.Indented);
		}
	}
}