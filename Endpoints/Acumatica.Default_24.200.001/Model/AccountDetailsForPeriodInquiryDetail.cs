using System;
using System.Collections.Generic;
using System.Runtime.Serialization;

using Newtonsoft.Json;

using Acumatica.RESTClient.Client;
using Acumatica.RESTClient.ContractBasedApi;
using Acumatica.RESTClient.ContractBasedApi.Model;

namespace Acumatica.Default_24_200_001.Model
{
	[DataContract]
	public class AccountDetailsForPeriodInquiryDetail : Entity
	{

		/// <summary>
		/// <para>DAC Field Name: GLTran_accountID</para>
		/// <para>DAC: PX.Data.GenericResult</para>
		/// </summary>
		[DataMember(Name="Account", EmitDefaultValue=false)]
		public StringValue? Account { get; set; }

		[DataMember(Name="BatchNumber", EmitDefaultValue=false)]
		public StringValue? BatchNumber { get; set; }

		/// <summary>
		/// <para>DAC Field Name: GLTran_branchID</para>
		/// <para>DAC: PX.Data.GenericResult</para>
		/// </summary>
		[DataMember(Name="Branch", EmitDefaultValue=false)]
		public StringValue? Branch { get; set; }

		/// <summary>
		/// <para>DAC Field Name: GLTran_curyCreditAmt</para>
		/// <para>DAC: PX.Data.GenericResult</para>
		/// </summary>
		[DataMember(Name="CreditAmount", EmitDefaultValue=false)]
		public DecimalValue? CreditAmount { get; set; }

		/// <summary>
		/// <para>DAC Field Name: GLTran_creditAmt</para>
		/// <para>DAC: PX.Data.GenericResult</para>
		/// </summary>
		[DataMember(Name="CreditAmountInBaseCurrency", EmitDefaultValue=false)]
		public DecimalValue? CreditAmountInBaseCurrency { get; set; }

		/// <summary>
		/// <para>DAC Field Name: Batch_curyID</para>
		/// <para>DAC: PX.Data.GenericResult</para>
		/// </summary>
		[DataMember(Name="Currency", EmitDefaultValue=false)]
		public StringValue? Currency { get; set; }

		/// <summary>
		/// <para>DAC Field Name: GLTran_referenceID</para>
		/// <para>DAC: PX.Data.GenericResult</para>
		/// </summary>
		[DataMember(Name="CustomerVendor", EmitDefaultValue=false)]
		public StringValue? CustomerVendor { get; set; }

		/// <summary>
		/// <para>DAC Field Name: GLTran_curyDebitAmt</para>
		/// <para>DAC: PX.Data.GenericResult</para>
		/// </summary>
		[DataMember(Name="DebitAmount", EmitDefaultValue=false)]
		public DecimalValue? DebitAmount { get; set; }

		/// <summary>
		/// <para>DAC Field Name: GLTran_debitAmt</para>
		/// <para>DAC: PX.Data.GenericResult</para>
		/// </summary>
		[DataMember(Name="DebitAmountInBaseCurrency", EmitDefaultValue=false)]
		public DecimalValue? DebitAmountInBaseCurrency { get; set; }

		/// <summary>
		/// <para>DAC Field Name: GLTran_lastModifiedDateTime</para>
		/// <para>DAC: PX.Data.GenericResult</para>
		/// </summary>
		[DataMember(Name="LastModifiedDateTime", EmitDefaultValue=false)]
		public DateTimeValue? LastModifiedDateTime { get; set; }

		/// <summary>
		/// <para>DAC Field Name: Batch_ledgerID</para>
		/// <para>DAC: PX.Data.GenericResult</para>
		/// </summary>
		[DataMember(Name="Ledger", EmitDefaultValue=false)]
		public StringValue? Ledger { get; set; }

		/// <summary>
		/// <para>DAC Field Name: GLTran_module</para>
		/// <para>DAC: PX.Data.GenericResult</para>
		/// </summary>
		[DataMember(Name="Module", EmitDefaultValue=false)]
		public StringValue? Module { get; set; }

		/// <summary>
		/// <para>DAC Field Name: GLTran_finPeriodID</para>
		/// <para>DAC: PX.Data.GenericResult</para>
		/// </summary>
		[DataMember(Name="PeriodID", EmitDefaultValue=false)]
		public StringValue? PeriodID { get; set; }

		/// <summary>
		/// <para>DAC Field Name: GLTran_projectID</para>
		/// <para>DAC: PX.Data.GenericResult</para>
		/// </summary>
		[DataMember(Name="Project", EmitDefaultValue=false)]
		public StringValue? Project { get; set; }

		/// <summary>
		/// <para>DAC Field Name: GLTran_taskID</para>
		/// <para>DAC: PX.Data.GenericResult</para>
		/// </summary>
		[DataMember(Name="ProjectTask", EmitDefaultValue=false)]
		public StringValue? ProjectTask { get; set; }

		/// <summary>
		/// <para>DAC Field Name: GLTran_refNbr</para>
		/// <para>DAC: PX.Data.GenericResult</para>
		/// </summary>
		[DataMember(Name="RefNumber", EmitDefaultValue=false)]
		public StringValue? RefNumber { get; set; }

		/// <summary>
		/// <para>DAC Field Name: GLTran_subID</para>
		/// <para>DAC: PX.Data.GenericResult</para>
		/// </summary>
		[DataMember(Name="Subaccount", EmitDefaultValue=false)]
		public StringValue? Subaccount { get; set; }

		/// <summary>
		/// <para>DAC Field Name: GLTran_tranDate</para>
		/// <para>DAC: PX.Data.GenericResult</para>
		/// </summary>
		[DataMember(Name="TransactionDate", EmitDefaultValue=false)]
		public DateTimeValue? TransactionDate { get; set; }

		/// <summary>
		/// <para>DAC Field Name: GLTran_tranDesc</para>
		/// <para>DAC: PX.Data.GenericResult</para>
		/// </summary>
		[DataMember(Name="TransactionDescription", EmitDefaultValue=false)]
		public StringValue? TransactionDescription { get; set; }

		/// <summary>
		/// <para>DAC Field Name: GLTran_tranType</para>
		/// <para>DAC: PX.Data.GenericResult</para>
		/// </summary>
		[DataMember(Name="TransactionType", EmitDefaultValue=false)]
		public StringValue? TransactionType { get; set; }

		/// <summary>
		/// <para>DAC Field Name: GLTran_posted</para>
		/// <para>DAC: PX.Data.GenericResult</para>
		/// </summary>
		[DataMember(Name="Posted", EmitDefaultValue=false)]
		public BooleanValue? Posted { get; set; }

		/// <summary>
		/// <para>DAC Field Name: GLTran_released</para>
		/// <para>DAC: PX.Data.GenericResult</para>
		/// </summary>
		[DataMember(Name="Released", EmitDefaultValue=false)]
		public BooleanValue? Released { get; set; }

	}
}