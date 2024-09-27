using System;
using System.Collections.Generic;
using System.Runtime.Serialization;

using Newtonsoft.Json;

using Acumatica.RESTClient.Client;
using Acumatica.RESTClient.ContractBasedApi;
using Acumatica.RESTClient.ContractBasedApi.Model;

namespace Acumatica.Default_23_200_001.Model
{
	[DataContract]
	public class AppOtherInformation : Entity
	{

		[DataMember(Name="BatchNbr", EmitDefaultValue=false)]
		public StringValue? BatchNbr { get; set; }

		/// <summary>
		/// DAC Field Name: LongDescr 
		/// DAC: PX.Objects.FS.FSAppointment 
		/// SQL Type: nvarchar(MAX) 
		/// </summary>
		[DataMember(Name="Description", EmitDefaultValue=false)]
		public StringValue? Description { get; set; }

		[DataMember(Name="DocumentType", EmitDefaultValue=false)]
		public StringValue? DocumentType { get; set; }

		[DataMember(Name="InvoiceNbr", EmitDefaultValue=false)]
		public StringValue? InvoiceNbr { get; set; }

		[DataMember(Name="IssueReferenceNbr", EmitDefaultValue=false)]
		public StringValue? IssueReferenceNbr { get; set; }

		/// <summary>
		/// DAC: PX.Objects.FS.FSSchedule 
		/// Display Name: Recurrence Description 
		/// SQL Type: varchar(MAX) 
		/// </summary>
		[DataMember(Name="RecurrenceDescription", EmitDefaultValue=false)]
		public StringValue? RecurrenceDescription { get; set; }

		[DataMember(Name="ReferenceNbr", EmitDefaultValue=false)]
		public StringValue? ReferenceNbr { get; set; }

		/// <summary>
		/// DAC: PX.Objects.FS.FSAppointment 
		/// Display Name: Route ID 
		/// </summary>
		[DataMember(Name="RouteID", EmitDefaultValue=false)]
		public StringValue? RouteID { get; set; }

		/// <summary>
		/// DAC Field Name: RouteDocumentID 
		/// DAC: PX.Objects.FS.FSAppointment 
		/// Display Name: Route Nbr. 
		/// </summary>
		[DataMember(Name="RouteNbr", EmitDefaultValue=false)]
		public StringValue? RouteNbr { get; set; }

		/// <summary>
		/// DAC Field Name: ScheduleID 
		/// DAC: PX.Objects.FS.FSAppointment 
		/// Display Name: Source Schedule ID 
		/// </summary>
		[DataMember(Name="SourceScheduleID", EmitDefaultValue=false)]
		public StringValue? SourceScheduleID { get; set; }

		/// <summary>
		/// DAC Field Name: ServiceContractID 
		/// DAC: PX.Objects.FS.FSAppointment 
		/// Display Name: Source Service Contract ID 
		/// </summary>
		[DataMember(Name="SourceServiceContractID", EmitDefaultValue=false)]
		public StringValue? SourceServiceContractID { get; set; }

	}
}