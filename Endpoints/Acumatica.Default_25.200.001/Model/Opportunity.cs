using System;
using System.Collections.Generic;

using Newtonsoft.Json;

using Acumatica.RESTClient.Client;
using Acumatica.RESTClient.ContractBasedApi;
using Acumatica.RESTClient.ContractBasedApi.Model;

namespace Acumatica.Default_25_200_001.Model
{
	/// <summary>
	/// Corresponds to the screen <c>CR304000</c> in the Acumatica ERP
	/// <para>Key Fields: OpportunityID</para>
	/// </summary>
	public class Opportunity : Entity, ITopLevelEntity
	{

		public List<ActivityDetail>? Activities { get; set; }

		public Address? Address { get; set; }

		/// <summary>
		/// <para>DAC Field Name: CuryAmount</para>
		/// <para>DAC: PX.Objects.CR.CROpportunity</para>
		/// <para>Display Name: Detail Total</para>
		/// </summary>
		public DecimalValue? Amount { get; set; }

		public List<AttributeValue>? Attributes { get; set; }

		/// <summary>
		/// The identifier of the Branch that will be used to ship the goods to the customer.
		/// <para>DAC Field Name: BranchID</para>
		/// <para>DAC: PX.Objects.CR.CROpportunity</para>
		/// </summary>
		public StringValue? Branch { get; set; }

		/// <summary>
		/// The identifier of the related business account.
		/// <para>DAC Field Name: BAccountID</para>
		/// <para>DAC: PX.Objects.CR.CROpportunity</para>
		/// <para>Display Name: Business Account</para>
		/// </summary>
		public StringValue? BusinessAccount { get; set; }

		/// <summary>
		/// The identifier of the CROpportunityClass.
		/// <para>DAC: PX.Objects.CR.CROpportunity</para>
		/// <para>Display Name: Opportunity Class</para>
		/// <para>SQL Type: nvarchar(10)</para>
		/// </summary>
		public StringValue? ClassID { get; set; }

		/// <summary>
		/// <para>DAC Field Name: ContactID_description</para>
		/// <para>DAC: PX.Objects.CR.CROpportunity</para>
		/// </summary>
		public StringValue? ContactDisplayName { get; set; }

		/// <summary>
		/// The identifier of the Contact, the representative to be contacted about the opportunity.
		/// <para>DAC: PX.Objects.CR.CROpportunity</para>
		/// <para>Display Name: Contact</para>
		/// </summary>
		public IntValue? ContactID { get; set; }

		public OpportunityContact? ContactInformation { get; set; }

		/// <summary>
		/// <para>DAC Field Name: LeadID_description</para>
		/// <para>DAC: PX.Objects.CR.CROpportunity</para>
		/// </summary>
		public StringValue? ConvertedLeadDisplayName { get; set; }

		public IntValue? ConvertedLeadID { get; set; }

		/// <summary>
		/// The currency of the opportunity.
		/// <para>DAC Field Name: CuryID</para>
		/// <para>DAC: PX.Objects.CR.CROpportunity</para>
		/// <para>Display Name: Currency</para>
		/// <para>SQL Type: nvarchar(5)</para>
		/// </summary>
		public StringValue? CurrencyID { get; set; }

		/// <summary>
		/// <para>DAC Field Name: CuryViewState</para>
		/// <para>DAC: PX.Objects.CR.CROpportunity</para>
		/// </summary>
		public BooleanValue? CurrencyViewState { get; set; }

		/// <summary>
		/// The detailed description or any relevant notes of the opportunity
		/// <para>DAC: PX.Objects.CR.CROpportunity</para>
		/// <para>SQL Type: nvarchar(MAX)</para>
		/// </summary>
		public StringValue? Details { get; set; }

