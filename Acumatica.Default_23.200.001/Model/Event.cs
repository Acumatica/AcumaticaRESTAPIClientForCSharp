using System;
using System.Collections.Generic;
using System.Runtime.Serialization;

using Newtonsoft.Json;

using Acumatica.RESTClient.Client;
using Acumatica.RESTClient.ContractBasedApi;
using Acumatica.RESTClient.ContractBasedApi.Model;

namespace Acumatica.Default_23_200_001.Model
{
	/// <summary>
	/// Corresponds to the screen CR306030 in the Acumatica ERP
	/// </summary>
	[DataContract]
	public class Event : Entity, ITopLevelEntity
	{

		/// <summary>
		/// 
		/// Display Name:
		/// DAC Field Name: AllDay 
		/// DAC: PX.Objects.CR.CRActivity 
		/// </summary>
		/// <remarks>
		/// 
		/// </remarks>
		[DataMember(Name="AllDay", EmitDefaultValue=false)]
		public BooleanValue? AllDay { get; set; }

		[DataMember(Name="Attendees", EmitDefaultValue=false)]
		public List<EventAttendee>? Attendees { get; set; }

		/// <summary>
		/// 
		/// Display Name:
		/// DAC Field Name: Body 
		/// DAC: PX.Objects.CR.CRActivity 
		/// </summary>
		/// <remarks>
		/// 
		/// </remarks>
		[DataMember(Name="Body", EmitDefaultValue=false)]
		public StringValue? Body { get; set; }

		/// <summary>
		/// 
		/// Display Name:
		/// DAC Field Name: CategoryID 
		/// DAC: PX.Objects.CR.CRActivity 
		/// </summary>
		/// <remarks>
		/// 
		/// </remarks>
		[DataMember(Name="Category", EmitDefaultValue=false)]
		public StringValue? Category { get; set; }

		[DataMember(Name="EndDate", EmitDefaultValue=false)]
		public DateTimeValue? EndDate { get; set; }

		[DataMember(Name="EndTime", EmitDefaultValue=false)]
		public DateTimeValue? EndTime { get; set; }

		/// <summary>
		/// 
		/// Display Name:
		/// DAC Field Name: IsPrivate 
		/// DAC: PX.Objects.CR.CRActivity 
		/// </summary>
		/// <remarks>
		/// 
		/// </remarks>
		[DataMember(Name="Internal", EmitDefaultValue=false)]
		public BooleanValue? Internal { get; set; }

		/// <summary>
		/// 
		/// Display Name:
		/// DAC Field Name: Location 
		/// DAC: PX.Objects.CR.CRActivity 
		/// </summary>
		/// <remarks>
		/// 
		/// </remarks>
		[DataMember(Name="Location", EmitDefaultValue=false)]
		public StringValue? Location { get; set; }

		/// <summary>
		/// 
		/// Display Name:
		/// DAC Field Name: NoteID 
		/// DAC: PX.Objects.CR.CRActivity 
		/// </summary>
		/// <remarks>
		/// 
		/// </remarks>
		[DataMember(Name="NoteID", EmitDefaultValue=false)]
		public GuidValue? NoteID { get; set; }

		/// <summary>
		/// 
		/// Display Name:
		/// DAC Field Name: Priority 
		/// DAC: PX.Objects.CR.CRActivity 
		/// </summary>
		/// <remarks>
		/// 
		/// </remarks>
		[DataMember(Name="Priority", EmitDefaultValue=false)]
		public StringValue? Priority { get; set; }

		[DataMember(Name="RelatedActivities", EmitDefaultValue=false)]
		public List<ActivityDetail>? RelatedActivities { get; set; }

		[DataMember(Name="Reminder", EmitDefaultValue=false)]
		public ReminderDetail? Reminder { get; set; }

		/// <summary>
		/// 
		/// Display Name:
		/// DAC Field Name: ShowAsID 
		/// DAC: PX.Objects.CR.CRActivity 
		/// </summary>
		/// <remarks>
		/// 
		/// </remarks>
		[DataMember(Name="ShowAs", EmitDefaultValue=false)]
		public StringValue? ShowAs { get; set; }

		/// <summary>
		/// 
		/// Display Name:
		/// DAC Field Name: StartDate 
		/// DAC: PX.Objects.CR.CRChildActivity 
		/// </summary>
		/// <remarks>
		/// 
		/// </remarks>
		[DataMember(Name="StartDate", EmitDefaultValue=false)]
		public DateTimeValue? StartDate { get; set; }

		/// <summary>
		/// 
		/// Display Name:
		/// DAC Field Name: UIStatus 
		/// DAC: PX.Objects.CR.CRActivity 
		/// </summary>
		/// <remarks>
		/// 
		/// </remarks>
		[DataMember(Name="Status", EmitDefaultValue=false)]
		public StringValue? Status { get; set; }

		/// <summary>
		/// 
		/// Display Name:
		/// DAC Field Name: Subject 
		/// DAC: PX.Objects.CR.CRActivity 
		/// </summary>
		/// <remarks>
		/// 
		/// </remarks>
		[DataMember(Name="Summary", EmitDefaultValue=false)]
		public StringValue? Summary { get; set; }

		[DataMember(Name="TimeActivity", EmitDefaultValue=false)]
		public EventTimeActivity? TimeActivity { get; set; }

		[DataMember(Name="CreatedByID", EmitDefaultValue=false)]
		public StringValue? CreatedByID { get; set; }

		[DataMember(Name="CreatedDateTime", EmitDefaultValue=false)]
		public DateTimeValue? CreatedDateTime { get; set; }

		[DataMember(Name="LastModifiedDateTime", EmitDefaultValue=false)]
		public DateTimeValue? LastModifiedDateTime { get; set; }

		/// <summary>
		/// 
		/// Display Name:
		/// DAC Field Name: RefNoteIDType 
		/// DAC: PX.Objects.CR.CRActivity 
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
		/// DAC: PX.Objects.CR.CRActivity 
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
			return "entity/Default/23.200.001";
		}
	}
}