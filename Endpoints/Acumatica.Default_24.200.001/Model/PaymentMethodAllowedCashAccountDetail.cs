using System;
using System.Collections.Generic;

using Newtonsoft.Json;

using Acumatica.RESTClient.Client;
using Acumatica.RESTClient.ContractBasedApi;
using Acumatica.RESTClient.ContractBasedApi.Model;

namespace Acumatica.Default_24_200_001.Model
{
	public class PaymentMethodAllowedCashAccountDetail : Entity
	{

		/// <summary>
		/// <para>DAC Field Name: APIsDefault</para>
		/// <para>DAC: PX.Objects.CA.PaymentMethodAccount</para>
		/// <para>Display Name: AP Default</para>
		/// </summary>
		public BooleanValue? APDefault { get; set; }

		/// <summary>
		/// <para>DAC: PX.Objects.CA.PaymentMethodAccount</para>
		/// <para>Display Name: AP Last Reference Number</para>
		/// <para>SQL Type: nvarchar(40)</para>
		/// </summary>
		public StringValue? APLastRefNbr { get; set; }

		/// <summary>
		/// <para>DAC Field Name: APAutoNextNbr</para>
		/// <para>DAC: PX.Objects.CA.PaymentMethodAccount</para>
		/// <para>Display Name: AP - Suggest Next Number</para>
		/// </summary>
		public BooleanValue? APSuggestNextNbr { get; set; }

		/// <summary>
		/// <para>DAC Field Name: ARIsDefault</para>
		/// <para>DAC: PX.Objects.CA.PaymentMethodAccount</para>
		/// <para>Display Name: AR Default</para>
		/// </summary>
		public BooleanValue? ARDefault { get; set; }

		/// <summary>
		/// <para>DAC Field Name: ARIsDefaultForRefund</para>
		/// <para>DAC: PX.Objects.CA.PaymentMethodAccount</para>
		/// <para>Display Name: AR Default For Refund</para>
		/// </summary>
		public BooleanValue? ARDefaultForRefund { get; set; }

		/// <summary>
		/// <para>DAC: PX.Objects.CA.PaymentMethodAccount</para>
		/// <para>Display Name: AR Last Reference Number</para>
		/// <para>SQL Type: nvarchar(40)</para>
		/// </summary>
		public StringValue? ARLastRefNbr { get; set; }

		/// <summary>
		/// <para>DAC Field Name: ARAutoNextNbr</para>
		/// <para>DAC: PX.Objects.CA.PaymentMethodAccount</para>
		/// <para>Display Name: AR - Suggest Next Number</para>
		/// </summary>
		public BooleanValue? ARSuggestNextNbr { get; set; }

		/// <summary>
		/// <para>DAC Field Name: APBatchLastRefNbr</para>
		/// <para>DAC: PX.Objects.CA.PaymentMethodAccount</para>
		/// <para>Display Name: Batch Last Reference Number</para>
		/// <para>SQL Type: nvarchar(15)</para>
		/// </summary>
		public StringValue? BatchLastRefNbr { get; set; }

		/// <summary>
		/// <para>DAC Field Name: CashAccount__BranchID</para>
		/// <para>DAC: PX.Objects.CA.PaymentMethodAccount</para>
		/// </summary>
		public StringValue? Branch { get; set; }

		/// <summary>
		/// <para>DAC Field Name: CashAccountID</para>
		/// <para>DAC: PX.Objects.CA.PaymentMethodAccount</para>
		/// <para>Display Name: Cash Account</para>
		/// Key Field
		/// </summary>
		public StringValue? CashAccount { get; set; }

		/// <summary>
		/// <para>DAC Field Name: CashAccountID_CashAccount_Descr</para>
		/// <para>DAC: PX.Objects.CA.PaymentMethodAccount</para>
		/// </summary>
		public StringValue? Description { get; set; }

		/// <summary>
		/// <para>DAC Field Name: PaymentMethodID</para>
		/// <para>DAC: PX.Objects.CA.PaymentMethod</para>
		/// <para>Display Name:  Payment Method ID</para>
		/// <para>SQL Type: nvarchar(10)</para>
		/// Key Field
		/// </summary>
		public StringValue? PaymentMethod { get; set; }

		/// <summary>
		/// <para>DAC Field Name: UseForAP</para>
		/// <para>DAC: PX.Objects.CA.PaymentMethod</para>
		/// <para>Display Name: Use in AP</para>
		/// </summary>
		public BooleanValue? UseInAP { get; set; }

		/// <summary>
		/// <para>DAC Field Name: UseForAR</para>
		/// <para>DAC: PX.Objects.CA.PaymentMethod</para>
		/// <para>Display Name: Use in AR</para>
		/// </summary>
		public BooleanValue? UseInAR { get; set; }

		public DateTimeValue? LastModifiedDateTime { get; set; }

		/// <summary>
		/// <para>DAC Field Name: UseForPR</para>
		/// <para>DAC: PX.Objects.CA.PaymentMethod</para>
		/// <para>Display Name: Use in PR</para>
		/// </summary>
		public BooleanValue? UseInPR { get; set; }

	}
}