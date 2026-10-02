using System;
using System.Collections.Generic;

using Newtonsoft.Json;

using Acumatica.RESTClient.Client;
using Acumatica.RESTClient.ContractBasedApi;
using Acumatica.RESTClient.ContractBasedApi.Model;

namespace Acumatica.Default_26_200_001.Model
{
	public class AccountDetailsForPeriodInquiryDetail : Entity
	{

		#region Fields
		/// <summary>
		/// <para>DAC Field Name: GLTran_branchID</para>
		/// <para>DAC: PX.Data.GenericResult</para>
		/// </summary>
		public StringValue? Branch { get; set; }

		/// <summary>
		/// <para>DAC Field Name: Batch_ledgerID</para>
		/// <para>DAC: PX.Data.GenericResult</para>
		/// </summary>
		public StringValue? Ledger { get; set; }

		/// <summary>
		/// <para>DAC Field Name: Batch_curyID</para>
		/// <para>DAC: PX.Data.GenericResult</para>
		/// </summary>
		public StringValue? Currency { get; set; }

		/// <summary>
		/// <para>DAC Field Name: GLTran_accountID</para>
		/// <para>DAC: PX.Data.GenericResult</para>
		/// </summary>
		public StringValue? Account { get; set; }

		/// <summary>
		/// <para>DAC Field Name: GLTran_subID</para>
		/// <para>DAC: PX.Data.GenericResult</para>
		/// </summary>
		public StringValue? Subaccount { get; set; }

		/// <summary>
		/// <para>DAC Field Name: GLTran_finPeriodID</para>
		/// <para>DAC: PX.Data.GenericResult</para>
		/// </summary>
		public StringValue? PeriodID { get; set; }

		/// <summary>
		/// <para>DAC Field Name: GLTran_tranDate</para>
		/// <para>DAC: PX.Data.GenericResult</para>
		/// </summary>
		public DateOnlyValue? TransactionDate { get; set; }

		/// <summary>
		/// <para>DAC Field Name: GLTran_tranDesc</para>
		/// <para>DAC: PX.Data.GenericResult</para>
		/// </summary>
		public StringValue? TransactionDescription { get; set; }

		/// <summary>
		/// <para>DAC Field Name: GLTran_posted</para>
		/// <para>DAC: PX.Data.GenericResult</para>
		/// </summary>
		public BooleanValue? Posted { get; set; }

		/// <summary>
		/// <para>DAC Field Name: GLTran_released</para>
		/// <para>DAC: PX.Data.GenericResult</para>
		/// </summary>
		public BooleanValue? Released { get; set; }

		/// <summary>
		/// <para>DAC Field Name: GLTran_module</para>
		/// <para>DAC: PX.Data.GenericResult</para>
		/// </summary>
		public StringValue? Module { get; set; }

		/// <summary>
		/// <para>DAC Field Name: GLTran_tranType</para>
		/// <para>DAC: PX.Data.GenericResult</para>
		/// </summary>
		public StringValue? TransactionType { get; set; }

		/// <summary>
		/// <para>DAC Field Name: GLTran_refNbr</para>
		/// <para>DAC: PX.Data.GenericResult</para>
		/// </summary>
		public StringValue? RefNumber { get; set; }

		/// <summary>
		/// <para>DAC Field Name: GLTran_referenceID</para>
		/// <para>DAC: PX.Data.GenericResult</para>
		/// </summary>
		public StringValue? CustomerVendor { get; set; }

		/// <summary>
		/// <para>DAC Field Name: GLTran_curyDebitAmt</para>
		/// <para>DAC: PX.Data.GenericResult</para>
		/// </summary>
		public DecimalValue? DebitAmount { get; set; }

		/// <summary>
		/// <para>DAC Field Name: GLTran_curyCreditAmt</para>
		/// <para>DAC: PX.Data.GenericResult</para>
		/// </summary>
		public DecimalValue? CreditAmount { get; set; }

		/// <summary>
		/// <para>DAC Field Name: GLTran_debitAmt</para>
		/// <para>DAC: PX.Data.GenericResult</para>
		/// </summary>
		public DecimalValue? DebitAmountInBaseCurrency { get; set; }

		/// <summary>
		/// <para>DAC Field Name: GLTran_creditAmt</para>
		/// <para>DAC: PX.Data.GenericResult</para>
		/// </summary>
		public DecimalValue? CreditAmountInBaseCurrency { get; set; }

		/// <summary>
		/// <para>DAC Field Name: GLTran_projectID</para>
		/// <para>DAC: PX.Data.GenericResult</para>
		/// </summary>
		public StringValue? Project { get; set; }

		/// <summary>
		/// <para>DAC Field Name: GLTran_taskID</para>
		/// <para>DAC: PX.Data.GenericResult</para>
		/// </summary>
		public StringValue? ProjectTask { get; set; }

		/// <summary>
		/// <para>DAC Field Name: GLTran_lastModifiedDateTime</para>
		/// <para>DAC: PX.Data.GenericResult</para>
		/// </summary>
		public DateTimeValue? LastModifiedDateTime { get; set; }

		public StringValue? BatchNumber { get; set; }

		#endregion

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

			//Intentionally excluded
			//public const string All = "Files";
		}
	}
}