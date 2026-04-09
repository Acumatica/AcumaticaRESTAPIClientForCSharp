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
	public class CustomerLocation : Entity, ITopLevelEntity
	{

		[DataMember(Name="Active", EmitDefaultValue=false)]
		public BooleanValue? Active { get; set; }

		[DataMember(Name="AddressOverride", EmitDefaultValue=false)]
		public BooleanValue? AddressOverride { get; set; }

		[DataMember(Name="Calendar", EmitDefaultValue=false)]
		public StringValue? Calendar { get; set; }

		[DataMember(Name="ContactOverride", EmitDefaultValue=false)]
		public BooleanValue? ContactOverride { get; set; }

		[DataMember(Name="CreatedDateTime", EmitDefaultValue=false)]
		public DateTimeValue? CreatedDateTime { get; set; }

		[DataMember(Name="Customer", EmitDefaultValue=false)]
		public StringValue? Customer { get; set; }

		[DataMember(Name="Default", EmitDefaultValue=false)]
		public BooleanValue? Default { get; set; }

		[DataMember(Name="DefaultProject", EmitDefaultValue=false)]
		public StringValue? DefaultProject { get; set; }

		[DataMember(Name="EntityUsageType", EmitDefaultValue=false)]
		public StringValue? EntityUsageType { get; set; }

		[DataMember(Name="FedExGroundCollect", EmitDefaultValue=false)]
		public BooleanValue? FedExGroundCollect { get; set; }

		[DataMember(Name="FOBPoint", EmitDefaultValue=false)]
		public StringValue? FOBPoint { get; set; }

		[DataMember(Name="Insurance", EmitDefaultValue=false)]
		public BooleanValue? Insurance { get; set; }

		[DataMember(Name="LastModifiedDateTime", EmitDefaultValue=false)]
		public DateTimeValue? LastModifiedDateTime { get; set; }

		[DataMember(Name="LeadTimeDays", EmitDefaultValue=false)]
		public ShortValue? LeadTimeDays { get; set; }

		[DataMember(Name="LocationContact", EmitDefaultValue=false)]
		public Contact? LocationContact { get; set; }

		[DataMember(Name="LocationID", EmitDefaultValue=false)]
		public StringValue? LocationID { get; set; }

		[DataMember(Name="LocationName", EmitDefaultValue=false)]
		public StringValue? LocationName { get; set; }

		[DataMember(Name="OrderPriority", EmitDefaultValue=false)]
		public ShortValue? OrderPriority { get; set; }

		[DataMember(Name="PriceClass", EmitDefaultValue=false)]
		public StringValue? PriceClass { get; set; }

		[DataMember(Name="ResidentialDelivery", EmitDefaultValue=false)]
		public BooleanValue? ResidentialDelivery { get; set; }

		[DataMember(Name="RoleAssignments", EmitDefaultValue=false)]
		public List<BCRoleAssignment>? RoleAssignments { get; set; }

		[DataMember(Name="SaturdayDelivery", EmitDefaultValue=false)]
		public BooleanValue? SaturdayDelivery { get; set; }

		[DataMember(Name="ShippingBranch", EmitDefaultValue=false)]
		public StringValue? ShippingBranch { get; set; }

		[DataMember(Name="ShippingRule", EmitDefaultValue=false)]
		public StringValue? ShippingRule { get; set; }

		[DataMember(Name="ShippingTerms", EmitDefaultValue=false)]
		public StringValue? ShippingTerms { get; set; }

		[DataMember(Name="ShippingZone", EmitDefaultValue=false)]
		public StringValue? ShippingZone { get; set; }

		[DataMember(Name="ShipVia", EmitDefaultValue=false)]
		public StringValue? ShipVia { get; set; }

		[DataMember(Name="Status", EmitDefaultValue=false)]
		public StringSingleSelectValue? Status { get; set; }

		[DataMember(Name="TaxExemptionNbr", EmitDefaultValue=false)]
		public StringValue? TaxExemptionNbr { get; set; }

		[DataMember(Name="TaxRegistrationID", EmitDefaultValue=false)]
		public StringValue? TaxRegistrationID { get; set; }

		[DataMember(Name="TaxZone", EmitDefaultValue=false)]
		public StringValue? TaxZone { get; set; }

		[DataMember(Name="Warehouse", EmitDefaultValue=false)]
		public StringValue? Warehouse { get; set; }

		[DataMember(Name="NoteID", EmitDefaultValue=false)]
		public GuidValue? NoteID { get; set; }

		[DataMember(Name="ExtRefNbr", EmitDefaultValue=false)]
		public StringValue? ExtRefNbr { get; set; }

		public static class Expand
		{
			public const string Files = "Files";
			public const string Translations = "Translations";
			public const string LocationContact = "LocationContact";
			public const string LocationContact_Activities = "LocationContact/Activities";
			public const string LocationContact_Activities_Files = "LocationContact/Activities/Files";
			public const string LocationContact_Address = "LocationContact/Address";
			public const string LocationContact_Attributes = "LocationContact/Attributes";
			public const string LocationContact_Campaigns = "LocationContact/Campaigns";
			public const string LocationContact_Campaigns_Files = "LocationContact/Campaigns/Files";
			public const string LocationContact_Cases = "LocationContact/Cases";
			public const string LocationContact_Cases_Files = "LocationContact/Cases/Files";
			public const string LocationContact_Duplicates = "LocationContact/Duplicates";
			public const string LocationContact_Duplicates_Files = "LocationContact/Duplicates/Files";
			public const string LocationContact_MarketingLists = "LocationContact/MarketingLists";
			public const string LocationContact_MarketingLists_Files = "LocationContact/MarketingLists/Files";
			public const string LocationContact_Notifications = "LocationContact/Notifications";
			public const string LocationContact_Notifications_Files = "LocationContact/Notifications/Files";
			public const string LocationContact_Opportunities = "LocationContact/Opportunities";
			public const string LocationContact_Opportunities_Files = "LocationContact/Opportunities/Files";
			public const string LocationContact_Relations = "LocationContact/Relations";
			public const string LocationContact_Relations_Files = "LocationContact/Relations/Files";
			public const string LocationContact_RoleAssignments = "LocationContact/RoleAssignments";
			public const string LocationContact_RoleAssignments_Files = "LocationContact/RoleAssignments/Files";
			public const string LocationContact_UserInfo = "LocationContact/UserInfo";
			public const string LocationContact_UserInfo_Roles = "LocationContact/UserInfo/Roles";
			public const string LocationContact_UserInfo_Roles_Files = "LocationContact/UserInfo/Roles/Files";
			public const string RoleAssignments = "RoleAssignments";
			public const string RoleAssignments_Files = "RoleAssignments/Files";

			//Intentionally excluded
			//public const string All = "Files,Translations,LocationContact,LocationContact/Activities,LocationContact/Activities/Files,LocationContact/Address,LocationContact/Attributes,LocationContact/Campaigns,LocationContact/Campaigns/Files,LocationContact/Cases,LocationContact/Cases/Files,LocationContact/Duplicates,LocationContact/Duplicates/Files,LocationContact/MarketingLists,LocationContact/MarketingLists/Files,LocationContact/Notifications,LocationContact/Notifications/Files,LocationContact/Opportunities,LocationContact/Opportunities/Files,LocationContact/Relations,LocationContact/Relations/Files,LocationContact/RoleAssignments,LocationContact/RoleAssignments/Files,LocationContact/UserInfo,LocationContact/UserInfo/Roles,LocationContact/UserInfo/Roles/Files,RoleAssignments,RoleAssignments/Files";
		}
		public virtual string GetEndpointPath()
		{
			return "entity/Default/26.200.001";
		}
	}
}