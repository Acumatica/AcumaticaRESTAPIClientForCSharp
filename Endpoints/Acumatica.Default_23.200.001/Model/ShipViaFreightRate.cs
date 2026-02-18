using System;
using System.Collections.Generic;

using Newtonsoft.Json;

using Acumatica.RESTClient.Client;
using Acumatica.RESTClient.ContractBasedApi;
using Acumatica.RESTClient.ContractBasedApi.Model;

namespace Acumatica.Default_23_200_001.Model
{
	public class ShipViaFreightRate : Entity
	{

		public IntValue? LineNbr { get; set; }

		/// <summary>
		/// <para>DAC: PX.Objects.CS.FreightRate</para>
		/// </summary>
		public DecimalValue? Rate { get; set; }

		/// <summary>
		/// <para>DAC: PX.Objects.CS.FreightRate</para>
		/// </summary>
		public DecimalValue? Volume { get; set; }

		/// <summary>
		/// <para>DAC: PX.Objects.CS.FreightRate</para>
		/// </summary>
		public DecimalValue? Weight { get; set; }

		/// <summary>
		/// <para>DAC: PX.Objects.CS.FreightRate</para>
		/// <para>Display Name: Zone ID</para>
		/// <para>SQL Type: nvarchar(15)</para>
		/// </summary>
		public StringValue? ZoneID { get; set; }

	}
}