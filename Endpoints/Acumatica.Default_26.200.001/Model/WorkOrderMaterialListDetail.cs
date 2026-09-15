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
	public class WorkOrderMaterialListDetail : Entity
	{

		[DataMember(Name="BranchID", EmitDefaultValue=false)]
		public StringValue? BranchID { get; set; }

		[DataMember(Name="CreatedFromWorkTicket", EmitDefaultValue=false)]
		public BooleanValue? CreatedFromWorkTicket { get; set; }

		[DataMember(Name="Description", EmitDefaultValue=false)]
		public StringValue? Description { get; set; }

		[DataMember(Name="ExpectedByDate", EmitDefaultValue=false)]
		public DateOnlyValue? ExpectedByDate { get; set; }

		[DataMember(Name="ExtCost", EmitDefaultValue=false)]
		public DecimalValue? ExtCost { get; set; }

		[DataMember(Name="InventoryID", EmitDefaultValue=false)]
		public StringValue? InventoryID { get; set; }

		[DataMember(Name="LineNbr", EmitDefaultValue=false)]
		public IntValue? LineNbr { get; set; }

		[DataMember(Name="NeededByDate", EmitDefaultValue=false)]
		public DateOnlyValue? NeededByDate { get; set; }

		[DataMember(Name="ProvisionNoteID", EmitDefaultValue=false)]
		public GuidValue? ProvisionNoteID { get; set; }

		[DataMember(Name="ProvisioningSource", EmitDefaultValue=false)]
		public StringSingleSelectValue? ProvisioningSource { get; set; }

		[DataMember(Name="QtyAvailableForDispatch", EmitDefaultValue=false)]
		public DecimalValue? QtyAvailableForDispatch { get; set; }

		[DataMember(Name="QtyAwaiting", EmitDefaultValue=false)]
		public DecimalValue? QtyAwaiting { get; set; }

		[DataMember(Name="QtyDispatched", EmitDefaultValue=false)]
		public DecimalValue? QtyDispatched { get; set; }

		[DataMember(Name="QtyOnDispatch", EmitDefaultValue=false)]
		public DecimalValue? QtyOnDispatch { get; set; }

		[DataMember(Name="QtyOnOrders", EmitDefaultValue=false)]
		public DecimalValue? QtyOnOrders { get; set; }

		[DataMember(Name="QtyProcured", EmitDefaultValue=false)]
		public DecimalValue? QtyProcured { get; set; }

		[DataMember(Name="QtyToOrder", EmitDefaultValue=false)]
		public DecimalValue? QtyToOrder { get; set; }

		[DataMember(Name="QtyUsed", EmitDefaultValue=false)]
		public DecimalValue? QtyUsed { get; set; }

		[DataMember(Name="RequiredQty", EmitDefaultValue=false)]
		public DecimalValue? RequiredQty { get; set; }

		[DataMember(Name="ShipDate", EmitDefaultValue=false)]
		public DateOnlyValue? ShipDate { get; set; }

		[DataMember(Name="SiteID", EmitDefaultValue=false)]
		public StringValue? SiteID { get; set; }

		[DataMember(Name="Status", EmitDefaultValue=false)]
		public StringSingleSelectValue? Status { get; set; }

		[DataMember(Name="ToLocationID", EmitDefaultValue=false)]
		public StringValue? ToLocationID { get; set; }

		[DataMember(Name="ToSiteID", EmitDefaultValue=false)]
		public StringValue? ToSiteID { get; set; }

		[DataMember(Name="UOM", EmitDefaultValue=false)]
		public StringValue? UOM { get; set; }

		[DataMember(Name="UnitCost", EmitDefaultValue=false)]
		public DecimalValue? UnitCost { get; set; }

		[DataMember(Name="VendorID", EmitDefaultValue=false)]
		public StringValue? VendorID { get; set; }

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