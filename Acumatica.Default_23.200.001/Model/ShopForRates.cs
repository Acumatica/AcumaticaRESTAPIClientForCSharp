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
	public class ShopForRates : Entity
	{

		[DataMember(Name="IsManualPackage", EmitDefaultValue=false)]
		public BooleanValue? IsManualPackage { get; set; }

		[DataMember(Name="OrderWeight", EmitDefaultValue=false)]
		public DecimalValue? OrderWeight { get; set; }

		[DataMember(Name="PackageWeight", EmitDefaultValue=false)]
		public DecimalValue? PackageWeight { get; set; }

	}
}