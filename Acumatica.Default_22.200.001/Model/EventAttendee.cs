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
	public class EventAttendee : Entity
	{

		/// <summary>
		/// The comment of the event owner for the attendee.
		/// DAC: PX.Objects.EP.EPAttendee 
		/// SQL Type: nvarchar(255) 
		/// </summary>
		[DataMember(Name="Comment", EmitDefaultValue=false)]
		public StringValue? Comment { get; set; }

		/// <summary>
		/// DAC: PX.Objects.EP.SendCardFilter 
		/// SQL Type: nvarchar(255) 
		/// </summary>
		[DataMember(Name="Email", EmitDefaultValue=false)]
		public StringValue? Email { get; set; }

		[DataMember(Name="EventNoteID", EmitDefaultValue=false)]
		public GuidValue? EventNoteID { get; set; }

		/// <summary>
		/// The invitation status of the attendee.
		/// DAC Field Name: Invitation 
		/// DAC: PX.Objects.EP.EPAttendee 
		/// Display Name: Invitation 
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