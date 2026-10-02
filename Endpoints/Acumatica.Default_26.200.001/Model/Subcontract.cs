using System;
using System.Collections.Generic;

using Newtonsoft.Json;

using Acumatica.RESTClient.Client;
using Acumatica.RESTClient.ContractBasedApi;
using Acumatica.RESTClient.ContractBasedApi.Model;

namespace Acumatica.Default_26_200_001.Model
{
	/// <summary>
	/// Corresponds to the screen <c>SC301000</c> in the Acumatica ERP
	/// </summary>
	public class Subcontract : Entity, ITopLevelEntity
	{

		#region Fields
		public StringValue? SubcontractNbr { get; set; }

		public StringSingleSelectValue? Status { get; set; }

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

		#endregion

		#region LinkedEntities
		public SubcontractVendorAddressInfo? VendorAddressInfo { get; set; }

		public SubcontractVendorContactInfo? VendorContactInfo { get; set; }

		#endregion

		#region Details
		public List<SubcontractDetail>? Details { get; set; }

		public List<SubcontractTaxDetail>? TaxDetails { get; set; }

		#endregion

		/// <summary>
		/// Names that can be passed in the <c>$expand</c> parameter.
		/// <para>This endpoint uses system contract 5, where a nested entity is expanded
		/// as <c>Parent($expand=Child)</c> rather than <c>Parent/Child</c>, so only the names
		/// that can be expanded directly on this entity are listed here. Use the nested
		/// entity's own <c>Expand</c> class for the inner names.</para>
		/// </summary>
		public static class Expand
		{
			public const string Files = "Files";
			public const string Translations = "Translations";
			public const string Details = "Details";
			public const string TaxDetails = "TaxDetails";
			public const string VendorAddressInfo = "VendorAddressInfo";
			public const string VendorContactInfo = "VendorContactInfo";

			//Intentionally excluded
			//public const string All = "Files,Translations,Details,TaxDetails,VendorAddressInfo,VendorContactInfo";
		}
		public virtual string GetEndpointPath()
		{
			return "entity/Default/26.200.001";
		}
	}
}