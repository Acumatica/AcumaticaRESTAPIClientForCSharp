using System;
using System.Collections.Generic;

using Newtonsoft.Json;

using Acumatica.RESTClient.Client;
using Acumatica.RESTClient.ContractBasedApi;
using Acumatica.RESTClient.ContractBasedApi.Model;

namespace Acumatica.ISVCB_21_200_001.Model
{
	public class RepositoryLines : Entity
	{

		public StringValue? AcumaticaBuild { get; set; }

		public BooleanValue? Certified { get; set; }

		public StringValue? ISVVersion { get; set; }

		public StringValue? ClientApplication { get; set; }

		public StringValue? CustomizationProject { get; set; }

		public StringValue? Documentation { get; set; }

		public BooleanValue? IsStatusISVApproved { get; set; }

		public BooleanValue? IsStatusPassed { get; set; }

		public BooleanValue? IsStatusSubmitted { get; set; }

		public StringValue? PortalCustomization { get; set; }

		public StringValue? Issues { get; set; }

		public StringValue? Status { get; set; }

		public StringValue? TestFiles { get; set; }

	}
}