using System;
using System.Collections.Generic;

using Newtonsoft.Json;

using Acumatica.RESTClient.Client;
using Acumatica.RESTClient.ContractBasedApi;
using Acumatica.RESTClient.ContractBasedApi.Model;

namespace Acumatica.Default_24_200_001.Model
{
	/// <summary>
	/// Corresponds to the screen <c>PR201000</c> in the Acumatica ERP
	/// <para>Key Fields: PayGroup, Year</para>
	/// </summary>
	public class PayPeriod : Entity, ITopLevelEntity
	{

		public DateTimeValue? LastModifiedDateTime { get; set; }

		/// <summary>
		/// <para>DAC Field Name: FinPeriods</para>
		/// <para>DAC: PX.Objects.PR.PRPayGroupYear</para>
		/// <para>Display Name: Number of Periods</para>
		/// </summary>
		public ShortValue? NumberofPeriods { get; set; }

		/// <summary>
		/// <para>DAC Field Name: OverrideFinPeriods</para>
		/// <para>DAC: PX.Objects.PR.PRPayGroupYear</para>
		/// </summary>
		public BooleanValue? Override { get; set; }

		/// <summary>
		/// <para>DAC Field Name: PayGroupID</para>
		/// <para>DAC: PX.Objects.PR.PRPayGroupYear</para>
		/// <para>Display Name: Pay Group</para>
		/// <para>SQL Type: nvarchar(15)</para>
		/// Key Field
		/// </summary>
		public StringValue? PayGroup { get; set; }

		public List<PaymentPeriod>? PaymentPeriods { get; set; }

		/// <summary>
		/// <para>DAC: PX.Objects.PR.PRPayGroupYear</para>
		/// <para>Display Name: Start Date</para>
		/// </summary>
		public DateTimeValue? StartDate { get; set; }

		/// <summary>
		/// <para>DAC: PX.Objects.PR.PRPayGroupYear</para>
		/// <para>SQL Type: char(4)</para>
		/// Key Field
		/// </summary>
		public StringValue? Year { get; set; }

		public static class Expand
		{
			public const string Files = "Files";
			public const string Translations = "Translations";
			public const string PaymentPeriods = "PaymentPeriods";
			public const string PaymentPeriods_Files = "PaymentPeriods/Files";

			//Intentionally excluded
			//public const string All = "Files,Translations,PaymentPeriods,PaymentPeriods/Files";
		}
		public virtual string GetEndpointPath()
		{
			return "entity/Default/24.200.001";
		}
	}
}