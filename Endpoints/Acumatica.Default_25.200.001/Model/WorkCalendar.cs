using System;
using System.Collections.Generic;

using Newtonsoft.Json;

using Acumatica.RESTClient.Client;
using Acumatica.RESTClient.ContractBasedApi;
using Acumatica.RESTClient.ContractBasedApi.Model;

namespace Acumatica.Default_25_200_001.Model
{
	/// <summary>
	/// Corresponds to the screen <c>CS209000</c> in the Acumatica ERP
	/// <para>Key Fields: WorkCalendarID</para>
	/// </summary>
	public class WorkCalendar : Entity, ITopLevelEntity
	{

		public List<WorkCalendarExceptionDetail>? CalendarExceptions { get; set; }

		public CalendarSettings? CalendarSettings { get; set; }

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

		/// <summary>
		/// <para>DAC Field Name: CalendarID</para>
		/// <para>DAC: PX.Objects.CS.CSCalendar</para>
		/// <para>Display Name: Calendar ID</para>
		/// <para>SQL Type: nvarchar(10)</para>
		/// Key Field
		/// </summary>
		public StringValue? WorkCalendarID { get; set; }

		public static class Expand
		{
			public const string Files = "Files";
			public const string Translations = "Translations";
			public const string CalendarExceptions = "CalendarExceptions";
			public const string CalendarExceptions_Files = "CalendarExceptions/Files";
			public const string CalendarSettings = "CalendarSettings";

			//Intentionally excluded
			//public const string All = "Files,Translations,CalendarExceptions,CalendarExceptions/Files,CalendarSettings";
		}
		public virtual string GetEndpointPath()
		{
			return "entity/Default/25.200.001";
		}
	}
}