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
		/// 
		/// Display Name:
		/// DAC Field Name: BaseCuryID 
		/// DAC: {} 
		/// </summary>
		/// <remarks>
		/// 
		/// </remarks>
		[DataMember(Name="BaseCurrencyID", EmitDefaultValue=false)]
		public StringValue? BaseCurrencyID { get; set; }

		/// <summary>
		/// 
		/// Display Name:
		/// DAC Field Name: BranchID 
		/// DAC: PX.Objects.PO.POOrder 
		/// </summary>
		/// <remarks>
		/// 
		/// </remarks>
		[DataMember(Name="Branch", EmitDefaultValue=false)]
		public StringValue? Branch { get; set; }

		/// <summary>
		/// 
		/// Display Name:
		/// DAC Field Name: CuryControlTotal 
		/// DAC: PX.Objects.PO.POOrder 
		/// </summary>
		/// <remarks>
		/// 
		/// </remarks>
		[DataMember(Name="ControlTotal", EmitDefaultValue=false)]
		public DecimalValue? ControlTotal { get; set; }

		/// <summary>
		/// 
		/// Display Name:
		/// DAC Field Name: CuryID 
		/// DAC: PX.Objects.PO.POOrder 
		/// </summary>
		/// <remarks>
		/// 
		/// </remarks>
		[DataMember(Name="CurrencyID", EmitDefaultValue=false)]
		public StringValue? CurrencyID { get; set; }

		/// <summary>
		/// 
		/// Display Name:
		/// DAC Field Name: CuryEffDate 
		/// DAC: {} 
		/// </summary>
		/// <remarks>
		/// 
		/// </remarks>
		[DataMember(Name="CurrencyEffectiveDate", EmitDefaultValue=false)]
		public DateTimeValue? CurrencyEffectiveDate { get; set; }

		/// <summary>
		/// 
		/// Display Name:
		/// DAC Field Name: SampleCuryRate 
		/// DAC: {} 
		/// </summary>
		/// <remarks>
		/// 
		/// </remarks>
		[DataMember(Name="CurrencyRate", EmitDefaultValue=false)]
		public DecimalValue? CurrencyRate { get; set; }

		/// <summary>
		/// 
		/// Display Name:
		/// DAC Field Name: CuryRateTypeID 
		/// DAC: {} 
		/// </summary>
		/// <remarks>
		/// 
		/// </remarks>
		[DataMember(Name="CurrencyRateTypeID", EmitDefaultValue=false)]
		public StringValue? CurrencyRateTypeID { get; set; }

		/// <summary>
		/// 
		/// Display Name:
		/// DAC Field Name: SampleRecipRate 
		/// DAC: {} 
		/// </summary>
		/// <remarks>
		/// 
		/// </remarks>
		[DataMember(Name="CurrencyReciprocalRate", EmitDefaultValue=false)]
		public DecimalValue? CurrencyReciprocalRate { get; set; }

		/// <summary>
		/// 
		/// Display Name:
		/// DAC Field Name: OrderDate 
		/// DAC: PX.Objects.PO.POOrder 
		/// </summary>
		/// <remarks>
		/// 
		/// </remarks>
		[DataMember(Name="Date", EmitDefaultValue=false)]
		public DateTimeValue? Date { get; set; }

		/// <summary>
		/// 
		/// Display Name:
		/// DAC Field Name: OrderDesc 
		/// DAC: PX.Objects.PO.POOrder 
		/// </summary>
		/// <remarks>
		/// 
		/// </remarks>
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
		/// 
		/// Display Name:
		/// DAC Field Name: VendorLocationID 
		/// DAC: PX.Objects.PO.POOrder 
		/// </summary>
		/// <remarks>
		/// 
		/// </remarks>
		[DataMember(Name="Location", EmitDefaultValue=false)]
		public StringValue? Location { get; set; }

		/// <summary>
		/// 
		/// Display Name:
		/// DAC Field Name: OrderNbr 
		/// DAC: PX.Objects.PO.POOrder 
		/// </summary>
		/// <remarks>
		/// 
		/// </remarks>
		[DataMember(Name="OrderNbr", EmitDefaultValue=false)]
		public StringValue? OrderNbr { get; set; }

		/// <summary>
		/// 
		/// Display Name:
		/// DAC Field Name: CuryOrderTotal 
		/// DAC: PX.Objects.PO.POOrder 
		/// </summary>
		/// <remarks>
		/// 
		/// </remarks>
		[DataMember(Name="OrderTotal", EmitDefaultValue=false)]
		public DecimalValue? OrderTotal { get; set; }

		/// <summary>
		/// 
		/// Display Name:
		/// DAC Field Name: OwnerID 
		/// DAC: PX.Objects.PO.POOrder 
		/// </summary>
		/// <remarks>
		/// 
		/// </remarks>
		[DataMember(Name="Owner", EmitDefaultValue=false)]
		public StringValue? Owner { get; set; }

		/// <summary>
		/// 
		/// Display Name:
		/// DAC Field Name: ProjectID 
		/// DAC: PX.Objects.PO.POOrder 
		/// </summary>
		/// <remarks>
		/// 
		/// </remarks>
		[DataMember(Name="Project", EmitDefaultValue=false)]
		public StringValue? Project { get; set; }

		/// <summary>
		/// 
		/// Display Name:
		/// DAC Field Name: ExpectedDate 
		/// DAC: PX.Objects.PO.POOrder 
		/// </summary>
		/// <remarks>
		/// 
		/// </remarks>
		[DataMember(Name="PromisedOn", EmitDefaultValue=false)]
		public DateTimeValue? PromisedOn { get; set; }

		[DataMember(Name="ShippingInstructions", EmitDefaultValue=false)]
		public ShippingInstructions? ShippingInstructions { get; set; }

		/// <summary>
		/// 
		/// Display Name:
		/// DAC Field Name: Status 
		/// DAC: PX.Objects.PO.POOrder 
		/// </summary>
		/// <remarks>
		/// 
		/// </remarks>
		[DataMember(Name="Status", EmitDefaultValue=false)]
		public StringValue? Status { get; set; }

		[DataMember(Name="TaxDetails", EmitDefaultValue=false)]
		public List<PurchaseOrderTaxDetail>? TaxDetails { get; set; }

		/// <summary>
		/// 
		/// Display Name:
		/// DAC Field Name: CuryTaxTotal 
		/// DAC: PX.Objects.PO.POOrder 
		/// </summary>
		/// <remarks>
		/// 
		/// </remarks>
		[DataMember(Name="TaxTotal", EmitDefaultValue=false)]
		public DecimalValue? TaxTotal { get; set; }

		/// <summary>
		/// 
		/// Display Name:
		/// DAC Field Name: TermsID 
		/// DAC: PX.Objects.PO.POOrder 
		/// </summary>
		/// <remarks>
		/// 
		/// </remarks>
		[DataMember(Name="Terms", EmitDefaultValue=false)]
		public StringValue? Terms { get; set; }

		/// <summary>
		/// 
		/// Display Name:
		/// DAC Field Name: OrderType 
		/// DAC: PX.Objects.PO.POOrder 
		/// </summary>
		/// <remarks>
		/// 
		/// </remarks>
		[DataMember(Name="Type", EmitDefaultValue=false)]
		public StringValue? Type { get; set; }

		/// <summary>
		/// 
		/// Display Name:
		/// DAC Field Name: VendorID 
		/// DAC: PX.Objects.PO.POOrder 
		/// </summary>
		/// <remarks>
		/// 
		/// </remarks>
		[DataMember(Name="VendorID", EmitDefaultValue=false)]
		public StringValue? VendorID { get; set; }

		/// <summary>
		/// 
		/// Display Name:
		/// DAC Field Name: VendorRefNbr 
		/// DAC: PX.Objects.PO.POOrder 
		/// </summary>
		/// <remarks>
		/// 
		/// </remarks>
		[DataMember(Name="VendorRef", EmitDefaultValue=false)]
		public StringValue? VendorRef { get; set; }

		/// <summary>
		/// 
		/// Display Name:
		/// DAC Field Name: TaxZoneID 
		/// DAC: PX.Objects.PO.POOrder 
		/// </summary>
		/// <remarks>
		/// 
		/// </remarks>
		[DataMember(Name="VendorTaxZone", EmitDefaultValue=false)]
		public StringValue? VendorTaxZone { get; set; }

		public virtual string GetEndpointPath()
		{
			return "entity/Default/24.200.001";
		}
	}
}