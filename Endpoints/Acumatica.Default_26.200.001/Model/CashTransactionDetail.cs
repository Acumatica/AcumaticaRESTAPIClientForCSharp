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
	public class CashTransactionDetail : Entity
	{

		/// <summary>
		/// The unit price for the item in the selected currency.
		/// <para>DAC Field Name: CuryUnitPrice</para>
		/// <para>DAC: PX.Objects.CA.CASplit</para>
		/// <para>Display Name: Price</para>
		/// </summary>
		[DataMember(Name="Amount", EmitDefaultValue=false)]
		public DecimalValue? Amount { get; set; }

		/// <summary>
		/// The description of the transaction.
		/// <para>DAC Field Name: TranDesc</para>
		/// <para>DAC: PX.Objects.CA.CAAdj</para>
		/// <para>Display Name: Description</para>
		/// <para>SQL Type: nvarchar(512)</para>
		/// </summary>
		[DataMember(Name="AmountDescription", EmitDefaultValue=false)]
		public StringValue? AmountDescription { get; set; }

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