using Acumatica.RESTClient.Model;
using System.Collections.Generic;
using System.Runtime.Serialization;

namespace Acumatica.Default_22_200_001.Model
{
	[DataContract]
	public class PayrollUnionLocal : Entity_v4
	{

		[DataMember(Name="Active", EmitDefaultValue=false)]
		public BooleanValue Active { get; set; }

		[DataMember(Name="DeductionsAndBenefits", EmitDefaultValue=false)]
		public List<UnionDeductionOrBenefitDetail> DeductionsAndBenefits { get; set; }

		[DataMember(Name="Description", EmitDefaultValue=false)]
		public StringValue Description { get; set; }

		[DataMember(Name="EarningRates", EmitDefaultValue=false)]
		public List<UnionEarningRateDetail> EarningRates { get; set; }

		[DataMember(Name="LastModifiedDateTime", EmitDefaultValue=false)]
		public DateTimeValue LastModifiedDateTime { get; set; }

		[DataMember(Name="Location", EmitDefaultValue=false)]
		public StringValue Location { get; set; }

		[DataMember(Name="PayrollUnionLocalID", EmitDefaultValue=false)]
		public StringValue PayrollUnionLocalID { get; set; }

		[DataMember(Name="Vendor", EmitDefaultValue=false)]
		public StringValue Vendor { get; set; }

	}
}