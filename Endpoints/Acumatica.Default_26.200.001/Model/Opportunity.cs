using System;
using System.Collections.Generic;
using System.Runtime.Serialization;

using Newtonsoft.Json;

using Acumatica.RESTClient.Client;
using Acumatica.RESTClient.ContractBasedApi;
using Acumatica.RESTClient.ContractBasedApi.Model;

namespace Acumatica.Default_26_200_001.Model
{
	/// <summary>
	/// Corresponds to the screen <c>CR304000</c> in the Acumatica ERP
	/// <para>Key Fields: OpportunityID</para>
	/// </summary>
	[DataContract]
	public class Opportunity : Entity, ITopLevelEntity
	{

		[DataMember(Name="BusinessAccountName", EmitDefaultValue=false)]
		public StringValue? BusinessAccountName { get; set; }

		[DataMember(Name="Activities", EmitDefaultValue=false)]
		public List<ActivityDetail>? Activities { get; set; }

		[DataMember(Name="ActivityOpportunityStatistics", EmitDefaultValue=false)]
		public ActivityStatistics? ActivityOpportunityStatistics { get; set; }

		[DataMember(Name="ActivityQuoteStatistics", EmitDefaultValue=false)]
		public ActivityStatistics? ActivityQuoteStatistics { get; set; }

		[DataMember(Name="Address", EmitDefaultValue=false)]
		public Address? Address { get; set; }

		[DataMember(Name="AISentiment", EmitDefaultValue=false)]
		public StringValue? AISentiment { get; set; }

		/// <summary>
		/// <para>DAC Field Name: CuryAmount</para>
		/// <para>DAC: PX.Objects.CR.CROpportunity</para>
		/// <para>Display Name: Detail Total</para>
		/// </summary>
		[DataMember(Name="Amount", EmitDefaultValue=false)]
		public DecimalValue? Amount { get; set; }

		[DataMember(Name="AssignDate", EmitDefaultValue=false)]
		public DateTimeValue? AssignDate { get; set; }

		[DataMember(Name="Attributes", EmitDefaultValue=false)]
		public List<AttributeValue>? Attributes { get; set; }

		/// <summary>
		/// The identifier of the Branch that will be used to ship the goods to the customer.
		/// <para>DAC Field Name: BranchID</para>
		/// <para>DAC: PX.Objects.CR.CROpportunity</para>
		/// </summary>
		[DataMember(Name="Branch", EmitDefaultValue=false)]
		public StringValue? Branch { get; set; }

		/// <summary>
		/// The identifier of the related business account.
		/// <para>DAC Field Name: BAccountID</para>
		/// <para>DAC: PX.Objects.CR.CROpportunity</para>
		/// <para>Display Name: Business Account</para>
		/// </summary>
		[DataMember(Name="BusinessAccount", EmitDefaultValue=false)]
		public StringValue? BusinessAccount { get; set; }

		/// <summary>
		/// The identifier of the CROpportunityClass.
		/// <para>DAC: PX.Objects.CR.CROpportunity</para>
		/// <para>Display Name: Opportunity Class</para>
		/// <para>SQL Type: nvarchar(10)</para>
		/// </summary>
		[DataMember(Name="ClassID", EmitDefaultValue=false)]
		public StringValue? ClassID { get; set; }

		/// <summary>
		/// The date of closing the opportunity.
		/// <para>DAC: PX.Objects.CR.CROpportunity</para>
		/// <para>Display Name: Actual Close Date</para>
		/// </summary>
		[DataMember(Name="ClosingDate", EmitDefaultValue=false)]
		public DateTimeValue? ClosingDate { get; set; }

		/// <summary>
		/// <para>DAC Field Name: ContactID_description</para>
		/// <para>DAC: PX.Objects.CR.CROpportunity</para>
		/// </summary>
		[DataMember(Name="ContactDisplayName", EmitDefaultValue=false)]
		public StringValue? ContactDisplayName { get; set; }

