using System;
using System.Collections.Generic;
using System.Runtime.Serialization;

using Newtonsoft.Json;

using Acumatica.RESTClient.Client;
using Acumatica.RESTClient.ContractBasedApi;
using Acumatica.RESTClient.ContractBasedApi.Model;

namespace Acumatica.Default_23_200_001.Model
{
	[DataContract]
	public class EventAttendee : Entity
	{

		/// <summary>
		/// The comment of the event owner for the attendee.
		/// <para>DAC: PX.Objects.EP.EPAttendee</para>
		/// <para>SQL Type: nvarchar(255)</para>
		/// </summary>
		[DataMember(Name="Comment", EmitDefaultValue=false)]
		public StringValue? Comment { get; set; }

		/// <summary>
		/// <para>DAC: PX.Objects.EP.SendCardFilter</para>
		/// <para>SQL Type: nvarchar(255)</para>
		/// </summary>
		[DataMember(Name="Email", EmitDefaultValue=false)]
		public StringValue? Email { get; set; }

		[DataMember(Name="EventNoteID", EmitDefaultValue=false)]
		public GuidValue? EventNoteID { get; set; }

		/// <summary>
		/// The invitation status of the attendee.
		/// <para>DAC Field Name: Invitation</para>
		/// <para>DAC: PX.Objects.EP.EPAttendee</para>
		/// <para>Display Name: Invitation</para>
		/// </summary>
		[DataMember(Name="InvitationStatus", EmitDefaultValue=false)]
		public StringValue? InvitationStatus { get; set; }

		[DataMember(Name="Key", EmitDefaultValue=false)]
		public StringValue? Key { get; set; }

		[DataMember(Name="Name", EmitDefaultValue=false)]
		public StringValue? Name { get; set; }

		[DataMember(Name="NameAttendeeName", EmitDefaultValue=false)]
		public StringValue? NameAttendeeName { get; set; }

		[DataMember(Name="Type", EmitDefaultValue=false)]
		public IntValue? Type { get; set; }

	}
}