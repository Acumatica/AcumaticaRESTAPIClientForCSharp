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
	/// Corresponds to the screen <c>AM306010</c> in the Acumatica ERP
	/// <para>Key Fields: ConfigResultsID</para>
	/// </summary>
	[DataContract]
	public class ConfigurationEntry : Entity, ITopLevelEntity
	{

		[DataMember(Name="Attributes", EmitDefaultValue=false)]
		public List<ConfigurationEntryAttributes>? Attributes { get; set; }

		/// <summary>
		/// <para>DAC: PX.Objects.AM.AMConfigurationResults</para>
		/// </summary>
		[DataMember(Name="Completed", EmitDefaultValue=false)]
		public BooleanValue? Completed { get; set; }

		/// <summary>
		/// <para>DAC: PX.Objects.AM.AMConfigurationResults</para>
		/// <para>Display Name: Config Results ID</para>
		/// Key Field
		/// </summary>
		[DataMember(Name="ConfigResultsID", EmitDefaultValue=false)]
		public IntValue? ConfigResultsID { get; set; }

		/// <summary>
		/// <para>DAC: PX.Objects.AM.AMConfigurationResults</para>
		/// <para>Display Name: Configuration ID</para>
		/// <para>SQL Type: nvarchar(15)</para>
		/// </summary>
		[DataMember(Name="ConfigurationID", EmitDefaultValue=false)]
		public StringValue? ConfigurationID { get; set; }

		/// <summary>
		/// <para>DAC Field Name: Revision</para>
		/// <para>DAC: PX.Objects.AM.AMConfigurationResults</para>
		/// <para>Display Name: Conf. Revision</para>
		/// <para>SQL Type: nvarchar(10)</para>
		/// </summary>
		[DataMember(Name="ConfRevision", EmitDefaultValue=false)]
		public StringValue? ConfRevision { get; set; }

		[DataMember(Name="Features", EmitDefaultValue=false)]
		public List<ConfigurationEntryFeatures>? Features { get; set; }

		/// <summary>
		/// <para>DAC: PX.Objects.AM.AMConfigurationResults</para>
		/// <para>Display Name: Inventory ID</para>
		/// </summary>
		[DataMember(Name="InventoryID", EmitDefaultValue=false)]
		public StringValue? InventoryID { get; set; }

		/// <summary>
		/// <para>DAC: PX.Objects.AM.AMConfigurationResults</para>
		/// <para>Display Name: Opportunity Line Nbr</para>
		/// </summary>
		[DataMember(Name="OpportunityLineNbr", EmitDefaultValue=false)]
		public IntValue? OpportunityLineNbr { get; set; }

		/// <summary>
		/// <para>DAC: PX.Objects.AM.AMConfigurationResults</para>
		/// <para>Display Name: Opportunity Quote ID</para>
		/// </summary>
		[DataMember(Name="OpportunityQuoteID", EmitDefaultValue=false)]
		public GuidValue? OpportunityQuoteID { get; set; }

		/// <summary>
		/// <para>DAC: PX.Objects.AM.AMConfigurationResults</para>
		/// <para>Display Name: Prod Order Nbr</para>
		/// <para>SQL Type: nvarchar(15)</para>
		/// </summary>
		[DataMember(Name="ProdOrderNbr", EmitDefaultValue=false)]
		public StringValue? ProdOrderNbr { get; set; }

		/// <summary>
		/// <para>DAC: PX.Objects.AM.AMConfigurationResults</para>
		/// <para>Display Name: Prod Order Type</para>
		/// <para>SQL Type: char(2)</para>
		/// </summary>
		[DataMember(Name="ProdOrderType", EmitDefaultValue=false)]
		public StringValue? ProdOrderType { get; set; }

		/// <summary>
		/// <para>DAC Field Name: OrdLineRef</para>
		/// <para>DAC: PX.Objects.AM.AMConfigurationResults</para>
		/// <para>Display Name: SO Line Nbr.</para>
		/// </summary>
		[DataMember(Name="SOLineNbr", EmitDefaultValue=false)]
		public IntValue? SOLineNbr { get; set; }

		/// <summary>
		/// <para>DAC Field Name: OrdNbrRef</para>
		/// <para>DAC: PX.Objects.AM.AMConfigurationResults</para>
		/// <para>Display Name: SO Order Nbr</para>
		/// <para>SQL Type: nvarchar(15)</para>
		/// </summary>
		[DataMember(Name="SOOrderNbr", EmitDefaultValue=false)]
		public StringValue? SOOrderNbr { get; set; }

		/// <summary>
		/// <para>DAC Field Name: OrdTypeRef</para>
		/// <para>DAC: PX.Objects.AM.AMConfigurationResults</para>
		/// <para>Display Name: SO Order Type</para>
		/// <para>SQL Type: char(2)</para>
		/// </summary>
		[DataMember(Name="SOOrderType", EmitDefaultValue=false)]
		public StringValue? SOOrderType { get; set; }

		/// <summary>
		/// Indicates the configuration is running in test mode (no persist to the database)
		/// <para>DAC Field Name: IsConfigurationTesting</para>
		/// <para>DAC: PX.Objects.AM.AMConfigurationResults</para>
		/// <para>Display Name: Test Configuration</para>
		/// </summary>
		[DataMember(Name="TestConfiguration", EmitDefaultValue=false)]
		public BooleanValue? TestConfiguration { get; set; }

		/// <summary>
		/// <para>DAC Field Name: SiteID</para>
		/// <para>DAC: PX.Objects.AM.AMConfigurationResults</para>
		/// </summary>
		[DataMember(Name="Warehouse", EmitDefaultValue=false)]
		public StringValue? Warehouse { get; set; }

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
			public const string Attributes = "Attributes";
			public const string Features = "Features";

			//Intentionally excluded
			//public const string All = "Files,Translations,Attributes,Features";
		}
		public virtual string GetEndpointPath()
		{
			return "entity/MANUFACTURING/26.200.001";
		}
	}
}