using System;
using System.Collections.Generic;

using Newtonsoft.Json;

using Acumatica.RESTClient.Client;
using Acumatica.RESTClient.ContractBasedApi;
using Acumatica.RESTClient.ContractBasedApi.Model;

namespace Acumatica.MANUFACTURING_25_100_001.Model
{
	/// <summary>
	/// Corresponds to the screen <c>AM104000</c> in the Acumatica ERP
	/// </summary>
	public class ConfiguratorPreferences : Entity, ITopLevelEntity
	{

		/// <summary>
		/// <para>DAC: PX.Objects.AM.AMConfiguratorSetup</para>
		/// <para>SQL Type: char(1)</para>
		/// </summary>
		public StringValue? Calculate { get; set; }

		/// <summary>
		/// <para>DAC Field Name: IsCompletionRequired</para>
		/// <para>DAC: PX.Objects.AM.AMConfiguratorSetup</para>
		/// <para>Display Name: Completion Required Before Production</para>
		/// </summary>
		public BooleanValue? CompletionRequiredBeforeProduction { get; set; }

		/// <summary>
		/// <para>DAC: PX.Objects.AM.AMConfiguratorSetup</para>
		/// <para>Display Name: Config Key Format</para>
		/// <para>SQL Type: char(1)</para>
		/// </summary>
		public StringValue? ConfigKeyFormat { get; set; }

		/// <summary>
		/// <para>DAC Field Name: ConfigNumberingID</para>
		/// <para>DAC: PX.Objects.AM.AMConfiguratorSetup</para>
		/// <para>Display Name: Config Numbering Sequence</para>
		/// <para>SQL Type: nvarchar(10)</para>
		/// </summary>
		public StringValue? ConfigNumberingSequence { get; set; }

		/// <summary>
		/// <para>DAC Field Name: DefaultKeyNumberingID</para>
		/// <para>DAC: PX.Objects.AM.AMConfiguratorSetup</para>
		/// <para>Display Name: Default Key Number Sequence</para>
		/// <para>SQL Type: nvarchar(10)</para>
		/// </summary>
		public StringValue? DefaultKeyNumberSequence { get; set; }

		/// <summary>
		/// <para>DAC Field Name: DfltRevisionNbr</para>
		/// <para>DAC: PX.Objects.AM.AMConfiguratorSetup</para>
		/// <para>Display Name: Default Revision</para>
		/// <para>SQL Type: nvarchar(10)</para>
		/// </summary>
		public StringValue? DefaultRevision { get; set; }

		/// <summary>
		/// <para>DAC: PX.Objects.AM.AMConfiguratorSetup</para>
		/// <para>Display Name: Enable Discount</para>
		/// </summary>
		public BooleanValue? EnableDiscount { get; set; }

		/// <summary>
		/// <para>DAC: PX.Objects.AM.AMConfiguratorSetup</para>
		/// <para>Display Name: Enable Price</para>
		/// </summary>
		public BooleanValue? EnablePrice { get; set; }

		/// <summary>
		/// <para>DAC Field Name: EnableSubItem</para>
		/// <para>DAC: PX.Objects.AM.AMConfiguratorSetup</para>
		/// <para>Display Name: Enable Sub item</para>
		/// </summary>
		public BooleanValue? EnableSubitem { get; set; }

		/// <summary>
		/// <para>DAC: PX.Objects.AM.AMConfiguratorSetup</para>
		/// <para>Display Name: Enable Warehouse</para>
		/// </summary>
		public BooleanValue? EnableWarehouse { get; set; }

		/// <summary>
		/// <para>DAC: PX.Objects.AM.AMConfiguratorSetup</para>
		/// <para>Display Name: Hide Price Details</para>
		/// </summary>
		public BooleanValue? HidePriceDetails { get; set; }

		/// <summary>
		/// <para>DAC Field Name: AllowCalculateOverride</para>
		/// <para>DAC: PX.Objects.AM.AMConfiguratorSetup</para>
		/// <para>Display Name: Override Default on Configuration</para>
		/// </summary>
		public BooleanValue? OverrideDefaultonConfigurationAllowCalculateOverride { get; set; }

		/// <summary>
		/// <para>DAC Field Name: AllowRollupOverride</para>
		/// <para>DAC: PX.Objects.AM.AMConfiguratorSetup</para>
		/// <para>Display Name: Override Default on Configuration</para>
		/// </summary>
		public BooleanValue? OverrideDefaultonConfigurationAllowRollupOverride { get; set; }

		/// <summary>
		/// <para>DAC: PX.Objects.AM.AMConfiguratorSetup</para>
		/// <para>SQL Type: char(2)</para>
		/// </summary>
		public StringValue? Rollup { get; set; }

		public static class Expand
		{
			public const string Files = "Files";
			public const string Translations = "Translations";

			//Intentionally excluded
			//public const string All = "Files,Translations";
		}
		public virtual string GetEndpointPath()
		{
			return "entity/MANUFACTURING/25.100.001";
		}
	}
}