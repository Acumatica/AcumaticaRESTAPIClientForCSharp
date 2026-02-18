using System;
using System.Collections.Generic;

using Newtonsoft.Json;

using Acumatica.RESTClient.Client;
using Acumatica.RESTClient.ContractBasedApi;
using Acumatica.RESTClient.ContractBasedApi.Model;

namespace Acumatica.Default_24_200_001.Model
{
	public class ShippingTermDetail : Entity
	{

		/// <summary>
		/// <para>DAC: PX.Objects.CS.ShipTermsDetail</para>
		/// <para>Display Name: Break Amount</para>
		/// </summary>
		public DecimalValue? BreakAmount { get; set; }

		/// <summary>
		/// <para>DAC Field Name: FreightCostPercent</para>
		/// <para>DAC: PX.Objects.CS.ShipTermsDetail</para>
		/// <para>Display Name: Freight Cost %</para>
		/// </summary>
		public DecimalValue? FreightCost { get; set; }

		/// <summary>
		/// <para>DAC Field Name: InvoiceAmountPercent</para>
		/// <para>DAC: PX.Objects.CS.ShipTermsDetail</para>
		/// <para>Display Name: Invoice Amount %</para>
		/// </summary>
		public DecimalValue? InvoiceAmount { get; set; }

		/// <summary>
		/// <para>DAC: PX.Objects.CS.ShipTermsDetail</para>
		/// <para>Display Name: Line Handling</para>
		/// </summary>
		public DecimalValue? LineHandling { get; set; }

		public IntValue? LineNbr { get; set; }

		/// <summary>
		/// <para>DAC Field Name: ShippingHandling</para>
		/// <para>DAC: PX.Objects.CS.ShipTermsDetail</para>
		/// <para>Display Name: Shipping and Handling</para>
		/// </summary>
		public DecimalValue? ShippingandHandling { get; set; }

	}
}