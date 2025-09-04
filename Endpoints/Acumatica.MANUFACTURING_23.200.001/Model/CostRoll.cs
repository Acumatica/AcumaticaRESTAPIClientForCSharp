using System;
using System.Collections.Generic;
using System.Runtime.Serialization;

using Newtonsoft.Json;

using Acumatica.RESTClient.Client;
using Acumatica.RESTClient.ContractBasedApi;
using Acumatica.RESTClient.ContractBasedApi.Model;

namespace Acumatica.Manufacturing_23_200_001.Model
{
	/// <summary>
	/// Corresponds to the screen AM508000 in the Acumatica ERP
	/// </summary>
	[DataContract]
	public class CostRoll : Entity, ITopLevelEntity
	{

		/// <summary>
		/// DAC Field Name: ApplyPend 
		/// DAC: {} 
		/// </summary>
		[DataMember(Name="ApplytoPendingCosts", EmitDefaultValue=false)]
		public BooleanValue? ApplytoPendingCosts { get; set; }

		/// <summary>
		/// DAC: {} 
		/// </summary>
		[DataMember(Name="BOMID", EmitDefaultValue=false)]
		public StringValue? BOMID { get; set; }

		/// <summary>
		/// DAC: {} 
		/// </summary>
		[DataMember(Name="EffectiveDate", EmitDefaultValue=false)]
		public DateTimeValue? EffectiveDate { get; set; }

		/// <summary>
		/// DAC: {} 
		/// </summary>
		[DataMember(Name="IgnoreMinMaxLotSizeValues", EmitDefaultValue=false)]
		public BooleanValue? IgnoreMinMaxLotSizeValues { get; set; }

		/// <summary>
		/// DAC Field Name: IncFixed 
		/// DAC: {} 
		/// </summary>
		[DataMember(Name="IncludeFixedCosts", EmitDefaultValue=false)]
		public BooleanValue? IncludeFixedCosts { get; set; }

		/// <summary>
		/// DAC Field Name: IncMatScrp 
		/// DAC: {} 
		/// </summary>
		[DataMember(Name="IncludeMaterialScrapFactors", EmitDefaultValue=false)]
		public BooleanValue? IncludeMaterialScrapFactors { get; set; }

		/// <summary>
		/// DAC: {} 
		/// </summary>
		[DataMember(Name="InventoryID", EmitDefaultValue=false)]
		public StringValue? InventoryID { get; set; }

		/// <summary>
		/// DAC Field Name: ItemClassID 
		/// DAC: {} 
		/// </summary>
		[DataMember(Name="ItemClass", EmitDefaultValue=false)]
		public StringValue? ItemClass { get; set; }

		/// <summary>
		/// DAC Field Name: SnglMlti 
		/// DAC: {} 
		/// </summary>
		[DataMember(Name="Level", EmitDefaultValue=false)]
		public StringValue? Level { get; set; }

		[DataMember(Name="Results", EmitDefaultValue=false)]
		public List<CostRollResult>? Results { get; set; }

		/// <summary>
		/// DAC Field Name: RevisionID 
		/// DAC: {} 
		/// </summary>
		[DataMember(Name="Revision", EmitDefaultValue=false)]
		public StringValue? Revision { get; set; }

		/// <summary>
		/// DAC Field Name: SubItemID 
		/// DAC: {} 
		/// </summary>
		[DataMember(Name="Subitem", EmitDefaultValue=false)]
		public StringValue? Subitem { get; set; }

		/// <summary>
		/// DAC: {} 
		/// </summary>
		[DataMember(Name="UpdateMaterial", EmitDefaultValue=false)]
		public BooleanValue? UpdateMaterial { get; set; }

		/// <summary>
		/// DAC Field Name: UsePending 
		/// DAC: {} 
		/// </summary>
		[DataMember(Name="UsePendingStandardCostforPurchaseItems", EmitDefaultValue=false)]
		public BooleanValue? UsePendingStandardCostforPurchaseItems { get; set; }

		/// <summary>
		/// DAC Field Name: SiteId 
		/// DAC: {} 
		/// </summary>
		[DataMember(Name="Warehouse", EmitDefaultValue=false)]
		public StringValue? Warehouse { get; set; }

		public virtual string GetEndpointPath()
		{
			return "entity/MANUFACTURING/23.200.001";
		}
	}
}