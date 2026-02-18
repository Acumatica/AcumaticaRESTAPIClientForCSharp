using System;
using System.Collections.Generic;

using Newtonsoft.Json;

using Acumatica.RESTClient.Client;
using Acumatica.RESTClient.ContractBasedApi;
using Acumatica.RESTClient.ContractBasedApi.Model;

namespace Acumatica.MANUFACTURING_25_100_001.Model
{
	/// <summary>
	/// Corresponds to the screen <c>AM203500</c> in the Acumatica ERP
	/// <para>Key Fields: FeatureID</para>
	/// </summary>
	public class ConfigurationFeature : Entity, ITopLevelEntity
	{

		/// <summary>
		/// <para>DAC Field Name: ActiveFlg</para>
		/// <para>DAC: PX.Objects.AM.AMFeature</para>
		/// </summary>
		public BooleanValue? Active { get; set; }

		/// <summary>
		/// <para>DAC: PX.Objects.AM.AMFeature</para>
		/// <para>Display Name: Allow Non-Inventory Options</para>
		/// </summary>
		public BooleanValue? AllowNonInventoryOptions { get; set; }

		public List<FeatureAttributes>? ConfigurationFeatureAttribute { get; set; }

		public List<FeatureOptions>? ConfigurationFeatureOption { get; set; }

		/// <summary>
		/// <para>DAC Field Name: Descr</para>
		/// <para>DAC: PX.Objects.AM.AMFeature</para>
		/// <para>SQL Type: nvarchar(256)</para>
		/// </summary>
		public StringValue? Description { get; set; }

		/// <summary>
		/// <para>DAC: PX.Objects.AM.AMFeature</para>
		/// <para>Display Name: Display Option Attributes</para>
		/// </summary>
		public BooleanValue? DisplayOptionAttributes { get; set; }

		/// <summary>
		/// <para>DAC: PX.Objects.AM.AMFeature</para>
		/// <para>Display Name: Feature ID</para>
		/// <para>SQL Type: nvarchar(30)</para>
		/// Key Field
		/// </summary>
		public StringValue? FeatureID { get; set; }

		/// <summary>
		/// Flag used for reporting
		/// <para>DAC: PX.Objects.AM.AMFeature</para>
		/// <para>Display Name: Print Results</para>
		/// </summary>
		public BooleanValue? PrintResults { get; set; }

		public static class Expand
		{
			public const string Files = "Files";
			public const string Translations = "Translations";
			public const string ConfigurationFeatureAttribute = "ConfigurationFeatureAttribute";
			public const string ConfigurationFeatureAttribute_Files = "ConfigurationFeatureAttribute/Files";
			public const string ConfigurationFeatureOption = "ConfigurationFeatureOption";
			public const string ConfigurationFeatureOption_Files = "ConfigurationFeatureOption/Files";

			//Intentionally excluded
			//public const string All = "Files,Translations,ConfigurationFeatureAttribute,ConfigurationFeatureAttribute/Files,ConfigurationFeatureOption,ConfigurationFeatureOption/Files";
		}
		public virtual string GetEndpointPath()
		{
			return "entity/MANUFACTURING/25.100.001";
		}
	}
}