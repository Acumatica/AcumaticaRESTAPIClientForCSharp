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
	/// Corresponds to the screen <c>SO301000</c> in the Acumatica ERP
	/// </summary>
	[DataContract]
	public class SalesOrder : Acumatica.Default_24_200_001.Model.SalesOrder, ITopLevelEntity
	{

		[DataMember(Name="ExternalQuoteNbr", EmitDefaultValue=false)]
		public StringValue? ExternalQuoteNbr { get; set; }

		[DataMember(Name="ExternalQuoteStatus", EmitDefaultValue=false)]
		public StringValue? ExternalQuoteStatus { get; set; }

		public override string GetEndpointPath()
		{
			return "entity/eCommerce/24.200.001";
		}
	}
}