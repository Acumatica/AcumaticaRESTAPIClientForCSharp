using System;
using System.Collections.Generic;
using System.Runtime.Serialization;

using Newtonsoft.Json;

using Acumatica.RESTClient.Client;
using Acumatica.RESTClient.ContractBasedApi;
using Acumatica.RESTClient.ContractBasedApi.Model;

namespace Acumatica.Manufacturing_21_200_001.Model
{
	[DataContract]
	public class ConfiguratorPreferences : Entity, ITopLevelEntity
	{

		[DataMember(Name="Calculate", EmitDefaultValue=false)]
		public StringValue? Calculate { get; set; }

		[DataMember(Name="CompletionRequiredBeforeProduction", EmitDefaultValue=false)]
		public BooleanValue? CompletionRequiredBeforeProduction { get; set; }

		[DataMember(Name="ConfigKeyFormat", EmitDefaultValue=false)]
		public StringValue? ConfigKeyFormat { get; set; }

		[DataMember(Name="ConfigNumberingSequence", EmitDefaultValue=false)]
		public StringValue? ConfigNumberingSequence { get; set; }

		[DataMember(Name="DefaultKeyNumberSequence", EmitDefaultValue=false)]
		public StringValue? DefaultKeyNumberSequence { get; set; }

		[DataMember(Name="DefaultRevision", EmitDefaultValue=false)]
		public StringValue? DefaultRevision { get; set; }

		[DataMember(Name="EnableDiscount", EmitDefaultValue=false)]
		public BooleanValue? EnableDiscount { get; set; }

		[DataMember(Name="EnablePrice", EmitDefaultValue=false)]
		public BooleanValue? EnablePrice { get; set; }

		[DataMember(Name="EnableSubitem", EmitDefaultValue=false)]
		public BooleanValue? EnableSubitem { get; set; }

		[DataMember(Name="EnableWarehouse", EmitDefaultValue=false)]
		public BooleanValue? EnableWarehouse { get; set; }

		[DataMember(Name="HidePriceDetails", EmitDefaultValue=false)]
		public BooleanValue? HidePriceDetails { get; set; }

		[DataMember(Name="OverrideDefaultonConfigurationAllowCalculateOverride", EmitDefaultValue=false)]
		public BooleanValue? OverrideDefaultonConfigurationAllowCalculateOverride { get; set; }

		[DataMember(Name="OverrideDefaultonConfigurationAllowRollupOverride", EmitDefaultValue=false)]
		public BooleanValue? OverrideDefaultonConfigurationAllowRollupOverride { get; set; }

		[DataMember(Name="Rollup", EmitDefaultValue=false)]
		public StringValue? Rollup { get; set; }

		public virtual string GetEndpointPath()
		{
			return "entity/MANUFACTURING/21.200.001";
		}
	}
}