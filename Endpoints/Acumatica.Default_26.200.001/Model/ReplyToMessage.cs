using System;
using System.Collections.Generic;
using System.Runtime.Serialization;

using Newtonsoft.Json;

using Acumatica.RESTClient.Client;
using Acumatica.RESTClient.ContractBasedApi;
using Acumatica.RESTClient.ContractBasedApi.Model;

namespace Acumatica.Default_26_200_001.Model
{
	[DataContract]
	public class ReplyToMessage : Entity
	{

		/// <summary>
		/// The identifier of the Note object associated with the document.
		/// <para>DAC: PX.Objects.CR.CRSMEmail</para>
		/// Key Field
		/// </summary>
		[DataMember(Name="NoteID", EmitDefaultValue=false)]
		public GuidValue? NoteID { get; set; }

		/// <summary>
		/// <para>DAC: PX.Objects.CR.CRSMEmail</para>
		/// <para>Display Name: From</para>
		/// <para>SQL Type: nvarchar(500)</para>
		/// </summary>
		[DataMember(Name="MailFrom", EmitDefaultValue=false)]
		public StringValue? MailFrom { get; set; }

		/// <summary>
		/// <para>DAC: PX.Objects.CR.CRSMEmail</para>
		/// <para>Display Name: To</para>
		/// <para>SQL Type: nvarchar(3000)</para>
		/// </summary>
		[DataMember(Name="MailTo", EmitDefaultValue=false)]
		public StringValue? MailTo { get; set; }

		/// <summary>
		/// <para>DAC: PX.Objects.CR.CRSMEmail</para>
		/// <para>Display Name: CC</para>
		/// <para>SQL Type: nvarchar(3000)</para>
		/// </summary>
		[DataMember(Name="MailCc", EmitDefaultValue=false)]
		public StringValue? MailCc { get; set; }

		/// <summary>
		/// <para>DAC: PX.Objects.CR.CRSMEmail</para>
		/// <para>Display Name: BCC</para>
		/// <para>SQL Type: nvarchar(3000)</para>
		/// </summary>
		[DataMember(Name="MailBcc", EmitDefaultValue=false)]
		public StringValue? MailBcc { get; set; }

		/// <summary>
		/// The summary description of the activity.
		/// <para>DAC: PX.Objects.CR.CRSMEmail</para>
		/// <para>Display Name: Summary</para>
		/// <para>SQL Type: nvarchar(998)</para>
		/// </summary>
		[DataMember(Name="Subject", EmitDefaultValue=false)]
		public StringValue? Subject { get; set; }

		/// <summary>
		/// <para>DAC: PX.Objects.CR.CRSMEmail</para>
		/// <para>Display Name: Activity Details</para>
		/// <para>SQL Type: nvarchar(MAX)</para>
		/// </summary>
		[DataMember(Name="Body", EmitDefaultValue=false)]
		public StringValue? Body { get; set; }

		[DataMember(Name="StartDate", EmitDefaultValue=false)]
		public DateTimeValue? StartDate { get; set; }

	}
}