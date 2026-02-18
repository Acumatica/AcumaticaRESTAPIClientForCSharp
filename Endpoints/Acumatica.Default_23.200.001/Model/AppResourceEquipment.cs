using System;
using System.Collections.Generic;

using Newtonsoft.Json;

using Acumatica.RESTClient.Client;
using Acumatica.RESTClient.ContractBasedApi;
using Acumatica.RESTClient.ContractBasedApi.Model;

namespace Acumatica.Default_23_200_001.Model
{
	public class AppResourceEquipment : Entity
	{

		/// <summary>
		/// <para>DAC Field Name: RefNbr</para>
		/// <para>DAC: PX.Objects.FS.FSAppointment</para>
		/// <para>Display Name: Appointment Nbr.</para>
		/// <para>SQL Type: nvarchar(20)</para>
		/// Key Field
		/// </summary>
		public StringValue? AppointmentNbr { get; set; }

		/// <summary>
		/// <para>DAC: PX.Objects.FS.FSAppointmentDet</para>
		/// <para>Display Name: Equipment Action Comment</para>
		/// <para>SQL Type: varchar(255)</para>
		/// </summary>
		public StringValue? Comment { get; set; }

		/// <summary>
		/// <para>DAC Field Name: FSEquipment__Descr</para>
		/// <para>DAC: PX.Objects.FS.FSAppointmentResource</para>
		/// </summary>
		public StringValue? Description { get; set; }

		/// <summary>
		/// <para>DAC Field Name: SMEquipmentID</para>
		/// <para>DAC: PX.Objects.FS.FSAppointmentDet</para>
		/// <para>Display Name: Target Equipment ID</para>
		/// </summary>
		public StringValue? EquipmentID { get; set; }

		/// <summary>
		/// <para>DAC Field Name: SrvOrdType</para>
		/// <para>DAC: PX.Objects.FS.FSAppointment</para>
		/// <para>Display Name: Service Order Type</para>
		/// <para>SQL Type: char(4)</para>
		/// Key Field
		/// </summary>
		public StringValue? ServiceOrderType { get; set; }

	}
}