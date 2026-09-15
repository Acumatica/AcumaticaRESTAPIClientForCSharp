using System;
using System.Collections.Generic;
using System.Runtime.Serialization;

using Newtonsoft.Json;

using Acumatica.RESTClient.Client;
using Acumatica.RESTClient.ContractBasedApi;
using Acumatica.RESTClient.ContractBasedApi.Model;

namespace Acumatica.Default_26_200_001.Model
{
	[DataContract]
	public class CashPurchaseDetail : Entity
	{

		[DataMember(Name="Account", EmitDefaultValue=false)]
		public StringValue? Account { get; set; }

		[DataMember(Name="Branch", EmitDefaultValue=false)]
		public StringValue? Branch { get; set; }

		[DataMember(Name="DeferralCode", EmitDefaultValue=false)]
		public StringValue? DeferralCode { get; set; }

		[DataMember(Name="Description", EmitDefaultValue=false)]
		public StringValue? Description { get; set; }

		[DataMember(Name="ExtCost", EmitDefaultValue=false)]
		public DecimalValue? ExtCost { get; set; }

		[DataMember(Name="Inventory", EmitDefaultValue=false)]
		public StringValue? Inventory { get; set; }

		[DataMember(Name="LineNbr", EmitDefaultValue=false)]
		public IntValue? LineNbr { get; set; }

		[DataMember(Name="NonBillable", EmitDefaultValue=false)]
		public BooleanValue? NonBillable { get; set; }

		[DataMember(Name="Project", EmitDefaultValue=false)]
		public StringValue? Project { get; set; }

		[DataMember(Name="Quantity", EmitDefaultValue=false)]
		public DecimalValue? Quantity { get; set; }

		[DataMember(Name="Subaccount", EmitDefaultValue=false)]
		public StringValue? Subaccount { get; set; }

		[DataMember(Name="TaxCategory", EmitDefaultValue=false)]
		public StringValue? TaxCategory { get; set; }

		[DataMember(Name="TermEndDate", EmitDefaultValue=false)]
		public DateOnlyValue? TermEndDate { get; set; }

		[DataMember(Name="TermStartDate", EmitDefaultValue=false)]
		public DateOnlyValue? TermStartDate { get; set; }

		[DataMember(Name="TransactionDescription", EmitDefaultValue=false)]
		public StringValue? TransactionDescription { get; set; }

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

			//Intentionally excluded
			//public const string All = "Files";
		}
	}
}