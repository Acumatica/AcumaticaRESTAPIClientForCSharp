using System;
using System.Collections.Generic;
using System.Runtime.Serialization;

using Newtonsoft.Json;

using Acumatica.RESTClient.Client;
using Acumatica.RESTClient.ContractBasedApi;
using Acumatica.RESTClient.ContractBasedApi.Model;

namespace Acumatica.Default_23_200_001.Model
{
	[DataContract]
	public class ExpenseClaimFinancialDetail : Entity
	{

		[DataMember(Name="APDocuments", EmitDefaultValue=false)]
		public List<ExpenseClaimAPDocument>? APDocuments { get; set; }

		/// <summary>
		/// The branch of the claim.
		/// DAC Field Name: BranchID 
		/// DAC: PX.Objects.EP.EPExpenseClaim 
		/// </summary>
		[DataMember(Name="Branch", EmitDefaultValue=false)]
		public StringValue? Branch { get; set; }

		/// <summary>
		/// The period to which the AP document should be posted. The selected period is copied to the Post Period box on the Bills and Adjustments form (AP301000) (which corresponds to the APInvoiceEntry graph) for the AP document created upon the release of the expense claim.
		/// DAC Field Name: FinPeriodID 
		/// DAC: PX.Objects.EP.EPExpenseClaim 
		/// Display Name: Post to Period 
		/// SQL Type: char(6) 
		/// </summary>
		[DataMember(Name="PosttoPeriod", EmitDefaultValue=false)]
		public StringValue? PosttoPeriod { get; set; }

		/// <summary>
		/// The tax zone associated with the branch.
		/// DAC Field Name: TaxZoneID 
		/// DAC: PX.Objects.EP.EPExpenseClaim 
		/// Display Name: Tax Zone 
		/// SQL Type: nvarchar(10) 
		/// </summary>
		[DataMember(Name="TaxZone", EmitDefaultValue=false)]
		public StringValue? TaxZone { get; set; }

	}
}