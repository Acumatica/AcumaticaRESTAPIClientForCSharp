using System;
using System.Collections.Generic;
using System.Runtime.Serialization;

using Newtonsoft.Json;

using Acumatica.RESTClient.Client;
using Acumatica.RESTClient.ContractBasedApi;
using Acumatica.RESTClient.ContractBasedApi.Model;

namespace Acumatica.Default_23_200_001.Model
{
	[DataContract]
	public class BudgetDetail : Entity
	{

		/// <summary>
		/// The identifier of the GL account of the budget article.
		/// DAC Field Name: AccountID 
		/// DAC: PX.Objects.GL.GLBudgetLine 
		/// </summary>
		[DataMember(Name="Account", EmitDefaultValue=false)]
		public StringValue? Account { get; set; }

		/// <summary>
		/// The amount that is budgeted for the article for a particular year.
		/// DAC: PX.Objects.GL.GLBudgetLine 
		/// </summary>
		[DataMember(Name="Amount", EmitDefaultValue=false)]
		public DecimalValue? Amount { get; set; }

		/// <summary>
		/// DAC Field Name: BranchID 
		/// DAC: PX.Objects.GL.BudgetFilter 
		/// </summary>
		[DataMember(Name="Branch", EmitDefaultValue=false)]
		public StringValue? Branch { get; set; }

		/// <summary>
		/// The ID of the user who created the record.
		/// DAC Field Name: CreatedByID 
		/// DAC: PX.Objects.GL.GLBudgetLine 
		/// Display Name: Created By 
		/// </summary>
		[DataMember(Name="CreatedBy", EmitDefaultValue=false)]
		public StringValue? CreatedBy { get; set; }

		/// <summary>
		/// The description of the budget article.
		/// DAC: PX.Objects.GL.GLBudgetLine 
		/// SQL Type: nvarchar(150) 
		/// </summary>
		[DataMember(Name="Description", EmitDefaultValue=false)]
		public StringValue? Description { get; set; }

		/// <summary>
		/// The total amount of the budget article distributed between the periods of the year.
		/// DAC Field Name: AllocatedAmount 
		/// DAC: PX.Objects.GL.GLBudgetLine 
		/// Display Name: Distributed Amount 
		/// </summary>
		[DataMember(Name="DistributedAmount", EmitDefaultValue=false)]
		public DecimalValue? DistributedAmount { get; set; }

		/// <summary>
		/// DAC Field Name: FinYear 
		/// DAC: PX.Objects.GL.BudgetFilter 
		/// Display Name: Financial Year 
		/// SQL Type: varchar(4) 
		/// </summary>
		[DataMember(Name="FinancialYear", EmitDefaultValue=false)]
		public StringValue? FinancialYear { get; set; }

		/// <summary>
		/// The unique identifier of the budget article.This field is a part of the compound key.
		/// DAC: PX.Objects.GL.GLBudgetLine 
		/// Key Field
		/// </summary>
		[DataMember(Name="GroupID", EmitDefaultValue=false)]
		public GuidValue? GroupID { get; set; }

		/// <summary>
		/// The ID of the user who last modified the record.
		/// DAC Field Name: LastModifiedByID 
		/// DAC: PX.Objects.GL.GLBudgetLine 
		/// Display Name: Last Modified By 
		/// </summary>
		[DataMember(Name="LastModifiedBy", EmitDefaultValue=false)]
		public StringValue? LastModifiedBy { get; set; }

		[DataMember(Name="LedgerID", EmitDefaultValue=false)]
		public StringValue? LedgerID { get; set; }

		/// <summary>
		/// Specifies (if set to true) that the budget article represents a group of other articles.That is, the article has child articles, which are linked to this article by their ParentGroupID field.
		/// DAC Field Name: IsGroup 
		/// DAC: PX.Objects.GL.GLBudgetLine 
		/// </summary>
		[DataMember(Name="Node", EmitDefaultValue=false)]
		public BooleanValue? Node { get; set; }

