using System;
using System.Collections.Generic;
using System.Runtime.Serialization;

using Newtonsoft.Json;

using Acumatica.RESTClient.Client;
using Acumatica.RESTClient.ContractBasedApi;
using Acumatica.RESTClient.ContractBasedApi.Model;

namespace Acumatica.Default_22_200_001.Model
{
	[DataContract]
	public class ContactNotification : Entity
	{

		/// <summary>
		/// DAC: PX.Objects.CR.ContactNotification 
		/// </summary>
		[DataMember(Name="Active", EmitDefaultValue=false)]
		public BooleanValue? Active { get; set; }

		[DataMember(Name="Bcc", EmitDefaultValue=false)]
		public BooleanValue? Bcc { get; set; }

		/// <summary>
		/// The identifier of the class.
		/// DAC: PX.Objects.CR.Contact 
		/// Display Name: Class ID 
		/// SQL Type: nvarchar(10) 
		/// </summary>
		[DataMember(Name="ClassID", EmitDefaultValue=false)]
		public StringValue? ClassID { get; set; }

		/// <summary>
		/// DAC Field Name: EntityDescription 
		/// DAC: PX.Objects.CR.ContactNotification 
		/// SQL Type: nvarchar(MAX) 
		/// </summary>
		[DataMember(Name="Description", EmitDefaultValue=false)]
		public StringValue? Description { get; set; }

		/// <summary>
		/// DAC: PX.Objects.CR.ContactNotification 
		/// SQL Type: char(1) 
		/// </summary>
		[DataMember(Name="Format", EmitDefaultValue=false)]
		public StringValue? Format { get; set; }

		/// <summary>
		/// DAC Field Name: NotificationSetup__NotificationCD 
		/// DAC: PX.Objects.CR.ContactNotification 
		/// </summary>
		[DataMember(Name="MailingID", EmitDefaultValue=false)]
		public StringValue? MailingID { get; set; }

		/// <summary>
		/// DAC Field Name: NotificationSetup__Module 
		/// DAC: PX.Objects.CR.ContactNotification 
		/// </summary>
		[DataMember(Name="Module", EmitDefaultValue=false)]
		public StringValue? Module { get; set; }

		/// <summary>
		/// DAC: PX.Objects.CR.ContactNotification 
		/// Key Field
		/// </summary>
		[DataMember(Name="NotificationID", EmitDefaultValue=false)]
		public IntValue? NotificationID { get; set; }

		/// <summary>
		/// DAC Field Name: ReportID 
		/// DAC: PX.Objects.CR.ContactNotification 
		/// SQL Type: varchar(8) 
		/// </summary>
		[DataMember(Name="Report", EmitDefaultValue=false)]
		public StringValue? Report { get; set; }

		/// <summary>
		/// DAC Field Name: NotificationSetup__SourceCD 
		/// DAC: PX.Objects.CR.ContactNotification 
		/// </summary>
		[DataMember(Name="Source", EmitDefaultValue=false)]
		public StringValue? Source { get; set; }

	}
}