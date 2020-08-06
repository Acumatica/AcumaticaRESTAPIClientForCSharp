using Acumatica.RESTClient.Model;
using Newtonsoft.Json;
using System.Runtime.Serialization;

namespace Acumatica.Default_20_200_001.Model
{
	[DataContract]
	public class ChangeBusinessAccountIDParameters
	{
		public ChangeBusinessAccountIDParameters() { }

		[DataMember(Name="BusinessAccountID", EmitDefaultValue=false)]
		public StringValue BusinessAccountID { get; set; }
		public virtual string ToJson()
		{
			return JsonConvert.SerializeObject(this, Formatting.Indented);
		}
	}
}