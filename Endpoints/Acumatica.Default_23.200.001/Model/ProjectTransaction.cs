using System;
using System.Collections.Generic;

using Newtonsoft.Json;

using Acumatica.RESTClient.Client;
using Acumatica.RESTClient.ContractBasedApi;
using Acumatica.RESTClient.ContractBasedApi.Model;

namespace Acumatica.Default_23_200_001.Model
{
	/// <summary>
	/// Corresponds to the screen <c>PM304000</c> in the Acumatica ERP
	/// <para>Key Fields: Module, ReferenceNbr</para>
	/// </summary>
	public class ProjectTransaction : Entity, ITopLevelEntity
	{

		public DateTimeValue? CreatedDateTime { get; set; }

		/// <summary>
		/// The description of the document.
		/// <para>DAC: PX.Objects.PM.PMRegister</para>
		/// <para>SQL Type: nvarchar(255)</para>
		/// </summary>
		public StringValue? Description { get; set; }

		public List<ProjectTransactionDetail>? Details { get; set; }

		public DateTimeValue? LastModifiedDateTime { get; set; }

		/// <summary>
		/// The identifier of the functional area, to which the batch belongs.
		/// <para>DAC: PX.Objects.PM.PMRegister</para>
		/// <para>Display Name: Source</para>
		/// <para>SQL Type: char(2)</para>
		/// Key Field
		/// </summary>
		public StringValue? Module { get; set; }

		/// <summary>
		/// The reference number of the original document.
		/// <para>DAC Field Name: OrigDocNbr</para>
		/// <para>DAC: PX.Objects.PM.PMRegister</para>
		/// <para>Display Name: Orig. Doc. Nbr.</para>
		/// <para>SQL Type: nvarchar(30)</para>
		/// </summary>
		public StringValue? OriginalDocNbr { get; set; }

		/// <summary>
		/// The type of the original document.
		/// <para>DAC Field Name: OrigDocType</para>
		/// <para>DAC: PX.Objects.PM.PMRegister</para>
		/// <para>Display Name: Orig. Doc. Type</para>
		/// <para>SQL Type: char(2)</para>
		/// </summary>
		public StringValue? OriginalDocType { get; set; }

		/// <summary>
		/// The reference number of the document.
		/// <para>DAC Field Name: RefNbr</para>
		/// <para>DAC: PX.Objects.PM.PMRegister</para>
		/// <para>Display Name: Ref. Number</para>
		/// <para>SQL Type: nvarchar(15)</para>
		/// Key Field
		/// </summary>
		public StringValue? ReferenceNbr { get; set; }

		/// <summary>
		/// The read-only status of the document.
		/// <para>DAC: PX.Objects.PM.PMRegister</para>
		/// <para>SQL Type: char(1)</para>
		/// </summary>
		public StringValue? Status { get; set; }

		/// <summary>
		/// The total amount for the project transactions in the base currency.
		/// <para>DAC Field Name: AmtTotal</para>
		/// <para>DAC: PX.Objects.PM.PMRegister</para>
		/// <para>Display Name: Total Amount</para>
		/// </summary>
		public DecimalValue? TotalAmount { get; set; }

		/// <summary>
		/// The total billable quantity for the project transactions.
		/// <para>DAC Field Name: BillableQtyTotal</para>
		/// <para>DAC: PX.Objects.PM.PMRegister</para>
		/// <para>Display Name: Total Billable Quantity</para>
		/// </summary>
		public DecimalValue? TotalBillableQty { get; set; }

		/// <summary>
		/// The total quantity of items in the project transactions.
		/// <para>DAC Field Name: QtyTotal</para>
		/// <para>DAC: PX.Objects.PM.PMRegister</para>
		/// <para>Display Name: Total Quantity</para>
		/// </summary>
		public DecimalValue? TotalQty { get; set; }

		public static class Expand
		{
			public const string Files = "Files";
			public const string Translations = "Translations";
			public const string Details = "Details";
			public const string Details_Files = "Details/Files";

			//Intentionally excluded
			//public const string All = "Files,Translations,Details,Details/Files";
		}
		public virtual string GetEndpointPath()
		{
			return "entity/Default/23.200.001";
		}
	}
}