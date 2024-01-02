using System;
using System.Collections.Generic;
using System.Runtime.Serialization;

using Newtonsoft.Json;

using Acumatica.RESTClient.Client;
using Acumatica.RESTClient.ContractBasedApi;
using Acumatica.RESTClient.ContractBasedApi.Model;

namespace Acumatica.Manufacturing_23_100_001.Model
{
	[DataContract]
	public class LaborCodes : Entity, ITopLevelEntity
	{

		[DataMember(Name="Description", EmitDefaultValue=false)]
		public StringValue? Description { get; set; }

		[DataMember(Name="LaborAccount", EmitDefaultValue=false)]
		public StringValue? LaborAccount { get; set; }

		[DataMember(Name="LaborCode", EmitDefaultValue=false)]
		public StringValue? LaborCode { get; set; }

		[DataMember(Name="LaborSub", EmitDefaultValue=false)]
		public StringValue? LaborSub { get; set; }

		[DataMember(Name="OverheadAccount", EmitDefaultValue=false)]
		public StringValue? OverheadAccount { get; set; }

		[DataMember(Name="OverheadSub", EmitDefaultValue=false)]
		public StringValue? OverheadSub { get; set; }

		[DataMember(Name="Type", EmitDefaultValue=false)]
		public StringValue? Type { get; set; }

		public virtual string GetEndpointPath()
		{
			return "entity/MANUFACTURING/23.100.001";
		}
	}
}