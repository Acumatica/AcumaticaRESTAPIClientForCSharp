using System;
using System.Collections.Generic;

using Newtonsoft.Json;

using Acumatica.RESTClient.Client;
using Acumatica.RESTClient.ContractBasedApi;
using Acumatica.RESTClient.ContractBasedApi.Model;

namespace Acumatica.Default_23_200_001.Model
{
	/// <summary>
	/// Corresponds to the screen <c>PM201000</c> in the Acumatica ERP
	/// <para>Key Fields: AccountGroupID</para>
	/// </summary>
	public class AccountGroup : Entity, ITopLevelEntity
	{

		/// <summary>
		/// Gets or Sets the AccountGroup identifier.This is a segmented key and format is configured under segmented key maintenance screen in CS module.
		/// <para>DAC Field Name: GroupCD</para>
		/// <para>DAC: PX.Objects.PM.PMAccountGroup</para>
		/// <para>Display Name: Account Group ID</para>
		/// <para>SQL Type: nvarchar(10)</para>
		/// Key Field
		/// </summary>
		public StringValue? AccountGroupID { get; set; }

		/// <summary>
		/// Gets or sets whether Account group is active or not.
		/// <para>DAC Field Name: IsActive</para>
		/// <para>DAC: PX.Objects.PM.PMAccountGroup</para>
		/// </summary>
		public BooleanValue? Active { get; set; }

		public List<AttributeValue>? Attributes { get; set; }

		/// <summary>
		/// <para>DAC Field Name: AccountID</para>
		/// <para>DAC: PX.Objects.PM.AccountGroupMaint+AccountPtr</para>
		/// </summary>
		public StringValue? DefaultAccountID { get; set; }

		/// <summary>
		/// Gets or Sets the AccountGroup description.
		/// <para>DAC: PX.Objects.PM.PMAccountGroup</para>
		/// <para>SQL Type: nvarchar(250)</para>
		/// </summary>
		public StringValue? Description { get; set; }

		/// <summary>
		/// A Boolean value that indicates whether the account group is an expense account groupand can be selected on the Cost Budget tab of the Projects (PM301000) form.
		/// <para>DAC Field Name: IsExpense</para>
		/// <para>DAC: PX.Objects.PM.PMAccountGroup</para>
		/// </summary>
		public BooleanValue? Expense { get; set; }

		public DateTimeValue? LastModifiedDateTime { get; set; }

		/// <summary>
		/// Gets or sets sort order. Sort order is used in displaying the Balances for the Project.
		/// <para>DAC: PX.Objects.PM.PMAccountGroup</para>
		/// <para>Display Name: Sort Order</para>
		/// </summary>
		public ShortValue? SortOrder { get; set; }

		/// <summary>
		/// The type of the account group, which can be one of the following: Asset, Liability, Expense, Income, and Off-Balance.
		/// <para>DAC: PX.Objects.PM.PMAccountGroup</para>
		/// <para>SQL Type: char(1)</para>
		/// </summary>
		public StringValue? Type { get; set; }

		public static class Expand
		{
			public const string Files = "Files";
			public const string Translations = "Translations";
			public const string Attributes = "Attributes";

			//Intentionally excluded
			//public const string All = "Files,Translations,Attributes";
		}
		public virtual string GetEndpointPath()
		{
			return "entity/Default/23.200.001";
		}
	}
}