using System.Collections.Generic;
using System.Runtime.Serialization;

using Newtonsoft.Json;

using Acumatica.RESTClient.Client;
using Acumatica.RESTClient.ContractBasedApi;
using Acumatica.RESTClient.ContractBasedApi.Model;

namespace Acumatica.Manufacturing_23_100_001.Model
{
	[DataContract]
	public class Machine : Entity
	{

		[DataMember(Name="Account", EmitDefaultValue=false)]
		public StringValue Account { get; set; }

		[DataMember(Name="Active", EmitDefaultValue=false)]
		public BooleanValue Active { get; set; }

		[DataMember(Name="AssetID", EmitDefaultValue=false)]
		public StringValue AssetID { get; set; }

		[DataMember(Name="CalendarID", EmitDefaultValue=false)]
		public StringValue CalendarID { get; set; }

		[DataMember(Name="Description", EmitDefaultValue=false)]
		public StringValue Description { get; set; }

		[DataMember(Name="Down", EmitDefaultValue=false)]
		public BooleanValue Down { get; set; }

		[DataMember(Name="Efficiency", EmitDefaultValue=false)]
		public DecimalValue Efficiency { get; set; }

		[DataMember(Name="MachineID", EmitDefaultValue=false)]
		public StringValue MachineID { get; set; }

		[DataMember(Name="StandardCost", EmitDefaultValue=false)]
		public DecimalValue StandardCost { get; set; }

		[DataMember(Name="Subaccount", EmitDefaultValue=false)]
		public StringValue Subaccount { get; set; }

	}
}