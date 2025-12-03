using System;
using System.Collections.Generic;
using System.Runtime.Serialization;

using Newtonsoft.Json;

using Acumatica.RESTClient.Client;
using Acumatica.RESTClient.ContractBasedApi;
using Acumatica.RESTClient.ContractBasedApi.Model;

namespace Acumatica.Default_23_200_001.Model
{
	[DataContract]
	public class KitAssemblyStockComponent : Entity
	{

		[DataMember(Name="Allocations", EmitDefaultValue=false)]
		public List<KitAssemblyStockComponentAllocation>? Allocations { get; set; }

		/// <summary>
		/// <para>DAC Field Name: INKitSpecStkDet__DfltCompQty</para>
		/// <para>DAC: PX.Objects.IN.INComponentTran</para>
		/// </summary>
		[DataMember(Name="ComponentQty", EmitDefaultValue=false)]
		public DecimalValue? ComponentQty { get; set; }

		[DataMember(Name="LineNbr", EmitDefaultValue=false)]
		public IntValue? LineNbr { get; set; }

		/// <summary>
		/// <para>DAC: PX.Objects.IN.INKitRegister</para>
		/// <para>Display Name: Location</para>
		/// </summary>
		[DataMember(Name="LocationID", EmitDefaultValue=false)]
		public StringValue? LocationID { get; set; }

		/// <summary>
		/// <para>DAC: PX.Objects.IN.INKitRegister</para>
		/// <para>Display Name: Quantity</para>
		/// </summary>
		[DataMember(Name="Qty", EmitDefaultValue=false)]
		public DecimalValue? Qty { get; set; }

		/// <summary>
		/// <para>DAC: PX.Objects.IN.INKitRegister</para>
		/// <para>Display Name: Reason Code</para>
		/// <para>SQL Type: nvarchar(20)</para>
		/// </summary>
		[DataMember(Name="ReasonCode", EmitDefaultValue=false)]
		public StringValue? ReasonCode { get; set; }

		/// <summary>
		/// <para>DAC Field Name: InventoryID</para>
		/// <para>DAC: PX.Objects.IN.INComponentTran</para>
		/// <para>Display Name: Inventory ID</para>
		/// </summary>
		[DataMember(Name="StockInventoryID", EmitDefaultValue=false)]
		public StringValue? StockInventoryID { get; set; }

		/// <summary>
		/// <para>DAC Field Name: SubItemID</para>
		/// <para>DAC: PX.Objects.IN.INKitRegister</para>
		/// </summary>
		[DataMember(Name="Subitem", EmitDefaultValue=false)]
		public StringValue? Subitem { get; set; }

		/// <summary>
		/// <para>DAC: PX.Objects.IN.INComponentTran</para>
		/// <para>Display Name: Unit Cost</para>
		/// </summary>
		[DataMember(Name="UnitCost", EmitDefaultValue=false)]
		public DecimalValue? UnitCost { get; set; }

		/// <summary>
		/// <para>DAC: PX.Objects.IN.INKitRegister</para>
		/// <para>SQL Type: nvarchar(6)</para>
		/// </summary>
		[DataMember(Name="UOM", EmitDefaultValue=false)]
		public StringValue? UOM { get; set; }

	}
}