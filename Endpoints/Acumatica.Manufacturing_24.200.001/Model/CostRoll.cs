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
	/// Corresponds to the screen <c>AM508000</c> in the Acumatica ERP
	/// </summary>
	[DataContract]
	public class CostRoll : Entity, ITopLevelEntity
	{

		/// <summary>
		/// <para>DAC Field Name: ApplyPend</para>
		/// <para>DAC: {}</para>
		/// </summary>
		[DataMember(Name="ApplytoPendingCosts", EmitDefaultValue=false)]
		public BooleanValue? ApplytoPendingCosts { get; set; }

		/// <summary>
		/// <para>DAC: {}</para>
		/// </summary>
		[DataMember(Name="BOMID", EmitDefaultValue=false)]
		public StringValue? BOMID { get; set; }

		/// <summary>
		/// <para>DAC: {}</para>
		/// </summary>
		[DataMember(Name="EffectiveDate", EmitDefaultValue=false)]
		public DateTimeValue? EffectiveDate { get; set; }

		/// <summary>
		/// <para>DAC: {}</para>
		/// </summary>
		[DataMember(Name="IgnoreMinMaxLotSizeValues", EmitDefaultValue=false)]
		public BooleanValue? IgnoreMinMaxLotSizeValues { get; set; }

		/// <summary>
		/// <para>DAC Field Name: IncFixed</para>
		/// <para>DAC: {}</para>
		/// </summary>
		[DataMember(Name="IncludeFixedCosts", EmitDefaultValue=false)]
		public BooleanValue? IncludeFixedCosts { get; set; }

		/// <summary>
		/// <para>DAC Field Name: IncMatScrp</para>
		/// <para>DAC: {}</para>
		/// </summary>
		[DataMember(Name="IncludeMaterialScrapFactors", EmitDefaultValue=false)]
		public BooleanValue? IncludeMaterialScrapFactors { get; set; }

		/// <summary>
		/// <para>DAC: {}</para>
		/// </summary>
		[DataMember(Name="InventoryID", EmitDefaultValue=false)]
		public StringValue? InventoryID { get; set; }

		/// <summary>
		/// <para>DAC Field Name: ItemClassID</para>
		/// <para>DAC: {}</para>
		/// </summary>
		[DataMember(Name="ItemClass", EmitDefaultValue=false)]
		public StringValue? ItemClass { get; set; }

		/// <summary>
		/// <para>DAC Field Name: SnglMlti</para>
		/// <para>DAC: {}</para>
		/// </summary>
		[DataMember(Name="Level", EmitDefaultValue=false)]
		public StringValue? Level { get; set; }

		[DataMember(Name="Results", EmitDefaultValue=false)]
		public List<CostRollResult>? Results { get; set; }

		/// <summary>
		/// <para>DAC Field Name: RevisionID</para>
		/// <para>DAC: {}</para>
		/// </summary>
		[DataMember(Name="Revision", EmitDefaultValue=false)]
		public StringValue? Revision { get; set; }

		/// <summary>
		/// <para>DAC Field Name: SubItemID</para>
		/// <para>DAC: {}</para>
		/// </summary>
		[DataMember(Name="Subitem", EmitDefaultValue=false)]
		public StringValue? Subitem { get; set; }

		/// <summary>
		/// <para>DAC: {}</para>
		/// </summary>
		[DataMember(Name="UpdateMaterial", EmitDefaultValue=false)]
		public BooleanValue? UpdateMaterial { get; set; }

		/// <summary>
		/// <para>DAC Field Name: UsePending</para>
		/// <para>DAC: {}</para>
		/// </summary>
		[DataMember(Name="UsePendingStandardCostforPurchaseItems", EmitDefaultValue=false)]
		public BooleanValue? UsePendingStandardCostforPurchaseItems { get; set; }

		/// <summary>
		/// <para>DAC Field Name: SiteId</para>
		/// <para>DAC: {}</para>
		/// </summary>
		[DataMember(Name="Warehouse", EmitDefaultValue=false)]
		public StringValue? Warehouse { get; set; }

		public static class Expand
		{
			public const string Files = "Files";
			public const string Results = "Results";
			public const string Results_Files = "Results/Files";

			//Intentionally excluded
			//public const string All = "Files,Results,Results/Files";
		}
		public virtual string GetEndpointPath()
		{
			return "entity/MANUFACTURING/24.200.001";
		}
	}
}