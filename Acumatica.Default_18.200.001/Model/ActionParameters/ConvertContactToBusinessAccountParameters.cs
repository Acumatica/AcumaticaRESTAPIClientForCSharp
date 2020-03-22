using Acumatica.RESTClient.Model;
using Newtonsoft.Json;
using System.Runtime.Serialization;

namespace Acumatica.Default_18_200_001.Model
{
	[DataContract]
	public class ConvertContactToBusinessAccountParameters
	{
		public ConvertContactToBusinessAccountParameters() { }

		[DataMember(Name="AccountClass", EmitDefaultValue=false)]
		public StringValue AccountClass { get; set; }
		[DataMember(Name="AccountName", EmitDefaultValue=false)]
		public StringValue AccountName { get; set; }
		[DataMember(Name="BAccountID", EmitDefaultValue=false)]
		public StringValue BAccountID { get; set; }
		public virtual string ToJson()
		{
			return JsonConvert.SerializeObject(this, Formatting.Indented);
		}
	}
}