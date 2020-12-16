using Acumatica.RESTClient.Model;
using System.Collections.Generic;
using System.Runtime.Serialization;

namespace Acumatica.Default_20_200_001.Model
{
	[DataContract]
	public class ProjectBilling : Entity_v4
	{

		[DataMember(Name="Customer", EmitDefaultValue=false)]
		public StringValue Customer { get; set; }

		[DataMember(Name="CustomerClass", EmitDefaultValue=false)]
		public StringValue CustomerClass { get; set; }

		[DataMember(Name="Details", EmitDefaultValue=false)]
		public List<ProjectBillingDetails> Details { get; set; }

		[DataMember(Name="InvoiceDate", EmitDefaultValue=false)]
		public DateTimeValue InvoiceDate { get; set; }

		[DataMember(Name="PostPeriod", EmitDefaultValue=false)]
		public StringValue PostPeriod { get; set; }

		[DataMember(Name="ProjectTemplate", EmitDefaultValue=false)]
		public StringValue ProjectTemplate { get; set; }

		[DataMember(Name="StatementCycle", EmitDefaultValue=false)]
		public StringValue StatementCycle { get; set; }

	}
}