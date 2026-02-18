using System;
using System.Collections.Generic;

using Newtonsoft.Json;

using Acumatica.RESTClient.Client;
using Acumatica.RESTClient.ContractBasedApi;
using Acumatica.RESTClient.ContractBasedApi.Model;

namespace Acumatica.Default_23_200_001.Model
{
	/// <summary>
	/// Corresponds to the screen <c>GL302010</c> in the Acumatica ERP
	/// </summary>
	public class Budget : Entity, ITopLevelEntity
	{

		/// <summary>
		/// <para>DAC Field Name: BranchID</para>
		/// <para>DAC: PX.Objects.GL.BudgetFilter</para>
		/// </summary>
		public StringValue? Branch { get; set; }

		/// <summary>
		/// <para>DAC Field Name: CompareToBranchID</para>
		/// <para>DAC: PX.Objects.GL.BudgetFilter</para>
		/// <para>Display Name: Compare to Branch</para>
		/// </summary>
		public StringValue? ComparetoBranch { get; set; }

		/// <summary>
		/// <para>DAC Field Name: CompareToLedgerID</para>
		/// <para>DAC: PX.Objects.GL.BudgetFilter</para>
		/// <para>Display Name: Compare to Ledger</para>
		/// </summary>
		public StringValue? ComparetoLedger { get; set; }

		/// <summary>
		/// <para>DAC Field Name: CompareToFinYear</para>
		/// <para>DAC: PX.Objects.GL.BudgetFilter</para>
		/// <para>Display Name: Compare to Year</para>
		/// <para>SQL Type: varchar(4)</para>
		/// </summary>
		public StringValue? ComparetoYear { get; set; }

		public List<BudgetDetail>? Details { get; set; }

		/// <summary>
		/// <para>DAC Field Name: FinYear</para>
		/// <para>DAC: PX.Objects.GL.BudgetFilter</para>
		/// <para>Display Name: Financial Year</para>
		/// <para>SQL Type: varchar(4)</para>
		/// </summary>
		public StringValue? FinancialYear { get; set; }

		/// <summary>
		/// <para>DAC Field Name: LedgerId</para>
		/// <para>DAC: PX.Objects.GL.BudgetFilter</para>
		/// </summary>
		public StringValue? Ledger { get; set; }

		/// <summary>
		/// <para>DAC Field Name: SubIDFilter</para>
		/// <para>DAC: PX.Objects.GL.BudgetFilter</para>
		/// <para>Display Name: Subaccount Filter</para>
		/// <para>SQL Type: nvarchar(30)</para>
		/// </summary>
		public StringValue? SubaccountFilter { get; set; }

		/// <summary>
		/// <para>DAC: PX.Objects.GL.BudgetFilter</para>
		/// <para>Display Name: Tree Node Filter</para>
		/// <para>SQL Type: nvarchar(30)</para>
		/// </summary>
		public StringValue? TreeNodeFilter { get; set; }

		public static class Expand
		{
			public const string Files = "Files";
			public const string Translations = "Translations";
			public const string Details = "Details";
			public const string Details_Files = "Details/Files";

			//Intentionally excluded
			//public const string All = "Files,Translations,Details,Details/Files";
		}
		public virtual string GetEndpointPath()
		{
			return "entity/Default/23.200.001";
		}
	}
}