		/// <summary>
		/// The identifier of the Contact, the representative to be contacted about the opportunity.
		/// <para>DAC: PX.Objects.CR.CROpportunity</para>
		/// <para>Display Name: Contact</para>
		/// </summary>
		[DataMember(Name="ContactID", EmitDefaultValue=false)]
		public IntValue? ContactID { get; set; }

		[DataMember(Name="ContactInformation", EmitDefaultValue=false)]
		public OpportunityContact? ContactInformation { get; set; }

		[DataMember(Name="ContractCD", EmitDefaultValue=false)]
		public StringValue? ContractCD { get; set; }

		/// <summary>
		/// <para>DAC Field Name: LeadID_description</para>
		/// <para>DAC: PX.Objects.CR.CROpportunity</para>
		/// </summary>
		[DataMember(Name="ConvertedLeadDisplayName", EmitDefaultValue=false)]
		public StringValue? ConvertedLeadDisplayName { get; set; }

		[DataMember(Name="ConvertedLeadID", EmitDefaultValue=false)]
		public IntValue? ConvertedLeadID { get; set; }

		/// <summary>
		/// The ID of the user who created the record.
		/// <para>DAC: PX.Objects.CR.CRRelation</para>
		/// <para>Display Name: Creator</para>
		/// </summary>
		[DataMember(Name="CreatedByID", EmitDefaultValue=false)]
		public GuidValue? CreatedByID { get; set; }

		/// <summary>
		/// The date and time when the record was created.
		/// <para>DAC: PX.Objects.CR.CRPMTimeActivity</para>
		/// <para>Display Name: Created At</para>
		/// </summary>
		[DataMember(Name="CreatedDateTime", EmitDefaultValue=false)]
		public DateTimeValue? CreatedDateTime { get; set; }

		/// <summary>
		/// The currency of the opportunity.
		/// <para>DAC Field Name: CuryID</para>
		/// <para>DAC: PX.Objects.CR.CROpportunity</para>
		/// <para>Display Name: Currency</para>
		/// <para>SQL Type: nvarchar(5)</para>
		/// </summary>
		[DataMember(Name="CurrencyID", EmitDefaultValue=false)]
		public StringValue? CurrencyID { get; set; }

		/// <summary>
		/// <para>DAC Field Name: CuryViewState</para>
		/// <para>DAC: PX.Objects.CR.CROpportunity</para>
		/// </summary>
		[DataMember(Name="CurrencyViewState", EmitDefaultValue=false)]
		public BooleanValue? CurrencyViewState { get; set; }

		/// <summary>
		/// <para>DAC: PX.Objects.CR.CROpportunity</para>
		/// <para>Display Name: Line Discounts</para>
		/// </summary>
		[DataMember(Name="CuryLineDiscountTotal", EmitDefaultValue=false)]
		public DecimalValue? CuryLineDiscountTotal { get; set; }

		[DataMember(Name="CuryOrderDiscTotal", EmitDefaultValue=false)]
		public DecimalValue? CuryOrderDiscTotal { get; set; }

		[DataMember(Name="Description", EmitDefaultValue=false)]
		public StringValue? Description { get; set; }

		/// <summary>
		/// The detailed description or any relevant notes of the opportunity
		/// <para>DAC: PX.Objects.CR.CROpportunity</para>
		/// <para>SQL Type: nvarchar(MAX)</para>
		/// </summary>
		[DataMember(Name="Details", EmitDefaultValue=false)]
		public StringValue? Details { get; set; }

		/// <summary>
		/// The total discount of the document (in the currency of the document),which is calculated as the sum of all group, document of the opportunity(line discounts are not included).
		/// <para>DAC Field Name: CuryDiscTot</para>
		/// <para>DAC: PX.Objects.CR.CROpportunity</para>
		/// <para>Display Name: Document Discounts</para>
		/// </summary>
		[DataMember(Name="Discount", EmitDefaultValue=false)]
		public DecimalValue? Discount { get; set; }

		[DataMember(Name="Discounts", EmitDefaultValue=false)]
		public List<OpportunityDiscount>? Discounts { get; set; }

		[DataMember(Name="DisplayName", EmitDefaultValue=false)]
		public StringValue? DisplayName { get; set; }

