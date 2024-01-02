using System;
using System.Collections.Generic;
using System.Runtime.Serialization;

using Newtonsoft.Json;

using Acumatica.RESTClient.Client;
using Acumatica.RESTClient.ContractBasedApi;
using Acumatica.RESTClient.ContractBasedApi.Model;

namespace Acumatica.Default_22_200_001.Model
{
	[DataContract]
	public class Commissions : Entity
	{

		[DataMember(Name="DefaultSalesperson", EmitDefaultValue=false)]
		public StringValue? DefaultSalesperson { get; set; }

		[DataMember(Name="SalesPersons", EmitDefaultValue=false)]
		public List<SalesPersonDetail>? SalesPersons { get; set; }

	}
}