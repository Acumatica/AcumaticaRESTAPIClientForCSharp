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
	public class AccountDetailsForPeriodInquiryDetail : Entity
	{

		/// <summary>
		/// DAC Field Name: GLTran_accountID 
		/// DAC: PX.Data.GenericResult 
		/// </summary>
		[DataMember(Name="Account", EmitDefaultValue=false)]
		public StringValue? Account { get; set; }

		[DataMember(Name="BatchNumber", EmitDefaultValue=false)]
		public StringValue? BatchNumber { get; set; }

		/// <summary>
		/// DAC Field Name: GLTran_branchID 
		/// DAC: PX.Data.GenericResult 
		/// </summary>
		[DataMember(Name="Branch", EmitDefaultValue=false)]
		public StringValue? Branch { get; set; }

		/// <summary>
		/// DAC Field Name: GLTran_curyCreditAmt 
		/// DAC: PX.Data.GenericResult 
		/// </summary>
		[DataMember(Name="CreditAmount", EmitDefaultValue=false)]
		public DecimalValue? CreditAmount { get; set; }

		/// <summary>
		/// DAC Field Name: GLTran_creditAmt 
		/// DAC: PX.Data.GenericResult 
		/// </summary>
		[DataMember(Name="CreditAmountInBaseCurrency", EmitDefaultValue=false)]
		public DecimalValue? CreditAmountInBaseCurrency { get; set; }

		/// <summary>
		/// DAC Field Name: Batch_curyID 
		/// DAC: PX.Data.GenericResult 
		/// </summary>
		[DataMember(Name="Currency", EmitDefaultValue=false)]
		public StringValue? Currency { get; set; }

		/// <summary>
		/// DAC Field Name: GLTran_referenceID 
		/// DAC: PX.Data.GenericResult 
		/// </summary>
		[DataMember(Name="CustomerVendor", EmitDefaultValue=false)]
		public StringValue? CustomerVendor { get; set; }

		/// <summary>
		/// DAC Field Name: GLTran_curyDebitAmt 
		/// DAC: PX.Data.GenericResult 
		/// </summary>
		[DataMember(Name="DebitAmount", EmitDefaultValue=false)]
		public DecimalValue? DebitAmount { get; set; }

		/// <summary>
		/// DAC Field Name: GLTran_debitAmt 
		/// DAC: PX.Data.GenericResult 
		/// </summary>
		[DataMember(Name="DebitAmountInBaseCurrency", EmitDefaultValue=false)]
		public DecimalValue? DebitAmountInBaseCurrency { get; set; }

		/// <summary>
		/// DAC Field Name: GLTran_lastModifiedDateTime 
		/// DAC: PX.Data.GenericResult 
		/// </summary>
		[DataMember(Name="LastModifiedDateTime", EmitDefaultValue=false)]
		public DateTimeValue? LastModifiedDateTime { get; set; }

		/// <summary>
		/// DAC Field Name: Batch_ledgerID 
		/// DAC: PX.Data.GenericResult 
		/// </summary>
		[DataMember(Name="Ledger", EmitDefaultValue=false)]
		public StringValue? Ledger { get; set; }

		/// <summary>
		/// DAC Field Name: GLTran_module 
		/// DAC: PX.Data.GenericResult 
		/// </summary>
		[DataMember(Name="Module", EmitDefaultValue=false)]
		public StringValue? Module { get; set; }

		/// <summary>
		/// DAC Field Name: GLTran_finPeriodID 
		/// DAC: PX.Data.GenericResult 
		/// </summary>
		[DataMember(Name="PeriodID", EmitDefaultValue=false)]
		public StringValue? PeriodID { get; set; }

		/// <summary>
		/// DAC Field Name: GLTran_projectID 
		/// DAC: PX.Data.GenericResult 
		/// </summary>
		[DataMember(Name="Project", EmitDefaultValue=false)]
		public StringValue? Project { get; set; }

		/// <summary>
		/// DAC Field Name: GLTran_taskID 
		/// DAC: PX.Data.GenericResult 
		/// </summary>
		[DataMember(Name="ProjectTask", EmitDefaultValue=false)]
		public StringValue? ProjectTask { get; set; }

		/// <summary>
		/// DAC Field Name: GLTran_refNbr 
		/// DAC: PX.Data.GenericResult 
		/// </summary>
		[DataMember(Name="RefNumber", EmitDefaultValue=false)]
		public StringValue? RefNumber { get; set; }

		/// <summary>
		/// DAC Field Name: GLTran_subID 
		/// DAC: PX.Data.GenericResult 
		/// </summary>
		[DataMember(Name="Subaccount", EmitDefaultValue=false)]
		public StringValue? Subaccount { get; set; }

		/// <summary>
		/// DAC Field Name: GLTran_tranDate 
		/// DAC: PX.Data.GenericResult 
		/// </summary>
		[DataMember(Name="TransactionDate", EmitDefaultValue=false)]
		public DateTimeValue? TransactionDate { get; set; }

		/// <summary>
		/// DAC Field Name: GLTran_tranDesc 
		/// DAC: PX.Data.GenericResult 
		/// </summary>
		[DataMember(Name="TransactionDescription", EmitDefaultValue=false)]
		public StringValue? TransactionDescription { get; set; }

		/// <summary>
		/// DAC Field Name: GLTran_tranType 
		/// DAC: PX.Data.GenericResult 
		/// </summary>
		[DataMember(Name="TransactionType", EmitDefaultValue=false)]
		public StringValue? TransactionType { get; set; }

		/// <summary>
		/// DAC Field Name: GLTran_posted 
		/// DAC: PX.Data.GenericResult 
		/// </summary>
		[DataMember(Name="Posted", EmitDefaultValue=false)]
		public BooleanValue? Posted { get; set; }

		/// <summary>
		/// DAC Field Name: GLTran_released 
		/// DAC: PX.Data.GenericResult 
		/// </summary>
		[DataMember(Name="Released", EmitDefaultValue=false)]
		public BooleanValue? Released { get; set; }

	}
}