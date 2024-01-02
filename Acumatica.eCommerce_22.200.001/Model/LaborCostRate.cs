using System.Collections.Generic;
using System.Runtime.Serialization;

using Newtonsoft.Json;

using Acumatica.RESTClient.Client;
using Acumatica.RESTClient.ContractBasedApi;
using Acumatica.RESTClient.ContractBasedApi.Model;

namespace Acumatica.eCommerce_22_200_001.Model
{
	[DataContract]
	public class LaborCostRate : Entity, ITopLevelEntity
	{

		[DataMember(Name="EffectiveDate", EmitDefaultValue=false)]
		public DateTimeValue? EffectiveDate { get; set; }

		[DataMember(Name="Employee", EmitDefaultValue=false)]
		public StringValue? Employee { get; set; }

		[DataMember(Name="LaborItem", EmitDefaultValue=false)]
		public StringValue? LaborItem { get; set; }

		[DataMember(Name="Project", EmitDefaultValue=false)]
		public StringValue? Project { get; set; }

		[DataMember(Name="ProjectTask", EmitDefaultValue=false)]
		public StringValue? ProjectTask { get; set; }

		[DataMember(Name="LaborRateType", EmitDefaultValue=false)]
		public StringValue? LaborRateType { get; set; }

		[DataMember(Name="UnionLocal", EmitDefaultValue=false)]
		public StringValue? UnionLocal { get; set; }

		[DataMember(Name="Results", EmitDefaultValue=false)]
		public List<LaborRate>? Results { get; set; }

		public virtual string GetEndpointPath()
		{
			return "entity/eCommerce/22.200.001";
		}
	}
}