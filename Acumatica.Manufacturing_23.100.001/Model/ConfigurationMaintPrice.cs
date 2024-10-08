using System;
using System.Collections.Generic;
using System.Runtime.Serialization;

using Newtonsoft.Json;

using Acumatica.RESTClient.Client;
using Acumatica.RESTClient.ContractBasedApi;
using Acumatica.RESTClient.ContractBasedApi.Model;

namespace Acumatica.Manufacturing_23_100_001.Model
{
	[DataContract]
	public class ConfigurationMaintPrice : Entity
	{

		/// <summary>
		/// DAC Field Name: PriceCalc 
		/// DAC: PX.Objects.AM.AMConfiguration 
		/// SQL Type: char(1) 
		/// </summary>
		[DataMember(Name="Calculate", EmitDefaultValue=false)]
		public StringValue? Calculate { get; set; }

		/// <summary>
		/// DAC Field Name: PriceRollup 
		/// DAC: PX.Objects.AM.AMConfiguration 
		/// SQL Type: char(2) 
		/// </summary>
		[DataMember(Name="Rollup", EmitDefaultValue=false)]
		public StringValue? Rollup { get; set; }

	}
}