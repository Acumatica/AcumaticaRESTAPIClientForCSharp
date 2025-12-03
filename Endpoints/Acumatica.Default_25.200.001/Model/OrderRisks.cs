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
	public class OrderRisks : Entity
	{

		/// <summary>
		/// <para>DAC: {}</para>
		/// </summary>
		[DataMember(Name="Message", EmitDefaultValue=false)]
		public StringValue? Message { get; set; }

		/// <summary>
		/// <para>DAC: {}</para>
		/// </summary>
		[DataMember(Name="Recommendation", EmitDefaultValue=false)]
		public StringValue? Recommendation { get; set; }

		/// <summary>
		/// <para>DAC: {}</para>
		/// </summary>
		[DataMember(Name="Score", EmitDefaultValue=false)]
		public DecimalValue? Score { get; set; }

	}
}