using System.Collections.Generic;
using System.Runtime.Serialization;

using Newtonsoft.Json;

using Acumatica.RESTClient.Client;
using Acumatica.RESTClient.ContractBasedApi;
using Acumatica.RESTClient.ContractBasedApi.Model;

namespace Acumatica.eCommerce_22_200_001.Model
{
	[DataContract]
	public class ProjectTaskProperties : Entity
	{

		[DataMember(Name="Approver", EmitDefaultValue=false)]
		public StringValue Approver { get; set; }

		[DataMember(Name="Completed", EmitDefaultValue=false)]
		public DecimalValue Completed { get; set; }

		[DataMember(Name="CompletionMethod", EmitDefaultValue=false)]
		public StringValue CompletionMethod { get; set; }

		[DataMember(Name="EndDate", EmitDefaultValue=false)]
		public DateTimeValue EndDate { get; set; }

		[DataMember(Name="PlannedEndDate", EmitDefaultValue=false)]
		public DateTimeValue PlannedEndDate { get; set; }

		[DataMember(Name="PlannedStartDate", EmitDefaultValue=false)]
		public DateTimeValue PlannedStartDate { get; set; }

		[DataMember(Name="StartDate", EmitDefaultValue=false)]
		public DateTimeValue StartDate { get; set; }

	}
}