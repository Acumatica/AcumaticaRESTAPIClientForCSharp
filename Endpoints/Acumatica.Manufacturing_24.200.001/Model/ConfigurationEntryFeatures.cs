using System;
using System.Collections.Generic;

using Newtonsoft.Json;

using Acumatica.RESTClient.Client;
using Acumatica.RESTClient.ContractBasedApi;
using Acumatica.RESTClient.ContractBasedApi.Model;

namespace Acumatica.Manufacturing_24_200_001.Model
{
	public class ConfigurationEntryFeatures : Entity
	{

		/// <summary>
		/// <para>DAC: PX.Objects.AM.AMConfigurationResults</para>
		/// <para>Display Name: Config Results ID</para>
		/// Key Field
		/// </summary>
		public IntValue? ConfigResultsID { get; set; }

		/// <summary>
		/// <para>DAC: PX.Objects.AM.AMConfigResultsOption</para>
		/// <para>Display Name: Feature Line Nbr</para>
		/// Key Field
		/// </summary>
		public IntValue? FeatureLineNbr { get; set; }

		/// <summary>
		/// <para>DAC Field Name: AMConfigurationFeature__Label</para>
		/// <para>DAC: PX.Objects.AM.AMConfigResultsFeature</para>
		/// </summary>
		public StringValue? Label { get; set; }

		/// <summary>
		/// <para>DAC: PX.Objects.AM.AMConfigResultsFeature</para>
		/// <para>Display Name: Lot Qty.</para>
		/// </summary>
		public DecimalValue? LotQty { get; set; }

		/// <summary>
		/// <para>DAC: PX.Objects.AM.AMConfigResultsFeature</para>
		/// <para>Display Name: Max. Qty.</para>
		/// </summary>
		public DecimalValue? MaxQty { get; set; }

		/// <summary>
		/// <para>DAC: PX.Objects.AM.AMConfigResultsFeature</para>
		/// <para>Display Name: Max Selection</para>
		/// </summary>
		public IntValue? MaxSelection { get; set; }

		/// <summary>
		/// <para>DAC: PX.Objects.AM.AMConfigResultsFeature</para>
		/// <para>Display Name: Min. Qty.</para>
		/// </summary>
		public DecimalValue? MinQty { get; set; }

		/// <summary>
		/// <para>DAC: PX.Objects.AM.AMConfigResultsFeature</para>
		/// <para>Display Name: Min Selection</para>
		/// </summary>
		public IntValue? MinSelection { get; set; }

		public List<ConfigurationEntryOptions>? Options { get; set; }

		/// <summary>
		/// <para>DAC: PX.Objects.AM.AMConfigResultsFeature</para>
		/// <para>Display Name: Total Qty.</para>
		/// </summary>
		public DecimalValue? TotalQty { get; set; }

	}
}