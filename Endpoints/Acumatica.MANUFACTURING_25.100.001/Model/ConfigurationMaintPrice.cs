using System;
using System.Collections.Generic;

using Newtonsoft.Json;

using Acumatica.RESTClient.Client;
using Acumatica.RESTClient.ContractBasedApi;
using Acumatica.RESTClient.ContractBasedApi.Model;

namespace Acumatica.MANUFACTURING_25_100_001.Model
{
	public class ConfigurationMaintPrice : Entity
	{

		/// <summary>
		/// <para>DAC Field Name: PriceCalc</para>
		/// <para>DAC: PX.Objects.AM.AMConfiguration</para>
		/// <para>SQL Type: char(1)</para>
		/// </summary>
		public StringValue? Calculate { get; set; }

		/// <summary>
		/// <para>DAC Field Name: PriceRollup</para>
		/// <para>DAC: PX.Objects.AM.AMConfiguration</para>
		/// <para>SQL Type: char(2)</para>
		/// </summary>
		public StringValue? Rollup { get; set; }

	}
}