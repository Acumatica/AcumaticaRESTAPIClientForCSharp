using System;
using System.Collections.Generic;
using System.Runtime.Serialization;

using Newtonsoft.Json;

using Acumatica.RESTClient.Client;
using Acumatica.RESTClient.ContractBasedApi;
using Acumatica.RESTClient.ContractBasedApi.Model;

namespace Acumatica.Default_24_200_001.Model
{
	/// <summary>
	/// Corresponds to the screen CR306015 in the Acumatica ERP
	/// </summary>
	[DataContract]
	public class Email : Entity, ITopLevelEntity
	{

		/// <summary>
		/// DAC Field Name: MailBcc 
		/// DAC: PX.Objects.CR.CRSMEmail 
		/// Display Name: BCC 
		/// SQL Type: nvarchar(3000) 
		/// </summary>
		[DataMember(Name="Bcc", EmitDefaultValue=false)]
		public StringValue? Bcc { get; set; }

		/// <summary>
		/// DAC: PX.Objects.CR.CRSMEmail 
		/// Display Name: Activity Details 
		/// SQL Type: nvarchar(MAX) 
		/// </summary>
		[DataMember(Name="Body", EmitDefaultValue=false)]
		public StringValue? Body { get; set; }

		/// <summary>
		/// DAC Field Name: MailCc 
		/// DAC: PX.Objects.CR.CRSMEmail 
		/// Display Name: CC 
		/// SQL Type: nvarchar(3000) 
		/// </summary>
		[DataMember(Name="Cc", EmitDefaultValue=false)]
		public StringValue? Cc { get; set; }

		/// <summary>
		/// Returns either additional information about the related entity or the last error message. The property isused by the CREmailActivityMaint graph to show additional infomation about the SMEmail status.
		/// DAC Field Name: EntityDescription 
		/// DAC: PX.Objects.CR.CRSMEmail 
		/// Display Name: Entity 
		/// SQL Type: nvarchar(MAX) 
		/// </summary>
		[DataMember(Name="Description", EmitDefaultValue=false)]
		public StringValue? Description { get; set; }

		/// <summary>
		/// DAC Field Name: MailFrom 
		/// DAC: PX.Objects.CR.CRSMEmail 
		/// SQL Type: nvarchar(500) 
		/// </summary>
		[DataMember(Name="From", EmitDefaultValue=false)]
		public StringValue? From { get; set; }

		/// <summary>
		/// DAC Field Name: MailAccountID_description 
		/// DAC: PX.Objects.CR.CRSMEmail 
		/// </summary>
		[DataMember(Name="FromEmailAccountDisplayName", EmitDefaultValue=false)]
		public StringValue? FromEmailAccountDisplayName { get; set; }

		/// <summary>
		/// DAC Field Name: MailAccountID 
		/// DAC: PX.Objects.CR.CRSMEmail 
		/// Display Name: From 
		/// </summary>
		[DataMember(Name="FromEmailAccountID", EmitDefaultValue=false)]
		public IntValue? FromEmailAccountID { get; set; }

		/// <summary>
		/// DAC Field Name: IsIncome 
		/// DAC: PX.Objects.CR.CRSMEmail 
		/// Display Name: Is Income 
		/// </summary>
		[DataMember(Name="Incoming", EmitDefaultValue=false)]
		public BooleanValue? Incoming { get; set; }

		/// <summary>
		/// Specifies whether this activity is hidden from external usersand not visible on the portal site.
		/// DAC Field Name: IsPrivate 
		/// DAC: PX.Objects.CR.CRSMEmail 
		/// </summary>
		[DataMember(Name="Internal", EmitDefaultValue=false)]
		public BooleanValue? Internal { get; set; }

		/// <summary>
		/// DAC Field Name: MPStatus 
		/// DAC: PX.Objects.CR.CRSMEmail 
		/// Display Name: Email Status 
		/// SQL Type: char(2) 
		/// </summary>
		[DataMember(Name="MailStatus", EmitDefaultValue=false)]
		public StringValue? MailStatus { get; set; }

