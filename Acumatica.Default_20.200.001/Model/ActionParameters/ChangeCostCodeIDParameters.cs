using Acumatica.RESTClient.Model;
using Newtonsoft.Json;
using System.Runtime.Serialization;

namespace Acumatica.Default_20_200_001.Model
{
	[DataContract]
	public class ChangeCostCodeIDParameters
	{
		public ChangeCostCodeIDParameters() { }

		[DataMember(Name="CostCodeID", EmitDefaultValue=false)]
		public StringValue CostCodeID { get; set; }
		public virtual string ToJson()
		{
			return JsonConvert.SerializeObject(this, Formatting.Indented);
		}
	}
}