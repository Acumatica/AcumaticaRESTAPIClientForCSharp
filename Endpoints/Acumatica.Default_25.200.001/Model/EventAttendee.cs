using System;
using System.Collections.Generic;

using Newtonsoft.Json;

using Acumatica.RESTClient.Client;
using Acumatica.RESTClient.ContractBasedApi;
using Acumatica.RESTClient.ContractBasedApi.Model;

namespace Acumatica.Default_25_200_001.Model
{
	public class EventAttendee : Entity
	{

		/// <summary>
		/// The comment of the event owner for the attendee.
		/// <para>DAC: PX.Objects.EP.EPAttendee</para>
		/// <para>SQL Type: nvarchar(255)</para>
		/// </summary>
		public StringValue? Comment { get; set; }

		/// <summary>
		/// <para>DAC: PX.Objects.EP.SendCardFilter</para>
		/// <para>SQL Type: nvarchar(255)</para>
		/// </summary>
		public StringValue? Email { get; set; }

		public GuidValue? EventNoteID { get; set; }

		/// <summary>
		/// The invitation status of the attendee.
		/// <para>DAC Field Name: Invitation</para>
		/// <para>DAC: PX.Objects.EP.EPAttendee</para>
		/// <para>Display Name: Invitation</para>
		/// </summary>
		public StringValue? InvitationStatus { get; set; }

		public StringValue? Key { get; set; }

		public StringValue? Name { get; set; }

		public StringValue? NameAttendeeName { get; set; }

		public IntValue? Type { get; set; }

	}
}