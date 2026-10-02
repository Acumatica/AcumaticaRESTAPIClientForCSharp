using System;
using System.Collections.Generic;

using Newtonsoft.Json;

using Acumatica.RESTClient.Client;
using Acumatica.RESTClient.ContractBasedApi;
using Acumatica.RESTClient.ContractBasedApi.Model;

namespace Acumatica.Default_26_200_001.Model
{
	public class ReplyToMessage : Entity
	{

		#region Fields
		/// <summary>
		/// The identifier of the Note object associated with the document.
		/// <para>DAC: PX.Objects.CR.CRSMEmail</para>
		/// Key Field
		/// </summary>
		public GuidValue? NoteID { get; set; }

		/// <summary>
		/// <para>DAC: PX.Objects.CR.CRSMEmail</para>
		/// <para>Display Name: From</para>
		/// <para>SQL Type: nvarchar(500)</para>
		/// </summary>
		public StringValue? MailFrom { get; set; }

		/// <summary>
		/// <para>DAC: PX.Objects.CR.CRSMEmail</para>
		/// <para>Display Name: To</para>
		/// <para>SQL Type: nvarchar(3000)</para>
		/// </summary>
		public StringValue? MailTo { get; set; }

		/// <summary>
		/// <para>DAC: PX.Objects.CR.CRSMEmail</para>
		/// <para>Display Name: CC</para>
		/// <para>SQL Type: nvarchar(3000)</para>
		/// </summary>
		public StringValue? MailCc { get; set; }

		/// <summary>
		/// <para>DAC: PX.Objects.CR.CRSMEmail</para>
		/// <para>Display Name: BCC</para>
		/// <para>SQL Type: nvarchar(3000)</para>
		/// </summary>
		public StringValue? MailBcc { get; set; }

		/// <summary>
		/// The summary description of the activity.
		/// <para>DAC: PX.Objects.CR.CRSMEmail</para>
		/// <para>Display Name: Summary</para>
		/// <para>SQL Type: nvarchar(998)</para>
		/// </summary>
		public StringValue? Subject { get; set; }

		/// <summary>
		/// <para>DAC: PX.Objects.CR.CRSMEmail</para>
		/// <para>Display Name: Activity Details</para>
		/// <para>SQL Type: nvarchar(MAX)</para>
		/// </summary>
		public StringValue? Body { get; set; }

		public DateTimeValue? StartDate { get; set; }

		#endregion

	}
}