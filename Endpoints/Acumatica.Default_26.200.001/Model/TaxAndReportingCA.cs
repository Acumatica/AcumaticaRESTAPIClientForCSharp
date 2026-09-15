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
	public class TaxAndReportingCA : Entity
	{

		/// <summary>
		/// The unique identifier of the federal reporting type which the earning type corresponds to, if any.
		/// <para>DAC Field Name: ReportTypeCAN</para>
		/// <para>DAC: PX.Objects.EP.EPEarningType</para>
		/// <para>Display Name: Federal Reporting Type</para>
		/// </summary>
		[DataMember(Name="ReportingType", EmitDefaultValue=false)]
		public StringValue? ReportingType { get; set; }

		[DataMember(Name="TaxDetailsCA", EmitDefaultValue=false)]
		public List<EarningCodeTaxDetailCA>? TaxDetailsCA { get; set; }

		/// <summary>
		/// The user-friendly unique identifier of the wage type. The tax engine uses this value to determine the rate to apply to the earning code.
		/// <para>DAC Field Name: WageTypeCDCAN</para>
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
			public const string TaxDetailsCA = "TaxDetailsCA";

			//Intentionally excluded
			//public const string All = "TaxDetailsCA";
		}
	}
}