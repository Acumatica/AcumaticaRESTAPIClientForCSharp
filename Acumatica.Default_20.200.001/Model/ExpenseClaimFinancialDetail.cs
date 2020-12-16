using Acumatica.RESTClient.Model;
using System.Collections.Generic;
using System.Runtime.Serialization;

namespace Acumatica.Default_20_200_001.Model
{
	[DataContract]
	public class ExpenseClaimFinancialDetail : Entity_v4
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