		/// <summary>
		/// The estimated date of closing the deal.
		/// <para>DAC Field Name: CloseDate</para>
		/// <para>DAC: PX.Objects.CR.CROpportunity</para>
		/// <para>Display Name: Estimated Close Date</para>
		/// </summary>
		[DataMember(Name="Estimation", EmitDefaultValue=false)]
		public DateTimeValue? Estimation { get; set; }

		/// <summary>
		/// Indicates whether the opportunity is active.
		/// <para>DAC: PX.Objects.CR.CROpportunity</para>
		/// <para>Display Name: Active</para>
		/// </summary>
		[DataMember(Name="IsActive", EmitDefaultValue=false)]
		public BooleanValue? IsActive { get; set; }

		/// <summary>
		/// The ID of the user who last modified the record.
		/// <para>DAC: PX.Objects.CR.CRRelation</para>
		/// <para>Display Name: Last Modified By</para>
		/// </summary>
		[DataMember(Name="LastModifiedByID", EmitDefaultValue=false)]
		public GuidValue? LastModifiedByID { get; set; }

		/// <summary>
		/// The identifier of the default location Location object linked with the prospective or existing customer selected in the Business Account box.If no location is selected in this box, the settings on the Shipping tab are empty and available for editing.
		/// <para>DAC Field Name: LocationID</para>
		/// <para>DAC: PX.Objects.CR.CROpportunity</para>
		/// <para>Display Name: Account Location</para>
		/// </summary>
		/// <remarks>
		/// Also, the Location.BAccountID value must be equal tothe CROpportunity.BAccountID value of the current opportunity.
		/// </remarks>
		[DataMember(Name="Location", EmitDefaultValue=false)]
		public StringValue? Location { get; set; }

		/// <summary>
		/// <para>DAC Field Name: ManualTotalEntry</para>
		/// <para>DAC: PX.Objects.CR.CROpportunity</para>
		/// <para>Display Name: Manual Amount</para>
		/// </summary>
		[DataMember(Name="ManualAmount", EmitDefaultValue=false)]
		public BooleanValue? ManualAmount { get; set; }

		[DataMember(Name="MarginPct", EmitDefaultValue=false)]
		public DecimalValue? MarginPct { get; set; }

		/// <summary>
		/// The identifier of the opportunity.
		/// <para>DAC: PX.Objects.CR.CROpportunity</para>
		/// <para>Display Name: Opportunity ID</para>
		/// <para>SQL Type: nvarchar(15)</para>
		/// Key Field
		/// </summary>
		/// <remarks>
		/// This field depends on opportunityNumberingID.
		/// </remarks>
		[DataMember(Name="OpportunityID", EmitDefaultValue=false)]
		public StringValue? OpportunityID { get; set; }

		/// <summary>
		/// The subject or description of the opportunity.
		/// <para>DAC Field Name: Subject</para>
		/// <para>DAC: PX.Objects.CR.CROpportunity</para>
		/// <para>Display Name: Description</para>
		/// <para>SQL Type: nvarchar(255)</para>
		/// </summary>
		[DataMember(Name="OpportunityName", EmitDefaultValue=false)]
		public StringValue? OpportunityName { get; set; }

		/// <summary>
		/// Specifies whether the contactand address information of this opportunity differs fromthe contact and address informationof the business account associated with this opportunity.
		/// <para>DAC Field Name: AllowOverrideContactAddress</para>
		/// <para>DAC: PX.Objects.CR.CROpportunity</para>
		/// </summary>
		/// <remarks>
		/// The behavior is controlled by the ContactAddress graph extension derived from the CROpportunityContactAddressExt`1graph extension.
		/// </remarks>
		[DataMember(Name="Override", EmitDefaultValue=false)]
		public BooleanValue? Override { get; set; }

		/// <summary>
		/// The Contact responsible for the opportunity.
		/// <para>DAC Field Name: OwnerID</para>
		/// <para>DAC: PX.Objects.CR.CROpportunity</para>
		/// </summary>
		[DataMember(Name="Owner", EmitDefaultValue=false)]
		public StringValue? Owner { get; set; }

