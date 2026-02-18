using System;
using System.Collections.Generic;

using Newtonsoft.Json;

using Acumatica.RESTClient.Client;
using Acumatica.RESTClient.ContractBasedApi;
using Acumatica.RESTClient.ContractBasedApi.Model;

namespace Acumatica.Default_24_200_001.Model
{
	public class JournalTransactionDetail : Entity
	{

		/// <summary>
		/// Identifier of the Account of the transaction.
		/// <para>DAC Field Name: AccountID</para>
		/// <para>DAC: PX.Objects.GL.GLTran</para>
		/// </summary>
		public StringValue? Account { get; set; }

		/// <summary>
		/// Identifier of the Branch, to which the batch belongs.
		/// <para>DAC: PX.Objects.GL.Batch</para>
		/// <para>Display Name: Branch</para>
		/// </summary>
		public StringValue? BranchID { get; set; }

		/// <summary>
		/// <para>DAC Field Name: CostCodeID</para>
		/// <para>DAC: PX.Objects.GL.GLTran</para>
		/// <para>Display Name: Cost Code</para>
		/// </summary>
		public StringValue? CostCode { get; set; }

		/// <summary>
		/// The credit amount of the transaction.Given in the currency of the batch.See also the CreditAmt field.
		/// <para>DAC Field Name: CuryCreditAmt</para>
		/// <para>DAC: PX.Objects.GL.GLTran</para>
		/// <para>Display Name: Credit Amount</para>
		/// </summary>
		public DecimalValue? CreditAmount { get; set; }

		/// <summary>
		/// The debit amount of the transaction.Given in the currency of the batch.See also the DebitAmt field.
		/// <para>DAC Field Name: CuryDebitAmt</para>
		/// <para>DAC: PX.Objects.GL.GLTran</para>
		/// <para>Display Name: Debit Amount</para>
		/// </summary>
		public DecimalValue? DebitAmount { get; set; }

		/// <summary>
		/// <para>DAC Field Name: AccountID_Account_description</para>
		/// <para>DAC: PX.Objects.GL.GLTran</para>
		/// </summary>
		public StringValue? Description { get; set; }

		public BooleanValue? IsNonPM { get; set; }

		/// <summary>
		/// Key field. Auto-generated.The number of the transaction in the Batch.
		/// <para>DAC: PX.Objects.GL.GLTran</para>
		/// <para>Display Name: Line Nbr.</para>
		/// Key Field
		/// </summary>
		public IntValue? LineNbr { get; set; }

		/// <summary>
		/// When set to true, indicates that the transaction is non-billable in the ProjectThis means that when releasing the batch the system will set the Billable field ofthe project transaction generated from this transaction to false.This field is relevant only if the Projects module has been activated and integrated with the General Ledger module.
		/// <para>DAC: PX.Objects.GL.GLTran</para>
		/// <para>Display Name: Non Billable</para>
		/// </summary>
		public BooleanValue? NonBillable { get; set; }

		/// <summary>
		/// Identifier of the Project associated with the transaction,or the non-project code indicating that the transaction is not related to any particular project.
		/// <para>DAC Field Name: ProjectID</para>
		/// <para>DAC: PX.Objects.GL.GLTran</para>
		/// </summary>
		public StringValue? Project { get; set; }

		/// <summary>
		/// Identifier of the Task associated with the transaction.The field is relevant only if the Projects module has been activated.
		/// <para>DAC Field Name: TaskID</para>
		/// <para>DAC: PX.Objects.GL.GLTran</para>
		/// <para>Display Name: Project Task</para>
		/// </summary>
		public StringValue? ProjectTask { get; set; }

		/// <summary>
		/// Identifier of the Project Transaction associated with this transaction.
		/// <para>DAC Field Name: PMTranID</para>
		/// <para>DAC: PX.Objects.GL.GLTran</para>
		/// <para>Display Name: PM Tran.</para>
		/// </summary>
		public LongValue? ProjectTransactionID { get; set; }

		/// <summary>
		/// The quantity of the transaction.
		/// <para>DAC: PX.Objects.GL.GLTran</para>
		/// <para>Display Name: Quantity</para>
		/// </summary>
		public DecimalValue? Qty { get; set; }

		/// <summary>
		/// The reference number of the transaction.
		/// <para>DAC Field Name: RefNbr</para>
		/// <para>DAC: PX.Objects.GL.GLTran</para>
		/// <para>Display Name: Ref. Number</para>
		/// <para>SQL Type: nvarchar(15)</para>
		/// </summary>
		public StringValue? ReferenceNbr { get; set; }

		/// <summary>
		/// Identifier of the Subaccount of the transaction.
		/// <para>DAC Field Name: SubID</para>
		/// <para>DAC: PX.Objects.GL.GLTran</para>
		/// </summary>
		public StringValue? Subaccount { get; set; }

		/// <summary>
		/// The description of the transaction.
		/// <para>DAC Field Name: TranDesc</para>
		/// <para>DAC: PX.Objects.GL.GLTran</para>
		/// <para>Display Name: Transaction Description</para>
		/// <para>SQL Type: nvarchar(512)</para>
		/// </summary>
		public StringValue? TransactionDescription { get; set; }

		/// <summary>
		/// The code of the Unit of Measure for the qunatity of the transaction.
		/// <para>DAC: PX.Objects.GL.GLTran</para>
		/// <para>SQL Type: nvarchar(6)</para>
		/// </summary>
		public StringValue? UOM { get; set; }

		/// <summary>
		/// Identifier of the Customer or Vendorassociated with the transaction.This field is populated when a document is released in Accounts Receivable or Accounts Payable module.
		/// <para>DAC Field Name: ReferenceID</para>
		/// <para>DAC: PX.Objects.GL.GLTran</para>
		/// <para>Display Name: Customer/Vendor</para>
		/// </summary>
		public StringValue? VendorOrCustomer { get; set; }

	}
}