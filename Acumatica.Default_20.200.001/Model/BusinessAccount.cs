using Acumatica.RESTClient.Model;
using System.Collections.Generic;
using System.Runtime.Serialization;

namespace Acumatica.Default_20_200_001.Model
{
	[DataContract]
	public class BusinessAccount : Entity_v4
	{

		[DataMember(Name="AccountRef", EmitDefaultValue=false)]
		public StringValue AccountRef { get; set; }

		[DataMember(Name="Activities", EmitDefaultValue=false)]
		public List<ActivityDetail> Activities { get; set; }

		[DataMember(Name="Attributes", EmitDefaultValue=false)]
		public List<AttributeValue> Attributes { get; set; }

		[DataMember(Name="BusinessAccountID", EmitDefaultValue=false)]
		public StringValue BusinessAccountID { get; set; }

		[DataMember(Name="Campaigns", EmitDefaultValue=false)]
		public List<CampaignDetail> Campaigns { get; set; }

		[DataMember(Name="Cases", EmitDefaultValue=false)]
		public List<BusinessAccountCaseDetail> Cases { get; set; }

		[DataMember(Name="ClassID", EmitDefaultValue=false)]
		public StringValue ClassID { get; set; }

		[DataMember(Name="Contacts", EmitDefaultValue=false)]
		public List<BusinessAccountContact> Contacts { get; set; }

		[DataMember(Name="Contracts", EmitDefaultValue=false)]
		public List<BusinessAccountContract> Contracts { get; set; }

		[DataMember(Name="DefaultLocationSettings", EmitDefaultValue=false)]
		public BusinessAccountDefaultLocationSetting DefaultLocationSettings { get; set; }

		[DataMember(Name="Duplicate", EmitDefaultValue=false)]
		public StringValue Duplicate { get; set; }

		[DataMember(Name="Duplicates", EmitDefaultValue=false)]
		public List<DuplicateDetail> Duplicates { get; set; }

		[DataMember(Name="LastIncomingActivity", EmitDefaultValue=false)]
		public DateTimeValue LastIncomingActivity { get; set; }

		[DataMember(Name="LastModifiedDateTime", EmitDefaultValue=false)]
		public DateTimeValue LastModifiedDateTime { get; set; }

		[DataMember(Name="LastOutgoingActivity", EmitDefaultValue=false)]
		public DateTimeValue LastOutgoingActivity { get; set; }

		[DataMember(Name="Locations", EmitDefaultValue=false)]
		public List<BusinessAccountLocation> Locations { get; set; }

		[DataMember(Name="MainAddress", EmitDefaultValue=false)]
		public Address MainAddress { get; set; }

		[DataMember(Name="MainAddressValidated", EmitDefaultValue=false)]
		public BooleanValue MainAddressValidated { get; set; }

		[DataMember(Name="MainContact", EmitDefaultValue=false)]
		public BusinessAccountMainContact MainContact { get; set; }

		[DataMember(Name="MarketingLists", EmitDefaultValue=false)]
		public List<MarketingListDetail> MarketingLists { get; set; }

		[DataMember(Name="Name", EmitDefaultValue=false)]
		public StringValue Name { get; set; }

		[DataMember(Name="Opportunities", EmitDefaultValue=false)]
		public List<BusinessAccountOpportunityDetail> Opportunities { get; set; }

		[DataMember(Name="Orders", EmitDefaultValue=false)]
		public List<BusinessAccountOrder> Orders { get; set; }

		[DataMember(Name="Owner", EmitDefaultValue=false)]
		public StringValue Owner { get; set; }

		[DataMember(Name="OwnerEmployeeName", EmitDefaultValue=false)]
		public StringValue OwnerEmployeeName { get; set; }

		[DataMember(Name="ParentAccount", EmitDefaultValue=false)]
		public StringValue ParentAccount { get; set; }

		[DataMember(Name="PrimaryContact", EmitDefaultValue=false)]
		public Contact PrimaryContact { get; set; }

		[DataMember(Name="Relations", EmitDefaultValue=false)]
		public List<RelationDetail> Relations { get; set; }

		[DataMember(Name="ShippingAddress", EmitDefaultValue=false)]
		public Address ShippingAddress { get; set; }

		[DataMember(Name="ShippingAddressOverride", EmitDefaultValue=false)]
		public BooleanValue ShippingAddressOverride { get; set; }

		[DataMember(Name="ShippingAddressValidated", EmitDefaultValue=false)]
		public BooleanValue ShippingAddressValidated { get; set; }

		[DataMember(Name="ShippingContact", EmitDefaultValue=false)]
		public BusinessAccountShippingContact ShippingContact { get; set; }

		[DataMember(Name="SourceCampaign", EmitDefaultValue=false)]
		public StringValue SourceCampaign { get; set; }

		[DataMember(Name="Status", EmitDefaultValue=false)]
		public StringValue Status { get; set; }

		[DataMember(Name="Type", EmitDefaultValue=false)]
		public StringValue Type { get; set; }

		[DataMember(Name="Workgroup", EmitDefaultValue=false)]
		public StringValue Workgroup { get; set; }

		[DataMember(Name="WorkgroupDescription", EmitDefaultValue=false)]
		public StringValue WorkgroupDescription { get; set; }

		[DataMember(Name="NoteID", EmitDefaultValue=false)]
		public GuidValue NoteID { get; set; }

	}
}