using System;
using System.Collections.Generic;
using System.Runtime.Serialization;

using Newtonsoft.Json;

using Acumatica.RESTClient.Client;
using Acumatica.RESTClient.ContractBasedApi;
using Acumatica.RESTClient.ContractBasedApi.Model;

namespace Acumatica.Manufacturing_24_200_001.Model
{
	[DataContract]
	public class ConfigurationFeature : Entity, ITopLevelEntity
	{

		[DataMember(Name="Active", EmitDefaultValue=false)]
		public BooleanValue? Active { get; set; }

		[DataMember(Name="AllowNonInventoryOptions", EmitDefaultValue=false)]
		public BooleanValue? AllowNonInventoryOptions { get; set; }

		[DataMember(Name="ConfigurationFeatureAttribute", EmitDefaultValue=false)]
		public List<FeatureAttributes>? ConfigurationFeatureAttribute { get; set; }

		[DataMember(Name="ConfigurationFeatureOption", EmitDefaultValue=false)]
		public List<FeatureOptions>? ConfigurationFeatureOption { get; set; }

		[DataMember(Name="Description", EmitDefaultValue=false)]
		public StringValue? Description { get; set; }

		[DataMember(Name="DisplayOptionAttributes", EmitDefaultValue=false)]
		public BooleanValue? DisplayOptionAttributes { get; set; }

		[DataMember(Name="FeatureID", EmitDefaultValue=false)]
		public StringValue? FeatureID { get; set; }

		[DataMember(Name="PrintResults", EmitDefaultValue=false)]
		public BooleanValue? PrintResults { get; set; }

		public virtual string GetEndpointPath()
		{
			return "entity/MANUFACTURING/24.200.001";
		}
	}
}