		/// <summary>
		/// DAC Field Name: Period1 
		/// DAC: PX.Objects.GL.GLBudgetLine 
		/// </summary>
		[DataMember(Name="Period01", EmitDefaultValue=false)]
		public DecimalValue? Period01 { get; set; }

		/// <summary>
		/// DAC Field Name: Period2 
		/// DAC: PX.Objects.GL.GLBudgetLine 
		/// </summary>
		[DataMember(Name="Period02", EmitDefaultValue=false)]
		public DecimalValue? Period02 { get; set; }

		/// <summary>
		/// DAC Field Name: Period3 
		/// DAC: PX.Objects.GL.GLBudgetLine 
		/// </summary>
		[DataMember(Name="Period03", EmitDefaultValue=false)]
		public DecimalValue? Period03 { get; set; }

		/// <summary>
		/// DAC Field Name: Period4 
		/// DAC: PX.Objects.GL.GLBudgetLine 
		/// </summary>
		[DataMember(Name="Period04", EmitDefaultValue=false)]
		public DecimalValue? Period04 { get; set; }

		/// <summary>
		/// DAC Field Name: Period5 
		/// DAC: PX.Objects.GL.GLBudgetLine 
		/// </summary>
		[DataMember(Name="Period05", EmitDefaultValue=false)]
		public DecimalValue? Period05 { get; set; }

		/// <summary>
		/// DAC Field Name: Period6 
		/// DAC: PX.Objects.GL.GLBudgetLine 
		/// </summary>
		[DataMember(Name="Period06", EmitDefaultValue=false)]
		public DecimalValue? Period06 { get; set; }

		/// <summary>
		/// DAC Field Name: Period7 
		/// DAC: PX.Objects.GL.GLBudgetLine 
		/// </summary>
		[DataMember(Name="Period07", EmitDefaultValue=false)]
		public DecimalValue? Period07 { get; set; }

		/// <summary>
		/// DAC Field Name: Period8 
		/// DAC: PX.Objects.GL.GLBudgetLine 
		/// </summary>
		[DataMember(Name="Period08", EmitDefaultValue=false)]
		public DecimalValue? Period08 { get; set; }

		/// <summary>
		/// DAC Field Name: Period9 
		/// DAC: PX.Objects.GL.GLBudgetLine 
		/// </summary>
		[DataMember(Name="Period09", EmitDefaultValue=false)]
		public DecimalValue? Period09 { get; set; }

		/// <summary>
		/// DAC: PX.Objects.GL.GLBudgetLine 
		/// </summary>
		[DataMember(Name="Period10", EmitDefaultValue=false)]
		public DecimalValue? Period10 { get; set; }

		/// <summary>
		/// DAC: PX.Objects.GL.GLBudgetLine 
		/// </summary>
		[DataMember(Name="Period11", EmitDefaultValue=false)]
		public DecimalValue? Period11 { get; set; }

		/// <summary>
		/// DAC: PX.Objects.GL.GLBudgetLine 
		/// </summary>
		[DataMember(Name="Period12", EmitDefaultValue=false)]
		public DecimalValue? Period12 { get; set; }

		/// <summary>
		/// DAC: PX.Objects.GL.GLBudgetLine 
		/// </summary>
		[DataMember(Name="Period13", EmitDefaultValue=false)]
		public DecimalValue? Period13 { get; set; }

		/// <summary>
		/// Specifies (if set to true) that the budget article has been released at least once.A released article can be released again if its Amount is not equal to its ReleasedAmount.
		/// DAC: PX.Objects.GL.GLBudgetLine 
		/// </summary>
		[DataMember(Name="Released", EmitDefaultValue=false)]
		public BooleanValue? Released { get; set; }

		/// <summary>
		/// The identifier of the GL subaccount of the budget article.
		/// DAC Field Name: SubID 
		/// DAC: PX.Objects.GL.GLBudgetLine 
		/// </summary>
		[DataMember(Name="Subaccount", EmitDefaultValue=false)]
		public StringValue? Subaccount { get; set; }

	}
}