using System;
using System.Collections.Generic;

using Newtonsoft.Json;

using Acumatica.RESTClient.Client;
using Acumatica.RESTClient.ContractBasedApi;
using Acumatica.RESTClient.ContractBasedApi.Model;

namespace Acumatica.Default_23_200_001.Model
{
	/// <summary>
	/// Corresponds to the screen <c>PM209000</c> in the Acumatica ERP
	/// </summary>
	public class ExternalCommitment : Entity, ITopLevelEntity
	{

		/// <summary>
		/// The account group of the commitment.
		/// <para>DAC Field Name: AccountGroupID</para>
		/// <para>DAC: PX.Objects.PM.PMCommitment</para>
		/// <para>Display Name: Account Group</para>
		/// </summary>
		public StringValue? AccountGroup { get; set; }

		public DecimalValue? CommittedCOAmount { get; set; }

		public DecimalValue? CommittedCOQty { get; set; }

		/// <summary>
		/// The invoiced amount of the commitment.
		/// <para>DAC Field Name: InvoicedAmount</para>
		/// <para>DAC: PX.Objects.PM.PMCommitment</para>
		/// <para>Display Name: Committed Invoiced Amount</para>
		/// </summary>
		public DecimalValue? CommittedInvoicedAmount { get; set; }

		/// <summary>
		/// The invoiced quantity of the commitment.
		/// <para>DAC Field Name: InvoicedQty</para>
		/// <para>DAC: PX.Objects.PM.PMCommitment</para>
		/// <para>Display Name: Committed Invoiced Quantity</para>
		/// </summary>
		public DecimalValue? CommittedInvoicedQty { get; set; }

		/// <summary>
		/// The open amount of the commitment that has not been received yet.
		/// <para>DAC Field Name: OpenAmount</para>
		/// <para>DAC: PX.Objects.PM.PMCommitment</para>
		/// <para>Display Name: Committed Open Amount</para>
		/// </summary>
		public DecimalValue? CommittedOpenAmount { get; set; }

		/// <summary>
		/// The open quantity of the commitment that has not been received yet.
		/// <para>DAC Field Name: OpenQty</para>
		/// <para>DAC: PX.Objects.PM.PMCommitment</para>
		/// <para>Display Name: Committed Open Quantity</para>
		/// </summary>
		public DecimalValue? CommittedOpenQty { get; set; }

		/// <summary>
		/// The received quantity of the commitment.
		/// <para>DAC Field Name: ReceivedQty</para>
		/// <para>DAC: PX.Objects.PM.PMCommitment</para>
		/// <para>Display Name: Committed Received Quantity</para>
		/// </summary>
		public DecimalValue? CommittedReceivedQty { get; set; }

		/// <summary>
		/// The cost code of the commitment.
		/// <para>DAC Field Name: CostCodeID</para>
		/// <para>DAC: PX.Objects.PM.PMCommitment</para>
		/// <para>Display Name: Cost Code</para>
		/// </summary>
		public StringValue? CostCode { get; set; }

		/// <summary>
		/// The reference number of the commitment of the external type.
		/// <para>DAC Field Name: ExtRefNbr</para>
		/// <para>DAC: PX.Objects.PM.PMCommitment</para>
		/// <para>Display Name: External Ref. Nbr</para>
		/// <para>SQL Type: nvarchar(15)</para>
		/// </summary>
		public StringValue? ExternalRefNbr { get; set; }

		/// <summary>
		/// The inventory item of the commitment.
		/// <para>DAC: PX.Objects.PM.PMCommitment</para>
		/// <para>Display Name: Inventory ID</para>
		/// </summary>
		public StringValue? InventoryID { get; set; }

		public DateTimeValue? LastModifiedDateTime { get; set; }

		/// <summary>
		/// The original amount of the commitment.
		/// <para>DAC Field Name: OrigAmount</para>
		/// <para>DAC: PX.Objects.PM.PMCommitment</para>
		/// <para>Display Name: Original Committed Amount</para>
		/// </summary>
		public DecimalValue? OriginalCommittedAmount { get; set; }

		/// <summary>
		/// The original quantity of the commitment.
		/// <para>DAC Field Name: OrigQty</para>
		/// <para>DAC: PX.Objects.PM.PMCommitment</para>
		/// <para>Display Name: Original Committed Quantity</para>
		/// </summary>
		public DecimalValue? OriginalCommittedQty { get; set; }

		/// <summary>
		/// The project associated with the commitment.
		/// <para>DAC: PX.Objects.PM.PMCommitment</para>
		/// <para>Display Name: Project</para>
		/// </summary>
		public StringValue? ProjectID { get; set; }

		/// <summary>
		/// The project task associated with the commitment.
		/// <para>DAC: PX.Objects.PM.PMCommitment</para>
		/// <para>Display Name: Project Task</para>
		/// </summary>
		public StringValue? ProjectTaskID { get; set; }

		public StringValue? RelatedDocument { get; set; }

		/// <summary>
		/// The revised amount of the commitment.
		/// <para>DAC Field Name: Amount</para>
		/// <para>DAC: PX.Objects.PM.PMCommitment</para>
		/// <para>Display Name: Revised Committed Amount</para>
		/// </summary>
		public DecimalValue? RevisedCommittedAmount { get; set; }

		/// <summary>
		/// The revised quantity of the commitment.
		/// <para>DAC Field Name: Qty</para>
		/// <para>DAC: PX.Objects.PM.PMCommitment</para>
		/// <para>Display Name: Revised Committed Quantity</para>
		/// </summary>
		public DecimalValue? RevisedCommittedQty { get; set; }

		public StringValue? Type { get; set; }

		/// <summary>
		/// The unit of measure of the commitment.
		/// <para>DAC: PX.Objects.PM.PMCommitment</para>
		/// <para>SQL Type: nvarchar(6)</para>
		/// </summary>
		public StringValue? UOM { get; set; }

		public static class Expand
		{
			public const string Files = "Files";
			public const string Translations = "Translations";

			//Intentionally excluded
			//public const string All = "Files,Translations";
		}
		public virtual string GetEndpointPath()
		{
			return "entity/Default/23.200.001";
		}
	}
}