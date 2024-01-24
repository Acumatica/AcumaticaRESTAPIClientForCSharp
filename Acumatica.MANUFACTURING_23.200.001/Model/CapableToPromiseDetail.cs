using System;
using System.Collections.Generic;
using System.Runtime.Serialization;

using Newtonsoft.Json;

using Acumatica.RESTClient.Client;
using Acumatica.RESTClient.ContractBasedApi;
using Acumatica.RESTClient.ContractBasedApi.Model;

namespace Acumatica.Manufacturing_23_200_001.Model
{
	[DataContract]
	public class CapableToPromiseDetail : Entity
	{

		[DataMember(Name="CTPAccepted", EmitDefaultValue=false)]
		public BooleanValue? CTPAccepted { get; set; }

		[DataMember(Name="CTPDate", EmitDefaultValue=false)]
		public DateTimeValue? CTPDate { get; set; }

		[DataMember(Name="InventoryID", EmitDefaultValue=false)]
		public StringValue? InventoryID { get; set; }

		[DataMember(Name="LineDescription", EmitDefaultValue=false)]
		public StringValue? LineDescription { get; set; }

		[DataMember(Name="LineNbr", EmitDefaultValue=false)]
		public IntValue? LineNbr { get; set; }

		[DataMember(Name="LineOrder", EmitDefaultValue=false)]
		public IntValue? LineOrder { get; set; }

		[DataMember(Name="ManualOrderNbr", EmitDefaultValue=false)]
		public StringValue? ManualOrderNbr { get; set; }

		[DataMember(Name="OpenQty", EmitDefaultValue=false)]
		public DecimalValue? OpenQty { get; set; }

		[DataMember(Name="OriginalRequestDate", EmitDefaultValue=false)]
		public DateTimeValue? OriginalRequestDate { get; set; }

		[DataMember(Name="ProdOrderNbr", EmitDefaultValue=false)]
		public StringValue? ProdOrderNbr { get; set; }

		[DataMember(Name="ProdOrderType", EmitDefaultValue=false)]
		public StringValue? ProdOrderType { get; set; }

		[DataMember(Name="RequestedOn", EmitDefaultValue=false)]
		public DateTimeValue? RequestedOn { get; set; }

		[DataMember(Name="Selected", EmitDefaultValue=false)]
		public BooleanValue? Selected { get; set; }

		[DataMember(Name="ShipOn", EmitDefaultValue=false)]
		public DateTimeValue? ShipOn { get; set; }

		[DataMember(Name="SONbr", EmitDefaultValue=false)]
		public StringValue? SONbr { get; set; }

		[DataMember(Name="SOType", EmitDefaultValue=false)]
		public StringValue? SOType { get; set; }

		[DataMember(Name="Subitem", EmitDefaultValue=false)]
		public StringValue? Subitem { get; set; }

		[DataMember(Name="UOM", EmitDefaultValue=false)]
		public StringValue? UOM { get; set; }

		[DataMember(Name="Warehouse", EmitDefaultValue=false)]
		public StringValue? Warehouse { get; set; }

	}
}