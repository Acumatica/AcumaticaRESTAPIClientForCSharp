using System;
using System.Collections.Generic;

using Newtonsoft.Json;

using Acumatica.RESTClient.Client;
using Acumatica.RESTClient.ContractBasedApi;
using Acumatica.RESTClient.ContractBasedApi.Model;

namespace Acumatica.Default_23_200_001.Model
{
	public class AppOtherInformation : Entity
	{

		public StringValue? BatchNbr { get; set; }

		/// <summary>
		/// <para>DAC Field Name: LongDescr</para>
		/// <para>DAC: PX.Objects.FS.FSAppointment</para>
		/// <para>SQL Type: nvarchar(MAX)</para>
		/// </summary>
		public StringValue? Description { get; set; }

		public StringValue? DocumentType { get; set; }

		public StringValue? InvoiceNbr { get; set; }

		public StringValue? IssueReferenceNbr { get; set; }

		/// <summary>
		/// <para>DAC: PX.Objects.FS.FSSchedule</para>
		/// <para>Display Name: Recurrence Description</para>
		/// <para>SQL Type: varchar(MAX)</para>
		/// </summary>
		public StringValue? RecurrenceDescription { get; set; }

		public StringValue? ReferenceNbr { get; set; }

		/// <summary>
		/// <para>DAC: PX.Objects.FS.FSAppointment</para>
		/// <para>Display Name: Route ID</para>
		/// </summary>
		public StringValue? RouteID { get; set; }

		/// <summary>
		/// <para>DAC Field Name: RouteDocumentID</para>
		/// <para>DAC: PX.Objects.FS.FSAppointment</para>
		/// <para>Display Name: Route Nbr.</para>
		/// </summary>
		public StringValue? RouteNbr { get; set; }

		/// <summary>
		/// <para>DAC Field Name: ScheduleID</para>
		/// <para>DAC: PX.Objects.FS.FSAppointment</para>
		/// <para>Display Name: Source Schedule ID</para>
		/// </summary>
		public StringValue? SourceScheduleID { get; set; }

		/// <summary>
		/// <para>DAC Field Name: ServiceContractID</para>
		/// <para>DAC: PX.Objects.FS.FSAppointment</para>
		/// <para>Display Name: Source Service Contract ID</para>
		/// </summary>
		public StringValue? SourceServiceContractID { get; set; }

	}
}