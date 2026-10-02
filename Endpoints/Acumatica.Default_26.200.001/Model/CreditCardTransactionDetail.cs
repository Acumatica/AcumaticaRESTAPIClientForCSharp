using System;
using System.Collections.Generic;

using Newtonsoft.Json;

using Acumatica.RESTClient.Client;
using Acumatica.RESTClient.ContractBasedApi;
using Acumatica.RESTClient.ContractBasedApi.Model;

namespace Acumatica.Default_26_200_001.Model
{
	public class CreditCardTransactionDetail : Entity
	{

		#region Fields
		/// <summary>
		/// <para>DAC: PX.Objects.AR.CCProcTran</para>
		/// <para>Display Name: Tran. Type</para>
		/// <para>SQL Type: char(3)</para>
		/// </summary>
		public StringValue? TranType { get; set; }

		/// <summary>
		/// <para>DAC Field Name: PCTranNumber</para>
		/// <para>DAC: PX.Objects.AR.CCProcTran</para>
		/// <para>Display Name: Proc. Center Tran. Nbr.</para>
		/// <para>SQL Type: nvarchar(50)</para>
		/// </summary>
		public StringValue? TranNbr { get; set; }

		/// <summary>
		/// <para>DAC Field Name: AuthNumber</para>
		/// <para>DAC: PX.Objects.AR.CCProcTran</para>
		/// <para>Display Name: Proc. Center Auth. Nbr.</para>
		/// <para>SQL Type: nvarchar(50)</para>
		/// </summary>
		public StringValue? AuthNbr { get; set; }

		public StringValue? TranApiNbr { get; set; }

		public StringValue? CommerceTranNbr { get; set; }

		public DateTimeValue? TranDate { get; set; }

		public StringValue? ExtProfileId { get; set; }

		public BooleanValue? NeedValidation { get; set; }

		public StringValue? OrigTranNbr { get; set; }

		public DateTimeValue? ExpirationDate { get; set; }

		public StringValue? CardType { get; set; }

		#endregion

		/// <summary>
		/// Names that can be passed in the <c>$expand</c> parameter.
		/// <para>This endpoint uses system contract 5, where a nested entity is expanded
		/// as <c>Parent($expand=Child)</c> rather than <c>Parent/Child</c>, so only the names
		/// that can be expanded directly on this entity are listed here. Use the nested
		/// entity's own <c>Expand</c> class for the inner names.</para>
		/// </summary>
		public static class Expand
		{
			public const string Files = "Files";

			//Intentionally excluded
			//public const string All = "Files";
		}
	}
}