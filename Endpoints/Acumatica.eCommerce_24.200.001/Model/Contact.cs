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
	/// Corresponds to the screen <c>CR302000</c> in the Acumatica ERP
	/// </summary>
	[DataContract]
	public class Contact : Acumatica.Default_24_200_001.Model.Contact, ITopLevelEntity
	{

		[DataMember(Name="ExtUserRole", EmitDefaultValue=false)]
		public StringValue? ExtUserRole { get; set; }

		public override string GetEndpointPath()
		{
			return "entity/eCommerce/24.200.001";
		}
	}
}