using System;
using System.Collections.Generic;

using Newtonsoft.Json;

using Acumatica.RESTClient.Client;
using Acumatica.RESTClient.ContractBasedApi;
using Acumatica.RESTClient.ContractBasedApi.Model;

namespace Acumatica.Default_24_200_001.Model
{
	/// <summary>
	/// Corresponds to the screen <c>CM202000</c> in the Acumatica ERP
	/// <para>Key Fields: CurrencyID</para>
	/// </summary>
	public class Currency : Entity, ITopLevelEntity
	{

		/// <summary>
		/// <para>DAC Field Name: IsActive</para>
		/// <para>DAC: PX.Objects.CM.CurrencyList</para>
		/// </summary>
		public BooleanValue? Active { get; set; }

		public DateTimeValue? CreatedDateTime { get; set; }

		/// <summary>
		/// <para>DAC Field Name: CuryID</para>
		/// <para>DAC: PX.Objects.CM.CurrencyList</para>
		/// <para>Display Name: Currency ID</para>
		/// <para>SQL Type: nvarchar(5)</para>
		/// Key Field
		/// </summary>
		public StringValue? CurrencyID { get; set; }

		/// <summary>
		/// <para>DAC Field Name: CurySymbol</para>
		/// <para>DAC: PX.Objects.CM.CurrencyList</para>
		/// <para>Display Name: Currency Symbol</para>
		/// <para>SQL Type: nvarchar(10)</para>
		/// </summary>
		public StringValue? CurrencySymbol { get; set; }

		/// <summary>
		/// <para>DAC Field Name: DecimalPlaces</para>
		/// <para>DAC: PX.Objects.CM.CurrencyList</para>
		/// <para>Display Name: Decimal Precision</para>
		/// </summary>
		public ShortValue? DecimalPrecision { get; set; }

		/// <summary>
		/// <para>DAC: PX.Objects.CM.CurrencyList</para>
		/// <para>SQL Type: nvarchar(60)</para>
		/// </summary>
		public StringValue? Description { get; set; }

		public DateTimeValue? LastModifiedDateTime { get; set; }

		/// <summary>
		/// <para>DAC Field Name: IsFinancial</para>
		/// <para>DAC: PX.Objects.CM.CurrencyList</para>
		/// <para>Display Name: Use for Accounting</para>
		/// </summary>
		public BooleanValue? UseForAccounting { get; set; }

		public static class Expand
		{
			public const string Files = "Files";
			public const string Translations = "Translations";

			//Intentionally excluded
			//public const string All = "Files,Translations";
		}
		public virtual string GetEndpointPath()
		{
			return "entity/Default/24.200.001";
		}
	}
}