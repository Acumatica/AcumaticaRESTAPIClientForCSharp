using System;
using System.Collections.Generic;

using Newtonsoft.Json;

using Acumatica.RESTClient.Client;
using Acumatica.RESTClient.ContractBasedApi;
using Acumatica.RESTClient.ContractBasedApi.Model;

namespace Acumatica.Default_25_200_001.Model
{
	/// <summary>
	/// Corresponds to the screen <c>GL301000</c> in the Acumatica ERP
	/// <para>Key Fields: BatchNbr, Module</para>
	/// </summary>
	public class JournalTransaction : Entity, ITopLevelEntity
	{

		/// <summary>
		/// Key field.Auto-generated unique number of the batch.
		/// <para>DAC: PX.Objects.GL.Batch</para>
		/// <para>Display Name: Batch Number</para>
		/// <para>SQL Type: nvarchar(15)</para>
		/// Key Field
		/// </summary>
		public StringValue? BatchNbr { get; set; }

		/// <summary>
		/// Identifier of the Branch, to which the batch belongs.
		/// <para>DAC: PX.Objects.GL.Batch</para>
		/// <para>Display Name: Branch</para>
		/// </summary>
		public StringValue? BranchID { get; set; }

		/// <summary>
		/// The date and time when the record was created.
		/// <para>DAC: PX.Objects.EP.EPApproval</para>
		/// <para>Display Name: Assignment Date</para>
		/// </summary>
		public DateTimeValue? CreatedDateTime { get; set; }

		/// <summary>
		/// The code of the Currency of the batch.
		/// <para>DAC Field Name: CuryID</para>
		/// <para>DAC: PX.Objects.GL.Batch</para>
		/// <para>Display Name: Currency</para>
		/// <para>SQL Type: nvarchar(5)</para>
		/// </summary>
		public StringValue? CurrencyID { get; set; }

		/// <summary>
		/// The description of the batch.
		/// <para>DAC: PX.Objects.GL.Batch</para>
		/// <para>SQL Type: nvarchar(512)</para>
		/// </summary>
		public StringValue? Description { get; set; }

		public List<JournalTransactionDetail>? Details { get; set; }

		public BooleanValue? Hold { get; set; }

		public DateTimeValue? LastModifiedDateTime { get; set; }

		/// <summary>
		/// Identifier of the Ledger, to which the batch belongs.
		/// <para>DAC: PX.Objects.GL.Batch</para>
		/// <para>Display Name: Ledger</para>
		/// </summary>
		public StringValue? LedgerID { get; set; }

		/// <summary>
		/// Key field.The code of the module, to which the batch belongs.
		/// <para>DAC: PX.Objects.GL.Batch</para>
		/// <para>SQL Type: char(2)</para>
		/// Key Field
		/// </summary>
		public StringValue? Module { get; set; }

		/// <summary>
		/// Identifier of the Financial Period, to which the batch belongs.
		/// <para>DAC Field Name: FinPeriodID</para>
		/// <para>DAC: PX.Objects.GL.Batch</para>
		/// <para>Display Name: Post Period</para>
		/// <para>SQL Type: char(6)</para>
		/// </summary>
		public StringValue? PostPeriod { get; set; }

		/// <summary>
		/// The read-only status of the batch.
		/// <para>DAC: PX.Objects.GL.Batch</para>
		/// <para>SQL Type: char(1)</para>
		/// </summary>
		public StringValue? Status { get; set; }

		/// <summary>
		/// The date of the batch, specified by user.
		/// <para>DAC Field Name: DateEntered</para>
		/// <para>DAC: PX.Objects.GL.Batch</para>
		/// <para>Display Name: Transaction Date</para>
		/// </summary>
		public DateTimeValue? TransactionDate { get; set; }

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
			return "entity/Default/25.200.001";
		}
	}
}