using System;
using System.Collections.Generic;

using Newtonsoft.Json;

using Acumatica.RESTClient.Client;
using Acumatica.RESTClient.ContractBasedApi;
using Acumatica.RESTClient.ContractBasedApi.Model;

namespace Acumatica.Default_26_200_001.Model
{
	public class TaxScheduleDetail : Entity
	{

		#region Fields
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
		/// <para>Display Name: Start Date</para>
		/// </summary>
		public DateOnlyValue? StartDate { get; set; }

		/// <summary>
		/// <para>DAC: PX.Objects.TX.TaxRev</para>
		/// <para>Display Name: Tax Rate</para>
		/// </summary>
		public DecimalValue? TaxRate { get; set; }

		/// <summary>
		/// <para>DAC Field Name: NonDeductibleTaxRate</para>
		/// <para>DAC: PX.Objects.TX.TaxRev</para>
		/// <para>Display Name: Deductible Tax Rate</para>
		/// </summary>
		public DecimalValue? DeductibleTaxRate { get; set; }

		/// <summary>
		/// <para>DAC Field Name: TaxableMin</para>
		/// <para>DAC: PX.Objects.TX.TaxRev</para>
		/// <para>Display Name: Min. Taxable Amount</para>
		/// </summary>
		public DecimalValue? MinTaxableAmount { get; set; }

		/// <summary>
		/// <para>DAC Field Name: TaxableMax</para>
		/// <para>DAC: PX.Objects.TX.TaxRev</para>
		/// <para>Display Name: Max. Taxable Amount</para>
		/// </summary>
		public DecimalValue? MaxTaxableAmount { get; set; }

		/// <summary>
		/// <para>DAC Field Name: TaxBucketID</para>
		/// <para>DAC: PX.Objects.TX.TaxRev</para>
		/// <para>Display Name: Reporting Group</para>
		/// </summary>
		public StringValue? ReportingGroup { get; set; }

		public IntValue? RevisionID { get; set; }

		#endregion

		/// <summary>
		/// Names that can be passed in the <c>$expand</c> parameter.
		/// <para>This endpoint uses system contract 5, where a nested entity is expanded
		/// as <c>Parent($expand=Child)</c> rather than <c>Parent/Child</c>, so only the names
		/// that can be expanded directly on this entity are listed here. Use the nested
		/// entity's own <c>Expand</c> class for the inner names.</para>
		/// </summary>
		public static class Expand
		{
			public const string Files = "Files";

			//Intentionally excluded
			//public const string All = "Files";
		}
	}
}