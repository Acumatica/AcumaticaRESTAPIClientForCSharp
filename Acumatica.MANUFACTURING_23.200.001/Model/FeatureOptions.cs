using System;
using System.Collections.Generic;
using System.Runtime.Serialization;

using Newtonsoft.Json;

using Acumatica.RESTClient.Client;
using Acumatica.RESTClient.ContractBasedApi;
using Acumatica.RESTClient.ContractBasedApi.Model;

namespace Acumatica.Manufacturing_23_200_001.Model
{
	[DataContract]
	public class FeatureOptions : Entity
	{

		/// <summary>
		/// DAC Field Name: BFlush 
		/// DAC: PX.Objects.AM.AMFeatureOption 
		/// </summary>
		[DataMember(Name="Backflush", EmitDefaultValue=false)]
		public BooleanValue? Backflush { get; set; }

		/// <summary>
		/// DAC: PX.Objects.AM.AMFeatureOption 
		/// Display Name: Batch Size 
		/// </summary>
		[DataMember(Name="BatchSize", EmitDefaultValue=false)]
		public DecimalValue? BatchSize { get; set; }

		/// <summary>
		/// DAC Field Name: Descr 
		/// DAC: PX.Objects.AM.AMFeature 
		/// SQL Type: nvarchar(256) 
		/// </summary>
		[DataMember(Name="Description", EmitDefaultValue=false)]
		public StringValue? Description { get; set; }

		/// <summary>
		/// DAC: PX.Objects.AM.AMFeature 
		/// Display Name: Feature ID 
		/// SQL Type: nvarchar(30) 
		/// Key Field
		/// </summary>
		[DataMember(Name="FeatureID", EmitDefaultValue=false)]
		public StringValue? FeatureID { get; set; }

		/// <summary>
		/// DAC: PX.Objects.AM.AMFeatureOption 
		/// Display Name: Fixed Include 
		/// </summary>
		[DataMember(Name="FixedInclude", EmitDefaultValue=false)]
		public BooleanValue? FixedInclude { get; set; }

		/// <summary>
		/// DAC: PX.Objects.AM.AMFeatureOption 
		/// Display Name: Inventory ID 
		/// </summary>
		[DataMember(Name="InventoryID", EmitDefaultValue=false)]
		public StringValue? InventoryID { get; set; }

		/// <summary>
		/// DAC: PX.Objects.AM.AMFeatureOption 
		/// SQL Type: nvarchar(30) 
		/// </summary>
		[DataMember(Name="Label", EmitDefaultValue=false)]
		public StringValue? Label { get; set; }

		/// <summary>
		/// DAC: PX.Objects.AM.AMFeatureOption 
		/// Display Name: Line Nbr 
		/// Key Field
		/// </summary>
		[DataMember(Name="LineNbr", EmitDefaultValue=false)]
		public IntValue? LineNbr { get; set; }

		/// <summary>
		/// DAC: PX.Objects.AM.AMFeatureOption 
		/// Display Name: Lot Qty 
		/// SQL Type: nvarchar(MAX) 
		/// </summary>
		[DataMember(Name="LotQty", EmitDefaultValue=false)]
		public StringValue? LotQty { get; set; }

		/// <summary>
		/// DAC: PX.Objects.AM.AMFeatureOption 
		/// Display Name: Material Type 
		/// </summary>
		[DataMember(Name="MaterialType", EmitDefaultValue=false)]
		public StringValue? MaterialType { get; set; }

		/// <summary>
		/// DAC: PX.Objects.AM.AMFeatureOption 
		/// Display Name: Max Qty 
		/// SQL Type: nvarchar(MAX) 
		/// </summary>
		[DataMember(Name="MaxQty", EmitDefaultValue=false)]
		public StringValue? MaxQty { get; set; }

		/// <summary>
		/// DAC: PX.Objects.AM.AMFeatureOption 
		/// Display Name: Min Qty 
		/// SQL Type: nvarchar(MAX) 
		/// </summary>
		[DataMember(Name="MinQty", EmitDefaultValue=false)]
		public StringValue? MinQty { get; set; }

		/// <summary>
		/// DAC: PX.Objects.AM.AMFeatureOption 
		/// Display Name: Phantom Routing 
		/// </summary>
		[DataMember(Name="PhantomRouting", EmitDefaultValue=false)]
		public StringValue? PhantomRouting { get; set; }

		/// <summary>
		/// DAC: PX.Objects.AM.AMFeatureOption 
		/// Display Name: Price Factor 
		/// SQL Type: nvarchar(MAX) 
		/// </summary>
		[DataMember(Name="PriceFactor", EmitDefaultValue=false)]
		public StringValue? PriceFactor { get; set; }

		/// <summary>
		/// Flag used for reporting
		/// DAC: PX.Objects.AM.AMFeature 
		/// Display Name: Print Results 
		/// </summary>
		[DataMember(Name="PrintResults", EmitDefaultValue=false)]
		public BooleanValue? PrintResults { get; set; }

		/// <summary>
		/// DAC: PX.Objects.AM.AMFeatureOption 
		/// Display Name: Qty Enabled 
		/// </summary>
		[DataMember(Name="QtyEnabled", EmitDefaultValue=false)]
		public BooleanValue? QtyEnabled { get; set; }

		/// <summary>
		/// DAC: PX.Objects.AM.AMFeatureOption 
		/// Display Name: Qty Required 
		/// SQL Type: nvarchar(MAX) 
		/// </summary>
		[DataMember(Name="QtyRequired", EmitDefaultValue=false)]
		public StringValue? QtyRequired { get; set; }

		/// <summary>
		/// DAC: PX.Objects.AM.AMFeatureOption 
		/// Display Name: Qty Round Up 
		/// </summary>
		[DataMember(Name="QtyRoundUp", EmitDefaultValue=false)]
		public BooleanValue? QtyRoundUp { get; set; }

		/// <summary>
		/// DAC: PX.Objects.AM.AMFeatureOption 
		/// Display Name: Results Copy 
		/// </summary>
		[DataMember(Name="ResultsCopy", EmitDefaultValue=false)]
		public BooleanValue? ResultsCopy { get; set; }

		/// <summary>
		/// DAC: PX.Objects.AM.AMFeatureOption 
		/// Display Name: Scrap Factor 
		/// SQL Type: nvarchar(MAX) 
		/// </summary>
		[DataMember(Name="ScrapFactor", EmitDefaultValue=false)]
		public StringValue? ScrapFactor { get; set; }

		/// <summary>
		/// DAC: PX.Objects.AM.AMFeatureOption 
		/// Display Name: Subcontract Source 
		/// </summary>
		[DataMember(Name="SubcontractSource", EmitDefaultValue=false)]
		public StringValue? SubcontractSource { get; set; }

		/// <summary>
		/// DAC Field Name: SubItemID 
		/// DAC: PX.Objects.AM.AMFeatureOption 
		/// </summary>
		[DataMember(Name="Subitem", EmitDefaultValue=false)]
		public StringValue? Subitem { get; set; }

		/// <summary>
		/// DAC: PX.Objects.AM.AMFeatureOption 
		/// SQL Type: nvarchar(6) 
		/// </summary>
		[DataMember(Name="UOM", EmitDefaultValue=false)]
		public StringValue? UOM { get; set; }

	}
}