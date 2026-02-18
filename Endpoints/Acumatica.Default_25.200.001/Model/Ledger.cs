using System;
using System.Collections.Generic;

using Newtonsoft.Json;

using Acumatica.RESTClient.Client;
using Acumatica.RESTClient.ContractBasedApi;
using Acumatica.RESTClient.ContractBasedApi.Model;

namespace Acumatica.Default_25_200_001.Model
{
	/// <summary>
	/// Corresponds to the screen <c>GL201500</c> in the Acumatica ERP
	/// <para>Key Fields: LedgerID</para>
	/// </summary>
	public class Ledger : Entity, ITopLevelEntity
	{

		public List<LedgerBranches>? Branches { get; set; }

		public List<LedgerCompanies>? Companies { get; set; }

		/// <summary>
		/// When set to true, indicates that the system must use the Ledger as a source Ledger for consolidation.
		/// <para>DAC Field Name: ConsolAllowed</para>
		/// <para>DAC: PX.Objects.GL.Ledger</para>
		/// <para>Display Name: Consolidation Source</para>
		/// </summary>
		public BooleanValue? ConsolidationSource { get; set; }

		/// <summary>
		/// Base Currency of the Ledger.
		/// <para>DAC Field Name: BaseCuryID</para>
		/// <para>DAC: PX.Objects.GL.Ledger</para>
		/// <para>SQL Type: nvarchar(5)</para>
		/// </summary>
		public StringValue? Currency { get; set; }

		/// <summary>
		/// The description of the Ledger.
		/// <para>DAC Field Name: Descr</para>
		/// <para>DAC: PX.Objects.GL.Ledger</para>
		/// <para>SQL Type: nvarchar(60)</para>
		/// </summary>
		public StringValue? Description { get; set; }

		public DateTimeValue? LastModifiedDateTime { get; set; }

		/// <summary>
		/// Key field.Unique user-friendly identifier of the Ledger.
		/// <para>DAC Field Name: LedgerCD</para>
		/// <para>DAC: PX.Objects.GL.Ledger</para>
		/// <para>Display Name: Ledger ID</para>
		/// <para>SQL Type: nvarchar(10)</para>
		/// Key Field
		/// </summary>
		public StringValue? LedgerID { get; set; }

		/// <summary>
		/// The type of the balance of the ledger.
		/// <para>DAC Field Name: BalanceType</para>
		/// <para>DAC: PX.Objects.GL.Ledger</para>
		/// <para>SQL Type: char(1)</para>
		/// </summary>
		public StringValue? Type { get; set; }

		public static class Expand
		{
			public const string Files = "Files";
			public const string Translations = "Translations";
			public const string Branches = "Branches";
			public const string Branches_Files = "Branches/Files";
			public const string Companies = "Companies";
			public const string Companies_Files = "Companies/Files";

			//Intentionally excluded
			//public const string All = "Files,Translations,Branches,Branches/Files,Companies,Companies/Files";
		}
		public virtual string GetEndpointPath()
		{
			return "entity/Default/25.200.001";
		}
	}
}