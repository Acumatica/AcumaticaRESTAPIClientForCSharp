using System;
using System.Collections.Generic;

using Newtonsoft.Json;

using Acumatica.RESTClient.Client;
using Acumatica.RESTClient.ContractBasedApi;
using Acumatica.RESTClient.ContractBasedApi.Model;

namespace Acumatica.Default_23_200_001.Model
{
	public class Approval : Entity
	{

		public StringValue? ApprovedBy { get; set; }

		public StringValue? ApprovedByName { get; set; }

		public StringValue? Approver { get; set; }

		public StringValue? ApproverName { get; set; }

		public DateTimeValue? Date { get; set; }

		public StringValue? Status { get; set; }

		public StringValue? Workgroup { get; set; }

	}
}