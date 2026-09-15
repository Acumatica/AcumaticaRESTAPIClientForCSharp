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
	public class SalesOrderDetailAllocation : Entity
	{

		[DataMember(Name="Allocated", EmitDefaultValue=false)]
		public BooleanValue? Allocated { get; set; }

		[DataMember(Name="AllocWarehouseID", EmitDefaultValue=false)]
		public StringValue? AllocWarehouseID { get; set; }

		[DataMember(Name="Completed", EmitDefaultValue=false)]
		public BooleanValue? Completed { get; set; }

		[DataMember(Name="CustomerOrderNbr", EmitDefaultValue=false)]
		public StringValue? CustomerOrderNbr { get; set; }

		[DataMember(Name="ExpirationDate", EmitDefaultValue=false)]
		public DateTimeValue? ExpirationDate { get; set; }

		[DataMember(Name="InventoryID", EmitDefaultValue=false)]
		public StringValue? InventoryID { get; set; }

		[DataMember(Name="LineNbr", EmitDefaultValue=false)]
		public IntValue? LineNbr { get; set; }

		[DataMember(Name="LocationID", EmitDefaultValue=false)]
		public StringValue? LocationID { get; set; }

		[DataMember(Name="LotSerialNbr", EmitDefaultValue=false)]
		public StringValue? LotSerialNbr { get; set; }

		[DataMember(Name="OrderNbr", EmitDefaultValue=false)]
		public StringValue? OrderNbr { get; set; }

		[DataMember(Name="OrderType", EmitDefaultValue=false)]
		public StringValue? OrderType { get; set; }

		[DataMember(Name="Qty", EmitDefaultValue=false)]
		public DecimalValue? Qty { get; set; }

		[DataMember(Name="QtyOnShipments", EmitDefaultValue=false)]
		public DecimalValue? QtyOnShipments { get; set; }

		[DataMember(Name="QtyReceived", EmitDefaultValue=false)]
		public DecimalValue? QtyReceived { get; set; }

		[DataMember(Name="RelatedDocument", EmitDefaultValue=false)]
		public StringValue? RelatedDocument { get; set; }

		[DataMember(Name="SchedOrderDate", EmitDefaultValue=false)]
		public DateTimeValue? SchedOrderDate { get; set; }

		[DataMember(Name="ShipOn", EmitDefaultValue=false)]
		public DateTimeValue? ShipOn { get; set; }

		[DataMember(Name="SplitLineNbr", EmitDefaultValue=false)]
		public IntValue? SplitLineNbr { get; set; }

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