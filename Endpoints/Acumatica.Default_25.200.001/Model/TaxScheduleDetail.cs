using System;
using System.Collections.Generic;

using Newtonsoft.Json;

using Acumatica.RESTClient.Client;
using Acumatica.RESTClient.ContractBasedApi;
using Acumatica.RESTClient.ContractBasedApi.Model;

namespace Acumatica.Default_25_200_001.Model
{
	public class TaxScheduleDetail : Entity
	{

		/// <summary>
		/// <para>DAC Field Name: NonDeductibleTaxRate</para>
		/// <para>DAC: PX.Objects.TX.TaxRev</para>
		/// <para>Display Name: Deductible Tax Rate</para>
		/// </summary>
		public DecimalValue? DeductibleTaxRate { get; set; }

		/// <summary>
		/// <para>DAC Field Name: TaxableMax</para>
		/// <para>DAC: PX.Objects.TX.TaxRev</para>
		/// <para>Display Name: Max. Taxable Amount</para>
		/// </summary>
		public DecimalValue? MaxTaxableAmount { get; set; }

		/// <summary>
		/// <para>DAC Field Name: TaxableMin</para>
		/// <para>DAC: PX.Objects.TX.TaxRev</para>
		/// <para>Display Name: Min. Taxable Amount</para>
		/// </summary>
		public DecimalValue? MinTaxableAmount { get; set; }

		/// <summary>
		/// <para>DAC Field Name: TaxBucketID</para>
		/// <para>DAC: PX.Objects.TX.TaxRev</para>
		/// <para>Display Name: Reporting Group</para>
		/// </summary>
		public StringValue? ReportingGroup { get; set; }

		public IntValue? RevisionID { get; set; }

		/// <summary>
		/// <para>DAC: PX.Objects.TX.TaxRev</para>
		/// <para>Display Name: Start Date</para>
		/// </summary>
		public DateTimeValue? StartDate { get; set; }

		/// <summary>
		/// The tax ID. This is the key field, which can be specified by the user.
		/// <para>DAC: PX.Objects.TX.Tax</para>
		/// <para>Display Name: Tax ID</para>
		/// <para>SQL Type: nvarchar(60)</para>
		/// Key Field
		/// </summary>
		public StringValue? TaxID { get; set; }

		/// <summary>
		/// <para>DAC: PX.Objects.TX.TaxRev</para>
		/// <para>Display Name: Tax Rate</para>
		/// </summary>
		public DecimalValue? TaxRate { get; set; }

	}
}