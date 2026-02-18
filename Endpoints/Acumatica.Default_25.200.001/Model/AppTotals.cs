using System;
using System.Collections.Generic;

using Newtonsoft.Json;

using Acumatica.RESTClient.Client;
using Acumatica.RESTClient.ContractBasedApi;
using Acumatica.RESTClient.ContractBasedApi.Model;

namespace Acumatica.Default_25_200_001.Model
{
	public class AppTotals : Entity
	{

		/// <summary>
		/// <para>DAC Field Name: CuryLineTotal</para>
		/// <para>DAC: PX.Objects.FS.FSAppointment</para>
		/// <para>Display Name: Ext. Price Total</para>
		/// </summary>
		public DecimalValue? ActualTotal { get; set; }

		/// <summary>
		/// <para>DAC Field Name: AppCompletedBillableTotal</para>
		/// <para>DAC: PX.Objects.FS.FSAppointment</para>
		/// <para>Display Name: Appointment Billable Total</para>
		/// </summary>
		public DecimalValue? AppointmentBillableTotal { get; set; }

		/// <summary>
		/// <para>DAC Field Name: CuryDocTotal</para>
		/// <para>DAC: PX.Objects.FS.FSAppointment</para>
		/// <para>Display Name: Invoice Total</para>
		/// </summary>
		public DecimalValue? AppointmentTotal { get; set; }

		/// <summary>
		/// <para>DAC Field Name: CuryLogBillableTranAmountTotal</para>
		/// <para>DAC: PX.Objects.FS.FSAppointment</para>
		/// <para>Display Name: Billable Labor Total</para>
		/// </summary>
		public DecimalValue? BillableLaborTotal { get; set; }

		/// <summary>
		/// <para>DAC Field Name: CuryEffectiveBillableDocTotal</para>
		/// <para>DAC: PX.Objects.FS.FSServiceOrder</para>
		/// <para>Display Name: Invoice Total</para>
		/// </summary>
		public DecimalValue? BillableTotal { get; set; }

		/// <summary>
		/// <para>DAC Field Name: CuryEstimatedLineTotal</para>
		/// <para>DAC: PX.Objects.FS.FSAppointment</para>
		/// <para>Display Name: Estimated Total</para>
		/// </summary>
		public DecimalValue? EstimatedTotal { get; set; }

		/// <summary>
		/// <para>DAC Field Name: CuryBillableLineTotal</para>
		/// <para>DAC: PX.Objects.FS.FSAppointment</para>
		/// <para>Display Name: Actual Billable Total</para>
		/// </summary>
		public DecimalValue? LineTotal { get; set; }

		/// <summary>
		/// <para>DAC Field Name: SOPrepaymentApplied</para>
		/// <para>DAC: PX.Objects.FS.FSServiceOrder</para>
		/// <para>Display Name: Prepayment Applied</para>
		/// </summary>
		public DecimalValue? PrepaymentApplied { get; set; }

		/// <summary>
		/// <para>DAC Field Name: SOPrepaymentReceived</para>
		/// <para>DAC: PX.Objects.FS.FSServiceOrder</para>
		/// <para>Display Name: Prepayment Received</para>
		/// </summary>
		public DecimalValue? PrepaymentReceived { get; set; }

		/// <summary>
		/// <para>DAC Field Name: SOPrepaymentRemaining</para>
		/// <para>DAC: PX.Objects.FS.FSServiceOrder</para>
		/// <para>Display Name: Prepayment Remaining</para>
		/// </summary>
		public DecimalValue? PrepaymentRemaining { get; set; }

		/// <summary>
		/// <para>DAC Field Name: SOCuryBillableUnpaidBalanace</para>
		/// <para>DAC: PX.Objects.FS.FSServiceOrder</para>
		/// <para>Display Name: Service Order Billable Unpaid Balance</para>
		/// </summary>
		public DecimalValue? ServiceOrderBillableUnpaidBalance { get; set; }

		/// <summary>
		/// <para>DAC Field Name: CuryDocTotal</para>
		/// <para>DAC: PX.Objects.FS.FSAppointment</para>
		/// <para>Display Name: Invoice Total</para>
		/// </summary>
		public DecimalValue? ServiceOrderTotal { get; set; }

		/// <summary>
		/// <para>DAC Field Name: SOCuryUnpaidBalanace</para>
		/// <para>DAC: PX.Objects.FS.FSServiceOrder</para>
		/// <para>Display Name: Service Order Unpaid Balance</para>
		/// </summary>
		public DecimalValue? ServiceOrderUnpaidBalance { get; set; }

		/// <summary>
		/// <para>DAC Field Name: CuryTaxTotal</para>
		/// <para>DAC: PX.Objects.FS.FSAppointment</para>
		/// <para>Display Name: Actual Tax Total</para>
		/// </summary>
		public DecimalValue? TaxTotal { get; set; }

		/// <summary>
		/// <para>DAC Field Name: CuryVatExemptTotal</para>
		/// <para>DAC: PX.Objects.FS.FSAppointment</para>
		/// <para>Display Name: VAT Exempt Total</para>
		/// </summary>
		public DecimalValue? VATExemptTotal { get; set; }

		/// <summary>
		/// <para>DAC Field Name: CuryVatTaxableTotal</para>
		/// <para>DAC: PX.Objects.FS.FSAppointment</para>
		/// <para>Display Name: VAT Taxable Total</para>
		/// </summary>
		public DecimalValue? VATTaxableTotal { get; set; }

	}
}