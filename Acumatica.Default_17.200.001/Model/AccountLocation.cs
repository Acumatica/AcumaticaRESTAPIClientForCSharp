using Acumatica.RESTClient.Model;
using System.Collections.Generic;
using System.Runtime.Serialization;

namespace Acumatica.Default_17_200_001.Model
{
	[DataContract]
	public class AccountLocation : Entity
	{

		[DataMember(Name="Active", EmitDefaultValue=false)]
		public BooleanValue Active { get; set; }

		[DataMember(Name="Address", EmitDefaultValue=false)]
		public Address Address { get; set; }

		[DataMember(Name="AddressSameAsMain", EmitDefaultValue=false)]
		public BooleanValue AddressSameAsMain { get; set; }

		[DataMember(Name="AddressValidated", EmitDefaultValue=false)]
		public BooleanValue AddressValidated { get; set; }

		[DataMember(Name="ARAccount", EmitDefaultValue=false)]
		public StringValue ARAccount { get; set; }

		[DataMember(Name="ARSubaccount", EmitDefaultValue=false)]
		public StringValue ARSubaccount { get; set; }

		[DataMember(Name="BusinessAccountID", EmitDefaultValue=false)]
		public StringValue BusinessAccountID { get; set; }

		[DataMember(Name="Calendar", EmitDefaultValue=false)]
		public StringValue Calendar { get; set; }

		[DataMember(Name="Cases", EmitDefaultValue=false)]
		public List<CaseDetail> Cases { get; set; }

		[DataMember(Name="Contact", EmitDefaultValue=false)]
		public AccountLocationContact Contact { get; set; }

		[DataMember(Name="DefaultProject", EmitDefaultValue=false)]
		public StringValue DefaultProject { get; set; }

		[DataMember(Name="DiscountAccount", EmitDefaultValue=false)]
		public StringValue DiscountAccount { get; set; }

		[DataMember(Name="DiscountSubaccount", EmitDefaultValue=false)]
		public StringValue DiscountSubaccount { get; set; }

		[DataMember(Name="EntityUsageType", EmitDefaultValue=false)]
		public StringValue EntityUsageType { get; set; }

		[DataMember(Name="FedExGroundCollect", EmitDefaultValue=false)]
		public BooleanValue FedExGroundCollect { get; set; }

		[DataMember(Name="FOBPoint", EmitDefaultValue=false)]
		public StringValue FOBPoint { get; set; }

		[DataMember(Name="FreightAccount", EmitDefaultValue=false)]
		public StringValue FreightAccount { get; set; }

		[DataMember(Name="FreightSubaccount", EmitDefaultValue=false)]
		public StringValue FreightSubaccount { get; set; }

		[DataMember(Name="Insurance", EmitDefaultValue=false)]
		public BooleanValue Insurance { get; set; }

		[DataMember(Name="LeadTimeInDays", EmitDefaultValue=false)]
		public ShortValue LeadTimeInDays { get; set; }

		[DataMember(Name="LocationID", EmitDefaultValue=false)]
		public StringValue LocationID { get; set; }

		[DataMember(Name="LocationName", EmitDefaultValue=false)]
		public StringValue LocationName { get; set; }

		[DataMember(Name="Opportunities", EmitDefaultValue=false)]
		public List<OpportunityDetail> Opportunities { get; set; }

		[DataMember(Name="OrderPriority", EmitDefaultValue=false)]
		public ShortValue OrderPriority { get; set; }

		[DataMember(Name="PriceClass", EmitDefaultValue=false)]
		public StringValue PriceClass { get; set; }

		[DataMember(Name="ResidentialDelivery", EmitDefaultValue=false)]
		public BooleanValue ResidentialDelivery { get; set; }

		[DataMember(Name="SalesAccount", EmitDefaultValue=false)]
		public StringValue SalesAccount { get; set; }

		[DataMember(Name="SalesSubaccount", EmitDefaultValue=false)]
		public StringValue SalesSubaccount { get; set; }

		[DataMember(Name="SameAsDefaultLocation", EmitDefaultValue=false)]
		public BooleanValue SameAsDefaultLocation { get; set; }

		[DataMember(Name="SaturdayDelivery", EmitDefaultValue=false)]
		public BooleanValue SaturdayDelivery { get; set; }

		[DataMember(Name="ShippingBranch", EmitDefaultValue=false)]
		public StringValue ShippingBranch { get; set; }

		[DataMember(Name="ShippingRule", EmitDefaultValue=false)]
		public StringValue ShippingRule { get; set; }

		[DataMember(Name="ShippingTerms", EmitDefaultValue=false)]
		public StringValue ShippingTerms { get; set; }

		[DataMember(Name="ShippingZone", EmitDefaultValue=false)]
		public StringValue ShippingZone { get; set; }

		[DataMember(Name="ShipVia", EmitDefaultValue=false)]
		public StringValue ShipVia { get; set; }

		[DataMember(Name="TaxExemptionNumber", EmitDefaultValue=false)]
		public StringValue TaxExemptionNumber { get; set; }

		[DataMember(Name="TaxRegistrationID", EmitDefaultValue=false)]
		public StringValue TaxRegistrationID { get; set; }

		[DataMember(Name="TaxZone", EmitDefaultValue=false)]
		public StringValue TaxZone { get; set; }

		[DataMember(Name="Warehouse", EmitDefaultValue=false)]
		public StringValue Warehouse { get; set; }

	}
}