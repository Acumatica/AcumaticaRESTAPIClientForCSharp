using System;
using System.Collections.Generic;
using System.Runtime.Serialization;

using Newtonsoft.Json;

using Acumatica.RESTClient.Client;
using Acumatica.RESTClient.ContractBasedApi;
using Acumatica.RESTClient.ContractBasedApi.Model;

namespace Acumatica.Default_24_200_001.Model
{
	/// <summary>
	/// Corresponds to the screen CR304000 in the Acumatica ERP
	/// </summary>
	[DataContract]
	public class Opportunity : Entity, ITopLevelEntity
	{

		[DataMember(Name="Activities", EmitDefaultValue=false)]
		public List<ActivityDetail>? Activities { get; set; }

		[DataMember(Name="Address", EmitDefaultValue=false)]
		public Address? Address { get; set; }

		/// <summary>
		/// DAC Field Name: CuryAmount 
		/// DAC: PX.Objects.CR.CROpportunity 
		/// Display Name: Detail Total 
		/// </summary>
		[DataMember(Name="Amount", EmitDefaultValue=false)]
		public DecimalValue? Amount { get; set; }

		[DataMember(Name="Attributes", EmitDefaultValue=false)]
		public List<AttributeValue>? Attributes { get; set; }

		/// <summary>
		/// The identifier of the Branch that will be used to ship the goods to the customer.
		/// DAC Field Name: BranchID 
		/// DAC: PX.Objects.CR.CROpportunity 
		/// </summary>
		[DataMember(Name="Branch", EmitDefaultValue=false)]
		public StringValue? Branch { get; set; }

		/// <summary>
		/// The identifier of the related business account.
		/// DAC Field Name: BAccountID 
		/// DAC: PX.Objects.CR.CROpportunity 
		/// Display Name: Business Account 
		/// </summary>
		[DataMember(Name="BusinessAccount", EmitDefaultValue=false)]
		public StringValue? BusinessAccount { get; set; }

		/// <summary>
		/// The identifier of the CROpportunityClass.
		/// DAC: PX.Objects.CR.CROpportunity 
		/// Display Name: Class ID 
		/// SQL Type: nvarchar(10) 
		/// </summary>
		[DataMember(Name="ClassID", EmitDefaultValue=false)]
		public StringValue? ClassID { get; set; }

		/// <summary>
		/// DAC Field Name: ContactID_description 
		/// DAC: PX.Objects.CR.CROpportunity 
		/// </summary>
		[DataMember(Name="ContactDisplayName", EmitDefaultValue=false)]
		public StringValue? ContactDisplayName { get; set; }

		/// <summary>
		/// The identifier of the Contact, the representative to be contacted about the opportunity.
		/// DAC: PX.Objects.CR.CROpportunity 
		/// Display Name: Contact 
		/// </summary>
		[DataMember(Name="ContactID", EmitDefaultValue=false)]
		public IntValue? ContactID { get; set; }

		[DataMember(Name="ContactInformation", EmitDefaultValue=false)]
		public OpportunityContact? ContactInformation { get; set; }

		/// <summary>
		/// DAC Field Name: LeadID_description 
		/// DAC: PX.Objects.CR.CROpportunity 
		/// </summary>
		[DataMember(Name="ConvertedLeadDisplayName", EmitDefaultValue=false)]
		public StringValue? ConvertedLeadDisplayName { get; set; }

		[DataMember(Name="ConvertedLeadID", EmitDefaultValue=false)]
		public IntValue? ConvertedLeadID { get; set; }

		/// <summary>
		/// The currency of the opportunity.
		/// DAC Field Name: CuryID 
		/// DAC: PX.Objects.CR.CROpportunity 
		/// Display Name: Currency 
		/// SQL Type: nvarchar(5) 
		/// </summary>
		[DataMember(Name="CurrencyID", EmitDefaultValue=false)]
		public StringValue? CurrencyID { get; set; }

		/// <summary>
		/// DAC Field Name: CuryViewState 
		/// DAC: PX.Objects.CR.CROpportunity 
		/// </summary>
		[DataMember(Name="CurrencyViewState", EmitDefaultValue=false)]
		public BooleanValue? CurrencyViewState { get; set; }

		/// <summary>
		/// The detailed description or any relevant notes of the opportunity
		/// DAC: PX.Objects.CR.CROpportunity 
		/// SQL Type: nvarchar(MAX) 
		/// </summary>
		[DataMember(Name="Details", EmitDefaultValue=false)]
		public StringValue? Details { get; set; }

