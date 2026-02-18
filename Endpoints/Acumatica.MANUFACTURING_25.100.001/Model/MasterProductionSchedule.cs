using System;
using System.Collections.Generic;

using Newtonsoft.Json;

using Acumatica.RESTClient.Client;
using Acumatica.RESTClient.ContractBasedApi;
using Acumatica.RESTClient.ContractBasedApi.Model;

namespace Acumatica.MANUFACTURING_25_100_001.Model
{
	/// <summary>
	/// Corresponds to the screen <c>AM201000</c> in the Acumatica ERP
	/// <para>Key Fields: MPSID, Type</para>
	/// </summary>
	public class MasterProductionSchedule : Entity, ITopLevelEntity
	{

		/// <summary>
		/// <para>DAC Field Name: ActiveFlg</para>
		/// <para>DAC: PX.Objects.AM.AMMPS</para>
		/// </summary>
		public BooleanValue? Active { get; set; }

		/// <summary>
		/// <para>DAC Field Name: BOMID_description</para>
		/// <para>DAC: PX.Objects.AM.AMMPS</para>
		/// </summary>
		public StringValue? BOMDescription { get; set; }

		/// <summary>
		/// <para>DAC: PX.Objects.AM.AMMPS</para>
		/// <para>Display Name: BOM ID</para>
		/// <para>SQL Type: nvarchar(15)</para>
		/// </summary>
		public StringValue? BOMID { get; set; }

		/// <summary>
		/// <para>DAC Field Name: BranchID</para>
		/// <para>DAC: PX.Objects.AM.AMMPS</para>
		/// </summary>
		public StringValue? Branch { get; set; }

		/// <summary>
		/// <para>DAC Field Name: InventoryID_description</para>
		/// <para>DAC: PX.Objects.AM.AMMPS</para>
		/// </summary>
		public StringValue? Description { get; set; }

		/// <summary>
		/// <para>DAC: PX.Objects.AM.AMMPS</para>
		/// <para>Display Name: Inventory ID</para>
		/// </summary>
		public StringValue? InventoryID { get; set; }

		/// <summary>
		/// <para>DAC: PX.Objects.AM.AMMPS</para>
		/// <para>Display Name: MPS ID</para>
		/// <para>SQL Type: nvarchar(15)</para>
		/// Key Field
		/// </summary>
		public StringValue? MPSID { get; set; }

		/// <summary>
		/// <para>DAC: PX.Objects.AM.AMMPS</para>
		/// <para>Display Name: Plan Date</para>
		/// </summary>
		public DateTimeValue? PlanDate { get; set; }

		/// <summary>
		/// <para>DAC Field Name: Qty</para>
		/// <para>DAC: PX.Objects.AM.AMMPS</para>
		/// </summary>
		public DecimalValue? Quantity { get; set; }

		/// <summary>
		/// <para>DAC Field Name: SubItemID</para>
		/// <para>DAC: PX.Objects.AM.AMMPS</para>
		/// </summary>
		public StringValue? Subitem { get; set; }

		/// <summary>
		/// <para>DAC Field Name: MPSTypeID</para>
		/// <para>DAC: PX.Objects.AM.AMMPS</para>
		/// <para>SQL Type: nvarchar(20)</para>
		/// Key Field
		/// </summary>
		public StringValue? Type { get; set; }

		/// <summary>
		/// <para>DAC: PX.Objects.AM.AMMPS</para>
		/// <para>SQL Type: nvarchar(6)</para>
		/// </summary>
		public StringValue? UOM { get; set; }

		/// <summary>
		/// <para>DAC Field Name: SiteID</para>
		/// <para>DAC: PX.Objects.AM.AMMPS</para>
		/// </summary>
		public StringValue? Warehouse { get; set; }

		public static class Expand
		{
			public const string Files = "Files";
			public const string Translations = "Translations";

			//Intentionally excluded
			//public const string All = "Files,Translations";
		}
		public virtual string GetEndpointPath()
		{
			return "entity/MANUFACTURING/25.100.001";
		}
	}
}