using System.Collections.Generic;
using System.Runtime.Serialization;

using Newtonsoft.Json;

using Acumatica.RESTClient.Client;
using Acumatica.RESTClient.ContractBasedApi;
using Acumatica.RESTClient.ContractBasedApi.Model;

namespace Acumatica.Manufacturing_23_100_001.Model
{
	[DataContract]
	public class Overhead : Entity
	{

		[DataMember(Name="Account", EmitDefaultValue=false)]
		public StringValue Account { get; set; }

		[DataMember(Name="CostRate", EmitDefaultValue=false)]
		public DecimalValue CostRate { get; set; }

		[DataMember(Name="Description", EmitDefaultValue=false)]
		public StringValue Description { get; set; }

		[DataMember(Name="OverheadID", EmitDefaultValue=false)]
		public StringValue OverheadID { get; set; }

		[DataMember(Name="OverheadType", EmitDefaultValue=false)]
		public StringValue OverheadType { get; set; }

		[DataMember(Name="Subaccount", EmitDefaultValue=false)]
		public StringValue Subaccount { get; set; }

	}
}