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
		/// 
		/// Display Name:
		/// DAC Field Name: CuryAmount 
		/// DAC: PX.Objects.CR.CROpportunity 
		/// </summary>
		/// <remarks>
		/// 
		/// </remarks>
		[DataMember(Name="Amount", EmitDefaultValue=false)]
		public DecimalValue? Amount { get; set; }

		[DataMember(Name="Attributes", EmitDefaultValue=false)]
		public List<AttributeValue>? Attributes { get; set; }

		/// <summary>
		/// 
		/// Display Name:
		/// DAC Field Name: BranchID 
		/// DAC: PX.Objects.CR.CROpportunity 
		/// </summary>
		/// <remarks>
		/// 
		/// </remarks>
		[DataMember(Name="Branch", EmitDefaultValue=false)]
		public StringValue? Branch { get; set; }

		/// <summary>
		/// 
		/// Display Name:
		/// DAC Field Name: BAccountID 
		/// DAC: PX.Objects.CR.CROpportunity 
		/// </summary>
		/// <remarks>
		/// 
		/// </remarks>
		[DataMember(Name="BusinessAccount", EmitDefaultValue=false)]
		public StringValue? BusinessAccount { get; set; }

		/// <summary>
		/// 
		/// Display Name:
		/// DAC Field Name: ClassID 
		/// DAC: PX.Objects.CR.CROpportunity 
		/// </summary>
		/// <remarks>
		/// 
		/// </remarks>
		[DataMember(Name="ClassID", EmitDefaultValue=false)]
		public StringValue? ClassID { get; set; }

		/// <summary>
		/// 
		/// Display Name:
		/// DAC Field Name: ContactID_description 
		/// DAC: PX.Objects.CR.CROpportunity 
		/// </summary>
		/// <remarks>
		/// 
		/// </remarks>
		[DataMember(Name="ContactDisplayName", EmitDefaultValue=false)]
		public StringValue? ContactDisplayName { get; set; }

		/// <summary>
		/// 
		/// Display Name:
		/// DAC Field Name: ContactID 
		/// DAC: PX.Objects.CR.CROpportunity 
		/// </summary>
		/// <remarks>
		/// 
		/// </remarks>
		[DataMember(Name="ContactID", EmitDefaultValue=false)]
		public IntValue? ContactID { get; set; }

		[DataMember(Name="ContactInformation", EmitDefaultValue=false)]
		public OpportunityContact? ContactInformation { get; set; }

		/// <summary>
		/// 
		/// Display Name:
		/// DAC Field Name: LeadID_description 
		/// DAC: PX.Objects.CR.CROpportunity 
		/// </summary>
		/// <remarks>
		/// 
		/// </remarks>
		[DataMember(Name="ConvertedLeadDisplayName", EmitDefaultValue=false)]
		public StringValue? ConvertedLeadDisplayName { get; set; }

		[DataMember(Name="ConvertedLeadID", EmitDefaultValue=false)]
		public IntValue? ConvertedLeadID { get; set; }

		/// <summary>
		/// 
		/// Display Name:
		/// DAC Field Name: CuryID 
		/// DAC: PX.Objects.CR.CROpportunity 
		/// </summary>
		/// <remarks>
		/// 
		/// </remarks>
		[DataMember(Name="CurrencyID", EmitDefaultValue=false)]
		public StringValue? CurrencyID { get; set; }

		/// <summary>
		/// 
		/// Display Name:
		/// DAC Field Name: CuryViewState 
		/// DAC: PX.Objects.CR.CROpportunity 
		/// </summary>
		/// <remarks>
		/// 
		/// </remarks>
		[DataMember(Name="CurrencyViewState", EmitDefaultValue=false)]
		public BooleanValue? CurrencyViewState { get; set; }

		/// <summary>
		/// 
		/// Display Name:
		/// DAC Field Name: Details 
		/// DAC: PX.Objects.CR.CROpportunity 
		/// </summary>
		/// <remarks>
		/// 
		/// </remarks>
		[DataMember(Name="Details", EmitDefaultValue=false)]
		public StringValue? Details { get; set; }

		/// <summary>
		/// 
		/// Display Name:
		/// DAC Field Name: CuryDiscTot 
		/// DAC: PX.Objects.CR.CROpportunity 
		/// </summary>
		/// <remarks>
		/// 
		/// </remarks>
		[DataMember(Name="Discount", EmitDefaultValue=false)]
		public DecimalValue? Discount { get; set; }

		[DataMember(Name="Discounts", EmitDefaultValue=false)]
		public List<OpportunityDiscount>? Discounts { get; set; }

		/// <summary>
		/// 
		/// Display Name:
		/// DAC Field Name: CloseDate 
		/// DAC: PX.Objects.CR.CROpportunity 
		/// </summary>
		/// <remarks>
		/// 
		/// </remarks>
		[DataMember(Name="Estimation", EmitDefaultValue=false)]
		public DateTimeValue? Estimation { get; set; }

		/// <summary>
		/// 
		/// Display Name:
		/// DAC Field Name: LocationID 
		/// DAC: PX.Objects.CR.CROpportunity 
		/// </summary>
		/// <remarks>
		/// 
		/// </remarks>
		[DataMember(Name="Location", EmitDefaultValue=false)]
		public StringValue? Location { get; set; }

		/// <summary>
		/// 
		/// Display Name:
		/// DAC Field Name: ManualTotalEntry 
		/// DAC: PX.Objects.CR.CROpportunity 
		/// </summary>
		/// <remarks>
		/// 
		/// </remarks>
		[DataMember(Name="ManualAmount", EmitDefaultValue=false)]
		public BooleanValue? ManualAmount { get; set; }

		/// <summary>
		/// 
		/// Display Name:
		/// DAC Field Name: OpportunityID 
		/// DAC: PX.Objects.CR.CROpportunity 
		/// </summary>
		/// <remarks>
		/// 
		/// </remarks>
		[DataMember(Name="OpportunityID", EmitDefaultValue=false)]
		public StringValue? OpportunityID { get; set; }

		/// <summary>
		/// 
		/// Display Name:
		/// DAC Field Name: AllowOverrideContactAddress 
		/// DAC: PX.Objects.CR.CROpportunity 
		/// </summary>
		/// <remarks>
		/// 
		/// </remarks>
		[DataMember(Name="Override", EmitDefaultValue=false)]
		public BooleanValue? Override { get; set; }

		/// <summary>
		/// 
		/// Display Name:
		/// DAC Field Name: OwnerID 
		/// DAC: PX.Objects.CR.CROpportunity 
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
		/// DAC: PX.Objects.CR.CROpportunity 
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
		/// DAC: PX.Objects.CR.CROpportunity 
		/// </summary>
		/// <remarks>
		/// 
		/// </remarks>
		[DataMember(Name="ParentAccount", EmitDefaultValue=false)]
		public StringValue? ParentAccount { get; set; }

		[DataMember(Name="Products", EmitDefaultValue=false)]
		public List<OpportunityProduct>? Products { get; set; }

		/// <summary>
		/// 
		/// Display Name:
		/// DAC Field Name: ProjectID 
		/// DAC: PX.Objects.CR.CROpportunity 
		/// </summary>
		/// <remarks>
		/// 
		/// </remarks>
		[DataMember(Name="Project", EmitDefaultValue=false)]
		public StringValue? Project { get; set; }

		/// <summary>
		/// 
		/// Display Name:
		/// DAC Field Name: Resolution 
		/// DAC: PX.Objects.CR.CROpportunity 
		/// </summary>
		/// <remarks>
		/// 
		/// </remarks>
		[DataMember(Name="Reason", EmitDefaultValue=false)]
		public StringValue? Reason { get; set; }

		[DataMember(Name="Relations", EmitDefaultValue=false)]
		public List<RelationDetail>? Relations { get; set; }

		/// <summary>
		/// 
		/// Display Name:
		/// DAC Field Name: Source 
		/// DAC: PX.Objects.CR.CROpportunity 
		/// </summary>
		/// <remarks>
		/// 
		/// </remarks>
		[DataMember(Name="Source", EmitDefaultValue=false)]
		public StringValue? Source { get; set; }

		/// <summary>
		/// 
		/// Display Name:
		/// DAC Field Name: CampaignSourceID 
		/// DAC: PX.Objects.CR.CROpportunity 
		/// </summary>
		/// <remarks>
		/// 
		/// </remarks>
		[DataMember(Name="SourceCampaign", EmitDefaultValue=false)]
		public StringValue? SourceCampaign { get; set; }

		/// <summary>
		/// 
		/// Display Name:
		/// DAC Field Name: StageID 
		/// DAC: PX.Objects.CR.CROpportunity 
		/// </summary>
		/// <remarks>
		/// 
		/// </remarks>
		[DataMember(Name="Stage", EmitDefaultValue=false)]
		public StringValue? Stage { get; set; }

		/// <summary>
		/// 
		/// Display Name:
		/// DAC Field Name: Status 
		/// DAC: PX.Objects.CR.CROpportunity 
		/// </summary>
		/// <remarks>
		/// 
		/// </remarks>
		[DataMember(Name="Status", EmitDefaultValue=false)]
		public StringValue? Status { get; set; }

		/// <summary>
		/// 
		/// Display Name:
		/// DAC Field Name: Subject 
		/// DAC: PX.Objects.CR.CROpportunity 
		/// </summary>
		/// <remarks>
		/// 
		/// </remarks>
		[DataMember(Name="Subject", EmitDefaultValue=false)]
		public StringValue? Subject { get; set; }

		[DataMember(Name="TaxDetails", EmitDefaultValue=false)]
		public List<OpportunityTaxDetail>? TaxDetails { get; set; }

		/// <summary>
		/// 
		/// Display Name:
		/// DAC Field Name: TaxZoneID 
		/// DAC: PX.Objects.CR.CROpportunity 
		/// </summary>
		/// <remarks>
		/// 
		/// </remarks>
		[DataMember(Name="TaxZone", EmitDefaultValue=false)]
		public StringValue? TaxZone { get; set; }

		/// <summary>
		/// 
		/// Display Name:
		/// DAC Field Name: CuryProductsAmount 
		/// DAC: PX.Objects.CR.CROpportunity 
		/// </summary>
		/// <remarks>
		/// 
		/// </remarks>
		[DataMember(Name="Total", EmitDefaultValue=false)]
		public DecimalValue? Total { get; set; }

		/// <summary>
		/// 
		/// Display Name:
		/// DAC Field Name: CuryWgtAmount 
		/// DAC: PX.Objects.CR.CROpportunity 
		/// </summary>
		/// <remarks>
		/// 
		/// </remarks>
		[DataMember(Name="WeightTotal", EmitDefaultValue=false)]
		public DecimalValue? WeightTotal { get; set; }

		/// <summary>
		/// 
		/// Display Name:
		/// DAC Field Name: WorkgroupID_description 
		/// DAC: PX.Objects.CR.CROpportunity 
		/// </summary>
		/// <remarks>
		/// 
		/// </remarks>
		[DataMember(Name="WorkgroupDescription", EmitDefaultValue=false)]
		public StringValue? WorkgroupDescription { get; set; }

		/// <summary>
		/// 
		/// Display Name:
		/// DAC Field Name: WorkgroupID 
		/// DAC: PX.Objects.CR.CROpportunity 
		/// </summary>
		/// <remarks>
		/// 
		/// </remarks>
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