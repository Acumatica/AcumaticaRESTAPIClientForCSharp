using Acumatica.RESTClient.Model;
using Newtonsoft.Json;
using System.Runtime.Serialization;

namespace Acumatica.Default_18_200_001.Model
{
	[DataContract]
	public partial class ChangeEmployeeIDParameters
	{
		public ChangeEmployeeIDParameters() { }

		public virtual string ToJson()
		{
			return JsonConvert.SerializeObject(this, Formatting.Indented);
		}
	}
}