using System;
using System.Collections.Generic;
using System.Runtime.Serialization;

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
	[DataContract]
	public class ConfigurationFeature : Entity, ITopLevelEntity
	{

		/// <summary>
		/// <para>DAC Field Name: ActiveFlg</para>
		/// <para>DAC: PX.Objects.AM.AMFeature</para>
		/// </summary>
		[DataMember(Name="Active", EmitDefaultValue=false)]
		public BooleanValue? Active { get; set; }

		/// <summary>
		/// <para>DAC: PX.Objects.AM.AMFeature</para>
		/// <para>Display Name: Allow Non-Inventory Options</para>
		/// </summary>
		[DataMember(Name="AllowNonInventoryOptions", EmitDefaultValue=false)]
		public BooleanValue? AllowNonInventoryOptions { get; set; }

		[DataMember(Name="ConfigurationFeatureAttribute", EmitDefaultValue=false)]
		public List<FeatureAttributes>? ConfigurationFeatureAttribute { get; set; }

		[DataMember(Name="ConfigurationFeatureOption", EmitDefaultValue=false)]
		public List<FeatureOptions>? ConfigurationFeatureOption { get; set; }

		/// <summary>
		/// <para>DAC Field Name: Descr</para>
		/// <para>DAC: PX.Objects.AM.AMFeature</para>
		/// <para>SQL Type: nvarchar(256)</para>
		/// </summary>
		[DataMember(Name="Description", EmitDefaultValue=false)]
		public StringValue? Description { get; set; }

		/// <summary>
		/// <para>DAC: PX.Objects.AM.AMFeature</para>
		/// <para>Display Name: Display Option Attributes</para>
		/// </summary>
		[DataMember(Name="DisplayOptionAttributes", EmitDefaultValue=false)]
		public BooleanValue? DisplayOptionAttributes { get; set; }

		/// <summary>
		/// <para>DAC: PX.Objects.AM.AMFeature</para>
		/// <para>Display Name: Feature ID</para>
		/// <para>SQL Type: nvarchar(30)</para>
		/// Key Field
		/// </summary>
		[DataMember(Name="FeatureID", EmitDefaultValue=false)]
		public StringValue? FeatureID { get; set; }

		/// <summary>
		/// Flag used for reporting
		/// <para>DAC: PX.Objects.AM.AMFeature</para>
		/// <para>Display Name: Print Results</para>
		/// </summary>
		[DataMember(Name="PrintResults", EmitDefaultValue=false)]
		public BooleanValue? PrintResults { get; set; }

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