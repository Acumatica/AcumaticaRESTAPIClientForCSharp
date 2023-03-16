using Acumatica.RESTClient.Model;
using System.Collections.Generic;
using System.Runtime.Serialization;

namespace Acumatica.Manufacturing_20_200_001.Model
{
	[DataContract]
	public class CostRoll : Entity
	{

		[DataMember(Name="ApplytoPendingCosts", EmitDefaultValue=false)]
		public BooleanValue ApplytoPendingCosts { get; set; }

		[DataMember(Name="BOMID", EmitDefaultValue=false)]
		public StringValue BOMID { get; set; }

		[DataMember(Name="EffectiveDate", EmitDefaultValue=false)]
		public DateTimeValue EffectiveDate { get; set; }

		[DataMember(Name="IgnoreMinMaxLotSizeValues", EmitDefaultValue=false)]
		public BooleanValue IgnoreMinMaxLotSizeValues { get; set; }

		[DataMember(Name="IncludeFixedCosts", EmitDefaultValue=false)]
		public BooleanValue IncludeFixedCosts { get; set; }

		[DataMember(Name="IncludeMaterialScrapFactors", EmitDefaultValue=false)]
		public BooleanValue IncludeMaterialScrapFactors { get; set; }

		[DataMember(Name="InventoryID", EmitDefaultValue=false)]
		public StringValue InventoryID { get; set; }

		[DataMember(Name="ItemBOM", EmitDefaultValue=false)]
		public StringValue ItemBOM { get; set; }

		[DataMember(Name="ItemClass", EmitDefaultValue=false)]
		public StringValue ItemClass { get; set; }

		[DataMember(Name="Level", EmitDefaultValue=false)]
		public StringValue Level { get; set; }

		[DataMember(Name="Results", EmitDefaultValue=false)]
		public List<CostRollResult> Results { get; set; }

		[DataMember(Name="Revision", EmitDefaultValue=false)]
		public StringValue Revision { get; set; }

		[DataMember(Name="Subitem", EmitDefaultValue=false)]
		public StringValue Subitem { get; set; }

		[DataMember(Name="UpdateMaterial", EmitDefaultValue=false)]
		public BooleanValue UpdateMaterial { get; set; }

		[DataMember(Name="UsePendingStandardCostforPurchaseItems", EmitDefaultValue=false)]
		public BooleanValue UsePendingStandardCostforPurchaseItems { get; set; }

		[DataMember(Name="Warehouse", EmitDefaultValue=false)]
		public StringValue Warehouse { get; set; }

	}
}