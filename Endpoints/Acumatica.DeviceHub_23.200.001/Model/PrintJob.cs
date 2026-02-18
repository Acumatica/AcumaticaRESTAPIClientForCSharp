using System;
using System.Collections.Generic;

using Newtonsoft.Json;

using Acumatica.RESTClient.Client;
using Acumatica.RESTClient.ContractBasedApi;
using Acumatica.RESTClient.ContractBasedApi.Model;

namespace Acumatica.DeviceHub_23_200_001.Model
{
	public class PrintJob : Entity
	{

		/// <summary>
		/// The ID of the user who created the record.
		/// <para>DAC Field Name: CreatedByID</para>
		/// <para>DAC: PX.SM.SMPrintJob</para>
		/// <para>Display Name: Created By</para>
		/// </summary>
		public StringValue? CreatedBy { get; set; }

		public DateTimeValue? CreationDateTime { get; set; }

		/// <summary>
		/// <para>DAC: PX.SM.SMPrintJob</para>
		/// <para>SQL Type: nvarchar(255)</para>
		/// </summary>
		public StringValue? Description { get; set; }

		/// <summary>
		/// <para>DAC Field Name: DeviceHubID</para>
		/// <para>DAC: PX.SM.SMPrintJob</para>
		/// <para>Display Name: DeviceHub ID</para>
		/// <para>SQL Type: varchar(30)</para>
		/// </summary>
		public StringValue? DeviceHub { get; set; }

		/// <summary>
		/// <para>DAC: PX.SM.SMPrintJob</para>
		/// <para>Display Name: Job ID</para>
		/// Key Field
		/// </summary>
		public IntValue? JobID { get; set; }

		public DateTimeValue? ModifiedDateTime { get; set; }

		/// <summary>
		/// <para>DAC: PX.SM.SMPrintJob</para>
		/// <para>Display Name: Number of Copies</para>
		/// </summary>
		public IntValue? NumberOfCopies { get; set; }

		public List<PrintJobParameter>? Parameters { get; set; }

		/// <summary>
		/// <para>DAC Field Name: PrinterName</para>
		/// <para>DAC: PX.SM.SMPrintJob</para>
		/// <para>SQL Type: varchar(20)</para>
		/// </summary>
		public StringValue? Printer { get; set; }

		/// <summary>
		/// <para>DAC: PX.SM.SMPrintJob</para>
		/// <para>Display Name: Report ID</para>
		/// <para>SQL Type: varchar(8)</para>
		/// </summary>
		public StringValue? ReportID { get; set; }

		/// <summary>
		/// Specifies (if set to true) that a user has selected the record in the table on the form for processing.
		/// <para>DAC: PX.SM.SMPrintJob</para>
		/// </summary>
		public BooleanValue? Selected { get; set; }

		/// <summary>
		/// <para>DAC: PX.SM.SMPrintJob</para>
		/// <para>SQL Type: char(1)</para>
		/// </summary>
		public StringValue? Status { get; set; }

	}
}