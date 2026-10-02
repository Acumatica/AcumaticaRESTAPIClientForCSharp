using System;
using System.Collections.Generic;

using Newtonsoft.Json;

using Acumatica.RESTClient.Client;
using Acumatica.RESTClient.ContractBasedApi;
using Acumatica.RESTClient.ContractBasedApi.Model;

namespace Acumatica.Default_26_200_001.Model
{
	public class AIAdditionalInfo : Entity
	{

		#region Fields
		public GuidValue? NoteID { get; set; }

		public StringValue? Body { get; set; }

		public StringValue? BodyAsPlainText { get; set; }

		public StringValue? ClearedBodyAsPlainText { get; set; }

		public StringValue? ReplyBodyAsPlainText { get; set; }

		#endregion

	}
}