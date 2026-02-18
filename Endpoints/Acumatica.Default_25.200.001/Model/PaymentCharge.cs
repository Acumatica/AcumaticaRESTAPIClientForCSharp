using System;
using System.Collections.Generic;

using Newtonsoft.Json;

using Acumatica.RESTClient.Client;
using Acumatica.RESTClient.ContractBasedApi;
using Acumatica.RESTClient.ContractBasedApi.Model;

namespace Acumatica.Default_25_200_001.Model
{
	public class PaymentCharge : Entity
	{

		public StringValue? AccountID { get; set; }

		/// <summary>
		/// <para>DAC Field Name: CuryTranAmt</para>
		/// <para>DAC: PX.Objects.AR.ARPaymentChargeTran</para>
		/// </summary>
		public DecimalValue? Amount { get; set; }

		/// <summary>
		/// <para>DAC Field Name: TranDesc</para>
		/// <para>DAC: PX.Objects.AR.ARPaymentChargeTran</para>
		/// <para>SQL Type: nvarchar(256)</para>
		/// </summary>
		public StringValue? Description { get; set; }

		/// <summary>
		/// <para>DAC: PX.Objects.AR.ARPayment</para>
		/// <para>Display Name: Type</para>
		/// <para>SQL Type: char(3)</para>
		/// Key Field
		/// </summary>
		public StringValue? DocType { get; set; }

		/// <summary>
		/// <para>DAC: PX.Objects.AR.ARPaymentChargeTran</para>
		/// <para>Display Name: Entry Type</para>
		/// <para>SQL Type: nvarchar(10)</para>
		/// </summary>
		public StringValue? EntryTypeID { get; set; }

		/// <summary>
		/// <para>DAC: PX.Objects.AR.ARTranPostBal</para>
		/// <para>Display Name: Line Nbr.</para>
		/// </summary>
		public IntValue? LineNbr { get; set; }

		/// <summary>
		/// <para>DAC: PX.Objects.AR.ARPayment</para>
		/// <para>Display Name: Reference Nbr.</para>
		/// <para>SQL Type: nvarchar(15)</para>
		/// Key Field
		/// </summary>
		public StringValue? RefNbr { get; set; }

		public StringValue? SubID { get; set; }

	}
}