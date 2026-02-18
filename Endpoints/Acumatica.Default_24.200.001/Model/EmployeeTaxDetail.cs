using System;
using System.Collections.Generic;

using Newtonsoft.Json;

using Acumatica.RESTClient.Client;
using Acumatica.RESTClient.ContractBasedApi;
using Acumatica.RESTClient.ContractBasedApi.Model;

namespace Acumatica.Default_24_200_001.Model
{
	public class EmployeeTaxDetail : Entity
	{

		/// <summary>
		/// <para>DAC Field Name: IsActive</para>
		/// <para>DAC: PX.Objects.PR.PREmployeeEarning</para>
		/// </summary>
		public BooleanValue? Active { get; set; }

		public DateTimeValue? LastModifiedDateTime { get; set; }

		/// <summary>
		/// <para>DAC Field Name: TaxID</para>
		/// <para>DAC: PX.Objects.PR.PREmployeeTax</para>
		/// <para>Display Name: Tax Code</para>
		/// Key Field
		/// </summary>
		public StringValue? TaxCode { get; set; }

		public List<TaxCodeSetting>? TaxCodeSettings { get; set; }

		/// <summary>
		/// <para>DAC Field Name: TaxID_Description</para>
		/// <para>DAC: PX.Objects.PR.PREmployeeTax</para>
		/// </summary>
		public StringValue? TaxDescription { get; set; }

	}
}