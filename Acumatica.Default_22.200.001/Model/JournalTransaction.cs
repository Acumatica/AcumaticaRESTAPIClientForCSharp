using System;
using System.Collections.Generic;
using System.Runtime.Serialization;

using Newtonsoft.Json;

using Acumatica.RESTClient.Client;
using Acumatica.RESTClient.ContractBasedApi;
using Acumatica.RESTClient.ContractBasedApi.Model;

namespace Acumatica.Default_22_200_001.Model
{
	/// <summary>
	/// Corresponds to the screen GL301000 in the Acumatica ERP
	/// </summary>
	[DataContract]
	public class JournalTransaction : Entity, ITopLevelEntity
	{

		/// <summary>
		/// 
		/// Display Name:
		/// DAC Field Name: BatchNbr 
		/// DAC: PX.Objects.GL.Batch 
		/// </summary>
		/// <remarks>
		/// 
		/// </remarks>
		[DataMember(Name="BatchNbr", EmitDefaultValue=false)]
		public StringValue? BatchNbr { get; set; }

		/// <summary>
		/// 
		/// Display Name:
		/// DAC Field Name: BranchID 
		/// DAC: PX.Objects.GL.Batch 
		/// </summary>
		/// <remarks>
		/// 
		/// </remarks>
		[DataMember(Name="BranchID", EmitDefaultValue=false)]
		public StringValue? BranchID { get; set; }

		/// <summary>
		/// 
		/// Display Name:
		/// DAC Field Name: CreatedDateTime 
		/// DAC: PX.Objects.EP.EPApproval 
		/// </summary>
		/// <remarks>
		/// 
		/// </remarks>
		[DataMember(Name="CreatedDateTime", EmitDefaultValue=false)]
		public DateTimeValue? CreatedDateTime { get; set; }

		/// <summary>
		/// 
		/// Display Name:
		/// DAC Field Name: CuryID 
		/// DAC: PX.Objects.GL.Batch 
		/// </summary>
		/// <remarks>
		/// 
		/// </remarks>
		[DataMember(Name="CurrencyID", EmitDefaultValue=false)]
		public StringValue? CurrencyID { get; set; }

		/// <summary>
		/// 
		/// Display Name:
		/// DAC Field Name: Description 
		/// DAC: PX.Objects.GL.Batch 
		/// </summary>
		/// <remarks>
		/// 
		/// </remarks>
		[DataMember(Name="Description", EmitDefaultValue=false)]
		public StringValue? Description { get; set; }

		[DataMember(Name="Details", EmitDefaultValue=false)]
		public List<JournalTransactionDetail>? Details { get; set; }

		[DataMember(Name="Hold", EmitDefaultValue=false)]
		public BooleanValue? Hold { get; set; }

		[DataMember(Name="LastModifiedDateTime", EmitDefaultValue=false)]
		public DateTimeValue? LastModifiedDateTime { get; set; }

		/// <summary>
		/// 
		/// Display Name:
		/// DAC Field Name: LedgerID 
		/// DAC: PX.Objects.GL.Batch 
		/// </summary>
		/// <remarks>
		/// 
		/// </remarks>
		[DataMember(Name="LedgerID", EmitDefaultValue=false)]
		public StringValue? LedgerID { get; set; }

		/// <summary>
		/// 
		/// Display Name:
		/// DAC Field Name: Module 
		/// DAC: PX.Objects.GL.Batch 
		/// </summary>
		/// <remarks>
		/// 
		/// </remarks>
		[DataMember(Name="Module", EmitDefaultValue=false)]
		public StringValue? Module { get; set; }

		/// <summary>
		/// 
		/// Display Name:
		/// DAC Field Name: FinPeriodID 
		/// DAC: PX.Objects.GL.Batch 
		/// </summary>
		/// <remarks>
		/// 
		/// </remarks>
		[DataMember(Name="PostPeriod", EmitDefaultValue=false)]
		public StringValue? PostPeriod { get; set; }

		/// <summary>
		/// 
		/// Display Name:
		/// DAC Field Name: Status 
		/// DAC: PX.Objects.GL.Batch 
		/// </summary>
		/// <remarks>
		/// 
		/// </remarks>
		[DataMember(Name="Status", EmitDefaultValue=false)]
		public StringValue? Status { get; set; }

		/// <summary>
		/// 
		/// Display Name:
		/// DAC Field Name: DateEntered 
		/// DAC: PX.Objects.GL.Batch 
		/// </summary>
		/// <remarks>
		/// 
		/// </remarks>
		[DataMember(Name="TransactionDate", EmitDefaultValue=false)]
		public DateTimeValue? TransactionDate { get; set; }

		public virtual string GetEndpointPath()
		{
			return "entity/Default/22.200.001";
		}
	}
}