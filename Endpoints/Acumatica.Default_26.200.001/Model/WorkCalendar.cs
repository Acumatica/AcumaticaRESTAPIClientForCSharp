using System;
using System.Collections.Generic;

using Newtonsoft.Json;

using Acumatica.RESTClient.Client;
using Acumatica.RESTClient.ContractBasedApi;
using Acumatica.RESTClient.ContractBasedApi.Model;

namespace Acumatica.Default_26_200_001.Model
{
	/// <summary>
	/// Corresponds to the screen <c>CS209000</c> in the Acumatica ERP
	/// <para>Key Fields: WorkCalendarID</para>
	/// </summary>
	public class WorkCalendar : Entity, ITopLevelEntity
	{

		#region Fields
		/// <summary>
		/// <para>DAC Field Name: CalendarID</para>
		/// <para>DAC: PX.Objects.CS.CSCalendar</para>
		/// <para>Display Name: Calendar ID</para>
		/// <para>SQL Type: nvarchar(10)</para>
		/// Key Field
		/// </summary>
		public StringValue? WorkCalendarID { get; set; }

		/// <summary>
		/// <para>DAC: PX.Objects.CS.CSCalendar</para>
		/// <para>SQL Type: nvarchar(60)</para>
		/// </summary>
		public StringValue? Description { get; set; }

		/// <summary>
		/// <para>DAC: PX.Objects.CS.CSCalendar</para>
		/// <para>Display Name: Time Zone</para>
		/// <para>SQL Type: nvarchar(10)</para>
		/// </summary>
		public StringValue? TimeZone { get; set; }

		#endregion

		#region LinkedEntities
		public CalendarSettings? CalendarSettings { get; set; }

		#endregion

		#region Details
		public List<WorkCalendarExceptionDetail>? CalendarExceptions { get; set; }

		#endregion

		protected override string GetDebuggerDisplay()
		{
			return $"{nameof(WorkCalendar)} - \"{WorkCalendarID}\"";
		}

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
			public const string Translations = "Translations";
			public const string CalendarExceptions = "CalendarExceptions";
			public const string CalendarSettings = "CalendarSettings";

			//Intentionally excluded
			//public const string All = "Files,Translations,CalendarExceptions,CalendarSettings";
		}
		public virtual string GetEndpointPath()
		{
			return "entity/Default/26.200.001";
		}
	}
}