		/// <summary>
		/// The total discount of the document (in the currency of the document),which is calculated as the sum of all group, document of the opportunity(line discounts are not included).
		/// DAC Field Name: CuryDiscTot 
		/// DAC: PX.Objects.CR.CROpportunity 
		/// Display Name: Document Discounts 
		/// </summary>
		[DataMember(Name="Discount", EmitDefaultValue=false)]
		public DecimalValue? Discount { get; set; }

		[DataMember(Name="Discounts", EmitDefaultValue=false)]
		public List<OpportunityDiscount>? Discounts { get; set; }

		/// <summary>
		/// The estimated date of closing the deal.
		/// DAC Field Name: CloseDate 
		/// DAC: PX.Objects.CR.CROpportunity 
		/// Display Name: Estimated Close Date 
		/// </summary>
		[DataMember(Name="Estimation", EmitDefaultValue=false)]
		public DateTimeValue? Estimation { get; set; }

		/// <summary>
		/// The identifier of the default location Location object linked with the prospective or existing customer selected in the Business Account box.If no location is selected in this box, the settings on the Shipping tab are empty and available for editing.
		/// DAC Field Name: LocationID 
		/// DAC: PX.Objects.CR.CROpportunity 
		/// Display Name: Account Location 
		/// </summary>
		/// <remarks>
		/// Also, the Location.BAccountID value must be equal tothe CROpportunity.BAccountID value of the current opportunity.
		/// </remarks>
		[DataMember(Name="Location", EmitDefaultValue=false)]
		public StringValue? Location { get; set; }

		/// <summary>
		/// DAC Field Name: ManualTotalEntry 
		/// DAC: PX.Objects.CR.CROpportunity 
		/// Display Name: Manual Amount 
		/// </summary>
		[DataMember(Name="ManualAmount", EmitDefaultValue=false)]
		public BooleanValue? ManualAmount { get; set; }

		/// <summary>
		/// The identifier of the opportunity.
		/// DAC: PX.Objects.CR.CROpportunity 
		/// Display Name: Opportunity ID 
		/// SQL Type: nvarchar(15) 
		/// Key Field
		/// </summary>
		/// <remarks>
		/// This field depends on opportunityNumberingID.
		/// </remarks>
		[DataMember(Name="OpportunityID", EmitDefaultValue=false)]
		public StringValue? OpportunityID { get; set; }

		/// <summary>
		/// Specifies whether the contactand address information of this opportunity differs fromthe contact and address informationof the business account associated with this opportunity.
		/// DAC Field Name: AllowOverrideContactAddress 
		/// DAC: PX.Objects.CR.CROpportunity 
		/// </summary>
		/// <remarks>
		/// The behavior is controlled by the ContactAddress graph extension derived from the CROpportunityContactAddressExt`1graph extension.
		/// </remarks>
		[DataMember(Name="Override", EmitDefaultValue=false)]
		public BooleanValue? Override { get; set; }

		/// <summary>
		/// The identifier of the user responsible for the current document.If the WorkgroupID is specified, only a user that belongsto the specified workgroup can be used.
		/// DAC Field Name: OwnerID 
		/// DAC: PX.Objects.CR.CROpportunity 
		/// </summary>
		[DataMember(Name="Owner", EmitDefaultValue=false)]
		public StringValue? Owner { get; set; }

		/// <summary>
		/// DAC Field Name: OwnerID_description 
		/// DAC: PX.Objects.CR.CROpportunity 
		/// </summary>
		[DataMember(Name="OwnerEmployeeName", EmitDefaultValue=false)]
		public StringValue? OwnerEmployeeName { get; set; }

		/// <summary>
		/// The identifier of the parent business account.
		/// DAC Field Name: ParentBAccountID 
		/// DAC: PX.Objects.CR.CROpportunity 
		/// Display Name: Parent Account 
		/// </summary>
		[DataMember(Name="ParentAccount", EmitDefaultValue=false)]
		public StringValue? ParentAccount { get; set; }

		[DataMember(Name="Products", EmitDefaultValue=false)]
		public List<OpportunityProduct>? Products { get; set; }

		/// <summary>
		/// The project with which the item is associated.
		/// DAC Field Name: ProjectID 
		/// DAC: PX.Objects.CR.CROpportunity 
		/// </summary>
		[DataMember(Name="Project", EmitDefaultValue=false)]
		public StringValue? Project { get; set; }

