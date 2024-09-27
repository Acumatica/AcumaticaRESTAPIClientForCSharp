using System;
using System.Collections.Generic;
using System.Runtime.Serialization;

using Newtonsoft.Json;

using Acumatica.RESTClient.Client;
using Acumatica.RESTClient.ContractBasedApi;
using Acumatica.RESTClient.ContractBasedApi.Model;

namespace Acumatica.Default_22_200_001.Model
{
	/// <summary>
	/// Corresponds to the screen CR303000 in the Acumatica ERP
	/// </summary>
	[DataContract]
	public class BusinessAccount : Entity, ITopLevelEntity
	{

		/// <summary>
		/// The external reference number of the business account.
		/// DAC Field Name: AcctReferenceNbr 
		/// DAC: PX.Objects.CR.BAccount 
		/// Display Name: Ext Ref Nbr 
		/// SQL Type: nvarchar(50) 
		/// </summary>
		/// <remarks>
		/// It can be an additional number of the business account used in external integration.            
		/// </remarks>
		[DataMember(Name="AccountRef", EmitDefaultValue=false)]
		public StringValue? AccountRef { get; set; }

		[DataMember(Name="Activities", EmitDefaultValue=false)]
		public List<ActivityDetail>? Activities { get; set; }

		[DataMember(Name="Attributes", EmitDefaultValue=false)]
		public List<AttributeValue>? Attributes { get; set; }

		/// <summary>
		/// The human-readable identifier of the business account that isspecified by the user or defined by the auto-numbering sequence during thecreation of the account. This field is a natural key, as opposedto the surrogate key BAccountID.
		/// DAC Field Name: AcctCD 
		/// DAC: PX.Objects.CR.BAccount 
		/// Display Name: Account ID 
		/// SQL Type: nvarchar(30) 
		/// Key Field
		/// </summary>
		[DataMember(Name="BusinessAccountID", EmitDefaultValue=false)]
		public StringValue? BusinessAccountID { get; set; }

		[DataMember(Name="Campaigns", EmitDefaultValue=false)]
		public List<CampaignDetail>? Campaigns { get; set; }

		[DataMember(Name="Cases", EmitDefaultValue=false)]
		public List<BusinessAccountCaseDetail>? Cases { get; set; }

		/// <summary>
		/// Identifier of the business acccount class to which the business account belongs.
		/// DAC: PX.Objects.CR.BAccount 
		/// Display Name: Class 
		/// SQL Type: nvarchar(10) 
		/// </summary>
		[DataMember(Name="ClassID", EmitDefaultValue=false)]
		public StringValue? ClassID { get; set; }

		[DataMember(Name="Contacts", EmitDefaultValue=false)]
		public List<BusinessAccountContact>? Contacts { get; set; }

		[DataMember(Name="Contracts", EmitDefaultValue=false)]
		public List<BusinessAccountContract>? Contracts { get; set; }

		[DataMember(Name="DefaultLocationSettings", EmitDefaultValue=false)]
		public BusinessAccountDefaultLocationSetting? DefaultLocationSettings { get; set; }

		[DataMember(Name="Duplicate", EmitDefaultValue=false)]
		public StringValue? Duplicate { get; set; }

		[DataMember(Name="Duplicates", EmitDefaultValue=false)]
		public List<DuplicateDetail>? Duplicates { get; set; }

		/// <summary>
		/// DAC Field Name: LastIncomingActivityDate 
		/// DAC: PX.Objects.CR.CRActivityStatistics 
		/// Display Name: Last Incoming Activity 
		/// </summary>
		[DataMember(Name="LastIncomingActivity", EmitDefaultValue=false)]
		public DateTimeValue? LastIncomingActivity { get; set; }

		/// <summary>
		/// The date and time when the record was last modified.
		/// DAC: PX.Objects.CR.Contact 
		/// Display Name: Last Modified On 
		/// </summary>
		[DataMember(Name="LastModifiedDateTime", EmitDefaultValue=false)]
		public DateTimeValue? LastModifiedDateTime { get; set; }

