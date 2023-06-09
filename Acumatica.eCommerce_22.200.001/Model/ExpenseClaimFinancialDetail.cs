using System.Collections.Generic;
using System.Runtime.Serialization;

using Newtonsoft.Json;

using Acumatica.RESTClient.Client;
using Acumatica.RESTClient.ContractBasedApi;
using Acumatica.RESTClient.ContractBasedApi.Model;

namespace Acumatica.eCommerce_22_200_001.Model
{
	[DataContract]
	public class ExpenseClaimFinancialDetail : Entity
	{

		[DataMember(Name="APDocuments", EmitDefaultValue=false)]
		public List<ExpenseClaimAPDocument> APDocuments { get; set; }

		[DataMember(Name="Branch", EmitDefaultValue=false)]
		public StringValue Branch { get; set; }

		[DataMember(Name="PosttoPeriod", EmitDefaultValue=false)]
		public StringValue PosttoPeriod { get; set; }

		[DataMember(Name="TaxZone", EmitDefaultValue=false)]
		public StringValue TaxZone { get; set; }

	}
}