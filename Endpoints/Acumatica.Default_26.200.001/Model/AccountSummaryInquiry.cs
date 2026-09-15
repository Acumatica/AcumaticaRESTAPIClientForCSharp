using System;
using System.Collections.Generic;
using System.Runtime.Serialization;

using Newtonsoft.Json;

using Acumatica.RESTClient.Client;
using Acumatica.RESTClient.ContractBasedApi;
using Acumatica.RESTClient.ContractBasedApi.Model;

namespace Acumatica.Default_26_200_001.Model
{
	/// <summary>
	/// Corresponds to the screen <c>GL401000</c> in the Acumatica ERP
	/// </summary>
	[DataContract]
	public class AccountSummaryInquiry : Entity, ITopLevelEntity
	{

		/// <summary>
		/// <para>DAC Field Name: AccountClassID</para>
		/// <para>DAC: PX.Objects.GL.GLHistoryEnqFilter</para>
		/// <para>Display Name: Account Class</para>
		/// <para>SQL Type: nvarchar(20)</para>
		/// </summary>
		[DataMember(Name="AccountClass", EmitDefaultValue=false)]
		public StringValue? AccountClass { get; set; }

		/// <summary>
		/// <para>DAC Field Name: OrgBAccountID</para>
		/// <para>DAC: PX.Objects.GL.GLHistoryEnqFilter</para>
		/// <para>Display Name: Company/Branch</para>
		/// </summary>
		[DataMember(Name="Branch", EmitDefaultValue=false)]
		public StringValue? Branch { get; set; }

		/// <summary>
		/// <para>DAC Field Name: LedgerID</para>
		/// <para>DAC: PX.Objects.GL.GLHistoryEnqFilter</para>
		/// </summary>
		[DataMember(Name="Ledger", EmitDefaultValue=false)]
		public StringValue? Ledger { get; set; }

		/// <summary>
		/// <para>DAC Field Name: FinPeriodID</para>
		/// <para>DAC: PX.Objects.GL.GLHistoryEnqFilter</para>
		/// <para>SQL Type: char(6)</para>
		/// </summary>
		[DataMember(Name="Period", EmitDefaultValue=false)]
		public StringValue? Period { get; set; }

		[DataMember(Name="Results", EmitDefaultValue=false)]
		public List<AccountSummaryRow>? Results { get; set; }

		/// <summary>
		/// <para>DAC Field Name: SubCD</para>
		/// <para>DAC: PX.Objects.GL.GLHistoryEnqFilter</para>
		/// <para>SQL Type: varchar(30)</para>
		/// </summary>
		[DataMember(Name="Subaccount", EmitDefaultValue=false)]
		public StringValue? Subaccount { get; set; }

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
			public const string Translations = "Translations";
			public const string Results = "Results";

			//Intentionally excluded
			//public const string All = "Files,Translations,Results";
		}
		public virtual string GetEndpointPath()
		{
			return "entity/Default/26.200.001";
		}
	}
}