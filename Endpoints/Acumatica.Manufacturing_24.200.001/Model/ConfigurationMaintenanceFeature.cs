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

		/// <summary>
		/// <para>DAC: PX.Objects.AM.AMConfigurationFeature</para>
		/// <para>Display Name: Feature ID</para>
		/// <para>SQL Type: nvarchar(30)</para>
		/// </summary>
		[DataMember(Name="FeatureID", EmitDefaultValue=false)]
		public StringValue? FeatureID { get; set; }

		/// <summary>
		/// <para>DAC: PX.Objects.AM.AMConfigurationFeature</para>
		/// <para>SQL Type: nvarchar(30)</para>
		/// </summary>
		[DataMember(Name="Label", EmitDefaultValue=false)]
		public StringValue? Label { get; set; }

		/// <summary>
		/// <para>DAC: PX.Objects.AM.AMConfigurationFeature</para>
		/// <para>Display Name: Line Nbr</para>
		/// Key Field
		/// </summary>
		[DataMember(Name="LineNbr", EmitDefaultValue=false)]
		public IntValue? LineNbr { get; set; }

		/// <summary>
		/// <para>DAC: PX.Objects.AM.AMConfigurationFeature</para>
		/// <para>Display Name: Lot Qty</para>
		/// <para>SQL Type: nvarchar(MAX)</para>
		/// </summary>
		[DataMember(Name="LotQty", EmitDefaultValue=false)]
		public StringValue? LotQty { get; set; }

		/// <summary>
		/// <para>DAC: PX.Objects.AM.AMConfigurationFeature</para>
		/// <para>Display Name: Max Qty</para>
		/// <para>SQL Type: nvarchar(MAX)</para>
		/// </summary>
		[DataMember(Name="MaxQty", EmitDefaultValue=false)]
		public StringValue? MaxQty { get; set; }

		/// <summary>
		/// <para>DAC: PX.Objects.AM.AMConfigurationFeature</para>
		/// <para>Display Name: Max Selection</para>
		/// <para>SQL Type: nvarchar(MAX)</para>
		/// </summary>
		[DataMember(Name="MaxSelection", EmitDefaultValue=false)]
		public StringValue? MaxSelection { get; set; }

		/// <summary>
		/// <para>DAC: PX.Objects.AM.AMConfigurationFeature</para>
		/// <para>Display Name: Min Qty</para>
		/// <para>SQL Type: nvarchar(MAX)</para>
		/// </summary>
		[DataMember(Name="MinQty", EmitDefaultValue=false)]
		public StringValue? MinQty { get; set; }

		/// <summary>
		/// <para>DAC: PX.Objects.AM.AMConfigurationFeature</para>
		/// <para>Display Name: Min Selection</para>
		/// <para>SQL Type: nvarchar(MAX)</para>
		/// </summary>
		[DataMember(Name="MinSelection", EmitDefaultValue=false)]
		public StringValue? MinSelection { get; set; }

		[DataMember(Name="Options", EmitDefaultValue=false)]
		public List<ConfigurationMaintFeatureOption>? Options { get; set; }

		/// <summary>
		/// Flag used for reporting
		/// <para>DAC: PX.Objects.AM.AMConfigurationFeature</para>
		/// <para>Display Name: Print Results</para>
		/// </summary>
		[DataMember(Name="PrintResults", EmitDefaultValue=false)]
		public BooleanValue? PrintResults { get; set; }

		/// <summary>
		/// <para>DAC: PX.Objects.AM.AMConfigurationFeature</para>
		/// <para>Display Name: Results Copy</para>
		/// </summary>
		[DataMember(Name="ResultsCopy", EmitDefaultValue=false)]
		public BooleanValue? ResultsCopy { get; set; }

		/// <summary>
		/// <para>DAC: PX.Objects.AM.AMConfiguration</para>
		/// <para>SQL Type: nvarchar(10)</para>
		/// Key Field
		/// </summary>
		[DataMember(Name="Revision", EmitDefaultValue=false)]
		public StringValue? Revision { get; set; }

		[DataMember(Name="Rules", EmitDefaultValue=false)]
		public List<ConfigurationMaintFeatureRule>? Rules { get; set; }

		/// <summary>
		/// <para>DAC: PX.Objects.AM.AMConfigurationFeature</para>
		/// <para>Display Name: Sort Order</para>
		/// </summary>
		[DataMember(Name="SortOrder", EmitDefaultValue=false)]
		public IntValue? SortOrder { get; set; }

		/// <summary>
		/// <para>DAC: PX.Objects.AM.AMConfigurationFeature</para>
		/// </summary>
		[DataMember(Name="Visible", EmitDefaultValue=false)]
		public BooleanValue? Visible { get; set; }

	}
}