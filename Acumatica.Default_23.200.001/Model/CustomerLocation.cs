using System;
using System.Collections.Generic;
using System.Runtime.Serialization;

using Newtonsoft.Json;

using Acumatica.RESTClient.Client;
using Acumatica.RESTClient.ContractBasedApi;
using Acumatica.RESTClient.ContractBasedApi.Model;

namespace Acumatica.Default_23_200_001.Model
{
	/// <summary>
	/// Corresponds to the screen AR303020 in the Acumatica ERP
	/// </summary>
	[DataContract]
	public class CustomerLocation : Entity, ITopLevelEntity
	{

		[DataMember(Name="Active", EmitDefaultValue=false)]
		public BooleanValue? Active { get; set; }

		/// <summary>
		/// 
		/// Display Name:
		/// DAC Field Name: OverrideAddress 
		/// DAC: PX.Objects.CR.Location 
		/// </summary>
		/// <remarks>
		/// 
		/// </remarks>
		[DataMember(Name="AddressOverride", EmitDefaultValue=false)]
		public BooleanValue? AddressOverride { get; set; }

		/// <summary>
		/// 
		/// Display Name:
		/// DAC Field Name: CCalendarID 
		/// DAC: PX.Objects.CR.Location 
		/// </summary>
		/// <remarks>
		/// 
		/// </remarks>
		[DataMember(Name="Calendar", EmitDefaultValue=false)]
		public StringValue? Calendar { get; set; }

		/// <summary>
		/// 
		/// Display Name:
		/// DAC Field Name: OverrideContact 
		/// DAC: PX.Objects.CR.Location 
		/// </summary>
		/// <remarks>
		/// 
		/// </remarks>
		[DataMember(Name="ContactOverride", EmitDefaultValue=false)]
		public BooleanValue? ContactOverride { get; set; }

		[DataMember(Name="CreatedDateTime", EmitDefaultValue=false)]
		public DateTimeValue? CreatedDateTime { get; set; }

		/// <summary>
		/// 
		/// Display Name:
		/// DAC Field Name: BAccountID 
		/// DAC: PX.Objects.CR.Location 
		/// </summary>
		/// <remarks>
		/// 
		/// </remarks>
		[DataMember(Name="Customer", EmitDefaultValue=false)]
		public StringValue? Customer { get; set; }

		/// <summary>
		/// 
		/// Display Name:
		/// DAC Field Name: IsDefault 
		/// DAC: PX.Objects.CR.Location 
		/// </summary>
		/// <remarks>
		/// 
		/// </remarks>
		[DataMember(Name="Default", EmitDefaultValue=false)]
		public BooleanValue? Default { get; set; }

		/// <summary>
		/// 
		/// Display Name:
		/// DAC Field Name: CDefProjectID 
		/// DAC: PX.Objects.CR.Location 
		/// </summary>
		/// <remarks>
		/// 
		/// </remarks>
		[DataMember(Name="DefaultProject", EmitDefaultValue=false)]
		public StringValue? DefaultProject { get; set; }

		/// <summary>
		/// 
		/// Display Name:
		/// DAC Field Name: CAvalaraCustomerUsageType 
		/// DAC: PX.Objects.CR.Location 
		/// </summary>
		/// <remarks>
		/// 
		/// </remarks>
		[DataMember(Name="EntityUsageType", EmitDefaultValue=false)]
		public StringValue? EntityUsageType { get; set; }

		/// <summary>
		/// 
		/// Display Name:
		/// DAC Field Name: CGroundCollect 
		/// DAC: PX.Objects.CR.Location 
		/// </summary>
		/// <remarks>
		/// 
		/// </remarks>
		[DataMember(Name="FedExGroundCollect", EmitDefaultValue=false)]
		public BooleanValue? FedExGroundCollect { get; set; }

		/// <summary>
		/// 
		/// Display Name:
		/// DAC Field Name: CFOBPointID 
		/// DAC: PX.Objects.CR.Location 
		/// </summary>
		/// <remarks>
		/// 
		/// </remarks>
		[DataMember(Name="FOBPoint", EmitDefaultValue=false)]
		public StringValue? FOBPoint { get; set; }

		/// <summary>
		/// 
		/// Display Name:
		/// DAC Field Name: CInsurance 
		/// DAC: PX.Objects.CR.Location 
		/// </summary>
		/// <remarks>
		/// 
		/// </remarks>
		[DataMember(Name="Insurance", EmitDefaultValue=false)]
		public BooleanValue? Insurance { get; set; }

		[DataMember(Name="LastModifiedDateTime", EmitDefaultValue=false)]
		public DateTimeValue? LastModifiedDateTime { get; set; }

		/// <summary>
		/// 
		/// Display Name:
		/// DAC Field Name: CLeadTime 
		/// DAC: PX.Objects.CR.Location 
		/// </summary>
		/// <remarks>
		/// 
		/// </remarks>
		[DataMember(Name="LeadTimeDays", EmitDefaultValue=false)]
		public ShortValue? LeadTimeDays { get; set; }

		[DataMember(Name="LocationContact", EmitDefaultValue=false)]
		public Contact? LocationContact { get; set; }

		/// <summary>
		/// 
		/// Display Name:
		/// DAC Field Name: LocationCD 
		/// DAC: PX.Objects.CR.Location 
		/// </summary>
		/// <remarks>
		/// 
		/// </remarks>
		[DataMember(Name="LocationID", EmitDefaultValue=false)]
		public StringValue? LocationID { get; set; }

		/// <summary>
		/// 
		/// Display Name:
		/// DAC Field Name: Descr 
		/// DAC: PX.Objects.CR.Location 
		/// </summary>
		/// <remarks>
		/// 
		/// </remarks>
		[DataMember(Name="LocationName", EmitDefaultValue=false)]
		public StringValue? LocationName { get; set; }

