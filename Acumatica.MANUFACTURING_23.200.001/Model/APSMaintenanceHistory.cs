using System;
using System.Collections.Generic;
using System.Runtime.Serialization;

using Newtonsoft.Json;

using Acumatica.RESTClient.Client;
using Acumatica.RESTClient.ContractBasedApi;
using Acumatica.RESTClient.ContractBasedApi.Model;

namespace Acumatica.Manufacturing_23_200_001.Model
{
	[DataContract]
	public class APSMaintenanceHistory : Entity
	{

		/// <summary>
		/// The user who updated the schedule block for the work center.
		/// DAC Field Name: BlockSizeSyncProcessLastRunByID 
		/// DAC: PX.Objects.AM.AMAPSMaintenanceSetup 
		/// Display Name: Block Size Sync Process Last Run By 
		/// </summary>
		[DataMember(Name="BlockSizeChangeLastRunBy", EmitDefaultValue=false)]
		public StringValue? BlockSizeChangeLastRunBy { get; set; }

		/// <summary>
		/// The date and time when the schedule blocks for the work center were last updated.
		/// DAC Field Name: BlockSizeSyncProcessLastRunDateTime 
		/// DAC: PX.Objects.AM.AMAPSMaintenanceSetup 
		/// Display Name: Block Size Sync Process Last Run Date Time 
		/// </summary>
		[DataMember(Name="BlockSizeChangeLastRunDate", EmitDefaultValue=false)]
		public DateTimeValue? BlockSizeChangeLastRunDate { get; set; }

		/// <summary>
		/// The new block size.
		/// DAC: PX.Objects.AM.AMAPSMaintenanceSetup 
		/// Display Name: Current Block Size 
		/// </summary>
		[DataMember(Name="CurrentBlockSize", EmitDefaultValue=false)]
		public StringValue? CurrentBlockSize { get; set; }

		/// <summary>
		/// The user who ran the history cleanup.
		/// DAC Field Name: HistoryCleanupProcessLastRunByID 
		/// DAC: PX.Objects.AM.AMAPSMaintenanceSetup 
		/// Display Name: History Cleanup Process Last Run By 
		/// </summary>
		[DataMember(Name="HistoryCleanupLastRunBy", EmitDefaultValue=false)]
		public StringValue? HistoryCleanupLastRunBy { get; set; }

		/// <summary>
		/// The date and time when the history was cleaned up for the last time.
		/// DAC Field Name: HistoryCleanupProcessLastRunDateTime 
		/// DAC: PX.Objects.AM.AMAPSMaintenanceSetup 
		/// Display Name: History Cleanup Process Last Run Date Time 
		/// </summary>
		[DataMember(Name="HistoryCleanupLastRunDate", EmitDefaultValue=false)]
		public DateTimeValue? HistoryCleanupLastRunDate { get; set; }

		/// <summary>
		/// The previous schedule block size.
		/// DAC: PX.Objects.AM.AMAPSMaintenanceSetup 
		/// Display Name: Last Block Size 
		/// </summary>
		[DataMember(Name="LastBlockSize", EmitDefaultValue=false)]
		public StringValue? LastBlockSize { get; set; }

		/// <summary>
		/// The user who ran the update of the work calendar parameters.
		/// DAC Field Name: WorkCalendarProcessLastRunByID 
		/// DAC: PX.Objects.AM.AMAPSMaintenanceSetup 
		/// Display Name: Work Calendar Process Last Run By 
		/// </summary>
		[DataMember(Name="WorkCalendarLastRunBy", EmitDefaultValue=false)]
		public StringValue? WorkCalendarLastRunBy { get; set; }

		/// <summary>
		/// The date and time when the work calendar process was lately run.
		/// DAC Field Name: WorkCalendarProcessLastRunDateTime 
		/// DAC: PX.Objects.AM.AMAPSMaintenanceSetup 
		/// Display Name: Work Calendar Process Last Run Date Time 
		/// </summary>
		[DataMember(Name="WorkCalendarLastRunDate", EmitDefaultValue=false)]
		public DateTimeValue? WorkCalendarLastRunDate { get; set; }

		/// <summary>
		/// The user who ran the update of the work center schedule.
		/// DAC Field Name: WorkCenterCalendarProcessLastRunByID 
		/// DAC: PX.Objects.AM.AMAPSMaintenanceSetup 
		/// Display Name: Work Center Calendar Process Last Run By 
		/// </summary>
		[DataMember(Name="WorkCenterScheduleLastRunBy", EmitDefaultValue=false)]
		public StringValue? WorkCenterScheduleLastRunBy { get; set; }

		/// <summary>
		/// The date when the work center schedule was updated for the last time.
		/// DAC Field Name: WorkCenterCalendarProcessLastRunDateTime 
		/// DAC: PX.Objects.AM.AMAPSMaintenanceSetup 
		/// Display Name: Work Center Calendar Process Last Run Date Time 
		/// </summary>
		[DataMember(Name="WorkCenterScheduleLastRunDate", EmitDefaultValue=false)]
		public DateTimeValue? WorkCenterScheduleLastRunDate { get; set; }

	}
}