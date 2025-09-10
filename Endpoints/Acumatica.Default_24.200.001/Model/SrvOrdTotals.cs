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
	public class SrvOrdTotals : Entity
	{

		/// <summary>
		/// DAC Field Name: CuryApptOrderTotal 
		/// DAC: PX.Objects.FS.FSServiceOrder 
		/// Display Name: Actual Billable Total 
		/// </summary>
		[DataMember(Name="AppointmentTotal", EmitDefaultValue=false)]
		public DecimalValue? AppointmentTotal { get; set; }

		/// <summary>
		/// DAC Field Name: CuryEffectiveBillableDocTotal 
		/// DAC: PX.Objects.FS.FSServiceOrder 
		/// Display Name: Invoice Total 
		/// </summary>
		[DataMember(Name="BillableTotal", EmitDefaultValue=false)]
		public DecimalValue? BillableTotal { get; set; }

		/// <summary>
		/// DAC Field Name: CuryEstimatedOrderTotal 
		/// DAC: PX.Objects.FS.FSServiceOrder 
		/// Display Name: Ext. Price Total 
		/// </summary>
		[DataMember(Name="EstimatedTotal", EmitDefaultValue=false)]
		public DecimalValue? EstimatedTotal { get; set; }

		/// <summary>
		/// DAC Field Name: CuryBillableOrderTotal 
		/// DAC: PX.Objects.FS.FSServiceOrder 
		/// Display Name: Estimated Billable Total 
		/// </summary>
		[DataMember(Name="LineTotal", EmitDefaultValue=false)]
		public DecimalValue? LineTotal { get; set; }

		/// <summary>
		/// DAC Field Name: SOPrepaymentApplied 
		/// DAC: PX.Objects.FS.FSServiceOrder 
		/// Display Name: Prepayment Applied 
		/// </summary>
		[DataMember(Name="PrepaymentApplied", EmitDefaultValue=false)]
		public DecimalValue? PrepaymentApplied { get; set; }

		/// <summary>
		/// DAC Field Name: SOPrepaymentReceived 
		/// DAC: PX.Objects.FS.FSServiceOrder 
		/// Display Name: Prepayment Received 
		/// </summary>
		[DataMember(Name="PrepaymentReceived", EmitDefaultValue=false)]
		public DecimalValue? PrepaymentReceived { get; set; }

		/// <summary>
		/// DAC Field Name: SOPrepaymentRemaining 
		/// DAC: PX.Objects.FS.FSServiceOrder 
		/// Display Name: Prepayment Remaining 
		/// </summary>
		[DataMember(Name="PrepaymentRemaining", EmitDefaultValue=false)]
		public DecimalValue? PrepaymentRemaining { get; set; }

		/// <summary>
		/// DAC Field Name: SOCuryBillableUnpaidBalanace 
		/// DAC: PX.Objects.FS.FSServiceOrder 
		/// Display Name: Service Order Billable Unpaid Balance 
		/// </summary>
		[DataMember(Name="ServiceOrderBillableUnpaidBalance", EmitDefaultValue=false)]
		public DecimalValue? ServiceOrderBillableUnpaidBalance { get; set; }

		/// <summary>
		/// DAC Field Name: CuryDocTotal 
		/// DAC: PX.Objects.FS.FSServiceOrder 
		/// Display Name: Estimated Total 
		/// </summary>
		[DataMember(Name="ServiceOrderTotal", EmitDefaultValue=false)]
		public DecimalValue? ServiceOrderTotal { get; set; }

		/// <summary>
		/// DAC Field Name: SOCuryUnpaidBalanace 
		/// DAC: PX.Objects.FS.FSServiceOrder 
		/// Display Name: Service Order Unpaid Balance 
		/// </summary>
		[DataMember(Name="ServiceOrderUnpaidBalance", EmitDefaultValue=false)]
		public DecimalValue? ServiceOrderUnpaidBalance { get; set; }

		/// <summary>
		/// DAC Field Name: CuryTaxTotal 
		/// DAC: PX.Objects.FS.FSServiceOrder 
		/// Display Name: Estimated Tax Total 
		/// </summary>
		[DataMember(Name="TaxTotal", EmitDefaultValue=false)]
		public DecimalValue? TaxTotal { get; set; }

		/// <summary>
		/// DAC Field Name: CuryVatExemptTotal 
		/// DAC: PX.Objects.FS.FSServiceOrder 
		/// Display Name: VAT Exempt Total 
		/// </summary>
		[DataMember(Name="VATExemptTotal", EmitDefaultValue=false)]
		public DecimalValue? VATExemptTotal { get; set; }

		/// <summary>
		/// DAC Field Name: CuryVatTaxableTotal 
		/// DAC: PX.Objects.FS.FSServiceOrder 
		/// Display Name: VAT Taxable Total 
		/// </summary>
		[DataMember(Name="VATTaxableTotal", EmitDefaultValue=false)]
		public DecimalValue? VATTaxableTotal { get; set; }

	}
}