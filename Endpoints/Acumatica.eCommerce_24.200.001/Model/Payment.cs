using System;
using System.Collections.Generic;
using System.Runtime.Serialization;

using Newtonsoft.Json;

using Acumatica.RESTClient.Client;
using Acumatica.RESTClient.ContractBasedApi;
using Acumatica.RESTClient.ContractBasedApi.Model;

namespace Acumatica.eCommerce_24_200_001.Model
{
	/// <summary>
	/// Corresponds to the screen <c>AR302000</c> in the Acumatica ERP
	/// </summary>
	[DataContract]
	public class Payment : Acumatica.Default_24_200_001.Model.Payment, ITopLevelEntity
	{

		/// <summary>
		/// <para>DAC Field Name: SampleRecipRate</para>
		/// <para>DAC: {}</para>
		/// </summary>
		[DataMember(Name="ReciprocalRate", EmitDefaultValue=false)]
		public DecimalValue? ReciprocalRate { get; set; }

		/// <summary>
		/// CC payment state description
		/// <para>DAC Field Name: CCPaymentStateDescr</para>
		/// <para>DAC: PX.Objects.AR.ARPayment</para>
		/// <para>Display Name: Processing Status</para>
		/// <para>SQL Type: char(3)</para>
		/// </summary>
		[DataMember(Name="CCProcessingStatus", EmitDefaultValue=false)]
		public StringValue? CCProcessingStatus { get; set; }

		public override string GetEndpointPath()
		{
			return "entity/eCommerce/24.200.001";
		}
	}
}