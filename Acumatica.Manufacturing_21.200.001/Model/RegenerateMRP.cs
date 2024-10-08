using System;
using System.Collections.Generic;
using System.Runtime.Serialization;

using Newtonsoft.Json;

using Acumatica.RESTClient.Client;
using Acumatica.RESTClient.ContractBasedApi;
using Acumatica.RESTClient.ContractBasedApi.Model;

namespace Acumatica.Manufacturing_21_200_001.Model
{
	[DataContract]
	public class RegenerateMRP : Entity, ITopLevelEntity
	{

		[DataMember(Name="LastCompletedAt", EmitDefaultValue=false)]
		public DateTimeValue? LastCompletedAt { get; set; }

		[DataMember(Name="LastCompletedBy", EmitDefaultValue=false)]
		public StringValue? LastCompletedBy { get; set; }

		[DataMember(Name="Messages", EmitDefaultValue=false)]
		public List<RegenerateMRPMessage>? Messages { get; set; }

		public virtual string GetEndpointPath()
		{
			return "entity/MANUFACTURING/21.200.001";
		}
	}
}