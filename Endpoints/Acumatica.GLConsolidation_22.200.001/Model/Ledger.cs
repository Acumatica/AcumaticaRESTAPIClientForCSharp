using System;
using System.Collections.Generic;

using Newtonsoft.Json;

using Acumatica.RESTClient.Client;
using Acumatica.RESTClient.ContractBasedApi;
using Acumatica.RESTClient.ContractBasedApi.Model;

namespace Acumatica.GLConsolidation_22_200_001.Model
{
	/// <summary>
	/// Corresponds to the screen <c>GL103003</c> in the Acumatica ERP
	/// <para>Key Fields: LedgerCD</para>
	/// </summary>
	public class Ledger : Entity, ITopLevelEntity
	{

		/// <summary>
		/// The type of the balance of the ledger.
		/// <para>DAC: PX.Objects.GL.Ledger</para>
		/// <para>Display Name: Type</para>
		/// <para>SQL Type: char(1)</para>
		/// </summary>
		public StringValue? BalanceType { get; set; }

		/// <summary>
		/// The description of the Ledger.
		/// <para>DAC: PX.Objects.GL.Ledger</para>
		/// <para>Display Name: Description</para>
		/// <para>SQL Type: nvarchar(60)</para>
		/// </summary>
		public StringValue? Descr { get; set; }

		/// <summary>
		/// Key field.Unique user-friendly identifier of the Ledger.
		/// <para>DAC: PX.Objects.GL.Ledger</para>
		/// <para>Display Name: Ledger ID</para>
		/// <para>SQL Type: nvarchar(10)</para>
		/// Key Field
		/// </summary>
		public StringValue? LedgerCD { get; set; }

		public static class Expand
		{
			public const string Files = "Files";
			public const string Translations = "Translations";

			//Intentionally excluded
			//public const string All = "Files,Translations";
		}
		public virtual string GetEndpointPath()
		{
			return "entity/GLConsolidation/22.200.001";
		}
	}
}