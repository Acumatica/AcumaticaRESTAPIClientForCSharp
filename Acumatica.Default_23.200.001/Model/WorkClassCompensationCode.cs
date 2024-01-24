using System;
using System.Collections.Generic;
using System.Runtime.Serialization;

using Newtonsoft.Json;

using Acumatica.RESTClient.Client;
using Acumatica.RESTClient.ContractBasedApi;
using Acumatica.RESTClient.ContractBasedApi.Model;

namespace Acumatica.Default_23_200_001.Model
{
	[DataContract]
	public class WorkClassCompensationCode : Entity, ITopLevelEntity
	{

		[DataMember(Name="Active", EmitDefaultValue=false)]
		public BooleanValue? Active { get; set; }

		[DataMember(Name="CostCodeFrom", EmitDefaultValue=false)]
		public StringValue? CostCodeFrom { get; set; }

		[DataMember(Name="CostCodeTo", EmitDefaultValue=false)]
		public StringValue? CostCodeTo { get; set; }

		[DataMember(Name="Description", EmitDefaultValue=false)]
		public StringValue? Description { get; set; }

		[DataMember(Name="WCCCode", EmitDefaultValue=false)]
		public StringValue? WCCCode { get; set; }

		public virtual string GetEndpointPath()
		{
			return "entity/Default/23.200.001";
		}
	}
}