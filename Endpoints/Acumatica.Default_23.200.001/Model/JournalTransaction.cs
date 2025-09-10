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
	/// Corresponds to the screen GL301000 in the Acumatica ERP
	/// </summary>
	[DataContract]
	public class JournalTransaction : Entity, ITopLevelEntity
	{

		/// <summary>
		/// Key field.Auto-generated unique number of the batch.
		/// DAC: PX.Objects.GL.Batch 
		/// Display Name: Batch Number 
		/// SQL Type: nvarchar(15) 
		/// Key Field
		/// </summary>
		[DataMember(Name="BatchNbr", EmitDefaultValue=false)]
		public StringValue? BatchNbr { get; set; }

		/// <summary>
		/// Identifier of the Branch, to which the batch belongs.
		/// DAC: PX.Objects.GL.Batch 
		/// Display Name: Branch 
		/// </summary>
		[DataMember(Name="BranchID", EmitDefaultValue=false)]
		public StringValue? BranchID { get; set; }

		/// <summary>
		/// The date and time when the record was created.
		/// DAC: PX.Objects.EP.EPApproval 
		/// Display Name: Assignment Date 
		/// </summary>
		[DataMember(Name="CreatedDateTime", EmitDefaultValue=false)]
		public DateTimeValue? CreatedDateTime { get; set; }

		/// <summary>
		/// The code of the Currency of the batch.
		/// DAC Field Name: CuryID 
		/// DAC: PX.Objects.GL.Batch 
		/// Display Name: Currency 
		/// SQL Type: nvarchar(5) 
		/// </summary>
		[DataMember(Name="CurrencyID", EmitDefaultValue=false)]
		public StringValue? CurrencyID { get; set; }

		/// <summary>
		/// The description of the batch.
		/// DAC: PX.Objects.GL.Batch 
		/// SQL Type: nvarchar(512) 
		/// </summary>
		[DataMember(Name="Description", EmitDefaultValue=false)]
		public StringValue? Description { get; set; }

		[DataMember(Name="Details", EmitDefaultValue=false)]
		public List<JournalTransactionDetail>? Details { get; set; }

		[DataMember(Name="Hold", EmitDefaultValue=false)]
		public BooleanValue? Hold { get; set; }

		[DataMember(Name="LastModifiedDateTime", EmitDefaultValue=false)]
		public DateTimeValue? LastModifiedDateTime { get; set; }

		/// <summary>
		/// Identifier of the Ledger, to which the batch belongs.
		/// DAC: PX.Objects.GL.Batch 
		/// Display Name: Ledger 
		/// </summary>
		[DataMember(Name="LedgerID", EmitDefaultValue=false)]
		public StringValue? LedgerID { get; set; }

		/// <summary>
		/// Key field.The code of the module, to which the batch belongs.
		/// DAC: PX.Objects.GL.Batch 
		/// SQL Type: char(2) 
		/// Key Field
		/// </summary>
		[DataMember(Name="Module", EmitDefaultValue=false)]
		public StringValue? Module { get; set; }

		/// <summary>
		/// Identifier of the Financial Period, to which the batch belongs.
		/// DAC Field Name: FinPeriodID 
		/// DAC: PX.Objects.GL.Batch 
		/// Display Name: Post Period 
		/// SQL Type: char(6) 
		/// </summary>
		[DataMember(Name="PostPeriod", EmitDefaultValue=false)]
		public StringValue? PostPeriod { get; set; }

		/// <summary>
		/// The read-only status of the batch.
		/// DAC: PX.Objects.GL.Batch 
		/// SQL Type: char(1) 
		/// </summary>
		[DataMember(Name="Status", EmitDefaultValue=false)]
		public StringValue? Status { get; set; }

		/// <summary>
		/// The date of the batch, specified by user.
		/// DAC Field Name: DateEntered 
		/// DAC: PX.Objects.GL.Batch 
		/// Display Name: Transaction Date 
		/// </summary>
		[DataMember(Name="TransactionDate", EmitDefaultValue=false)]
		public DateTimeValue? TransactionDate { get; set; }

		public virtual string GetEndpointPath()
		{
			return "entity/Default/23.200.001";
		}
	}
}