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
	/// Corresponds to the screen <c>AM207500</c> in the Acumatica ERP
	/// <para>Key Fields: ConfigurationID, Revision</para>
	/// </summary>
	[DataContract]
	public class ConfigurationMaintenance : Entity, ITopLevelEntity
	{

		/// <summary>
		/// <para>DAC: PX.Objects.AM.AMConfiguration</para>
		/// <para>Display Name: BOM ID</para>
		/// <para>SQL Type: nvarchar(15)</para>
		/// </summary>
		[DataMember(Name="BOMID", EmitDefaultValue=false)]
		public StringValue? BOMID { get; set; }

		/// <summary>
		/// <para>DAC Field Name: BOMRevisionID</para>
		/// <para>DAC: PX.Objects.AM.AMConfiguration</para>
		/// <para>Display Name: BOM Revision</para>
		/// <para>SQL Type: nvarchar(10)</para>
		/// </summary>
		[DataMember(Name="BOMRevision", EmitDefaultValue=false)]
		public StringValue? BOMRevision { get; set; }

		/// <summary>
		/// <para>DAC Field Name: IsCompletionRequired</para>
		/// <para>DAC: PX.Objects.AM.AMConfiguration</para>
		/// <para>Display Name: Completion Required Before Production</para>
		/// </summary>
		[DataMember(Name="CompletionRequiredBeforeProduction", EmitDefaultValue=false)]
		public BooleanValue? CompletionRequiredBeforeProduction { get; set; }

		[DataMember(Name="ConfigAttributes", EmitDefaultValue=false)]
		public List<ConfigurationMaintAttribute>? ConfigAttributes { get; set; }

		/// <summary>
		/// <para>DAC: PX.Objects.AM.AMConfiguration</para>
		/// <para>Display Name: Configuration ID</para>
		/// <para>SQL Type: nvarchar(15)</para>
		/// Key Field
		/// </summary>
		[DataMember(Name="ConfigurationID", EmitDefaultValue=false)]
		public StringValue? ConfigurationID { get; set; }

		/// <summary>
		/// <para>DAC Field Name: Descr</para>
		/// <para>DAC: PX.Objects.AM.AMConfiguration</para>
		/// <para>SQL Type: nvarchar(256)</para>
		/// </summary>
		[DataMember(Name="Description", EmitDefaultValue=false)]
		public StringValue? Description { get; set; }

		[DataMember(Name="Features", EmitDefaultValue=false)]
		public List<ConfigurationMaintenanceFeature>? Features { get; set; }

		/// <summary>
		/// <para>DAC: PX.Objects.AM.AMConfiguration</para>
		/// <para>Display Name: Inventory ID</para>
		/// </summary>
		[DataMember(Name="InventoryID", EmitDefaultValue=false)]
		public StringValue? InventoryID { get; set; }

		[DataMember(Name="Keys", EmitDefaultValue=false)]
		public ConfigurationMaintKey? Keys { get; set; }

		[DataMember(Name="Price", EmitDefaultValue=false)]
		public ConfigurationMaintPrice? Price { get; set; }

		/// <summary>
		/// <para>DAC: PX.Objects.AM.AMConfiguration</para>
		/// <para>SQL Type: nvarchar(10)</para>
		/// Key Field
		/// </summary>
		[DataMember(Name="Revision", EmitDefaultValue=false)]
		public StringValue? Revision { get; set; }

		/// <summary>
		/// <para>DAC: PX.Objects.AM.AMConfiguration</para>
		/// <para>SQL Type: char(1)</para>
		/// </summary>
		[DataMember(Name="Status", EmitDefaultValue=false)]
		public StringValue? Status { get; set; }

		public static class Expand
		{
			public const string Files = "Files";
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
			//public const string All = "Files,ConfigAttributes,ConfigAttributes/Files,ConfigAttributes/Rules,ConfigAttributes/Rules/Files,Features,Features/Files,Features/Options,Features/Options/Files,Features/Rules,Features/Rules/Files,Keys,Price";
		}
		public virtual string GetEndpointPath()
		{
			return "entity/MANUFACTURING/25.100.001";
		}
	}
}