		/// <summary>
		/// <para>DAC Field Name: OwnerID_description</para>
		/// <para>DAC: PX.Objects.CR.CROpportunity</para>
		/// </summary>
		[DataMember(Name="OwnerEmployeeName", EmitDefaultValue=false)]
		public StringValue? OwnerEmployeeName { get; set; }

		/// <summary>
		/// The identifier of the parent business account.
		/// <para>DAC Field Name: ParentBAccountID</para>
		/// <para>DAC: PX.Objects.CR.CROpportunity</para>
		/// <para>Display Name: Parent Account</para>
		/// </summary>
		[DataMember(Name="ParentAccount", EmitDefaultValue=false)]
		public StringValue? ParentAccount { get; set; }

		/// <summary>
		/// <para>DAC: PX.Objects.CR.CROpportunityProbability</para>
		/// </summary>
		[DataMember(Name="Probability", EmitDefaultValue=false)]
		public IntValue? Probability { get; set; }

		[DataMember(Name="Products", EmitDefaultValue=false)]
		public List<OpportunityProduct>? Products { get; set; }

		/// <summary>
		/// The project with which the item is associated.
		/// <para>DAC Field Name: ProjectID</para>
		/// <para>DAC: PX.Objects.CR.CROpportunity</para>
		/// </summary>
		/// <remarks>
		/// The project that is specified in the Location object of the account location. The system uses the project when it creates a document, such as a sales order.
		/// </remarks>
		[DataMember(Name="Project", EmitDefaultValue=false)]
		public StringValue? Project { get; set; }

		/// <summary>
		/// The reason why the status of the opportunity has been changed.
		/// <para>DAC Field Name: Resolution</para>
		/// <para>DAC: PX.Objects.CR.CROpportunity</para>
		/// <para>SQL Type: char(2)</para>
		/// </summary>
		[DataMember(Name="Reason", EmitDefaultValue=false)]
		public StringValue? Reason { get; set; }

		[DataMember(Name="Relations", EmitDefaultValue=false)]
		public List<RelationDetail>? Relations { get; set; }

		/// <summary>
		/// The flag identified that the salesTerritoryID is filled automaticallybased on state and countryID or can be assigned manually.
		/// <para>DAC: PX.Objects.CR.CROpportunity</para>
		/// <para>Display Name: Override Territory</para>
		/// </summary>
		[DataMember(Name="OverrideSalesTerritory", EmitDefaultValue=false)]
		public BooleanValue? OverrideSalesTerritory { get; set; }

		/// <summary>
		/// The reference to salesTerritoryID. If overrideSalesTerritoryis false then it's filled automaticallybased on state and countryID otherwise it's assigned by user.
		/// <para>DAC: PX.Objects.CR.CROpportunity</para>
		/// <para>Display Name: Sales Territory</para>
		/// <para>SQL Type: nvarchar(15)</para>
		/// </summary>
		[DataMember(Name="SalesTerritoryID", EmitDefaultValue=false)]
		public StringValue? SalesTerritoryID { get; set; }

		/// <summary>
		/// <para>DAC: PX.Objects.CR.CROpportunity</para>
		/// <para>SQL Type: char(1)</para>
		/// </summary>
		[DataMember(Name="Source", EmitDefaultValue=false)]
		public StringValue? Source { get; set; }

		/// <summary>
		/// The marketing campaign that resulted in the creation of the opportunity.
		/// <para>DAC Field Name: CampaignSourceID</para>
		/// <para>DAC: PX.Objects.CR.CROpportunity</para>
		/// <para>Display Name: Source Campaign</para>
		/// <para>SQL Type: nvarchar(15)</para>
		/// </summary>
		[DataMember(Name="SourceCampaign", EmitDefaultValue=false)]
		public StringValue? SourceCampaign { get; set; }

		/// <summary>
		/// The current stage of the opportunity.
		/// <para>DAC Field Name: StageID</para>
		/// <para>DAC: PX.Objects.CR.CROpportunity</para>
		/// <para>SQL Type: varchar(2)</para>
		/// </summary>
		[DataMember(Name="Stage", EmitDefaultValue=false)]
		public StringValue? Stage { get; set; }

