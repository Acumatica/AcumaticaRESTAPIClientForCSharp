using Acumatica.RESTClient.Model;
using System.Collections.Generic;
using System.Runtime.Serialization;

namespace Acumatica.Default_22_200_001.Model
{
	[DataContract]
	public class TaxAndReportingCA : Entity_v4
	{

		[DataMember(Name="ReportingType", EmitDefaultValue=false)]
		public StringValue ReportingType { get; set; }

		[DataMember(Name="SupplementalIncome", EmitDefaultValue=false)]
		public BooleanValue SupplementalIncome { get; set; }

		[DataMember(Name="TaxDetailsCA", EmitDefaultValue=false)]
		public List<EarningCodeTaxDetailCA> TaxDetailsCA { get; set; }

		[DataMember(Name="WageType", EmitDefaultValue=false)]
		public StringValue WageType { get; set; }

	}
}