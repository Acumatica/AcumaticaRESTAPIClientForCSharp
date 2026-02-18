using System;
using System.Collections.Generic;

using Newtonsoft.Json;

using Acumatica.RESTClient.Client;
using Acumatica.RESTClient.ContractBasedApi;
using Acumatica.RESTClient.ContractBasedApi.Model;

namespace Acumatica.Default_25_200_001.Model
{
	public class PaymentPeriod : Entity
	{

		/// <summary>
		/// <para>DAC Field Name: Descr</para>
		/// <para>DAC: PX.Objects.PR.PRPayGroupPeriod</para>
		/// <para>SQL Type: nvarchar(60)</para>
		/// </summary>
		public StringValue? Description { get; set; }

		/// <summary>
		/// <para>DAC Field Name: EndDateUI</para>
		/// <para>DAC: PX.Objects.PR.PRPayGroupPeriod</para>
		/// <para>Display Name: End Date</para>
		/// </summary>
		public DateTimeValue? EndDate { get; set; }

		/// <summary>
		/// <para>DAC: PX.Objects.PR.PRPayGroupPeriod</para>
		/// <para>Display Name: Financial Year</para>
		/// <para>SQL Type: char(4)</para>
		/// </summary>
		public StringValue? FinYear { get; set; }

		public DateTimeValue? LastModifiedDateTime { get; set; }

		/// <summary>
		/// <para>DAC Field Name: FinPeriodID</para>
		/// <para>DAC: PX.Objects.PR.PRPayGroupPeriod</para>
		/// <para>Display Name: Pay Period ID</para>
		/// <para>SQL Type: char(6)</para>
		/// Key Field
		/// </summary>
		public StringValue? PayPeriodID { get; set; }

		/// <summary>
		/// <para>DAC: PX.Objects.PR.PRPayGroupPeriod</para>
		/// <para>Display Name: Period Nbr.</para>
		/// <para>SQL Type: char(2)</para>
		/// </summary>
		public StringValue? PeriodNbr { get; set; }

		/// <summary>
		/// <para>DAC: PX.Objects.PR.PRPayGroupYear</para>
		/// <para>Display Name: Start Date</para>
		/// </summary>
		public DateTimeValue? StartDate { get; set; }

		/// <summary>
		/// <para>DAC: PX.Objects.PR.PRPayGroupPeriod</para>
		/// <para>Display Name: Transaction Date</para>
		/// </summary>
		public DateTimeValue? TransactionDate { get; set; }

	}
}