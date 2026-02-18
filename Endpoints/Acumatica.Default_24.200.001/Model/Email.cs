using System;
using System.Collections.Generic;

using Newtonsoft.Json;

using Acumatica.RESTClient.Client;
using Acumatica.RESTClient.ContractBasedApi;
using Acumatica.RESTClient.ContractBasedApi.Model;

namespace Acumatica.Default_24_200_001.Model
{
	/// <summary>
	/// Corresponds to the screen <c>CR306015</c> in the Acumatica ERP
	/// <para>Key Fields: NoteID</para>
	/// </summary>
	public class Email : Entity, ITopLevelEntity
	{

		/// <summary>
		/// <para>DAC Field Name: MailBcc</para>
		/// <para>DAC: PX.Objects.CR.CRSMEmail</para>
		/// <para>Display Name: BCC</para>
		/// <para>SQL Type: nvarchar(3000)</para>
		/// </summary>
		public StringValue? Bcc { get; set; }

		/// <summary>
		/// <para>DAC: PX.Objects.CR.CRSMEmail</para>
		/// <para>Display Name: Activity Details</para>
		/// <para>SQL Type: nvarchar(MAX)</para>
		/// </summary>
		public StringValue? Body { get; set; }

		/// <summary>
		/// <para>DAC Field Name: MailCc</para>
		/// <para>DAC: PX.Objects.CR.CRSMEmail</para>
		/// <para>Display Name: CC</para>
		/// <para>SQL Type: nvarchar(3000)</para>
		/// </summary>
		public StringValue? Cc { get; set; }

		/// <summary>
		/// Returns either additional information about the related entity or the last error message. The property isused by the CREmailActivityMaint graph to show additional infomation about the SMEmail status.
		/// <para>DAC Field Name: EntityDescription</para>
		/// <para>DAC: PX.Objects.CR.CRSMEmail</para>
		/// <para>Display Name: Entity</para>
		/// <para>SQL Type: nvarchar(MAX)</para>
		/// </summary>
		public StringValue? Description { get; set; }

		/// <summary>
		/// <para>DAC Field Name: MailFrom</para>
		/// <para>DAC: PX.Objects.CR.CRSMEmail</para>
		/// <para>SQL Type: nvarchar(500)</para>
		/// </summary>
		public StringValue? From { get; set; }

		/// <summary>
		/// <para>DAC Field Name: MailAccountID_description</para>
		/// <para>DAC: PX.Objects.CR.CRSMEmail</para>
		/// </summary>
		public StringValue? FromEmailAccountDisplayName { get; set; }

		/// <summary>
		/// <para>DAC Field Name: MailAccountID</para>
		/// <para>DAC: PX.Objects.CR.CRSMEmail</para>
		/// <para>Display Name: From</para>
		/// </summary>
		public IntValue? FromEmailAccountID { get; set; }

		/// <summary>
		/// <para>DAC Field Name: IsIncome</para>
		/// <para>DAC: PX.Objects.CR.CRSMEmail</para>
		/// <para>Display Name: Is Income</para>
		/// </summary>
		public BooleanValue? Incoming { get; set; }

		/// <summary>
		/// Specifies whether this activity is hidden from external usersand not visible on the portal site.
		/// <para>DAC Field Name: IsPrivate</para>
		/// <para>DAC: PX.Objects.CR.CRSMEmail</para>
		/// </summary>
		public BooleanValue? Internal { get; set; }

		/// <summary>
		/// <para>DAC Field Name: MPStatus</para>
		/// <para>DAC: PX.Objects.CR.CRSMEmail</para>
		/// <para>Display Name: Email Status</para>
		/// <para>SQL Type: char(2)</para>
		/// </summary>
		public StringValue? MailStatus { get; set; }

		/// <summary>
		/// The identifier of the user responsible for the current document.If the WorkgroupID is specified, only a user that belongsto the specified workgroup can be used.
		/// <para>DAC Field Name: OwnerID</para>
		/// <para>DAC: PX.Objects.CR.CRSMEmail</para>
		/// </summary>
		public StringValue? Owner { get; set; }

		/// <summary>
		/// <para>DAC Field Name: ParentNoteID</para>
		/// <para>DAC: PX.Objects.CR.CRSMEmail</para>
		/// <para>Display Name: Task</para>
		/// </summary>
		public GuidValue? Parent { get; set; }

		public StringValue? ParentSummary { get; set; }

		public DateTimeValue? StartDate { get; set; }

		/// <summary>
		/// The summary description of the activity.
		/// <para>DAC: PX.Objects.CR.CRSMEmail</para>
		/// <para>Display Name: Summary</para>
		/// <para>SQL Type: nvarchar(998)</para>
		/// </summary>
		public StringValue? Subject { get; set; }

		public TimeActivity? TimeActivity { get; set; }

		/// <summary>
		/// <para>DAC Field Name: MailTo</para>
		/// <para>DAC: PX.Objects.CR.CRSMEmail</para>
		/// <para>SQL Type: nvarchar(3000)</para>
		/// </summary>
		public StringValue? To { get; set; }

		/// <summary>
		/// The identifier of the workgroup responsible for the current document.
		/// <para>DAC Field Name: WorkgroupID</para>
		/// <para>DAC: PX.Objects.CR.CRSMEmail</para>
		/// </summary>
		public StringValue? Workgroup { get; set; }

		public StringValue? CreatedByID { get; set; }

		public DateTimeValue? CreatedDateTime { get; set; }

		public DateTimeValue? LastModifiedDateTime { get; set; }

		/// <summary>
		/// The identifier of the Note object associated with the document.
		/// <para>DAC: PX.Objects.CR.CRSMEmail</para>
		/// Key Field
		/// </summary>
		public GuidValue? NoteID { get; set; }

		/// <summary>
		/// Contains the type of the related entity, that is specified in RefNoteID.
		/// <para>DAC Field Name: RefNoteIDType</para>
		/// <para>DAC: PX.Objects.CR.CRSMEmail</para>
		/// <para>Display Name: Related Entity Type</para>
		/// <para>SQL Type: nvarchar(MAX)</para>
		/// </summary>
		public StringValue? RelatedEntityType { get; set; }

		/// <summary>
		/// Contains the NoteID value of the related entity.This activity is displayed on the Activities tab of the entity's form.
		/// <para>DAC Field Name: RefNoteID</para>
		/// <para>DAC: PX.Objects.CR.CRSMEmail</para>
		/// <para>Display Name: Related Entity</para>
		/// </summary>
		/// <remarks>
		/// The related document may or may not implement the INotable interface,            but it must have a field marked with the PXNoteAttribute attribute            with the ShowInReferenceSelector property set to true.            
		/// </remarks>
		public GuidValue? RelatedEntityNoteID { get; set; }

		public StringValue? RelatedEntityDescription { get; set; }

		public static class Expand
		{
			public const string Files = "Files";
			public const string Translations = "Translations";
			public const string TimeActivity = "TimeActivity";

			//Intentionally excluded
			//public const string All = "Files,Translations,TimeActivity";
		}
		public virtual string GetEndpointPath()
		{
			return "entity/Default/24.200.001";
		}
	}
}