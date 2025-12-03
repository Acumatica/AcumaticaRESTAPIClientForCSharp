using System;
using System.Collections.Generic;
using System.Runtime.Serialization;

using Newtonsoft.Json;

using Acumatica.RESTClient.Client;
using Acumatica.RESTClient.ContractBasedApi;
using Acumatica.RESTClient.ContractBasedApi.Model;

namespace Acumatica.GLConsolidation_22_200_001.Model
{
	[DataContract]
	public class ConsolidationItem : Entity
	{

		/// <summary>
		/// <para>DAC: PX.Objects.GL.GLConsolData</para>
		/// <para>Display Name: Account</para>
		/// <para>SQL Type: nvarchar(30)</para>
		/// Key Field
		/// </summary>
		[DataMember(Name="AccountCD", EmitDefaultValue=false)]
		public StringValue? AccountCD { get; set; }

		/// <summary>
		/// <para>DAC: PX.Objects.GL.GLConsolData</para>
		/// <para>Display Name: Credit Amount</para>
		/// </summary>
		[DataMember(Name="ConsolAmtCredit", EmitDefaultValue=false)]
		public DecimalValue? ConsolAmtCredit { get; set; }

		/// <summary>
		/// <para>DAC: PX.Objects.GL.GLConsolData</para>
		/// <para>Display Name: Debit Amount</para>
		/// </summary>
		[DataMember(Name="ConsolAmtDebit", EmitDefaultValue=false)]
		public DecimalValue? ConsolAmtDebit { get; set; }

		/// <summary>
		/// <para>DAC: PX.Objects.GL.GLConsolData</para>
		/// <para>Display Name: Fin. Period</para>
		/// <para>SQL Type: nchar(6)</para>
		/// Key Field
		/// </summary>
		[DataMember(Name="FinPeriodID", EmitDefaultValue=false)]
		public StringValue? FinPeriodID { get; set; }

		/// <summary>
		/// <para>DAC: PX.Objects.GL.GLConsolData</para>
		/// <para>Display Name: Mapped Sub.</para>
		/// <para>SQL Type: nvarchar(30)</para>
		/// Key Field
		/// </summary>
		[DataMember(Name="MappedValue", EmitDefaultValue=false)]
		public StringValue? MappedValue { get; set; }

		/// <summary>
		/// <para>DAC: PX.Objects.GL.GLConsolData</para>
		/// <para>Display Name: Mapped Sub. Length</para>
		/// </summary>
		[DataMember(Name="MappedValueLength", EmitDefaultValue=false)]
		public IntValue? MappedValueLength { get; set; }

	}
}