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
	/// Corresponds to the screen <c>IN301000</c> in the Acumatica ERP
	/// <para>Key Fields: ReferenceNbr</para>
	/// </summary>
	[DataContract]
	public class InventoryReceipt : Entity, ITopLevelEntity
	{

		/// <summary>
		/// <para>DAC: PX.Objects.IN.INRegister</para>
		/// <para>Display Name: Control Cost</para>
		/// </summary>
		[DataMember(Name="ControlCost", EmitDefaultValue=false)]
		public DecimalValue? ControlCost { get; set; }

		/// <summary>
		/// <para>DAC: PX.Objects.IN.INRegister</para>
		/// <para>Display Name: Control Qty.</para>
		/// </summary>
		[DataMember(Name="ControlQty", EmitDefaultValue=false)]
		public DecimalValue? ControlQty { get; set; }

		/// <summary>
		/// <para>DAC Field Name: TranDate</para>
		/// <para>DAC: PX.Objects.IN.INRegister</para>
		/// </summary>
		[DataMember(Name="Date", EmitDefaultValue=false)]
		public DateTimeValue? Date { get; set; }

		/// <summary>
		/// <para>DAC Field Name: TranDesc</para>
		/// <para>DAC: PX.Objects.IN.INRegister</para>
		/// <para>SQL Type: nvarchar(256)</para>
		/// </summary>
		[DataMember(Name="Description", EmitDefaultValue=false)]
		public StringValue? Description { get; set; }

		[DataMember(Name="Details", EmitDefaultValue=false)]
		public List<InventoryReceiptDetail>? Details { get; set; }

		[DataMember(Name="Hold", EmitDefaultValue=false)]
		public BooleanValue? Hold { get; set; }

		[DataMember(Name="LastModifiedDateTime", EmitDefaultValue=false)]
		public DateTimeValue? LastModifiedDateTime { get; set; }

		/// <summary>
		/// <para>DAC Field Name: FinPeriodID</para>
		/// <para>DAC: PX.Objects.IN.INRegister</para>
		/// <para>Display Name: Post Period</para>
		/// <para>SQL Type: char(6)</para>
		/// </summary>
		[DataMember(Name="PostPeriod", EmitDefaultValue=false)]
		public StringValue? PostPeriod { get; set; }

		/// <summary>
		/// <para>DAC Field Name: RefNbr</para>
		/// <para>DAC: PX.Objects.IN.INRegister</para>
		/// <para>Display Name: Reference Nbr.</para>
		/// <para>SQL Type: nvarchar(15)</para>
		/// Key Field
		/// </summary>
		[DataMember(Name="ReferenceNbr", EmitDefaultValue=false)]
		public StringValue? ReferenceNbr { get; set; }

		/// <summary>
		/// <para>DAC: PX.Objects.IN.INRegister</para>
		/// <para>SQL Type: char(1)</para>
		/// </summary>
		[DataMember(Name="Status", EmitDefaultValue=false)]
		public StringValue? Status { get; set; }

		/// <summary>
		/// <para>DAC: PX.Objects.IN.INRegister</para>
		/// <para>Display Name: Total Cost</para>
		/// </summary>
		[DataMember(Name="TotalCost", EmitDefaultValue=false)]
		public DecimalValue? TotalCost { get; set; }

		/// <summary>
		/// <para>DAC: PX.Objects.IN.INRegister</para>
		/// <para>Display Name: Total Qty.</para>
		/// </summary>
		[DataMember(Name="TotalQty", EmitDefaultValue=false)]
		public DecimalValue? TotalQty { get; set; }

		/// <summary>
		/// Field used in INReceiptEntry screen.
		/// <para>DAC: PX.Objects.IN.INRegister</para>
		/// <para>Display Name: Transfer Nbr.</para>
		/// <para>SQL Type: nvarchar(15)</para>
		/// </summary>
		[DataMember(Name="TransferNbr", EmitDefaultValue=false)]
		public StringValue? TransferNbr { get; set; }

		public static class Expand
		{
			public const string Files = "Files";
			public const string Details = "Details";
			public const string Details_Files = "Details/Files";
			public const string Details_Allocations = "Details/Allocations";
			public const string Details_Allocations_Files = "Details/Allocations/Files";

			//Intentionally excluded
			//public const string All = "Files,Details,Details/Files,Details/Allocations,Details/Allocations/Files";
		}
		public virtual string GetEndpointPath()
		{
			return "entity/Default/23.200.001";
		}
	}
}