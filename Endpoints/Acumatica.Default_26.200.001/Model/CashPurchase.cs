using System;
using System.Collections.Generic;
using System.Runtime.Serialization;

using Newtonsoft.Json;

using Acumatica.RESTClient.Client;
using Acumatica.RESTClient.ContractBasedApi;
using Acumatica.RESTClient.ContractBasedApi.Model;

namespace Acumatica.Default_26_200_001.Model
{
	/// <summary>
	/// Corresponds to the screen <c>AP304000</c> in the Acumatica ERP
	/// </summary>
	[DataContract]
	public class CashPurchase : Entity, ITopLevelEntity
	{

		[DataMember(Name="Balance", EmitDefaultValue=false)]
		public DecimalValue? Balance { get; set; }

		[DataMember(Name="CashAccount", EmitDefaultValue=false)]
		public StringValue? CashAccount { get; set; }

		[DataMember(Name="CashDiscountTaken", EmitDefaultValue=false)]
		public DecimalValue? CashDiscountTaken { get; set; }

		[DataMember(Name="Currency", EmitDefaultValue=false)]
		public StringValue? Currency { get; set; }

		[DataMember(Name="CuryViewState", EmitDefaultValue=false)]
		public BooleanValue? CuryViewState { get; set; }

		[DataMember(Name="Date", EmitDefaultValue=false)]
		public DateOnlyValue? Date { get; set; }

		[DataMember(Name="DepositAfter", EmitDefaultValue=false)]
		public DateOnlyValue? DepositAfter { get; set; }

		[DataMember(Name="Description", EmitDefaultValue=false)]
		public StringValue? Description { get; set; }

		[DataMember(Name="Details", EmitDefaultValue=false)]
		public List<CashPurchaseDetail>? Details { get; set; }

		[DataMember(Name="DetailTotal", EmitDefaultValue=false)]
		public DecimalValue? DetailTotal { get; set; }

		[DataMember(Name="FinanceCharges", EmitDefaultValue=false)]
		public DecimalValue? FinanceCharges { get; set; }

		[DataMember(Name="Hold", EmitDefaultValue=false)]
		public BooleanValue? Hold { get; set; }

		[DataMember(Name="Location", EmitDefaultValue=false)]
		public StringValue? Location { get; set; }

		[DataMember(Name="PaymentAmount", EmitDefaultValue=false)]
		public DecimalValue? PaymentAmount { get; set; }

		[DataMember(Name="PaymentMethod", EmitDefaultValue=false)]
		public StringValue? PaymentMethod { get; set; }

		[DataMember(Name="PaymentRef", EmitDefaultValue=false)]
		public StringValue? PaymentRef { get; set; }

		[DataMember(Name="PostPeriod", EmitDefaultValue=false)]
		public StringValue? PostPeriod { get; set; }

		[DataMember(Name="Project", EmitDefaultValue=false)]
		public StringValue? Project { get; set; }

		[DataMember(Name="RoundingDiff", EmitDefaultValue=false)]
		public DecimalValue? RoundingDiff { get; set; }

		[DataMember(Name="TaxAmount", EmitDefaultValue=false)]
		public DecimalValue? TaxAmount { get; set; }

		[DataMember(Name="TaxTotal", EmitDefaultValue=false)]
		public DecimalValue? TaxTotal { get; set; }

		[DataMember(Name="Vendor", EmitDefaultValue=false)]
		public StringValue? Vendor { get; set; }

		[DataMember(Name="WithTax", EmitDefaultValue=false)]
		public DecimalValue? WithTax { get; set; }

		[DataMember(Name="ReferenceNbr", EmitDefaultValue=false)]
		public StringValue? ReferenceNbr { get; set; }

		[DataMember(Name="Status", EmitDefaultValue=false)]
		public StringSingleSelectValue? Status { get; set; }

		[DataMember(Name="Type", EmitDefaultValue=false)]
		public StringSingleSelectValue? Type { get; set; }

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