using System;
using System.Collections.Generic;
using System.Runtime.Serialization;

using Newtonsoft.Json;

using Acumatica.RESTClient.Client;
using Acumatica.RESTClient.ContractBasedApi;
using Acumatica.RESTClient.ContractBasedApi.Model;

namespace Acumatica.MANUFACTURING_25_100_001.Model
{
	/// <summary>
	/// Corresponds to the screen <c>AM309000</c> in the Acumatica ERP
	/// <para>Key Fields: BatchNbr</para>
	/// </summary>
	[DataContract]
	public class CostTransaction : Entity, ITopLevelEntity
	{

		/// <summary>
		/// The reference number of the transaction.
		/// <para>DAC Field Name: BatNbr</para>
		/// <para>DAC: PX.Objects.AM.AMBatch</para>
		/// <para>Display Name: Batch Nbr.</para>
		/// <para>SQL Type: nvarchar(15)</para>
		/// Key Field
		/// </summary>
		[DataMember(Name="BatchNbr", EmitDefaultValue=false)]
		public StringValue? BatchNbr { get; set; }

		/// <summary>
		/// The control amount.
		/// <para>DAC: PX.Objects.AM.AMBatch</para>
		/// <para>Display Name: Control Amount</para>
		/// </summary>
		[DataMember(Name="ControlAmount", EmitDefaultValue=false)]
		public DecimalValue? ControlAmount { get; set; }

		/// <summary>
		/// The date when the transaction was created.
		/// <para>DAC Field Name: TranDate</para>
		/// <para>DAC: PX.Objects.AM.AMBatch</para>
		/// </summary>
		[DataMember(Name="Date", EmitDefaultValue=false)]
		public DateTimeValue? Date { get; set; }

		/// <summary>
		/// A brief description of the transaction.
		/// <para>DAC Field Name: TranDesc</para>
		/// <para>DAC: PX.Objects.AM.AMBatch</para>
		/// <para>SQL Type: nvarchar(256)</para>
		/// </summary>
		[DataMember(Name="Description", EmitDefaultValue=false)]
		public StringValue? Description { get; set; }

		[DataMember(Name="Details", EmitDefaultValue=false)]
		public List<CostTransactionDetail>? Details { get; set; }

		/// <summary>
		/// A Boolean value that indicates whether the batch is on hold.
		/// <para>DAC: PX.Objects.AM.AMBatch</para>
		/// </summary>
		[DataMember(Name="Hold", EmitDefaultValue=false)]
		public BooleanValue? Hold { get; set; }

		/// <summary>
		/// The batch number of th original transaction.
		/// <para>DAC Field Name: OrigBatNbr</para>
		/// <para>DAC: PX.Objects.AM.AMBatch</para>
		/// <para>Display Name: Orig Batch Nbr</para>
		/// <para>SQL Type: nvarchar(15)</para>
		/// </summary>
		[DataMember(Name="OrigBatchNbr", EmitDefaultValue=false)]
		public StringValue? OrigBatchNbr { get; set; }

		/// <summary>
		/// The document type of the original transaction.
		/// <para>DAC: PX.Objects.AM.AMBatch</para>
		/// <para>Display Name: Orig Doc Type</para>
		/// <para>SQL Type: char(1)</para>
		/// </summary>
		[DataMember(Name="OrigDocType", EmitDefaultValue=false)]
		public StringValue? OrigDocType { get; set; }

		/// <summary>
		/// The financial period that corresponds to the transaction date.
		/// <para>DAC Field Name: FinPeriodID</para>
		/// <para>DAC: PX.Objects.AM.AMBatch</para>
		/// <para>Display Name: Post Period</para>
		/// <para>SQL Type: char(6)</para>
		/// </summary>
		[DataMember(Name="PostPeriod", EmitDefaultValue=false)]
		public StringValue? PostPeriod { get; set; }

		/// <summary>
		/// The status of the transaction set by the system.
		/// <para>DAC: PX.Objects.AM.AMBatch</para>
		/// <para>SQL Type: char(1)</para>
		/// </summary>
		[DataMember(Name="Status", EmitDefaultValue=false)]
		public StringValue? Status { get; set; }

		/// <summary>
		/// The total amount of the transaction.
		/// <para>DAC: PX.Objects.AM.AMBatch</para>
		/// <para>Display Name: Total Amount</para>
		/// </summary>
		[DataMember(Name="TotalAmount", EmitDefaultValue=false)]
		public DecimalValue? TotalAmount { get; set; }

		public static class Expand
		{
			public const string Files = "Files";
			public const string Details = "Details";
			public const string Details_Files = "Details/Files";

			//Intentionally excluded
			//public const string All = "Files,Details,Details/Files";
		}
		public virtual string GetEndpointPath()
		{
			return "entity/MANUFACTURING/25.100.001";
		}
	}
}