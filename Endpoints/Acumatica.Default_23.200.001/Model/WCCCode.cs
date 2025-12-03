using System;
using System.Collections.Generic;
using System.Runtime.Serialization;

using Newtonsoft.Json;

using Acumatica.RESTClient.Client;
using Acumatica.RESTClient.ContractBasedApi;
using Acumatica.RESTClient.ContractBasedApi.Model;

namespace Acumatica.Default_23_200_001.Model
{
	[DataContract]
	public class WCCCode : Entity
	{

		/// <summary>
		/// <para>DAC Field Name: IsActive</para>
		/// <para>DAC: PX.Objects.PM.PMWorkCode</para>
		/// </summary>
		[DataMember(Name="Active", EmitDefaultValue=false)]
		public BooleanValue? Active { get; set; }

		/// <summary>
		/// <para>DAC: PX.Objects.PM.PMWorkCode</para>
		/// <para>SQL Type: nvarchar(255)</para>
		/// </summary>
		[DataMember(Name="Description", EmitDefaultValue=false)]
		public StringValue? Description { get; set; }

		[DataMember(Name="LastModifiedDateTime", EmitDefaultValue=false)]
		public DateTimeValue? LastModifiedDateTime { get; set; }

		/// <summary>
		/// <para>DAC Field Name: WorkCodeID</para>
		/// <para>DAC: PX.Objects.PM.PMWorkCode</para>
		/// <para>Display Name: WCC Code</para>
		/// <para>SQL Type: nvarchar(15)</para>
		/// Key Field
		/// </summary>
		[DataMember(Name="wcccode", EmitDefaultValue=false)]
		public StringValue? wcccode { get; set; }

		[DataMember(Name="WCCCodeCostCodeSources", EmitDefaultValue=false)]
		public List<WCCCodeCostCodeSource>? WCCCodeCostCodeSources { get; set; }

		[DataMember(Name="WCCCodeLaborItemSources", EmitDefaultValue=false)]
		public List<WCCCodeLaborItemSource>? WCCCodeLaborItemSources { get; set; }

		[DataMember(Name="WCCCodeMaxInsurableWages", EmitDefaultValue=false)]
		public List<WCCCodeMaxInsurableWage>? WCCCodeMaxInsurableWages { get; set; }

		[DataMember(Name="WCCCodeProjectSources", EmitDefaultValue=false)]
		public List<WCCCodeProjectSource>? WCCCodeProjectSources { get; set; }

		[DataMember(Name="WCCCodeRates", EmitDefaultValue=false)]
		public List<WCCCodeRate>? WCCCodeRates { get; set; }

	}
}