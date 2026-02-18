using System;
using System.Collections.Generic;

using Newtonsoft.Json;

using Acumatica.RESTClient.Client;
using Acumatica.RESTClient.ContractBasedApi;
using Acumatica.RESTClient.ContractBasedApi.Model;

namespace Acumatica.Default_23_200_001.Model
{
	public class BatchDeductionOrBenefitDetail : Entity
	{

		/// <summary>
		/// <para>DAC Field Name: BatchNbr</para>
		/// <para>DAC: PX.Objects.PR.PRBatch</para>
		/// <para>Display Name: Batch ID</para>
		/// <para>SQL Type: nvarchar(15)</para>
		/// Key Field
		/// </summary>
		public StringValue? BatchNumber { get; set; }

		/// <summary>
		/// <para>DAC Field Name: PRDeductCode__CntAmount</para>
		/// <para>DAC: PX.Objects.PR.PRBatchDeduct</para>
		/// </summary>
		public DecimalValue? BenefitAmount { get; set; }

		/// <summary>
		/// <para>DAC Field Name: PRDeductCode__CntCalcType</para>
		/// <para>DAC: PX.Objects.PR.PRBatchDeduct</para>
		/// </summary>
		public StringValue? BenefitCalculationMethod { get; set; }

		/// <summary>
		/// <para>DAC Field Name: PRDeductCode__CntPercent</para>
		/// <para>DAC: PX.Objects.PR.PRBatchDeduct</para>
		/// </summary>
		public DecimalValue? BenefitPercent { get; set; }

		/// <summary>
		/// <para>DAC Field Name: PRDeductCode__ContribType</para>
		/// <para>DAC: PX.Objects.PR.PRBatchDeduct</para>
		/// </summary>
		public StringValue? ContributionType { get; set; }

		/// <summary>
		/// <para>DAC Field Name: PRDeductCode__DedAmount</para>
		/// <para>DAC: PX.Objects.PR.PRBatchDeduct</para>
		/// </summary>
		public DecimalValue? DeductionAmount { get; set; }

		/// <summary>
		/// <para>DAC Field Name: PRDeductCode__DedCalcType</para>
		/// <para>DAC: PX.Objects.PR.PRBatchDeduct</para>
		/// </summary>
		public StringValue? DeductionCalculationMethod { get; set; }

		/// <summary>
		/// <para>DAC Field Name: CodeID</para>
		/// <para>DAC: PX.Objects.PR.PRBatchDeduct</para>
		/// <para>Display Name: Deduction Code</para>
		/// Key Field
		/// </summary>
		public StringValue? DeductionCode { get; set; }

		/// <summary>
		/// <para>DAC Field Name: PRDeductCode__DedPercent</para>
		/// <para>DAC: PX.Objects.PR.PRBatchDeduct</para>
		/// </summary>
		public DecimalValue? DeductionPercent { get; set; }

		/// <summary>
		/// <para>DAC Field Name: PRDeductCode__Description</para>
		/// <para>DAC: PX.Objects.PR.PRBatchDeduct</para>
		/// </summary>
		public StringValue? Description { get; set; }

		/// <summary>
		/// <para>DAC Field Name: IsEnabled</para>
		/// <para>DAC: PX.Objects.PR.PRBatchDeduct</para>
		/// </summary>
		public BooleanValue? Enabled { get; set; }

		/// <summary>
		/// <para>DAC Field Name: PRDeductCode__IsGarnishment</para>
		/// <para>DAC: PX.Objects.PR.PRBatchDeduct</para>
		/// </summary>
		public BooleanValue? IsGarnishment { get; set; }

		public DateTimeValue? LastModifiedDateTime { get; set; }

	}
}