		/// <summary>
		/// The identifier of the user responsible for the current document.If the WorkgroupID is specified, only a user that belongsto the specified workgroup can be used.
		/// DAC Field Name: OwnerID 
		/// DAC: PX.Objects.CR.CRSMEmail 
		/// </summary>
		[DataMember(Name="Owner", EmitDefaultValue=false)]
		public StringValue? Owner { get; set; }

		/// <summary>
		/// DAC Field Name: ParentNoteID 
		/// DAC: PX.Objects.CR.CRSMEmail 
		/// Display Name: Task 
		/// </summary>
		[DataMember(Name="Parent", EmitDefaultValue=false)]
		public GuidValue? Parent { get; set; }

		[DataMember(Name="ParentSummary", EmitDefaultValue=false)]
		public StringValue? ParentSummary { get; set; }

		[DataMember(Name="StartDate", EmitDefaultValue=false)]
		public DateTimeValue? StartDate { get; set; }

		/// <summary>
		/// The summary description of the activity.
		/// DAC: PX.Objects.CR.CRSMEmail 
		/// Display Name: Summary 
		/// SQL Type: nvarchar(998) 
		/// </summary>
		[DataMember(Name="Subject", EmitDefaultValue=false)]
		public StringValue? Subject { get; set; }

		[DataMember(Name="TimeActivity", EmitDefaultValue=false)]
		public TimeActivity? TimeActivity { get; set; }

		/// <summary>
		/// DAC Field Name: MailTo 
		/// DAC: PX.Objects.CR.CRSMEmail 
		/// SQL Type: nvarchar(3000) 
		/// </summary>
		[DataMember(Name="To", EmitDefaultValue=false)]
		public StringValue? To { get; set; }

		/// <summary>
		/// The identifier of the workgroup responsible for the current document.
		/// DAC Field Name: WorkgroupID 
		/// DAC: PX.Objects.CR.CRSMEmail 
		/// </summary>
		[DataMember(Name="Workgroup", EmitDefaultValue=false)]
		public StringValue? Workgroup { get; set; }

		[DataMember(Name="CreatedByID", EmitDefaultValue=false)]
		public StringValue? CreatedByID { get; set; }

		[DataMember(Name="CreatedDateTime", EmitDefaultValue=false)]
		public DateTimeValue? CreatedDateTime { get; set; }

		[DataMember(Name="LastModifiedDateTime", EmitDefaultValue=false)]
		public DateTimeValue? LastModifiedDateTime { get; set; }

		/// <summary>
		/// The identifier of the Note object associated with the document.
		/// DAC: PX.Objects.CR.CRSMEmail 
		/// Key Field
		/// </summary>
		[DataMember(Name="NoteID", EmitDefaultValue=false)]
		public GuidValue? NoteID { get; set; }

		/// <summary>
		/// Contains the type of the related entity, that is specified in RefNoteID.
		/// DAC Field Name: RefNoteIDType 
		/// DAC: PX.Objects.CR.CRSMEmail 
		/// Display Name: Related Entity Type 
		/// SQL Type: nvarchar(MAX) 
		/// </summary>
		[DataMember(Name="RelatedEntityType", EmitDefaultValue=false)]
		public StringValue? RelatedEntityType { get; set; }

		/// <summary>
		/// Contains the NoteID value of the related entity.This activity is displayed on the Activities tab of the entity's form.
		/// DAC Field Name: RefNoteID 
		/// DAC: PX.Objects.CR.CRSMEmail 
		/// Display Name: Related Entity 
		/// </summary>
		/// <remarks>
		/// The related document may or may not implement the INotable interface,            but it must have a field marked with the PXNoteAttribute attribute            with the ShowInReferenceSelector property set to true.            
		/// </remarks>
		[DataMember(Name="RelatedEntityNoteID", EmitDefaultValue=false)]
		public GuidValue? RelatedEntityNoteID { get; set; }

		[DataMember(Name="RelatedEntityDescription", EmitDefaultValue=false)]
		public StringValue? RelatedEntityDescription { get; set; }

		public virtual string GetEndpointPath()
		{
			return "entity/Default/24.200.001";
		}
	}
}