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
	public class SrvOrdAppointments : Entity
	{

		/// <summary>
		/// DAC Field Name: RefNbr 
		/// DAC: PX.Objects.FS.FSServiceOrder 
		/// Display Name: Order Nbr. 
		/// SQL Type: nvarchar(15) 
		/// Key Field
		/// </summary>
		[DataMember(Name="AppointmentNbr", EmitDefaultValue=false)]
		public StringValue? AppointmentNbr { get; set; }

		/// <summary>
		/// DAC: PX.Objects.FS.FSAppointment 
		/// </summary>
		[DataMember(Name="Confirmed", EmitDefaultValue=false)]
		public BooleanValue? Confirmed { get; set; }

		/// <summary>
		/// DAC Field Name: ScheduledDateTimeEnd_Date 
		/// DAC: PX.Objects.FS.FSAppointment 
		/// </summary>
		[DataMember(Name="ScheduledEndDate", EmitDefaultValue=false)]
		public DateTimeValue? ScheduledEndDate { get; set; }

		/// <summary>
		/// DAC Field Name: ScheduledDateTimeEnd_Time 
		/// DAC: PX.Objects.FS.FSAppointment 
		/// </summary>
		[DataMember(Name="ScheduledEndTime", EmitDefaultValue=false)]
		public DateTimeValue? ScheduledEndTime { get; set; }

		/// <summary>
		/// DAC Field Name: ScheduledDateTimeBegin_Date 
		/// DAC: PX.Objects.FS.FSAppointment 
		/// </summary>
		[DataMember(Name="ScheduledStartDate", EmitDefaultValue=false)]
		public DateTimeValue? ScheduledStartDate { get; set; }

		/// <summary>
		/// DAC Field Name: ScheduledDateTimeBegin_Time 
		/// DAC: PX.Objects.FS.FSAppointment 
		/// </summary>
		[DataMember(Name="ScheduledStartTime", EmitDefaultValue=false)]
		public DateTimeValue? ScheduledStartTime { get; set; }

		/// <summary>
		/// DAC Field Name: SrvOrdType 
		/// DAC: PX.Objects.FS.FSServiceOrder 
		/// Display Name: Order Type 
		/// SQL Type: char(4) 
		/// Key Field
		/// </summary>
		[DataMember(Name="ServiceOrderType", EmitDefaultValue=false)]
		public StringValue? ServiceOrderType { get; set; }

		/// <summary>
		/// DAC: PX.Objects.FS.FSServiceOrder 
		/// SQL Type: char(1) 
		/// </summary>
		[DataMember(Name="Status", EmitDefaultValue=false)]
		public StringValue? Status { get; set; }

	}
}