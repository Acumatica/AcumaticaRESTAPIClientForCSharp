using System;
using System.Collections.Generic;
using System.Runtime.Serialization;

using Newtonsoft.Json;

using Acumatica.RESTClient.Client;
using Acumatica.RESTClient.ContractBasedApi;
using Acumatica.RESTClient.ContractBasedApi.Model;

namespace Acumatica.Default_26_200_001.Model
{
	/// <summary>
	/// Corresponds to the screen <c>GL201100</c> in the Acumatica ERP
	/// <para>Key Fields: Company, FinancialYear</para>
	/// </summary>
	[DataContract]
	public class CompanyFinancialPeriod : Entity, ITopLevelEntity
	{

		/// <summary>
		/// <para>DAC Field Name: OrganizationID</para>
		/// <para>DAC: PX.Objects.GL.FinPeriods.OrganizationFinYear</para>
		/// Key Field
		/// </summary>
		[DataMember(Name="Company", EmitDefaultValue=false)]
		public StringValue? Company { get; set; }

		[DataMember(Name="Details", EmitDefaultValue=false)]
		public List<FinancialPeriodDetail>? Details { get; set; }

		/// <summary>
		/// Key field.The financial year.
		/// <para>DAC Field Name: Year</para>
		/// <para>DAC: PX.Objects.GL.FinPeriods.OrganizationFinYear</para>
		/// <para>Display Name: Financial Year</para>
		/// <para>SQL Type: char(4)</para>
		/// Key Field
		/// </summary>
		[DataMember(Name="FinancialYear", EmitDefaultValue=false)]
		public StringValue? FinancialYear { get; set; }

		/// <summary>
		/// The number of periods in the year.
		/// <para>DAC Field Name: FinPeriods</para>
		/// <para>DAC: PX.Objects.GL.FinPeriods.OrganizationFinYear</para>
		/// <para>Display Name: Number of Periods</para>
		/// </summary>
		[DataMember(Name="NbrOfPeriods", EmitDefaultValue=false)]
		public ShortValue? NbrOfPeriods { get; set; }

		/// <summary>
		/// The start date of the year.
		/// <para>DAC: PX.Objects.GL.FinPeriods.OrganizationFinYear</para>
		/// <para>Display Name: Start Date</para>
		/// </summary>
		[DataMember(Name="StartDate", EmitDefaultValue=false)]
		public DateOnlyValue? StartDate { get; set; }

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
			public const string Translations = "Translations";
			public const string Details = "Details";

			//Intentionally excluded
			//public const string All = "Files,Translations,Details";
		}
		public virtual string GetEndpointPath()
		{
			return "entity/Default/26.200.001";
		}
	}
}