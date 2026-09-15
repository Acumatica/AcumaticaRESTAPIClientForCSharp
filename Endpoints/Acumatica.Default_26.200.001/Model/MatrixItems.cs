using System;
using System.Collections.Generic;
using System.Runtime.Serialization;

using Newtonsoft.Json;

using Acumatica.RESTClient.Client;
using Acumatica.RESTClient.ContractBasedApi;
using Acumatica.RESTClient.ContractBasedApi.Model;

namespace Acumatica.Default_26_200_001.Model
{
	[DataContract]
	public class MatrixItems : Entity
	{

		/// <summary>
		/// The price used as the default price, if there are no other prices defined for this item in any price list in the Accounts Receivable module.
		/// <para>DAC Field Name: BasePrice</para>
		/// <para>DAC: PX.Objects.IN.InventoryItemCurySettings</para>
		/// <para>Display Name: Default Price</para>
		/// </summary>
		[DataMember(Name="DefaultPrice", EmitDefaultValue=false)]
		public DecimalValue? DefaultPrice { get; set; }

		/// <summary>
		/// The description of the Inventory Item.
		/// <para>DAC Field Name: Descr</para>
		/// <para>DAC: PX.Objects.IN.InventoryItem</para>
		/// <para>SQL Type: nvarchar(256)</para>
		/// </summary>
		[DataMember(Name="Description", EmitDefaultValue=false)]
		public StringValue? Description { get; set; }

		/// <summary>
		/// <para>DAC: PX.Objects.IN.Matrix.GraphExtensions.ItemsGridExt+MatrixInventoryItem</para>
		/// </summary>
		[DataMember(Name="InventoryID", EmitDefaultValue=false)]
		public StringValue? InventoryID { get; set; }

		/// <summary>
		/// The manufacturer's suggested retail price of the item.
		/// <para>DAC Field Name: RecPrice</para>
		/// <para>DAC: PX.Objects.IN.InventoryItemCurySettings</para>
		/// </summary>
		[DataMember(Name="MSRP", EmitDefaultValue=false)]
		public DecimalValue? MSRP { get; set; }

		[DataMember(Name="ItemStatus", EmitDefaultValue=false)]
		public StringSingleSelectValue? ItemStatus { get; set; }

		[DataMember(Name="ExportToExternal", EmitDefaultValue=false)]
		public BooleanValue? ExportToExternal { get; set; }

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

			//Intentionally excluded
			//public const string All = "Files";
		}
	}
}