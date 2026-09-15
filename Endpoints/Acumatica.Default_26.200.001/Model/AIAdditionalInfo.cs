using System;
using System.Collections.Generic;
using System.Runtime.Serialization;

using Newtonsoft.Json;

using Acumatica.RESTClient.Client;
using Acumatica.RESTClient.ContractBasedApi;
using Acumatica.RESTClient.ContractBasedApi.Model;

namespace Acumatica.Default_26_200_001.Model
{
	[DataContract]
	public class AIAdditionalInfo : Entity
	{

		[DataMember(Name="NoteID", EmitDefaultValue=false)]
		public GuidValue? NoteID { get; set; }

		[DataMember(Name="Body", EmitDefaultValue=false)]
		public StringValue? Body { get; set; }

		[DataMember(Name="BodyAsPlainText", EmitDefaultValue=false)]
		public StringValue? BodyAsPlainText { get; set; }

		[DataMember(Name="ClearedBodyAsPlainText", EmitDefaultValue=false)]
		public StringValue? ClearedBodyAsPlainText { get; set; }

		[DataMember(Name="ReplyBodyAsPlainText", EmitDefaultValue=false)]
		public StringValue? ReplyBodyAsPlainText { get; set; }

	}
}