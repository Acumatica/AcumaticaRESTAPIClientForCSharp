using System;
using System.Collections.Generic;

using Newtonsoft.Json;

using Acumatica.RESTClient.Client;
using Acumatica.RESTClient.ContractBasedApi;
using Acumatica.RESTClient.ContractBasedApi.Model;

namespace Acumatica.Default_23_200_001.Model
{
	public class AppFinancialSettings : Entity
	{

		/// <summary>
		/// <para>DAC Field Name: BillCustomerID</para>
		/// <para>DAC: PX.Objects.FS.FSServiceOrder</para>
		/// <para>Display Name: Billing Customer</para>
		/// </summary>
		public StringValue? BillingCustomer { get; set; }

		public StringValue? BillingCycle { get; set; }

		/// <summary>
		/// <para>DAC Field Name: BillLocationID</para>
		/// <para>DAC: PX.Objects.FS.FSServiceOrder</para>
		/// <para>Display Name: Billing Location</para>
		/// </summary>
		public StringValue? BillingLocation { get; set; }

		/// <summary>
		/// <para>DAC Field Name: BranchID</para>
		/// <para>DAC: PX.Objects.FS.FSServiceOrder</para>
		/// </summary>
		public StringValue? Branch { get; set; }

		/// <summary>
		/// <para>DAC: PX.Objects.FS.FSServiceOrder</para>
		/// </summary>
		public BooleanValue? Commissionable { get; set; }

		/// <summary>
		/// <para>DAC Field Name: TaxZoneID</para>
		/// <para>DAC: PX.Objects.FS.FSAppointment</para>
		/// <para>Display Name: Customer Tax Zone</para>
		/// <para>SQL Type: nvarchar(10)</para>
		/// </summary>
		public StringValue? CustomerTaxZone { get; set; }

		/// <summary>
		/// <para>DAC Field Name: BillingBy</para>
		/// <para>DAC: PX.Objects.FS.FSServiceOrder</para>
		/// <para>Display Name: Billing By</para>
		/// <para>SQL Type: char(2)</para>
		/// </summary>
		public StringValue? RunBillingFor { get; set; }

		/// <summary>
		/// <para>DAC Field Name: SalesPersonID</para>
		/// <para>DAC: PX.Objects.FS.FSServiceOrder</para>
		/// </summary>
		public StringValue? Salesperson { get; set; }

		/// <summary>
		/// <para>DAC Field Name: TaxCalcMode</para>
		/// <para>DAC: PX.Objects.FS.FSAppointment</para>
		/// <para>Display Name: Tax Calculation Mode</para>
		/// <para>SQL Type: char(1)</para>
		/// </summary>
		public StringValue? TaxCalculationMode { get; set; }

	}
}