using System;
using System.Collections.Generic;

using Newtonsoft.Json;

using Acumatica.RESTClient.Client;
using Acumatica.RESTClient.ContractBasedApi;
using Acumatica.RESTClient.ContractBasedApi.Model;

namespace Acumatica.Default_26_200_001.Model
{
	public class EventAttendee : Entity
	{

		#region Fields
		/// <summary>
		/// <para>DAC: PX.Objects.EP.SendCardFilter</para>
		/// <para>SQL Type: nvarchar(255)</para>
		/// </summary>
		public StringValue? Email { get; set; }

		/// <summary>
		/// The comment of the event owner for the attendee.
		/// <para>DAC: PX.Objects.EP.EPAttendee</para>
		/// <para>SQL Type: nvarchar(255)</para>
		/// </summary>
		public StringValue? Comment { get; set; }

		/// <summary>
		/// The invitation status of the attendee.
		/// <para>DAC Field Name: Invitation</para>
		/// <para>DAC: PX.Objects.EP.EPAttendee</para>
		/// <para>Display Name: Invitation</para>
		/// </summary>
		public StringSingleSelectValue? InvitationStatus { get; set; }

		public GuidValue? EventNoteID { get; set; }

		public StringValue? Key { get; set; }

		public StringValue? Name { get; set; }

		public StringValue? NameAttendeeName { get; set; }

		public IntValue? Type { get; set; }

		#endregion

		/// <summary>
		/// Names that can be passed in the <c>$expand</c> parameter.
		/// <para>This endpoint uses system contract 5, where a nested entity is expanded
		/// as <c>Parent($expand=Child)</c> rather than <c>Parent/Child</c>, so only the names
		/// that can be expanded directly on this entity are listed here. Use the nested
		/// entity's own <c>Expand</c> class for the inner names.</para>
		/// </summary>
		public static class Expand
		{
			public const string Files = "Files";

			//Intentionally excluded
			//public const string All = "Files";
		}
	}
}