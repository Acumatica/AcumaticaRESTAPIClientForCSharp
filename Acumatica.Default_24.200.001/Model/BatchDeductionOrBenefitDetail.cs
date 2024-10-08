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
	public class BatchDeductionOrBenefitDetail : Entity
	{

		/// <summary>
		/// DAC Field Name: BatchNbr 
		/// DAC: PX.Objects.PR.PRBatch 
		/// Display Name: Batch ID 
		/// SQL Type: nvarchar(15) 
		/// Key Field
		/// </summary>
		[DataMember(Name="BatchNumber", EmitDefaultValue=false)]
		public StringValue? BatchNumber { get; set; }

		/// <summary>
		/// DAC Field Name: PRDeductCode__CntAmount 
		/// DAC: PX.Objects.PR.PRBatchDeduct 
		/// </summary>
		[DataMember(Name="BenefitAmount", EmitDefaultValue=false)]
		public DecimalValue? BenefitAmount { get; set; }

		/// <summary>
		/// DAC Field Name: PRDeductCode__CntCalcType 
		/// DAC: PX.Objects.PR.PRBatchDeduct 
		/// </summary>
		[DataMember(Name="BenefitCalculationMethod", EmitDefaultValue=false)]
		public StringValue? BenefitCalculationMethod { get; set; }

		/// <summary>
		/// DAC Field Name: PRDeductCode__CntPercent 
		/// DAC: PX.Objects.PR.PRBatchDeduct 
		/// </summary>
		[DataMember(Name="BenefitPercent", EmitDefaultValue=false)]
		public DecimalValue? BenefitPercent { get; set; }

		/// <summary>
		/// DAC Field Name: PRDeductCode__ContribType 
		/// DAC: PX.Objects.PR.PRBatchDeduct 
		/// </summary>
		[DataMember(Name="ContributionType", EmitDefaultValue=false)]
		public StringValue? ContributionType { get; set; }

		/// <summary>
		/// DAC Field Name: PRDeductCode__DedAmount 
		/// DAC: PX.Objects.PR.PRBatchDeduct 
		/// </summary>
		[DataMember(Name="DeductionAmount", EmitDefaultValue=false)]
		public DecimalValue? DeductionAmount { get; set; }

		/// <summary>
		/// DAC Field Name: PRDeductCode__DedCalcType 
		/// DAC: PX.Objects.PR.PRBatchDeduct 
		/// </summary>
		[DataMember(Name="DeductionCalculationMethod", EmitDefaultValue=false)]
		public StringValue? DeductionCalculationMethod { get; set; }

		/// <summary>
		/// DAC Field Name: CodeID 
		/// DAC: PX.Objects.PR.PRBatchDeduct 
		/// Display Name: Deduction Code 
		/// Key Field
		/// </summary>
		[DataMember(Name="DeductionCode", EmitDefaultValue=false)]
		public StringValue? DeductionCode { get; set; }

		/// <summary>
		/// DAC Field Name: PRDeductCode__DedPercent 
		/// DAC: PX.Objects.PR.PRBatchDeduct 
		/// </summary>
		[DataMember(Name="DeductionPercent", EmitDefaultValue=false)]
		public DecimalValue? DeductionPercent { get; set; }

		/// <summary>
		/// DAC Field Name: PRDeductCode__Description 
		/// DAC: PX.Objects.PR.PRBatchDeduct 
		/// </summary>
		[DataMember(Name="Description", EmitDefaultValue=false)]
		public StringValue? Description { get; set; }

		/// <summary>
		/// DAC Field Name: IsEnabled 
		/// DAC: PX.Objects.PR.PRBatchDeduct 
		/// </summary>
		[DataMember(Name="Enabled", EmitDefaultValue=false)]
		public BooleanValue? Enabled { get; set; }

		/// <summary>
		/// DAC Field Name: PRDeductCode__IsGarnishment 
		/// DAC: PX.Objects.PR.PRBatchDeduct 
		/// </summary>
		[DataMember(Name="IsGarnishment", EmitDefaultValue=false)]
		public BooleanValue? IsGarnishment { get; set; }

		[DataMember(Name="LastModifiedDateTime", EmitDefaultValue=false)]
		public DateTimeValue? LastModifiedDateTime { get; set; }

	}
}