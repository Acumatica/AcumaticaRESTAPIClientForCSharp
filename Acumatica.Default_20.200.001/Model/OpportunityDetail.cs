using Acumatica.RESTClient.Model;
using System.Collections.Generic;
using System.Runtime.Serialization;

namespace Acumatica.Default_20_200_001.Model
{
	[DataContract]
	public class OpportunityDetail : Entity_v4
	{

		[DataMember(Name="Currency", EmitDefaultValue=false)]
		public StringValue Currency { get; set; }

		[DataMember(Name="DisplayName", EmitDefaultValue=false)]
		public StringValue DisplayName { get; set; }

		[DataMember(Name="Estimation", EmitDefaultValue=false)]
		public DateTimeValue Estimation { get; set; }

		[DataMember(Name="Owner", EmitDefaultValue=false)]
		public StringValue Owner { get; set; }

		[DataMember(Name="Probability", EmitDefaultValue=false)]
		public IntValue Probability { get; set; }

		[DataMember(Name="Stage", EmitDefaultValue=false)]
		public StringValue Stage { get; set; }

		[DataMember(Name="Status", EmitDefaultValue=false)]
		public StringValue Status { get; set; }

		[DataMember(Name="Subject", EmitDefaultValue=false)]
		public StringValue Subject { get; set; }

		[DataMember(Name="Total", EmitDefaultValue=false)]
		public DecimalValue Total { get; set; }

		[DataMember(Name="Workgroup", EmitDefaultValue=false)]
		public StringValue Workgroup { get; set; }

	}
}