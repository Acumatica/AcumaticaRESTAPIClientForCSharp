using System;
using System.Collections.Generic;
using System.Runtime.Serialization;

using Newtonsoft.Json;

using Acumatica.RESTClient.Client;
using Acumatica.RESTClient.ContractBasedApi;
using Acumatica.RESTClient.ContractBasedApi.Model;

namespace Acumatica.Default_24_200_001.Model
{
	/// <summary>
	/// Corresponds to the screen PM209000 in the Acumatica ERP
	/// </summary>
	[DataContract]
	public class ExternalCommitment : Entity, ITopLevelEntity
	{

		/// <summary>
		/// 
		/// Display Name:
		/// DAC Field Name: AccountGroupID 
		/// DAC: PX.Objects.PM.PMCommitment 
		/// </summary>
		/// <remarks>
		/// 
		/// </remarks>
		[DataMember(Name="AccountGroup", EmitDefaultValue=false)]
		public StringValue? AccountGroup { get; set; }

		[DataMember(Name="CommittedCOAmount", EmitDefaultValue=false)]
		public DecimalValue? CommittedCOAmount { get; set; }

		[DataMember(Name="CommittedCOQty", EmitDefaultValue=false)]
		public DecimalValue? CommittedCOQty { get; set; }

		/// <summary>
		/// 
		/// Display Name:
		/// DAC Field Name: InvoicedAmount 
		/// DAC: PX.Objects.PM.PMCommitment 
		/// </summary>
		/// <remarks>
		/// 
		/// </remarks>
		[DataMember(Name="CommittedInvoicedAmount", EmitDefaultValue=false)]
		public DecimalValue? CommittedInvoicedAmount { get; set; }

		/// <summary>
		/// 
		/// Display Name:
		/// DAC Field Name: InvoicedQty 
		/// DAC: PX.Objects.PM.PMCommitment 
		/// </summary>
		/// <remarks>
		/// 
		/// </remarks>
		[DataMember(Name="CommittedInvoicedQty", EmitDefaultValue=false)]
		public DecimalValue? CommittedInvoicedQty { get; set; }

		/// <summary>
		/// 
		/// Display Name:
		/// DAC Field Name: OpenAmount 
		/// DAC: PX.Objects.PM.PMCommitment 
		/// </summary>
		/// <remarks>
		/// 
		/// </remarks>
		[DataMember(Name="CommittedOpenAmount", EmitDefaultValue=false)]
		public DecimalValue? CommittedOpenAmount { get; set; }

		/// <summary>
		/// 
		/// Display Name:
		/// DAC Field Name: OpenQty 
		/// DAC: PX.Objects.PM.PMCommitment 
		/// </summary>
		/// <remarks>
		/// 
		/// </remarks>
		[DataMember(Name="CommittedOpenQty", EmitDefaultValue=false)]
		public DecimalValue? CommittedOpenQty { get; set; }

		/// <summary>
		/// 
		/// Display Name:
		/// DAC Field Name: ReceivedQty 
		/// DAC: PX.Objects.PM.PMCommitment 
		/// </summary>
		/// <remarks>
		/// 
		/// </remarks>
		[DataMember(Name="CommittedReceivedQty", EmitDefaultValue=false)]
		public DecimalValue? CommittedReceivedQty { get; set; }

		/// <summary>
		/// 
		/// Display Name:
		/// DAC Field Name: CostCodeID 
		/// DAC: PX.Objects.PM.PMCommitment 
		/// </summary>
		/// <remarks>
		/// 
		/// </remarks>
		[DataMember(Name="CostCode", EmitDefaultValue=false)]
		public StringValue? CostCode { get; set; }

		/// <summary>
		/// 
		/// Display Name:
		/// DAC Field Name: ExtRefNbr 
		/// DAC: PX.Objects.PM.PMCommitment 
		/// </summary>
		/// <remarks>
		/// 
		/// </remarks>
		[DataMember(Name="ExternalRefNbr", EmitDefaultValue=false)]
		public StringValue? ExternalRefNbr { get; set; }

		/// <summary>
		/// 
		/// Display Name:
		/// DAC Field Name: InventoryID 
		/// DAC: PX.Objects.PM.PMCommitment 
		/// </summary>
		/// <remarks>
		/// 
		/// </remarks>
		[DataMember(Name="InventoryID", EmitDefaultValue=false)]
		public StringValue? InventoryID { get; set; }

		[DataMember(Name="LastModifiedDateTime", EmitDefaultValue=false)]
		public DateTimeValue? LastModifiedDateTime { get; set; }

		/// <summary>
		/// 
		/// Display Name:
		/// DAC Field Name: OrigAmount 
		/// DAC: PX.Objects.PM.PMCommitment 
		/// </summary>
		/// <remarks>
		/// 
		/// </remarks>
		[DataMember(Name="OriginalCommittedAmount", EmitDefaultValue=false)]
		public DecimalValue? OriginalCommittedAmount { get; set; }

		/// <summary>
		/// 
		/// Display Name:
		/// DAC Field Name: OrigQty 
		/// DAC: PX.Objects.PM.PMCommitment 
		/// </summary>
		/// <remarks>
		/// 
		/// </remarks>
		[DataMember(Name="OriginalCommittedQty", EmitDefaultValue=false)]
		public DecimalValue? OriginalCommittedQty { get; set; }

		/// <summary>
		/// 
		/// Display Name:
		/// DAC Field Name: ProjectID 
		/// DAC: PX.Objects.PM.PMCommitment 
		/// </summary>
		/// <remarks>
		/// 
		/// </remarks>
		[DataMember(Name="ProjectID", EmitDefaultValue=false)]
		public StringValue? ProjectID { get; set; }

		/// <summary>
		/// 
		/// Display Name:
		/// DAC Field Name: ProjectTaskID 
		/// DAC: PX.Objects.PM.PMCommitment 
		/// </summary>
		/// <remarks>
		/// 
		/// </remarks>
		[DataMember(Name="ProjectTaskID", EmitDefaultValue=false)]
		public StringValue? ProjectTaskID { get; set; }

		[DataMember(Name="RelatedDocument", EmitDefaultValue=false)]
		public StringValue? RelatedDocument { get; set; }

		/// <summary>
		/// 
		/// Display Name:
		/// DAC Field Name: Amount 
		/// DAC: PX.Objects.PM.PMCommitment 
		/// </summary>
		/// <remarks>
		/// 
		/// </remarks>
		[DataMember(Name="RevisedCommittedAmount", EmitDefaultValue=false)]
		public DecimalValue? RevisedCommittedAmount { get; set; }

		/// <summary>
		/// 
		/// Display Name:
		/// DAC Field Name: Qty 
		/// DAC: PX.Objects.PM.PMCommitment 
		/// </summary>
		/// <remarks>
		/// 
		/// </remarks>
		[DataMember(Name="RevisedCommittedQty", EmitDefaultValue=false)]
		public DecimalValue? RevisedCommittedQty { get; set; }

		[DataMember(Name="Type", EmitDefaultValue=false)]
		public StringValue? Type { get; set; }

		/// <summary>
		/// 
		/// Display Name:
		/// DAC Field Name: UOM 
		/// DAC: PX.Objects.PM.PMCommitment 
		/// </summary>
		/// <remarks>
		/// 
		/// </remarks>
		[DataMember(Name="UOM", EmitDefaultValue=false)]
		public StringValue? UOM { get; set; }

		public virtual string GetEndpointPath()
		{
			return "entity/Default/24.200.001";
		}
	}
}