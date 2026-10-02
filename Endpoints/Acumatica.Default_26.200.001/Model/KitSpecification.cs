using System;
using System.Collections.Generic;

using Newtonsoft.Json;

using Acumatica.RESTClient.Client;
using Acumatica.RESTClient.ContractBasedApi;
using Acumatica.RESTClient.ContractBasedApi.Model;

namespace Acumatica.Default_26_200_001.Model
{
	/// <summary>
	/// Corresponds to the screen <c>IN209500</c> in the Acumatica ERP
	/// <para>Key Fields: KitInventoryID, RevisionID</para>
	/// </summary>
	public class KitSpecification : Entity, ITopLevelEntity
	{

		#region Fields
		/// <summary>
		/// <para>DAC: PX.Objects.IN.INKitSpecHdr</para>
		/// <para>Display Name: Kit Inventory ID</para>
		/// Key Field
		/// </summary>
		public StringValue? KitInventoryID { get; set; }

		/// <summary>
		/// <para>DAC: PX.Objects.IN.INKitSpecHdr</para>
		/// <para>Display Name: Revision</para>
		/// <para>SQL Type: nvarchar(10)</para>
		/// Key Field
		/// </summary>
		public StringValue? RevisionID { get; set; }

		/// <summary>
		/// <para>DAC: PX.Objects.IN.INKitSpecHdr</para>
		/// <para>Display Name: Non-Stock</para>
		/// </summary>
		public BooleanValue? IsNonStock { get; set; }

		/// <summary>
		/// <para>DAC Field Name: Descr</para>
		/// <para>DAC: PX.Objects.IN.INKitSpecHdr</para>
		/// <para>SQL Type: nvarchar(256)</para>
		/// </summary>
		public StringValue? Description { get; set; }

		/// <summary>
		/// <para>DAC Field Name: IsActive</para>
		/// <para>DAC: PX.Objects.IN.INKitSpecHdr</para>
		/// </summary>
		public BooleanValue? Active { get; set; }

		public DateTimeValue? LastModifiedDateTime { get; set; }

		#endregion

		#region Details
		public List<KitNonStockComponent>? NonStockComponents { get; set; }

		public List<KitStockComponent>? StockComponents { get; set; }

		#endregion

		protected override string GetDebuggerDisplay()
		{
			return $"{nameof(KitSpecification)} - \"{KitInventoryID}\" - \"{RevisionID}\"";
		}

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
			public const string NonStockComponents = "NonStockComponents";
			public const string StockComponents = "StockComponents";

			//Intentionally excluded
			//public const string All = "Files,Translations,NonStockComponents,StockComponents";
		}
		public virtual string GetEndpointPath()
		{
			return "entity/Default/26.200.001";
		}
	}
}