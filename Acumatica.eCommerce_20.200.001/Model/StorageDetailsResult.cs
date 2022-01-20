using Acumatica.RESTClient.Model;
using System.Collections.Generic;
using System.Runtime.Serialization;

namespace Acumatica.eCommerce_20_200_001.Model
{
	[DataContract]
	public class StorageDetailsResult : Entity_v4
	{

		[DataMember(Name="Availability", EmitDefaultValue=false)]
		public StringValue Availability { get; set; }

		[DataMember(Name="IdentifyNoteID", EmitDefaultValue=false)]
		public StringValue IdentifyNoteID { get; set; }

		[DataMember(Name="InventoryDescription", EmitDefaultValue=false)]
		public StringValue InventoryDescription { get; set; }

		[DataMember(Name="InventoryCD", EmitDefaultValue=false)]
		public StringValue InventoryCD { get; set; }

		[DataMember(Name="InventoryLastModifiedDate", EmitDefaultValue=false)]
		public DateTimeValue InventoryLastModifiedDate { get; set; }

		[DataMember(Name="InventoryNoteID", EmitDefaultValue=false)]
		public GuidValue InventoryNoteID { get; set; }

		[DataMember(Name="IsTemplate", EmitDefaultValue=false)]
		public BooleanValue IsTemplate { get; set; }

		[DataMember(Name="ItemStatus", EmitDefaultValue=false)]
		public StringValue ItemStatus { get; set; }

		[DataMember(Name="Location", EmitDefaultValue=false)]
		public StringValue Location { get; set; }

		[DataMember(Name="LocationAvailable", EmitDefaultValue=false)]
		public DecimalValue LocationAvailable { get; set; }

		[DataMember(Name="LocationAvailableforIssue", EmitDefaultValue=false)]
		public DecimalValue LocationAvailableforIssue { get; set; }

		[DataMember(Name="LocationAvailableforShipping", EmitDefaultValue=false)]
		public DecimalValue LocationAvailableforShipping { get; set; }

		[DataMember(Name="LocationDescription", EmitDefaultValue=false)]
		public StringValue LocationDescription { get; set; }

		[DataMember(Name="LocationID", EmitDefaultValue=false)]
		public StringValue LocationID { get; set; }

		[DataMember(Name="LocationLastModifiedDate", EmitDefaultValue=false)]
		public DateTimeValue LocationLastModifiedDate { get; set; }

		[DataMember(Name="LocationOnHand", EmitDefaultValue=false)]
		public DecimalValue LocationOnHand { get; set; }

		[DataMember(Name="LotSerialNbr", EmitDefaultValue=false)]
		public StringValue LotSerialNbr { get; set; }

		[DataMember(Name="NotAvailMode", EmitDefaultValue=false)]
		public StringValue NotAvailMode { get; set; }

		[DataMember(Name="ParentSyncId", EmitDefaultValue=false)]
		public IntValue ParentSyncId { get; set; }

		[DataMember(Name="SiteAvailable", EmitDefaultValue=false)]
		public DecimalValue SiteAvailable { get; set; }

		[DataMember(Name="SiteAvailableforIssue", EmitDefaultValue=false)]
		public DecimalValue SiteAvailableforIssue { get; set; }

		[DataMember(Name="SiteAvailableforShipping", EmitDefaultValue=false)]
		public DecimalValue SiteAvailableforShipping { get; set; }

		[DataMember(Name="SiteDescription", EmitDefaultValue=false)]
		public StringValue SiteDescription { get; set; }

		[DataMember(Name="SiteID", EmitDefaultValue=false)]
		public StringValue SiteID { get; set; }

		[DataMember(Name="SiteLastModifiedDate", EmitDefaultValue=false)]
		public DateTimeValue SiteLastModifiedDate { get; set; }

		[DataMember(Name="SiteOnHand", EmitDefaultValue=false)]
		public DecimalValue SiteOnHand { get; set; }

		[DataMember(Name="TemplateItemID", EmitDefaultValue=false)]
		public StringValue TemplateItemID { get; set; }

	}
}