		/// <summary>
		/// 
		/// Display Name:
		/// DAC Field Name: COrderPriority 
		/// DAC: PX.Objects.CR.Location 
		/// </summary>
		/// <remarks>
		/// 
		/// </remarks>
		[DataMember(Name="OrderPriority", EmitDefaultValue=false)]
		public ShortValue? OrderPriority { get; set; }

		/// <summary>
		/// 
		/// Display Name:
		/// DAC Field Name: CPriceClassID 
		/// DAC: PX.Objects.CR.Location 
		/// </summary>
		/// <remarks>
		/// 
		/// </remarks>
		[DataMember(Name="PriceClass", EmitDefaultValue=false)]
		public StringValue? PriceClass { get; set; }

		/// <summary>
		/// 
		/// Display Name:
		/// DAC Field Name: CResedential 
		/// DAC: PX.Objects.CR.Location 
		/// </summary>
		/// <remarks>
		/// 
		/// </remarks>
		[DataMember(Name="ResidentialDelivery", EmitDefaultValue=false)]
		public BooleanValue? ResidentialDelivery { get; set; }

		[DataMember(Name="RoleAssignments", EmitDefaultValue=false)]
		public List<BCRoleAssignment>? RoleAssignments { get; set; }

		/// <summary>
		/// 
		/// Display Name:
		/// DAC Field Name: CSaturdayDelivery 
		/// DAC: PX.Objects.CR.Location 
		/// </summary>
		/// <remarks>
		/// 
		/// </remarks>
		[DataMember(Name="SaturdayDelivery", EmitDefaultValue=false)]
		public BooleanValue? SaturdayDelivery { get; set; }

		/// <summary>
		/// 
		/// Display Name:
		/// DAC Field Name: CBranchID 
		/// DAC: PX.Objects.CR.Location 
		/// </summary>
		/// <remarks>
		/// 
		/// </remarks>
		[DataMember(Name="ShippingBranch", EmitDefaultValue=false)]
		public StringValue? ShippingBranch { get; set; }

		/// <summary>
		/// 
		/// Display Name:
		/// DAC Field Name: CShipComplete 
		/// DAC: PX.Objects.CR.Location 
		/// </summary>
		/// <remarks>
		/// 
		/// </remarks>
		[DataMember(Name="ShippingRule", EmitDefaultValue=false)]
		public StringValue? ShippingRule { get; set; }

		/// <summary>
		/// 
		/// Display Name:
		/// DAC Field Name: CShipTermsID 
		/// DAC: PX.Objects.CR.Location 
		/// </summary>
		/// <remarks>
		/// 
		/// </remarks>
		[DataMember(Name="ShippingTerms", EmitDefaultValue=false)]
		public StringValue? ShippingTerms { get; set; }

		/// <summary>
		/// 
		/// Display Name:
		/// DAC Field Name: CShipZoneID 
		/// DAC: PX.Objects.CR.Location 
		/// </summary>
		/// <remarks>
		/// 
		/// </remarks>
		[DataMember(Name="ShippingZone", EmitDefaultValue=false)]
		public StringValue? ShippingZone { get; set; }

		/// <summary>
		/// 
		/// Display Name:
		/// DAC Field Name: CCarrierID 
		/// DAC: PX.Objects.CR.Location 
		/// </summary>
		/// <remarks>
		/// 
		/// </remarks>
		[DataMember(Name="ShipVia", EmitDefaultValue=false)]
		public StringValue? ShipVia { get; set; }

		/// <summary>
		/// 
		/// Display Name:
		/// DAC Field Name: Status 
		/// DAC: PX.Objects.CR.Location 
		/// </summary>
		/// <remarks>
		/// 
		/// </remarks>
		[DataMember(Name="Status", EmitDefaultValue=false)]
		public StringValue? Status { get; set; }

		/// <summary>
		/// 
		/// Display Name:
		/// DAC Field Name: CAvalaraExemptionNumber 
		/// DAC: PX.Objects.CR.Location 
		/// </summary>
		/// <remarks>
		/// 
		/// </remarks>
		[DataMember(Name="TaxExemptionNbr", EmitDefaultValue=false)]
		public StringValue? TaxExemptionNbr { get; set; }

		/// <summary>
		/// 
		/// Display Name:
		/// DAC Field Name: TaxRegistrationID 
		/// DAC: PX.Objects.CR.Location 
		/// </summary>
		/// <remarks>
		/// 
		/// </remarks>
		[DataMember(Name="TaxRegistrationID", EmitDefaultValue=false)]
		public StringValue? TaxRegistrationID { get; set; }

		/// <summary>
		/// 
		/// Display Name:
		/// DAC Field Name: CTaxZoneID 
		/// DAC: PX.Objects.CR.Location 
		/// </summary>
		/// <remarks>
		/// 
		/// </remarks>
		[DataMember(Name="TaxZone", EmitDefaultValue=false)]
		public StringValue? TaxZone { get; set; }

		/// <summary>
		/// 
		/// Display Name:
		/// DAC Field Name: CSiteID 
		/// DAC: PX.Objects.CR.Location 
		/// </summary>
		/// <remarks>
		/// 
		/// </remarks>
		[DataMember(Name="Warehouse", EmitDefaultValue=false)]
		public StringValue? Warehouse { get; set; }

		[DataMember(Name="NoteID", EmitDefaultValue=false)]
		public GuidValue? NoteID { get; set; }

		public virtual string GetEndpointPath()
		{
			return "entity/Default/23.200.001";
		}
	}
}