using Acumatica.RESTClient.Model;
using Newtonsoft.Json;
using System.Runtime.Serialization;

namespace Acumatica.Default_20_200_001.Model
{
	[DataContract]
	public class ChangeEmployeeIDParameters
	{
		public ChangeEmployeeIDParameters() { }

		[DataMember(Name="EmployeeID", EmitDefaultValue=false)]
		public StringValue EmployeeID { get; set; }
		public virtual string ToJson()
		{
			return JsonConvert.SerializeObject(this, Formatting.Indented);
		}
	}
}