		/// <summary>
		/// The reason why the status of the opportunity has been changed.
		/// DAC Field Name: Resolution 
		/// DAC: PX.Objects.CR.CROpportunity 
		/// SQL Type: char(2) 
		/// </summary>
		[DataMember(Name="Reason", EmitDefaultValue=false)]
		public StringValue? Reason { get; set; }

		[DataMember(Name="Relations", EmitDefaultValue=false)]
		public List<RelationDetail>? Relations { get; set; }

		/// <summary>
		/// DAC: PX.Objects.CR.CROpportunity 
		/// SQL Type: char(1) 
		/// </summary>
		[DataMember(Name="Source", EmitDefaultValue=false)]
		public StringValue? Source { get; set; }

		/// <summary>
		/// The marketing campaign that resulted in the creation of the opportunity.
		/// DAC Field Name: CampaignSourceID 
		/// DAC: PX.Objects.CR.CROpportunity 
		/// Display Name: Source Campaign 
		/// SQL Type: nvarchar(15) 
		/// </summary>
		[DataMember(Name="SourceCampaign", EmitDefaultValue=false)]
		public StringValue? SourceCampaign { get; set; }

		/// <summary>
		/// The current stage of the opportunity.
		/// DAC Field Name: StageID 
		/// DAC: PX.Objects.CR.CROpportunity 
		/// SQL Type: varchar(2) 
		/// </summary>
		[DataMember(Name="Stage", EmitDefaultValue=false)]
		public StringValue? Stage { get; set; }

		/// <summary>
		/// The current status of the opportunity.
		/// DAC: PX.Objects.CR.CROpportunity 
		/// SQL Type: char(1) 
		/// </summary>
		[DataMember(Name="Status", EmitDefaultValue=false)]
		public StringValue? Status { get; set; }

		/// <summary>
		/// The subject or description of the opportunity.
		/// DAC: PX.Objects.CR.CROpportunity 
		/// Display Name: Description 
		/// SQL Type: nvarchar(255) 
		/// </summary>
		[DataMember(Name="Subject", EmitDefaultValue=false)]
		public StringValue? Subject { get; set; }

		[DataMember(Name="TaxDetails", EmitDefaultValue=false)]
		public List<OpportunityTaxDetail>? TaxDetails { get; set; }

		/// <summary>
		/// The tax zone that applies to the bank transaction.
		/// DAC Field Name: TaxZoneID 
		/// DAC: PX.Objects.CR.CROpportunity 
		/// Display Name: Tax Zone 
		/// SQL Type: nvarchar(10) 
		/// </summary>
		[DataMember(Name="TaxZone", EmitDefaultValue=false)]
		public StringValue? TaxZone { get; set; }

		/// <summary>
		/// DAC Field Name: CuryProductsAmount 
		/// DAC: PX.Objects.CR.CROpportunity 
		/// </summary>
		[DataMember(Name="Total", EmitDefaultValue=false)]
		public DecimalValue? Total { get; set; }

		/// <summary>
		/// DAC Field Name: CuryWgtAmount 
		/// DAC: PX.Objects.CR.CROpportunity 
		/// Display Name: Wgt. Total 
		/// </summary>
		[DataMember(Name="WeightTotal", EmitDefaultValue=false)]
		public DecimalValue? WeightTotal { get; set; }

		/// <summary>
		/// DAC Field Name: WorkgroupID_description 
		/// DAC: PX.Objects.CR.CROpportunity 
		/// </summary>
		[DataMember(Name="WorkgroupDescription", EmitDefaultValue=false)]
		public StringValue? WorkgroupDescription { get; set; }

		/// <summary>
		/// The workgroup associated with the opportunity.
		/// DAC: PX.Objects.CR.CROpportunity 
		/// Display Name: Workgroup 
		/// </summary>
		[DataMember(Name="WorkgroupID", EmitDefaultValue=false)]
		public StringValue? WorkgroupID { get; set; }

		[DataMember(Name="LastModifiedDateTime", EmitDefaultValue=false)]
		public DateTimeValue? LastModifiedDateTime { get; set; }

		[DataMember(Name="NoteID", EmitDefaultValue=false)]
		public GuidValue? NoteID { get; set; }

		public virtual string GetEndpointPath()
		{
			return "entity/Default/24.200.001";
		}
	}
}