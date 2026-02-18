using System;
using System.Collections.Generic;

using Newtonsoft.Json;

using Acumatica.RESTClient.Client;
using Acumatica.RESTClient.ContractBasedApi;
using Acumatica.RESTClient.ContractBasedApi.Model;

namespace Acumatica.Default_24_200_001.Model
{
	/// <summary>
	/// Corresponds to the screen <c>GL201100</c> in the Acumatica ERP
	/// <para>Key Fields: Company, FinancialYear</para>
	/// </summary>
	public class CompanyFinancialPeriod : Entity, ITopLevelEntity
	{

		/// <summary>
		/// <para>DAC Field Name: OrganizationID</para>
		/// <para>DAC: PX.Objects.GL.FinPeriods.OrganizationFinYear</para>
		/// Key Field
		/// </summary>
		public StringValue? Company { get; set; }

		public List<FinancialPeriodDetail>? Details { get; set; }

		/// <summary>
		/// Key field.The financial year.
		/// <para>DAC Field Name: Year</para>
		/// <para>DAC: PX.Objects.GL.FinPeriods.OrganizationFinYear</para>
		/// <para>Display Name: Financial Year</para>
		/// <para>SQL Type: char(4)</para>
		/// Key Field
		/// </summary>
		public StringValue? FinancialYear { get; set; }

		/// <summary>
		/// The number of periods in the year.
		/// <para>DAC Field Name: FinPeriods</para>
		/// <para>DAC: PX.Objects.GL.FinPeriods.OrganizationFinYear</para>
		/// <para>Display Name: Number of Periods</para>
		/// </summary>
		public ShortValue? NbrOfPeriods { get; set; }

		/// <summary>
		/// The start date of the year.
		/// <para>DAC: PX.Objects.GL.FinPeriods.OrganizationFinYear</para>
		/// <para>Display Name: Start Date</para>
		/// </summary>
		public DateTimeValue? StartDate { get; set; }

		public static class Expand
		{
			public const string Files = "Files";
			public const string Translations = "Translations";
			public const string Details = "Details";
			public const string Details_Files = "Details/Files";

			//Intentionally excluded
			//public const string All = "Files,Translations,Details,Details/Files";
		}
		public virtual string GetEndpointPath()
		{
			return "entity/Default/24.200.001";
		}
	}
}