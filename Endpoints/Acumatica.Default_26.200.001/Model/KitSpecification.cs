using System;
using System.Collections.Generic;
using System.Runtime.Serialization;

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
	[DataContract]
	public class KitSpecification : Entity, ITopLevelEntity
	{

		/// <summary>
		/// <para>DAC Field Name: IsActive</para>
		/// <para>DAC: PX.Objects.IN.INKitSpecHdr</para>
		/// </summary>
		[DataMember(Name="Active", EmitDefaultValue=false)]
		public BooleanValue? Active { get; set; }

		/// <summary>
		/// <para>DAC Field Name: Descr</para>
		/// <para>DAC: PX.Objects.IN.INKitSpecHdr</para>
		/// <para>SQL Type: nvarchar(256)</para>
		/// </summary>
		[DataMember(Name="Description", EmitDefaultValue=false)]
		public StringValue? Description { get; set; }

		/// <summary>
		/// <para>DAC: PX.Objects.IN.INKitSpecHdr</para>
		/// <para>Display Name: Non-Stock</para>
		/// </summary>
		[DataMember(Name="IsNonStock", EmitDefaultValue=false)]
		public BooleanValue? IsNonStock { get; set; }

		/// <summary>
		/// <para>DAC: PX.Objects.IN.INKitSpecHdr</para>
		/// <para>Display Name: Kit Inventory ID</para>
		/// Key Field
		/// </summary>
		[DataMember(Name="KitInventoryID", EmitDefaultValue=false)]
		public StringValue? KitInventoryID { get; set; }

		[DataMember(Name="LastModifiedDateTime", EmitDefaultValue=false)]
		public DateTimeValue? LastModifiedDateTime { get; set; }

		[DataMember(Name="NonStockComponents", EmitDefaultValue=false)]
		public List<KitNonStockComponent>? NonStockComponents { get; set; }

		/// <summary>
		/// <para>DAC: PX.Objects.IN.INKitSpecHdr</para>
		/// <para>Display Name: Revision</para>
		/// <para>SQL Type: nvarchar(10)</para>
		/// Key Field
		/// </summary>
		[DataMember(Name="RevisionID", EmitDefaultValue=false)]
		public StringValue? RevisionID { get; set; }

		[DataMember(Name="StockComponents", EmitDefaultValue=false)]
		public List<KitStockComponent>? StockComponents { get; set; }

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