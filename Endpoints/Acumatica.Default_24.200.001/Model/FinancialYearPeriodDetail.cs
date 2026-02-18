using System;
using System.Collections.Generic;

using Newtonsoft.Json;

using Acumatica.RESTClient.Client;
using Acumatica.RESTClient.ContractBasedApi;
using Acumatica.RESTClient.ContractBasedApi.Model;

namespace Acumatica.Default_24_200_001.Model
{
	public class FinancialYearPeriodDetail : Entity
	{

		/// <summary>
		/// The description of the period.
		/// <para>DAC Field Name: Descr</para>
		/// <para>DAC: PX.Objects.GL.FinPeriodSetup</para>
		/// <para>SQL Type: nvarchar(60)</para>
		/// </summary>
		public StringValue? Description { get; set; }

		/// <summary>
		/// The field used to display and edit the EndDate of the period (inclusive) in the UI.
		/// <para>DAC Field Name: EndDateUI</para>
		/// <para>DAC: PX.Objects.GL.FinPeriodSetup</para>
		/// <para>Display Name: End Date</para>
		/// </summary>
		public DateTimeValue? EndDate { get; set; }

		/// <summary>
		/// The number of the period in a year.
		/// <para>DAC: PX.Objects.GL.FinPeriodSetup</para>
		/// <para>Display Name: Period Nbr.</para>
		/// <para>SQL Type: char(2)</para>
		/// Key Field
		/// </summary>
		public StringValue? PeriodNbr { get; set; }

		public DateTimeValue? StartDate { get; set; }

	}
}