using System;
using System.Collections.Generic;

using Newtonsoft.Json;

using Acumatica.RESTClient.Client;
using Acumatica.RESTClient.ContractBasedApi;
using Acumatica.RESTClient.ContractBasedApi.Model;

namespace Acumatica.Manufacturing_24_200_001.Model
{
	/// <summary>
	/// Corresponds to the screen <c>AM207500</c> in the Acumatica ERP
	/// <para>Key Fields: ConfigurationID, Revision</para>
	/// </summary>
	public class ConfigurationMaintenance : Entity, ITopLevelEntity
	{

		/// <summary>
		/// <para>DAC: PX.Objects.AM.AMConfiguration</para>
		/// <para>Display Name: BOM ID</para>
		/// <para>SQL Type: nvarchar(15)</para>
		/// </summary>
		public StringValue? BOMID { get; set; }

		/// <summary>
		/// <para>DAC Field Name: BOMRevisionID</para>
		/// <para>DAC: PX.Objects.AM.AMConfiguration</para>
		/// <para>Display Name: BOM Revision</para>
		/// <para>SQL Type: nvarchar(10)</para>
		/// </summary>
		public StringValue? BOMRevision { get; set; }

		/// <summary>
		/// <para>DAC Field Name: IsCompletionRequired</para>
		/// <para>DAC: PX.Objects.AM.AMConfiguration</para>
		/// <para>Display Name: Completion Required Before Production</para>
		/// </summary>
		public BooleanValue? CompletionRequiredBeforeProduction { get; set; }

		public List<ConfigurationMaintAttribute>? ConfigAttributes { get; set; }

		/// <summary>
		/// <para>DAC: PX.Objects.AM.AMConfiguration</para>
		/// <para>Display Name: Configuration ID</para>
		/// <para>SQL Type: nvarchar(15)</para>
		/// Key Field
		/// </summary>
		public StringValue? ConfigurationID { get; set; }

		/// <summary>
		/// <para>DAC Field Name: Descr</para>
		/// <para>DAC: PX.Objects.AM.AMConfiguration</para>
		/// <para>SQL Type: nvarchar(256)</para>
		/// </summary>
		public StringValue? Description { get; set; }

		public List<ConfigurationMaintenanceFeature>? Features { get; set; }

		/// <summary>
		/// <para>DAC: PX.Objects.AM.AMConfiguration</para>
		/// <para>Display Name: Inventory ID</para>
		/// </summary>
		public StringValue? InventoryID { get; set; }

		public ConfigurationMaintKey? Keys { get; set; }

		public ConfigurationMaintPrice? Price { get; set; }

		/// <summary>
		/// <para>DAC: PX.Objects.AM.AMConfiguration</para>
		/// <para>SQL Type: nvarchar(10)</para>
		/// Key Field
		/// </summary>
		public StringValue? Revision { get; set; }

		/// <summary>
		/// <para>DAC: PX.Objects.AM.AMConfiguration</para>
		/// <para>SQL Type: char(1)</para>
		/// </summary>
		public StringValue? Status { get; set; }

		public static class Expand
		{
			public const string Files = "Files";
			public const string Translations = "Translations";
			public const string ConfigAttributes = "ConfigAttributes";
			public const string ConfigAttributes_Files = "ConfigAttributes/Files";
			public const string ConfigAttributes_Rules = "ConfigAttributes/Rules";
			public const string ConfigAttributes_Rules_Files = "ConfigAttributes/Rules/Files";
			public const string Features = "Features";
			public const string Features_Files = "Features/Files";
			public const string Features_Options = "Features/Options";
			public const string Features_Options_Files = "Features/Options/Files";
			public const string Features_Rules = "Features/Rules";
			public const string Features_Rules_Files = "Features/Rules/Files";
			public const string Keys = "Keys";
			public const string Price = "Price";

			//Intentionally excluded
			//public const string All = "Files,Translations,ConfigAttributes,ConfigAttributes/Files,ConfigAttributes/Rules,ConfigAttributes/Rules/Files,Features,Features/Files,Features/Options,Features/Options/Files,Features/Rules,Features/Rules/Files,Keys,Price";
		}
		public virtual string GetEndpointPath()
		{
			return "entity/MANUFACTURING/24.200.001";
		}
	}
}