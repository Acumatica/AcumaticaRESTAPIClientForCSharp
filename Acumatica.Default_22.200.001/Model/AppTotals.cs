using System;
using System.Collections.Generic;
using System.Runtime.Serialization;

using Newtonsoft.Json;

using Acumatica.RESTClient.Client;
using Acumatica.RESTClient.ContractBasedApi;
using Acumatica.RESTClient.ContractBasedApi.Model;

namespace Acumatica.Default_22_200_001.Model
{
	[DataContract]
	public class AppTotals : Entity
	{

		/// <summary>
		/// DAC Field Name: CuryLineTotal 
		/// DAC: PX.Objects.FS.FSAppointment 
		/// Display Name: Ext. Price Total 
		/// </summary>
		[DataMember(Name="ActualTotal", EmitDefaultValue=false)]
		public DecimalValue? ActualTotal { get; set; }

		/// <summary>
		/// DAC Field Name: AppCompletedBillableTotal 
		/// DAC: PX.Objects.FS.FSAppointment 
		/// Display Name: Appointment Billable Total 
		/// </summary>
		[DataMember(Name="AppointmentBillableTotal", EmitDefaultValue=false)]
		public DecimalValue? AppointmentBillableTotal { get; set; }

		/// <summary>
		/// DAC Field Name: CuryDocTotal 
		/// DAC: PX.Objects.FS.FSAppointment 
		/// Display Name: Invoice Total 
		/// </summary>
		[DataMember(Name="AppointmentTotal", EmitDefaultValue=false)]
		public DecimalValue? AppointmentTotal { get; set; }

		/// <summary>
		/// DAC Field Name: CuryLogBillableTranAmountTotal 
		/// DAC: PX.Objects.FS.FSAppointment 
		/// Display Name: Billable Labor Total 
		/// </summary>
		[DataMember(Name="BillableLaborTotal", EmitDefaultValue=false)]
		public DecimalValue? BillableLaborTotal { get; set; }

		/// <summary>
		/// DAC Field Name: CuryEffectiveBillableDocTotal 
		/// DAC: PX.Objects.FS.FSServiceOrder 
		/// Display Name: Invoice Total 
		/// </summary>
		[DataMember(Name="BillableTotal", EmitDefaultValue=false)]
		public DecimalValue? BillableTotal { get; set; }

		/// <summary>
		/// DAC Field Name: CuryEstimatedLineTotal 
		/// DAC: PX.Objects.FS.FSAppointment 
		/// Display Name: Estimated Total 
		/// </summary>
		[DataMember(Name="EstimatedTotal", EmitDefaultValue=false)]
		public DecimalValue? EstimatedTotal { get; set; }

		/// <summary>
		/// DAC Field Name: CuryBillableLineTotal 
		/// DAC: PX.Objects.FS.FSAppointment 
		/// Display Name: Actual Billable Total 
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
		/// DAC: PX.Objects.FS.FSAppointment 
		/// Display Name: Invoice Total 
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
		/// DAC: PX.Objects.FS.FSAppointment 
		/// Display Name: Actual Tax Total 
		/// </summary>
		[DataMember(Name="TaxTotal", EmitDefaultValue=false)]
		public DecimalValue? TaxTotal { get; set; }

		/// <summary>
		/// DAC Field Name: CuryVatExemptTotal 
		/// DAC: PX.Objects.FS.FSAppointment 
		/// Display Name: VAT Exempt Total 
		/// </summary>
		[DataMember(Name="VATExemptTotal", EmitDefaultValue=false)]
		public DecimalValue? VATExemptTotal { get; set; }

		/// <summary>
		/// DAC Field Name: CuryVatTaxableTotal 
		/// DAC: PX.Objects.FS.FSAppointment 
		/// Display Name: VAT Taxable Total 
		/// </summary>
		[DataMember(Name="VATTaxableTotal", EmitDefaultValue=false)]
		public DecimalValue? VATTaxableTotal { get; set; }

	}
}