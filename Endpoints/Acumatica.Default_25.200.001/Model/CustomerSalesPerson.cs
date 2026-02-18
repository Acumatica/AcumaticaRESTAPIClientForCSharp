using System;
using System.Collections.Generic;

using Newtonsoft.Json;

using Acumatica.RESTClient.Client;
using Acumatica.RESTClient.ContractBasedApi;
using Acumatica.RESTClient.ContractBasedApi.Model;

namespace Acumatica.Default_25_200_001.Model
{
	public class CustomerSalesPerson : Entity
	{

		/// <summary>
		/// The default sales commission percentage received by the salesperson for the specified customer and location.
		/// <para>DAC Field Name: CommisionPct</para>
		/// <para>DAC: PX.Objects.AR.CustSalesPeople</para>
		/// <para>Display Name: Commission %</para>
		/// </summary>
		public DecimalValue? Commission { get; set; }

		/// <summary>
		/// This field indicates whether the location is default for the corresponding business account.
		/// <para>DAC Field Name: IsDefault</para>
		/// <para>DAC: PX.Objects.CR.Standalone.Location</para>
		/// </summary>
		public BooleanValue? Default { get; set; }

		/// <summary>
		/// The integer identifier of the customer location. This field is a part of the compound key of the record.
		/// <para>DAC: PX.Objects.AR.CustSalesPeople</para>
		/// <para>Display Name: Location</para>
		/// Key Field
		/// </summary>
		public StringValue? LocationID { get; set; }

		/// <summary>
		/// <para>DAC Field Name: LocationID_description</para>
		/// <para>DAC: PX.Objects.AR.CustSalesPeople</para>
		/// </summary>
		public StringValue? LocationName { get; set; }

		/// <summary>
		/// <para>DAC Field Name: SalesPersonID_SalesPerson_descr</para>
		/// <para>DAC: PX.Objects.AR.CustSalesPeople</para>
		/// </summary>
		public StringValue? Name { get; set; }

		/// <summary>
		/// The integer identifier of the salesperson. This field is a part of the compound key of the record.
		/// <para>DAC Field Name: SalesPersonID</para>
		/// <para>DAC: PX.Objects.AR.CustSalesPeople</para>
		/// Key Field
		/// </summary>
		public StringValue? SalespersonID { get; set; }

	}
}