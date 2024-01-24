using System;
using System.Collections.Generic;
using System.Runtime.Serialization;

using Newtonsoft.Json;

using Acumatica.RESTClient.Client;
using Acumatica.RESTClient.ContractBasedApi;
using Acumatica.RESTClient.ContractBasedApi.Model;

namespace Acumatica.eCommerce_23_200_001.Model
{
	[DataContract]
	public class TransferOrderDetail : Entity
	{

		[DataMember(Name="Allocations", EmitDefaultValue=false)]
		public List<TransferOrderDetailAllocation>? Allocations { get; set; }

		[DataMember(Name="CostCode", EmitDefaultValue=false)]
		public StringValue? CostCode { get; set; }

		[DataMember(Name="Description", EmitDefaultValue=false)]
		public StringValue? Description { get; set; }

		[DataMember(Name="ExpirationDate", EmitDefaultValue=false)]
		public DateTimeValue? ExpirationDate { get; set; }

		[DataMember(Name="FromLocationID", EmitDefaultValue=false)]
		public StringValue? FromLocationID { get; set; }

		[DataMember(Name="InventoryID", EmitDefaultValue=false)]
		public StringValue? InventoryID { get; set; }

		[DataMember(Name="LineNbr", EmitDefaultValue=false)]
		public IntValue? LineNbr { get; set; }

		[DataMember(Name="LotSerialNbr", EmitDefaultValue=false)]
		public StringValue? LotSerialNbr { get; set; }

		[DataMember(Name="Project", EmitDefaultValue=false)]
		public StringValue? Project { get; set; }

		[DataMember(Name="ProjectTask", EmitDefaultValue=false)]
		public StringValue? ProjectTask { get; set; }

		[DataMember(Name="Qty", EmitDefaultValue=false)]
		public DecimalValue? Qty { get; set; }

		[DataMember(Name="ReasonCode", EmitDefaultValue=false)]
		public StringValue? ReasonCode { get; set; }

		[DataMember(Name="SpecialOrderNbr", EmitDefaultValue=false)]
		public StringValue? SpecialOrderNbr { get; set; }

		[DataMember(Name="Subitem", EmitDefaultValue=false)]
		public StringValue? Subitem { get; set; }

		[DataMember(Name="ToLocationID", EmitDefaultValue=false)]
		public StringValue? ToLocationID { get; set; }

		[DataMember(Name="ToCostCode", EmitDefaultValue=false)]
		public StringValue? ToCostCode { get; set; }

		[DataMember(Name="ToCostLayerType", EmitDefaultValue=false)]
		public StringValue? ToCostLayerType { get; set; }

		[DataMember(Name="ToProject", EmitDefaultValue=false)]
		public StringValue? ToProject { get; set; }

		[DataMember(Name="ToProjectTask", EmitDefaultValue=false)]
		public StringValue? ToProjectTask { get; set; }

		[DataMember(Name="ToSpecialOrderNbr", EmitDefaultValue=false)]
		public StringValue? ToSpecialOrderNbr { get; set; }

		[DataMember(Name="UOM", EmitDefaultValue=false)]
		public StringValue? UOM { get; set; }

	}
}