using System;
using System.Collections.Generic;
using System.Runtime.Serialization;

using Newtonsoft.Json;

using Acumatica.RESTClient.Client;
using Acumatica.RESTClient.ContractBasedApi;
using Acumatica.RESTClient.ContractBasedApi.Model;

namespace Acumatica.Default_25_200_001.Model
{
	[DataContract]
	public class BudgetDetail : Entity
	{

		/// <summary>
		/// The identifier of the GL account of the budget article.
		/// <para>DAC Field Name: AccountID</para>
		/// <para>DAC: PX.Objects.GL.GLBudgetLine</para>
		/// </summary>
		[DataMember(Name="Account", EmitDefaultValue=false)]
		public StringValue? Account { get; set; }

		/// <summary>
		/// The amount that is budgeted for the article for a particular year.
		/// <para>DAC: PX.Objects.GL.GLBudgetLine</para>
		/// </summary>
		[DataMember(Name="Amount", EmitDefaultValue=false)]
		public DecimalValue? Amount { get; set; }

		/// <summary>
		/// <para>DAC Field Name: BranchID</para>
		/// <para>DAC: PX.Objects.GL.BudgetFilter</para>
		/// </summary>
		[DataMember(Name="Branch", EmitDefaultValue=false)]
		public StringValue? Branch { get; set; }

		/// <summary>
		/// The ID of the user who created the record.
		/// <para>DAC Field Name: CreatedByID</para>
		/// <para>DAC: PX.Objects.GL.GLBudgetLine</para>
		/// <para>Display Name: Created By</para>
		/// </summary>
		[DataMember(Name="CreatedBy", EmitDefaultValue=false)]
		public StringValue? CreatedBy { get; set; }

		/// <summary>
		/// The description of the budget article.
		/// <para>DAC: PX.Objects.GL.GLBudgetLine</para>
		/// <para>SQL Type: nvarchar(150)</para>
		/// </summary>
		[DataMember(Name="Description", EmitDefaultValue=false)]
		public StringValue? Description { get; set; }

		/// <summary>
		/// The total amount of the budget article distributed between the periods of the year.
		/// <para>DAC Field Name: AllocatedAmount</para>
		/// <para>DAC: PX.Objects.GL.GLBudgetLine</para>
		/// <para>Display Name: Distributed Amount</para>
		/// </summary>
		[DataMember(Name="DistributedAmount", EmitDefaultValue=false)]
		public DecimalValue? DistributedAmount { get; set; }

		/// <summary>
		/// <para>DAC Field Name: FinYear</para>
		/// <para>DAC: PX.Objects.GL.BudgetFilter</para>
		/// <para>Display Name: Financial Year</para>
		/// <para>SQL Type: varchar(4)</para>
		/// </summary>
		[DataMember(Name="FinancialYear", EmitDefaultValue=false)]
		public StringValue? FinancialYear { get; set; }

		/// <summary>
		/// The unique identifier of the budget article.This field is a part of the compound key.
		/// <para>DAC: PX.Objects.GL.GLBudgetLine</para>
		/// Key Field
		/// </summary>
		[DataMember(Name="GroupID", EmitDefaultValue=false)]
		public GuidValue? GroupID { get; set; }

		/// <summary>
		/// The ID of the user who last modified the record.
		/// <para>DAC Field Name: LastModifiedByID</para>
		/// <para>DAC: PX.Objects.GL.GLBudgetLine</para>
		/// <para>Display Name: Last Modified By</para>
		/// </summary>
		[DataMember(Name="LastModifiedBy", EmitDefaultValue=false)]
		public StringValue? LastModifiedBy { get; set; }

		[DataMember(Name="LedgerID", EmitDefaultValue=false)]
		public StringValue? LedgerID { get; set; }

		/// <summary>
		/// Specifies (if set to true) that the budget article represents a group of other articles.That is, the article has child articles, which are linked to this article by their ParentGroupID field.
		/// <para>DAC Field Name: IsGroup</para>
		/// <para>DAC: PX.Objects.GL.GLBudgetLine</para>
		/// </summary>
		[DataMember(Name="Node", EmitDefaultValue=false)]
		public BooleanValue? Node { get; set; }

