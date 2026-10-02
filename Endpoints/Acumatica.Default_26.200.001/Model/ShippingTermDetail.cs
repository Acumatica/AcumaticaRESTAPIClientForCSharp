using System;
using System.Collections.Generic;

using Newtonsoft.Json;

using Acumatica.RESTClient.Client;
using Acumatica.RESTClient.ContractBasedApi;
using Acumatica.RESTClient.ContractBasedApi.Model;

namespace Acumatica.Default_26_200_001.Model
{
	public class ShippingTermDetail : Entity
	{

		#region Fields
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
		/// <para>DAC Field Name: ShippingHandling</para>
		/// <para>DAC: PX.Objects.CS.ShipTermsDetail</para>
		/// <para>Display Name: Shipping and Handling</para>
		/// </summary>
		public DecimalValue? ShippingandHandling { get; set; }

		/// <summary>
		/// <para>DAC: PX.Objects.CS.ShipTermsDetail</para>
		/// <para>Display Name: Line Handling</para>
		/// </summary>
		public DecimalValue? LineHandling { get; set; }

		public IntValue? LineNbr { get; set; }

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