		/// <summary>
		/// DAC Field Name: LastOutgoingActivityDate 
		/// DAC: PX.Objects.CR.CRActivityStatistics 
		/// Display Name: Last Outgoing Activity 
		/// </summary>
		[DataMember(Name="LastOutgoingActivity", EmitDefaultValue=false)]
		public DateTimeValue? LastOutgoingActivity { get; set; }

		[DataMember(Name="Locations", EmitDefaultValue=false)]
		public List<BusinessAccountLocation>? Locations { get; set; }

		[DataMember(Name="MainAddress", EmitDefaultValue=false)]
		public Address? MainAddress { get; set; }

		/// <summary>
		/// If set to true, this field indicates that the address has been successfully validated by Acumatica ERP.
		/// DAC Field Name: IsValidated 
		/// DAC: PX.Objects.CR.Address 
		/// Display Name: Validated 
		/// </summary>
		[DataMember(Name="MainAddressValidated", EmitDefaultValue=false)]
		public BooleanValue? MainAddressValidated { get; set; }

		[DataMember(Name="MainContact", EmitDefaultValue=false)]
		public BusinessAccountMainContact? MainContact { get; set; }

		[DataMember(Name="MarketingLists", EmitDefaultValue=false)]
		public List<MarketingListDetail>? MarketingLists { get; set; }

		/// <summary>
		/// The full business account name (as opposed to theshort identifier AcctCD).
		/// DAC Field Name: AcctName 
		/// DAC: PX.Objects.CR.BAccount 
		/// Display Name: Account Name 
		/// SQL Type: nvarchar(255) 
		/// </summary>
		[DataMember(Name="Name", EmitDefaultValue=false)]
		public StringValue? Name { get; set; }

		[DataMember(Name="Opportunities", EmitDefaultValue=false)]
		public List<BusinessAccountOpportunityDetail>? Opportunities { get; set; }

		[DataMember(Name="Orders", EmitDefaultValue=false)]
		public List<BusinessAccountOrder>? Orders { get; set; }

		/// <summary>
		/// The identifier of the user responsible for the current document.If the WorkgroupID is specified, only a user that belongsto the specified workgroup can be used.
		/// DAC Field Name: OwnerID 
		/// DAC: PX.Objects.CR.BAccount 
		/// </summary>
		[DataMember(Name="Owner", EmitDefaultValue=false)]
		public StringValue? Owner { get; set; }

		/// <summary>
		/// DAC Field Name: OwnerID_description 
		/// DAC: PX.Objects.CR.BAccount 
		/// </summary>
		[DataMember(Name="OwnerEmployeeName", EmitDefaultValue=false)]
		public StringValue? OwnerEmployeeName { get; set; }

		/// <summary>
		/// The identifier of the parent business account.
		/// DAC Field Name: ParentBAccountID 
		/// DAC: PX.Objects.CR.BAccount 
		/// Display Name: Parent Account 
		/// </summary>
		[DataMember(Name="ParentAccount", EmitDefaultValue=false)]
		public StringValue? ParentAccount { get; set; }

		[DataMember(Name="PrimaryContact", EmitDefaultValue=false)]
		public Contact? PrimaryContact { get; set; }

		[DataMember(Name="Relations", EmitDefaultValue=false)]
		public List<RelationDetail>? Relations { get; set; }

		[DataMember(Name="ShippingAddress", EmitDefaultValue=false)]
		public Address? ShippingAddress { get; set; }

		/// <summary>
		/// If set to true, indicates that the addressoverrides the default Address record, which isreferenced by DefAddressID.
		/// DAC Field Name: OverrideAddress 
		/// DAC: PX.Objects.CR.Standalone.Location 
		/// Display Name: Override 
		/// </summary>
		[DataMember(Name="ShippingAddressOverride", EmitDefaultValue=false)]
		public BooleanValue? ShippingAddressOverride { get; set; }

