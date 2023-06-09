using System.Collections.Generic;
using System.Runtime.Serialization;

using Newtonsoft.Json;

using Acumatica.RESTClient.Client;
using Acumatica.RESTClient.ContractBasedApi;
using Acumatica.RESTClient.ContractBasedApi.Model;

namespace Acumatica.Default_22_200_001.Model
{
	[DataContract]
	public class BatchDeductionOrBenefitDetail : Entity
	{

		[DataMember(Name="BatchNumber", EmitDefaultValue=false)]
		public StringValue BatchNumber { get; set; }

		[DataMember(Name="BenefitAmount", EmitDefaultValue=false)]
		public DecimalValue BenefitAmount { get; set; }

		[DataMember(Name="BenefitCalculationMethod", EmitDefaultValue=false)]
		public StringValue BenefitCalculationMethod { get; set; }

		[DataMember(Name="BenefitPercent", EmitDefaultValue=false)]
		public DecimalValue BenefitPercent { get; set; }

		[DataMember(Name="ContributionType", EmitDefaultValue=false)]
		public StringValue ContributionType { get; set; }

		[DataMember(Name="DeductionAmount", EmitDefaultValue=false)]
		public DecimalValue DeductionAmount { get; set; }

		[DataMember(Name="DeductionCalculationMethod", EmitDefaultValue=false)]
		public StringValue DeductionCalculationMethod { get; set; }

		[DataMember(Name="DeductionCode", EmitDefaultValue=false)]
		public StringValue DeductionCode { get; set; }

		[DataMember(Name="DeductionPercent", EmitDefaultValue=false)]
		public DecimalValue DeductionPercent { get; set; }

		[DataMember(Name="Description", EmitDefaultValue=false)]
		public StringValue Description { get; set; }

		[DataMember(Name="Enabled", EmitDefaultValue=false)]
		public BooleanValue Enabled { get; set; }

		[DataMember(Name="IsGarnishment", EmitDefaultValue=false)]
		public BooleanValue IsGarnishment { get; set; }

		[DataMember(Name="LastModifiedDateTime", EmitDefaultValue=false)]
		public DateTimeValue LastModifiedDateTime { get; set; }

	}
}