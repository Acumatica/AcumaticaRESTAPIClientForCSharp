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
	/// Corresponds to the screen CR303000 in the Acumatica ERP
	/// </summary>
	[DataContract]
	public class BusinessAccount : Entity, ITopLevelEntity
	{

		/// <summary>
		/// 
		/// Display Name:
		/// DAC Field Name: AcctReferenceNbr 
		/// DAC: PX.Objects.CR.BAccount 
		/// </summary>
		/// <remarks>
		/// 
		/// </remarks>
		[DataMember(Name="AccountRef", EmitDefaultValue=false)]
		public StringValue? AccountRef { get; set; }

		[DataMember(Name="Activities", EmitDefaultValue=false)]
		public List<ActivityDetail>? Activities { get; set; }

		[DataMember(Name="Attributes", EmitDefaultValue=false)]
		public List<AttributeValue>? Attributes { get; set; }

		/// <summary>
		/// 
		/// Display Name:
		/// DAC Field Name: AcctCD 
		/// DAC: PX.Objects.CR.BAccount 
		/// </summary>
		/// <remarks>
		/// 
		/// </remarks>
		[DataMember(Name="BusinessAccountID", EmitDefaultValue=false)]
		public StringValue? BusinessAccountID { get; set; }

		[DataMember(Name="Campaigns", EmitDefaultValue=false)]
		public List<CampaignDetail>? Campaigns { get; set; }

		[DataMember(Name="Cases", EmitDefaultValue=false)]
		public List<BusinessAccountCaseDetail>? Cases { get; set; }

		/// <summary>
		/// 
		/// Display Name:
		/// DAC Field Name: ClassID 
		/// DAC: PX.Objects.CR.BAccount 
		/// </summary>
		/// <remarks>
		/// 
		/// </remarks>
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
		/// 
		/// Display Name:
		/// DAC Field Name: LastIncomingActivityDate 
		/// DAC: PX.Objects.CR.CRActivityStatistics 
		/// </summary>
		/// <remarks>
		/// 
		/// </remarks>
		[DataMember(Name="LastIncomingActivity", EmitDefaultValue=false)]
		public DateTimeValue? LastIncomingActivity { get; set; }

		/// <summary>
		/// 
		/// Display Name:
		/// DAC Field Name: LastModifiedDateTime 
		/// DAC: PX.Objects.CR.Contact 
		/// </summary>
		/// <remarks>
		/// 
		/// </remarks>
		[DataMember(Name="LastModifiedDateTime", EmitDefaultValue=false)]
		public DateTimeValue? LastModifiedDateTime { get; set; }

		/// <summary>
		/// 
		/// Display Name:
		/// DAC Field Name: LastOutgoingActivityDate 
		/// DAC: PX.Objects.CR.CRActivityStatistics 
		/// </summary>
		/// <remarks>
		/// 
		/// </remarks>
		[DataMember(Name="LastOutgoingActivity", EmitDefaultValue=false)]
		public DateTimeValue? LastOutgoingActivity { get; set; }

		[DataMember(Name="Locations", EmitDefaultValue=false)]
		public List<BusinessAccountLocation>? Locations { get; set; }

		[DataMember(Name="MainAddress", EmitDefaultValue=false)]
		public Address? MainAddress { get; set; }

		/// <summary>
		/// 
		/// Display Name:
		/// DAC Field Name: IsValidated 
		/// DAC: PX.Objects.CR.Address 
		/// </summary>
		/// <remarks>
		/// 
		/// </remarks>
		[DataMember(Name="MainAddressValidated", EmitDefaultValue=false)]
		public BooleanValue? MainAddressValidated { get; set; }

		[DataMember(Name="MainContact", EmitDefaultValue=false)]
		public BusinessAccountMainContact? MainContact { get; set; }

		[DataMember(Name="MarketingLists", EmitDefaultValue=false)]
		public List<MarketingListDetail>? MarketingLists { get; set; }

		/// <summary>
		/// 
		/// Display Name:
		/// DAC Field Name: AcctName 
		/// DAC: PX.Objects.CR.BAccount 
		/// </summary>
		/// <remarks>
		/// 
		/// </remarks>
		[DataMember(Name="Name", EmitDefaultValue=false)]
		public StringValue? Name { get; set; }

		[DataMember(Name="Opportunities", EmitDefaultValue=false)]
		public List<BusinessAccountOpportunityDetail>? Opportunities { get; set; }

		[DataMember(Name="Orders", EmitDefaultValue=false)]
		public List<BusinessAccountOrder>? Orders { get; set; }

		/// <summary>
		/// 
		/// Display Name:
		/// DAC Field Name: OwnerID 
		/// DAC: PX.Objects.CR.BAccount 
		/// </summary>
		/// <remarks>
		/// 
		/// </remarks>
		[DataMember(Name="Owner", EmitDefaultValue=false)]
		public StringValue? Owner { get; set; }

		/// <summary>
		/// 
		/// Display Name:
		/// DAC Field Name: OwnerID_description 
		/// DAC: PX.Objects.CR.BAccount 
		/// </summary>
		/// <remarks>
		/// 
		/// </remarks>
		[DataMember(Name="OwnerEmployeeName", EmitDefaultValue=false)]
		public StringValue? OwnerEmployeeName { get; set; }

		/// <summary>
		/// 
		/// Display Name:
		/// DAC Field Name: ParentBAccountID 
		/// DAC: PX.Objects.CR.BAccount 
		/// </summary>
		/// <remarks>
		/// 
		/// </remarks>
		[DataMember(Name="ParentAccount", EmitDefaultValue=false)]
		public StringValue? ParentAccount { get; set; }

		[DataMember(Name="PrimaryContact", EmitDefaultValue=false)]
		public Contact? PrimaryContact { get; set; }

		[DataMember(Name="Relations", EmitDefaultValue=false)]
		public List<RelationDetail>? Relations { get; set; }

		[DataMember(Name="ShippingAddress", EmitDefaultValue=false)]
		public Address? ShippingAddress { get; set; }

		/// <summary>
		/// 
		/// Display Name:
		/// DAC Field Name: OverrideAddress 
		/// DAC: PX.Objects.CR.Standalone.Location 
		/// </summary>
		/// <remarks>
		/// 
		/// </remarks>
		[DataMember(Name="ShippingAddressOverride", EmitDefaultValue=false)]
		public BooleanValue? ShippingAddressOverride { get; set; }

		/// <summary>
		/// 
		/// Display Name:
		/// DAC Field Name: IsValidated 
		/// DAC: PX.Objects.CR.Address 
		/// </summary>
		/// <remarks>
		/// 
		/// </remarks>
		[DataMember(Name="ShippingAddressValidated", EmitDefaultValue=false)]
		public BooleanValue? ShippingAddressValidated { get; set; }

		[DataMember(Name="ShippingContact", EmitDefaultValue=false)]
		public BusinessAccountShippingContact? ShippingContact { get; set; }

		/// <summary>
		/// 
		/// Display Name:
		/// DAC Field Name: CampaignSourceID 
		/// DAC: PX.Objects.CR.BAccount 
		/// </summary>
		/// <remarks>
		/// 
		/// </remarks>
		[DataMember(Name="SourceCampaign", EmitDefaultValue=false)]
		public StringValue? SourceCampaign { get; set; }

		/// <summary>
		/// 
		/// Display Name:
		/// DAC Field Name: Status 
		/// DAC: PX.Objects.CR.BAccount 
		/// </summary>
		/// <remarks>
		/// 
		/// </remarks>
		[DataMember(Name="Status", EmitDefaultValue=false)]
		public StringValue? Status { get; set; }

		/// <summary>
		/// 
		/// Display Name:
		/// DAC Field Name: Type 
		/// DAC: PX.Objects.CR.BAccount 
		/// </summary>
		/// <remarks>
		/// 
		/// </remarks>
		[DataMember(Name="Type", EmitDefaultValue=false)]
		public StringValue? Type { get; set; }

		/// <summary>
		/// 
		/// Display Name:
		/// DAC Field Name: WorkgroupID 
		/// DAC: PX.Objects.CR.BAccount 
		/// </summary>
		/// <remarks>
		/// 
		/// </remarks>
		[DataMember(Name="Workgroup", EmitDefaultValue=false)]
		public StringValue? Workgroup { get; set; }

		/// <summary>
		/// 
		/// Display Name:
		/// DAC Field Name: WorkgroupID_description 
		/// DAC: PX.Objects.CR.BAccount 
		/// </summary>
		/// <remarks>
		/// 
		/// </remarks>
		[DataMember(Name="WorkgroupDescription", EmitDefaultValue=false)]
		public StringValue? WorkgroupDescription { get; set; }

		[DataMember(Name="NoteID", EmitDefaultValue=false)]
		public GuidValue? NoteID { get; set; }

		/// <summary>
		/// 
		/// Display Name:
		/// DAC Field Name: CuryID 
		/// DAC: PX.Objects.CR.BAccount 
		/// </summary>
		/// <remarks>
		/// 
		/// </remarks>
		[DataMember(Name="CurrencyID", EmitDefaultValue=false)]
		public StringValue? CurrencyID { get; set; }

		/// <summary>
		/// 
		/// Display Name:
		/// DAC Field Name: AllowOverrideCury 
		/// DAC: PX.Objects.CR.BAccount 
		/// </summary>
		/// <remarks>
		/// 
		/// </remarks>
		[DataMember(Name="EnableCurrencyOverride", EmitDefaultValue=false)]
		public BooleanValue? EnableCurrencyOverride { get; set; }

		public virtual string GetEndpointPath()
		{
			return "entity/Default/24.200.001";
		}
	}
}