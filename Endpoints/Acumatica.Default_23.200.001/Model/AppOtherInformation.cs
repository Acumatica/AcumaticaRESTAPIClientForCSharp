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
		/// <para>DAC Field Name: LongDescr</para>
		/// <para>DAC: PX.Objects.FS.FSAppointment</para>
		/// <para>SQL Type: nvarchar(MAX)</para>
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
		/// <para>DAC: PX.Objects.FS.FSSchedule</para>
		/// <para>Display Name: Recurrence Description</para>
		/// <para>SQL Type: varchar(MAX)</para>
		/// </summary>
		[DataMember(Name="RecurrenceDescription", EmitDefaultValue=false)]
		public StringValue? RecurrenceDescription { get; set; }

		[DataMember(Name="ReferenceNbr", EmitDefaultValue=false)]
		public StringValue? ReferenceNbr { get; set; }

		/// <summary>
		/// <para>DAC: PX.Objects.FS.FSAppointment</para>
		/// <para>Display Name: Route ID</para>
		/// </summary>
		[DataMember(Name="RouteID", EmitDefaultValue=false)]
		public StringValue? RouteID { get; set; }

		/// <summary>
		/// <para>DAC Field Name: RouteDocumentID</para>
		/// <para>DAC: PX.Objects.FS.FSAppointment</para>
		/// <para>Display Name: Route Nbr.</para>
		/// </summary>
		[DataMember(Name="RouteNbr", EmitDefaultValue=false)]
		public StringValue? RouteNbr { get; set; }

		/// <summary>
		/// <para>DAC Field Name: ScheduleID</para>
		/// <para>DAC: PX.Objects.FS.FSAppointment</para>
		/// <para>Display Name: Source Schedule ID</para>
		/// </summary>
		[DataMember(Name="SourceScheduleID", EmitDefaultValue=false)]
		public StringValue? SourceScheduleID { get; set; }

		/// <summary>
		/// <para>DAC Field Name: ServiceContractID</para>
		/// <para>DAC: PX.Objects.FS.FSAppointment</para>
		/// <para>Display Name: Source Service Contract ID</para>
		/// </summary>
		[DataMember(Name="SourceServiceContractID", EmitDefaultValue=false)]
		public StringValue? SourceServiceContractID { get; set; }

	}
}