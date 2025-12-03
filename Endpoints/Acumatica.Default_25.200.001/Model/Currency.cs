using System;
using System.Collections.Generic;
using System.Runtime.Serialization;

using Newtonsoft.Json;

using Acumatica.RESTClient.Client;
using Acumatica.RESTClient.ContractBasedApi;
using Acumatica.RESTClient.ContractBasedApi.Model;

namespace Acumatica.Default_25_200_001.Model
{
	/// <summary>
	/// Corresponds to the screen <c>CM202000</c> in the Acumatica ERP
	/// <para>Key Fields: CurrencyID</para>
	/// </summary>
	[DataContract]
	public class Currency : Entity, ITopLevelEntity
	{

		/// <summary>
		/// <para>DAC Field Name: IsActive</para>
		/// <para>DAC: PX.Objects.CM.CurrencyList</para>
		/// </summary>
		[DataMember(Name="Active", EmitDefaultValue=false)]
		public BooleanValue? Active { get; set; }

		[DataMember(Name="CreatedDateTime", EmitDefaultValue=false)]
		public DateTimeValue? CreatedDateTime { get; set; }

		/// <summary>
		/// <para>DAC Field Name: CuryID</para>
		/// <para>DAC: PX.Objects.CM.CurrencyList</para>
		/// <para>Display Name: Currency ID</para>
		/// <para>SQL Type: nvarchar(5)</para>
		/// Key Field
		/// </summary>
		[DataMember(Name="CurrencyID", EmitDefaultValue=false)]
		public StringValue? CurrencyID { get; set; }

		/// <summary>
		/// <para>DAC Field Name: CurySymbol</para>
		/// <para>DAC: PX.Objects.CM.CurrencyList</para>
		/// <para>Display Name: Currency Symbol</para>
		/// <para>SQL Type: nvarchar(10)</para>
		/// </summary>
		[DataMember(Name="CurrencySymbol", EmitDefaultValue=false)]
		public StringValue? CurrencySymbol { get; set; }

		/// <summary>
		/// <para>DAC Field Name: DecimalPlaces</para>
		/// <para>DAC: PX.Objects.CM.CurrencyList</para>
		/// <para>Display Name: Decimal Precision</para>
		/// </summary>
		[DataMember(Name="DecimalPrecision", EmitDefaultValue=false)]
		public ShortValue? DecimalPrecision { get; set; }

		/// <summary>
		/// <para>DAC: PX.Objects.CM.CurrencyList</para>
		/// <para>SQL Type: nvarchar(60)</para>
		/// </summary>
		[DataMember(Name="Description", EmitDefaultValue=false)]
		public StringValue? Description { get; set; }

		[DataMember(Name="LastModifiedDateTime", EmitDefaultValue=false)]
		public DateTimeValue? LastModifiedDateTime { get; set; }

		/// <summary>
		/// <para>DAC Field Name: IsFinancial</para>
		/// <para>DAC: PX.Objects.CM.CurrencyList</para>
		/// <para>Display Name: Use for Accounting</para>
		/// </summary>
		[DataMember(Name="UseForAccounting", EmitDefaultValue=false)]
		public BooleanValue? UseForAccounting { get; set; }

		public static class Expand
		{
			public const string Files = "Files";

			//Intentionally excluded
			//public const string All = "Files";
		}
		public virtual string GetEndpointPath()
		{
			return "entity/Default/25.200.001";
		}
	}
}