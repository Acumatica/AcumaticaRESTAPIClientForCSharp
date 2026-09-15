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
	public class TaxAndReportingUS : Entity
	{

		/// <summary>
		/// A code that determines whether this earning type will appear in Box 12 of the W-2 report and which code it will use.
		/// <para>DAC Field Name: ReportType</para>
		/// <para>DAC: PX.Objects.EP.EPEarningType</para>
		/// <para>Display Name: Reporting Type</para>
		/// </summary>
		[DataMember(Name="ReportingType", EmitDefaultValue=false)]
		public StringValue? ReportingType { get; set; }

		/// <summary>
		/// The method to be used to determine the list of applicable taxes.
		/// <para>DAC Field Name: IncludeType</para>
		/// <para>DAC: PX.Objects.EP.EPEarningType</para>
		/// <para>Display Name: Subject to Taxes</para>
		/// <para>SQL Type: char(3)</para>
		/// </summary>
		[DataMember(Name="SubjecttoTaxes", EmitDefaultValue=false)]
		public StringValue? SubjecttoTaxes { get; set; }

		[DataMember(Name="TaxDetailsUS", EmitDefaultValue=false)]
		public List<EarningCodeTaxDetailUS>? TaxDetailsUS { get; set; }

		/// <summary>
		/// The user-friendly unique identifier of the wage type. The tax engine uses this value to determine the rate to apply to the earning code.
		/// <para>DAC Field Name: WageTypeCD</para>
		/// <para>DAC: PX.Objects.EP.EPEarningType</para>
		/// <para>Display Name: Wage Type</para>
		/// </summary>
		[DataMember(Name="WageType", EmitDefaultValue=false)]
		public StringValue? WageType { get; set; }

		/// <summary>
		/// Names that can be passed in the <c>$expand</c> parameter.
		/// <para>This endpoint uses system contract 5, where a nested entity is expanded
		/// as <c>Parent($expand=Child)</c> rather than <c>Parent/Child</c>, so only the names
		/// that can be expanded directly on this entity are listed here. Use the nested
		/// entity's own <c>Expand</c> class for the inner names.</para>
		/// </summary>
		public static class Expand
		{
			public const string TaxDetailsUS = "TaxDetailsUS";

			//Intentionally excluded
			//public const string All = "TaxDetailsUS";
		}
	}
}