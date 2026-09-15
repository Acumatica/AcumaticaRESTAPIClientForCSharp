using System;
using System.Collections.Generic;
using System.Runtime.Serialization;

using Newtonsoft.Json;

using Acumatica.RESTClient.Client;
using Acumatica.RESTClient.ContractBasedApi;
using Acumatica.RESTClient.ContractBasedApi.Model;

namespace Acumatica.Default_26_200_001.Model
{
	[DataContract]
	public class ShippingTermDetail : Entity
	{

		/// <summary>
		/// <para>DAC: PX.Objects.CS.ShipTermsDetail</para>
		/// <para>Display Name: Break Amount</para>
		/// </summary>
		[DataMember(Name="BreakAmount", EmitDefaultValue=false)]
		public DecimalValue? BreakAmount { get; set; }

		/// <summary>
		/// <para>DAC Field Name: FreightCostPercent</para>
		/// <para>DAC: PX.Objects.CS.ShipTermsDetail</para>
		/// <para>Display Name: Freight Cost %</para>
		/// </summary>
		[DataMember(Name="FreightCost", EmitDefaultValue=false)]
		public DecimalValue? FreightCost { get; set; }

		/// <summary>
		/// <para>DAC Field Name: InvoiceAmountPercent</para>
		/// <para>DAC: PX.Objects.CS.ShipTermsDetail</para>
		/// <para>Display Name: Invoice Amount %</para>
		/// </summary>
		[DataMember(Name="InvoiceAmount", EmitDefaultValue=false)]
		public DecimalValue? InvoiceAmount { get; set; }

		/// <summary>
		/// <para>DAC: PX.Objects.CS.ShipTermsDetail</para>
		/// <para>Display Name: Line Handling</para>
		/// </summary>
		[DataMember(Name="LineHandling", EmitDefaultValue=false)]
		public DecimalValue? LineHandling { get; set; }

		[DataMember(Name="LineNbr", EmitDefaultValue=false)]
		public IntValue? LineNbr { get; set; }

		/// <summary>
		/// <para>DAC Field Name: ShippingHandling</para>
		/// <para>DAC: PX.Objects.CS.ShipTermsDetail</para>
		/// <para>Display Name: Shipping and Handling</para>
		/// </summary>
		[DataMember(Name="ShippingandHandling", EmitDefaultValue=false)]
		public DecimalValue? ShippingandHandling { get; set; }

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