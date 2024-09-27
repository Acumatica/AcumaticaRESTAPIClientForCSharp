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
	public class ConfigurationMaintenanceFeature : Entity
	{

		/// <summary>
		/// DAC: PX.Objects.AM.AMConfiguration 
		/// Display Name: Configuration ID 
		/// SQL Type: nvarchar(15) 
		/// Key Field
		/// </summary>
		[DataMember(Name="ConfigurationID", EmitDefaultValue=false)]
		public StringValue? ConfigurationID { get; set; }

		/// <summary>
		/// DAC Field Name: Descr 
		/// DAC: PX.Objects.AM.AMConfiguration 
		/// SQL Type: nvarchar(256) 
		/// </summary>
		[DataMember(Name="Description", EmitDefaultValue=false)]
		public StringValue? Description { get; set; }

		/// <summary>
		/// DAC: PX.Objects.AM.AMConfigurationFeature 
		/// Display Name: Feature ID 
		/// SQL Type: nvarchar(30) 
		/// </summary>
		[DataMember(Name="FeatureID", EmitDefaultValue=false)]
		public StringValue? FeatureID { get; set; }

		/// <summary>
		/// DAC: PX.Objects.AM.AMConfigurationFeature 
		/// SQL Type: nvarchar(30) 
		/// </summary>
		[DataMember(Name="Label", EmitDefaultValue=false)]
		public StringValue? Label { get; set; }

		/// <summary>
		/// DAC: PX.Objects.AM.AMConfigurationFeature 
		/// Display Name: Line Nbr 
		/// Key Field
		/// </summary>
		[DataMember(Name="LineNbr", EmitDefaultValue=false)]
		public IntValue? LineNbr { get; set; }

		/// <summary>
		/// DAC: PX.Objects.AM.AMConfigurationFeature 
		/// Display Name: Lot Qty 
		/// SQL Type: nvarchar(MAX) 
		/// </summary>
		[DataMember(Name="LotQty", EmitDefaultValue=false)]
		public StringValue? LotQty { get; set; }

		/// <summary>
		/// DAC: PX.Objects.AM.AMConfigurationFeature 
		/// Display Name: Max Qty 
		/// SQL Type: nvarchar(MAX) 
		/// </summary>
		[DataMember(Name="MaxQty", EmitDefaultValue=false)]
		public StringValue? MaxQty { get; set; }

		/// <summary>
		/// DAC: PX.Objects.AM.AMConfigurationFeature 
		/// Display Name: Max Selection 
		/// SQL Type: nvarchar(MAX) 
		/// </summary>
		[DataMember(Name="MaxSelection", EmitDefaultValue=false)]
		public StringValue? MaxSelection { get; set; }

		/// <summary>
		/// DAC: PX.Objects.AM.AMConfigurationFeature 
		/// Display Name: Min Qty 
		/// SQL Type: nvarchar(MAX) 
		/// </summary>
		[DataMember(Name="MinQty", EmitDefaultValue=false)]
		public StringValue? MinQty { get; set; }

		/// <summary>
		/// DAC: PX.Objects.AM.AMConfigurationFeature 
		/// Display Name: Min Selection 
		/// SQL Type: nvarchar(MAX) 
		/// </summary>
		[DataMember(Name="MinSelection", EmitDefaultValue=false)]
		public StringValue? MinSelection { get; set; }

		[DataMember(Name="Options", EmitDefaultValue=false)]
		public List<ConfigurationMaintFeatureOption>? Options { get; set; }

		/// <summary>
		/// Flag used for reporting
		/// DAC: PX.Objects.AM.AMConfigurationFeature 
		/// Display Name: Print Results 
		/// </summary>
		[DataMember(Name="PrintResults", EmitDefaultValue=false)]
		public BooleanValue? PrintResults { get; set; }

		/// <summary>
		/// DAC: PX.Objects.AM.AMConfigurationFeature 
		/// Display Name: Results Copy 
		/// </summary>
		[DataMember(Name="ResultsCopy", EmitDefaultValue=false)]
		public BooleanValue? ResultsCopy { get; set; }

		/// <summary>
		/// DAC: PX.Objects.AM.AMConfiguration 
		/// SQL Type: nvarchar(10) 
		/// Key Field
		/// </summary>
		[DataMember(Name="Revision", EmitDefaultValue=false)]
		public StringValue? Revision { get; set; }

		[DataMember(Name="Rules", EmitDefaultValue=false)]
		public List<ConfigurationMaintFeatureRule>? Rules { get; set; }

		/// <summary>
		/// DAC: PX.Objects.AM.AMConfigurationFeature 
		/// Display Name: Sort Order 
		/// </summary>
		[DataMember(Name="SortOrder", EmitDefaultValue=false)]
		public IntValue? SortOrder { get; set; }

		/// <summary>
		/// DAC: PX.Objects.AM.AMConfigurationFeature 
		/// </summary>
		[DataMember(Name="Visible", EmitDefaultValue=false)]
		public BooleanValue? Visible { get; set; }

	}
}