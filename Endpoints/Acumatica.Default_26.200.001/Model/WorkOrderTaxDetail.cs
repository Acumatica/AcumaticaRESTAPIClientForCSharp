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
	public class WorkOrderTaxDetail : Entity
	{

		[DataMember(Name="ExemptTax", EmitDefaultValue=false)]
		public BooleanValue? ExemptTax { get; set; }

		[DataMember(Name="ExemptedAmt", EmitDefaultValue=false)]
		public DecimalValue? ExemptedAmt { get; set; }

		[DataMember(Name="PendingTax", EmitDefaultValue=false)]
		public BooleanValue? PendingTax { get; set; }

		[DataMember(Name="ReverseTax", EmitDefaultValue=false)]
		public BooleanValue? ReverseTax { get; set; }

		[DataMember(Name="StatisticalTax", EmitDefaultValue=false)]
		public BooleanValue? StatisticalTax { get; set; }

		[DataMember(Name="TaxAmt", EmitDefaultValue=false)]
		public DecimalValue? TaxAmt { get; set; }

		[DataMember(Name="TaxID", EmitDefaultValue=false)]
		public StringValue? TaxID { get; set; }

		[DataMember(Name="TaxRate", EmitDefaultValue=false)]
		public DecimalValue? TaxRate { get; set; }

		[DataMember(Name="TaxType", EmitDefaultValue=false)]
		public StringSingleSelectValue? TaxType { get; set; }

		[DataMember(Name="TaxUOM", EmitDefaultValue=false)]
		public StringValue? TaxUOM { get; set; }

		[DataMember(Name="TaxableAmt", EmitDefaultValue=false)]
		public DecimalValue? TaxableAmt { get; set; }

		[DataMember(Name="TaxableQty", EmitDefaultValue=false)]
		public DecimalValue? TaxableQty { get; set; }

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