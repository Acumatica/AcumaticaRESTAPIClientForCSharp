using System;
using System.Collections.Generic;
using System.Runtime.Serialization;

using Newtonsoft.Json;

using Acumatica.RESTClient.Client;
using Acumatica.RESTClient.ContractBasedApi;
using Acumatica.RESTClient.ContractBasedApi.Model;

namespace Acumatica.eCommerce_24_200_001.Model
{
	[DataContract]
	public class TimeActivity : Entity
	{

		[DataMember(Name="Approver", EmitDefaultValue=false)]
		public StringValue? Approver { get; set; }

		[DataMember(Name="Billable", EmitDefaultValue=false)]
		public BooleanValue? Billable { get; set; }

		[DataMember(Name="BillableOvertime", EmitDefaultValue=false)]
		public StringValue? BillableOvertime { get; set; }

		[DataMember(Name="BillableTime", EmitDefaultValue=false)]
		public StringValue? BillableTime { get; set; }

		[DataMember(Name="CostCode", EmitDefaultValue=false)]
		public StringValue? CostCode { get; set; }

		[DataMember(Name="EarningType", EmitDefaultValue=false)]
		public StringValue? EarningType { get; set; }

		[DataMember(Name="Overtime", EmitDefaultValue=false)]
		public StringValue? Overtime { get; set; }

		[DataMember(Name="Project", EmitDefaultValue=false)]
		public StringValue? Project { get; set; }

		[DataMember(Name="ProjectTask", EmitDefaultValue=false)]
		public StringValue? ProjectTask { get; set; }

		[DataMember(Name="ReferenceNbr", EmitDefaultValue=false)]
		public StringValue? ReferenceNbr { get; set; }

		[DataMember(Name="Released", EmitDefaultValue=false)]
		public BooleanValue? Released { get; set; }

		[DataMember(Name="Status", EmitDefaultValue=false)]
		public StringValue? Status { get; set; }

		[DataMember(Name="TimeSpent", EmitDefaultValue=false)]
		public StringValue? TimeSpent { get; set; }

		[DataMember(Name="TrackTime", EmitDefaultValue=false)]
		public BooleanValue? TrackTime { get; set; }

	}
}