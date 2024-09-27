using System;
using System.Collections.Generic;
using System.Runtime.Serialization;

using Newtonsoft.Json;

using Acumatica.RESTClient.Client;
using Acumatica.RESTClient.ContractBasedApi;
using Acumatica.RESTClient.ContractBasedApi.Model;

namespace Acumatica.Default_24_200_001.Model
{
	[DataContract]
	public class AppFinancialSettings : Entity
	{

		/// <summary>
		/// DAC Field Name: BillCustomerID 
		/// DAC: PX.Objects.FS.FSServiceOrder 
		/// Display Name: Billing Customer 
		/// </summary>
		[DataMember(Name="BillingCustomer", EmitDefaultValue=false)]
		public StringValue? BillingCustomer { get; set; }

		[DataMember(Name="BillingCycle", EmitDefaultValue=false)]
		public StringValue? BillingCycle { get; set; }

		/// <summary>
		/// DAC Field Name: BillLocationID 
		/// DAC: PX.Objects.FS.FSServiceOrder 
		/// Display Name: Billing Location 
		/// </summary>
		[DataMember(Name="BillingLocation", EmitDefaultValue=false)]
		public StringValue? BillingLocation { get; set; }

		/// <summary>
		/// DAC Field Name: BranchID 
		/// DAC: PX.Objects.FS.FSServiceOrder 
		/// </summary>
		[DataMember(Name="Branch", EmitDefaultValue=false)]
		public StringValue? Branch { get; set; }

		/// <summary>
		/// DAC: PX.Objects.FS.FSServiceOrder 
		/// </summary>
		[DataMember(Name="Commissionable", EmitDefaultValue=false)]
		public BooleanValue? Commissionable { get; set; }

		/// <summary>
		/// DAC Field Name: TaxZoneID 
		/// DAC: PX.Objects.FS.FSAppointment 
		/// Display Name: Customer Tax Zone 
		/// SQL Type: nvarchar(10) 
		/// </summary>
		[DataMember(Name="CustomerTaxZone", EmitDefaultValue=false)]
		public StringValue? CustomerTaxZone { get; set; }

		/// <summary>
		/// DAC Field Name: BillingBy 
		/// DAC: PX.Objects.FS.FSServiceOrder 
		/// Display Name: Billing By 
		/// SQL Type: char(2) 
		/// </summary>
		[DataMember(Name="RunBillingFor", EmitDefaultValue=false)]
		public StringValue? RunBillingFor { get; set; }

		/// <summary>
		/// DAC Field Name: SalesPersonID 
		/// DAC: PX.Objects.FS.FSServiceOrder 
		/// </summary>
		[DataMember(Name="Salesperson", EmitDefaultValue=false)]
		public StringValue? Salesperson { get; set; }

		/// <summary>
		/// DAC Field Name: TaxCalcMode 
		/// DAC: PX.Objects.FS.FSAppointment 
		/// Display Name: Tax Calculation Mode 
		/// SQL Type: char(1) 
		/// </summary>
		[DataMember(Name="TaxCalculationMode", EmitDefaultValue=false)]
		public StringValue? TaxCalculationMode { get; set; }

	}
}