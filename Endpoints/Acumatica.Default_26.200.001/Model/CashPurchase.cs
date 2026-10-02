using System;
using System.Collections.Generic;

using Newtonsoft.Json;

using Acumatica.RESTClient.Client;
using Acumatica.RESTClient.ContractBasedApi;
using Acumatica.RESTClient.ContractBasedApi.Model;

namespace Acumatica.Default_26_200_001.Model
{
	/// <summary>
	/// Corresponds to the screen <c>AP304000</c> in the Acumatica ERP
	/// </summary>
	public class CashPurchase : Entity, ITopLevelEntity
	{

		#region Fields
		public DecimalValue? Balance { get; set; }

		public StringValue? CashAccount { get; set; }

		public DecimalValue? CashDiscountTaken { get; set; }

		public StringValue? Currency { get; set; }

		public BooleanValue? CuryViewState { get; set; }

		public DateOnlyValue? Date { get; set; }

		public DateOnlyValue? DepositAfter { get; set; }

		public StringValue? Description { get; set; }

		public DecimalValue? DetailTotal { get; set; }

		public DecimalValue? FinanceCharges { get; set; }

		public BooleanValue? Hold { get; set; }

		public StringValue? Location { get; set; }

		public DecimalValue? PaymentAmount { get; set; }

		public StringValue? PaymentMethod { get; set; }

		public StringValue? PaymentRef { get; set; }

		public StringValue? PostPeriod { get; set; }

		public StringValue? Project { get; set; }

		public DecimalValue? RoundingDiff { get; set; }

		public DecimalValue? TaxAmount { get; set; }

		public DecimalValue? TaxTotal { get; set; }

		public StringValue? Vendor { get; set; }

		public DecimalValue? WithTax { get; set; }

		public StringValue? ReferenceNbr { get; set; }

		public StringSingleSelectValue? Status { get; set; }

		public StringSingleSelectValue? Type { get; set; }

		#endregion

		#region Details
		public List<CashPurchaseDetail>? Details { get; set; }

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