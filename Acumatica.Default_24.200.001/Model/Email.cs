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
		/// 
		/// Display Name:
		/// DAC Field Name: MailBcc 
		/// DAC: PX.Objects.CR.CRSMEmail 
		/// </summary>
		/// <remarks>
		/// 
		/// </remarks>
		[DataMember(Name="Bcc", EmitDefaultValue=false)]
		public StringValue? Bcc { get; set; }

		/// <summary>
		/// 
		/// Display Name:
		/// DAC Field Name: Body 
		/// DAC: PX.Objects.CR.CRSMEmail 
		/// </summary>
		/// <remarks>
		/// 
		/// </remarks>
		[DataMember(Name="Body", EmitDefaultValue=false)]
		public StringValue? Body { get; set; }

		/// <summary>
		/// 
		/// Display Name:
		/// DAC Field Name: MailCc 
		/// DAC: PX.Objects.CR.CRSMEmail 
		/// </summary>
		/// <remarks>
		/// 
		/// </remarks>
		[DataMember(Name="Cc", EmitDefaultValue=false)]
		public StringValue? Cc { get; set; }

		/// <summary>
		/// 
		/// Display Name:
		/// DAC Field Name: EntityDescription 
		/// DAC: PX.Objects.CR.CRSMEmail 
		/// </summary>
		/// <remarks>
		/// 
		/// </remarks>
		[DataMember(Name="Description", EmitDefaultValue=false)]
		public StringValue? Description { get; set; }

		/// <summary>
		/// 
		/// Display Name:
		/// DAC Field Name: MailFrom 
		/// DAC: PX.Objects.CR.CRSMEmail 
		/// </summary>
		/// <remarks>
		/// 
		/// </remarks>
		[DataMember(Name="From", EmitDefaultValue=false)]
		public StringValue? From { get; set; }

		/// <summary>
		/// 
		/// Display Name:
		/// DAC Field Name: MailAccountID_description 
		/// DAC: PX.Objects.CR.CRSMEmail 
		/// </summary>
		/// <remarks>
		/// 
		/// </remarks>
		[DataMember(Name="FromEmailAccountDisplayName", EmitDefaultValue=false)]
		public StringValue? FromEmailAccountDisplayName { get; set; }

		/// <summary>
		/// 
		/// Display Name:
		/// DAC Field Name: MailAccountID 
		/// DAC: PX.Objects.CR.CRSMEmail 
		/// </summary>
		/// <remarks>
		/// 
		/// </remarks>
		[DataMember(Name="FromEmailAccountID", EmitDefaultValue=false)]
		public IntValue? FromEmailAccountID { get; set; }

		/// <summary>
		/// 
		/// Display Name:
		/// DAC Field Name: IsIncome 
		/// DAC: PX.Objects.CR.CRSMEmail 
		/// </summary>
		/// <remarks>
		/// 
		/// </remarks>
		[DataMember(Name="Incoming", EmitDefaultValue=false)]
		public BooleanValue? Incoming { get; set; }

		/// <summary>
		/// 
		/// Display Name:
		/// DAC Field Name: IsPrivate 
		/// DAC: PX.Objects.CR.CRSMEmail 
		/// </summary>
		/// <remarks>
		/// 
		/// </remarks>
		[DataMember(Name="Internal", EmitDefaultValue=false)]
		public BooleanValue? Internal { get; set; }

		/// <summary>
		/// 
		/// Display Name:
		/// DAC Field Name: MPStatus 
		/// DAC: PX.Objects.CR.CRSMEmail 
		/// </summary>
		/// <remarks>
		/// 
		/// </remarks>
		[DataMember(Name="MailStatus", EmitDefaultValue=false)]
		public StringValue? MailStatus { get; set; }

		/// <summary>
		/// 
		/// Display Name:
		/// DAC Field Name: OwnerID 
		/// DAC: PX.Objects.CR.CRSMEmail 
		/// </summary>
		/// <remarks>
		/// 
		/// </remarks>
		[DataMember(Name="Owner", EmitDefaultValue=false)]
		public StringValue? Owner { get; set; }

		/// <summary>
		/// 
		/// Display Name:
		/// DAC Field Name: ParentNoteID 
		/// DAC: PX.Objects.CR.CRSMEmail 
		/// </summary>
		/// <remarks>
		/// 
		/// </remarks>
		[DataMember(Name="Parent", EmitDefaultValue=false)]
		public GuidValue? Parent { get; set; }

		[DataMember(Name="ParentSummary", EmitDefaultValue=false)]
		public StringValue? ParentSummary { get; set; }

		[DataMember(Name="StartDate", EmitDefaultValue=false)]
		public DateTimeValue? StartDate { get; set; }

		/// <summary>
		/// 
		/// Display Name:
		/// DAC Field Name: Subject 
		/// DAC: PX.Objects.CR.CRSMEmail 
		/// </summary>
		/// <remarks>
		/// 
		/// </remarks>
		[DataMember(Name="Subject", EmitDefaultValue=false)]
		public StringValue? Subject { get; set; }

		[DataMember(Name="TimeActivity", EmitDefaultValue=false)]
		public TimeActivity? TimeActivity { get; set; }

		/// <summary>
		/// 
		/// Display Name:
		/// DAC Field Name: MailTo 
		/// DAC: PX.Objects.CR.CRSMEmail 
		/// </summary>
		/// <remarks>
		/// 
		/// </remarks>
		[DataMember(Name="To", EmitDefaultValue=false)]
		public StringValue? To { get; set; }

		/// <summary>
		/// 
		/// Display Name:
		/// DAC Field Name: WorkgroupID 
		/// DAC: PX.Objects.CR.CRSMEmail 
		/// </summary>
		/// <remarks>
		/// 
		/// </remarks>
		[DataMember(Name="Workgroup", EmitDefaultValue=false)]
		public StringValue? Workgroup { get; set; }

		[DataMember(Name="CreatedByID", EmitDefaultValue=false)]
		public StringValue? CreatedByID { get; set; }

		[DataMember(Name="CreatedDateTime", EmitDefaultValue=false)]
		public DateTimeValue? CreatedDateTime { get; set; }

		[DataMember(Name="LastModifiedDateTime", EmitDefaultValue=false)]
		public DateTimeValue? LastModifiedDateTime { get; set; }

		/// <summary>
		/// 
		/// Display Name:
		/// DAC Field Name: NoteID 
		/// DAC: PX.Objects.CR.CRSMEmail 
		/// </summary>
		/// <remarks>
		/// 
		/// </remarks>
		[DataMember(Name="NoteID", EmitDefaultValue=false)]
		public GuidValue? NoteID { get; set; }

		/// <summary>
		/// 
		/// Display Name:
		/// DAC Field Name: RefNoteIDType 
		/// DAC: PX.Objects.CR.CRSMEmail 
		/// </summary>
		/// <remarks>
		/// 
		/// </remarks>
		[DataMember(Name="RelatedEntityType", EmitDefaultValue=false)]
		public StringValue? RelatedEntityType { get; set; }

		/// <summary>
		/// 
		/// Display Name:
		/// DAC Field Name: RefNoteID 
		/// DAC: PX.Objects.CR.CRSMEmail 
		/// </summary>
		/// <remarks>
		/// 
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