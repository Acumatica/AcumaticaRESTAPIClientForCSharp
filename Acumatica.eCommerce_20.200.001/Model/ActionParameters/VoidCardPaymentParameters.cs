using Acumatica.RESTClient.Model;
using Newtonsoft.Json;
using System.Runtime.Serialization;

namespace Acumatica.eCommerce_20_200_001.Model
{
	[DataContract]
	public class VoidCardPaymentParameters
	{
		public VoidCardPaymentParameters() { }

		[DataMember(Name="TranType", EmitDefaultValue=false)]
		public StringValue TranType { get; set; }
		[DataMember(Name="TranNbr", EmitDefaultValue=false)]
		public StringValue TranNbr { get; set; }
		[DataMember(Name="ExtProfileId", EmitDefaultValue=false)]
		public StringValue ExtProfileId { get; set; }
		[DataMember(Name="TranDate", EmitDefaultValue=false)]
		public DateTimeValue TranDate { get; set; }
		[DataMember(Name="NeedValidation", EmitDefaultValue=false)]
		public BooleanValue NeedValidation { get; set; }
		[DataMember(Name="OrigTranNbr", EmitDefaultValue=false)]
		public StringValue OrigTranNbr { get; set; }
		public virtual string ToJson()
		{
			return JsonConvert.SerializeObject(this, Formatting.Indented);
		}
	}
}