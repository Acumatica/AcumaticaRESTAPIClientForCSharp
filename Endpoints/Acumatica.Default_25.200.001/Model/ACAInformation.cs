using System;
using System.Collections.Generic;
using System.Runtime.Serialization;

using Newtonsoft.Json;

using Acumatica.RESTClient.Client;
using Acumatica.RESTClient.ContractBasedApi;
using Acumatica.RESTClient.ContractBasedApi.Model;

namespace Acumatica.Default_25_200_001.Model
{
	[DataContract]
	public class ACAInformation : Entity
	{

		[DataMember(Name="ACAInfoDetails", EmitDefaultValue=false)]
		public List<ACAInfoDetail>? ACAInfoDetails { get; set; }

		/// <summary>
		/// <para>DAC Field Name: MinimumIndividualContribution</para>
		/// <para>DAC: PX.Objects.PR.PRDeductCode</para>
		/// <para>Display Name: Minimum Individual Contribution</para>
		/// </summary>
		[DataMember(Name="MinIndividualContribution", EmitDefaultValue=false)]
		public DecimalValue? MinIndividualContribution { get; set; }

	}
}