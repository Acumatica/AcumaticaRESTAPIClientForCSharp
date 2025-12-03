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
	public class AppTotals : Entity
	{

		/// <summary>
		/// <para>DAC Field Name: CuryLineTotal</para>
		/// <para>DAC: PX.Objects.FS.FSAppointment</para>
		/// <para>Display Name: Ext. Price Total</para>
		/// </summary>
		[DataMember(Name="ActualTotal", EmitDefaultValue=false)]
		public DecimalValue? ActualTotal { get; set; }

		/// <summary>
		/// <para>DAC Field Name: AppCompletedBillableTotal</para>
		/// <para>DAC: PX.Objects.FS.FSAppointment</para>
		/// <para>Display Name: Appointment Billable Total</para>
		/// </summary>
		[DataMember(Name="AppointmentBillableTotal", EmitDefaultValue=false)]
		public DecimalValue? AppointmentBillableTotal { get; set; }

		/// <summary>
		/// <para>DAC Field Name: CuryDocTotal</para>
		/// <para>DAC: PX.Objects.FS.FSAppointment</para>
		/// <para>Display Name: Invoice Total</para>
		/// </summary>
		[DataMember(Name="AppointmentTotal", EmitDefaultValue=false)]
		public DecimalValue? AppointmentTotal { get; set; }

		/// <summary>
		/// <para>DAC Field Name: CuryLogBillableTranAmountTotal</para>
		/// <para>DAC: PX.Objects.FS.FSAppointment</para>
		/// <para>Display Name: Billable Labor Total</para>
		/// </summary>
		[DataMember(Name="BillableLaborTotal", EmitDefaultValue=false)]
		public DecimalValue? BillableLaborTotal { get; set; }

		/// <summary>
		/// <para>DAC Field Name: CuryEffectiveBillableDocTotal</para>
		/// <para>DAC: PX.Objects.FS.FSServiceOrder</para>
		/// <para>Display Name: Invoice Total</para>
		/// </summary>
		[DataMember(Name="BillableTotal", EmitDefaultValue=false)]
		public DecimalValue? BillableTotal { get; set; }

		/// <summary>
		/// <para>DAC Field Name: CuryEstimatedLineTotal</para>
		/// <para>DAC: PX.Objects.FS.FSAppointment</para>
		/// <para>Display Name: Estimated Total</para>
		/// </summary>
		[DataMember(Name="EstimatedTotal", EmitDefaultValue=false)]
		public DecimalValue? EstimatedTotal { get; set; }

		/// <summary>
		/// <para>DAC Field Name: CuryBillableLineTotal</para>
		/// <para>DAC: PX.Objects.FS.FSAppointment</para>
		/// <para>Display Name: Actual Billable Total</para>
		/// </summary>
		[DataMember(Name="LineTotal", EmitDefaultValue=false)]
		public DecimalValue? LineTotal { get; set; }

		/// <summary>
		/// <para>DAC Field Name: SOPrepaymentApplied</para>
		/// <para>DAC: PX.Objects.FS.FSServiceOrder</para>
		/// <para>Display Name: Prepayment Applied</para>
		/// </summary>
		[DataMember(Name="PrepaymentApplied", EmitDefaultValue=false)]
		public DecimalValue? PrepaymentApplied { get; set; }

		/// <summary>
		/// <para>DAC Field Name: SOPrepaymentReceived</para>
		/// <para>DAC: PX.Objects.FS.FSServiceOrder</para>
		/// <para>Display Name: Prepayment Received</para>
		/// </summary>
		[DataMember(Name="PrepaymentReceived", EmitDefaultValue=false)]
		public DecimalValue? PrepaymentReceived { get; set; }

		/// <summary>
		/// <para>DAC Field Name: SOPrepaymentRemaining</para>
		/// <para>DAC: PX.Objects.FS.FSServiceOrder</para>
		/// <para>Display Name: Prepayment Remaining</para>
		/// </summary>
		[DataMember(Name="PrepaymentRemaining", EmitDefaultValue=false)]
		public DecimalValue? PrepaymentRemaining { get; set; }

		/// <summary>
		/// <para>DAC Field Name: SOCuryBillableUnpaidBalanace</para>
		/// <para>DAC: PX.Objects.FS.FSServiceOrder</para>
		/// <para>Display Name: Service Order Billable Unpaid Balance</para>
		/// </summary>
		[DataMember(Name="ServiceOrderBillableUnpaidBalance", EmitDefaultValue=false)]
		public DecimalValue? ServiceOrderBillableUnpaidBalance { get; set; }

		/// <summary>
		/// <para>DAC Field Name: CuryDocTotal</para>
		/// <para>DAC: PX.Objects.FS.FSAppointment</para>
		/// <para>Display Name: Invoice Total</para>
		/// </summary>
		[DataMember(Name="ServiceOrderTotal", EmitDefaultValue=false)]
		public DecimalValue? ServiceOrderTotal { get; set; }

		/// <summary>
		/// <para>DAC Field Name: SOCuryUnpaidBalanace</para>
		/// <para>DAC: PX.Objects.FS.FSServiceOrder</para>
		/// <para>Display Name: Service Order Unpaid Balance</para>
		/// </summary>
		[DataMember(Name="ServiceOrderUnpaidBalance", EmitDefaultValue=false)]
		public DecimalValue? ServiceOrderUnpaidBalance { get; set; }

		/// <summary>
		/// <para>DAC Field Name: CuryTaxTotal</para>
		/// <para>DAC: PX.Objects.FS.FSAppointment</para>
		/// <para>Display Name: Actual Tax Total</para>
		/// </summary>
		[DataMember(Name="TaxTotal", EmitDefaultValue=false)]
		public DecimalValue? TaxTotal { get; set; }

		/// <summary>
		/// <para>DAC Field Name: CuryVatExemptTotal</para>
		/// <para>DAC: PX.Objects.FS.FSAppointment</para>
		/// <para>Display Name: VAT Exempt Total</para>
		/// </summary>
		[DataMember(Name="VATExemptTotal", EmitDefaultValue=false)]
		public DecimalValue? VATExemptTotal { get; set; }

		/// <summary>
		/// <para>DAC Field Name: CuryVatTaxableTotal</para>
		/// <para>DAC: PX.Objects.FS.FSAppointment</para>
		/// <para>Display Name: VAT Taxable Total</para>
		/// </summary>
		[DataMember(Name="VATTaxableTotal", EmitDefaultValue=false)]
		public DecimalValue? VATTaxableTotal { get; set; }

	}
}