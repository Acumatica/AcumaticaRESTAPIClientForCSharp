using System;
using System.Collections.Generic;
using System.Runtime.Serialization;

using Newtonsoft.Json;

using Acumatica.RESTClient.Client;
using Acumatica.RESTClient.ContractBasedApi;
using Acumatica.RESTClient.ContractBasedApi.Model;

namespace Acumatica.Default_26_200_001.Model
{
	[DataContract]
	public class WorkCalendar : Entity, ITopLevelEntity
	{

		[DataMember(Name="CalendarExceptions", EmitDefaultValue=false)]
		public List<WorkCalendarExceptionDetail>? CalendarExceptions { get; set; }

		[DataMember(Name="CalendarSettings", EmitDefaultValue=false)]
		public CalendarSettings? CalendarSettings { get; set; }

		[DataMember(Name="Description", EmitDefaultValue=false)]
		public StringValue? Description { get; set; }

		[DataMember(Name="TimeZone", EmitDefaultValue=false)]
		public StringValue? TimeZone { get; set; }

		[DataMember(Name="WorkCalendarID", EmitDefaultValue=false)]
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
			return "entity/Default/26.200.001";
		}
	}
}