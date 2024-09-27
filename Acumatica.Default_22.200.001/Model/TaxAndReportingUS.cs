using System;
using System.Collections.Generic;
using System.Runtime.Serialization;

using Newtonsoft.Json;

using Acumatica.RESTClient.Client;
using Acumatica.RESTClient.ContractBasedApi;
using Acumatica.RESTClient.ContractBasedApi.Model;

namespace Acumatica.Default_22_200_001.Model
{
	[DataContract]
	public class TaxAndReportingUS : Entity
	{

		/// <summary>
		/// A code that determines whether this earning type will appear in Box 12 of the W-2 report and which code it will use.
		/// DAC Field Name: ReportType 
		/// DAC: PX.Objects.EP.EPEarningType 
		/// Display Name: Reporting Type 
		/// </summary>
		[DataMember(Name="ReportingType", EmitDefaultValue=false)]
		public StringValue? ReportingType { get; set; }

		/// <summary>
		/// The method to be used to determine the list of applicable taxes.
		/// DAC Field Name: IncludeType 
		/// DAC: PX.Objects.EP.EPEarningType 
		/// Display Name: Subject to Taxes 
		/// SQL Type: char(3) 
		/// </summary>
		[DataMember(Name="SubjecttoTaxes", EmitDefaultValue=false)]
		public StringValue? SubjecttoTaxes { get; set; }

		[DataMember(Name="TaxDetailsUS", EmitDefaultValue=false)]
		public List<EarningCodeTaxDetailUS>? TaxDetailsUS { get; set; }

		/// <summary>
		/// The user-friendly unique identifier of the wage type. The tax engine uses this value to determine the rate to apply to the earning code.
		/// DAC Field Name: WageTypeCD 
		/// DAC: PX.Objects.EP.EPEarningType 
		/// Display Name: Wage Type 
		/// </summary>
		[DataMember(Name="WageType", EmitDefaultValue=false)]
		public StringValue? WageType { get; set; }

	}
}