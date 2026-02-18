using System;
using System.Collections.Generic;

using Newtonsoft.Json;

using Acumatica.RESTClient.Client;
using Acumatica.RESTClient.ContractBasedApi;
using Acumatica.RESTClient.ContractBasedApi.Model;

namespace Acumatica.Default_24_200_001.Model
{
	public class CashTransactionDetail : Entity
	{

		/// <summary>
		/// The unit price for the item in the selected currency.
		/// <para>DAC Field Name: CuryUnitPrice</para>
		/// <para>DAC: PX.Objects.CA.CASplit</para>
		/// <para>Display Name: Price</para>
		/// </summary>
		public DecimalValue? Amount { get; set; }

		/// <summary>
		/// The description of the transaction.
		/// <para>DAC Field Name: TranDesc</para>
		/// <para>DAC: PX.Objects.CA.CAAdj</para>
		/// <para>Display Name: Description</para>
		/// <para>SQL Type: nvarchar(512)</para>
		/// </summary>
		public StringValue? AmountDescription { get; set; }

	}
}