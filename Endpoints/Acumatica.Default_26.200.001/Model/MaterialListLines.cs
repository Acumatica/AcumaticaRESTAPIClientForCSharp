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
	public class MaterialListLines : Entity
	{

		[DataMember(Name="Branch", EmitDefaultValue=false)]
		public StringValue? Branch { get; set; }

		[DataMember(Name="CostCode", EmitDefaultValue=false)]
		public StringValue? CostCode { get; set; }

		[DataMember(Name="Description", EmitDefaultValue=false)]
		public StringValue? Description { get; set; }

		[DataMember(Name="DispatchOn", EmitDefaultValue=false)]
		public DateOnlyValue? DispatchOn { get; set; }

		[DataMember(Name="ExpectedBy", EmitDefaultValue=false)]
		public DateOnlyValue? ExpectedBy { get; set; }

		[DataMember(Name="ExtCost", EmitDefaultValue=false)]
		public DecimalValue? ExtCost { get; set; }

		[DataMember(Name="InventoryID", EmitDefaultValue=false)]
		public StringValue? InventoryID { get; set; }

		[DataMember(Name="InventorySource", EmitDefaultValue=false)]
		public StringValue? InventorySource { get; set; }

		[DataMember(Name="LineNbr", EmitDefaultValue=false)]
		public IntValue? LineNbr { get; set; }

		[DataMember(Name="NeededBy", EmitDefaultValue=false)]
		public DateOnlyValue? NeededBy { get; set; }

		[DataMember(Name="POCreate", EmitDefaultValue=false)]
		public BooleanValue? POCreate { get; set; }

		[DataMember(Name="POCreationDate", EmitDefaultValue=false)]
		public DateOnlyValue? POCreationDate { get; set; }

		[DataMember(Name="ProjectTask", EmitDefaultValue=false)]
		public StringValue? ProjectTask { get; set; }

		[DataMember(Name="ProvisioningDocRefNbr", EmitDefaultValue=false)]
		public StringValue? ProvisioningDocRefNbr { get; set; }

		[DataMember(Name="ProvisioningSource", EmitDefaultValue=false)]
		public StringValue? ProvisioningSource { get; set; }

		[DataMember(Name="QtyAvailableforDispatch", EmitDefaultValue=false)]
		public DecimalValue? QtyAvailableforDispatch { get; set; }

		[DataMember(Name="QtyAwaitingDelivery", EmitDefaultValue=false)]
		public DecimalValue? QtyAwaitingDelivery { get; set; }

		[DataMember(Name="QtyDispatched", EmitDefaultValue=false)]
		public DecimalValue? QtyDispatched { get; set; }

		[DataMember(Name="QtyonDispatch", EmitDefaultValue=false)]
		public DecimalValue? QtyonDispatch { get; set; }

		[DataMember(Name="QtyonOrders", EmitDefaultValue=false)]
		public DecimalValue? QtyonOrders { get; set; }

		[DataMember(Name="QtyProcured", EmitDefaultValue=false)]
		public DecimalValue? QtyProcured { get; set; }

		[DataMember(Name="QtytoOrderorAllocate", EmitDefaultValue=false)]
		public DecimalValue? QtytoOrderorAllocate { get; set; }

		[DataMember(Name="QtyUsed", EmitDefaultValue=false)]
		public DecimalValue? QtyUsed { get; set; }

		[DataMember(Name="RequiredQty", EmitDefaultValue=false)]
		public DecimalValue? RequiredQty { get; set; }

		[DataMember(Name="Status", EmitDefaultValue=false)]
		public StringValue? Status { get; set; }

		[DataMember(Name="UnitCost", EmitDefaultValue=false)]
		public DecimalValue? UnitCost { get; set; }

		[DataMember(Name="UOM", EmitDefaultValue=false)]
		public StringValue? UOM { get; set; }

		[DataMember(Name="Vendor", EmitDefaultValue=false)]
		public StringValue? Vendor { get; set; }

		[DataMember(Name="Warehouse", EmitDefaultValue=false)]
		public StringValue? Warehouse { get; set; }

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