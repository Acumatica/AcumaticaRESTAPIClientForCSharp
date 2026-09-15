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
	public class SalesInvoiceCommissions : Entity
	{

		/// <summary>
		/// The commission amount calculated on this document for the salesperson.Given in the currency of the document.
		/// <para>DAC Field Name: CuryCommnAmt</para>
		/// <para>DAC: PX.Objects.AR.ARInvoice</para>
		/// <para>Display Name: Commission Amt.</para>
		/// </summary>
		[DataMember(Name="CommissionAmount", EmitDefaultValue=false)]
		public DecimalValue? CommissionAmount { get; set; }

		[DataMember(Name="SalesPersons", EmitDefaultValue=false)]
		public List<SalesInvoiceSalesPersonDetail>? SalesPersons { get; set; }

		/// <summary>
		/// The amount used as the base to calculate commission for this document.Given in the currency of the document.
		/// <para>DAC Field Name: CuryCommnblAmt</para>
		/// <para>DAC: PX.Objects.AR.ARInvoice</para>
		/// <para>Display Name: Total Commissionable</para>
		/// </summary>
		[DataMember(Name="TotalCommissionableAmount", EmitDefaultValue=false)]
		public DecimalValue? TotalCommissionableAmount { get; set; }

		/// <summary>
		/// Names that can be passed in the <c>$expand</c> parameter.
		/// <para>This endpoint uses system contract 5, where a nested entity is expanded
		/// as <c>Parent($expand=Child)</c> rather than <c>Parent/Child</c>, so only the names
		/// that can be expanded directly on this entity are listed here. Use the nested
		/// entity's own <c>Expand</c> class for the inner names.</para>
		/// </summary>
		public static class Expand
		{
			public const string SalesPersons = "SalesPersons";

			//Intentionally excluded
			//public const string All = "SalesPersons";
		}
	}
}