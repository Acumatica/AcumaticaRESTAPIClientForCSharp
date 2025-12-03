using System;
using System.Collections.Generic;
using System.Runtime.Serialization;

using Newtonsoft.Json;

using Acumatica.RESTClient.Client;
using Acumatica.RESTClient.ContractBasedApi;
using Acumatica.RESTClient.ContractBasedApi.Model;

namespace Acumatica.DeviceHub_23_200_001.Model
{
	[DataContract]
	public class PrintJob : Entity
	{

		/// <summary>
		/// The ID of the user who created the record.
		/// <para>DAC Field Name: CreatedByID</para>
		/// <para>DAC: PX.SM.SMPrintJob</para>
		/// <para>Display Name: Created By</para>
		/// </summary>
		[DataMember(Name="CreatedBy", EmitDefaultValue=false)]
		public StringValue? CreatedBy { get; set; }

		[DataMember(Name="CreationDateTime", EmitDefaultValue=false)]
		public DateTimeValue? CreationDateTime { get; set; }

		/// <summary>
		/// <para>DAC: PX.SM.SMPrintJob</para>
		/// <para>SQL Type: nvarchar(255)</para>
		/// </summary>
		[DataMember(Name="Description", EmitDefaultValue=false)]
		public StringValue? Description { get; set; }

		/// <summary>
		/// <para>DAC Field Name: DeviceHubID</para>
		/// <para>DAC: PX.SM.SMPrintJob</para>
		/// <para>Display Name: DeviceHub ID</para>
		/// <para>SQL Type: varchar(30)</para>
		/// </summary>
		[DataMember(Name="DeviceHub", EmitDefaultValue=false)]
		public StringValue? DeviceHub { get; set; }

		/// <summary>
		/// <para>DAC: PX.SM.SMPrintJob</para>
		/// <para>Display Name: Job ID</para>
		/// Key Field
		/// </summary>
		[DataMember(Name="JobID", EmitDefaultValue=false)]
		public IntValue? JobID { get; set; }

		[DataMember(Name="ModifiedDateTime", EmitDefaultValue=false)]
		public DateTimeValue? ModifiedDateTime { get; set; }

		/// <summary>
		/// <para>DAC: PX.SM.SMPrintJob</para>
		/// <para>Display Name: Number of Copies</para>
		/// </summary>
		[DataMember(Name="NumberOfCopies", EmitDefaultValue=false)]
		public IntValue? NumberOfCopies { get; set; }

		[DataMember(Name="Parameters", EmitDefaultValue=false)]
		public List<PrintJobParameter>? Parameters { get; set; }

		/// <summary>
		/// <para>DAC Field Name: PrinterName</para>
		/// <para>DAC: PX.SM.SMPrintJob</para>
		/// <para>SQL Type: varchar(20)</para>
		/// </summary>
		[DataMember(Name="Printer", EmitDefaultValue=false)]
		public StringValue? Printer { get; set; }

		/// <summary>
		/// <para>DAC: PX.SM.SMPrintJob</para>
		/// <para>Display Name: Report ID</para>
		/// <para>SQL Type: varchar(8)</para>
		/// </summary>
		[DataMember(Name="ReportID", EmitDefaultValue=false)]
		public StringValue? ReportID { get; set; }

		/// <summary>
		/// Specifies (if set to true) that a user has selected the record in the table on the form for processing.
		/// <para>DAC: PX.SM.SMPrintJob</para>
		/// </summary>
		[DataMember(Name="Selected", EmitDefaultValue=false)]
		public BooleanValue? Selected { get; set; }

		/// <summary>
		/// <para>DAC: PX.SM.SMPrintJob</para>
		/// <para>SQL Type: char(1)</para>
		/// </summary>
		[DataMember(Name="Status", EmitDefaultValue=false)]
		public StringValue? Status { get; set; }

	}
}