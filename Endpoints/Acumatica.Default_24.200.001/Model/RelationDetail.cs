using System;
using System.Collections.Generic;

using Newtonsoft.Json;

using Acumatica.RESTClient.Client;
using Acumatica.RESTClient.ContractBasedApi;
using Acumatica.RESTClient.ContractBasedApi.Model;

namespace Acumatica.Default_24_200_001.Model
{
	public class RelationDetail : Entity
	{

		public StringValue? Account { get; set; }

		public BooleanValue? AddToCc { get; set; }

		public StringValue? ContactDisplayName { get; set; }

		public IntValue? ContactID { get; set; }

		public GuidValue? Document { get; set; }

		public StringValue? DocumentTargetNoteIDDescription { get; set; }

		public StringValue? Email { get; set; }

		public StringValue? Name { get; set; }

		public BooleanValue? Primary { get; set; }

		public IntValue? RelationID { get; set; }

		public StringValue? Role { get; set; }

		public StringValue? Type { get; set; }

		public DateTimeValue? DocumentDate { get; set; }

	}
}