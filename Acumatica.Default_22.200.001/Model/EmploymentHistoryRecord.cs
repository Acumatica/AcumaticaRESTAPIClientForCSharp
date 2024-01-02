using System;
using System.Collections.Generic;
using System.Runtime.Serialization;

using Newtonsoft.Json;

using Acumatica.RESTClient.Client;
using Acumatica.RESTClient.ContractBasedApi;
using Acumatica.RESTClient.ContractBasedApi.Model;

namespace Acumatica.Default_22_200_001.Model
{
	[DataContract]
	public class EmploymentHistoryRecord : Entity
	{

		[DataMember(Name="Active", EmitDefaultValue=false)]
		public BooleanValue? Active { get; set; }

		[DataMember(Name="EndDate", EmitDefaultValue=false)]
		public DateTimeValue? EndDate { get; set; }

		[DataMember(Name="LineNbr", EmitDefaultValue=false)]
		public IntValue? LineNbr { get; set; }

		[DataMember(Name="PositionID", EmitDefaultValue=false)]
		public StringValue? PositionID { get; set; }

		[DataMember(Name="RehireEligible", EmitDefaultValue=false)]
		public BooleanValue? RehireEligible { get; set; }

		[DataMember(Name="StartDate", EmitDefaultValue=false)]
		public DateTimeValue? StartDate { get; set; }

		[DataMember(Name="StartReason", EmitDefaultValue=false)]
		public StringValue? StartReason { get; set; }

		[DataMember(Name="Terminated", EmitDefaultValue=false)]
		public BooleanValue? Terminated { get; set; }

		[DataMember(Name="TerminationReason", EmitDefaultValue=false)]
		public StringValue? TerminationReason { get; set; }

	}
}