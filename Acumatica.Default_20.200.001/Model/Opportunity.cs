using Acumatica.RESTClient.Model;
using System.Collections.Generic;
using System.Runtime.Serialization;

namespace Acumatica.Default_20_200_001.Model
{
	[DataContract]
	public class Opportunity : Entity_v4
	{

		[DataMember(Name="Activities", EmitDefaultValue=false)]
		public List<ActivityDetail> Activities { get; set; }

		[DataMember(Name="Address", EmitDefaultValue=false)]
		public Address Address { get; set; }

		[DataMember(Name="Amount", EmitDefaultValue=false)]
		public DecimalValue Amount { get; set; }

		[DataMember(Name="Attributes", EmitDefaultValue=false)]
		public List<AttributeValue> Attributes { get; set; }

		[DataMember(Name="Branch", EmitDefaultValue=false)]
		public StringValue Branch { get; set; }

		[DataMember(Name="BusinessAccount", EmitDefaultValue=false)]
		public StringValue BusinessAccount { get; set; }

		[DataMember(Name="ClassID", EmitDefaultValue=false)]
		public StringValue ClassID { get; set; }

		[DataMember(Name="ContactDisplayName", EmitDefaultValue=false)]
		public StringValue ContactDisplayName { get; set; }

		[DataMember(Name="ContactID", EmitDefaultValue=false)]
		public IntValue ContactID { get; set; }

		[DataMember(Name="ContactInformation", EmitDefaultValue=false)]
		public OpportunityContact ContactInformation { get; set; }

		[DataMember(Name="ConvertedLeadDisplayName", EmitDefaultValue=false)]
		public StringValue ConvertedLeadDisplayName { get; set; }

		[DataMember(Name="ConvertedLeadID", EmitDefaultValue=false)]
		public IntValue ConvertedLeadID { get; set; }

		[DataMember(Name="CurrencyID", EmitDefaultValue=false)]
		public StringValue CurrencyID { get; set; }

		[DataMember(Name="CurrencyViewState", EmitDefaultValue=false)]
		public BooleanValue CurrencyViewState { get; set; }

		[DataMember(Name="Details", EmitDefaultValue=false)]
		public StringValue Details { get; set; }

		[DataMember(Name="Discount", EmitDefaultValue=false)]
		public DecimalValue Discount { get; set; }

		[DataMember(Name="Discounts", EmitDefaultValue=false)]
		public List<OpportunityDiscount> Discounts { get; set; }

		[DataMember(Name="Estimation", EmitDefaultValue=false)]
		public DateTimeValue Estimation { get; set; }

		[DataMember(Name="Location", EmitDefaultValue=false)]
		public StringValue Location { get; set; }

		[DataMember(Name="ManualAmount", EmitDefaultValue=false)]
		public BooleanValue ManualAmount { get; set; }

		[DataMember(Name="OpportunityID", EmitDefaultValue=false)]
		public StringValue OpportunityID { get; set; }

		[DataMember(Name="Override", EmitDefaultValue=false)]
		public BooleanValue Override { get; set; }

		[DataMember(Name="Owner", EmitDefaultValue=false)]
		public StringValue Owner { get; set; }

		[DataMember(Name="OwnerEmployeeName", EmitDefaultValue=false)]
		public StringValue OwnerEmployeeName { get; set; }

		[DataMember(Name="ParentAccount", EmitDefaultValue=false)]
		public StringValue ParentAccount { get; set; }

		[DataMember(Name="Products", EmitDefaultValue=false)]
		public List<OpportunityProduct> Products { get; set; }

		[DataMember(Name="Project", EmitDefaultValue=false)]
		public StringValue Project { get; set; }

		[DataMember(Name="Reason", EmitDefaultValue=false)]
		public StringValue Reason { get; set; }

		[DataMember(Name="Relations", EmitDefaultValue=false)]
		public List<RelationDetail> Relations { get; set; }

		[DataMember(Name="Source", EmitDefaultValue=false)]
		public StringValue Source { get; set; }

		[DataMember(Name="SourceCampaign", EmitDefaultValue=false)]
		public StringValue SourceCampaign { get; set; }

		[DataMember(Name="Stage", EmitDefaultValue=false)]
		public StringValue Stage { get; set; }

		[DataMember(Name="Status", EmitDefaultValue=false)]
		public StringValue Status { get; set; }

		[DataMember(Name="Subject", EmitDefaultValue=false)]
		public StringValue Subject { get; set; }

		[DataMember(Name="TaxDetails", EmitDefaultValue=false)]
		public List<OpportunityTaxDetail> TaxDetails { get; set; }

		[DataMember(Name="TaxZone", EmitDefaultValue=false)]
		public StringValue TaxZone { get; set; }

		[DataMember(Name="Total", EmitDefaultValue=false)]
		public DecimalValue Total { get; set; }

		[DataMember(Name="WeightTotal", EmitDefaultValue=false)]
		public DecimalValue WeightTotal { get; set; }

		[DataMember(Name="WorkgroupDescription", EmitDefaultValue=false)]
		public StringValue WorkgroupDescription { get; set; }

		[DataMember(Name="WorkgroupID", EmitDefaultValue=false)]
		public StringValue WorkgroupID { get; set; }

		[DataMember(Name="LastModifiedDateTime", EmitDefaultValue=false)]
		public DateTimeValue LastModifiedDateTime { get; set; }

		[DataMember(Name="NoteID", EmitDefaultValue=false)]
		public GuidValue NoteID { get; set; }

	}
}