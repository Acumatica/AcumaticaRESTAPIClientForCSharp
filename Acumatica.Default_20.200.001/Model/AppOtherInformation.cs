using System;
using System.Collections.Generic;
using System.Runtime.Serialization;

using Newtonsoft.Json;

using Acumatica.RESTClient.Client;
using Acumatica.RESTClient.ContractBasedApi;
using Acumatica.RESTClient.ContractBasedApi.Model;

namespace Acumatica.Default_20_200_001.Model
{
	[DataContract]
	public class AppOtherInformation : Entity
	{

		[DataMember(Name="BatchNbr", EmitDefaultValue=false)]
		public StringValue? BatchNbr { get; set; }

		[DataMember(Name="Description", EmitDefaultValue=false)]
		public StringValue? Description { get; set; }

		[DataMember(Name="DocumentType", EmitDefaultValue=false)]
		public StringValue? DocumentType { get; set; }

		[DataMember(Name="InvoiceNbr", EmitDefaultValue=false)]
		public StringValue? InvoiceNbr { get; set; }

		[DataMember(Name="IssueReferenceNbr", EmitDefaultValue=false)]
		public StringValue? IssueReferenceNbr { get; set; }

		[DataMember(Name="RecurrenceDescription", EmitDefaultValue=false)]
		public StringValue? RecurrenceDescription { get; set; }

		[DataMember(Name="ReferenceNbr", EmitDefaultValue=false)]
		public StringValue? ReferenceNbr { get; set; }

		[DataMember(Name="RouteID", EmitDefaultValue=false)]
		public StringValue? RouteID { get; set; }

		[DataMember(Name="RouteNbr", EmitDefaultValue=false)]
		public StringValue? RouteNbr { get; set; }

		[DataMember(Name="SourceScheduleID", EmitDefaultValue=false)]
		public StringValue? SourceScheduleID { get; set; }

		[DataMember(Name="SourceServiceContractID", EmitDefaultValue=false)]
		public StringValue? SourceServiceContractID { get; set; }

	}
}