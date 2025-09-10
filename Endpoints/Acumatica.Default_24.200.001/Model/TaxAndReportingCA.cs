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

		/// <summary>
		/// The unique identifier of the federal reporting type which the earning type corresponds to, if any.
		/// DAC Field Name: ReportTypeCAN 
		/// DAC: PX.Objects.EP.EPEarningType 
		/// Display Name: Federal Reporting Type 
		/// </summary>
		[DataMember(Name="ReportingType", EmitDefaultValue=false)]
		public StringValue? ReportingType { get; set; }

		/// <summary>
		/// A boolean value that specifies (if set to true) that the earning type represents an additional payment made to an employee outside of their regular wages.
		/// DAC Field Name: IsSupplementalCAN 
		/// DAC: PX.Objects.EP.EPEarningType 
		/// Display Name: Supplemental Income 
		/// </summary>
		[DataMember(Name="SupplementalIncome", EmitDefaultValue=false)]
		public BooleanValue? SupplementalIncome { get; set; }

		[DataMember(Name="TaxDetailsCA", EmitDefaultValue=false)]
		public List<EarningCodeTaxDetailCA>? TaxDetailsCA { get; set; }

		/// <summary>
		/// The user-friendly unique identifier of the wage type. The tax engine uses this value to determine the rate to apply to the earning code.
		/// DAC Field Name: WageTypeCDCAN 
		/// DAC: PX.Objects.EP.EPEarningType 
		/// Display Name: Wage Type 
		/// </summary>
		[DataMember(Name="WageType", EmitDefaultValue=false)]
		public StringValue? WageType { get; set; }

	}
}