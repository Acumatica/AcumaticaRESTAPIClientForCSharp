using System.Collections.Generic;
using System.Runtime.Serialization;

using Newtonsoft.Json;

using Acumatica.RESTClient.Client;
using Acumatica.RESTClient.ContractBasedApi;
using Acumatica.RESTClient.ContractBasedApi.Model;

namespace Acumatica.Manufacturing_20_200_001.Model
{
	[DataContract]
	public class OrderAttributeDetail : Entity
	{

		[DataMember(Name="AttributeID", EmitDefaultValue=false)]
		public StringValue AttributeID { get; set; }

		[DataMember(Name="Description", EmitDefaultValue=false)]
		public StringValue Description { get; set; }

		[DataMember(Name="Enabled", EmitDefaultValue=false)]
		public BooleanValue Enabled { get; set; }

		[DataMember(Name="Label", EmitDefaultValue=false)]
		public StringValue Label { get; set; }

		[DataMember(Name="Level", EmitDefaultValue=false)]
		public StringValue Level { get; set; }

		[DataMember(Name="LineNbr", EmitDefaultValue=false)]
		public IntValue LineNbr { get; set; }

		[DataMember(Name="OperationNbr", EmitDefaultValue=false)]
		public StringValue OperationNbr { get; set; }

		[DataMember(Name="Source", EmitDefaultValue=false)]
		public StringValue Source { get; set; }

		[DataMember(Name="TransactionRequired", EmitDefaultValue=false)]
		public BooleanValue TransactionRequired { get; set; }

		[DataMember(Name="Value", EmitDefaultValue=false)]
		public StringValue Value { get; set; }

	}
}