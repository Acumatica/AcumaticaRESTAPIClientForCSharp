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
	public class AppStaff : Entity
	{

		/// <summary>
		/// DAC Field Name: RefNbr 
		/// DAC: PX.Objects.FS.FSAppointment 
		/// Display Name: Appointment Nbr. 
		/// SQL Type: nvarchar(20) 
		/// Key Field
		/// </summary>
		[DataMember(Name="AppointmentNbr", EmitDefaultValue=false)]
		public StringValue? AppointmentNbr { get; set; }

		/// <summary>
		/// DAC Field Name: CostCodeID 
		/// DAC: PX.Objects.FS.FSAppointmentDet 
		/// Display Name: Cost Code 
		/// </summary>
		[DataMember(Name="CostCode", EmitDefaultValue=false)]
		public StringValue? CostCode { get; set; }

		/// <summary>
		/// DAC Field Name: FSAppointmentServiceEmployee__TranDesc 
		/// DAC: PX.Objects.FS.FSAppointmentEmployee 
		/// </summary>
		[DataMember(Name="Description", EmitDefaultValue=false)]
		public StringValue? Description { get; set; }

		/// <summary>
		/// DAC Field Name: ServiceLineRef 
		/// DAC: PX.Objects.FS.FSAppointmentEmployee 
		/// Display Name: Detail Ref. Nbr. 
		/// SQL Type: char(4) 
		/// </summary>
		[DataMember(Name="DetailLineRef", EmitDefaultValue=false)]
		public StringValue? DetailLineRef { get; set; }

		/// <summary>
		/// DAC: PX.Objects.FS.FSAppointmentEmployee 
		/// Display Name: Earning Type 
		/// SQL Type: nvarchar(15) 
		/// </summary>
		[DataMember(Name="EarningType", EmitDefaultValue=false)]
		public StringValue? EarningType { get; set; }

		/// <summary>
		/// DAC Field Name: FSAppointmentServiceEmployee__InventoryID 
		/// DAC: PX.Objects.FS.FSAppointmentEmployee 
		/// </summary>
		[DataMember(Name="InventoryID", EmitDefaultValue=false)]
		public StringValue? InventoryID { get; set; }

		/// <summary>
		/// DAC Field Name: LaborItemID 
		/// DAC: PX.Objects.FS.FSAppointmentEmployee 
		/// Display Name: Labor Item 
		/// </summary>
		[DataMember(Name="LaborItem", EmitDefaultValue=false)]
		public StringValue? LaborItem { get; set; }

		/// <summary>
		/// DAC: PX.Objects.FS.FSAppointmentDet 
		/// Display Name: Line Nbr. 
		/// Key Field
		/// </summary>
		[DataMember(Name="LineNbr", EmitDefaultValue=false)]
		public IntValue? LineNbr { get; set; }

		/// <summary>
		/// DAC: PX.Objects.FS.FSAppointmentDet 
		/// Display Name: Ref. Nbr. 
		/// SQL Type: char(4) 
		/// </summary>
		[DataMember(Name="LineRef", EmitDefaultValue=false)]
		public StringValue? LineRef { get; set; }

		/// <summary>
		/// DAC: PX.Objects.FS.FSAppointmentEmployee 
		/// Display Name: Primary Driver 
		/// </summary>
		[DataMember(Name="PrimaryDriver", EmitDefaultValue=false)]
		public BooleanValue? PrimaryDriver { get; set; }

		/// <summary>
		/// DAC Field Name: DfltProjectID 
		/// DAC: PX.Objects.FS.FSAppointmentEmployee 
		/// </summary>
		[DataMember(Name="Project", EmitDefaultValue=false)]
		public StringValue? Project { get; set; }

		/// <summary>
		/// DAC Field Name: DfltProjectTaskID 
		/// DAC: PX.Objects.FS.FSAppointment 
		/// Display Name: Default Project Task 
		/// </summary>
		[DataMember(Name="ProjectTask", EmitDefaultValue=false)]
		public StringValue? ProjectTask { get; set; }

		/// <summary>
		/// DAC Field Name: IsDriver 
		/// DAC: PX.Objects.FS.FSAppointmentEmployee 
		/// Display Name: Route Driver 
		/// </summary>
		[DataMember(Name="RouteDriver", EmitDefaultValue=false)]
		public BooleanValue? RouteDriver { get; set; }

		/// <summary>
		/// DAC Field Name: SrvOrdType 
		/// DAC: PX.Objects.FS.FSAppointment 
		/// Display Name: Service Order Type 
		/// SQL Type: char(4) 
		/// Key Field
		/// </summary>
		[DataMember(Name="ServiceOrderType", EmitDefaultValue=false)]
		public StringValue? ServiceOrderType { get; set; }

		/// <summary>
		/// DAC Field Name: EmployeeID 
		/// DAC: PX.Objects.FS.FSAppointmentEmployee 
		/// Display Name: Staff Member 
		/// </summary>
		[DataMember(Name="StaffMember", EmitDefaultValue=false)]
		public StringValue? StaffMember { get; set; }

		/// <summary>
		/// DAC Field Name: Type 
		/// DAC: PX.Objects.FS.FSLogActionStartFilter 
		/// Display Name: Logging 
		/// SQL Type: nchar(2) 
		/// </summary>
		[DataMember(Name="StaffType", EmitDefaultValue=false)]
		public StringValue? StaffType { get; set; }

		/// <summary>
		/// DAC: PX.Objects.FS.FSAppointmentEmployee 
		/// Display Name: Track Time 
		/// </summary>
		[DataMember(Name="TrackTime", EmitDefaultValue=false)]
		public BooleanValue? TrackTime { get; set; }

	}
}