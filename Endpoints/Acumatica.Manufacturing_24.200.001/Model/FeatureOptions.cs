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
	public class FeatureOptions : Entity
	{

		/// <summary>
		/// <para>DAC Field Name: BFlush</para>
		/// <para>DAC: PX.Objects.AM.AMFeatureOption</para>
		/// </summary>
		[DataMember(Name="Backflush", EmitDefaultValue=false)]
		public BooleanValue? Backflush { get; set; }

		/// <summary>
		/// <para>DAC: PX.Objects.AM.AMFeatureOption</para>
		/// <para>Display Name: Batch Size</para>
		/// </summary>
		[DataMember(Name="BatchSize", EmitDefaultValue=false)]
		public DecimalValue? BatchSize { get; set; }

		/// <summary>
		/// <para>DAC Field Name: Descr</para>
		/// <para>DAC: PX.Objects.AM.AMFeature</para>
		/// <para>SQL Type: nvarchar(256)</para>
		/// </summary>
		[DataMember(Name="Description", EmitDefaultValue=false)]
		public StringValue? Description { get; set; }

		/// <summary>
		/// <para>DAC: PX.Objects.AM.AMFeature</para>
		/// <para>Display Name: Feature ID</para>
		/// <para>SQL Type: nvarchar(30)</para>
		/// Key Field
		/// </summary>
		[DataMember(Name="FeatureID", EmitDefaultValue=false)]
		public StringValue? FeatureID { get; set; }

		/// <summary>
		/// <para>DAC: PX.Objects.AM.AMFeatureOption</para>
		/// <para>Display Name: Fixed Include</para>
		/// </summary>
		[DataMember(Name="FixedInclude", EmitDefaultValue=false)]
		public BooleanValue? FixedInclude { get; set; }

		/// <summary>
		/// <para>DAC: PX.Objects.AM.AMFeatureOption</para>
		/// <para>Display Name: Inventory ID</para>
		/// </summary>
		[DataMember(Name="InventoryID", EmitDefaultValue=false)]
		public StringValue? InventoryID { get; set; }

		/// <summary>
		/// <para>DAC: PX.Objects.AM.AMFeatureOption</para>
		/// <para>SQL Type: nvarchar(30)</para>
		/// </summary>
		[DataMember(Name="Label", EmitDefaultValue=false)]
		public StringValue? Label { get; set; }

		/// <summary>
		/// <para>DAC: PX.Objects.AM.AMFeatureOption</para>
		/// <para>Display Name: Line Nbr</para>
		/// Key Field
		/// </summary>
		[DataMember(Name="LineNbr", EmitDefaultValue=false)]
		public IntValue? LineNbr { get; set; }

		/// <summary>
		/// <para>DAC: PX.Objects.AM.AMFeatureOption</para>
		/// <para>Display Name: Lot Qty</para>
		/// <para>SQL Type: nvarchar(MAX)</para>
		/// </summary>
		[DataMember(Name="LotQty", EmitDefaultValue=false)]
		public StringValue? LotQty { get; set; }

		/// <summary>
		/// <para>DAC: PX.Objects.AM.AMFeatureOption</para>
		/// <para>Display Name: Material Type</para>
		/// </summary>
		[DataMember(Name="MaterialType", EmitDefaultValue=false)]
		public StringValue? MaterialType { get; set; }

		/// <summary>
		/// <para>DAC: PX.Objects.AM.AMFeatureOption</para>
		/// <para>Display Name: Max Qty</para>
		/// <para>SQL Type: nvarchar(MAX)</para>
		/// </summary>
		[DataMember(Name="MaxQty", EmitDefaultValue=false)]
		public StringValue? MaxQty { get; set; }

		/// <summary>
		/// <para>DAC: PX.Objects.AM.AMFeatureOption</para>
		/// <para>Display Name: Min Qty</para>
		/// <para>SQL Type: nvarchar(MAX)</para>
		/// </summary>
		[DataMember(Name="MinQty", EmitDefaultValue=false)]
		public StringValue? MinQty { get; set; }

		/// <summary>
		/// <para>DAC: PX.Objects.AM.AMFeatureOption</para>
		/// <para>Display Name: Phantom Routing</para>
		/// </summary>
		[DataMember(Name="PhantomRouting", EmitDefaultValue=false)]
		public StringValue? PhantomRouting { get; set; }

		/// <summary>
		/// <para>DAC: PX.Objects.AM.AMFeatureOption</para>
		/// <para>Display Name: Price Factor</para>
		/// <para>SQL Type: nvarchar(MAX)</para>
		/// </summary>
		[DataMember(Name="PriceFactor", EmitDefaultValue=false)]
		public StringValue? PriceFactor { get; set; }

		/// <summary>
		/// Flag used for reporting
		/// <para>DAC: PX.Objects.AM.AMFeature</para>
		/// <para>Display Name: Print Results</para>
		/// </summary>
		[DataMember(Name="PrintResults", EmitDefaultValue=false)]
		public BooleanValue? PrintResults { get; set; }

		/// <summary>
		/// <para>DAC: PX.Objects.AM.AMFeatureOption</para>
		/// <para>Display Name: Qty Enabled</para>
		/// </summary>
		[DataMember(Name="QtyEnabled", EmitDefaultValue=false)]
		public BooleanValue? QtyEnabled { get; set; }

		/// <summary>
		/// <para>DAC: PX.Objects.AM.AMFeatureOption</para>
		/// <para>Display Name: Qty Required</para>
		/// <para>SQL Type: nvarchar(MAX)</para>
		/// </summary>
		[DataMember(Name="QtyRequired", EmitDefaultValue=false)]
		public StringValue? QtyRequired { get; set; }

		/// <summary>
		/// <para>DAC: PX.Objects.AM.AMFeatureOption</para>
		/// <para>Display Name: Qty Round Up</para>
		/// </summary>
		[DataMember(Name="QtyRoundUp", EmitDefaultValue=false)]
		public BooleanValue? QtyRoundUp { get; set; }

		/// <summary>
		/// <para>DAC: PX.Objects.AM.AMFeatureOption</para>
		/// <para>Display Name: Results Copy</para>
		/// </summary>
		[DataMember(Name="ResultsCopy", EmitDefaultValue=false)]
		public BooleanValue? ResultsCopy { get; set; }

		/// <summary>
		/// <para>DAC: PX.Objects.AM.AMFeatureOption</para>
		/// <para>Display Name: Scrap Factor</para>
		/// <para>SQL Type: nvarchar(MAX)</para>
		/// </summary>
		[DataMember(Name="ScrapFactor", EmitDefaultValue=false)]
		public StringValue? ScrapFactor { get; set; }

		/// <summary>
		/// <para>DAC: PX.Objects.AM.AMFeatureOption</para>
		/// <para>Display Name: Subcontract Source</para>
		/// </summary>
		[DataMember(Name="SubcontractSource", EmitDefaultValue=false)]
		public StringValue? SubcontractSource { get; set; }

		/// <summary>
		/// <para>DAC Field Name: SubItemID</para>
		/// <para>DAC: PX.Objects.AM.AMFeatureOption</para>
		/// </summary>
		[DataMember(Name="Subitem", EmitDefaultValue=false)]
		public StringValue? Subitem { get; set; }

		/// <summary>
		/// <para>DAC: PX.Objects.AM.AMFeatureOption</para>
		/// <para>SQL Type: nvarchar(6)</para>
		/// </summary>
		[DataMember(Name="UOM", EmitDefaultValue=false)]
		public StringValue? UOM { get; set; }

	}
}