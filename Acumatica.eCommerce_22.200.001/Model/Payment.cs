using System;
using System.Collections.Generic;
using System.Runtime.Serialization;

using Newtonsoft.Json;

using Acumatica.RESTClient.Client;
using Acumatica.RESTClient.ContractBasedApi;
using Acumatica.RESTClient.ContractBasedApi.Model;

namespace Acumatica.eCommerce_22_200_001.Model
{
	/// <summary>
	/// Corresponds to the screen AR302000 in the Acumatica ERP
	/// </summary>
	[DataContract]
	public class Payment : Acumatica.Default_22_200_001.Model.Payment, ITopLevelEntity
	{

		[DataMember(Name="IsCCPayment", EmitDefaultValue=false)]
		public BooleanValue? IsCCPayment { get; set; }

		[DataMember(Name="Charges", EmitDefaultValue=false)]
		public List<PaymentCharge>? Charges { get; set; }

		public override string GetEndpointPath()
		{
			return "entity/eCommerce/22.200.001";
		}
	}
}