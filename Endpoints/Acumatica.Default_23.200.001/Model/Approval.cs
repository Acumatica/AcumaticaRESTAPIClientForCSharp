using System;
using System.Collections.Generic;
using System.Runtime.Serialization;

using Newtonsoft.Json;

using Acumatica.RESTClient.Client;
using Acumatica.RESTClient.ContractBasedApi;
using Acumatica.RESTClient.ContractBasedApi.Model;

namespace Acumatica.Default_23_200_001.Model
{
	[DataContract]
	public class Approval : Entity
	{

		[DataMember(Name="ApprovedBy", EmitDefaultValue=false)]
		public StringValue? ApprovedBy { get; set; }

		[DataMember(Name="ApprovedByName", EmitDefaultValue=false)]
		public StringValue? ApprovedByName { get; set; }

		[DataMember(Name="Approver", EmitDefaultValue=false)]
		public StringValue? Approver { get; set; }

		[DataMember(Name="ApproverName", EmitDefaultValue=false)]
		public StringValue? ApproverName { get; set; }

		[DataMember(Name="Date", EmitDefaultValue=false)]
		public DateTimeValue? Date { get; set; }

		[DataMember(Name="Status", EmitDefaultValue=false)]
		public StringValue? Status { get; set; }

		[DataMember(Name="Workgroup", EmitDefaultValue=false)]
		public StringValue? Workgroup { get; set; }

	}
}