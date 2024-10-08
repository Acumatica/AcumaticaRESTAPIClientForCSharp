using System;
using System.Collections.Generic;
using System.Runtime.Serialization;

using Newtonsoft.Json;

using Acumatica.RESTClient.Client;
using Acumatica.RESTClient.ContractBasedApi;
using Acumatica.RESTClient.ContractBasedApi.Model;

namespace Acumatica.Default_24_200_001.Model
{
	/// <summary>
	/// Corresponds to the screen GL202500 in the Acumatica ERP
	/// </summary>
	[DataContract]
	public class Account : Entity, ITopLevelEntity
	{

		/// <summary>
		/// Key field.The user-friendly unique identifier of the account.
		/// DAC: PX.Objects.GL.Account 
		/// Display Name: Account 
		/// SQL Type: nvarchar(10) 
		/// Key Field
		/// </summary>
		[DataMember(Name="AccountCD", EmitDefaultValue=false)]
		public StringValue? AccountCD { get; set; }

		/// <summary>
		/// Identifier of the account class, to which the account is assigned.
		/// DAC Field Name: AccountClassID 
		/// DAC: PX.Objects.GL.Account 
		/// Display Name: Account Class 
		/// SQL Type: nvarchar(20) 
		/// </summary>
		[DataMember(Name="AccountClass", EmitDefaultValue=false)]
		public StringValue? AccountClass { get; set; }

		/// <summary>
		/// Identifier of the Account Group, that includes this account.Used only if the Projects module has been activated.
		/// DAC Field Name: AccountGroupID 
		/// DAC: PX.Objects.GL.Account 
		/// Display Name: Account Group 
		/// </summary>
		[DataMember(Name="AccountGroup", EmitDefaultValue=false)]
		public StringValue? AccountGroup { get; set; }

		/// <summary>
		/// Unique identifier of the account. Database identity.
		/// DAC: PX.Objects.GL.Account 
		/// Display Name: Account ID 
		/// </summary>
		[DataMember(Name="AccountID", EmitDefaultValue=false)]
		public IntValue? AccountID { get; set; }

		/// <summary>
		/// Indicates whether the Account is active.
		/// DAC: PX.Objects.GL.Account 
		/// </summary>
		[DataMember(Name="Active", EmitDefaultValue=false)]
		public BooleanValue? Active { get; set; }

		/// <summary>
		/// Indicates whether the accounts has on or several Cash Accounts associated with it.
		/// DAC Field Name: IsCashAccount 
		/// DAC: PX.Objects.GL.Account 
		/// Display Name: Cash Account 
		/// </summary>
		[DataMember(Name="CashAccount", EmitDefaultValue=false)]
		public BooleanValue? CashAccount { get; set; }

		/// <summary>
		/// The relative order of the account in the chart of accounts.
		/// DAC Field Name: COAOrder 
		/// DAC: PX.Objects.GL.Account 
		/// Display Name: COA Order 
		/// </summary>
		[DataMember(Name="ChartOfAccountsOrder", EmitDefaultValue=false)]
		public IntValue? ChartOfAccountsOrder { get; set; }

		/// <summary>
		/// The identifier of the external General Ledger account in the chart of accounts of the parent company,to which the balance of this account will be exported in the process of consolidation.This field is relevant only if the company is a consolidation unit in the parent company.
		/// DAC Field Name: GLConsolAccountCD 
		/// DAC: PX.Objects.GL.Account 
		/// Display Name: Consolidation Account 
		/// SQL Type: nvarchar(30) 
		/// </summary>
		[DataMember(Name="ConsolidationAccount", EmitDefaultValue=false)]
		public StringValue? ConsolidationAccount { get; set; }

		[DataMember(Name="CreatedDateTime", EmitDefaultValue=false)]
		public DateTimeValue? CreatedDateTime { get; set; }

		/// <summary>
		/// Identifier of the Currency of the account.
		/// DAC Field Name: CuryID 
		/// DAC: PX.Objects.GL.Account 
		/// Display Name: Currency 
		/// SQL Type: nvarchar(5) 
		/// </summary>
		[DataMember(Name="CurrencyID", EmitDefaultValue=false)]
		public StringValue? CurrencyID { get; set; }

		/// <summary>
		/// The description of the account.
		/// DAC: PX.Objects.GL.Account 
		/// SQL Type: nvarchar(60) 
		/// </summary>
		[DataMember(Name="Description", EmitDefaultValue=false)]
		public StringValue? Description { get; set; }

		[DataMember(Name="LastModifiedDateTime", EmitDefaultValue=false)]
		public DateTimeValue? LastModifiedDateTime { get; set; }

		/// <summary>
		/// Defines how the transactions created in other modules are posted to this account.In the scope of the account overrides the APSetup.SummaryPost,ARSetup.SummaryPost and similar settings in other modules.
		/// DAC: PX.Objects.GL.Account 
		/// Display Name: Post Option 
		/// SQL Type: char(1) 
		/// </summary>
		[DataMember(Name="PostOption", EmitDefaultValue=false)]
		public StringValue? PostOption { get; set; }

		/// <summary>
		/// When set to true, indicates that every transaction posted to this account must haveQunatity and Units of Measure specified.
		/// DAC: PX.Objects.GL.Account 
		/// Display Name: Require Units 
		/// </summary>
		[DataMember(Name="RequireUnits", EmitDefaultValue=false)]
		public BooleanValue? RequireUnits { get; set; }

		/// <summary>
		/// The identifier of the Exchange Rate Typethat is used for the account in the process of revaluation.This field is required only for the accounts denominated to a foreign currency.
		/// DAC Field Name: RevalCuryRateTypeId 
		/// DAC: PX.Objects.GL.Account 
		/// Display Name: Revaluation Rate Type 
		/// SQL Type: nvarchar(6) 
		/// </summary>
		[DataMember(Name="RevaluationRateType", EmitDefaultValue=false)]
		public StringValue? RevaluationRateType { get; set; }

		/// <summary>
		/// DAC: PX.Objects.GL.Account 
		/// </summary>
		[DataMember(Name="Secured", EmitDefaultValue=false)]
		public BooleanValue? Secured { get; set; }

		/// <summary>
		/// Identifier of the Tax Category associated with the account.
		/// DAC Field Name: TaxCategoryID 
		/// DAC: PX.Objects.GL.Account 
		/// Display Name: Tax Category 
		/// SQL Type: nvarchar(15) 
		/// </summary>
		[DataMember(Name="TaxCategory", EmitDefaultValue=false)]
		public StringValue? TaxCategory { get; set; }

		/// <summary>
		/// The type of the account.
		/// DAC: PX.Objects.GL.Account 
		/// SQL Type: char(1) 
		/// </summary>
		[DataMember(Name="Type", EmitDefaultValue=false)]
		public StringValue? Type { get; set; }

		/// <summary>
		/// If set to true, indicates that the system must set the subaccount to the default subaccount,when this account is selected for a document or transaction.
		/// DAC Field Name: NoSubDetail 
		/// DAC: PX.Objects.GL.Account 
		/// Display Name: Use Default Subaccount 
		/// </summary>
		[DataMember(Name="UseDefaultSubaccount", EmitDefaultValue=false)]
		public BooleanValue? UseDefaultSubaccount { get; set; }

		public virtual string GetEndpointPath()
		{
			return "entity/Default/24.200.001";
		}
	}
}