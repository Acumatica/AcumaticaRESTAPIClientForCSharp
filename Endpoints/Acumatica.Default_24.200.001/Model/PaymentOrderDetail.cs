using System;
using System.Collections.Generic;

using Newtonsoft.Json;

using Acumatica.RESTClient.Client;
using Acumatica.RESTClient.ContractBasedApi;
using Acumatica.RESTClient.ContractBasedApi.Model;

namespace Acumatica.Default_24_200_001.Model
{
	public class PaymentOrderDetail : Entity
	{

		/// <summary>
		/// <para>DAC Field Name: CuryAdjgAmt</para>
		/// <para>DAC: PX.Objects.AR.ARAdjust</para>
		/// <para>Display Name: Amount Paid in Payment Currency</para>
		/// </summary>
		public DecimalValue? AppliedToOrder { get; set; }

		/// <summary>
		/// <para>DAC Field Name: AdjdOrderNbr</para>
		/// <para>DAC: PX.Objects.SO.SOAdjust</para>
		/// <para>Display Name: Order Nbr.</para>
		/// <para>SQL Type: nvarchar(15)</para>
		/// Key Field
		/// </summary>
		public StringValue? OrderNbr { get; set; }

		/// <summary>
		/// <para>DAC Field Name: AdjdOrderType</para>
		/// <para>DAC: PX.Objects.SO.SOAdjust</para>
		/// <para>Display Name: Order Type</para>
		/// <para>SQL Type: char(2)</para>
		/// Key Field
		/// </summary>
		public StringValue? OrderType { get; set; }

	}
}