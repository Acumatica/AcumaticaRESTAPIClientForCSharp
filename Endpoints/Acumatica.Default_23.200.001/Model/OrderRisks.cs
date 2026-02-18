using System;
using System.Collections.Generic;

using Newtonsoft.Json;

using Acumatica.RESTClient.Client;
using Acumatica.RESTClient.ContractBasedApi;
using Acumatica.RESTClient.ContractBasedApi.Model;

namespace Acumatica.Default_23_200_001.Model
{
	public class OrderRisks : Entity
	{

		/// <summary>
		/// <para>DAC: {}</para>
		/// </summary>
		public StringValue? Message { get; set; }

		/// <summary>
		/// <para>DAC: {}</para>
		/// </summary>
		public StringValue? Recommendation { get; set; }

		/// <summary>
		/// <para>DAC: {}</para>
		/// </summary>
		public DecimalValue? Score { get; set; }

	}
}