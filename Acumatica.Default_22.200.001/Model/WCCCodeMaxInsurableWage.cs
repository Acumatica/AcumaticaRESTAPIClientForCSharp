using Acumatica.RESTClient.Model;
using System.Collections.Generic;
using System.Runtime.Serialization;

namespace Acumatica.Default_22_200_001.Model
{
	[DataContract]
	public class WCCCodeMaxInsurableWage : Entity_v4
	{

		[DataMember(Name="DeductionandBenefitCode", EmitDefaultValue=false)]
		public StringValue DeductionandBenefitCode { get; set; }

		[DataMember(Name="EffectiveDate", EmitDefaultValue=false)]
		public DateTimeValue EffectiveDate { get; set; }

		[DataMember(Name="LastModifiedDateTime", EmitDefaultValue=false)]
		public DateTimeValue LastModifiedDateTime { get; set; }

		[DataMember(Name="State", EmitDefaultValue=false)]
		public StringValue State { get; set; }

		[DataMember(Name="Wage", EmitDefaultValue=false)]
		public DecimalValue Wage { get; set; }

		[DataMember(Name="WCCode", EmitDefaultValue=false)]
		public StringValue WCCode { get; set; }

	}
}