using Acumatica.RESTClient.Model;
using Newtonsoft.Json;
using System.Runtime.Serialization;

namespace Acumatica.eCommerce_20_200_001.Model
{
	[DataContract]
	public class RegisterAuthTranParameters
	{
		public RegisterAuthTranParameters() { }

		[DataMember(Name="PaymentGatewayCreateProfile", EmitDefaultValue=false)]
		public StringValue PaymentGatewayCreateProfile { get; set; }
		[DataMember(Name="PaymentGatewayTranID", EmitDefaultValue=false)]
		public StringValue PaymentGatewayTranID { get; set; }
		public virtual string ToJson()
		{
			return JsonConvert.SerializeObject(this, Formatting.Indented);
		}
	}
}