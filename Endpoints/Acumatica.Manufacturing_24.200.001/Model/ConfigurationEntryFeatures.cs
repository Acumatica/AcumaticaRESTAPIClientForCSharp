using System;
using System.Collections.Generic;
using System.Runtime.Serialization;

using Newtonsoft.Json;

using Acumatica.RESTClient.Client;
using Acumatica.RESTClient.ContractBasedApi;
using Acumatica.RESTClient.ContractBasedApi.Model;

namespace Acumatica.Manufacturing_24_200_001.Model
{
	[DataContract]
	public class ConfigurationEntryFeatures : Entity
	{

		/// <summary>
		/// <para>DAC: PX.Objects.AM.AMConfigurationResults</para>
		/// <para>Display Name: Config Results ID</para>
		/// Key Field
		/// </summary>
		[DataMember(Name="ConfigResultsID", EmitDefaultValue=false)]
		public IntValue? ConfigResultsID { get; set; }

		/// <summary>
		/// <para>DAC: PX.Objects.AM.AMConfigResultsOption</para>
		/// <para>Display Name: Feature Line Nbr</para>
		/// Key Field
		/// </summary>
		[DataMember(Name="FeatureLineNbr", EmitDefaultValue=false)]
		public IntValue? FeatureLineNbr { get; set; }

		/// <summary>
		/// <para>DAC Field Name: AMConfigurationFeature__Label</para>
		/// <para>DAC: PX.Objects.AM.AMConfigResultsFeature</para>
		/// </summary>
		[DataMember(Name="Label", EmitDefaultValue=false)]
		public StringValue? Label { get; set; }

		/// <summary>
		/// <para>DAC: PX.Objects.AM.AMConfigResultsFeature</para>
		/// <para>Display Name: Lot Qty</para>
		/// </summary>
		[DataMember(Name="LotQty", EmitDefaultValue=false)]
		public DecimalValue? LotQty { get; set; }

		/// <summary>
		/// <para>DAC: PX.Objects.AM.AMConfigResultsFeature</para>
		/// <para>Display Name: Max Qty</para>
		/// </summary>
		[DataMember(Name="MaxQty", EmitDefaultValue=false)]
		public DecimalValue? MaxQty { get; set; }

		/// <summary>
		/// <para>DAC: PX.Objects.AM.AMConfigResultsFeature</para>
		/// <para>Display Name: Max Selection</para>
		/// </summary>
		[DataMember(Name="MaxSelection", EmitDefaultValue=false)]
		public IntValue? MaxSelection { get; set; }

		/// <summary>
		/// <para>DAC: PX.Objects.AM.AMConfigResultsFeature</para>
		/// <para>Display Name: Min Qty</para>
		/// </summary>
		[DataMember(Name="MinQty", EmitDefaultValue=false)]
		public DecimalValue? MinQty { get; set; }

		/// <summary>
		/// <para>DAC: PX.Objects.AM.AMConfigResultsFeature</para>
		/// <para>Display Name: Min Selection</para>
		/// </summary>
		[DataMember(Name="MinSelection", EmitDefaultValue=false)]
		public IntValue? MinSelection { get; set; }

		[DataMember(Name="Options", EmitDefaultValue=false)]
		public List<ConfigurationEntryOptions>? Options { get; set; }

		/// <summary>
		/// <para>DAC: PX.Objects.AM.AMConfigResultsFeature</para>
		/// <para>Display Name: Total Qty</para>
		/// </summary>
		[DataMember(Name="TotalQty", EmitDefaultValue=false)]
		public DecimalValue? TotalQty { get; set; }

	}
}