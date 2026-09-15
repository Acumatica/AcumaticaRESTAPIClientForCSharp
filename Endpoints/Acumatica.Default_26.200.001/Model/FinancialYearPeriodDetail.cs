using System;
using System.Collections.Generic;
using System.Runtime.Serialization;

using Newtonsoft.Json;

using Acumatica.RESTClient.Client;
using Acumatica.RESTClient.ContractBasedApi;
using Acumatica.RESTClient.ContractBasedApi.Model;

namespace Acumatica.Default_26_200_001.Model
{
	[DataContract]
	public class FinancialYearPeriodDetail : Entity
	{

		/// <summary>
		/// The description of the period.
		/// <para>DAC Field Name: Descr</para>
		/// <para>DAC: PX.Objects.GL.FinPeriodSetup</para>
		/// <para>SQL Type: nvarchar(60)</para>
		/// </summary>
		[DataMember(Name="Description", EmitDefaultValue=false)]
		public StringValue? Description { get; set; }

		/// <summary>
		/// The field used to display and edit the EndDate of the period (inclusive) in the UI.
		/// <para>DAC Field Name: EndDateUI</para>
		/// <para>DAC: PX.Objects.GL.FinPeriodSetup</para>
		/// <para>Display Name: End Date</para>
		/// </summary>
		[DataMember(Name="EndDate", EmitDefaultValue=false)]
		public DateOnlyValue? EndDate { get; set; }

		/// <summary>
		/// The number of the period in a year.
		/// <para>DAC: PX.Objects.GL.FinPeriodSetup</para>
		/// <para>Display Name: Period Nbr.</para>
		/// <para>SQL Type: char(2)</para>
		/// Key Field
		/// </summary>
		[DataMember(Name="PeriodNbr", EmitDefaultValue=false)]
		public StringValue? PeriodNbr { get; set; }

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

			//Intentionally excluded
			//public const string All = "Files";
		}
	}
}