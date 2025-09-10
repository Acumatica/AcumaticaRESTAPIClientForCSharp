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
	public class JournalTransactionDetail : Entity
	{

		/// <summary>
		/// Identifier of the Account of the transaction.
		/// DAC Field Name: AccountID 
		/// DAC: PX.Objects.GL.GLTran 
		/// </summary>
		[DataMember(Name="Account", EmitDefaultValue=false)]
		public StringValue? Account { get; set; }

		/// <summary>
		/// Identifier of the Branch, to which the batch belongs.
		/// DAC: PX.Objects.GL.Batch 
		/// Display Name: Branch 
		/// </summary>
		[DataMember(Name="BranchID", EmitDefaultValue=false)]
		public StringValue? BranchID { get; set; }

		/// <summary>
		/// DAC Field Name: CostCodeID 
		/// DAC: PX.Objects.GL.GLTran 
		/// Display Name: Cost Code 
		/// </summary>
		[DataMember(Name="CostCode", EmitDefaultValue=false)]
		public StringValue? CostCode { get; set; }

		/// <summary>
		/// The credit amount of the transaction.Given in the currency of the batch.See also the CreditAmt field.
		/// DAC Field Name: CuryCreditAmt 
		/// DAC: PX.Objects.GL.GLTran 
		/// Display Name: Credit Amount 
		/// </summary>
		[DataMember(Name="CreditAmount", EmitDefaultValue=false)]
		public DecimalValue? CreditAmount { get; set; }

		/// <summary>
		/// The debit amount of the transaction.Given in the currency of the batch.See also the DebitAmt field.
		/// DAC Field Name: CuryDebitAmt 
		/// DAC: PX.Objects.GL.GLTran 
		/// Display Name: Debit Amount 
		/// </summary>
		[DataMember(Name="DebitAmount", EmitDefaultValue=false)]
		public DecimalValue? DebitAmount { get; set; }

		/// <summary>
		/// DAC Field Name: AccountID_Account_description 
		/// DAC: PX.Objects.GL.GLTran 
		/// </summary>
		[DataMember(Name="Description", EmitDefaultValue=false)]
		public StringValue? Description { get; set; }

		[DataMember(Name="IsNonPM", EmitDefaultValue=false)]
		public BooleanValue? IsNonPM { get; set; }

		/// <summary>
		/// Key field. Auto-generated.The number of the transaction in the Batch.
		/// DAC: PX.Objects.GL.GLTran 
		/// Display Name: Line Nbr. 
		/// Key Field
		/// </summary>
		[DataMember(Name="LineNbr", EmitDefaultValue=false)]
		public IntValue? LineNbr { get; set; }

		/// <summary>
		/// When set to true, indicates that the transaction is non-billable in the ProjectThis means that when releasing the batch the system will set the Billable field ofthe project transaction generated from this transaction to false.This field is relevant only if the Projects module has been activated and integrated with the General Ledger module.
		/// DAC: PX.Objects.GL.GLTran 
		/// Display Name: Non Billable 
		/// </summary>
		[DataMember(Name="NonBillable", EmitDefaultValue=false)]
		public BooleanValue? NonBillable { get; set; }

		/// <summary>
		/// Identifier of the Project associated with the transaction,or the non-project code indicating that the transaction is not related to any particular project.
		/// DAC Field Name: ProjectID 
		/// DAC: PX.Objects.GL.GLTran 
		/// </summary>
		[DataMember(Name="Project", EmitDefaultValue=false)]
		public StringValue? Project { get; set; }

		/// <summary>
		/// Identifier of the Task associated with the transaction.The field is relevant only if the Projects module has been activated.
		/// DAC Field Name: TaskID 
		/// DAC: PX.Objects.GL.GLTran 
		/// Display Name: Project Task 
		/// </summary>
		[DataMember(Name="ProjectTask", EmitDefaultValue=false)]
		public StringValue? ProjectTask { get; set; }

		/// <summary>
		/// Identifier of the Project Transaction associated with this transaction.
		/// DAC Field Name: PMTranID 
		/// DAC: PX.Objects.GL.GLTran 
		/// Display Name: Project Tran. ID 
		/// </summary>
		[DataMember(Name="ProjectTransactionID", EmitDefaultValue=false)]
		public LongValue? ProjectTransactionID { get; set; }

		/// <summary>
		/// The quantity of the transaction.
		/// DAC: PX.Objects.GL.GLTran 
		/// Display Name: Quantity 
		/// </summary>
		[DataMember(Name="Qty", EmitDefaultValue=false)]
		public DecimalValue? Qty { get; set; }

		/// <summary>
		/// The reference number of the transaction.
		/// DAC Field Name: RefNbr 
		/// DAC: PX.Objects.GL.GLTran 
		/// Display Name: Ref. Number 
		/// SQL Type: nvarchar(15) 
		/// </summary>
		[DataMember(Name="ReferenceNbr", EmitDefaultValue=false)]
		public StringValue? ReferenceNbr { get; set; }

		/// <summary>
		/// Identifier of the Subaccount of the transaction.
		/// DAC Field Name: SubID 
		/// DAC: PX.Objects.GL.GLTran 
		/// </summary>
		[DataMember(Name="Subaccount", EmitDefaultValue=false)]
		public StringValue? Subaccount { get; set; }

		/// <summary>
		/// The description of the transaction.
		/// DAC Field Name: TranDesc 
		/// DAC: PX.Objects.GL.GLTran 
		/// Display Name: Transaction Description 
		/// SQL Type: nvarchar(512) 
		/// </summary>
		[DataMember(Name="TransactionDescription", EmitDefaultValue=false)]
		public StringValue? TransactionDescription { get; set; }

		/// <summary>
		/// The code of the Unit of Measure for the qunatity of the transaction.
		/// DAC: PX.Objects.GL.GLTran 
		/// SQL Type: nvarchar(6) 
		/// </summary>
		[DataMember(Name="UOM", EmitDefaultValue=false)]
		public StringValue? UOM { get; set; }

		/// <summary>
		/// Identifier of the Customer or Vendorassociated with the transaction.This field is populated when a document is released in Accounts Receivable or Accounts Payable module.
		/// DAC Field Name: ReferenceID 
		/// DAC: PX.Objects.GL.GLTran 
		/// Display Name: Customer/Vendor 
		/// </summary>
		[DataMember(Name="VendorOrCustomer", EmitDefaultValue=false)]
		public StringValue? VendorOrCustomer { get; set; }

	}
}