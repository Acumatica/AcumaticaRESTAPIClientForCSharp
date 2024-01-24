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
	public class SalesTerritory : Entity, ITopLevelEntity
	{

		[DataMember(Name="SalesTerritoryID", EmitDefaultValue=false)]
		public StringValue? SalesTerritoryID { get; set; }

		[DataMember(Name="SalesTerritoryName", EmitDefaultValue=false)]
		public StringValue? SalesTerritoryName { get; set; }

		[DataMember(Name="Active", EmitDefaultValue=false)]
		public BooleanValue? Active { get; set; }

		[DataMember(Name="TerritoryType", EmitDefaultValue=false)]
		public StringValue? TerritoryType { get; set; }

		[DataMember(Name="Country", EmitDefaultValue=false)]
		public StringValue? Country { get; set; }

		[DataMember(Name="Countries", EmitDefaultValue=false)]
		public List<CountryDetail>? Countries { get; set; }

		[DataMember(Name="CountryStates", EmitDefaultValue=false)]
		public List<StateDetail>? CountryStates { get; set; }

		public virtual string GetEndpointPath()
		{
			return "entity/Default/22.200.001";
		}
	}
}