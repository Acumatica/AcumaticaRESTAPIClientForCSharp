using System.Collections.Generic;
using System.Runtime.Serialization;

using Newtonsoft.Json;

using Acumatica.RESTClient.Client;
using Acumatica.RESTClient.ContractBasedApi;
using Acumatica.RESTClient.ContractBasedApi.Model;

namespace Acumatica.Manufacturing_23_100_001.Model
{
	[DataContract]
	public class Shift : Entity, ITopLevelEntity
	{

		[DataMember(Name="CrewSize", EmitDefaultValue=false)]
		public DecimalValue CrewSize { get; set; }

		[DataMember(Name="Description", EmitDefaultValue=false)]
		public StringValue Description { get; set; }

		[DataMember(Name="DiffType", EmitDefaultValue=false)]
		public StringValue DiffType { get; set; }

		[DataMember(Name="shift", EmitDefaultValue=false)]
		public StringValue shift { get; set; }

		[DataMember(Name="ShiftDiff", EmitDefaultValue=false)]
		public DecimalValue ShiftDiff { get; set; }

		public string GetEndpointPath()
		{
			return "entity/MANUFACTURING/23.100.001";
		}
	}
}