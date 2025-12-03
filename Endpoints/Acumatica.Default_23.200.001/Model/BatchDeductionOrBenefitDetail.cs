using System;
using System.Collections.Generic;
using System.Runtime.Serialization;

using Newtonsoft.Json;

using Acumatica.RESTClient.Client;
using Acumatica.RESTClient.ContractBasedApi;
using Acumatica.RESTClient.ContractBasedApi.Model;

namespace Acumatica.Default_23_200_001.Model
{
	[DataContract]
	public class BatchDeductionOrBenefitDetail : Entity
	{

		/// <summary>
		/// <para>DAC Field Name: BatchNbr</para>
		/// <para>DAC: PX.Objects.PR.PRBatch</para>
		/// <para>Display Name: Batch ID</para>
		/// <para>SQL Type: nvarchar(15)</para>
		/// Key Field
		/// </summary>
		[DataMember(Name="BatchNumber", EmitDefaultValue=false)]
		public StringValue? BatchNumber { get; set; }

		/// <summary>
		/// <para>DAC Field Name: PRDeductCode__CntAmount</para>
		/// <para>DAC: PX.Objects.PR.PRBatchDeduct</para>
		/// </summary>
		[DataMember(Name="BenefitAmount", EmitDefaultValue=false)]
		public DecimalValue? BenefitAmount { get; set; }

		/// <summary>
		/// <para>DAC Field Name: PRDeductCode__CntCalcType</para>
		/// <para>DAC: PX.Objects.PR.PRBatchDeduct</para>
		/// </summary>
		[DataMember(Name="BenefitCalculationMethod", EmitDefaultValue=false)]
		public StringValue? BenefitCalculationMethod { get; set; }

		/// <summary>
		/// <para>DAC Field Name: PRDeductCode__CntPercent</para>
		/// <para>DAC: PX.Objects.PR.PRBatchDeduct</para>
		/// </summary>
		[DataMember(Name="BenefitPercent", EmitDefaultValue=false)]
		public DecimalValue? BenefitPercent { get; set; }

		/// <summary>
		/// <para>DAC Field Name: PRDeductCode__ContribType</para>
		/// <para>DAC: PX.Objects.PR.PRBatchDeduct</para>
		/// </summary>
		[DataMember(Name="ContributionType", EmitDefaultValue=false)]
		public StringValue? ContributionType { get; set; }

		/// <summary>
		/// <para>DAC Field Name: PRDeductCode__DedAmount</para>
		/// <para>DAC: PX.Objects.PR.PRBatchDeduct</para>
		/// </summary>
		[DataMember(Name="DeductionAmount", EmitDefaultValue=false)]
		public DecimalValue? DeductionAmount { get; set; }

		/// <summary>
		/// <para>DAC Field Name: PRDeductCode__DedCalcType</para>
		/// <para>DAC: PX.Objects.PR.PRBatchDeduct</para>
		/// </summary>
		[DataMember(Name="DeductionCalculationMethod", EmitDefaultValue=false)]
		public StringValue? DeductionCalculationMethod { get; set; }

		/// <summary>
		/// <para>DAC Field Name: CodeID</para>
		/// <para>DAC: PX.Objects.PR.PRBatchDeduct</para>
		/// <para>Display Name: Deduction Code</para>
		/// Key Field
		/// </summary>
		[DataMember(Name="DeductionCode", EmitDefaultValue=false)]
		public StringValue? DeductionCode { get; set; }

		/// <summary>
		/// <para>DAC Field Name: PRDeductCode__DedPercent</para>
		/// <para>DAC: PX.Objects.PR.PRBatchDeduct</para>
		/// </summary>
		[DataMember(Name="DeductionPercent", EmitDefaultValue=false)]
		public DecimalValue? DeductionPercent { get; set; }

		/// <summary>
		/// <para>DAC Field Name: PRDeductCode__Description</para>
		/// <para>DAC: PX.Objects.PR.PRBatchDeduct</para>
		/// </summary>
		[DataMember(Name="Description", EmitDefaultValue=false)]
		public StringValue? Description { get; set; }

		/// <summary>
		/// <para>DAC Field Name: IsEnabled</para>
		/// <para>DAC: PX.Objects.PR.PRBatchDeduct</para>
		/// </summary>
		[DataMember(Name="Enabled", EmitDefaultValue=false)]
		public BooleanValue? Enabled { get; set; }

		/// <summary>
		/// <para>DAC Field Name: PRDeductCode__IsGarnishment</para>
		/// <para>DAC: PX.Objects.PR.PRBatchDeduct</para>
		/// </summary>
		[DataMember(Name="IsGarnishment", EmitDefaultValue=false)]
		public BooleanValue? IsGarnishment { get; set; }

		[DataMember(Name="LastModifiedDateTime", EmitDefaultValue=false)]
		public DateTimeValue? LastModifiedDateTime { get; set; }

	}
}