using System;
using System.Collections.Generic;

using Newtonsoft.Json;

using Acumatica.RESTClient.Client;
using Acumatica.RESTClient.ContractBasedApi;
using Acumatica.RESTClient.ContractBasedApi.Model;

namespace Acumatica.eCommerce_24_200_001.Model
{
	/// <summary>
	/// Corresponds to the screen <c>AR302000</c> in the Acumatica ERP
	/// </summary>
	public class Payment : Acumatica.Default_24_200_001.Model.Payment, ITopLevelEntity
	{

		#region Fields
		/// <summary>
		/// CC payment state description
		/// <para>DAC Field Name: CCPaymentStateDescr</para>
		/// <para>DAC: PX.Objects.AR.ARPayment</para>
		/// <para>Display Name: Processing Status</para>
		/// <para>SQL Type: char(3)</para>
		/// </summary>
		public StringValue? CCProcessingStatus { get; set; }

		/// <summary>
		/// <para>DAC Field Name: SampleRecipRate</para>
		/// <para>DAC: {}</para>
		/// </summary>
		public DecimalValue? ReciprocalRate { get; set; }

		#endregion

		public override string GetEndpointPath()
		{
			return "entity/eCommerce/24.200.001";
		}
	}
}