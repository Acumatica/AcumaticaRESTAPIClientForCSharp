using System;
using System.Collections.Generic;
using System.Runtime.Serialization;

using Newtonsoft.Json;

using Acumatica.RESTClient.Client;
using Acumatica.RESTClient.ContractBasedApi;
using Acumatica.RESTClient.ContractBasedApi.Model;

namespace Acumatica.Default_25_200_001.Model
{
	[DataContract]
	public class ContactNotification : Entity
	{

		/// <summary>
		/// <para>DAC: PX.Objects.CR.ContactNotification</para>
		/// </summary>
		[DataMember(Name="Active", EmitDefaultValue=false)]
		public BooleanValue? Active { get; set; }

		[DataMember(Name="Bcc", EmitDefaultValue=false)]
		public BooleanValue? Bcc { get; set; }

		/// <summary>
		/// The identifier of the class.
		/// <para>DAC: PX.Objects.CR.Contact</para>
		/// <para>Display Name: Contact Class</para>
		/// <para>SQL Type: nvarchar(10)</para>
		/// </summary>
		[DataMember(Name="ClassID", EmitDefaultValue=false)]
		public StringValue? ClassID { get; set; }

		/// <summary>
		/// <para>DAC Field Name: EntityDescription</para>
		/// <para>DAC: PX.Objects.CR.ContactNotification</para>
		/// <para>SQL Type: nvarchar(MAX)</para>
		/// </summary>
		[DataMember(Name="Description", EmitDefaultValue=false)]
		public StringValue? Description { get; set; }

		/// <summary>
		/// <para>DAC: PX.Objects.CR.ContactNotification</para>
		/// <para>SQL Type: char(1)</para>
		/// </summary>
		[DataMember(Name="Format", EmitDefaultValue=false)]
		public StringValue? Format { get; set; }

		/// <summary>
		/// <para>DAC Field Name: NotificationSetup__NotificationCD</para>
		/// <para>DAC: PX.Objects.CR.ContactNotification</para>
		/// </summary>
		[DataMember(Name="MailingID", EmitDefaultValue=false)]
		public StringValue? MailingID { get; set; }

		/// <summary>
		/// <para>DAC Field Name: NotificationSetup__Module</para>
		/// <para>DAC: PX.Objects.CR.ContactNotification</para>
		/// </summary>
		[DataMember(Name="Module", EmitDefaultValue=false)]
		public StringValue? Module { get; set; }

		/// <summary>
		/// <para>DAC: PX.Objects.CR.ContactNotification</para>
		/// <para>Display Name: Notification ID</para>
		/// Key Field
		/// </summary>
		[DataMember(Name="NotificationID", EmitDefaultValue=false)]
		public IntValue? NotificationID { get; set; }

		/// <summary>
		/// <para>DAC Field Name: ReportID</para>
		/// <para>DAC: PX.Objects.CR.ContactNotification</para>
		/// <para>SQL Type: varchar(8)</para>
		/// </summary>
		[DataMember(Name="Report", EmitDefaultValue=false)]
		public StringValue? Report { get; set; }

		/// <summary>
		/// <para>DAC Field Name: NotificationSetup__SourceCD</para>
		/// <para>DAC: PX.Objects.CR.ContactNotification</para>
		/// </summary>
		[DataMember(Name="Source", EmitDefaultValue=false)]
		public StringValue? Source { get; set; }

	}
}