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
	/// Corresponds to the screen <c>PM201000</c> in the Acumatica ERP
	/// <para>Key Fields: AccountGroupID</para>
	/// </summary>
	[DataContract]
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
		[DataMember(Name="AccountGroupID", EmitDefaultValue=false)]
		public StringValue? AccountGroupID { get; set; }

		/// <summary>
		/// Gets or sets whether Account group is active or not.
		/// <para>DAC Field Name: IsActive</para>
		/// <para>DAC: PX.Objects.PM.PMAccountGroup</para>
		/// </summary>
		[DataMember(Name="Active", EmitDefaultValue=false)]
		public BooleanValue? Active { get; set; }

		[DataMember(Name="Attributes", EmitDefaultValue=false)]
		public List<AttributeValue>? Attributes { get; set; }

		/// <summary>
		/// <para>DAC Field Name: AccountID</para>
		/// <para>DAC: PX.Objects.PM.AccountGroupMaint+AccountPtr</para>
		/// </summary>
		[DataMember(Name="DefaultAccountID", EmitDefaultValue=false)]
		public StringValue? DefaultAccountID { get; set; }

		/// <summary>
		/// Gets or Sets the AccountGroup description.
		/// <para>DAC: PX.Objects.PM.PMAccountGroup</para>
		/// <para>SQL Type: nvarchar(250)</para>
		/// </summary>
		[DataMember(Name="Description", EmitDefaultValue=false)]
		public StringValue? Description { get; set; }

		/// <summary>
		/// A Boolean value that indicates whether the account group is an expense account groupand can be selected on the Cost Budget tab of the Projects (PM301000) form.
		/// <para>DAC Field Name: IsExpense</para>
		/// <para>DAC: PX.Objects.PM.PMAccountGroup</para>
		/// </summary>
		[DataMember(Name="Expense", EmitDefaultValue=false)]
		public BooleanValue? Expense { get; set; }

		[DataMember(Name="LastModifiedDateTime", EmitDefaultValue=false)]
		public DateTimeValue? LastModifiedDateTime { get; set; }

		/// <summary>
		/// Gets or sets sort order. Sort order is used in displaying the Balances for the Project.
		/// <para>DAC: PX.Objects.PM.PMAccountGroup</para>
		/// <para>Display Name: Sort Order</para>
		/// </summary>
		[DataMember(Name="SortOrder", EmitDefaultValue=false)]
		public ShortValue? SortOrder { get; set; }

		/// <summary>
		/// The type of the account group, which can be one of the following: Asset, Liability, Expense, Income, and Off-Balance.
		/// <para>DAC: PX.Objects.PM.PMAccountGroup</para>
		/// <para>SQL Type: char(1)</para>
		/// </summary>
		[DataMember(Name="Type", EmitDefaultValue=false)]
		public StringValue? Type { get; set; }

		public static class Expand
		{
			public const string Files = "Files";
			public const string Attributes = "Attributes";

			//Intentionally excluded
			//public const string All = "Files,Attributes";
		}
		public virtual string GetEndpointPath()
		{
			return "entity/Default/25.200.001";
		}
	}
}