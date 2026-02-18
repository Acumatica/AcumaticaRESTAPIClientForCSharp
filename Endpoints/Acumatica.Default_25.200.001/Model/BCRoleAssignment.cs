using System;
using System.Collections.Generic;

using Newtonsoft.Json;

using Acumatica.RESTClient.Client;
using Acumatica.RESTClient.ContractBasedApi;
using Acumatica.RESTClient.ContractBasedApi.Model;

namespace Acumatica.Default_25_200_001.Model
{
	public class BCRoleAssignment : Entity
	{

		public IntValue? RoleAssignmentID { get; set; }

		public IntValue? BAccountID { get; set; }

		public IntValue? ContactID { get; set; }

		public StringValue? LocationCD { get; set; }

		public StringValue? Role { get; set; }

		public DateTimeValue? CreatedDateTime { get; set; }

		public DateTimeValue? LastModifiedDateTime { get; set; }

	}
}