		/// <summary>
		/// <para>DAC Field Name: Period1</para>
		/// <para>DAC: PX.Objects.GL.GLBudgetLine</para>
		/// </summary>
		[DataMember(Name="Period01", EmitDefaultValue=false)]
		public DecimalValue? Period01 { get; set; }

		/// <summary>
		/// <para>DAC Field Name: Period2</para>
		/// <para>DAC: PX.Objects.GL.GLBudgetLine</para>
		/// </summary>
		[DataMember(Name="Period02", EmitDefaultValue=false)]
		public DecimalValue? Period02 { get; set; }

		/// <summary>
		/// <para>DAC Field Name: Period3</para>
		/// <para>DAC: PX.Objects.GL.GLBudgetLine</para>
		/// </summary>
		[DataMember(Name="Period03", EmitDefaultValue=false)]
		public DecimalValue? Period03 { get; set; }

		/// <summary>
		/// <para>DAC Field Name: Period4</para>
		/// <para>DAC: PX.Objects.GL.GLBudgetLine</para>
		/// </summary>
		[DataMember(Name="Period04", EmitDefaultValue=false)]
		public DecimalValue? Period04 { get; set; }

		/// <summary>
		/// <para>DAC Field Name: Period5</para>
		/// <para>DAC: PX.Objects.GL.GLBudgetLine</para>
		/// </summary>
		[DataMember(Name="Period05", EmitDefaultValue=false)]
		public DecimalValue? Period05 { get; set; }

		/// <summary>
		/// <para>DAC Field Name: Period6</para>
		/// <para>DAC: PX.Objects.GL.GLBudgetLine</para>
		/// </summary>
		[DataMember(Name="Period06", EmitDefaultValue=false)]
		public DecimalValue? Period06 { get; set; }

		/// <summary>
		/// <para>DAC Field Name: Period7</para>
		/// <para>DAC: PX.Objects.GL.GLBudgetLine</para>
		/// </summary>
		[DataMember(Name="Period07", EmitDefaultValue=false)]
		public DecimalValue? Period07 { get; set; }

		/// <summary>
		/// <para>DAC Field Name: Period8</para>
		/// <para>DAC: PX.Objects.GL.GLBudgetLine</para>
		/// </summary>
		[DataMember(Name="Period08", EmitDefaultValue=false)]
		public DecimalValue? Period08 { get; set; }

		/// <summary>
		/// <para>DAC Field Name: Period9</para>
		/// <para>DAC: PX.Objects.GL.GLBudgetLine</para>
		/// </summary>
		[DataMember(Name="Period09", EmitDefaultValue=false)]
		public DecimalValue? Period09 { get; set; }

		/// <summary>
		/// <para>DAC: PX.Objects.GL.GLBudgetLine</para>
		/// </summary>
		[DataMember(Name="Period10", EmitDefaultValue=false)]
		public DecimalValue? Period10 { get; set; }

		/// <summary>
		/// <para>DAC: PX.Objects.GL.GLBudgetLine</para>
		/// </summary>
		[DataMember(Name="Period11", EmitDefaultValue=false)]
		public DecimalValue? Period11 { get; set; }

		/// <summary>
		/// <para>DAC: PX.Objects.GL.GLBudgetLine</para>
		/// </summary>
		[DataMember(Name="Period12", EmitDefaultValue=false)]
		public DecimalValue? Period12 { get; set; }

		/// <summary>
		/// <para>DAC: PX.Objects.GL.GLBudgetLine</para>
		/// </summary>
		[DataMember(Name="Period13", EmitDefaultValue=false)]
		public DecimalValue? Period13 { get; set; }

		/// <summary>
		/// Specifies (if set to true) that the budget article has been released at least once.A released article can be released again if its Amount is not equal to its ReleasedAmount.
		/// <para>DAC: PX.Objects.GL.GLBudgetLine</para>
		/// </summary>
		[DataMember(Name="Released", EmitDefaultValue=false)]
		public BooleanValue? Released { get; set; }

		/// <summary>
		/// The identifier of the GL subaccount of the budget article.
		/// <para>DAC Field Name: SubID</para>
		/// <para>DAC: PX.Objects.GL.GLBudgetLine</para>
		/// </summary>
		[DataMember(Name="Subaccount", EmitDefaultValue=false)]
		public StringValue? Subaccount { get; set; }

	}
}