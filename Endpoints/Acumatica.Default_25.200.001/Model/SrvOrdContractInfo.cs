using System;
using System.Collections.Generic;

using Newtonsoft.Json;

using Acumatica.RESTClient.Client;
using Acumatica.RESTClient.ContractBasedApi;
using Acumatica.RESTClient.ContractBasedApi.Model;

namespace Acumatica.Default_25_200_001.Model
{
	public class SrvOrdContractInfo : Entity
	{

		/// <summary>
		/// <para>DAC Field Name: BillContractPeriodID</para>
		/// <para>DAC: PX.Objects.FS.FSServiceOrder</para>
		/// <para>Display Name: Contract Period</para>
		/// </summary>
		public StringValue? ContractPeriod { get; set; }

		/// <summary>
		/// <para>DAC Field Name: BillServiceContractID</para>
		/// <para>DAC: PX.Objects.FS.FSServiceOrder</para>
		/// <para>Display Name: Service Contract</para>
		/// </summary>
		public StringValue? ServiceContract { get; set; }

	}
}