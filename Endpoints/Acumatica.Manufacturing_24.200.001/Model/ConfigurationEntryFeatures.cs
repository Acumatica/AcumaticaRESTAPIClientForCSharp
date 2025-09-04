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
		/// DAC: PX.Objects.AM.AMConfigurationResults 
		/// Display Name: Config Results ID 
		/// Key Field
		/// </summary>
		[DataMember(Name="ConfigResultsID", EmitDefaultValue=false)]
		public IntValue? ConfigResultsID { get; set; }

		/// <summary>
		/// DAC: PX.Objects.AM.AMConfigResultsOption 
		/// Display Name: Feature Line Nbr 
		/// Key Field
		/// </summary>
		[DataMember(Name="FeatureLineNbr", EmitDefaultValue=false)]
		public IntValue? FeatureLineNbr { get; set; }

		/// <summary>
		/// DAC Field Name: AMConfigurationFeature__Label 
		/// DAC: PX.Objects.AM.AMConfigResultsFeature 
		/// </summary>
		[DataMember(Name="Label", EmitDefaultValue=false)]
		public StringValue? Label { get; set; }

		/// <summary>
		/// DAC: PX.Objects.AM.AMConfigResultsFeature 
		/// Display Name: Lot Qty 
		/// </summary>
		[DataMember(Name="LotQty", EmitDefaultValue=false)]
		public DecimalValue? LotQty { get; set; }

		/// <summary>
		/// DAC: PX.Objects.AM.AMConfigResultsFeature 
		/// Display Name: Max Qty 
		/// </summary>
		[DataMember(Name="MaxQty", EmitDefaultValue=false)]
		public DecimalValue? MaxQty { get; set; }

		/// <summary>
		/// DAC: PX.Objects.AM.AMConfigResultsFeature 
		/// Display Name: Max Selection 
		/// </summary>
		[DataMember(Name="MaxSelection", EmitDefaultValue=false)]
		public IntValue? MaxSelection { get; set; }

		/// <summary>
		/// DAC: PX.Objects.AM.AMConfigResultsFeature 
		/// Display Name: Min Qty 
		/// </summary>
		[DataMember(Name="MinQty", EmitDefaultValue=false)]
		public DecimalValue? MinQty { get; set; }

		/// <summary>
		/// DAC: PX.Objects.AM.AMConfigResultsFeature 
		/// Display Name: Min Selection 
		/// </summary>
		[DataMember(Name="MinSelection", EmitDefaultValue=false)]
		public IntValue? MinSelection { get; set; }

		[DataMember(Name="Options", EmitDefaultValue=false)]
		public List<ConfigurationEntryOptions>? Options { get; set; }

		/// <summary>
		/// DAC: PX.Objects.AM.AMConfigResultsFeature 
		/// Display Name: Total Qty 
		/// </summary>
		[DataMember(Name="TotalQty", EmitDefaultValue=false)]
		public DecimalValue? TotalQty { get; set; }

	}
}