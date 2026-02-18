using System;
using System.Collections.Generic;

using Newtonsoft.Json;

using Acumatica.RESTClient.Client;
using Acumatica.RESTClient.ContractBasedApi;
using Acumatica.RESTClient.ContractBasedApi.Model;

namespace Acumatica.Default_23_200_001.Model
{
	public class AppStaff : Entity
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
		/// <para>DAC Field Name: CostCodeID</para>
		/// <para>DAC: PX.Objects.FS.FSAppointmentDet</para>
		/// <para>Display Name: Cost Code</para>
		/// </summary>
		public StringValue? CostCode { get; set; }

		/// <summary>
		/// <para>DAC Field Name: FSAppointmentServiceEmployee__TranDesc</para>
		/// <para>DAC: PX.Objects.FS.FSAppointmentEmployee</para>
		/// </summary>
		public StringValue? Description { get; set; }

		/// <summary>
		/// <para>DAC Field Name: ServiceLineRef</para>
		/// <para>DAC: PX.Objects.FS.FSAppointmentEmployee</para>
		/// <para>Display Name: Detail Ref. Nbr.</para>
		/// <para>SQL Type: char(4)</para>
		/// </summary>
		public StringValue? DetailLineRef { get; set; }

		/// <summary>
		/// <para>DAC: PX.Objects.FS.FSAppointmentEmployee</para>
		/// <para>Display Name: Earning Type</para>
		/// <para>SQL Type: nvarchar(15)</para>
		/// </summary>
		public StringValue? EarningType { get; set; }

		/// <summary>
		/// <para>DAC Field Name: FSAppointmentServiceEmployee__InventoryID</para>
		/// <para>DAC: PX.Objects.FS.FSAppointmentEmployee</para>
		/// </summary>
		public StringValue? InventoryID { get; set; }

		/// <summary>
		/// <para>DAC Field Name: LaborItemID</para>
		/// <para>DAC: PX.Objects.FS.FSAppointmentEmployee</para>
		/// <para>Display Name: Labor Item</para>
		/// </summary>
		public StringValue? LaborItem { get; set; }

		/// <summary>
		/// <para>DAC: PX.Objects.FS.FSAppointmentDet</para>
		/// <para>Display Name: Line Nbr.</para>
		/// Key Field
		/// </summary>
		public IntValue? LineNbr { get; set; }

		/// <summary>
		/// <para>DAC: PX.Objects.FS.FSAppointmentDet</para>
		/// <para>Display Name: Ref. Nbr.</para>
		/// <para>SQL Type: char(4)</para>
		/// </summary>
		public StringValue? LineRef { get; set; }

		/// <summary>
		/// <para>DAC: PX.Objects.FS.FSAppointmentEmployee</para>
		/// <para>Display Name: Primary Driver</para>
		/// </summary>
		public BooleanValue? PrimaryDriver { get; set; }

		/// <summary>
		/// <para>DAC Field Name: DfltProjectID</para>
		/// <para>DAC: PX.Objects.FS.FSAppointmentEmployee</para>
		/// </summary>
		public StringValue? Project { get; set; }

		/// <summary>
		/// <para>DAC Field Name: DfltProjectTaskID</para>
		/// <para>DAC: PX.Objects.FS.FSAppointment</para>
		/// <para>Display Name: Default Project Task</para>
		/// </summary>
		public StringValue? ProjectTask { get; set; }

		/// <summary>
		/// <para>DAC Field Name: IsDriver</para>
		/// <para>DAC: PX.Objects.FS.FSAppointmentEmployee</para>
		/// <para>Display Name: Route Driver</para>
		/// </summary>
		public BooleanValue? RouteDriver { get; set; }

		/// <summary>
		/// <para>DAC Field Name: SrvOrdType</para>
		/// <para>DAC: PX.Objects.FS.FSAppointment</para>
		/// <para>Display Name: Service Order Type</para>
		/// <para>SQL Type: char(4)</para>
		/// Key Field
		/// </summary>
		public StringValue? ServiceOrderType { get; set; }

		/// <summary>
		/// <para>DAC Field Name: EmployeeID</para>
		/// <para>DAC: PX.Objects.FS.FSAppointmentEmployee</para>
		/// <para>Display Name: Staff Member</para>
		/// </summary>
		public StringValue? StaffMember { get; set; }

		/// <summary>
		/// <para>DAC Field Name: Type</para>
		/// <para>DAC: PX.Objects.FS.FSLogActionStartFilter</para>
		/// <para>Display Name: Logging</para>
		/// <para>SQL Type: nchar(2)</para>
		/// </summary>
		public StringValue? StaffType { get; set; }

		/// <summary>
		/// <para>DAC: PX.Objects.FS.FSAppointmentEmployee</para>
		/// <para>Display Name: Track Time</para>
		/// </summary>
		public BooleanValue? TrackTime { get; set; }

	}
}