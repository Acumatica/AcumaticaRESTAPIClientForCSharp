using System;
using System.Collections.Generic;

using Newtonsoft.Json;

using Acumatica.RESTClient.Client;
using Acumatica.RESTClient.ContractBasedApi;
using Acumatica.RESTClient.ContractBasedApi.Model;

namespace Acumatica.Default_24_200_001.Model
{
	/// <summary>
	/// Corresponds to the screen <c>IN209500</c> in the Acumatica ERP
	/// <para>Key Fields: KitInventoryID, RevisionID</para>
	/// </summary>
	public class KitSpecification : Entity, ITopLevelEntity
	{

		/// <summary>
		/// <para>DAC Field Name: IsActive</para>
		/// <para>DAC: PX.Objects.IN.INKitSpecHdr</para>
		/// </summary>
		public BooleanValue? Active { get; set; }

		/// <summary>
		/// <para>DAC Field Name: Descr</para>
		/// <para>DAC: PX.Objects.IN.INKitSpecHdr</para>
		/// <para>SQL Type: nvarchar(256)</para>
		/// </summary>
		public StringValue? Description { get; set; }

		/// <summary>
		/// <para>DAC: PX.Objects.IN.INKitSpecHdr</para>
		/// <para>Display Name: Non-Stock</para>
		/// </summary>
		public BooleanValue? IsNonStock { get; set; }

		/// <summary>
		/// <para>DAC: PX.Objects.IN.INKitSpecHdr</para>
		/// <para>Display Name: Kit Inventory ID</para>
		/// Key Field
		/// </summary>
		public StringValue? KitInventoryID { get; set; }

		public DateTimeValue? LastModifiedDateTime { get; set; }

		public List<KitNonStockComponent>? NonStockComponents { get; set; }

		/// <summary>
		/// <para>DAC: PX.Objects.IN.INKitSpecHdr</para>
		/// <para>Display Name: Revision</para>
		/// <para>SQL Type: nvarchar(10)</para>
		/// Key Field
		/// </summary>
		public StringValue? RevisionID { get; set; }

		public List<KitStockComponent>? StockComponents { get; set; }

		public static class Expand
		{
			public const string Files = "Files";
			public const string Translations = "Translations";
			public const string NonStockComponents = "NonStockComponents";
			public const string NonStockComponents_Files = "NonStockComponents/Files";
			public const string StockComponents = "StockComponents";
			public const string StockComponents_Files = "StockComponents/Files";

			//Intentionally excluded
			//public const string All = "Files,Translations,NonStockComponents,NonStockComponents/Files,StockComponents,StockComponents/Files";
		}
		public virtual string GetEndpointPath()
		{
			return "entity/Default/24.200.001";
		}
	}
}