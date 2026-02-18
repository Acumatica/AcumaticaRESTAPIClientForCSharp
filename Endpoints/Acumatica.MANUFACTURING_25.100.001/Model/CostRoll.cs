using System;
using System.Collections.Generic;

using Newtonsoft.Json;

using Acumatica.RESTClient.Client;
using Acumatica.RESTClient.ContractBasedApi;
using Acumatica.RESTClient.ContractBasedApi.Model;

namespace Acumatica.MANUFACTURING_25_100_001.Model
{
	/// <summary>
	/// Corresponds to the screen <c>AM508000</c> in the Acumatica ERP
	/// </summary>
	public class CostRoll : Entity, ITopLevelEntity
	{

		/// <summary>
		/// <para>DAC Field Name: ApplyPend</para>
		/// <para>DAC: {}</para>
		/// </summary>
		public BooleanValue? ApplytoPendingCosts { get; set; }

		/// <summary>
		/// <para>DAC: {}</para>
		/// </summary>
		public StringValue? BOMID { get; set; }

		/// <summary>
		/// <para>DAC: {}</para>
		/// </summary>
		public DateTimeValue? EffectiveDate { get; set; }

		/// <summary>
		/// <para>DAC: {}</para>
		/// </summary>
		public BooleanValue? IgnoreMinMaxLotSizeValues { get; set; }

		/// <summary>
		/// <para>DAC Field Name: IncFixed</para>
		/// <para>DAC: {}</para>
		/// </summary>
		public BooleanValue? IncludeFixedCosts { get; set; }

		/// <summary>
		/// <para>DAC Field Name: IncMatScrp</para>
		/// <para>DAC: {}</para>
		/// </summary>
		public BooleanValue? IncludeMaterialScrapFactors { get; set; }

		/// <summary>
		/// <para>DAC: {}</para>
		/// </summary>
		public StringValue? InventoryID { get; set; }

		/// <summary>
		/// <para>DAC Field Name: ItemClassID</para>
		/// <para>DAC: {}</para>
		/// </summary>
		public StringValue? ItemClass { get; set; }

		/// <summary>
		/// <para>DAC Field Name: SnglMlti</para>
		/// <para>DAC: {}</para>
		/// </summary>
		public StringValue? Level { get; set; }

		public List<CostRollResult>? Results { get; set; }

		/// <summary>
		/// <para>DAC Field Name: RevisionID</para>
		/// <para>DAC: {}</para>
		/// </summary>
		public StringValue? Revision { get; set; }

		/// <summary>
		/// <para>DAC Field Name: SubItemID</para>
		/// <para>DAC: {}</para>
		/// </summary>
		public StringValue? Subitem { get; set; }

		/// <summary>
		/// <para>DAC: {}</para>
		/// </summary>
		public BooleanValue? UpdateMaterial { get; set; }

		/// <summary>
		/// <para>DAC Field Name: UsePending</para>
		/// <para>DAC: {}</para>
		/// </summary>
		public BooleanValue? UsePendingStandardCostforPurchaseItems { get; set; }

		/// <summary>
		/// <para>DAC Field Name: SiteId</para>
		/// <para>DAC: {}</para>
		/// </summary>
		public StringValue? Warehouse { get; set; }

		public static class Expand
		{
			public const string Files = "Files";
			public const string Translations = "Translations";
			public const string Results = "Results";
			public const string Results_Files = "Results/Files";

			//Intentionally excluded
			//public const string All = "Files,Translations,Results,Results/Files";
		}
		public virtual string GetEndpointPath()
		{
			return "entity/MANUFACTURING/25.100.001";
		}
	}
}