using Acumatica.RESTClient.Model;
using Newtonsoft.Json;
using System.Runtime.Serialization;

namespace Acumatica.Default_17_200_001.Model
{
	[DataContract]
	public partial class UpdateDiscountsParameters
	{
		public UpdateDiscountsParameters() { }

		public virtual string ToJson()
		{
			return JsonConvert.SerializeObject(this, Formatting.Indented);
		}
	}
}