using System;
using System.Collections.Generic;

using Newtonsoft.Json;

using Acumatica.RESTClient.Client;
using Acumatica.RESTClient.ContractBasedApi;
using Acumatica.RESTClient.ContractBasedApi.Model;

namespace Acumatica.Default_26_200_001.Model
{
	/// <summary>
	/// Corresponds to the screen <c>CA304000</c> in the Acumatica ERP
	/// </summary>
	public class CashTransaction : Entity, ITopLevelEntity
	{

		#region Fields
		/// <summary>
		/// The cash account that is the source account for the transaction.
		/// <para>DAC Field Name: CashAccountID</para>
		/// <para>DAC: PX.Objects.CA.CAAdj</para>
		/// <para>Display Name: Cash Account</para>
		/// </summary>
		public StringValue? CashAccountCD { get; set; }

		/// <summary>
		/// Specifies (if set to <c>true</c>) that the transaction has been approved by a responsible person.This field is displayed if the RequestApproval field is set to <c>true</c>.
		/// <para>DAC: PX.Objects.CA.CAAdj</para>
		/// </summary>
		public BooleanValue? Approved { get; set; }

		/// <summary>
		/// The description of the transaction.
		/// <para>DAC Field Name: TranDesc</para>
		/// <para>DAC: PX.Objects.CA.CAAdj</para>
		/// <para>SQL Type: nvarchar(512)</para>
		/// </summary>
		public StringValue? Description { get; set; }

		/// <summary>
		/// The date of the transaction.
		/// <para>DAC Field Name: TranDate</para>
		/// <para>DAC: PX.Objects.CA.CAAdj</para>
		/// <para>Display Name: Tran. Date</para>
		/// </summary>
		public DateOnlyValue? PostedDate { get; set; }

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

		#endregion

		#region Details
		public List<CashTransactionDetail>? Details { get; set; }

		#endregion

		/// <summary>
		/// Names that can be passed in the <c>$expand</c> parameter.
		/// <para>This endpoint uses system contract 5, where a nested entity is expanded
		/// as <c>Parent($expand=Child)</c> rather than <c>Parent/Child</c>, so only the names
		/// that can be expanded directly on this entity are listed here. Use the nested
		/// entity's own <c>Expand</c> class for the inner names.</para>
		/// </summary>
		public static class Expand
		{
			public const string Files = "Files";
			public const string Translations = "Translations";
			public const string Details = "Details";

			//Intentionally excluded
			//public const string All = "Files,Translations,Details";
		}
		public virtual string GetEndpointPath()
		{
			return "entity/Default/26.200.001";
		}
	}
}