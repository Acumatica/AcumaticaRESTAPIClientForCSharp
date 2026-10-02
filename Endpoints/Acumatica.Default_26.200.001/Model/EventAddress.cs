using System;
using System.Collections.Generic;

using Newtonsoft.Json;

using Acumatica.RESTClient.Client;
using Acumatica.RESTClient.ContractBasedApi;
using Acumatica.RESTClient.ContractBasedApi.Model;

namespace Acumatica.Default_26_200_001.Model
{
	public class EventAddress : Entity
	{

		#region Fields
		public StringValue? AddressLine1 { get; set; }

		public StringValue? AddressLine2 { get; set; }

		public StringValue? AddressLine3 { get; set; }

		public StringValue? City { get; set; }

		public StringValue? Country { get; set; }

		public DecimalValue? Latitude { get; set; }

		public DecimalValue? Longitude { get; set; }

		public BooleanValue? OverrideAddress { get; set; }

		public StringValue? PostalCode { get; set; }

		public StringValue? State { get; set; }

		public BooleanValue? Validated { get; set; }

		#endregion

	}
}