		/// <summary>
		/// If set to true, this field indicates that the address has been successfully validated by Acumatica ERP.
		/// DAC Field Name: IsValidated 
		/// DAC: PX.Objects.CR.Address 
		/// Display Name: Validated 
		/// </summary>
		[DataMember(Name="ShippingAddressValidated", EmitDefaultValue=false)]
		public BooleanValue? ShippingAddressValidated { get; set; }

		[DataMember(Name="ShippingContact", EmitDefaultValue=false)]
		public BusinessAccountShippingContact? ShippingContact { get; set; }

		/// <summary>
		/// The identifier of the marketing or sales campaign that resulted in creation of the business account.
		/// DAC Field Name: CampaignSourceID 
		/// DAC: PX.Objects.CR.BAccount 
		/// Display Name: Source Campaign 
		/// SQL Type: nvarchar(15) 
		/// </summary>
		[DataMember(Name="SourceCampaign", EmitDefaultValue=false)]
		public StringValue? SourceCampaign { get; set; }

		/// <summary>
		/// DAC: PX.Objects.CR.BAccount 
		/// Display Name: Customer Status 
		/// SQL Type: char(1) 
		/// </summary>
		[DataMember(Name="Status", EmitDefaultValue=false)]
		public StringValue? Status { get; set; }

		/// <summary>
		/// Represents the type of the business account.
		/// DAC: PX.Objects.CR.BAccount 
		/// SQL Type: char(2) 
		/// </summary>
		[DataMember(Name="Type", EmitDefaultValue=false)]
		public StringValue? Type { get; set; }

		/// <summary>
		/// The identifier of the workgroup responsible for the current document.
		/// DAC Field Name: WorkgroupID 
		/// DAC: PX.Objects.CR.BAccount 
		/// </summary>
		[DataMember(Name="Workgroup", EmitDefaultValue=false)]
		public StringValue? Workgroup { get; set; }

		/// <summary>
		/// DAC Field Name: WorkgroupID_description 
		/// DAC: PX.Objects.CR.BAccount 
		/// </summary>
		[DataMember(Name="WorkgroupDescription", EmitDefaultValue=false)]
		public StringValue? WorkgroupDescription { get; set; }

		[DataMember(Name="NoteID", EmitDefaultValue=false)]
		public GuidValue? NoteID { get; set; }

		/// <summary>
		/// The identifier of the Currency,which is applied to the documents of the business account.
		/// DAC Field Name: CuryID 
		/// DAC: PX.Objects.CR.BAccount 
		/// Display Name: Currency ID 
		/// SQL Type: nvarchar(5) 
		/// </summary>
		[DataMember(Name="CurrencyID", EmitDefaultValue=false)]
		public StringValue? CurrencyID { get; set; }

		/// <summary>
		/// If set to true, indicates that the currencyof business account documents (which is specified by CuryID)can be overridden by a user during document entry.
		/// DAC Field Name: AllowOverrideCury 
		/// DAC: PX.Objects.CR.BAccount 
		/// Display Name: Enable Currency Override 
		/// </summary>
		[DataMember(Name="EnableCurrencyOverride", EmitDefaultValue=false)]
		public BooleanValue? EnableCurrencyOverride { get; set; }

		/// <summary>
		/// The flag identified that the salesTerritoryID is filled automaticallybased on state and countryID or can be assigned manually.
		/// DAC: PX.Objects.CR.BAccount 
		/// Display Name: Override Territory 
		/// </summary>
		[DataMember(Name="OverrideSalesTerritory", EmitDefaultValue=false)]
		public BooleanValue? OverrideSalesTerritory { get; set; }

		/// <summary>
		/// The reference to salesTerritoryID. If overrideSalesTerritoryis false then it's filled automaticallybased on state and countryID otherwise it's assigned by user.
		/// DAC: PX.Objects.CR.BAccount 
		/// Display Name: Sales Territory ID 
		/// SQL Type: nvarchar(15) 
		/// </summary>
		[DataMember(Name="SalesTerritoryID", EmitDefaultValue=false)]
		public StringValue? SalesTerritoryID { get; set; }

		public virtual string GetEndpointPath()
		{
			return "entity/Default/22.200.001";
		}
	}
}