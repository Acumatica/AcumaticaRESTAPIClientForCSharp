using System;
using System.Collections.Generic;

using Newtonsoft.Json;

using Acumatica.RESTClient.Client;
using Acumatica.RESTClient.ContractBasedApi;
using Acumatica.RESTClient.ContractBasedApi.Model;

namespace Acumatica.Default_23_200_001.Model
{
	public class AppProfitability : Entity
	{

		public DecimalValue? ActualAmount { get; set; }

		/// <summary>
		/// <para>DAC: PX.Objects.FS.FSAppointment</para>
		/// <para>Display Name: Actual Duration</para>
		/// </summary>
		public StringValue? ActualDuration { get; set; }

		/// <summary>
		/// <para>DAC Field Name: ActualQty</para>
		/// <para>DAC: PX.Objects.FS.FSAppointmentDet</para>
		/// <para>Display Name: Actual Quantity</para>
		/// </summary>
		public DecimalValue? ActualQuantity { get; set; }

		public DecimalValue? BillableAmount { get; set; }

		/// <summary>
		/// <para>DAC Field Name: BillableQty</para>
		/// <para>DAC: PX.Objects.FS.FSAppointmentDet</para>
		/// <para>Display Name: Billable Quantity</para>
		/// </summary>
		public DecimalValue? BillableQuantity { get; set; }

		public DecimalValue? ExtCost { get; set; }

		/// <summary>
		/// <para>DAC Field Name: Descr</para>
		/// <para>DAC: PX.Objects.FS.FSAppointmentLog</para>
		/// <para>SQL Type: nvarchar(256)</para>
		/// </summary>
		public StringValue? Description { get; set; }

		public DecimalValue? EstimatedAmount { get; set; }

		/// <summary>
		/// <para>DAC: PX.Objects.FS.FSAppointmentDet</para>
		/// <para>Display Name: Estimated Quantity</para>
		/// </summary>
		public DecimalValue? EstimatedQty { get; set; }

		/// <summary>
		/// <para>DAC Field Name: ItemID</para>
		/// <para>DAC: PX.Objects.FS.FSProfitability</para>
		/// <para>Display Name: Inventory ID</para>
		/// </summary>
		public StringValue? InventoryID { get; set; }

		/// <summary>
		/// <para>DAC: PX.Objects.FS.FSAppointmentDet</para>
		/// <para>Display Name: Ref. Nbr.</para>
		/// <para>SQL Type: char(4)</para>
		/// </summary>
		public StringValue? LineRef { get; set; }

		/// <summary>
		/// <para>DAC: PX.Objects.FS.FSAppointmentDet</para>
		/// <para>Display Name: Line Type</para>
		/// <para>SQL Type: char(5)</para>
		/// </summary>
		public StringValue? LineType { get; set; }

		public DecimalValue? Profit { get; set; }

		/// <summary>
		/// <para>DAC: PX.Objects.FS.FSAppointment</para>
		/// <para>Display Name: Profit Markup (%)</para>
		/// </summary>
		public DecimalValue? ProfitPercent { get; set; }

		/// <summary>
		/// <para>DAC Field Name: EmployeeID</para>
		/// <para>DAC: PX.Objects.FS.FSAppointmentEmployee</para>
		/// <para>Display Name: Staff Member</para>
		/// </summary>
		public StringValue? StaffMember { get; set; }

		public DecimalValue? UnitCost { get; set; }

		public DecimalValue? UnitPrice { get; set; }

	}
}