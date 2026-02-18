using System;
using System.Collections.Generic;

using Newtonsoft.Json;

using Acumatica.RESTClient.Client;
using Acumatica.RESTClient.ContractBasedApi;
using Acumatica.RESTClient.ContractBasedApi.Model;

namespace Acumatica.eCommerce_23_200_001.Model
{
	/// <summary>
	/// Corresponds to the screen <c>SO303000</c> in the Acumatica ERP
	/// </summary>
	public class SalesInvoice : Acumatica.Default_23_200_001.Model.SalesInvoice, ITopLevelEntity
	{

		public SalesInvoiceAddress? BillToAddress { get; set; }

		/// <summary>
		/// If set to true, indicates that the addressoverrides the default Address record, which isreferenced by CustomerAddressID. This field is the inverse of IsDefaultBillAddress.
		/// <para>DAC Field Name: OverrideAddress</para>
		/// <para>DAC: PX.Objects.AR.ARShippingAddress</para>
		/// <para>Display Name: Override Address</para>
		/// </summary>
		public BooleanValue? BillToAddressOverride { get; set; }

		public SalesInvoiceDocContact? BillToContact { get; set; }

		/// <summary>
		/// If set to true, indicates that the contactoverrides the default Contact recordreferenced by the CustomerContactID field.
		/// <para>DAC Field Name: OverrideContact</para>
		/// <para>DAC: PX.Objects.AR.ARShippingContact</para>
		/// <para>Display Name: Override Contact</para>
		/// </summary>
		public BooleanValue? BillToContactOverride { get; set; }

		/// <summary>
		/// The date and time when the record was created.
		/// <para>DAC Field Name: CreatedDateTime</para>
		/// <para>DAC: PX.Objects.EP.EPApproval</para>
		/// <para>Display Name: Assignment Date</para>
		/// </summary>
		public DateTimeValue? CreatedDate { get; set; }

		public StringValue? ExternalRef { get; set; }

		public DateTimeValue? LastModifiedDate { get; set; }

		public SalesInvoiceAddress? ShipToAddress { get; set; }

		/// <summary>
		/// If set to true, indicates that the addressoverrides the default Address record, which isreferenced by CustomerAddressID. This field is the inverse of IsDefaultBillAddress.
		/// <para>DAC Field Name: OverrideAddress</para>
		/// <para>DAC: PX.Objects.AR.ARShippingAddress</para>
		/// <para>Display Name: Override Address</para>
		/// </summary>
		public BooleanValue? ShipToAddressOverride { get; set; }

		public SalesInvoiceDocContact? ShipToContact { get; set; }

		/// <summary>
		/// If set to true, indicates that the contactoverrides the default Contact recordreferenced by the CustomerContactID field.
		/// <para>DAC Field Name: OverrideContact</para>
		/// <para>DAC: PX.Objects.AR.ARShippingContact</para>
		/// <para>Display Name: Override Contact</para>
		/// </summary>
		public BooleanValue? ShipToContactOverride { get; set; }

		/// <summary>
		/// <para>DAC: PX.Objects.AR.ARInvoice</para>
		/// <para>Display Name: Tax Calculation Mode</para>
		/// <para>SQL Type: char(1)</para>
		/// </summary>
		public StringValue? TaxCalcMode { get; set; }

		public override string GetEndpointPath()
		{
			return "entity/eCommerce/23.200.001";
		}
	}
}