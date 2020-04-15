using Acumatica.RESTClient.Model;
using System.Collections.Generic;
using System.Runtime.Serialization;

namespace Acumatica.POS_17_200_001.Model
{
	[DataContract]
	public class SalesInvoiceCommissions : Entity
	{

		[DataMember(Name="CommissionAmount", EmitDefaultValue=false)]
		public DecimalValue CommissionAmount { get; set; }

		[DataMember(Name="TotalCommissionableAmount", EmitDefaultValue=false)]
		public DecimalValue TotalCommissionableAmount { get; set; }

	}
}