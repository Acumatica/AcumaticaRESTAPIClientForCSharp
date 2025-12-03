using System;
using System.Collections.Generic;
using System.Runtime.Serialization;

using Newtonsoft.Json;

using Acumatica.RESTClient.Client;
using Acumatica.RESTClient.ContractBasedApi;
using Acumatica.RESTClient.ContractBasedApi.Model;

namespace Acumatica.Default_24_200_001.Model
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

	}
}