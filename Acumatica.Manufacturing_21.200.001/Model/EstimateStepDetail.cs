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
	public class EstimateStepDetail : Entity
	{

		[DataMember(Name="Description", EmitDefaultValue=false)]
		public StringValue? Description { get; set; }

		[DataMember(Name="LineNbr", EmitDefaultValue=false)]
		public IntValue? LineNbr { get; set; }

		[DataMember(Name="LineOrder", EmitDefaultValue=false)]
		public IntValue? LineOrder { get; set; }

		[DataMember(Name="OperationID", EmitDefaultValue=false)]
		public StringValue? OperationID { get; set; }

	}
}