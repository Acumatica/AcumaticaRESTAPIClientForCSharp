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
	public class KitStockComponent : Entity
	{

		/// <summary>
		/// <para>DAC Field Name: AllowQtyVariation</para>
		/// <para>DAC: PX.Objects.IN.INKitSpecStkDet</para>
		/// <para>Display Name: Allow Component Qty. Variance</para>
		/// </summary>
		[DataMember(Name="AllowComponentQtyVariance", EmitDefaultValue=false)]
		public BooleanValue? AllowComponentQtyVariance { get; set; }

		/// <summary>
		/// <para>DAC Field Name: DfltCompQty</para>
		/// <para>DAC: PX.Objects.IN.INKitSpecStkDet</para>
		/// <para>Display Name: Component Qty.</para>
		/// </summary>
		[DataMember(Name="ComponentQty", EmitDefaultValue=false)]
		public DecimalValue? ComponentQty { get; set; }

		/// <summary>
		/// <para>DAC Field Name: MaxCompQty</para>
		/// <para>DAC: PX.Objects.IN.INKitSpecStkDet</para>
		/// <para>Display Name: Max. Component Qty.</para>
		/// </summary>
		[DataMember(Name="MaxComponentQty", EmitDefaultValue=false)]
		public DecimalValue? MaxComponentQty { get; set; }

		/// <summary>
		/// <para>DAC Field Name: MinCompQty</para>
		/// <para>DAC: PX.Objects.IN.INKitSpecStkDet</para>
		/// <para>Display Name: Min. Component Qty.</para>
		/// </summary>
		[DataMember(Name="MinComponentQty", EmitDefaultValue=false)]
		public DecimalValue? MinComponentQty { get; set; }

		/// <summary>
		/// <para>DAC Field Name: CompInventoryID</para>
		/// <para>DAC: PX.Objects.IN.INKitSpecStkDet</para>
		/// <para>Display Name: Component ID</para>
		/// </summary>
		[DataMember(Name="StockInventoryID", EmitDefaultValue=false)]
		public StringValue? StockInventoryID { get; set; }

		/// <summary>
		/// <para>DAC: PX.Objects.IN.INKitSpecStkDet</para>
		/// <para>SQL Type: nvarchar(6)</para>
		/// </summary>
		[DataMember(Name="UOM", EmitDefaultValue=false)]
		public StringValue? UOM { get; set; }

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