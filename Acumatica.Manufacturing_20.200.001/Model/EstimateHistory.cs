using System.Collections.Generic;
using System.Runtime.Serialization;

using Newtonsoft.Json;

using Acumatica.RESTClient.Client;
using Acumatica.RESTClient.ContractBasedApi;
using Acumatica.RESTClient.ContractBasedApi.Model;

namespace Acumatica.Manufacturing_20_200_001.Model
{
	[DataContract]
	public class EstimateHistory : Entity
	{

		[DataMember(Name="CreatedAt", EmitDefaultValue=false)]
		public DateTimeValue CreatedAt { get; set; }

		[DataMember(Name="CreatedBy", EmitDefaultValue=false)]
		public StringValue CreatedBy { get; set; }

		[DataMember(Name="Description", EmitDefaultValue=false)]
		public StringValue Description { get; set; }

		[DataMember(Name="HistoryLineNumber", EmitDefaultValue=false)]
		public IntValue HistoryLineNumber { get; set; }

	}
}