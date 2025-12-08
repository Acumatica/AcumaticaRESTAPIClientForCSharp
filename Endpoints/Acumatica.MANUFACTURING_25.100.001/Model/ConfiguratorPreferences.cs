using System;
using System.Collections.Generic;
using System.Runtime.Serialization;

using Newtonsoft.Json;

using Acumatica.RESTClient.Client;
using Acumatica.RESTClient.ContractBasedApi;
using Acumatica.RESTClient.ContractBasedApi.Model;

namespace Acumatica.MANUFACTURING_25_100_001.Model
{
	/// <summary>
	/// Corresponds to the screen <c>AM104000</c> in the Acumatica ERP
	/// </summary>
	[DataContract]
	public class ConfiguratorPreferences : Entity, ITopLevelEntity
	{

		/// <summary>
		/// <para>DAC: PX.Objects.AM.AMConfiguratorSetup</para>
		/// <para>SQL Type: char(1)</para>
		/// </summary>
		[DataMember(Name="Calculate", EmitDefaultValue=false)]
		public StringValue? Calculate { get; set; }

		/// <summary>
		/// <para>DAC Field Name: IsCompletionRequired</para>
		/// <para>DAC: PX.Objects.AM.AMConfiguratorSetup</para>
		/// <para>Display Name: Completion Required Before Production</para>
		/// </summary>
		[DataMember(Name="CompletionRequiredBeforeProduction", EmitDefaultValue=false)]
		public BooleanValue? CompletionRequiredBeforeProduction { get; set; }

		/// <summary>
		/// <para>DAC: PX.Objects.AM.AMConfiguratorSetup</para>
		/// <para>Display Name: Config Key Format</para>
		/// <para>SQL Type: char(1)</para>
		/// </summary>
		[DataMember(Name="ConfigKeyFormat", EmitDefaultValue=false)]
		public StringValue? ConfigKeyFormat { get; set; }

		/// <summary>
		/// <para>DAC Field Name: ConfigNumberingID</para>
		/// <para>DAC: PX.Objects.AM.AMConfiguratorSetup</para>
		/// <para>Display Name: Config Numbering Sequence</para>
		/// <para>SQL Type: nvarchar(10)</para>
		/// </summary>
		[DataMember(Name="ConfigNumberingSequence", EmitDefaultValue=false)]
		public StringValue? ConfigNumberingSequence { get; set; }

		/// <summary>
		/// <para>DAC Field Name: DefaultKeyNumberingID</para>
		/// <para>DAC: PX.Objects.AM.AMConfiguratorSetup</para>
		/// <para>Display Name: Default Key Number Sequence</para>
		/// <para>SQL Type: nvarchar(10)</para>
		/// </summary>
		[DataMember(Name="DefaultKeyNumberSequence", EmitDefaultValue=false)]
		public StringValue? DefaultKeyNumberSequence { get; set; }

		/// <summary>
		/// <para>DAC Field Name: DfltRevisionNbr</para>
		/// <para>DAC: PX.Objects.AM.AMConfiguratorSetup</para>
		/// <para>Display Name: Default Revision</para>
		/// <para>SQL Type: nvarchar(10)</para>
		/// </summary>
		[DataMember(Name="DefaultRevision", EmitDefaultValue=false)]
		public StringValue? DefaultRevision { get; set; }

		/// <summary>
		/// <para>DAC: PX.Objects.AM.AMConfiguratorSetup</para>
		/// <para>Display Name: Enable Discount</para>
		/// </summary>
		[DataMember(Name="EnableDiscount", EmitDefaultValue=false)]
		public BooleanValue? EnableDiscount { get; set; }

		/// <summary>
		/// <para>DAC: PX.Objects.AM.AMConfiguratorSetup</para>
		/// <para>Display Name: Enable Price</para>
		/// </summary>
		[DataMember(Name="EnablePrice", EmitDefaultValue=false)]
		public BooleanValue? EnablePrice { get; set; }

		/// <summary>
		/// <para>DAC Field Name: EnableSubItem</para>
		/// <para>DAC: PX.Objects.AM.AMConfiguratorSetup</para>
		/// <para>Display Name: Enable Sub item</para>
		/// </summary>
		[DataMember(Name="EnableSubitem", EmitDefaultValue=false)]
		public BooleanValue? EnableSubitem { get; set; }

		/// <summary>
		/// <para>DAC: PX.Objects.AM.AMConfiguratorSetup</para>
		/// <para>Display Name: Enable Warehouse</para>
		/// </summary>
		[DataMember(Name="EnableWarehouse", EmitDefaultValue=false)]
		public BooleanValue? EnableWarehouse { get; set; }

		/// <summary>
		/// <para>DAC: PX.Objects.AM.AMConfiguratorSetup</para>
		/// <para>Display Name: Hide Price Details</para>
		/// </summary>
		[DataMember(Name="HidePriceDetails", EmitDefaultValue=false)]
		public BooleanValue? HidePriceDetails { get; set; }

		/// <summary>
		/// <para>DAC Field Name: AllowCalculateOverride</para>
		/// <para>DAC: PX.Objects.AM.AMConfiguratorSetup</para>
		/// <para>Display Name: Override Default on Configuration</para>
		/// </summary>
		[DataMember(Name="OverrideDefaultonConfigurationAllowCalculateOverride", EmitDefaultValue=false)]
		public BooleanValue? OverrideDefaultonConfigurationAllowCalculateOverride { get; set; }

		/// <summary>
		/// <para>DAC Field Name: AllowRollupOverride</para>
		/// <para>DAC: PX.Objects.AM.AMConfiguratorSetup</para>
		/// <para>Display Name: Override Default on Configuration</para>
		/// </summary>
		[DataMember(Name="OverrideDefaultonConfigurationAllowRollupOverride", EmitDefaultValue=false)]
		public BooleanValue? OverrideDefaultonConfigurationAllowRollupOverride { get; set; }

		/// <summary>
		/// <para>DAC: PX.Objects.AM.AMConfiguratorSetup</para>
		/// <para>SQL Type: char(2)</para>
		/// </summary>
		[DataMember(Name="Rollup", EmitDefaultValue=false)]
		public StringValue? Rollup { get; set; }

		public static class Expand
		{
			public const string Files = "Files";

			//Intentionally excluded
			//public const string All = "Files";
		}
		public virtual string GetEndpointPath()
		{
			return "entity/MANUFACTURING/25.100.001";
		}
	}
}