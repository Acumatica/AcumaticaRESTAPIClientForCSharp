using System;
using System.Collections.Generic;

using Newtonsoft.Json;

using Acumatica.RESTClient.Client;
using Acumatica.RESTClient.ContractBasedApi;
using Acumatica.RESTClient.ContractBasedApi.Model;

namespace Acumatica.MANUFACTURING_25_100_001.Model
{
	/// <summary>
	/// Corresponds to the screen <c>AM208000</c> in the Acumatica ERP
	/// <para>Key Fields: BOMID, Revision</para>
	/// </summary>
	public class BillOfMaterial : Entity, ITopLevelEntity
	{

		/// <summary>
		/// The identifier of the bill of material.
		/// <para>DAC: PX.Objects.AM.AMBomItem</para>
		/// <para>Display Name: BOM ID</para>
		/// <para>SQL Type: nvarchar(15)</para>
		/// Key Field
		/// </summary>
		public StringValue? BOMID { get; set; }

		/// <summary>
		/// A description of the bill of material. The system copies the description to production orders that are created by using the bill of material.
		/// <para>DAC Field Name: Descr</para>
		/// <para>DAC: PX.Objects.AM.AMBomItem</para>
		/// <para>SQL Type: nvarchar(256)</para>
		/// </summary>
		public StringValue? Description { get; set; }

		/// <summary>
		/// The last date when the BOM revision was effective.
		/// <para>DAC: PX.Objects.AM.AMBomItem</para>
		/// <para>Display Name: End Date</para>
		/// </summary>
		public DateTimeValue? EffEndDate { get; set; }

		/// <summary>
		/// The date when the BOM revision becomes effective.
		/// <para>DAC: PX.Objects.AM.AMBomItem</para>
		/// <para>Display Name: Start Date</para>
		/// </summary>
		public DateTimeValue? EffStartDate { get; set; }

		/// <summary>
		/// A Boolean value that indicates whether the BOM item is on hold.
		/// <para>DAC: PX.Objects.AM.AMBomItem</para>
		/// </summary>
		public BooleanValue? Hold { get; set; }

		/// <summary>
		/// The identifier of the stock item that is produced by using the bill of material.
		/// <para>DAC: PX.Objects.AM.AMBomItem</para>
		/// <para>Display Name: Inventory ID</para>
		/// </summary>
		public StringValue? InventoryID { get; set; }

		public List<OperationDetail>? Operations { get; set; }

		/// <summary>
		/// The identifier of the BOM revision, which is the modification of the bill of material.
		/// <para>DAC Field Name: RevisionID</para>
		/// <para>DAC: PX.Objects.AM.AMBomItem</para>
		/// <para>SQL Type: nvarchar(10)</para>
		/// Key Field
		/// </summary>
		public StringValue? Revision { get; set; }

		/// <summary>
		/// The status of the revision.
		/// <para>DAC: PX.Objects.AM.AMBomItem</para>
		/// <para>SQL Type: char(1)</para>
		/// </summary>
		public StringValue? Status { get; set; }

		/// <summary>
		/// The subitem of the stock item.
		/// <para>DAC Field Name: SubItemID</para>
		/// <para>DAC: PX.Objects.AM.AMBomItem</para>
		/// </summary>
		public StringValue? Subitem { get; set; }

		/// <summary>
		/// The warehouse to which the produced stock item is received when the item production is completed.
		/// <para>DAC Field Name: SiteID</para>
		/// <para>DAC: PX.Objects.AM.AMBomItem</para>
		/// </summary>
		public StringValue? Warehouse { get; set; }

		public static class Expand
		{
			public const string Files = "Files";
			public const string Translations = "Translations";
			public const string Operations = "Operations";
			public const string Operations_Files = "Operations/Files";
			public const string Operations_Material = "Operations/Material";
			public const string Operations_Material_Files = "Operations/Material/Files";
			public const string Operations_Material_ReferenceDesignators = "Operations/Material/ReferenceDesignators";
			public const string Operations_Material_ReferenceDesignators_Files = "Operations/Material/ReferenceDesignators/Files";
			public const string Operations_Overheads = "Operations/Overheads";
			public const string Operations_Overheads_Files = "Operations/Overheads/Files";
			public const string Operations_Steps = "Operations/Steps";
			public const string Operations_Steps_Files = "Operations/Steps/Files";
			public const string Operations_Tools = "Operations/Tools";
			public const string Operations_Tools_Files = "Operations/Tools/Files";

			//Intentionally excluded
			//public const string All = "Files,Translations,Operations,Operations/Files,Operations/Material,Operations/Material/Files,Operations/Material/ReferenceDesignators,Operations/Material/ReferenceDesignators/Files,Operations/Overheads,Operations/Overheads/Files,Operations/Steps,Operations/Steps/Files,Operations/Tools,Operations/Tools/Files";
		}
		public virtual string GetEndpointPath()
		{
			return "entity/MANUFACTURING/25.100.001";
		}
	}
}