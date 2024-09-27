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
	/// Corresponds to the screen CS209000 in the Acumatica ERP
	/// </summary>
	[DataContract]
	public class WorkCalendar : Entity, ITopLevelEntity
	{

		[DataMember(Name="CalendarExceptions", EmitDefaultValue=false)]
		public List<WorkCalendarExceptionDetail>? CalendarExceptions { get; set; }

		[DataMember(Name="CalendarSettings", EmitDefaultValue=false)]
		public CalendarSettings? CalendarSettings { get; set; }

		/// <summary>
		/// DAC: PX.Objects.CS.CSCalendar 
		/// SQL Type: nvarchar(60) 
		/// </summary>
		[DataMember(Name="Description", EmitDefaultValue=false)]
		public StringValue? Description { get; set; }

		/// <summary>
		/// DAC: PX.Objects.CS.CSCalendar 
		/// Display Name: Time Zone 
		/// SQL Type: nvarchar(10) 
		/// </summary>
		[DataMember(Name="TimeZone", EmitDefaultValue=false)]
		public StringValue? TimeZone { get; set; }

		/// <summary>
		/// DAC Field Name: CalendarID 
		/// DAC: PX.Objects.CS.CSCalendar 
		/// Display Name: Calendar ID 
		/// SQL Type: nvarchar(10) 
		/// Key Field
		/// </summary>
		[DataMember(Name="WorkCalendarID", EmitDefaultValue=false)]
		public StringValue? WorkCalendarID { get; set; }

		public virtual string GetEndpointPath()
		{
			return "entity/Default/23.200.001";
		}
	}
}