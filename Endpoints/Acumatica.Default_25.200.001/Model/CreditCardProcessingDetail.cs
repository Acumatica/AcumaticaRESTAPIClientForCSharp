using System;
using System.Collections.Generic;

using Newtonsoft.Json;

using Acumatica.RESTClient.Client;
using Acumatica.RESTClient.ContractBasedApi;
using Acumatica.RESTClient.ContractBasedApi.Model;

namespace Acumatica.Default_25_200_001.Model
{
	public class CreditCardProcessingDetail : Entity
	{

		/// <summary>
		/// <para>DAC Field Name: Amount</para>
		/// <para>DAC: PX.Objects.AR.CCProcTran</para>
		/// <para>Display Name: Tran. Amount</para>
		/// </summary>
		public DecimalValue? TransactionAmount { get; set; }

		/// <summary>
		/// <para>DAC Field Name: TranStatus</para>
		/// <para>DAC: PX.Objects.AR.CCProcTran</para>
		/// <para>Display Name: Tran. Status</para>
		/// <para>SQL Type: char(3)</para>
		/// </summary>
		public StringValue? TransactionStatus { get; set; }

	}
}