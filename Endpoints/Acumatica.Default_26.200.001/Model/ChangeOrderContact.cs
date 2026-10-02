using System;
using System.Collections.Generic;

using Newtonsoft.Json;

using Acumatica.RESTClient.Client;
using Acumatica.RESTClient.ContractBasedApi;
using Acumatica.RESTClient.ContractBasedApi.Model;

namespace Acumatica.Default_26_200_001.Model
{
	public class ChangeOrderContact : Entity
	{

		#region Fields
		public StringValue? AccountName { get; set; }

		public StringValue? Attention { get; set; }

		public StringValue? Email { get; set; }

		public BooleanValue? OverrideContact { get; set; }

		public StringValue? Phone1 { get; set; }

		public StringValue? Phone1Type { get; set; }

		public StringValue? Phone2 { get; set; }

		public StringValue? Phone2Type { get; set; }

		#endregion

	}
}