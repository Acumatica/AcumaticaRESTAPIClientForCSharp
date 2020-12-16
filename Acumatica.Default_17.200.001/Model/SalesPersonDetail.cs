using Acumatica.RESTClient.Model;
using System.Collections.Generic;
using System.Runtime.Serialization;

namespace Acumatica.Default_17_200_001.Model
{
	[DataContract]
	public class SalesPersonDetail : Entity_v3
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