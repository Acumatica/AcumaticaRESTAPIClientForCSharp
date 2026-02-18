using System;
using System.Collections.Generic;

using Newtonsoft.Json;

using Acumatica.RESTClient.Client;
using Acumatica.RESTClient.ContractBasedApi;
using Acumatica.RESTClient.ContractBasedApi.Model;

namespace Acumatica.Default_23_200_001.Model
{
	public class CarrierPluginParameter : Entity
	{

		/// <summary>
		/// <para>DAC Field Name: Descr</para>
		/// <para>DAC: PX.Objects.CS.CarrierPluginDetail</para>
		/// <para>SQL Type: nvarchar(255)</para>
		/// </summary>
		public StringValue? Description { get; set; }

		/// <summary>
		/// <para>DAC Field Name: DetailID</para>
		/// <para>DAC: PX.Objects.CS.CarrierPluginDetail</para>
		/// <para>Display Name: ID</para>
		/// <para>SQL Type: nvarchar(30)</para>
		/// Key Field
		/// </summary>
		public StringValue? PluginID { get; set; }

		/// <summary>
		/// <para>DAC: PX.Objects.CS.CarrierPluginDetail</para>
		/// <para>SQL Type: nvarchar(1024)</para>
		/// </summary>
		public StringValue? Value { get; set; }

	}
}