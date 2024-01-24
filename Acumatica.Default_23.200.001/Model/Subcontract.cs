using System;
using System.Collections.Generic;
using System.Runtime.Serialization;

using Newtonsoft.Json;

using Acumatica.RESTClient.Client;
using Acumatica.RESTClient.ContractBasedApi;
using Acumatica.RESTClient.ContractBasedApi.Model;

namespace Acumatica.Default_23_200_001.Model
{
	[DataContract]
	public class Subcontract : Entity, ITopLevelEntity
	{

		[DataMember(Name="SubcontractNbr", EmitDefaultValue=false)]
		public StringValue? SubcontractNbr { get; set; }

		[DataMember(Name="Status", EmitDefaultValue=false)]
		public StringValue? Status { get; set; }

		[DataMember(Name="Date", EmitDefaultValue=false)]
		public DateTimeValue? Date { get; set; }

		[DataMember(Name="StartDate", EmitDefaultValue=false)]
		public DateTimeValue? StartDate { get; set; }

		[DataMember(Name="Description", EmitDefaultValue=false)]
		public StringValue? Description { get; set; }

		[DataMember(Name="VendorID", EmitDefaultValue=false)]
		public StringValue? VendorID { get; set; }

		[DataMember(Name="Location", EmitDefaultValue=false)]
		public StringValue? Location { get; set; }

		[DataMember(Name="Owner", EmitDefaultValue=false)]
		public StringValue? Owner { get; set; }

		[DataMember(Name="CurrencyID", EmitDefaultValue=false)]
		public StringValue? CurrencyID { get; set; }

		[DataMember(Name="BaseCurrencyID", EmitDefaultValue=false)]
		public StringValue? BaseCurrencyID { get; set; }

		[DataMember(Name="CurrencyEffectiveDate", EmitDefaultValue=false)]
		public DateTimeValue? CurrencyEffectiveDate { get; set; }

		[DataMember(Name="CurrencyRate", EmitDefaultValue=false)]
		public DecimalValue? CurrencyRate { get; set; }

		[DataMember(Name="CurrencyRateTypeID", EmitDefaultValue=false)]
		public StringValue? CurrencyRateTypeID { get; set; }

		[DataMember(Name="CurrencyReciprocalRate", EmitDefaultValue=false)]
		public DecimalValue? CurrencyReciprocalRate { get; set; }

		[DataMember(Name="VendorRef", EmitDefaultValue=false)]
		public StringValue? VendorRef { get; set; }

		[DataMember(Name="LineTotal", EmitDefaultValue=false)]
		public DecimalValue? LineTotal { get; set; }

		[DataMember(Name="DiscountTotal", EmitDefaultValue=false)]
		public DecimalValue? DiscountTotal { get; set; }

		[DataMember(Name="RetainageTotal", EmitDefaultValue=false)]
		public DecimalValue? RetainageTotal { get; set; }

		[DataMember(Name="SubcontractTotal", EmitDefaultValue=false)]
		public DecimalValue? SubcontractTotal { get; set; }

		[DataMember(Name="TaxTotal", EmitDefaultValue=false)]
		public DecimalValue? TaxTotal { get; set; }

		[DataMember(Name="ControlTotal", EmitDefaultValue=false)]
		public DecimalValue? ControlTotal { get; set; }

		[DataMember(Name="Branch", EmitDefaultValue=false)]
		public StringValue? Branch { get; set; }

		[DataMember(Name="Terms", EmitDefaultValue=false)]
		public StringValue? Terms { get; set; }

		[DataMember(Name="VendorTaxZone", EmitDefaultValue=false)]
		public StringValue? VendorTaxZone { get; set; }

		[DataMember(Name="ApplyRetainage", EmitDefaultValue=false)]
		public BooleanValue? ApplyRetainage { get; set; }

		[DataMember(Name="RetainagePct", EmitDefaultValue=false)]
		public DecimalValue? RetainagePct { get; set; }

		[DataMember(Name="DoNotEmail", EmitDefaultValue=false)]
		public BooleanValue? DoNotEmail { get; set; }

		[DataMember(Name="DoNotPrint", EmitDefaultValue=false)]
		public BooleanValue? DoNotPrint { get; set; }

		[DataMember(Name="Emailed", EmitDefaultValue=false)]
		public BooleanValue? Emailed { get; set; }

		[DataMember(Name="Printed", EmitDefaultValue=false)]
		public BooleanValue? Printed { get; set; }

		[DataMember(Name="LastModifiedDateTime", EmitDefaultValue=false)]
		public DateTimeValue? LastModifiedDateTime { get; set; }

		[DataMember(Name="Details", EmitDefaultValue=false)]
		public List<SubcontractDetail>? Details { get; set; }

		[DataMember(Name="TaxDetails", EmitDefaultValue=false)]
		public List<SubcontractTaxDetail>? TaxDetails { get; set; }

		[DataMember(Name="VendorAddressInfo", EmitDefaultValue=false)]
		public SubcontractVendorAddressInfo? VendorAddressInfo { get; set; }

		[DataMember(Name="VendorContactInfo", EmitDefaultValue=false)]
		public SubcontractVendorContactInfo? VendorContactInfo { get; set; }

		public virtual string GetEndpointPath()
		{
			return "entity/Default/23.200.001";
		}
	}
}