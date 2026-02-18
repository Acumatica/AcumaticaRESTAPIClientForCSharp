using System;
using System.Collections.Generic;

using Newtonsoft.Json;

using Acumatica.RESTClient.Client;
using Acumatica.RESTClient.ContractBasedApi;
using Acumatica.RESTClient.ContractBasedApi.Model;

namespace Acumatica.Default_25_200_001.Model
{
	/// <summary>
	/// Corresponds to the screen <c>CA304000</c> in the Acumatica ERP
	/// </summary>
	public class CashTransaction : Entity, ITopLevelEntity
	{

		/// <summary>
		/// Specifies (if set to true) that the transaction has been approved by a responsible person.This field is displayed if the RequestApproval field is set to true.
		/// <para>DAC: PX.Objects.CA.CAAdj</para>
		/// </summary>
		public BooleanValue? Approved { get; set; }

		/// <summary>
		/// The cash account that is the source account for the transaction.
		/// <para>DAC Field Name: CashAccountID</para>
		/// <para>DAC: PX.Objects.CA.CAAdj</para>
		/// <para>Display Name: Cash Account</para>
		/// </summary>
		public StringValue? CashAccountCD { get; set; }

		/// <summary>
		/// The description of the transaction.
		/// <para>DAC Field Name: TranDesc</para>
		/// <para>DAC: PX.Objects.CA.CAAdj</para>
		/// <para>SQL Type: nvarchar(512)</para>
		/// </summary>
		public StringValue? Description { get; set; }

		public List<CashTransactionDetail>? Details { get; set; }

		/// <summary>
		/// The user-defined transaction type. Selects the appropriate type from the list of entry types defined for the selected cash account.
		/// <para>DAC Field Name: EntryTypeID</para>
		/// <para>DAC: PX.Objects.CA.CAAdj</para>
		/// <para>Display Name: Entry Type</para>
		/// <para>SQL Type: nvarchar(10)</para>
		/// </summary>
		public StringValue? EntryTypeCD { get; set; }

		/// <summary>
		/// The reference number of the external document.
		/// <para>DAC Field Name: ExtRefNbr</para>
		/// <para>DAC: PX.Objects.CA.CAAdj</para>
		/// <para>Display Name: Document Ref.</para>
		/// <para>SQL Type: nvarchar(40)</para>
		/// </summary>
		public StringValue? ExternalReferenceNumber { get; set; }

		/// <summary>
		/// The date of the transaction.
		/// <para>DAC Field Name: TranDate</para>
		/// <para>DAC: PX.Objects.CA.CAAdj</para>
		/// <para>Display Name: Tran. Date</para>
		/// </summary>
		public DateTimeValue? PostedDate { get; set; }

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