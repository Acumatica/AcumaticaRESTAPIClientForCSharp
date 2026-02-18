using System;
using System.Collections.Generic;

using Newtonsoft.Json;

using Acumatica.RESTClient.Client;
using Acumatica.RESTClient.ContractBasedApi;
using Acumatica.RESTClient.ContractBasedApi.Model;

namespace Acumatica.MANUFACTURING_25_100_001.Model
{
	public class APSMaintenanceHistory : Entity
	{

		/// <summary>
		/// The user who updated the schedule block for the work center.
		/// <para>DAC Field Name: BlockSizeSyncProcessLastRunByID</para>
		/// <para>DAC: PX.Objects.AM.AMAPSMaintenanceSetup</para>
		/// <para>Display Name: Block Size Sync Process Last Run By</para>
		/// </summary>
		public StringValue? BlockSizeChangeLastRunBy { get; set; }

		/// <summary>
		/// The date and time when the schedule blocks for the work center were last updated.
		/// <para>DAC Field Name: BlockSizeSyncProcessLastRunDateTime</para>
		/// <para>DAC: PX.Objects.AM.AMAPSMaintenanceSetup</para>
		/// <para>Display Name: Block Size Sync Process Last Run Date Time</para>
		/// </summary>
		public DateTimeValue? BlockSizeChangeLastRunDate { get; set; }

		/// <summary>
		/// The new block size.
		/// <para>DAC: PX.Objects.AM.AMAPSMaintenanceSetup</para>
		/// <para>Display Name: Current Block Size</para>
		/// </summary>
		public StringValue? CurrentBlockSize { get; set; }

		/// <summary>
		/// The user who ran the history cleanup.
		/// <para>DAC Field Name: HistoryCleanupProcessLastRunByID</para>
		/// <para>DAC: PX.Objects.AM.AMAPSMaintenanceSetup</para>
		/// <para>Display Name: History Cleanup Process Last Run By</para>
		/// </summary>
		public StringValue? HistoryCleanupLastRunBy { get; set; }

		/// <summary>
		/// The date and time when the history was cleaned up for the last time.
		/// <para>DAC Field Name: HistoryCleanupProcessLastRunDateTime</para>
		/// <para>DAC: PX.Objects.AM.AMAPSMaintenanceSetup</para>
		/// <para>Display Name: History Cleanup Process Last Run Date Time</para>
		/// </summary>
		public DateTimeValue? HistoryCleanupLastRunDate { get; set; }

		/// <summary>
		/// The previous schedule block size.
		/// <para>DAC: PX.Objects.AM.AMAPSMaintenanceSetup</para>
		/// <para>Display Name: Last Block Size</para>
		/// </summary>
		public StringValue? LastBlockSize { get; set; }

		/// <summary>
		/// The user who ran the update of the work calendar parameters.
		/// <para>DAC Field Name: WorkCalendarProcessLastRunByID</para>
		/// <para>DAC: PX.Objects.AM.AMAPSMaintenanceSetup</para>
		/// <para>Display Name: Work Calendar Process Last Run By</para>
		/// </summary>
		public StringValue? WorkCalendarLastRunBy { get; set; }

		/// <summary>
		/// The date and time when the work calendar process was lately run.
		/// <para>DAC Field Name: WorkCalendarProcessLastRunDateTime</para>
		/// <para>DAC: PX.Objects.AM.AMAPSMaintenanceSetup</para>
		/// <para>Display Name: Work Calendar Process Last Run Date Time</para>
		/// </summary>
		public DateTimeValue? WorkCalendarLastRunDate { get; set; }

		/// <summary>
		/// The user who ran the update of the work center schedule.
		/// <para>DAC Field Name: WorkCenterCalendarProcessLastRunByID</para>
		/// <para>DAC: PX.Objects.AM.AMAPSMaintenanceSetup</para>
		/// <para>Display Name: Work Center Calendar Process Last Run By</para>
		/// </summary>
		public StringValue? WorkCenterScheduleLastRunBy { get; set; }

		/// <summary>
		/// The date when the work center schedule was updated for the last time.
		/// <para>DAC Field Name: WorkCenterCalendarProcessLastRunDateTime</para>
		/// <para>DAC: PX.Objects.AM.AMAPSMaintenanceSetup</para>
		/// <para>Display Name: Work Center Calendar Process Last Run Date Time</para>
		/// </summary>
		public DateTimeValue? WorkCenterScheduleLastRunDate { get; set; }

	}
}