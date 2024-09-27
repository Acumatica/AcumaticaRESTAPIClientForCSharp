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
		/// DAC Field Name: CreatedByID 
		/// DAC: PX.SM.SMPrintJob 
		/// Display Name: Created By 
		/// </summary>
		[DataMember(Name="CreatedBy", EmitDefaultValue=false)]
		public StringValue? CreatedBy { get; set; }

		[DataMember(Name="CreationDateTime", EmitDefaultValue=false)]
		public DateTimeValue? CreationDateTime { get; set; }

		/// <summary>
		/// DAC: PX.SM.SMPrintJob 
		/// SQL Type: nvarchar(255) 
		/// </summary>
		[DataMember(Name="Description", EmitDefaultValue=false)]
		public StringValue? Description { get; set; }

		/// <summary>
		/// DAC Field Name: DeviceHubID 
		/// DAC: PX.SM.SMPrintJob 
		/// Display Name: DeviceHub ID 
		/// SQL Type: varchar(30) 
		/// </summary>
		[DataMember(Name="DeviceHub", EmitDefaultValue=false)]
		public StringValue? DeviceHub { get; set; }

		/// <summary>
		/// DAC: PX.SM.SMPrintJob 
		/// Display Name: Job ID 
		/// Key Field
		/// </summary>
		[DataMember(Name="JobID", EmitDefaultValue=false)]
		public IntValue? JobID { get; set; }

		[DataMember(Name="ModifiedDateTime", EmitDefaultValue=false)]
		public DateTimeValue? ModifiedDateTime { get; set; }

		/// <summary>
		/// DAC: PX.SM.SMPrintJob 
		/// Display Name: Number of Copies 
		/// </summary>
		[DataMember(Name="NumberOfCopies", EmitDefaultValue=false)]
		public IntValue? NumberOfCopies { get; set; }

		[DataMember(Name="Parameters", EmitDefaultValue=false)]
		public List<PrintJobParameter>? Parameters { get; set; }

		/// <summary>
		/// DAC Field Name: PrinterName 
		/// DAC: PX.SM.SMPrintJob 
		/// SQL Type: varchar(20) 
		/// </summary>
		[DataMember(Name="Printer", EmitDefaultValue=false)]
		public StringValue? Printer { get; set; }

		/// <summary>
		/// DAC: PX.SM.SMPrintJob 
		/// Display Name: Report ID 
		/// SQL Type: varchar(8) 
		/// </summary>
		[DataMember(Name="ReportID", EmitDefaultValue=false)]
		public StringValue? ReportID { get; set; }

		/// <summary>
		/// Specifies (if set to true) that a user has selected the record in the table on the form for processing.
		/// DAC: PX.SM.SMPrintJob 
		/// </summary>
		[DataMember(Name="Selected", EmitDefaultValue=false)]
		public BooleanValue? Selected { get; set; }

		/// <summary>
		/// DAC: PX.SM.SMPrintJob 
		/// SQL Type: char(1) 
		/// </summary>
		[DataMember(Name="Status", EmitDefaultValue=false)]
		public StringValue? Status { get; set; }

	}
}