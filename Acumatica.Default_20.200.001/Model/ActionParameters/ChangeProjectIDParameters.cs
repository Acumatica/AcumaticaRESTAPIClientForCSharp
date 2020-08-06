using Acumatica.RESTClient.Model;
using Newtonsoft.Json;
using System.Runtime.Serialization;

namespace Acumatica.Default_20_200_001.Model
{
	[DataContract]
	public class ChangeProjectIDParameters
	{
		public ChangeProjectIDParameters() { }

		[DataMember(Name="ProjectID", EmitDefaultValue=false)]
		public StringValue ProjectID { get; set; }
		public virtual string ToJson()
		{
			return JsonConvert.SerializeObject(this, Formatting.Indented);
		}
	}
}