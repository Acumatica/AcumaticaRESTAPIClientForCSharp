using System;
using System.Collections.Generic;
using System.Runtime.Serialization;

using Newtonsoft.Json;

using Acumatica.RESTClient.Client;
using Acumatica.RESTClient.ContractBasedApi;
using Acumatica.RESTClient.ContractBasedApi.Model;

namespace Acumatica.eCommerce_24_200_001.Model
{
	[DataContract]
	public class UnitsOfMeasure : Entity, ITopLevelEntity
	{

		[DataMember(Name="UnitID", EmitDefaultValue=false)]
		public StringValue? UnitID { get; set; }

		[DataMember(Name="Description", EmitDefaultValue=false)]
		public StringValue? Description { get; set; }

		[DataMember(Name="L3Code", EmitDefaultValue=false)]
		public StringValue? L3Code { get; set; }

		[DataMember(Name="Conversion", EmitDefaultValue=false)]
		public List<Units>? Conversion { get; set; }

		public virtual string GetEndpointPath()
		{
			return "entity/eCommerce/24.200.001";
		}
	}
}