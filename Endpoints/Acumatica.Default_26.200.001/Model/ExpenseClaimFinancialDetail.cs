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
	public class ExpenseClaimFinancialDetail : Entity
	{

		[DataMember(Name="APDocuments", EmitDefaultValue=false)]
		public List<ExpenseClaimAPDocument>? APDocuments { get; set; }

		/// <summary>
		/// The branch of the claim.
		/// <para>DAC Field Name: BranchID</para>
		/// <para>DAC: PX.Objects.EP.EPExpenseClaim</para>
		/// </summary>
		[DataMember(Name="Branch", EmitDefaultValue=false)]
		public StringValue? Branch { get; set; }

		/// <summary>
		/// The period to which the AP document should be posted. The selected period is copied to the Post Period box on the Bills and Adjustments form (AP301000) (which corresponds to the APInvoiceEntry graph) for the AP document created upon the release of the expense claim.
		/// <para>DAC Field Name: FinPeriodID</para>
		/// <para>DAC: PX.Objects.EP.EPExpenseClaim</para>
		/// <para>Display Name: Post to Period</para>
		/// <para>SQL Type: char(6)</para>
		/// </summary>
		[DataMember(Name="PosttoPeriod", EmitDefaultValue=false)]
		public StringValue? PosttoPeriod { get; set; }

		/// <summary>
		/// The tax zone associated with the branch.
		/// <para>DAC Field Name: TaxZoneID</para>
		/// <para>DAC: PX.Objects.EP.EPExpenseClaim</para>
		/// <para>Display Name: Tax Zone</para>
		/// <para>SQL Type: nvarchar(10)</para>
		/// </summary>
		[DataMember(Name="TaxZone", EmitDefaultValue=false)]
		public StringValue? TaxZone { get; set; }

		/// <summary>
		/// Names that can be passed in the <c>$expand</c> parameter.
		/// <para>This endpoint uses system contract 5, where a nested entity is expanded
		/// as <c>Parent($expand=Child)</c> rather than <c>Parent/Child</c>, so only the names
		/// that can be expanded directly on this entity are listed here. Use the nested
		/// entity's own <c>Expand</c> class for the inner names.</para>
		/// </summary>
		public static class Expand
		{
			public const string APDocuments = "APDocuments";

			//Intentionally excluded
			//public const string All = "APDocuments";
		}
	}
}