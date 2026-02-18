using System;
using System.Collections.Generic;

using Newtonsoft.Json;

using Acumatica.RESTClient.Client;
using Acumatica.RESTClient.ContractBasedApi;
using Acumatica.RESTClient.ContractBasedApi.Model;

namespace Acumatica.Default_24_200_001.Model
{
	public class ProjectEquipment : Entity
	{

		public BooleanValue? Active { get; set; }

		public StringValue? Description { get; set; }

		public StringValue? EquipmentID { get; set; }

		public DecimalValue? RunRate { get; set; }

		public StringValue? RunRateItem { get; set; }

		public DecimalValue? SetupRate { get; set; }

		public StringValue? SetupRateItem { get; set; }

		public DecimalValue? SuspendRate { get; set; }

		public StringValue? SuspendRateItem { get; set; }

	}
}