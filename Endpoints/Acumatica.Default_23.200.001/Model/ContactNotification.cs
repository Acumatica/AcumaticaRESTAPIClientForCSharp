using System;
using System.Collections.Generic;

using Newtonsoft.Json;

using Acumatica.RESTClient.Client;
using Acumatica.RESTClient.ContractBasedApi;
using Acumatica.RESTClient.ContractBasedApi.Model;

namespace Acumatica.Default_23_200_001.Model
{
	public class ContactNotification : Entity
	{

		/// <summary>
		/// <para>DAC: PX.Objects.CR.ContactNotification</para>
		/// </summary>
		public BooleanValue? Active { get; set; }

		public BooleanValue? Bcc { get; set; }

		/// <summary>
		/// The identifier of the class.
		/// <para>DAC: PX.Objects.CR.Contact</para>
		/// <para>Display Name: Contact Class</para>
		/// <para>SQL Type: nvarchar(10)</para>
		/// </summary>
		public StringValue? ClassID { get; set; }

		/// <summary>
		/// <para>DAC Field Name: EntityDescription</para>
		/// <para>DAC: PX.Objects.CR.ContactNotification</para>
		/// <para>SQL Type: nvarchar(MAX)</para>
		/// </summary>
		public StringValue? Description { get; set; }

		/// <summary>
		/// <para>DAC: PX.Objects.CR.ContactNotification</para>
		/// <para>SQL Type: char(1)</para>
		/// </summary>
		public StringValue? Format { get; set; }

		/// <summary>
		/// <para>DAC Field Name: NotificationSetup__NotificationCD</para>
		/// <para>DAC: PX.Objects.CR.ContactNotification</para>
		/// </summary>
		public StringValue? MailingID { get; set; }

		/// <summary>
		/// <para>DAC Field Name: NotificationSetup__Module</para>
		/// <para>DAC: PX.Objects.CR.ContactNotification</para>
		/// </summary>
		public StringValue? Module { get; set; }

		/// <summary>
		/// <para>DAC: PX.Objects.CR.ContactNotification</para>
		/// <para>Display Name: Notification ID</para>
		/// Key Field
		/// </summary>
		public IntValue? NotificationID { get; set; }

		/// <summary>
		/// <para>DAC Field Name: ReportID</para>
		/// <para>DAC: PX.Objects.CR.ContactNotification</para>
		/// <para>SQL Type: varchar(8)</para>
		/// </summary>
		public StringValue? Report { get; set; }

		/// <summary>
		/// <para>DAC Field Name: NotificationSetup__SourceCD</para>
		/// <para>DAC: PX.Objects.CR.ContactNotification</para>
		/// </summary>
		public StringValue? Source { get; set; }

	}
}