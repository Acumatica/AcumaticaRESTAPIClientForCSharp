using System;
using System.Collections.Generic;

using Newtonsoft.Json;

using Acumatica.RESTClient.Client;
using Acumatica.RESTClient.ContractBasedApi;
using Acumatica.RESTClient.ContractBasedApi.Model;

namespace Acumatica.Default_25_200_001.Model
{
	public class SrvOrdPrepayments : Entity
	{

		/// <summary>
		/// <para>DAC Field Name: AdjDate</para>
		/// <para>DAC: PX.Objects.AR.ARPayment</para>
		/// <para>Display Name: Application Date</para>
		/// </summary>
		public DateTimeValue? ApplicationDate { get; set; }

		/// <summary>
		/// <para>DAC Field Name: CurySOApplAmt</para>
		/// <para>DAC: PX.Objects.AR.ARPayment</para>
		/// <para>Display Name: Applied to Orders</para>
		/// </summary>
		public DecimalValue? AppliedtoOrders { get; set; }

		/// <summary>
		/// <para>DAC Field Name: CuryUnappliedBal</para>
		/// <para>DAC: PX.Objects.AR.ARPayment</para>
		/// <para>Display Name: Available Balance</para>
		/// </summary>
		public DecimalValue? AvailableBalance { get; set; }

		/// <summary>
		/// <para>DAC Field Name: CashAccountID</para>
		/// <para>DAC: PX.Objects.AR.ARPayment</para>
		/// <para>Display Name: Cash Account</para>
		/// </summary>
		public IntValue? CashAccount { get; set; }

		/// <summary>
		/// <para>DAC Field Name: CuryID</para>
		/// <para>DAC: PX.Objects.FS.FSServiceOrder</para>
		/// <para>SQL Type: nvarchar(5)</para>
		/// </summary>
		public StringValue? Currency { get; set; }

		/// <summary>
		/// <para>DAC Field Name: CuryOrigDocAmt</para>
		/// <para>DAC: PX.Objects.AR.ARPayment</para>
		/// <para>Display Name: Payment Amount</para>
		/// </summary>
		public DecimalValue? PaymentAmount { get; set; }

		/// <summary>
		/// <para>DAC Field Name: PaymentMethodID</para>
		/// <para>DAC: PX.Objects.AR.ARPayment</para>
		/// <para>Display Name: Payment Method</para>
		/// <para>SQL Type: nvarchar(10)</para>
		/// </summary>
		public StringValue? PaymentMethod { get; set; }

		/// <summary>
		/// <para>DAC Field Name: ExtRefNbr</para>
		/// <para>DAC: PX.Objects.AR.ARPayment</para>
		/// <para>Display Name: Payment Ref.</para>
		/// <para>SQL Type: nvarchar(40)</para>
		/// </summary>
		public StringValue? PaymentRef { get; set; }

		/// <summary>
		/// <para>DAC Field Name: RefNbr</para>
		/// <para>DAC: PX.Objects.FS.FSServiceOrder</para>
		/// <para>Display Name: Order Nbr.</para>
		/// <para>SQL Type: nvarchar(15)</para>
		/// Key Field
		/// </summary>
		public StringValue? ReferenceNbr { get; set; }

		/// <summary>
		/// <para>DAC Field Name: FSAdjust__AdjdAppRefNbr</para>
		/// <para>DAC: PX.Objects.AR.ARPayment</para>
		/// </summary>
		public StringValue? SourceAppointmentNbr { get; set; }

		/// <summary>
		/// <para>DAC: PX.Objects.FS.FSServiceOrder</para>
		/// <para>SQL Type: char(1)</para>
		/// </summary>
		public StringValue? Status { get; set; }

		/// <summary>
		/// <para>DAC Field Name: DocType</para>
		/// <para>DAC: PX.Objects.AR.ARPayment</para>
		/// <para>SQL Type: char(3)</para>
		/// Key Field
		/// </summary>
		public StringValue? Type { get; set; }

	}
}