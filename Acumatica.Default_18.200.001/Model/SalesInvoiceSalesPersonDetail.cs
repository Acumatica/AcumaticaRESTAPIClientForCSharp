using Acumatica.RESTClient.Model;
using System.Collections.Generic;
using System.Runtime.Serialization;

namespace Acumatica.Default_18_200_001.Model
{
	[DataContract]
	public class SalesInvoiceSalesPersonDetail : Entity
	{

		[DataMember(Name="CommissionableAmount", EmitDefaultValue=false)]
		public DecimalValue CommissionableAmount { get; set; }

		[DataMember(Name="CommissionAmount", EmitDefaultValue=false)]
		public DecimalValue CommissionAmount { get; set; }

		[DataMember(Name="CommissionPercent", EmitDefaultValue=false)]
		public DecimalValue CommissionPercent { get; set; }

		[DataMember(Name="SalespersonID", EmitDefaultValue=false)]
		public StringValue SalespersonID { get; set; }

	}
}