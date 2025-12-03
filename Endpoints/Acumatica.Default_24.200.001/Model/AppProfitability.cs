using System;
using System.Collections.Generic;
using System.Runtime.Serialization;

using Newtonsoft.Json;

using Acumatica.RESTClient.Client;
using Acumatica.RESTClient.ContractBasedApi;
using Acumatica.RESTClient.ContractBasedApi.Model;

namespace Acumatica.Default_24_200_001.Model
{
	[DataContract]
	public class AppProfitability : Entity
	{

		[DataMember(Name="ActualAmount", EmitDefaultValue=false)]
		public DecimalValue? ActualAmount { get; set; }

		/// <summary>
		/// <para>DAC: PX.Objects.FS.FSAppointment</para>
		/// <para>Display Name: Actual Duration</para>
		/// </summary>
		[DataMember(Name="ActualDuration", EmitDefaultValue=false)]
		public StringValue? ActualDuration { get; set; }

		/// <summary>
		/// <para>DAC Field Name: ActualQty</para>
		/// <para>DAC: PX.Objects.FS.FSAppointmentDet</para>
		/// <para>Display Name: Actual Quantity</para>
		/// </summary>
		[DataMember(Name="ActualQuantity", EmitDefaultValue=false)]
		public DecimalValue? ActualQuantity { get; set; }

		[DataMember(Name="BillableAmount", EmitDefaultValue=false)]
		public DecimalValue? BillableAmount { get; set; }

		/// <summary>
		/// <para>DAC Field Name: BillableQty</para>
		/// <para>DAC: PX.Objects.FS.FSAppointmentDet</para>
		/// <para>Display Name: Billable Quantity</para>
		/// </summary>
		[DataMember(Name="BillableQuantity", EmitDefaultValue=false)]
		public DecimalValue? BillableQuantity { get; set; }

		[DataMember(Name="ExtCost", EmitDefaultValue=false)]
		public DecimalValue? ExtCost { get; set; }

		/// <summary>
		/// <para>DAC Field Name: Descr</para>
		/// <para>DAC: PX.Objects.FS.FSAppointmentLog</para>
		/// <para>SQL Type: nvarchar(256)</para>
		/// </summary>
		[DataMember(Name="Description", EmitDefaultValue=false)]
		public StringValue? Description { get; set; }

		[DataMember(Name="EstimatedAmount", EmitDefaultValue=false)]
		public DecimalValue? EstimatedAmount { get; set; }

		/// <summary>
		/// <para>DAC: PX.Objects.FS.FSAppointmentDet</para>
		/// <para>Display Name: Estimated Quantity</para>
		/// </summary>
		[DataMember(Name="EstimatedQty", EmitDefaultValue=false)]
		public DecimalValue? EstimatedQty { get; set; }

		/// <summary>
		/// <para>DAC Field Name: ItemID</para>
		/// <para>DAC: PX.Objects.FS.FSProfitability</para>
		/// <para>Display Name: Inventory ID</para>
		/// </summary>
		[DataMember(Name="InventoryID", EmitDefaultValue=false)]
		public StringValue? InventoryID { get; set; }

		/// <summary>
		/// <para>DAC: PX.Objects.FS.FSAppointmentDet</para>
		/// <para>Display Name: Ref. Nbr.</para>
		/// <para>SQL Type: char(4)</para>
		/// </summary>
		[DataMember(Name="LineRef", EmitDefaultValue=false)]
		public StringValue? LineRef { get; set; }

		/// <summary>
		/// <para>DAC: PX.Objects.FS.FSAppointmentDet</para>
		/// <para>Display Name: Line Type</para>
		/// <para>SQL Type: char(5)</para>
		/// </summary>
		[DataMember(Name="LineType", EmitDefaultValue=false)]
		public StringValue? LineType { get; set; }

		[DataMember(Name="Profit", EmitDefaultValue=false)]
		public DecimalValue? Profit { get; set; }

		/// <summary>
		/// <para>DAC: PX.Objects.FS.FSAppointment</para>
		/// <para>Display Name: Profit Markup (%)</para>
		/// </summary>
		[DataMember(Name="ProfitPercent", EmitDefaultValue=false)]
		public DecimalValue? ProfitPercent { get; set; }

		/// <summary>
		/// <para>DAC Field Name: EmployeeID</para>
		/// <para>DAC: PX.Objects.FS.FSAppointmentEmployee</para>
		/// <para>Display Name: Staff Member</para>
		/// </summary>
		[DataMember(Name="StaffMember", EmitDefaultValue=false)]
		public StringValue? StaffMember { get; set; }

		[DataMember(Name="UnitCost", EmitDefaultValue=false)]
		public DecimalValue? UnitCost { get; set; }

		[DataMember(Name="UnitPrice", EmitDefaultValue=false)]
		public DecimalValue? UnitPrice { get; set; }

	}
}