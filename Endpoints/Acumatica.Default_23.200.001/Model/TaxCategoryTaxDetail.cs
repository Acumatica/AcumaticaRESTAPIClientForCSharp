using System;
using System.Collections.Generic;

using Newtonsoft.Json;

using Acumatica.RESTClient.Client;
using Acumatica.RESTClient.ContractBasedApi;
using Acumatica.RESTClient.ContractBasedApi.Model;

namespace Acumatica.Default_23_200_001.Model
{
	public class TaxCategoryTaxDetail : Entity
	{

		/// <summary>
		/// <para>DAC Field Name: Tax__TaxCalcRule</para>
		/// <para>DAC: PX.Objects.TX.TaxCategoryDet</para>
		/// </summary>
		public StringValue? CalculateOn { get; set; }

		/// <summary>
		/// <para>DAC Field Name: Tax__TaxApplyTermsDisc</para>
		/// <para>DAC: PX.Objects.TX.TaxCategoryDet</para>
		/// </summary>
		public StringValue? CashDiscount { get; set; }

		/// <summary>
		/// <para>DAC Field Name: Tax__Descr</para>
		/// <para>DAC: PX.Objects.TX.TaxCategoryDet</para>
		/// </summary>
		public StringValue? Description { get; set; }

		/// <summary>
		/// The tax category ID. This is the key field, which can be specified by the user.
		/// <para>DAC Field Name: TaxCategoryID</para>
		/// <para>DAC: PX.Objects.TX.TaxCategory</para>
		/// <para>Display Name: Tax Category ID</para>
		/// <para>SQL Type: nvarchar(15)</para>
		/// Key Field
		/// </summary>
		public StringValue? TaxCategory { get; set; }

		/// <summary>
		/// The foreign key to Tax.
		/// <para>DAC: PX.Objects.TX.TaxCategoryDet</para>
		/// <para>Display Name: Tax ID</para>
		/// <para>SQL Type: nvarchar(60)</para>
		/// Key Field
		/// </summary>
		public StringValue? TaxID { get; set; }

		/// <summary>
		/// <para>DAC Field Name: Tax__TaxType</para>
		/// <para>DAC: PX.Objects.TX.TaxCategoryDet</para>
		/// </summary>
		public StringValue? TaxType { get; set; }

	}
}