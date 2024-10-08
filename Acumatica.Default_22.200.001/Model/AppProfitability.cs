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
	public class AppProfitability : Entity
	{

		[DataMember(Name="ActualAmount", EmitDefaultValue=false)]
		public DecimalValue? ActualAmount { get; set; }

		/// <summary>
		/// DAC: PX.Objects.FS.FSAppointment 
		/// Display Name: Actual Duration 
		/// SQL Type: nvarchar(6) 
		/// </summary>
		[DataMember(Name="ActualDuration", EmitDefaultValue=false)]
		public StringValue? ActualDuration { get; set; }

		/// <summary>
		/// DAC Field Name: ActualQty 
		/// DAC: PX.Objects.FS.FSAppointmentDet 
		/// Display Name: Actual Quantity 
		/// </summary>
		[DataMember(Name="ActualQuantity", EmitDefaultValue=false)]
		public DecimalValue? ActualQuantity { get; set; }

		[DataMember(Name="BillableAmount", EmitDefaultValue=false)]
		public DecimalValue? BillableAmount { get; set; }

		/// <summary>
		/// DAC Field Name: BillableQty 
		/// DAC: PX.Objects.FS.FSAppointmentDet 
		/// Display Name: Billable Quantity 
		/// </summary>
		[DataMember(Name="BillableQuantity", EmitDefaultValue=false)]
		public DecimalValue? BillableQuantity { get; set; }

		[DataMember(Name="ExtCost", EmitDefaultValue=false)]
		public DecimalValue? ExtCost { get; set; }

		/// <summary>
		/// DAC Field Name: Descr 
		/// DAC: PX.Objects.FS.FSAppointmentLog 
		/// SQL Type: nvarchar(256) 
		/// </summary>
		[DataMember(Name="Description", EmitDefaultValue=false)]
		public StringValue? Description { get; set; }

		[DataMember(Name="EstimatedAmount", EmitDefaultValue=false)]
		public DecimalValue? EstimatedAmount { get; set; }

		/// <summary>
		/// DAC: PX.Objects.FS.FSAppointmentDet 
		/// Display Name: Estimated Quantity 
		/// </summary>
		[DataMember(Name="EstimatedQty", EmitDefaultValue=false)]
		public DecimalValue? EstimatedQty { get; set; }

		/// <summary>
		/// DAC Field Name: ItemID 
		/// DAC: PX.Objects.FS.FSProfitability 
		/// Display Name: Inventory ID 
		/// </summary>
		[DataMember(Name="InventoryID", EmitDefaultValue=false)]
		public StringValue? InventoryID { get; set; }

		/// <summary>
		/// DAC: PX.Objects.FS.FSAppointmentDet 
		/// Display Name: Ref. Nbr. 
		/// SQL Type: char(4) 
		/// </summary>
		[DataMember(Name="LineRef", EmitDefaultValue=false)]
		public StringValue? LineRef { get; set; }

		/// <summary>
		/// DAC: PX.Objects.FS.FSAppointmentDet 
		/// Display Name: Line Type 
		/// SQL Type: char(5) 
		/// </summary>
		[DataMember(Name="LineType", EmitDefaultValue=false)]
		public StringValue? LineType { get; set; }

		[DataMember(Name="Profit", EmitDefaultValue=false)]
		public DecimalValue? Profit { get; set; }

		/// <summary>
		/// DAC: PX.Objects.FS.FSAppointment 
		/// Display Name: Profit Markup (%) 
		/// </summary>
		[DataMember(Name="ProfitPercent", EmitDefaultValue=false)]
		public DecimalValue? ProfitPercent { get; set; }

		/// <summary>
		/// DAC Field Name: EmployeeID 
		/// DAC: PX.Objects.FS.FSAppointmentEmployee 
		/// Display Name: Staff Member 
		/// </summary>
		[DataMember(Name="StaffMember", EmitDefaultValue=false)]
		public StringValue? StaffMember { get; set; }

		[DataMember(Name="UnitCost", EmitDefaultValue=false)]
		public DecimalValue? UnitCost { get; set; }

		[DataMember(Name="UnitPrice", EmitDefaultValue=false)]
		public DecimalValue? UnitPrice { get; set; }

	}
}