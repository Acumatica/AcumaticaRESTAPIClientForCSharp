using System;
using System.Collections.Generic;

using Newtonsoft.Json;

using Acumatica.RESTClient.Client;
using Acumatica.RESTClient.ContractBasedApi;
using Acumatica.RESTClient.ContractBasedApi.Model;

namespace Acumatica.Default_23_200_001.Model
{
	public class AppTaxDetails : Entity
	{

		/// <summary>
		/// <para>DAC Field Name: RefNbr</para>
		/// <para>DAC: PX.Objects.FS.FSAppointment</para>
		/// <para>Display Name: Appointment Nbr.</para>
		/// <para>SQL Type: nvarchar(20)</para>
		/// Key Field
		/// </summary>
		public StringValue? AppointmentNbr { get; set; }

		/// <summary>
		/// <para>DAC Field Name: Tax__ExemptTax</para>
		/// <para>DAC: PX.Objects.FS.FSAppointmentTaxTran</para>
		/// </summary>
		public BooleanValue? IncludeinVATExemptTotal { get; set; }

		/// <summary>
		/// <para>DAC Field Name: Tax__PendingTax</para>
		/// <para>DAC: PX.Objects.FS.FSAppointmentTaxTran</para>
		/// </summary>
		public BooleanValue? PendingVAT { get; set; }

		public IntValue? RecordID { get; set; }

		/// <summary>
		/// <para>DAC Field Name: Tax__ReverseTax</para>
		/// <para>DAC: PX.Objects.FS.FSAppointmentTaxTran</para>
		/// </summary>
		public BooleanValue? ReverseVAT { get; set; }

		/// <summary>
		/// <para>DAC Field Name: SrvOrdType</para>
		/// <para>DAC: PX.Objects.FS.FSAppointment</para>
		/// <para>Display Name: Service Order Type</para>
		/// <para>SQL Type: char(4)</para>
		/// Key Field
		/// </summary>
		public StringValue? ServiceOrderType { get; set; }

		/// <summary>
		/// <para>DAC Field Name: Tax__StatisticalTax</para>
		/// <para>DAC: PX.Objects.FS.FSAppointmentTaxTran</para>
		/// </summary>
		public BooleanValue? StatisticalVAT { get; set; }

		/// <summary>
		/// <para>DAC Field Name: CuryTaxableAmt</para>
		/// <para>DAC: PX.Objects.FS.FSAppointmentTaxTran</para>
		/// <para>Display Name: Taxable Amount</para>
		/// </summary>
		public DecimalValue? TaxableAmount { get; set; }

		/// <summary>
		/// <para>DAC Field Name: CuryTaxAmt</para>
		/// <para>DAC: PX.Objects.FS.FSAppointmentTaxTran</para>
		/// <para>Display Name: Tax Amount</para>
		/// </summary>
		public DecimalValue? TaxAmount { get; set; }

		/// <summary>
		/// <para>DAC: PX.Objects.FS.FSAppointmentTaxTran</para>
		/// <para>Display Name: Tax ID</para>
		/// <para>SQL Type: nvarchar(60)</para>
		/// Key Field
		/// </summary>
		public StringValue? TaxID { get; set; }

		/// <summary>
		/// <para>DAC: PX.Objects.FS.FSAppointmentTaxTran</para>
		/// <para>Display Name: Tax Rate</para>
		/// </summary>
		public DecimalValue? TaxRate { get; set; }

		/// <summary>
		/// <para>DAC Field Name: Tax__TaxType</para>
		/// <para>DAC: PX.Objects.FS.FSAppointmentTaxTran</para>
		/// </summary>
		public StringValue? TaxType { get; set; }

	}
}