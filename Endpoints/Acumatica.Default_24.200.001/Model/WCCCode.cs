using System;
using System.Collections.Generic;

using Newtonsoft.Json;

using Acumatica.RESTClient.Client;
using Acumatica.RESTClient.ContractBasedApi;
using Acumatica.RESTClient.ContractBasedApi.Model;

namespace Acumatica.Default_24_200_001.Model
{
	public class WCCCode : Entity
	{

		/// <summary>
		/// <para>DAC Field Name: IsActive</para>
		/// <para>DAC: PX.Objects.PM.PMWorkCode</para>
		/// </summary>
		public BooleanValue? Active { get; set; }

		/// <summary>
		/// <para>DAC: PX.Objects.PM.PMWorkCode</para>
		/// <para>SQL Type: nvarchar(255)</para>
		/// </summary>
		public StringValue? Description { get; set; }

		public DateTimeValue? LastModifiedDateTime { get; set; }

		/// <summary>
		/// <para>DAC Field Name: WorkCodeID</para>
		/// <para>DAC: PX.Objects.PM.PMWorkCode</para>
		/// <para>Display Name: WCC Code</para>
		/// <para>SQL Type: nvarchar(15)</para>
		/// Key Field
		/// </summary>
		public StringValue? wcccode { get; set; }

		public List<WCCCodeCostCodeSource>? WCCCodeCostCodeSources { get; set; }

		public List<WCCCodeLaborItemSource>? WCCCodeLaborItemSources { get; set; }

		public List<WCCCodeMaxInsurableWage>? WCCCodeMaxInsurableWages { get; set; }

		public List<WCCCodeProjectSource>? WCCCodeProjectSources { get; set; }

		public List<WCCCodeRate>? WCCCodeRates { get; set; }

	}
}