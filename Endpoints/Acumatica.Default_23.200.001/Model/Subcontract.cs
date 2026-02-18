using System;
using System.Collections.Generic;

using Newtonsoft.Json;

using Acumatica.RESTClient.Client;
using Acumatica.RESTClient.ContractBasedApi;
using Acumatica.RESTClient.ContractBasedApi.Model;

namespace Acumatica.Default_23_200_001.Model
{
	/// <summary>
	/// Corresponds to the screen <c>SC301000</c> in the Acumatica ERP
	/// </summary>
	public class Subcontract : Entity, ITopLevelEntity
	{

		public StringValue? SubcontractNbr { get; set; }

		public StringValue? Status { get; set; }

		public DateTimeValue? Date { get; set; }

		public DateTimeValue? StartDate { get; set; }

		public StringValue? Description { get; set; }

		public StringValue? VendorID { get; set; }

		public StringValue? Location { get; set; }

		public StringValue? Owner { get; set; }

		public StringValue? CurrencyID { get; set; }

		public StringValue? BaseCurrencyID { get; set; }

		public DateTimeValue? CurrencyEffectiveDate { get; set; }

		public DecimalValue? CurrencyRate { get; set; }

		public StringValue? CurrencyRateTypeID { get; set; }

		public DecimalValue? CurrencyReciprocalRate { get; set; }

		public StringValue? VendorRef { get; set; }

		public DecimalValue? LineTotal { get; set; }

		public DecimalValue? DiscountTotal { get; set; }

		public DecimalValue? RetainageTotal { get; set; }

		public DecimalValue? SubcontractTotal { get; set; }

		public DecimalValue? TaxTotal { get; set; }

		public DecimalValue? ControlTotal { get; set; }

		public StringValue? Branch { get; set; }

		public StringValue? Terms { get; set; }

		public StringValue? VendorTaxZone { get; set; }

		public BooleanValue? ApplyRetainage { get; set; }

		public DecimalValue? RetainagePct { get; set; }

		public BooleanValue? DoNotEmail { get; set; }

		public BooleanValue? DoNotPrint { get; set; }

		public BooleanValue? Emailed { get; set; }

		public BooleanValue? Printed { get; set; }

		public DateTimeValue? LastModifiedDateTime { get; set; }

		public List<SubcontractDetail>? Details { get; set; }

		public List<SubcontractTaxDetail>? TaxDetails { get; set; }

		public SubcontractVendorAddressInfo? VendorAddressInfo { get; set; }

		public SubcontractVendorContactInfo? VendorContactInfo { get; set; }

		public static class Expand
		{
			public const string Files = "Files";
			public const string Translations = "Translations";
			public const string Details = "Details";
			public const string Details_Files = "Details/Files";
			public const string TaxDetails = "TaxDetails";
			public const string TaxDetails_Files = "TaxDetails/Files";
			public const string VendorAddressInfo = "VendorAddressInfo";
			public const string VendorContactInfo = "VendorContactInfo";

			//Intentionally excluded
			//public const string All = "Files,Translations,Details,Details/Files,TaxDetails,TaxDetails/Files,VendorAddressInfo,VendorContactInfo";
		}
		public virtual string GetEndpointPath()
		{
			return "entity/Default/23.200.001";
		}
	}
}