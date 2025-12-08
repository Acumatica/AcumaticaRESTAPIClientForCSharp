using System;
using System.Collections.Generic;
using System.Runtime.Serialization;

using Newtonsoft.Json;

using Acumatica.RESTClient.Client;
using Acumatica.RESTClient.ContractBasedApi;
using Acumatica.RESTClient.ContractBasedApi.Model;

namespace Acumatica.MANUFACTURING_25_100_001.Model
{
	[DataContract]
	public class CapableToPromiseDetail : Entity
	{

		/// <summary>
		/// <para>DAC Field Name: AMCTPAccepted</para>
		/// <para>DAC: PX.Objects.AM.CTPProcess+CTPLine</para>
		/// </summary>
		[DataMember(Name="CTPAccepted", EmitDefaultValue=false)]
		public BooleanValue? CTPAccepted { get; set; }

		/// <summary>
		/// <para>DAC: PX.Objects.AM.CTPProcess+CTPLine</para>
		/// </summary>
		[DataMember(Name="CTPDate", EmitDefaultValue=false)]
		public DateTimeValue? CTPDate { get; set; }

		/// <summary>
		/// <para>DAC: PX.Objects.AM.CTPProcess+CTPLine</para>
		/// </summary>
		[DataMember(Name="InventoryID", EmitDefaultValue=false)]
		public StringValue? InventoryID { get; set; }

		/// <summary>
		/// <para>DAC Field Name: TranDesc</para>
		/// <para>DAC: PX.Objects.AM.CTPProcess+CTPLine</para>
		/// </summary>
		[DataMember(Name="LineDescription", EmitDefaultValue=false)]
		public StringValue? LineDescription { get; set; }

		/// <summary>
		/// <para>DAC: PX.Objects.AM.CTPProcess+CTPLine</para>
		/// </summary>
		[DataMember(Name="LineNbr", EmitDefaultValue=false)]
		public IntValue? LineNbr { get; set; }

		[DataMember(Name="LineOrder", EmitDefaultValue=false)]
		public IntValue? LineOrder { get; set; }

		/// <summary>
		/// <para>DAC Field Name: ManualProdOrdID</para>
		/// <para>DAC: PX.Objects.AM.CTPProcess+CTPLine</para>
		/// </summary>
		[DataMember(Name="ManualOrderNbr", EmitDefaultValue=false)]
		public StringValue? ManualOrderNbr { get; set; }

		/// <summary>
		/// <para>DAC: PX.Objects.AM.CTPProcess+CTPLine</para>
		/// </summary>
		[DataMember(Name="OpenQty", EmitDefaultValue=false)]
		public DecimalValue? OpenQty { get; set; }

		/// <summary>
		/// <para>DAC Field Name: AMOrigRequestDate</para>
		/// <para>DAC: PX.Objects.AM.CTPProcess+CTPLine</para>
		/// </summary>
		[DataMember(Name="OriginalRequestDate", EmitDefaultValue=false)]
		public DateTimeValue? OriginalRequestDate { get; set; }

		/// <summary>
		/// <para>DAC Field Name: ProdOrdID</para>
		/// <para>DAC: PX.Objects.AM.CTPProcess+CTPLine</para>
		/// </summary>
		[DataMember(Name="ProdOrderNbr", EmitDefaultValue=false)]
		public StringValue? ProdOrderNbr { get; set; }

		/// <summary>
		/// <para>DAC Field Name: AMCTPOrderType</para>
		/// <para>DAC: PX.Objects.AM.CTPProcess+CTPLine</para>
		/// </summary>
		[DataMember(Name="ProdOrderType", EmitDefaultValue=false)]
		public StringValue? ProdOrderType { get; set; }

		/// <summary>
		/// <para>DAC Field Name: RequestDate</para>
		/// <para>DAC: PX.Objects.AM.CTPProcess+CTPLine</para>
		/// </summary>
		[DataMember(Name="RequestedOn", EmitDefaultValue=false)]
		public DateTimeValue? RequestedOn { get; set; }

		/// <summary>
		/// <para>DAC: PX.Objects.AM.CTPProcess+CTPLine</para>
		/// </summary>
		[DataMember(Name="Selected", EmitDefaultValue=false)]
		public BooleanValue? Selected { get; set; }

		/// <summary>
		/// <para>DAC Field Name: ShipDate</para>
		/// <para>DAC: PX.Objects.AM.CTPProcess+CTPLine</para>
		/// </summary>
		[DataMember(Name="ShipOn", EmitDefaultValue=false)]
		public DateTimeValue? ShipOn { get; set; }

		/// <summary>
		/// <para>DAC Field Name: OrderNbr</para>
		/// <para>DAC: PX.Objects.AM.CTPProcess+CTPLine</para>
		/// </summary>
		[DataMember(Name="SONbr", EmitDefaultValue=false)]
		public StringValue? SONbr { get; set; }

		/// <summary>
		/// <para>DAC Field Name: OrderType</para>
		/// <para>DAC: PX.Objects.AM.CTPProcess+CTPLine</para>
		/// </summary>
		[DataMember(Name="SOType", EmitDefaultValue=false)]
		public StringValue? SOType { get; set; }

		/// <summary>
		/// <para>DAC Field Name: SubItemID</para>
		/// <para>DAC: PX.Objects.AM.CTPProcess+CTPLine</para>
		/// </summary>
		[DataMember(Name="Subitem", EmitDefaultValue=false)]
		public StringValue? Subitem { get; set; }

		/// <summary>
		/// <para>DAC: PX.Objects.AM.CTPProcess+CTPLine</para>
		/// </summary>
		[DataMember(Name="UOM", EmitDefaultValue=false)]
		public StringValue? UOM { get; set; }

		/// <summary>
		/// <para>DAC Field Name: SiteID</para>
		/// <para>DAC: PX.Objects.AM.CTPProcess+CTPLine</para>
		/// </summary>
		[DataMember(Name="Warehouse", EmitDefaultValue=false)]
		public StringValue? Warehouse { get; set; }

	}
}