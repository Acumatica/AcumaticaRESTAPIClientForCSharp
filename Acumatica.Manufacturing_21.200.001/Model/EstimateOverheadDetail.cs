using System.Collections.Generic;
using System.Runtime.Serialization;

using Newtonsoft.Json;

using Acumatica.RESTClient.Client;
using Acumatica.RESTClient.ContractBasedApi;
using Acumatica.RESTClient.ContractBasedApi.Model;

namespace Acumatica.Manufacturing_21_200_001.Model
{
	[DataContract]
	public class EstimateOverheadDetail : Entity
	{

		[DataMember(Name="Description", EmitDefaultValue=false)]
		public StringValue Description { get; set; }

		[DataMember(Name="EstimateID", EmitDefaultValue=false)]
		public StringValue EstimateID { get; set; }

		[DataMember(Name="Factor", EmitDefaultValue=false)]
		public DecimalValue Factor { get; set; }

		[DataMember(Name="LineNbr", EmitDefaultValue=false)]
		public IntValue LineNbr { get; set; }

		[DataMember(Name="OperationID", EmitDefaultValue=false)]
		public StringValue OperationID { get; set; }

		[DataMember(Name="OverheadCostRate", EmitDefaultValue=false)]
		public DecimalValue OverheadCostRate { get; set; }

		[DataMember(Name="OverheadID", EmitDefaultValue=false)]
		public StringValue OverheadID { get; set; }

		[DataMember(Name="Revision", EmitDefaultValue=false)]
		public StringValue Revision { get; set; }

		[DataMember(Name="Type", EmitDefaultValue=false)]
		public StringValue Type { get; set; }

		[DataMember(Name="WCFlag", EmitDefaultValue=false)]
		public BooleanValue WCFlag { get; set; }

	}
}