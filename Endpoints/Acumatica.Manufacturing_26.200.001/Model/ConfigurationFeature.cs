using System;
using System.Collections.Generic;

using Newtonsoft.Json;

using Acumatica.RESTClient.Client;
using Acumatica.RESTClient.ContractBasedApi;
using Acumatica.RESTClient.ContractBasedApi.Model;

namespace Acumatica.Manufacturing_26_200_001.Model
{
	/// <summary>
	/// Corresponds to the screen <c>AM203500</c> in the Acumatica ERP
	/// <para>Key Fields: FeatureID</para>
	/// </summary>
	public class ConfigurationFeature : Entity, ITopLevelEntity
	{

		#region Fields
		/// <summary>
		/// <para>DAC: PX.Objects.AM.AMFeature</para>
		/// <para>Display Name: Feature ID</para>
		/// <para>SQL Type: nvarchar(30)</para>
		/// Key Field
		/// </summary>
		public StringValue? FeatureID { get; set; }

		/// <summary>
		/// <para>DAC Field Name: Descr</para>
		/// <para>DAC: PX.Objects.AM.AMFeature</para>
		/// <para>SQL Type: nvarchar(256)</para>
		/// </summary>
		public StringValue? Description { get; set; }

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

		/// <summary>
		/// <para>DAC: PX.Objects.AM.AMFeature</para>
		/// <para>Display Name: Display Option Attributes</para>
		/// </summary>
		public BooleanValue? DisplayOptionAttributes { get; set; }

		/// <summary>
		/// Flag used for reporting
		/// <para>DAC: PX.Objects.AM.AMFeature</para>
		/// <para>Display Name: Print Results</para>
		/// </summary>
		public BooleanValue? PrintResults { get; set; }

		#endregion

		#region Details
		public List<FeatureAttributes>? ConfigurationFeatureAttribute { get; set; }

		public List<FeatureOptions>? ConfigurationFeatureOption { get; set; }

		#endregion

		protected override string GetDebuggerDisplay()
		{
			return $"{nameof(ConfigurationFeature)} - \"{FeatureID}\"";
		}

		/// <summary>
		/// Names that can be passed in the <c>$expand</c> parameter.
		/// <para>This endpoint uses system contract 5, where a nested entity is expanded
		/// as <c>Parent($expand=Child)</c> rather than <c>Parent/Child</c>, so only the names
		/// that can be expanded directly on this entity are listed here. Use the nested
		/// entity's own <c>Expand</c> class for the inner names.</para>
		/// </summary>
		public static class Expand
		{
			public const string Files = "Files";
			public const string Translations = "Translations";
			public const string ConfigurationFeatureAttribute = "ConfigurationFeatureAttribute";
			public const string ConfigurationFeatureOption = "ConfigurationFeatureOption";

			//Intentionally excluded
			//public const string All = "Files,Translations,ConfigurationFeatureAttribute,ConfigurationFeatureOption";
		}
		public virtual string GetEndpointPath()
		{
			return "entity/MANUFACTURING/26.200.001";
		}
	}
}