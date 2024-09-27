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
	public class OrderRisks : Entity
	{

		/// <summary>
		/// DAC: {} 
		/// </summary>
		[DataMember(Name="Message", EmitDefaultValue=false)]
		public StringValue? Message { get; set; }

		/// <summary>
		/// DAC: {} 
		/// </summary>
		[DataMember(Name="Recommendation", EmitDefaultValue=false)]
		public StringValue? Recommendation { get; set; }

		/// <summary>
		/// DAC: {} 
		/// </summary>
		[DataMember(Name="Score", EmitDefaultValue=false)]
		public DecimalValue? Score { get; set; }

	}
}