		[DataMember(Name="StageChangedDate", EmitDefaultValue=false)]
		public DateTimeValue? StageChangedDate { get; set; }

		/// <summary>
		/// The current status of the opportunity.
		/// <para>DAC: PX.Objects.CR.CROpportunity</para>
		/// <para>SQL Type: char(1)</para>
		/// </summary>
		[DataMember(Name="Status", EmitDefaultValue=false)]
		public StringSingleSelectValue? Status { get; set; }

		/// <summary>
		/// The subject or description of the opportunity.
		/// <para>DAC: PX.Objects.CR.CROpportunity</para>
		/// <para>Display Name: Description</para>
		/// <para>SQL Type: nvarchar(255)</para>
		/// </summary>
		[DataMember(Name="Subject", EmitDefaultValue=false)]
		public StringValue? Subject { get; set; }

		[DataMember(Name="TaxDetails", EmitDefaultValue=false)]
		public List<OpportunityTaxDetail>? TaxDetails { get; set; }

		/// <summary>
		/// The tax zone that applies to the bank transaction.
		/// <para>DAC Field Name: TaxZoneID</para>
		/// <para>DAC: PX.Objects.CR.CROpportunity</para>
		/// <para>Display Name: Tax Zone</para>
		/// <para>SQL Type: nvarchar(10)</para>
		/// </summary>
		[DataMember(Name="TaxZone", EmitDefaultValue=false)]
		public StringValue? TaxZone { get; set; }

		/// <summary>
		/// <para>DAC Field Name: CuryProductsAmount</para>
		/// <para>DAC: PX.Objects.CR.CROpportunity</para>
		/// </summary>
		[DataMember(Name="Total", EmitDefaultValue=false)]
		public DecimalValue? Total { get; set; }

		[DataMember(Name="BusinessAccountType", EmitDefaultValue=false)]
		public StringValue? BusinessAccountType { get; set; }

		/// <summary>
		/// <para>DAC Field Name: CuryWgtAmount</para>
		/// <para>DAC: PX.Objects.CR.CROpportunity</para>
		/// <para>Display Name: Weight Total</para>
		/// </summary>
		[DataMember(Name="WeightTotal", EmitDefaultValue=false)]
		public DecimalValue? WeightTotal { get; set; }

		/// <summary>
		/// <para>DAC Field Name: WorkgroupID_description</para>
		/// <para>DAC: PX.Objects.CR.CROpportunity</para>
		/// </summary>
		[DataMember(Name="WorkgroupDescription", EmitDefaultValue=false)]
		public StringValue? WorkgroupDescription { get; set; }

		/// <summary>
		/// The workgroup associated with the opportunity.
		/// <para>DAC: PX.Objects.CR.CROpportunity</para>
		/// <para>Display Name: Workgroup</para>
		/// </summary>
		[DataMember(Name="WorkgroupID", EmitDefaultValue=false)]
		public StringValue? WorkgroupID { get; set; }

		[DataMember(Name="LastModifiedDateTime", EmitDefaultValue=false)]
		public DateTimeValue? LastModifiedDateTime { get; set; }

		[DataMember(Name="NoteID", EmitDefaultValue=false)]
		public GuidValue? NoteID { get; set; }

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
			public const string Translations = "Translations";
			public const string Activities = "Activities";
			public const string ActivityOpportunityStatistics = "ActivityOpportunityStatistics";
			public const string ActivityQuoteStatistics = "ActivityQuoteStatistics";
			public const string Address = "Address";
			public const string Attributes = "Attributes";
			public const string ContactInformation = "ContactInformation";
			public const string Discounts = "Discounts";
			public const string Products = "Products";
			public const string Relations = "Relations";
			public const string TaxDetails = "TaxDetails";

			//Intentionally excluded
			//public const string All = "Files,Translations,Activities,ActivityOpportunityStatistics,ActivityQuoteStatistics,Address,Attributes,ContactInformation,Discounts,Products,Relations,TaxDetails";
		}
		public virtual string GetEndpointPath()
		{
			return "entity/Default/26.200.001";
		}
	}
}