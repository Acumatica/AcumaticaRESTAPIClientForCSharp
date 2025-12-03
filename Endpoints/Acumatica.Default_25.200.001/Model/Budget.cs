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
	/// Corresponds to the screen <c>GL302010</c> in the Acumatica ERP
	/// </summary>
	[DataContract]
	public class Budget : Entity, ITopLevelEntity
	{

		/// <summary>
		/// <para>DAC Field Name: BranchID</para>
		/// <para>DAC: PX.Objects.GL.BudgetFilter</para>
		/// </summary>
		[DataMember(Name="Branch", EmitDefaultValue=false)]
		public StringValue? Branch { get; set; }

		/// <summary>
		/// <para>DAC Field Name: CompareToBranchID</para>
		/// <para>DAC: PX.Objects.GL.BudgetFilter</para>
		/// <para>Display Name: Compare to Branch</para>
		/// </summary>
		[DataMember(Name="ComparetoBranch", EmitDefaultValue=false)]
		public StringValue? ComparetoBranch { get; set; }

		/// <summary>
		/// <para>DAC Field Name: CompareToLedgerID</para>
		/// <para>DAC: PX.Objects.GL.BudgetFilter</para>
		/// <para>Display Name: Compare to Ledger</para>
		/// </summary>
		[DataMember(Name="ComparetoLedger", EmitDefaultValue=false)]
		public StringValue? ComparetoLedger { get; set; }

		/// <summary>
		/// <para>DAC Field Name: CompareToFinYear</para>
		/// <para>DAC: PX.Objects.GL.BudgetFilter</para>
		/// <para>Display Name: Compare to Year</para>
		/// <para>SQL Type: varchar(4)</para>
		/// </summary>
		[DataMember(Name="ComparetoYear", EmitDefaultValue=false)]
		public StringValue? ComparetoYear { get; set; }

		[DataMember(Name="Details", EmitDefaultValue=false)]
		public List<BudgetDetail>? Details { get; set; }

		/// <summary>
		/// <para>DAC Field Name: FinYear</para>
		/// <para>DAC: PX.Objects.GL.BudgetFilter</para>
		/// <para>Display Name: Financial Year</para>
		/// <para>SQL Type: varchar(4)</para>
		/// </summary>
		[DataMember(Name="FinancialYear", EmitDefaultValue=false)]
		public StringValue? FinancialYear { get; set; }

		/// <summary>
		/// <para>DAC Field Name: LedgerId</para>
		/// <para>DAC: PX.Objects.GL.BudgetFilter</para>
		/// </summary>
		[DataMember(Name="Ledger", EmitDefaultValue=false)]
		public StringValue? Ledger { get; set; }

		/// <summary>
		/// <para>DAC Field Name: SubIDFilter</para>
		/// <para>DAC: PX.Objects.GL.BudgetFilter</para>
		/// <para>Display Name: Subaccount Filter</para>
		/// <para>SQL Type: nvarchar(30)</para>
		/// </summary>
		[DataMember(Name="SubaccountFilter", EmitDefaultValue=false)]
		public StringValue? SubaccountFilter { get; set; }

		/// <summary>
		/// <para>DAC: PX.Objects.GL.BudgetFilter</para>
		/// <para>Display Name: Tree Node Filter</para>
		/// <para>SQL Type: nvarchar(30)</para>
		/// </summary>
		[DataMember(Name="TreeNodeFilter", EmitDefaultValue=false)]
		public StringValue? TreeNodeFilter { get; set; }

		public static class Expand
		{
			public const string Files = "Files";
			public const string Details = "Details";
			public const string Details_Files = "Details/Files";

			//Intentionally excluded
			//public const string All = "Files,Details,Details/Files";
		}
		public virtual string GetEndpointPath()
		{
			return "entity/Default/25.200.001";
		}
	}
}