		/// <summary>
		/// The total discount of the document (in the currency of the document),which is calculated as the sum of all group, document of the opportunity(line discounts are not included).
		/// <para>DAC Field Name: CuryDiscTot</para>
		/// <para>DAC: PX.Objects.CR.CROpportunity</para>
		/// <para>Display Name: Document Discounts</para>
		/// </summary>
		public DecimalValue? Discount { get; set; }

		public List<OpportunityDiscount>? Discounts { get; set; }

		/// <summary>
		/// The estimated date of closing the deal.
		/// <para>DAC Field Name: CloseDate</para>
		/// <para>DAC: PX.Objects.CR.CROpportunity</para>
		/// <para>Display Name: Estimated Close Date</para>
		/// </summary>
		public DateTimeValue? Estimation { get; set; }

		/// <summary>
		/// The identifier of the default location Location object linked with the prospective or existing customer selected in the Business Account box.If no location is selected in this box, the settings on the Shipping tab are empty and available for editing.
		/// <para>DAC Field Name: LocationID</para>
		/// <para>DAC: PX.Objects.CR.CROpportunity</para>
		/// <para>Display Name: Account Location</para>
		/// </summary>
		/// <remarks>
		/// Also, the Location.BAccountID value must be equal tothe CROpportunity.BAccountID value of the current opportunity.
		/// </remarks>
		public StringValue? Location { get; set; }

		/// <summary>
		/// <para>DAC Field Name: ManualTotalEntry</para>
		/// <para>DAC: PX.Objects.CR.CROpportunity</para>
		/// <para>Display Name: Manual Amount</para>
		/// </summary>
		public BooleanValue? ManualAmount { get; set; }

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
		public StringValue? OpportunityID { get; set; }

		/// <summary>
		/// Specifies whether the contactand address information of this opportunity differs fromthe contact and address informationof the business account associated with this opportunity.
		/// <para>DAC Field Name: AllowOverrideContactAddress</para>
		/// <para>DAC: PX.Objects.CR.CROpportunity</para>
		/// </summary>
		/// <remarks>
		/// The behavior is controlled by the ContactAddress graph extension derived from the CROpportunityContactAddressExt`1graph extension.
		/// </remarks>
		public BooleanValue? Override { get; set; }

		/// <summary>
		/// The identifier of the user responsible for the current document.If the WorkgroupID is specified, only a user that belongsto the specified workgroup can be used.
		/// <para>DAC Field Name: OwnerID</para>
		/// <para>DAC: PX.Objects.CR.CROpportunity</para>
		/// </summary>
		public StringValue? Owner { get; set; }

		/// <summary>
		/// <para>DAC Field Name: OwnerID_description</para>
		/// <para>DAC: PX.Objects.CR.CROpportunity</para>
		/// </summary>
		public StringValue? OwnerEmployeeName { get; set; }

		/// <summary>
		/// The identifier of the parent business account.
		/// <para>DAC Field Name: ParentBAccountID</para>
		/// <para>DAC: PX.Objects.CR.CROpportunity</para>
		/// <para>Display Name: Parent Account</para>
		/// </summary>
		public StringValue? ParentAccount { get; set; }

		public List<OpportunityProduct>? Products { get; set; }

		/// <summary>
		/// The project with which the item is associated.
		/// <para>DAC Field Name: ProjectID</para>
		/// <para>DAC: PX.Objects.CR.CROpportunity</para>
		/// </summary>
		public StringValue? Project { get; set; }

		/// <summary>
		/// The reason why the status of the opportunity has been changed.
		/// <para>DAC Field Name: Resolution</para>
		/// <para>DAC: PX.Objects.CR.CROpportunity</para>
		/// <para>SQL Type: char(2)</para>
		/// </summary>
		public StringValue? Reason { get; set; }

		public List<RelationDetail>? Relations { get; set; }

		/// <summary>
		/// <para>DAC: PX.Objects.CR.CROpportunity</para>
		/// <para>SQL Type: char(1)</para>
		/// </summary>
		public StringValue? Source { get; set; }

