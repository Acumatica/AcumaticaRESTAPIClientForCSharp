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
	public class ContractUsageTransactionDetail : Entity
	{

		/// <summary>
		/// The date on which the transaction was billed.
		/// <para>DAC Field Name: BilledDate</para>
		/// <para>DAC: PX.Objects.PM.PMTran</para>
		/// <para>Display Name: Billed Date</para>
		/// </summary>
		[DataMember(Name="BillingDate", EmitDefaultValue=false)]
		public DateTimeValue? BillingDate { get; set; }

		/// <summary>
		/// The identifier of the Branch to which the transaction belongs.
		/// <para>DAC Field Name: BranchID</para>
		/// <para>DAC: PX.Objects.PM.PMTran</para>
		/// </summary>
		[DataMember(Name="Branch", EmitDefaultValue=false)]
		public StringValue? Branch { get; set; }

		/// <summary>
		/// <para>DAC Field Name: CRCase__CaseCD</para>
		/// <para>DAC: PX.Objects.PM.PMTran</para>
		/// </summary>
		[DataMember(Name="CaseID", EmitDefaultValue=false)]
		public StringValue? CaseID { get; set; }

		/// <summary>
		/// The date of the transaction, which is specified by the user.
		/// <para>DAC: PX.Objects.PM.PMTran</para>
		/// </summary>
		[DataMember(Name="Date", EmitDefaultValue=false)]
		public DateTimeValue? Date { get; set; }

		/// <summary>
		/// The description provided for the transaction.
		/// <para>DAC: PX.Objects.PM.PMTran</para>
		/// <para>SQL Type: nvarchar(256)</para>
		/// </summary>
		[DataMember(Name="Description", EmitDefaultValue=false)]
		public StringValue? Description { get; set; }

		/// <summary>
		/// The transaction end date.
		/// <para>DAC: PX.Objects.PM.PMTran</para>
		/// <para>Display Name: End Date</para>
		/// </summary>
		[DataMember(Name="EndDate", EmitDefaultValue=false)]
		public DateTimeValue? EndDate { get; set; }

		/// <summary>
		/// The identifier of the stock or non-stock item associated with the transaction.
		/// <para>DAC: PX.Objects.PM.PMTran</para>
		/// <para>Display Name: Inventory ID</para>
		/// </summary>
		[DataMember(Name="InventoryID", EmitDefaultValue=false)]
		public StringValue? InventoryID { get; set; }

		/// <summary>
		/// The quantity that is used for billing the customer.
		/// <para>DAC Field Name: BillableQty</para>
		/// <para>DAC: PX.Objects.PM.PMTran</para>
		/// <para>Display Name: Billable Quantity</para>
		/// </summary>
		[DataMember(Name="Qty", EmitDefaultValue=false)]
		public DecimalValue? Qty { get; set; }

		/// <summary>
		/// The reference number of the accounts receivable document associated with the transaction.
		/// <para>DAC Field Name: ARRefNbr</para>
		/// <para>DAC: PX.Objects.PM.PMTran</para>
		/// <para>Display Name: AR Reference Nbr.</para>
		/// <para>SQL Type: nvarchar(15)</para>
		/// </summary>
		[DataMember(Name="ReferenceNbr", EmitDefaultValue=false)]
		public StringValue? ReferenceNbr { get; set; }

		/// <summary>
		/// The transaction start date.
		/// <para>DAC: PX.Objects.PM.PMTran</para>
		/// <para>Display Name: Start Date</para>
		/// </summary>
		[DataMember(Name="StartDate", EmitDefaultValue=false)]
		public DateTimeValue? StartDate { get; set; }

		[DataMember(Name="TransactionID", EmitDefaultValue=false)]
		public LongValue? TransactionID { get; set; }

		/// <summary>
		/// The type of the accounts receivable document associated with the transaction.
		/// <para>DAC Field Name: ARTranType</para>
		/// <para>DAC: PX.Objects.PM.PMTran</para>
		/// <para>SQL Type: char(3)</para>
		/// </summary>
		[DataMember(Name="Type", EmitDefaultValue=false)]
		public StringValue? Type { get; set; }

		/// <summary>
		/// The unit of measure used to estimate the quantity for the transaction.
		/// <para>DAC: PX.Objects.PM.PMTran</para>
		/// <para>SQL Type: nvarchar(6)</para>
		/// </summary>
		[DataMember(Name="UOM", EmitDefaultValue=false)]
		public StringValue? UOM { get; set; }

	}
}