using System.Collections.Generic;
using System.Runtime.Serialization;

using Newtonsoft.Json;

using Acumatica.RESTClient.Client;
using Acumatica.RESTClient.ContractBasedApi;
using Acumatica.RESTClient.ContractBasedApi.Model;

namespace Acumatica.Manufacturing_23_100_001.Model
{
	[DataContract]
	public class MPSType : Entity, ITopLevelEntity
	{

		[DataMember(Name="Dependent", EmitDefaultValue=false)]
		public BooleanValue? Dependent { get; set; }

		[DataMember(Name="Description", EmitDefaultValue=false)]
		public StringValue? Description { get; set; }

		[DataMember(Name="NumberingSequence", EmitDefaultValue=false)]
		public StringValue? NumberingSequence { get; set; }

		[DataMember(Name="TypeID", EmitDefaultValue=false)]
		public StringValue? TypeID { get; set; }

		public virtual string GetEndpointPath()
		{
			return "entity/MANUFACTURING/23.100.001";
		}
	}
}