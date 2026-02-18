using System;
using System.Collections.Generic;

using Newtonsoft.Json;

using Acumatica.RESTClient.Client;
using Acumatica.RESTClient.ContractBasedApi;
using Acumatica.RESTClient.ContractBasedApi.Model;

namespace Acumatica.Default_25_200_001.Model
{
	/// <summary>
	/// Corresponds to the screen <c>CR306010</c> in the Acumatica ERP
	/// <para>Key Fields: NoteID</para>
	/// </summary>
	public class Activity : Entity, ITopLevelEntity
	{

		/// <summary>
		/// The HTML body of the activity.
		/// <para>DAC: PX.Objects.CR.CRActivity</para>
		/// <para>Display Name: Activity Details</para>
		/// <para>SQL Type: nvarchar(MAX)</para>
		/// </summary>
		public StringValue? Body { get; set; }

		public DateTimeValue? Date { get; set; }

		/// <summary>
		/// Specifies whether this activity is hidden from external usersand not visible on the portal site.
		/// <para>DAC Field Name: IsPrivate</para>
		/// <para>DAC: PX.Objects.CR.CRActivity</para>
		/// </summary>
		public BooleanValue? Internal { get; set; }

		/// <summary>
		/// The identifier of the Note object associated with the document.
		/// <para>DAC: PX.Objects.CR.CRActivity</para>
		/// <para>Display Name: ID</para>
		/// Key Field
		/// </summary>
		public GuidValue? NoteID { get; set; }

		/// <summary>
		/// The identifier of the user responsible for the current document.If the WorkgroupID is specified, only a user that belongsto the specified workgroup can be used.
		/// <para>DAC Field Name: OwnerID</para>
		/// <para>DAC: PX.Objects.CR.CRActivity</para>
		/// </summary>
		public StringValue? Owner { get; set; }

		public StringValue? Status { get; set; }

		/// <summary>
		/// The summary description of the activity.
		/// <para>DAC Field Name: Subject</para>
		/// <para>DAC: PX.Objects.CR.CRActivity</para>
		/// <para>SQL Type: nvarchar(998)</para>
		/// </summary>
		public StringValue? Summary { get; set; }

		/// <summary>
		/// The identifier of the parent task or event of the current activity.
		/// <para>DAC Field Name: ParentNoteID</para>
		/// <para>DAC: PX.Objects.CR.CRActivity</para>
		/// <para>Display Name: Parent Activity</para>
		/// </summary>
		public StringValue? Task { get; set; }

		public TimeActivity? TimeActivity { get; set; }

		/// <summary>
		/// The type of the activity, which is one of the options defined on the Activity Types (CR102000) form.
		/// <para>DAC: PX.Objects.CR.CRActivity</para>
		/// <para>SQL Type: char(5)</para>
		/// </summary>
		public StringValue? Type { get; set; }

		/// <summary>
		/// The identifier of the workgroup responsible for the current document.
		/// <para>DAC Field Name: WorkgroupID</para>
		/// <para>DAC: PX.Objects.CR.CRActivity</para>
		/// </summary>
		public StringValue? Workgroup { get; set; }

		public StringValue? CreatedByID { get; set; }

		public DateTimeValue? CreatedDateTime { get; set; }

		public DateTimeValue? LastModifiedDateTime { get; set; }

		/// <summary>
		/// Contains the type of the related entity, that is specified in RefNoteID.
		/// <para>DAC Field Name: RefNoteIDType</para>
		/// <para>DAC: PX.Objects.CR.CRActivity</para>
		/// <para>Display Name: Related Entity Type</para>
		/// <para>SQL Type: nvarchar(MAX)</para>
		/// </summary>
		public StringValue? RelatedEntityType { get; set; }

		/// <summary>
		/// Contains the NoteID value of the related entity.This activity is displayed on the Activities tab of the entity's form.
		/// <para>DAC Field Name: RefNoteID</para>
		/// <para>DAC: PX.Objects.CR.CRActivity</para>
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
			return "entity/Default/25.200.001";
		}
	}
}