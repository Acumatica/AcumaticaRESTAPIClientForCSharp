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
	/// Corresponds to the screen PO301000 in the Acumatica ERP
	/// </summary>
	[DataContract]
	public class PurchaseOrder : Entity, ITopLevelEntity
	{

		/// <summary>
		/// DAC Field Name: BaseCuryID 
		/// DAC: {} 
		/// </summary>
		[DataMember(Name="BaseCurrencyID", EmitDefaultValue=false)]
		public StringValue? BaseCurrencyID { get; set; }

		/// <summary>
		/// DAC Field Name: BranchID 
		/// DAC: PX.Objects.PO.POOrder 
		/// </summary>
		[DataMember(Name="Branch", EmitDefaultValue=false)]
		public StringValue? Branch { get; set; }

		/// <summary>
		/// DAC Field Name: CuryControlTotal 
		/// DAC: PX.Objects.PO.POOrder 
		/// Display Name: Control Total 
		/// </summary>
		[DataMember(Name="ControlTotal", EmitDefaultValue=false)]
		public DecimalValue? ControlTotal { get; set; }

		/// <summary>
		/// DAC Field Name: CuryID 
		/// DAC: PX.Objects.PO.POOrder 
		/// Display Name: Currency 
		/// SQL Type: nvarchar(5) 
		/// </summary>
		[DataMember(Name="CurrencyID", EmitDefaultValue=false)]
		public StringValue? CurrencyID { get; set; }

		/// <summary>
		/// DAC Field Name: CuryEffDate 
		/// DAC: {} 
		/// </summary>
		[DataMember(Name="CurrencyEffectiveDate", EmitDefaultValue=false)]
		public DateTimeValue? CurrencyEffectiveDate { get; set; }

		/// <summary>
		/// DAC Field Name: SampleCuryRate 
		/// DAC: {} 
		/// </summary>
		[DataMember(Name="CurrencyRate", EmitDefaultValue=false)]
		public DecimalValue? CurrencyRate { get; set; }

		/// <summary>
		/// DAC Field Name: CuryRateTypeID 
		/// DAC: {} 
		/// </summary>
		[DataMember(Name="CurrencyRateTypeID", EmitDefaultValue=false)]
		public StringValue? CurrencyRateTypeID { get; set; }

		/// <summary>
		/// DAC Field Name: SampleRecipRate 
		/// DAC: {} 
		/// </summary>
		[DataMember(Name="CurrencyReciprocalRate", EmitDefaultValue=false)]
		public DecimalValue? CurrencyReciprocalRate { get; set; }

		/// <summary>
		/// DAC Field Name: OrderDate 
		/// DAC: PX.Objects.PO.POOrder 
		/// </summary>
		[DataMember(Name="Date", EmitDefaultValue=false)]
		public DateTimeValue? Date { get; set; }

		/// <summary>
		/// DAC Field Name: OrderDesc 
		/// DAC: PX.Objects.PO.POOrder 
		/// SQL Type: nvarchar(60) 
		/// </summary>
		[DataMember(Name="Description", EmitDefaultValue=false)]
		public StringValue? Description { get; set; }

		[DataMember(Name="Details", EmitDefaultValue=false)]
		public List<PurchaseOrderDetail>? Details { get; set; }

		[DataMember(Name="Hold", EmitDefaultValue=false)]
		public BooleanValue? Hold { get; set; }

		[DataMember(Name="IsTaxValid", EmitDefaultValue=false)]
		public BooleanValue? IsTaxValid { get; set; }

		[DataMember(Name="LastModifiedDateTime", EmitDefaultValue=false)]
		public DateTimeValue? LastModifiedDateTime { get; set; }

		[DataMember(Name="LineTotal", EmitDefaultValue=false)]
		public DecimalValue? LineTotal { get; set; }

		/// <summary>
		/// DAC Field Name: VendorLocationID 
		/// DAC: PX.Objects.PO.POOrder 
		/// </summary>
		[DataMember(Name="Location", EmitDefaultValue=false)]
		public StringValue? Location { get; set; }

		/// <summary>
		/// DAC: PX.Objects.PO.POOrder 
		/// Display Name: Order Nbr. 
		/// SQL Type: nvarchar(15) 
		/// Key Field
		/// </summary>
		[DataMember(Name="OrderNbr", EmitDefaultValue=false)]
		public StringValue? OrderNbr { get; set; }

		/// <summary>
		/// DAC Field Name: CuryOrderTotal 
		/// DAC: PX.Objects.PO.POOrder 
		/// Display Name: Order Total 
		/// </summary>
		[DataMember(Name="OrderTotal", EmitDefaultValue=false)]
		public DecimalValue? OrderTotal { get; set; }

		/// <summary>
		/// DAC Field Name: OwnerID 
		/// DAC: PX.Objects.PO.POOrder 
		/// </summary>
		[DataMember(Name="Owner", EmitDefaultValue=false)]
		public StringValue? Owner { get; set; }

		/// <summary>
		/// DAC Field Name: ProjectID 
		/// DAC: PX.Objects.PO.POOrder 
		/// </summary>
		[DataMember(Name="Project", EmitDefaultValue=false)]
		public StringValue? Project { get; set; }

		/// <summary>
		/// DAC Field Name: ExpectedDate 
		/// DAC: PX.Objects.PO.POOrder 
		/// Display Name: Promised On 
		/// </summary>
		[DataMember(Name="PromisedOn", EmitDefaultValue=false)]
		public DateTimeValue? PromisedOn { get; set; }

		[DataMember(Name="ShippingInstructions", EmitDefaultValue=false)]
		public ShippingInstructions? ShippingInstructions { get; set; }

		/// <summary>
		/// DAC: PX.Objects.PO.POOrder 
		/// SQL Type: char(1) 
		/// </summary>
		[DataMember(Name="Status", EmitDefaultValue=false)]
		public StringValue? Status { get; set; }

		[DataMember(Name="TaxDetails", EmitDefaultValue=false)]
		public List<PurchaseOrderTaxDetail>? TaxDetails { get; set; }

		/// <summary>
		/// DAC Field Name: CuryTaxTotal 
		/// DAC: PX.Objects.PO.POOrder 
		/// Display Name: Tax Total 
		/// </summary>
		[DataMember(Name="TaxTotal", EmitDefaultValue=false)]
		public DecimalValue? TaxTotal { get; set; }

		/// <summary>
		/// DAC Field Name: TermsID 
		/// DAC: PX.Objects.PO.POOrder 
		/// SQL Type: nvarchar(10) 
		/// </summary>
		[DataMember(Name="Terms", EmitDefaultValue=false)]
		public StringValue? Terms { get; set; }

		/// <summary>
		/// DAC Field Name: OrderType 
		/// DAC: PX.Objects.PO.POOrder 
		/// SQL Type: char(2) 
		/// Key Field
		/// </summary>
		[DataMember(Name="Type", EmitDefaultValue=false)]
		public StringValue? Type { get; set; }

		/// <summary>
		/// DAC: PX.Objects.PO.POOrder 
		/// Display Name: Vendor 
		/// </summary>
		[DataMember(Name="VendorID", EmitDefaultValue=false)]
		public StringValue? VendorID { get; set; }

		/// <summary>
		/// DAC Field Name: VendorRefNbr 
		/// DAC: PX.Objects.PO.POOrder 
		/// Display Name: Vendor Ref. 
		/// SQL Type: nvarchar(40) 
		/// </summary>
		[DataMember(Name="VendorRef", EmitDefaultValue=false)]
		public StringValue? VendorRef { get; set; }

		/// <summary>
		/// DAC Field Name: TaxZoneID 
		/// DAC: PX.Objects.PO.POOrder 
		/// Display Name: Vendor Tax Zone 
		/// SQL Type: nvarchar(10) 
		/// </summary>
		[DataMember(Name="VendorTaxZone", EmitDefaultValue=false)]
		public StringValue? VendorTaxZone { get; set; }

		public virtual string GetEndpointPath()
		{
			return "entity/Default/24.200.001";
		}
	}
}