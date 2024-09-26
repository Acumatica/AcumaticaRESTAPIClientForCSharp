using System;
using System.Collections.Generic;
using System.Runtime.Serialization;

using Newtonsoft.Json;

using Acumatica.RESTClient.Client;
using Acumatica.RESTClient.ContractBasedApi;
using Acumatica.RESTClient.ContractBasedApi.Model;

namespace Acumatica.Manufacturing_24_200_001.Model
{
	/// <summary>
	/// Corresponds to the screen AM508000 in the Acumatica ERP
	/// </summary>
	[DataContract]
	public class CostRoll : Entity, ITopLevelEntity
	{

		/// <summary>
		/// 
		/// Display Name:
		/// DAC Field Name: ApplyPend 
		/// DAC: {} 
		/// </summary>
		/// <remarks>
		/// 
		/// </remarks>
		[DataMember(Name="ApplytoPendingCosts", EmitDefaultValue=false)]
		public BooleanValue? ApplytoPendingCosts { get; set; }

		/// <summary>
		/// 
		/// Display Name:
		/// DAC Field Name: BOMID 
		/// DAC: {} 
		/// </summary>
		/// <remarks>
		/// 
		/// </remarks>
		[DataMember(Name="BOMID", EmitDefaultValue=false)]
		public StringValue? BOMID { get; set; }

		/// <summary>
		/// 
		/// Display Name:
		/// DAC Field Name: EffectiveDate 
		/// DAC: {} 
		/// </summary>
		/// <remarks>
		/// 
		/// </remarks>
		[DataMember(Name="EffectiveDate", EmitDefaultValue=false)]
		public DateTimeValue? EffectiveDate { get; set; }

		/// <summary>
		/// 
		/// Display Name:
		/// DAC Field Name: IgnoreMinMaxLotSizeValues 
		/// DAC: {} 
		/// </summary>
		/// <remarks>
		/// 
		/// </remarks>
		[DataMember(Name="IgnoreMinMaxLotSizeValues", EmitDefaultValue=false)]
		public BooleanValue? IgnoreMinMaxLotSizeValues { get; set; }

		/// <summary>
		/// 
		/// Display Name:
		/// DAC Field Name: IncFixed 
		/// DAC: {} 
		/// </summary>
		/// <remarks>
		/// 
		/// </remarks>
		[DataMember(Name="IncludeFixedCosts", EmitDefaultValue=false)]
		public BooleanValue? IncludeFixedCosts { get; set; }

		/// <summary>
		/// 
		/// Display Name:
		/// DAC Field Name: IncMatScrp 
		/// DAC: {} 
		/// </summary>
		/// <remarks>
		/// 
		/// </remarks>
		[DataMember(Name="IncludeMaterialScrapFactors", EmitDefaultValue=false)]
		public BooleanValue? IncludeMaterialScrapFactors { get; set; }

		/// <summary>
		/// 
		/// Display Name:
		/// DAC Field Name: InventoryID 
		/// DAC: {} 
		/// </summary>
		/// <remarks>
		/// 
		/// </remarks>
		[DataMember(Name="InventoryID", EmitDefaultValue=false)]
		public StringValue? InventoryID { get; set; }

		/// <summary>
		/// 
		/// Display Name:
		/// DAC Field Name: ItemClassID 
		/// DAC: {} 
		/// </summary>
		/// <remarks>
		/// 
		/// </remarks>
		[DataMember(Name="ItemClass", EmitDefaultValue=false)]
		public StringValue? ItemClass { get; set; }

		/// <summary>
		/// 
		/// Display Name:
		/// DAC Field Name: SnglMlti 
		/// DAC: {} 
		/// </summary>
		/// <remarks>
		/// 
		/// </remarks>
		[DataMember(Name="Level", EmitDefaultValue=false)]
		public StringValue? Level { get; set; }

		[DataMember(Name="Results", EmitDefaultValue=false)]
		public List<CostRollResult>? Results { get; set; }

		/// <summary>
		/// 
		/// Display Name:
		/// DAC Field Name: RevisionID 
		/// DAC: {} 
		/// </summary>
		/// <remarks>
		/// 
		/// </remarks>
		[DataMember(Name="Revision", EmitDefaultValue=false)]
		public StringValue? Revision { get; set; }

		/// <summary>
		/// 
		/// Display Name:
		/// DAC Field Name: SubItemID 
		/// DAC: {} 
		/// </summary>
		/// <remarks>
		/// 
		/// </remarks>
		[DataMember(Name="Subitem", EmitDefaultValue=false)]
		public StringValue? Subitem { get; set; }

		/// <summary>
		/// 
		/// Display Name:
		/// DAC Field Name: UpdateMaterial 
		/// DAC: {} 
		/// </summary>
		/// <remarks>
		/// 
		/// </remarks>
		[DataMember(Name="UpdateMaterial", EmitDefaultValue=false)]
		public BooleanValue? UpdateMaterial { get; set; }

		/// <summary>
		/// 
		/// Display Name:
		/// DAC Field Name: UsePending 
		/// DAC: {} 
		/// </summary>
		/// <remarks>
		/// 
		/// </remarks>
		[DataMember(Name="UsePendingStandardCostforPurchaseItems", EmitDefaultValue=false)]
		public BooleanValue? UsePendingStandardCostforPurchaseItems { get; set; }

		/// <summary>
		/// 
		/// Display Name:
		/// DAC Field Name: SiteId 
		/// DAC: {} 
		/// </summary>
		/// <remarks>
		/// 
		/// </remarks>
		[DataMember(Name="Warehouse", EmitDefaultValue=false)]
		public StringValue? Warehouse { get; set; }

		public virtual string GetEndpointPath()
		{
			return "entity/MANUFACTURING/24.200.001";
		}
	}
}