using System;
using System.Collections.Generic;

using Newtonsoft.Json;

using Acumatica.RESTClient.Client;
using Acumatica.RESTClient.ContractBasedApi;
using Acumatica.RESTClient.ContractBasedApi.Model;

namespace Acumatica.Manufacturing_24_200_001.Model
{
	public class OrderStepDetail : Entity
	{

		public StringValue? Description { get; set; }

		public IntValue? LineID { get; set; }

		public IntValue? LineOrder { get; set; }

		public StringValue? PhantomBomID { get; set; }

		public IntValue? PhantomBOMLineID { get; set; }

		public StringValue? PhantomBOMOperNbr { get; set; }

		public StringValue? PhantomBOMRevision { get; set; }

		public IntValue? PhantomLevel { get; set; }

		public StringValue? PhantomMatlBOMID { get; set; }

		public IntValue? PhantomMatlLineID { get; set; }

		public StringValue? PhantomMatlOperNbr { get; set; }

		public StringValue? PhantomMatlRevision { get; set; }

	}
}