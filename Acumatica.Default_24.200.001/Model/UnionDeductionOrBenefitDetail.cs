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
	public class UnionDeductionOrBenefitDetail : Entity
	{

		[DataMember(Name="ContributionAmount", EmitDefaultValue=false)]
		public DecimalValue? ContributionAmount { get; set; }

		[DataMember(Name="ContributionCalculationMethod", EmitDefaultValue=false)]
		public StringValue? ContributionCalculationMethod { get; set; }

		[DataMember(Name="ContributionPercent", EmitDefaultValue=false)]
		public DecimalValue? ContributionPercent { get; set; }

		[DataMember(Name="ContributionType", EmitDefaultValue=false)]
		public StringValue? ContributionType { get; set; }

		[DataMember(Name="DeductionAmount", EmitDefaultValue=false)]
		public DecimalValue? DeductionAmount { get; set; }

		[DataMember(Name="DeductionAndBenefitCode", EmitDefaultValue=false)]
		public StringValue? DeductionAndBenefitCode { get; set; }

		[DataMember(Name="DeductionCalculationMethod", EmitDefaultValue=false)]
		public StringValue? DeductionCalculationMethod { get; set; }

		[DataMember(Name="DeductionPercent", EmitDefaultValue=false)]
		public DecimalValue? DeductionPercent { get; set; }

		[DataMember(Name="Description", EmitDefaultValue=false)]
		public StringValue? Description { get; set; }

		[DataMember(Name="EffectiveDate", EmitDefaultValue=false)]
		public DateTimeValue? EffectiveDate { get; set; }

		[DataMember(Name="LaborItem", EmitDefaultValue=false)]
		public StringValue? LaborItem { get; set; }

		[DataMember(Name="LastModifiedDateTime", EmitDefaultValue=false)]
		public DateTimeValue? LastModifiedDateTime { get; set; }

	}
}