using System;
using System.Collections.Generic;

using Newtonsoft.Json;

using Acumatica.RESTClient.Client;
using Acumatica.RESTClient.ContractBasedApi;
using Acumatica.RESTClient.ContractBasedApi.Model;

namespace Acumatica.Default_24_200_001.Model
{
	public class CreditCardTransactionDetail : Entity
	{

		/// <summary>
		/// <para>DAC Field Name: PCTranNumber</para>
		/// <para>DAC: PX.Objects.AR.CCProcTran</para>
		/// <para>Display Name: Proc. Center Tran. Nbr.</para>
		/// <para>SQL Type: nvarchar(50)</para>
		/// </summary>
		public StringValue? TranNbr { get; set; }

		public StringValue? TranApiNbr { get; set; }

		/// <summary>
		/// <para>DAC: PX.Objects.AR.CCProcTran</para>
		/// <para>Display Name: Tran. Type</para>
		/// <para>SQL Type: char(3)</para>
		/// </summary>
		public StringValue? TranType { get; set; }

		/// <summary>
		/// <para>DAC Field Name: AuthNumber</para>
		/// <para>DAC: PX.Objects.AR.CCProcTran</para>
		/// <para>Display Name: Proc. Center Auth. Nbr.</para>
		/// <para>SQL Type: nvarchar(50)</para>
		/// </summary>
		public StringValue? AuthNbr { get; set; }

		public DateTimeValue? TranDate { get; set; }

		public StringValue? ExtProfileId { get; set; }

		public BooleanValue? NeedValidation { get; set; }

		public StringValue? OrigTranNbr { get; set; }

		public DateTimeValue? ExpirationDate { get; set; }

		public StringValue? CardType { get; set; }

	}
}