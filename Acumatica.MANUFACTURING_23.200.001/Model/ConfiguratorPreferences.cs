using System;
using System.Collections.Generic;
using System.Runtime.Serialization;

using Newtonsoft.Json;

using Acumatica.RESTClient.Client;
using Acumatica.RESTClient.ContractBasedApi;
using Acumatica.RESTClient.ContractBasedApi.Model;

namespace Acumatica.Manufacturing_23_200_001.Model
{
	/// <summary>
	/// Corresponds to the screen AM104000 in the Acumatica ERP
	/// </summary>
	[DataContract]
	public class ConfiguratorPreferences : Entity, ITopLevelEntity
	{

		/// <summary>
		/// 
		/// Display Name:
		/// DAC Field Name: Calculate 
		/// DAC: PX.Objects.AM.AMConfiguratorSetup 
		/// </summary>
		/// <remarks>
		/// 
		/// </remarks>
		[DataMember(Name="Calculate", EmitDefaultValue=false)]
		public StringValue? Calculate { get; set; }

		/// <summary>
		/// 
		/// Display Name:
		/// DAC Field Name: IsCompletionRequired 
		/// DAC: PX.Objects.AM.AMConfiguratorSetup 
		/// </summary>
		/// <remarks>
		/// 
		/// </remarks>
		[DataMember(Name="CompletionRequiredBeforeProduction", EmitDefaultValue=false)]
		public BooleanValue? CompletionRequiredBeforeProduction { get; set; }

		/// <summary>
		/// 
		/// Display Name:
		/// DAC Field Name: ConfigKeyFormat 
		/// DAC: PX.Objects.AM.AMConfiguratorSetup 
		/// </summary>
		/// <remarks>
		/// 
		/// </remarks>
		[DataMember(Name="ConfigKeyFormat", EmitDefaultValue=false)]
		public StringValue? ConfigKeyFormat { get; set; }

		/// <summary>
		/// 
		/// Display Name:
		/// DAC Field Name: ConfigNumberingID 
		/// DAC: PX.Objects.AM.AMConfiguratorSetup 
		/// </summary>
		/// <remarks>
		/// 
		/// </remarks>
		[DataMember(Name="ConfigNumberingSequence", EmitDefaultValue=false)]
		public StringValue? ConfigNumberingSequence { get; set; }

		/// <summary>
		/// 
		/// Display Name:
		/// DAC Field Name: DefaultKeyNumberingID 
		/// DAC: PX.Objects.AM.AMConfiguratorSetup 
		/// </summary>
		/// <remarks>
		/// 
		/// </remarks>
		[DataMember(Name="DefaultKeyNumberSequence", EmitDefaultValue=false)]
		public StringValue? DefaultKeyNumberSequence { get; set; }

		/// <summary>
		/// 
		/// Display Name:
		/// DAC Field Name: DfltRevisionNbr 
		/// DAC: PX.Objects.AM.AMConfiguratorSetup 
		/// </summary>
		/// <remarks>
		/// 
		/// </remarks>
		[DataMember(Name="DefaultRevision", EmitDefaultValue=false)]
		public StringValue? DefaultRevision { get; set; }

		/// <summary>
		/// 
		/// Display Name:
		/// DAC Field Name: EnableDiscount 
		/// DAC: PX.Objects.AM.AMConfiguratorSetup 
		/// </summary>
		/// <remarks>
		/// 
		/// </remarks>
		[DataMember(Name="EnableDiscount", EmitDefaultValue=false)]
		public BooleanValue? EnableDiscount { get; set; }

		/// <summary>
		/// 
		/// Display Name:
		/// DAC Field Name: EnablePrice 
		/// DAC: PX.Objects.AM.AMConfiguratorSetup 
		/// </summary>
		/// <remarks>
		/// 
		/// </remarks>
		[DataMember(Name="EnablePrice", EmitDefaultValue=false)]
		public BooleanValue? EnablePrice { get; set; }

		/// <summary>
		/// 
		/// Display Name:
		/// DAC Field Name: EnableSubItem 
		/// DAC: PX.Objects.AM.AMConfiguratorSetup 
		/// </summary>
		/// <remarks>
		/// 
		/// </remarks>
		[DataMember(Name="EnableSubitem", EmitDefaultValue=false)]
		public BooleanValue? EnableSubitem { get; set; }

		/// <summary>
		/// 
		/// Display Name:
		/// DAC Field Name: EnableWarehouse 
		/// DAC: PX.Objects.AM.AMConfiguratorSetup 
		/// </summary>
		/// <remarks>
		/// 
		/// </remarks>
		[DataMember(Name="EnableWarehouse", EmitDefaultValue=false)]
		public BooleanValue? EnableWarehouse { get; set; }

		/// <summary>
		/// 
		/// Display Name:
		/// DAC Field Name: HidePriceDetails 
		/// DAC: PX.Objects.AM.AMConfiguratorSetup 
		/// </summary>
		/// <remarks>
		/// 
		/// </remarks>
		[DataMember(Name="HidePriceDetails", EmitDefaultValue=false)]
		public BooleanValue? HidePriceDetails { get; set; }

		/// <summary>
		/// 
		/// Display Name:
		/// DAC Field Name: AllowCalculateOverride 
		/// DAC: PX.Objects.AM.AMConfiguratorSetup 
		/// </summary>
		/// <remarks>
		/// 
		/// </remarks>
		[DataMember(Name="OverrideDefaultonConfigurationAllowCalculateOverride", EmitDefaultValue=false)]
		public BooleanValue? OverrideDefaultonConfigurationAllowCalculateOverride { get; set; }

		/// <summary>
		/// 
		/// Display Name:
		/// DAC Field Name: AllowRollupOverride 
		/// DAC: PX.Objects.AM.AMConfiguratorSetup 
		/// </summary>
		/// <remarks>
		/// 
		/// </remarks>
		[DataMember(Name="OverrideDefaultonConfigurationAllowRollupOverride", EmitDefaultValue=false)]
		public BooleanValue? OverrideDefaultonConfigurationAllowRollupOverride { get; set; }

		/// <summary>
		/// 
		/// Display Name:
		/// DAC Field Name: Rollup 
		/// DAC: PX.Objects.AM.AMConfiguratorSetup 
		/// </summary>
		/// <remarks>
		/// 
		/// </remarks>
		[DataMember(Name="Rollup", EmitDefaultValue=false)]
		public StringValue? Rollup { get; set; }

		public virtual string GetEndpointPath()
		{
			return "entity/MANUFACTURING/23.200.001";
		}
	}
}