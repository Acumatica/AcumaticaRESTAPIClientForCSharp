using System.Collections.Generic;
using System.Runtime.Serialization;

using Newtonsoft.Json;

using Acumatica.RESTClient.Client;
using Acumatica.RESTClient.ContractBasedApi;
using Acumatica.RESTClient.ContractBasedApi.Model;

namespace Acumatica.Default_20_200_001.Model
{
	[DataContract]
	public class ContactNotification : Entity
	{

		[DataMember(Name="Active", EmitDefaultValue=false)]
		public BooleanValue Active { get; set; }

		[DataMember(Name="Bcc", EmitDefaultValue=false)]
		public BooleanValue Bcc { get; set; }

		[DataMember(Name="ClassID", EmitDefaultValue=false)]
		public StringValue ClassID { get; set; }

		[DataMember(Name="Description", EmitDefaultValue=false)]
		public StringValue Description { get; set; }

		[DataMember(Name="Format", EmitDefaultValue=false)]
		public StringValue Format { get; set; }

		[DataMember(Name="MailingID", EmitDefaultValue=false)]
		public StringValue MailingID { get; set; }

		[DataMember(Name="Module", EmitDefaultValue=false)]
		public StringValue Module { get; set; }

		[DataMember(Name="NotificationID", EmitDefaultValue=false)]
		public IntValue NotificationID { get; set; }

		[DataMember(Name="Report", EmitDefaultValue=false)]
		public StringValue Report { get; set; }

		[DataMember(Name="Source", EmitDefaultValue=false)]
		public StringValue Source { get; set; }

	}
}