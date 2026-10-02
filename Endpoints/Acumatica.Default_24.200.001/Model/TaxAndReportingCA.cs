using System;
using System.Collections.Generic;
using System.Runtime.Serialization;

using Newtonsoft.Json;

using Acumatica.RESTClient.Client;
using Acumatica.RESTClient.ContractBasedApi;
using Acumatica.RESTClient.ContractBasedApi.Model;

namespace Acumatica.Default_24_200_001.Model
{
	[DataContract]
	public class TaxAndReportingCA : Entity
	{

		#region Fields
		/// <summary>
		/// The user-friendly unique identifier of the wage type. The tax engine uses this value to determine the rate to apply to the earning code.
		/// <para>DAC Field Name: WageTypeCDCAN</para>
		/// <para>DAC: PX.Objects.EP.EPEarningType</para>
		/// <para>Display Name: Wage Type</para>
		/// </summary>
		[DataMember(Name="WageType", EmitDefaultValue=false)]
		public StringValue? WageType { get; set; }

		/// <summary>
		/// The unique identifier of the federal reporting type which the earning type corresponds to, if any.
		/// <para>DAC Field Name: ReportTypeCAN</para>
		/// <para>DAC: PX.Objects.EP.EPEarningType</para>
		/// <para>Display Name: Federal Reporting Type</para>
		/// </summary>
		[DataMember(Name="ReportingType", EmitDefaultValue=false)]
		public StringValue? ReportingType { get; set; }

		/// <summary>
		/// <para>DAC Field Name: IsSupplementalCAN</para>
		/// <para>DAC: PX.Objects.EP.EPEarningType</para>
		/// </summary>
		[DataMember(Name="SupplementalIncome", EmitDefaultValue=false)]
		public BooleanValue? SupplementalIncome { get; set; }

		#endregion

		#region Details
		[DataMember(Name="TaxDetailsCA", EmitDefaultValue=false)]
		public List<EarningCodeTaxDetailCA>? TaxDetailsCA { get; set; }

		#endregion

	}
}