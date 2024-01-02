using System.Collections.Generic;
using System.Runtime.Serialization;

using Newtonsoft.Json;

using Acumatica.RESTClient.Client;
using Acumatica.RESTClient.ContractBasedApi;
using Acumatica.RESTClient.ContractBasedApi.Model;

namespace Acumatica.Manufacturing_23_100_001.Model
{
	[DataContract]
	public class EngineeringChangeRequestAttribute : Entity
	{

		[DataMember(Name="AttributeID", EmitDefaultValue=false)]
		public StringValue? AttributeID { get; set; }

		[DataMember(Name="ChangeStatus", EmitDefaultValue=false)]
		public StringValue? ChangeStatus { get; set; }

		[DataMember(Name="Description", EmitDefaultValue=false)]
		public StringValue? Description { get; set; }

		[DataMember(Name="ECRID", EmitDefaultValue=false)]
		public StringValue? ECRID { get; set; }

		[DataMember(Name="Enabled", EmitDefaultValue=false)]
		public BooleanValue? Enabled { get; set; }

		[DataMember(Name="Label", EmitDefaultValue=false)]
		public StringValue? Label { get; set; }

		[DataMember(Name="Level", EmitDefaultValue=false)]
		public StringValue? Level { get; set; }

		[DataMember(Name="LineNbr", EmitDefaultValue=false)]
		public IntValue? LineNbr { get; set; }

		[DataMember(Name="OperationID", EmitDefaultValue=false)]
		public StringValue? OperationID { get; set; }

		[DataMember(Name="OrderFunction", EmitDefaultValue=false)]
		public StringValue? OrderFunction { get; set; }

		[DataMember(Name="Revision", EmitDefaultValue=false)]
		public StringValue? Revision { get; set; }

		[DataMember(Name="TransactionRequired", EmitDefaultValue=false)]
		public BooleanValue? TransactionRequired { get; set; }

		[DataMember(Name="Value", EmitDefaultValue=false)]
		public StringValue? Value { get; set; }

	}
}