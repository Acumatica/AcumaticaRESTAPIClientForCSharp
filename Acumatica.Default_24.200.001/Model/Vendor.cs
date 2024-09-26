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
	/// Corresponds to the screen AP303000 in the Acumatica ERP
	/// </summary>
	[DataContract]
	public class Vendor : Entity, ITopLevelEntity
	{

		/// <summary>
		/// 
		/// Display Name:
		/// DAC Field Name: AcctReferenceNbr 
		/// DAC: PX.Objects.AP.Vendor 
		/// </summary>
		/// <remarks>
		/// 
		/// </remarks>
		[DataMember(Name="AccountRef", EmitDefaultValue=false)]
		public StringValue? AccountRef { get; set; }

		/// <summary>
		/// 
		/// Display Name:
		/// DAC Field Name: VAPAccountID 
		/// DAC: PX.Objects.CR.Standalone.Location 
		/// </summary>
		/// <remarks>
		/// 
		/// </remarks>
		[DataMember(Name="APAccount", EmitDefaultValue=false)]
		public StringValue? APAccount { get; set; }

		/// <summary>
		/// 
		/// Display Name:
		/// DAC Field Name: VAPSubID 
		/// DAC: PX.Objects.CR.Standalone.Location 
		/// </summary>
		/// <remarks>
		/// 
		/// </remarks>
		[DataMember(Name="APSubaccount", EmitDefaultValue=false)]
		public StringValue? APSubaccount { get; set; }

		[DataMember(Name="Attributes", EmitDefaultValue=false)]
		public List<AttributeValue>? Attributes { get; set; }

		/// <summary>
		/// 
		/// Display Name:
		/// DAC Field Name: VCashAccountID 
		/// DAC: PX.Objects.CR.Standalone.Location 
		/// </summary>
		/// <remarks>
		/// 
		/// </remarks>
		[DataMember(Name="CashAccount", EmitDefaultValue=false)]
		public StringValue? CashAccount { get; set; }

		[DataMember(Name="Contacts", EmitDefaultValue=false)]
		public List<CustomerContact>? Contacts { get; set; }

		/// <summary>
		/// 
		/// Display Name:
		/// DAC Field Name: CreatedDateTime 
		/// DAC: PX.Objects.CR.Standalone.Location 
		/// </summary>
		/// <remarks>
		/// 
		/// </remarks>
		[DataMember(Name="CreatedDateTime", EmitDefaultValue=false)]
		public DateTimeValue? CreatedDateTime { get; set; }

		/// <summary>
		/// 
		/// Display Name:
		/// DAC Field Name: CuryID 
		/// DAC: PX.Objects.AP.Vendor 
		/// </summary>
		/// <remarks>
		/// 
		/// </remarks>
		[DataMember(Name="CurrencyID", EmitDefaultValue=false)]
		public StringValue? CurrencyID { get; set; }

		/// <summary>
		/// 
		/// Display Name:
		/// DAC Field Name: CuryRateTypeID 
		/// DAC: PX.Objects.AP.Vendor 
		/// </summary>
		/// <remarks>
		/// 
		/// </remarks>
		[DataMember(Name="CurrencyRateType", EmitDefaultValue=false)]
		public StringValue? CurrencyRateType { get; set; }

		/// <summary>
		/// 
		/// Display Name:
		/// DAC Field Name: AllowOverrideCury 
		/// DAC: PX.Objects.AP.Vendor 
		/// </summary>
		/// <remarks>
		/// 
		/// </remarks>
		[DataMember(Name="EnableCurrencyOverride", EmitDefaultValue=false)]
		public BooleanValue? EnableCurrencyOverride { get; set; }

		/// <summary>
		/// 
		/// Display Name:
		/// DAC Field Name: AllowOverrideRate 
		/// DAC: PX.Objects.AP.Vendor 
		/// </summary>
		/// <remarks>
		/// 
		/// </remarks>
		[DataMember(Name="EnableRateOverride", EmitDefaultValue=false)]
		public BooleanValue? EnableRateOverride { get; set; }

		/// <summary>
		/// 
		/// Display Name:
		/// DAC Field Name: Box1099 
		/// DAC: PX.Objects.AP.Vendor 
		/// </summary>
		/// <remarks>
		/// 
		/// </remarks>
		[DataMember(Name="F1099Box", EmitDefaultValue=false)]
		public StringValue? F1099Box { get; set; }

		/// <summary>
		/// 
		/// Display Name:
		/// DAC Field Name: Vendor1099 
		/// DAC: PX.Objects.AP.Vendor 
		/// </summary>
		/// <remarks>
		/// 
		/// </remarks>
		[DataMember(Name="F1099Vendor", EmitDefaultValue=false)]
		public BooleanValue? F1099Vendor { get; set; }

		/// <summary>
		/// 
		/// Display Name:
		/// DAC Field Name: FATCA 
		/// DAC: PX.Objects.AP.Vendor 
		/// </summary>
		/// <remarks>
		/// 
		/// </remarks>
		[DataMember(Name="FATCA", EmitDefaultValue=false)]
		public BooleanValue? FATCA { get; set; }

		/// <summary>
		/// 
		/// Display Name:
		/// DAC Field Name: VFOBPointID 
		/// DAC: PX.Objects.CR.Standalone.Location 
		/// </summary>
		/// <remarks>
		/// 
		/// </remarks>
		[DataMember(Name="FOBPoint", EmitDefaultValue=false)]
		public StringValue? FOBPoint { get; set; }

		/// <summary>
		/// 
		/// Display Name:
		/// DAC Field Name: ForeignEntity 
		/// DAC: PX.Objects.AP.Vendor 
		/// </summary>
		/// <remarks>
		/// 
		/// </remarks>
		[DataMember(Name="ForeignEntity", EmitDefaultValue=false)]
		public BooleanValue? ForeignEntity { get; set; }

		/// <summary>
		/// 
		/// Display Name:
		/// DAC Field Name: LandedCostVendor 
		/// DAC: PX.Objects.AP.Vendor 
		/// </summary>
		/// <remarks>
		/// 
		/// </remarks>
		[DataMember(Name="LandedCostVendor", EmitDefaultValue=false)]
		public BooleanValue? LandedCostVendor { get; set; }

		/// <summary>
		/// 
		/// Display Name:
		/// DAC Field Name: LastModifiedDateTime 
		/// DAC: PX.Objects.CR.Standalone.Location 
		/// </summary>
		/// <remarks>
		/// 
		/// </remarks>
		[DataMember(Name="LastModifiedDateTime", EmitDefaultValue=false)]
		public DateTimeValue? LastModifiedDateTime { get; set; }

		/// <summary>
		/// 
		/// Display Name:
		/// DAC Field Name: VLeadTime 
		/// DAC: PX.Objects.CR.Standalone.Location 
		/// </summary>
		/// <remarks>
		/// 
		/// </remarks>
		[DataMember(Name="LeadTimedays", EmitDefaultValue=false)]
		public ShortValue? LeadTimedays { get; set; }

		/// <summary>
		/// 
		/// Display Name:
		/// DAC Field Name: LegalName 
		/// DAC: PX.Objects.AP.Vendor 
		/// </summary>
		/// <remarks>
		/// 
		/// </remarks>
		[DataMember(Name="LegalName", EmitDefaultValue=false)]
		public StringValue? LegalName { get; set; }

		/// <summary>
		/// 
		/// Display Name:
		/// DAC Field Name: Descr 
		/// DAC: PX.Objects.CR.Standalone.Location 
		/// </summary>
		/// <remarks>
		/// 
		/// </remarks>
		[DataMember(Name="LocationName", EmitDefaultValue=false)]
		public StringValue? LocationName { get; set; }

		[DataMember(Name="MainContact", EmitDefaultValue=false)]
		public Contact? MainContact { get; set; }

		/// <summary>
		/// 
		/// Display Name:
		/// DAC Field Name: VRcptQtyMax 
		/// DAC: PX.Objects.CR.Standalone.Location 
		/// </summary>
		/// <remarks>
		/// 
		/// </remarks>
		[DataMember(Name="MaxReceipt", EmitDefaultValue=false)]
		public DecimalValue? MaxReceipt { get; set; }

		/// <summary>
		/// 
		/// Display Name:
		/// DAC Field Name: VRcptQtyMin 
		/// DAC: PX.Objects.CR.Standalone.Location 
		/// </summary>
		/// <remarks>
		/// 
		/// </remarks>
		[DataMember(Name="MinReceipt", EmitDefaultValue=false)]
		public DecimalValue? MinReceipt { get; set; }

		/// <summary>
		/// 
		/// Display Name:
		/// DAC Field Name: ParentBAccountID 
		/// DAC: PX.Objects.AP.Vendor 
		/// </summary>
		/// <remarks>
		/// 
		/// </remarks>
		[DataMember(Name="ParentAccount", EmitDefaultValue=false)]
		public StringValue? ParentAccount { get; set; }

		/// <summary>
		/// 
		/// Display Name:
		/// DAC Field Name: VPaymentByType 
		/// DAC: PX.Objects.CR.Standalone.Location 
		/// </summary>
		/// <remarks>
		/// 
		/// </remarks>
		[DataMember(Name="PaymentBy", EmitDefaultValue=false)]
		public StringValue? PaymentBy { get; set; }

		[DataMember(Name="PaymentInstructions", EmitDefaultValue=false)]
		public List<BusinessAccountPaymentInstructionDetail>? PaymentInstructions { get; set; }

		/// <summary>
		/// 
		/// Display Name:
		/// DAC Field Name: VPaymentLeadTime 
		/// DAC: PX.Objects.CR.Standalone.Location 
		/// </summary>
		/// <remarks>
		/// 
		/// </remarks>
		[DataMember(Name="PaymentLeadTimedays", EmitDefaultValue=false)]
		public ShortValue? PaymentLeadTimedays { get; set; }

		/// <summary>
		/// 
		/// Display Name:
		/// DAC Field Name: VPaymentMethodID 
		/// DAC: PX.Objects.CR.Standalone.Location 
		/// </summary>
		/// <remarks>
		/// 
		/// </remarks>
		[DataMember(Name="PaymentMethod", EmitDefaultValue=false)]
		public StringValue? PaymentMethod { get; set; }

		/// <summary>
		/// 
		/// Display Name:
		/// DAC Field Name: VSeparateCheck 
		/// DAC: PX.Objects.CR.Standalone.Location 
		/// </summary>
		/// <remarks>
		/// 
		/// </remarks>
		[DataMember(Name="PaySeparately", EmitDefaultValue=false)]
		public BooleanValue? PaySeparately { get; set; }

		[DataMember(Name="PrimaryContact", EmitDefaultValue=false)]
		public Contact? PrimaryContact { get; set; }

		/// <summary>
		/// 
		/// Display Name:
		/// DAC Field Name: VPrintOrder 
		/// DAC: PX.Objects.CR.Standalone.Location 
		/// </summary>
		/// <remarks>
		/// 
		/// </remarks>
		[DataMember(Name="PrintOrders", EmitDefaultValue=false)]
		public BooleanValue? PrintOrders { get; set; }

		/// <summary>
		/// 
		/// Display Name:
		/// DAC Field Name: VRcptQtyAction 
		/// DAC: PX.Objects.CR.Standalone.Location 
		/// </summary>
		/// <remarks>
		/// 
		/// </remarks>
		[DataMember(Name="ReceiptAction", EmitDefaultValue=false)]
		public StringValue? ReceiptAction { get; set; }

		/// <summary>
		/// 
		/// Display Name:
		/// DAC Field Name: VBranchID 
		/// DAC: PX.Objects.CR.Standalone.Location 
		/// </summary>
		/// <remarks>
		/// 
		/// </remarks>
		[DataMember(Name="ReceivingBranch", EmitDefaultValue=false)]
		public StringValue? ReceivingBranch { get; set; }

		/// <summary>
		/// 
		/// Display Name:
		/// DAC Field Name: OverrideRemitAddress 
		/// DAC: PX.Objects.CR.Standalone.Location 
		/// </summary>
		/// <remarks>
		/// 
		/// </remarks>
		[DataMember(Name="RemittanceAddressOverride", EmitDefaultValue=false)]
		public BooleanValue? RemittanceAddressOverride { get; set; }

		[DataMember(Name="RemittanceContact", EmitDefaultValue=false)]
		public Contact? RemittanceContact { get; set; }

		/// <summary>
		/// 
		/// Display Name:
		/// DAC Field Name: OverrideRemitContact 
		/// DAC: PX.Objects.CR.Standalone.Location 
		/// </summary>
		/// <remarks>
		/// 
		/// </remarks>
		[DataMember(Name="RemittanceContactOverride", EmitDefaultValue=false)]
		public BooleanValue? RemittanceContactOverride { get; set; }

		/// <summary>
		/// 
		/// Display Name:
		/// DAC Field Name: VEmailOrder 
		/// DAC: PX.Objects.CR.Standalone.Location 
		/// </summary>
		/// <remarks>
		/// 
		/// </remarks>
		[DataMember(Name="SendOrdersbyEmail", EmitDefaultValue=false)]
		public BooleanValue? SendOrdersbyEmail { get; set; }

		/// <summary>
		/// 
		/// Display Name:
		/// DAC Field Name: OverrideContact 
		/// DAC: PX.Objects.CR.Standalone.Location 
		/// </summary>
		/// <remarks>
		/// 
		/// </remarks>
		[DataMember(Name="ShippingContactOverride", EmitDefaultValue=false)]
		public BooleanValue? ShippingContactOverride { get; set; }

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

		[DataMember(Name="ShippingContact", EmitDefaultValue=false)]
		public Contact? ShippingContact { get; set; }

		/// <summary>
		/// 
		/// Display Name:
		/// DAC Field Name: VShipTermsID 
		/// DAC: PX.Objects.CR.Standalone.Location 
		/// </summary>
		/// <remarks>
		/// 
		/// </remarks>
		[DataMember(Name="ShippingTerms", EmitDefaultValue=false)]
		public StringValue? ShippingTerms { get; set; }

		/// <summary>
		/// 
		/// Display Name:
		/// DAC Field Name: VCarrierID 
		/// DAC: PX.Objects.CR.Standalone.Location 
		/// </summary>
		/// <remarks>
		/// 
		/// </remarks>
		[DataMember(Name="ShipVia", EmitDefaultValue=false)]
		public StringValue? ShipVia { get; set; }

		/// <summary>
		/// 
		/// Display Name:
		/// DAC Field Name: VStatus 
		/// DAC: PX.Objects.AP.VendorR 
		/// </summary>
		/// <remarks>
		/// 
		/// </remarks>
		[DataMember(Name="Status", EmitDefaultValue=false)]
		public StringValue? Status { get; set; }

		/// <summary>
		/// 
		/// Display Name:
		/// DAC Field Name: VTaxCalcMode 
		/// DAC: PX.Objects.CR.Standalone.Location 
		/// </summary>
		/// <remarks>
		/// 
		/// </remarks>
		[DataMember(Name="TaxCalculationMode", EmitDefaultValue=false)]
		public StringValue? TaxCalculationMode { get; set; }

		/// <summary>
		/// 
		/// Display Name:
		/// DAC Field Name: TaxRegistrationID 
		/// DAC: PX.Objects.CR.Standalone.Location 
		/// </summary>
		/// <remarks>
		/// 
		/// </remarks>
		[DataMember(Name="TaxRegistrationID", EmitDefaultValue=false)]
		public StringValue? TaxRegistrationID { get; set; }

		/// <summary>
		/// 
		/// Display Name:
		/// DAC Field Name: VTaxZoneID 
		/// DAC: PX.Objects.CR.Standalone.Location 
		/// </summary>
		/// <remarks>
		/// 
		/// </remarks>
		[DataMember(Name="TaxZone", EmitDefaultValue=false)]
		public StringValue? TaxZone { get; set; }

		/// <summary>
		/// 
		/// Display Name:
		/// DAC Field Name: TermsID 
		/// DAC: PX.Objects.AP.Vendor 
		/// </summary>
		/// <remarks>
		/// 
		/// </remarks>
		[DataMember(Name="Terms", EmitDefaultValue=false)]
		public StringValue? Terms { get; set; }

		/// <summary>
		/// 
		/// Display Name:
		/// DAC Field Name: VRcptQtyThreshold 
		/// DAC: PX.Objects.CR.Standalone.Location 
		/// </summary>
		/// <remarks>
		/// 
		/// </remarks>
		[DataMember(Name="ThresholdReceipt", EmitDefaultValue=false)]
		public DecimalValue? ThresholdReceipt { get; set; }

		/// <summary>
		/// 
		/// Display Name:
		/// DAC Field Name: VendorClassID 
		/// DAC: PX.Objects.AP.VendorR 
		/// </summary>
		/// <remarks>
		/// 
		/// </remarks>
		[DataMember(Name="VendorClass", EmitDefaultValue=false)]
		public StringValue? VendorClass { get; set; }

		/// <summary>
		/// 
		/// Display Name:
		/// DAC Field Name: AcctCD 
		/// DAC: PX.Objects.AP.VendorR 
		/// </summary>
		/// <remarks>
		/// 
		/// </remarks>
		[DataMember(Name="VendorID", EmitDefaultValue=false)]
		public StringValue? VendorID { get; set; }

		/// <summary>
		/// 
		/// Display Name:
		/// DAC Field Name: IsLaborUnion 
		/// DAC: PX.Objects.AP.Vendor 
		/// </summary>
		/// <remarks>
		/// 
		/// </remarks>
		[DataMember(Name="VendorIsLaborUnion", EmitDefaultValue=false)]
		public BooleanValue? VendorIsLaborUnion { get; set; }

		/// <summary>
		/// 
		/// Display Name:
		/// DAC Field Name: TaxAgency 
		/// DAC: PX.Objects.AP.Vendor 
		/// </summary>
		/// <remarks>
		/// 
		/// </remarks>
		[DataMember(Name="VendorIsTaxAgency", EmitDefaultValue=false)]
		public BooleanValue? VendorIsTaxAgency { get; set; }

		/// <summary>
		/// 
		/// Display Name:
		/// DAC Field Name: AcctName 
		/// DAC: PX.Objects.AP.VendorMaint+SuppliedByVendor 
		/// </summary>
		/// <remarks>
		/// 
		/// </remarks>
		[DataMember(Name="VendorName", EmitDefaultValue=false)]
		public StringValue? VendorName { get; set; }

		/// <summary>
		/// 
		/// Display Name:
		/// DAC Field Name: VSiteID 
		/// DAC: PX.Objects.CR.Standalone.Location 
		/// </summary>
		/// <remarks>
		/// 
		/// </remarks>
		[DataMember(Name="Warehouse", EmitDefaultValue=false)]
		public StringValue? Warehouse { get; set; }

		public virtual string GetEndpointPath()
		{
			return "entity/Default/24.200.001";
		}
	}
}