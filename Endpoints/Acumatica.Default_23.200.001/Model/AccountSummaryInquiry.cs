using System;
using System.Collections.Generic;

using Newtonsoft.Json;

using Acumatica.RESTClient.Client;
using Acumatica.RESTClient.ContractBasedApi;
using Acumatica.RESTClient.ContractBasedApi.Model;

namespace Acumatica.Default_23_200_001.Model
{
	/// <summary>
	/// Corresponds to the screen <c>GL401000</c> in the Acumatica ERP
	/// </summary>
	public class AccountSummaryInquiry : Entity, ITopLevelEntity
	{

		/// <summary>
		/// <para>DAC Field Name: AccountClassID</para>
		/// <para>DAC: PX.Objects.GL.GLHistoryEnqFilter</para>
		/// <para>Display Name: Account Class</para>
		/// <para>SQL Type: nvarchar(20)</para>
		/// </summary>
		public StringValue? AccountClass { get; set; }

		/// <summary>
		/// <para>DAC Field Name: OrgBAccountID</para>
		/// <para>DAC: PX.Objects.GL.GLHistoryEnqFilter</para>
		/// <para>Display Name: Company/Branch</para>
		/// </summary>
		public StringValue? Branch { get; set; }

		/// <summary>
		/// <para>DAC Field Name: LedgerID</para>
		/// <para>DAC: PX.Objects.GL.GLHistoryEnqFilter</para>
		/// </summary>
		public StringValue? Ledger { get; set; }

		/// <summary>
		/// <para>DAC Field Name: FinPeriodID</para>
		/// <para>DAC: PX.Objects.GL.GLHistoryEnqFilter</para>
		/// <para>SQL Type: char(6)</para>
		/// </summary>
		public StringValue? Period { get; set; }

		public List<AccountSummaryRow>? Results { get; set; }

		/// <summary>
		/// <para>DAC Field Name: SubCD</para>
		/// <para>DAC: PX.Objects.GL.GLHistoryEnqFilter</para>
		/// <para>SQL Type: varchar(30)</para>
		/// </summary>
		public StringValue? Subaccount { get; set; }

		public static class Expand
		{
			public const string Files = "Files";
			public const string Translations = "Translations";
			public const string Results = "Results";
			public const string Results_Files = "Results/Files";

			//Intentionally excluded
			//public const string All = "Files,Translations,Results,Results/Files";
		}
		public virtual string GetEndpointPath()
		{
			return "entity/Default/23.200.001";
		}
	}
}