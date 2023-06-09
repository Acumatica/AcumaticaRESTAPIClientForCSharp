using System.Collections.Generic;
using System.Runtime.Serialization;

using Newtonsoft.Json;

using Acumatica.RESTClient.Client;
using Acumatica.RESTClient.ContractBasedApi;
using Acumatica.RESTClient.ContractBasedApi.Model;

namespace Acumatica.eCommerce_20_200_001.Model
{
	[DataContract]
	public class EmailProcessingRow : Entity
	{

		[DataMember(Name="EmailAccount", EmitDefaultValue=false)]
		public StringValue EmailAccount { get; set; }

		[DataMember(Name="From", EmitDefaultValue=false)]
		public StringValue From { get; set; }

		[DataMember(Name="MailStatus", EmitDefaultValue=false)]
		public StringValue MailStatus { get; set; }

		[DataMember(Name="Owner", EmitDefaultValue=false)]
		public StringValue Owner { get; set; }

		[DataMember(Name="Selected", EmitDefaultValue=false)]
		public BooleanValue Selected { get; set; }

		[DataMember(Name="StartDate", EmitDefaultValue=false)]
		public DateTimeValue StartDate { get; set; }

		[DataMember(Name="Subject", EmitDefaultValue=false)]
		public StringValue Subject { get; set; }

		[DataMember(Name="To", EmitDefaultValue=false)]
		public StringValue To { get; set; }

	}
}