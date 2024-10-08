using System;
using System.Collections.Generic;
using System.Runtime.Serialization;

using Newtonsoft.Json;

using Acumatica.RESTClient.Client;
using Acumatica.RESTClient.ContractBasedApi;
using Acumatica.RESTClient.ContractBasedApi.Model;

namespace Acumatica.Default_23_200_001.Model
{
	/// <summary>
	/// Corresponds to the screen PM209000 in the Acumatica ERP
	/// </summary>
	[DataContract]
	public class ExternalCommitment : Entity, ITopLevelEntity
	{

		/// <summary>
		/// The account group of the commitment.
		/// DAC Field Name: AccountGroupID 
		/// DAC: PX.Objects.PM.PMCommitment 
		/// Display Name: Account Group 
		/// </summary>
		[DataMember(Name="AccountGroup", EmitDefaultValue=false)]
		public StringValue? AccountGroup { get; set; }

		[DataMember(Name="CommittedCOAmount", EmitDefaultValue=false)]
		public DecimalValue? CommittedCOAmount { get; set; }

		[DataMember(Name="CommittedCOQty", EmitDefaultValue=false)]
		public DecimalValue? CommittedCOQty { get; set; }

		/// <summary>
		/// The invoiced amount of the commitment.
		/// DAC Field Name: InvoicedAmount 
		/// DAC: PX.Objects.PM.PMCommitment 
		/// Display Name: Committed Invoiced Amount 
		/// </summary>
		[DataMember(Name="CommittedInvoicedAmount", EmitDefaultValue=false)]
		public DecimalValue? CommittedInvoicedAmount { get; set; }

		/// <summary>
		/// The invoiced quantity of the commitment.
		/// DAC Field Name: InvoicedQty 
		/// DAC: PX.Objects.PM.PMCommitment 
		/// Display Name: Committed Invoiced Quantity 
		/// </summary>
		[DataMember(Name="CommittedInvoicedQty", EmitDefaultValue=false)]
		public DecimalValue? CommittedInvoicedQty { get; set; }

		/// <summary>
		/// The open amount of the commitment that has not been received yet.
		/// DAC Field Name: OpenAmount 
		/// DAC: PX.Objects.PM.PMCommitment 
		/// Display Name: Committed Open Amount 
		/// </summary>
		[DataMember(Name="CommittedOpenAmount", EmitDefaultValue=false)]
		public DecimalValue? CommittedOpenAmount { get; set; }

		/// <summary>
		/// The open quantity of the commitment that has not been received yet.
		/// DAC Field Name: OpenQty 
		/// DAC: PX.Objects.PM.PMCommitment 
		/// Display Name: Committed Open Quantity 
		/// </summary>
		[DataMember(Name="CommittedOpenQty", EmitDefaultValue=false)]
		public DecimalValue? CommittedOpenQty { get; set; }

		/// <summary>
		/// The received quantity of the commitment.
		/// DAC Field Name: ReceivedQty 
		/// DAC: PX.Objects.PM.PMCommitment 
		/// Display Name: Committed Received Quantity 
		/// </summary>
		[DataMember(Name="CommittedReceivedQty", EmitDefaultValue=false)]
		public DecimalValue? CommittedReceivedQty { get; set; }

		/// <summary>
		/// The cost code of the commitment.
		/// DAC Field Name: CostCodeID 
		/// DAC: PX.Objects.PM.PMCommitment 
		/// Display Name: Cost Code 
		/// </summary>
		[DataMember(Name="CostCode", EmitDefaultValue=false)]
		public StringValue? CostCode { get; set; }

		/// <summary>
		/// The reference number of the commitment of the external type.
		/// DAC Field Name: ExtRefNbr 
		/// DAC: PX.Objects.PM.PMCommitment 
		/// Display Name: External Ref. Nbr 
		/// SQL Type: nvarchar(15) 
		/// </summary>
		[DataMember(Name="ExternalRefNbr", EmitDefaultValue=false)]
		public StringValue? ExternalRefNbr { get; set; }

		/// <summary>
		/// The inventory item of the commitment.
		/// DAC: PX.Objects.PM.PMCommitment 
		/// Display Name: Inventory ID 
		/// </summary>
		[DataMember(Name="InventoryID", EmitDefaultValue=false)]
		public StringValue? InventoryID { get; set; }

		[DataMember(Name="LastModifiedDateTime", EmitDefaultValue=false)]
		public DateTimeValue? LastModifiedDateTime { get; set; }

		/// <summary>
		/// The original amount of the commitment.
		/// DAC Field Name: OrigAmount 
		/// DAC: PX.Objects.PM.PMCommitment 
		/// Display Name: Original Committed Amount 
		/// </summary>
		[DataMember(Name="OriginalCommittedAmount", EmitDefaultValue=false)]
		public DecimalValue? OriginalCommittedAmount { get; set; }

		/// <summary>
		/// The original quantity of the commitment.
		/// DAC Field Name: OrigQty 
		/// DAC: PX.Objects.PM.PMCommitment 
		/// Display Name: Original Committed Quantity 
		/// </summary>
		[DataMember(Name="OriginalCommittedQty", EmitDefaultValue=false)]
		public DecimalValue? OriginalCommittedQty { get; set; }

		/// <summary>
		/// The project associated with the commitment.
		/// DAC: PX.Objects.PM.PMCommitment 
		/// Display Name: Project 
		/// </summary>
		[DataMember(Name="ProjectID", EmitDefaultValue=false)]
		public StringValue? ProjectID { get; set; }

		/// <summary>
		/// The project task associated with the commitment.
		/// DAC: PX.Objects.PM.PMCommitment 
		/// Display Name: Project Task 
		/// </summary>
		[DataMember(Name="ProjectTaskID", EmitDefaultValue=false)]
		public StringValue? ProjectTaskID { get; set; }

		[DataMember(Name="RelatedDocument", EmitDefaultValue=false)]
		public StringValue? RelatedDocument { get; set; }

		/// <summary>
		/// The revised amount of the commitment.
		/// DAC Field Name: Amount 
		/// DAC: PX.Objects.PM.PMCommitment 
		/// Display Name: Revised Committed Amount 
		/// </summary>
		[DataMember(Name="RevisedCommittedAmount", EmitDefaultValue=false)]
		public DecimalValue? RevisedCommittedAmount { get; set; }

		/// <summary>
		/// The revised quantity of the commitment.
		/// DAC Field Name: Qty 
		/// DAC: PX.Objects.PM.PMCommitment 
		/// Display Name: Revised Committed Quantity 
		/// </summary>
		[DataMember(Name="RevisedCommittedQty", EmitDefaultValue=false)]
		public DecimalValue? RevisedCommittedQty { get; set; }

		[DataMember(Name="Type", EmitDefaultValue=false)]
		public StringValue? Type { get; set; }

		/// <summary>
		/// The unit of measure of the commitment.
		/// DAC: PX.Objects.PM.PMCommitment 
		/// SQL Type: nvarchar(6) 
		/// </summary>
		[DataMember(Name="UOM", EmitDefaultValue=false)]
		public StringValue? UOM { get; set; }

		public virtual string GetEndpointPath()
		{
			return "entity/Default/23.200.001";
		}
	}
}