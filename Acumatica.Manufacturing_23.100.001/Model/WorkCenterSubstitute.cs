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
	public class WorkCenterSubstitute : Entity
	{

		[DataMember(Name="SubstituteWorkCenter", EmitDefaultValue=false)]
		public StringValue? SubstituteWorkCenter { get; set; }

		[DataMember(Name="UpdateOperationDescription", EmitDefaultValue=false)]
		public BooleanValue? UpdateOperationDescription { get; set; }

		[DataMember(Name="Warehouse", EmitDefaultValue=false)]
		public StringValue? Warehouse { get; set; }

	}
}