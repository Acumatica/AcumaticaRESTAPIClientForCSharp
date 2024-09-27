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
		/// DAC: PX.Objects.AM.AMConfiguratorSetup 
		/// SQL Type: char(1) 
		/// </summary>
		[DataMember(Name="Calculate", EmitDefaultValue=false)]
		public StringValue? Calculate { get; set; }

		/// <summary>
		/// DAC Field Name: IsCompletionRequired 
		/// DAC: PX.Objects.AM.AMConfiguratorSetup 
		/// Display Name: Completion Required Before Production 
		/// </summary>
		[DataMember(Name="CompletionRequiredBeforeProduction", EmitDefaultValue=false)]
		public BooleanValue? CompletionRequiredBeforeProduction { get; set; }

		/// <summary>
		/// DAC: PX.Objects.AM.AMConfiguratorSetup 
		/// Display Name: Config Key Format 
		/// SQL Type: char(1) 
		/// </summary>
		[DataMember(Name="ConfigKeyFormat", EmitDefaultValue=false)]
		public StringValue? ConfigKeyFormat { get; set; }

		/// <summary>
		/// DAC Field Name: ConfigNumberingID 
		/// DAC: PX.Objects.AM.AMConfiguratorSetup 
		/// Display Name: Config Numbering Sequence 
		/// SQL Type: nvarchar(10) 
		/// </summary>
		[DataMember(Name="ConfigNumberingSequence", EmitDefaultValue=false)]
		public StringValue? ConfigNumberingSequence { get; set; }

		/// <summary>
		/// DAC Field Name: DefaultKeyNumberingID 
		/// DAC: PX.Objects.AM.AMConfiguratorSetup 
		/// Display Name: Default Key Number Sequence 
		/// SQL Type: nvarchar(10) 
		/// </summary>
		[DataMember(Name="DefaultKeyNumberSequence", EmitDefaultValue=false)]
		public StringValue? DefaultKeyNumberSequence { get; set; }

		/// <summary>
		/// DAC Field Name: DfltRevisionNbr 
		/// DAC: PX.Objects.AM.AMConfiguratorSetup 
		/// Display Name: Default Revision 
		/// SQL Type: nvarchar(10) 
		/// </summary>
		[DataMember(Name="DefaultRevision", EmitDefaultValue=false)]
		public StringValue? DefaultRevision { get; set; }

		/// <summary>
		/// DAC: PX.Objects.AM.AMConfiguratorSetup 
		/// Display Name: Enable Discount 
		/// </summary>
		[DataMember(Name="EnableDiscount", EmitDefaultValue=false)]
		public BooleanValue? EnableDiscount { get; set; }

		/// <summary>
		/// DAC: PX.Objects.AM.AMConfiguratorSetup 
		/// Display Name: Enable Price 
		/// </summary>
		[DataMember(Name="EnablePrice", EmitDefaultValue=false)]
		public BooleanValue? EnablePrice { get; set; }

		/// <summary>
		/// DAC Field Name: EnableSubItem 
		/// DAC: PX.Objects.AM.AMConfiguratorSetup 
		/// Display Name: Enable Sub item 
		/// </summary>
		[DataMember(Name="EnableSubitem", EmitDefaultValue=false)]
		public BooleanValue? EnableSubitem { get; set; }

		/// <summary>
		/// DAC: PX.Objects.AM.AMConfiguratorSetup 
		/// Display Name: Enable Warehouse 
		/// </summary>
		[DataMember(Name="EnableWarehouse", EmitDefaultValue=false)]
		public BooleanValue? EnableWarehouse { get; set; }

		/// <summary>
		/// DAC: PX.Objects.AM.AMConfiguratorSetup 
		/// Display Name: Hide Price Details 
		/// </summary>
		[DataMember(Name="HidePriceDetails", EmitDefaultValue=false)]
		public BooleanValue? HidePriceDetails { get; set; }

		/// <summary>
		/// DAC Field Name: AllowCalculateOverride 
		/// DAC: PX.Objects.AM.AMConfiguratorSetup 
		/// Display Name: Override Default on Configuration 
		/// </summary>
		[DataMember(Name="OverrideDefaultonConfigurationAllowCalculateOverride", EmitDefaultValue=false)]
		public BooleanValue? OverrideDefaultonConfigurationAllowCalculateOverride { get; set; }

		/// <summary>
		/// DAC Field Name: AllowRollupOverride 
		/// DAC: PX.Objects.AM.AMConfiguratorSetup 
		/// Display Name: Override Default on Configuration 
		/// </summary>
		[DataMember(Name="OverrideDefaultonConfigurationAllowRollupOverride", EmitDefaultValue=false)]
		public BooleanValue? OverrideDefaultonConfigurationAllowRollupOverride { get; set; }

		/// <summary>
		/// DAC: PX.Objects.AM.AMConfiguratorSetup 
		/// SQL Type: char(2) 
		/// </summary>
		[DataMember(Name="Rollup", EmitDefaultValue=false)]
		public StringValue? Rollup { get; set; }

		public virtual string GetEndpointPath()
		{
			return "entity/MANUFACTURING/23.200.001";
		}
	}
}