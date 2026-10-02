using System;
using System.Collections.Generic;

using Newtonsoft.Json;

using Acumatica.RESTClient.Client;
using Acumatica.RESTClient.ContractBasedApi;
using Acumatica.RESTClient.ContractBasedApi.Model;

namespace Acumatica.Default_26_200_001.Model
{
	public class AppProfitability : Entity
	{

		#region Fields
		/// <summary>
		/// <para>DAC: PX.Objects.FS.FSAppointment</para>
		/// <para>Display Name: Actual Duration</para>
		/// </summary>
		public StringValue? ActualDuration { get; set; }

		/// <summary>
		/// <para>DAC: PX.Objects.FS.FSAppointment</para>
		/// <para>Display Name: Profit Markup (%)</para>
		/// </summary>
		public DecimalValue? ProfitPercent { get; set; }

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

		/// <summary>
		/// <para>DAC: PX.Objects.FS.FSAppointmentDet</para>
		/// <para>Display Name: Estimated Quantity</para>
		/// </summary>
		public DecimalValue? EstimatedQty { get; set; }

		/// <summary>
		/// <para>DAC Field Name: ActualQty</para>
		/// <para>DAC: PX.Objects.FS.FSAppointmentDet</para>
		/// <para>Display Name: Actual Quantity</para>
		/// </summary>
		public DecimalValue? ActualQuantity { get; set; }

		/// <summary>
		/// <para>DAC Field Name: BillableQty</para>
		/// <para>DAC: PX.Objects.FS.FSAppointmentDet</para>
		/// <para>Display Name: Billable Quantity</para>
		/// </summary>
		public DecimalValue? BillableQuantity { get; set; }

		/// <summary>
		/// <para>DAC Field Name: EmployeeID</para>
		/// <para>DAC: PX.Objects.FS.FSAppointmentEmployee</para>
		/// <para>Display Name: Staff Member</para>
		/// </summary>
		public StringValue? StaffMember { get; set; }

		/// <summary>
		/// <para>DAC Field Name: Descr</para>
		/// <para>DAC: PX.Objects.FS.FSAppointmentLog</para>
		/// <para>SQL Type: nvarchar(256)</para>
		/// </summary>
		public StringValue? Description { get; set; }

		/// <summary>
		/// <para>DAC Field Name: ItemID</para>
		/// <para>DAC: PX.Objects.FS.FSProfitability</para>
		/// <para>Display Name: Inventory ID</para>
		/// </summary>
		public StringValue? InventoryID { get; set; }

		public DecimalValue? ActualAmount { get; set; }

		public DecimalValue? BillableAmount { get; set; }

		public DecimalValue? ExtCost { get; set; }

		public DecimalValue? EstimatedAmount { get; set; }

		public DecimalValue? Profit { get; set; }

		public DecimalValue? UnitCost { get; set; }

		public DecimalValue? UnitPrice { get; set; }

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