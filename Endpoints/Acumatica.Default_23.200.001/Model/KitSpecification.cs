using System;
using System.Collections.Generic;
using System.Runtime.Serialization;

using Newtonsoft.Json;

using Acumatica.RESTClient.Client;
using Acumatica.RESTClient.ContractBasedApi;
using Acumatica.RESTClient.ContractBasedApi.Model;

namespace Acumatica.Default_23_200_001.Model
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

		public static class Expand
		{
			public const string Files = "Files";
			public const string NonStockComponents = "NonStockComponents";
			public const string NonStockComponents_Files = "NonStockComponents/Files";
			public const string StockComponents = "StockComponents";
			public const string StockComponents_Files = "StockComponents/Files";

			//Intentionally excluded
			//public const string All = "Files,NonStockComponents,NonStockComponents/Files,StockComponents,StockComponents/Files";
		}
		public virtual string GetEndpointPath()
		{
			return "entity/Default/23.200.001";
		}
	}
}