		/// <summary>
		/// The marketing campaign that resulted in the creation of the opportunity.
		/// <para>DAC Field Name: CampaignSourceID</para>
		/// <para>DAC: PX.Objects.CR.CROpportunity</para>
		/// <para>Display Name: Source Campaign</para>
		/// <para>SQL Type: nvarchar(15)</para>
		/// </summary>
		public StringValue? SourceCampaign { get; set; }

		/// <summary>
		/// The current stage of the opportunity.
		/// <para>DAC Field Name: StageID</para>
		/// <para>DAC: PX.Objects.CR.CROpportunity</para>
		/// <para>SQL Type: varchar(2)</para>
		/// </summary>
		public StringValue? Stage { get; set; }

		/// <summary>
		/// The current status of the opportunity.
		/// <para>DAC: PX.Objects.CR.CROpportunity</para>
		/// <para>SQL Type: char(1)</para>
		/// </summary>
		public StringValue? Status { get; set; }

		/// <summary>
		/// The subject or description of the opportunity.
		/// <para>DAC: PX.Objects.CR.CROpportunity</para>
		/// <para>Display Name: Description</para>
		/// <para>SQL Type: nvarchar(255)</para>
		/// </summary>
		public StringValue? Subject { get; set; }

		public List<OpportunityTaxDetail>? TaxDetails { get; set; }

		/// <summary>
		/// The tax zone that applies to the bank transaction.
		/// <para>DAC Field Name: TaxZoneID</para>
		/// <para>DAC: PX.Objects.CR.CROpportunity</para>
		/// <para>Display Name: Tax Zone</para>
		/// <para>SQL Type: nvarchar(10)</para>
		/// </summary>
		public StringValue? TaxZone { get; set; }

		/// <summary>
		/// <para>DAC Field Name: CuryProductsAmount</para>
		/// <para>DAC: PX.Objects.CR.CROpportunity</para>
		/// </summary>
		public DecimalValue? Total { get; set; }

		/// <summary>
		/// <para>DAC Field Name: CuryWgtAmount</para>
		/// <para>DAC: PX.Objects.CR.CROpportunity</para>
		/// <para>Display Name: Weight Total</para>
		/// </summary>
		public DecimalValue? WeightTotal { get; set; }

		/// <summary>
		/// <para>DAC Field Name: WorkgroupID_description</para>
		/// <para>DAC: PX.Objects.CR.CROpportunity</para>
		/// </summary>
		public StringValue? WorkgroupDescription { get; set; }

		/// <summary>
		/// The workgroup associated with the opportunity.
		/// <para>DAC: PX.Objects.CR.CROpportunity</para>
		/// <para>Display Name: Workgroup</para>
		/// </summary>
		public StringValue? WorkgroupID { get; set; }

		public DateTimeValue? LastModifiedDateTime { get; set; }

		public GuidValue? NoteID { get; set; }

		public static class Expand
		{
			public const string Files = "Files";
			public const string Translations = "Translations";
			public const string Activities = "Activities";
			public const string Activities_Files = "Activities/Files";
			public const string Address = "Address";
			public const string Attributes = "Attributes";
			public const string ContactInformation = "ContactInformation";
			public const string Discounts = "Discounts";
			public const string Discounts_Files = "Discounts/Files";
			public const string Products = "Products";
			public const string Products_Files = "Products/Files";
			public const string Relations = "Relations";
			public const string Relations_Files = "Relations/Files";
			public const string TaxDetails = "TaxDetails";
			public const string TaxDetails_Files = "TaxDetails/Files";

			//Intentionally excluded
			//public const string All = "Files,Translations,Activities,Activities/Files,Address,Attributes,ContactInformation,Discounts,Discounts/Files,Products,Products/Files,Relations,Relations/Files,TaxDetails,TaxDetails/Files";
		}
		public virtual string GetEndpointPath()
		{
			return "entity/Default/25.200.001";
		}
	}
}