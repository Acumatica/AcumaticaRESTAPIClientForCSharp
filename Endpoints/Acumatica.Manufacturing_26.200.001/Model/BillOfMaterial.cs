using System;
using System.Collections.Generic;
using System.Runtime.Serialization;

using Newtonsoft.Json;

using Acumatica.RESTClient.Client;
using Acumatica.RESTClient.ContractBasedApi;
using Acumatica.RESTClient.ContractBasedApi.Model;

namespace Acumatica.Manufacturing_26_200_001.Model
{
	/// <summary>
	/// Corresponds to the screen <c>AM208000</c> in the Acumatica ERP
	/// <para>Key Fields: BOMID, Revision</para>
	/// </summary>
	[DataContract]
	public class BillOfMaterial : Entity, ITopLevelEntity
	{

		/// <summary>
		/// The identifier of the bill of material.
		/// <para>DAC: PX.Objects.AM.AMBomItem</para>
		/// <para>Display Name: BOM ID</para>
		/// <para>SQL Type: nvarchar(15)</para>
		/// Key Field
		/// </summary>
		[DataMember(Name="BOMID", EmitDefaultValue=false)]
		public StringValue? BOMID { get; set; }

		/// <summary>
		/// A description of the bill of material. The system copies the description to production orders that are created by using the bill of material.
		/// <para>DAC Field Name: Descr</para>
		/// <para>DAC: PX.Objects.AM.AMBomItem</para>
		/// <para>SQL Type: nvarchar(256)</para>
		/// </summary>
		[DataMember(Name="Description", EmitDefaultValue=false)]
		public StringValue? Description { get; set; }

		/// <summary>
		/// The last date when the BOM revision was effective.
		/// <para>DAC: PX.Objects.AM.AMBomItem</para>
		/// <para>Display Name: End Date</para>
		/// </summary>
		[DataMember(Name="EffEndDate", EmitDefaultValue=false)]
		public DateTimeValue? EffEndDate { get; set; }

		/// <summary>
		/// The date when the BOM revision becomes effective.
		/// <para>DAC: PX.Objects.AM.AMBomItem</para>
		/// <para>Display Name: Start Date</para>
		/// </summary>
		[DataMember(Name="EffStartDate", EmitDefaultValue=false)]
		public DateTimeValue? EffStartDate { get; set; }

		/// <summary>
		/// A Boolean value that indicates whether the BOM item is on hold.
		/// <para>DAC: PX.Objects.AM.AMBomItem</para>
		/// </summary>
		[DataMember(Name="Hold", EmitDefaultValue=false)]
		public BooleanValue? Hold { get; set; }

		/// <summary>
		/// The identifier of the stock item that is produced by using the bill of material.
		/// <para>DAC: PX.Objects.AM.AMBomItem</para>
		/// <para>Display Name: Inventory ID</para>
		/// </summary>
		[DataMember(Name="InventoryID", EmitDefaultValue=false)]
		public StringValue? InventoryID { get; set; }

		[DataMember(Name="Operations", EmitDefaultValue=false)]
		public List<OperationDetail>? Operations { get; set; }

		/// <summary>
		/// The identifier of the BOM revision, which is the modification of the bill of material.
		/// <para>DAC Field Name: RevisionID</para>
		/// <para>DAC: PX.Objects.AM.AMBomItem</para>
		/// <para>SQL Type: nvarchar(10)</para>
		/// Key Field
		/// </summary>
		[DataMember(Name="Revision", EmitDefaultValue=false)]
		public StringValue? Revision { get; set; }

		/// <summary>
		/// The status of the revision.
		/// <para>DAC: PX.Objects.AM.AMBomItem</para>
		/// <para>SQL Type: char(1)</para>
		/// </summary>
		[DataMember(Name="Status", EmitDefaultValue=false)]
		public StringValue? Status { get; set; }

		/// <summary>
		/// The subitem of the stock item.
		/// <para>DAC Field Name: SubItemID</para>
		/// <para>DAC: PX.Objects.AM.AMBomItem</para>
		/// </summary>
		[DataMember(Name="Subitem", EmitDefaultValue=false)]
		public StringValue? Subitem { get; set; }

		/// <summary>
		/// The warehouse to which the produced stock item is received when the item production is completed.
		/// <para>DAC Field Name: SiteID</para>
		/// <para>DAC: PX.Objects.AM.AMBomItem</para>
		/// </summary>
		[DataMember(Name="Warehouse", EmitDefaultValue=false)]
		public StringValue? Warehouse { get; set; }

		/// <summary>
		/// Names that can be passed in the <c>$expand</c> parameter.
		/// <para>This endpoint uses system contract 5, where a nested entity is expanded
		/// as <c>Parent($expand=Child)</c> rather than <c>Parent/Child</c>, so only the names
		/// that can be expanded directly on this entity are listed here. Use the nested
		/// entity's own <c>Expand</c> class for the inner names.</para>
		/// </summary>
		public static class Expand
		{
			public const string Files = "Files";
			public const string Translations = "Translations";
			public const string Operations = "Operations";

			//Intentionally excluded
			//public const string All = "Files,Translations,Operations";
		}
		public virtual string GetEndpointPath()
		{
			return "entity/MANUFACTURING/26.200.001";
		}
	}
}