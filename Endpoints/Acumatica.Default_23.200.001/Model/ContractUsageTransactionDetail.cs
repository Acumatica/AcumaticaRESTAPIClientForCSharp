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
		/// DAC Field Name: BilledDate 
		/// DAC: PX.Objects.PM.PMTran 
		/// Display Name: Billed Date 
		/// </summary>
		[DataMember(Name="BillingDate", EmitDefaultValue=false)]
		public DateTimeValue? BillingDate { get; set; }

		/// <summary>
		/// The identifier of the Branch to which the transaction belongs.
		/// DAC Field Name: BranchID 
		/// DAC: PX.Objects.PM.PMTran 
		/// </summary>
		[DataMember(Name="Branch", EmitDefaultValue=false)]
		public StringValue? Branch { get; set; }

		/// <summary>
		/// DAC Field Name: CRCase__CaseCD 
		/// DAC: PX.Objects.PM.PMTran 
		/// </summary>
		[DataMember(Name="CaseID", EmitDefaultValue=false)]
		public StringValue? CaseID { get; set; }

		/// <summary>
		/// The date of the transaction, which is specified by the user.
		/// DAC: PX.Objects.PM.PMTran 
		/// </summary>
		[DataMember(Name="Date", EmitDefaultValue=false)]
		public DateTimeValue? Date { get; set; }

		/// <summary>
		/// The description provided for the transaction.
		/// DAC: PX.Objects.PM.PMTran 
		/// SQL Type: nvarchar(256) 
		/// </summary>
		[DataMember(Name="Description", EmitDefaultValue=false)]
		public StringValue? Description { get; set; }

		/// <summary>
		/// The transaction end date.
		/// DAC: PX.Objects.PM.PMTran 
		/// Display Name: End Date 
		/// </summary>
		[DataMember(Name="EndDate", EmitDefaultValue=false)]
		public DateTimeValue? EndDate { get; set; }

		/// <summary>
		/// The identifier of the stock or non-stock item associated with the transaction.
		/// DAC: PX.Objects.PM.PMTran 
		/// Display Name: Inventory ID 
		/// </summary>
		[DataMember(Name="InventoryID", EmitDefaultValue=false)]
		public StringValue? InventoryID { get; set; }

		/// <summary>
		/// The quantity that is used for billing the customer.
		/// DAC Field Name: BillableQty 
		/// DAC: PX.Objects.PM.PMTran 
		/// Display Name: Billable Quantity 
		/// </summary>
		[DataMember(Name="Qty", EmitDefaultValue=false)]
		public DecimalValue? Qty { get; set; }

		/// <summary>
		/// The reference number of the accounts receivable document associated with the transaction.
		/// DAC Field Name: ARRefNbr 
		/// DAC: PX.Objects.PM.PMTran 
		/// Display Name: AR Reference Nbr. 
		/// SQL Type: nvarchar(15) 
		/// </summary>
		[DataMember(Name="ReferenceNbr", EmitDefaultValue=false)]
		public StringValue? ReferenceNbr { get; set; }

		/// <summary>
		/// The transaction start date.
		/// DAC: PX.Objects.PM.PMTran 
		/// Display Name: Start Date 
		/// </summary>
		[DataMember(Name="StartDate", EmitDefaultValue=false)]
		public DateTimeValue? StartDate { get; set; }

		[DataMember(Name="TransactionID", EmitDefaultValue=false)]
		public LongValue? TransactionID { get; set; }

		/// <summary>
		/// The type of the accounts receivable document associated with the transaction.
		/// DAC Field Name: ARTranType 
		/// DAC: PX.Objects.PM.PMTran 
		/// SQL Type: char(3) 
		/// </summary>
		[DataMember(Name="Type", EmitDefaultValue=false)]
		public StringValue? Type { get; set; }

		/// <summary>
		/// The unit of measure used to estimate the quantity for the transaction.
		/// DAC: PX.Objects.PM.PMTran 
		/// SQL Type: nvarchar(6) 
		/// </summary>
		[DataMember(Name="UOM", EmitDefaultValue=false)]
		public StringValue? UOM { get; set; }

	}
}