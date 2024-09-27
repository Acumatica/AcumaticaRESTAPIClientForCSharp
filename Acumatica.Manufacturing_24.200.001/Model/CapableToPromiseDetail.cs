using System;
using System.Collections.Generic;
using System.Runtime.Serialization;

using Newtonsoft.Json;

using Acumatica.RESTClient.Client;
using Acumatica.RESTClient.ContractBasedApi;
using Acumatica.RESTClient.ContractBasedApi.Model;

namespace Acumatica.Manufacturing_24_200_001.Model
{
	[DataContract]
	public class CapableToPromiseDetail : Entity
	{

		/// <summary>
		/// DAC Field Name: AMCTPAccepted 
		/// DAC: PX.Objects.AM.CTPProcess+CTPLine 
		/// </summary>
		[DataMember(Name="CTPAccepted", EmitDefaultValue=false)]
		public BooleanValue? CTPAccepted { get; set; }

		/// <summary>
		/// DAC: PX.Objects.AM.CTPProcess+CTPLine 
		/// </summary>
		[DataMember(Name="CTPDate", EmitDefaultValue=false)]
		public DateTimeValue? CTPDate { get; set; }

		/// <summary>
		/// DAC: PX.Objects.AM.CTPProcess+CTPLine 
		/// </summary>
		[DataMember(Name="InventoryID", EmitDefaultValue=false)]
		public StringValue? InventoryID { get; set; }

		/// <summary>
		/// DAC Field Name: TranDesc 
		/// DAC: PX.Objects.AM.CTPProcess+CTPLine 
		/// </summary>
		[DataMember(Name="LineDescription", EmitDefaultValue=false)]
		public StringValue? LineDescription { get; set; }

		/// <summary>
		/// DAC: PX.Objects.AM.CTPProcess+CTPLine 
		/// </summary>
		[DataMember(Name="LineNbr", EmitDefaultValue=false)]
		public IntValue? LineNbr { get; set; }

		[DataMember(Name="LineOrder", EmitDefaultValue=false)]
		public IntValue? LineOrder { get; set; }

		/// <summary>
		/// DAC Field Name: ManualProdOrdID 
		/// DAC: PX.Objects.AM.CTPProcess+CTPLine 
		/// </summary>
		[DataMember(Name="ManualOrderNbr", EmitDefaultValue=false)]
		public StringValue? ManualOrderNbr { get; set; }

		/// <summary>
		/// DAC: PX.Objects.AM.CTPProcess+CTPLine 
		/// </summary>
		[DataMember(Name="OpenQty", EmitDefaultValue=false)]
		public DecimalValue? OpenQty { get; set; }

		/// <summary>
		/// DAC Field Name: AMOrigRequestDate 
		/// DAC: PX.Objects.AM.CTPProcess+CTPLine 
		/// </summary>
		[DataMember(Name="OriginalRequestDate", EmitDefaultValue=false)]
		public DateTimeValue? OriginalRequestDate { get; set; }

		/// <summary>
		/// DAC Field Name: ProdOrdID 
		/// DAC: PX.Objects.AM.CTPProcess+CTPLine 
		/// </summary>
		[DataMember(Name="ProdOrderNbr", EmitDefaultValue=false)]
		public StringValue? ProdOrderNbr { get; set; }

		/// <summary>
		/// DAC Field Name: AMCTPOrderType 
		/// DAC: PX.Objects.AM.CTPProcess+CTPLine 
		/// </summary>
		[DataMember(Name="ProdOrderType", EmitDefaultValue=false)]
		public StringValue? ProdOrderType { get; set; }

		/// <summary>
		/// DAC Field Name: RequestDate 
		/// DAC: PX.Objects.AM.CTPProcess+CTPLine 
		/// </summary>
		[DataMember(Name="RequestedOn", EmitDefaultValue=false)]
		public DateTimeValue? RequestedOn { get; set; }

		/// <summary>
		/// DAC: PX.Objects.AM.CTPProcess+CTPLine 
		/// </summary>
		[DataMember(Name="Selected", EmitDefaultValue=false)]
		public BooleanValue? Selected { get; set; }

		/// <summary>
		/// DAC Field Name: ShipDate 
		/// DAC: PX.Objects.AM.CTPProcess+CTPLine 
		/// </summary>
		[DataMember(Name="ShipOn", EmitDefaultValue=false)]
		public DateTimeValue? ShipOn { get; set; }

		/// <summary>
		/// DAC Field Name: OrderNbr 
		/// DAC: PX.Objects.AM.CTPProcess+CTPLine 
		/// </summary>
		[DataMember(Name="SONbr", EmitDefaultValue=false)]
		public StringValue? SONbr { get; set; }

		/// <summary>
		/// DAC Field Name: OrderType 
		/// DAC: PX.Objects.AM.CTPProcess+CTPLine 
		/// </summary>
		[DataMember(Name="SOType", EmitDefaultValue=false)]
		public StringValue? SOType { get; set; }

		/// <summary>
		/// DAC Field Name: SubItemID 
		/// DAC: PX.Objects.AM.CTPProcess+CTPLine 
		/// </summary>
		[DataMember(Name="Subitem", EmitDefaultValue=false)]
		public StringValue? Subitem { get; set; }

		/// <summary>
		/// DAC: PX.Objects.AM.CTPProcess+CTPLine 
		/// </summary>
		[DataMember(Name="UOM", EmitDefaultValue=false)]
		public StringValue? UOM { get; set; }

		/// <summary>
		/// DAC Field Name: SiteID 
		/// DAC: PX.Objects.AM.CTPProcess+CTPLine 
		/// </summary>
		[DataMember(Name="Warehouse", EmitDefaultValue=false)]
		public StringValue? Warehouse { get; set; }

	}
}