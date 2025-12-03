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
	/// Corresponds to the screen <c>GL202500</c> in the Acumatica ERP
	/// <para>Key Fields: AccountCD</para>
	/// </summary>
	[DataContract]
	public class Account : Entity, ITopLevelEntity
	{

		/// <summary>
		/// Key field.The user-friendly unique identifier of the account.
		/// <para>DAC: PX.Objects.GL.Account</para>
		/// <para>Display Name: Account</para>
		/// <para>SQL Type: nvarchar(10)</para>
		/// Key Field
		/// </summary>
		[DataMember(Name="AccountCD", EmitDefaultValue=false)]
		public StringValue? AccountCD { get; set; }

		/// <summary>
		/// Identifier of the account class, to which the account is assigned.
		/// <para>DAC Field Name: AccountClassID</para>
		/// <para>DAC: PX.Objects.GL.Account</para>
		/// <para>Display Name: Account Class</para>
		/// <para>SQL Type: nvarchar(20)</para>
		/// </summary>
		[DataMember(Name="AccountClass", EmitDefaultValue=false)]
		public StringValue? AccountClass { get; set; }

		/// <summary>
		/// Identifier of the Account Group, that includes this account.Used only if the Projects module has been activated.
		/// <para>DAC Field Name: AccountGroupID</para>
		/// <para>DAC: PX.Objects.GL.Account</para>
		/// <para>Display Name: Account Group</para>
		/// </summary>
		[DataMember(Name="AccountGroup", EmitDefaultValue=false)]
		public StringValue? AccountGroup { get; set; }

		/// <summary>
		/// Unique identifier of the account. Database identity.
		/// <para>DAC: PX.Objects.GL.Account</para>
		/// <para>Display Name: Account ID</para>
		/// </summary>
		[DataMember(Name="AccountID", EmitDefaultValue=false)]
		public IntValue? AccountID { get; set; }

		/// <summary>
		/// Indicates whether the Account is active.
		/// <para>DAC: PX.Objects.GL.Account</para>
		/// </summary>
		[DataMember(Name="Active", EmitDefaultValue=false)]
		public BooleanValue? Active { get; set; }

		/// <summary>
		/// Indicates whether the accounts has on or several Cash Accounts associated with it.
		/// <para>DAC Field Name: IsCashAccount</para>
		/// <para>DAC: PX.Objects.GL.Account</para>
		/// <para>Display Name: Cash Account</para>
		/// </summary>
		[DataMember(Name="CashAccount", EmitDefaultValue=false)]
		public BooleanValue? CashAccount { get; set; }

		/// <summary>
		/// The relative order of the account in the chart of accounts.
		/// <para>DAC Field Name: COAOrder</para>
		/// <para>DAC: PX.Objects.GL.Account</para>
		/// <para>Display Name: COA Order</para>
		/// </summary>
		[DataMember(Name="ChartOfAccountsOrder", EmitDefaultValue=false)]
		public IntValue? ChartOfAccountsOrder { get; set; }

		/// <summary>
		/// The identifier of the external General Ledger account in the chart of accounts of the parent company,to which the balance of this account will be exported in the process of consolidation.This field is relevant only if the company is a consolidation unit in the parent company.
		/// <para>DAC Field Name: GLConsolAccountCD</para>
		/// <para>DAC: PX.Objects.GL.Account</para>
		/// <para>Display Name: Consolidation Account</para>
		/// <para>SQL Type: nvarchar(30)</para>
		/// </summary>
		[DataMember(Name="ConsolidationAccount", EmitDefaultValue=false)]
		public StringValue? ConsolidationAccount { get; set; }

		[DataMember(Name="CreatedDateTime", EmitDefaultValue=false)]
		public DateTimeValue? CreatedDateTime { get; set; }

		/// <summary>
		/// Identifier of the Currency of the account.
		/// <para>DAC Field Name: CuryID</para>
		/// <para>DAC: PX.Objects.GL.Account</para>
		/// <para>Display Name: Currency</para>
		/// <para>SQL Type: nvarchar(5)</para>
		/// </summary>
		[DataMember(Name="CurrencyID", EmitDefaultValue=false)]
		public StringValue? CurrencyID { get; set; }

		/// <summary>
		/// The description of the account.
		/// <para>DAC: PX.Objects.GL.Account</para>
		/// <para>SQL Type: nvarchar(60)</para>
		/// </summary>
		[DataMember(Name="Description", EmitDefaultValue=false)]
		public StringValue? Description { get; set; }

		[DataMember(Name="LastModifiedDateTime", EmitDefaultValue=false)]
		public DateTimeValue? LastModifiedDateTime { get; set; }

		/// <summary>
		/// Defines how the transactions created in other modules are posted to this account.In the scope of the account overrides the APSetup.SummaryPost,ARSetup.SummaryPost and similar settings in other modules.
		/// <para>DAC: PX.Objects.GL.Account</para>
		/// <para>Display Name: Post Option</para>
		/// <para>SQL Type: char(1)</para>
		/// </summary>
		[DataMember(Name="PostOption", EmitDefaultValue=false)]
		public StringValue? PostOption { get; set; }

		/// <summary>
		/// When set to true, indicates that every transaction posted to this account must haveQunatity and Units of Measure specified.
		/// <para>DAC: PX.Objects.GL.Account</para>
		/// <para>Display Name: Require Units</para>
		/// </summary>
		[DataMember(Name="RequireUnits", EmitDefaultValue=false)]
		public BooleanValue? RequireUnits { get; set; }

		/// <summary>
		/// The identifier of the Exchange Rate Typethat is used for the account in the process of revaluation.This field is required only for the accounts denominated to a foreign currency.
		/// <para>DAC Field Name: RevalCuryRateTypeId</para>
		/// <para>DAC: PX.Objects.GL.Account</para>
		/// <para>Display Name: Revaluation Rate Type</para>
		/// <para>SQL Type: nvarchar(6)</para>
		/// </summary>
		[DataMember(Name="RevaluationRateType", EmitDefaultValue=false)]
		public StringValue? RevaluationRateType { get; set; }

		/// <summary>
		/// <para>DAC: PX.Objects.GL.Account</para>
		/// </summary>
		[DataMember(Name="Secured", EmitDefaultValue=false)]
		public BooleanValue? Secured { get; set; }

		/// <summary>
		/// Identifier of the Tax Category associated with the account.
		/// <para>DAC Field Name: TaxCategoryID</para>
		/// <para>DAC: PX.Objects.GL.Account</para>
		/// <para>Display Name: Tax Category</para>
		/// <para>SQL Type: nvarchar(15)</para>
		/// </summary>
		[DataMember(Name="TaxCategory", EmitDefaultValue=false)]
		public StringValue? TaxCategory { get; set; }

		/// <summary>
		/// The type of the account.
		/// <para>DAC: PX.Objects.GL.Account</para>
		/// <para>SQL Type: char(1)</para>
		/// </summary>
		[DataMember(Name="Type", EmitDefaultValue=false)]
		public StringValue? Type { get; set; }

		/// <summary>
		/// If set to true, indicates that the system must set the subaccount to the default subaccount,when this account is selected for a document or transaction.
		/// <para>DAC Field Name: NoSubDetail</para>
		/// <para>DAC: PX.Objects.GL.Account</para>
		/// <para>Display Name: Use Default Subaccount</para>
		/// </summary>
		[DataMember(Name="UseDefaultSubaccount", EmitDefaultValue=false)]
		public BooleanValue? UseDefaultSubaccount { get; set; }

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