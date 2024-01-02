using System.Collections.Generic;
using System.Runtime.Serialization;

using Newtonsoft.Json;

using Acumatica.RESTClient.Client;
using Acumatica.RESTClient.ContractBasedApi;
using Acumatica.RESTClient.ContractBasedApi.Model;

namespace Acumatica.Default_22_200_001.Model
{
	[DataContract]
	public class Subaccount : Entity, ITopLevelEntity
	{

		[DataMember(Name="Active", EmitDefaultValue=false)]
		public BooleanValue? Active { get; set; }

		[DataMember(Name="Description", EmitDefaultValue=false)]
		public StringValue? Description { get; set; }

		[DataMember(Name="Secured", EmitDefaultValue=false)]
		public BooleanValue? Secured { get; set; }

		[DataMember(Name="SubaccountCD", EmitDefaultValue=false)]
		public StringValue? SubaccountCD { get; set; }

		[DataMember(Name="SubaccountID", EmitDefaultValue=false)]
		public IntValue? SubaccountID { get; set; }

		public virtual string GetEndpointPath()
		{
			return "entity/Default/22.200.001";
		}
	}
}