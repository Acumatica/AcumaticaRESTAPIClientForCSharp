using System;
using System.Collections.Generic;
using System.Runtime.Serialization;

using Newtonsoft.Json;

using Acumatica.RESTClient.Client;
using Acumatica.RESTClient.ContractBasedApi;
using Acumatica.RESTClient.ContractBasedApi.Model;

namespace Acumatica.eCommerce_23_200_001.Model
{
	/// <summary>
	/// Corresponds to the screen SO303000 in the Acumatica ERP
	/// </summary>
	[DataContract]
	public class SalesInvoice : Acumatica.Default_23_200_001.Model.SalesInvoice, ITopLevelEntity
	{

		[DataMember(Name="BillToAddress", EmitDefaultValue=false)]
		public SalesInvoiceAddress? BillToAddress { get; set; }

		/// <summary>
		/// If set to true, indicates that the addressoverrides the default Address record, which isreferenced by CustomerAddressID. This field is the inverse of IsDefaultBillAddress.
		/// DAC Field Name: OverrideAddress 
		/// DAC: PX.Objects.AR.ARShippingAddress 
		/// Display Name: Override Address 
		/// </summary>
		[DataMember(Name="BillToAddressOverride", EmitDefaultValue=false)]
		public BooleanValue? BillToAddressOverride { get; set; }

		[DataMember(Name="BillToContact", EmitDefaultValue=false)]
		public SalesInvoiceDocContact? BillToContact { get; set; }

		/// <summary>
		/// If set to true, indicates that the contactoverrides the default Contact recordreferenced by the CustomerContactID field.
		/// DAC Field Name: OverrideContact 
		/// DAC: PX.Objects.AR.ARShippingContact 
		/// Display Name: Override Contact 
		/// </summary>
		[DataMember(Name="BillToContactOverride", EmitDefaultValue=false)]
		public BooleanValue? BillToContactOverride { get; set; }

		/// <summary>
		/// The date and time when the record was created.
		/// DAC Field Name: CreatedDateTime 
		/// DAC: PX.Objects.EP.EPApproval 
		/// Display Name: Assignment Date 
		/// </summary>
		[DataMember(Name="CreatedDate", EmitDefaultValue=false)]
		public DateTimeValue? CreatedDate { get; set; }

		[DataMember(Name="ExternalRef", EmitDefaultValue=false)]
		public StringValue? ExternalRef { get; set; }

		[DataMember(Name="LastModifiedDate", EmitDefaultValue=false)]
		public DateTimeValue? LastModifiedDate { get; set; }

		[DataMember(Name="ShipToAddress", EmitDefaultValue=false)]
		public SalesInvoiceAddress? ShipToAddress { get; set; }

		/// <summary>
		/// If set to true, indicates that the addressoverrides the default Address record, which isreferenced by CustomerAddressID. This field is the inverse of IsDefaultBillAddress.
		/// DAC Field Name: OverrideAddress 
		/// DAC: PX.Objects.AR.ARShippingAddress 
		/// Display Name: Override Address 
		/// </summary>
		[DataMember(Name="ShipToAddressOverride", EmitDefaultValue=false)]
		public BooleanValue? ShipToAddressOverride { get; set; }

		[DataMember(Name="ShipToContact", EmitDefaultValue=false)]
		public SalesInvoiceDocContact? ShipToContact { get; set; }

		/// <summary>
		/// If set to true, indicates that the contactoverrides the default Contact recordreferenced by the CustomerContactID field.
		/// DAC Field Name: OverrideContact 
		/// DAC: PX.Objects.AR.ARShippingContact 
		/// Display Name: Override Contact 
		/// </summary>
		[DataMember(Name="ShipToContactOverride", EmitDefaultValue=false)]
		public BooleanValue? ShipToContactOverride { get; set; }

		/// <summary>
		/// DAC: PX.Objects.AR.ARInvoice 
		/// Display Name: Tax Calculation Mode 
		/// SQL Type: char(1) 
		/// </summary>
		[DataMember(Name="TaxCalcMode", EmitDefaultValue=false)]
		public StringValue? TaxCalcMode { get; set; }

		public override string GetEndpointPath()
		{
			return "entity/eCommerce/23.200.001";
		}
	}
}