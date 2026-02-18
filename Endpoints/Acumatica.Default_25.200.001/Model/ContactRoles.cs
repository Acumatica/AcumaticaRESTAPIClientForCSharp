using System;
using System.Collections.Generic;

using Newtonsoft.Json;

using Acumatica.RESTClient.Client;
using Acumatica.RESTClient.ContractBasedApi;
using Acumatica.RESTClient.ContractBasedApi.Model;

namespace Acumatica.Default_25_200_001.Model
{
	public class ContactRoles : Entity
	{

		public StringValue? RoleDescription { get; set; }

		public StringValue? RoleName { get; set; }

		public BooleanValue? Selected { get; set; }

		public IntValue? UserType { get; set; }

	}
}