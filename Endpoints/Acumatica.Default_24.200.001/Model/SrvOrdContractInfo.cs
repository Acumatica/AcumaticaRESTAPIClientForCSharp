using System;
using System.Collections.Generic;
using System.Runtime.Serialization;

using Newtonsoft.Json;

using Acumatica.RESTClient.Client;
using Acumatica.RESTClient.ContractBasedApi;
using Acumatica.RESTClient.ContractBasedApi.Model;

namespace Acumatica.Default_24_200_001.Model
{
	[DataContract]
	public class SrvOrdContractInfo : Entity
	{

		/// <summary>
		/// <para>DAC Field Name: BillContractPeriodID</para>
		/// <para>DAC: PX.Objects.FS.FSServiceOrder</para>
		/// <para>Display Name: Contract Period</para>
		/// </summary>
		[DataMember(Name="ContractPeriod", EmitDefaultValue=false)]
		public StringValue? ContractPeriod { get; set; }

		/// <summary>
		/// <para>DAC Field Name: BillServiceContractID</para>
		/// <para>DAC: PX.Objects.FS.FSServiceOrder</para>
		/// <para>Display Name: Service Contract</para>
		/// </summary>
		[DataMember(Name="ServiceContract", EmitDefaultValue=false)]
		public StringValue? ServiceContract { get; set; }

	}
}