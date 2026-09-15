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
	public class PaymentOrderDetail : Entity
	{

		/// <summary>
		/// <para>DAC Field Name: CuryAdjgAmt</para>
		/// <para>DAC: PX.Objects.AR.ARAdjust</para>
		/// <para>Display Name: Amount Paid in Payment Currency</para>
		/// </summary>
		[DataMember(Name="AppliedToOrder", EmitDefaultValue=false)]
		public DecimalValue? AppliedToOrder { get; set; }

		/// <summary>
		/// <para>DAC Field Name: AdjdOrderNbr</para>
		/// <para>DAC: PX.Objects.SO.SOAdjust</para>
		/// <para>Display Name: Order Nbr.</para>
		/// <para>SQL Type: nvarchar(15)</para>
		/// Key Field
		/// </summary>
		[DataMember(Name="OrderNbr", EmitDefaultValue=false)]
		public StringValue? OrderNbr { get; set; }

		/// <summary>
		/// <para>DAC Field Name: AdjdOrderType</para>
		/// <para>DAC: PX.Objects.SO.SOAdjust</para>
		/// <para>Display Name: Order Type</para>
		/// <para>SQL Type: char(2)</para>
		/// Key Field
		/// </summary>
		[DataMember(Name="OrderType", EmitDefaultValue=false)]
		public StringValue? OrderType { get; set; }

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