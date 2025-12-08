using System;
using System.Collections.Generic;
using System.Runtime.Serialization;

using Newtonsoft.Json;

using Acumatica.RESTClient.Client;
using Acumatica.RESTClient.ContractBasedApi;
using Acumatica.RESTClient.ContractBasedApi.Model;

namespace Acumatica.MANUFACTURING_25_100_001.Model
{
	[DataContract]
	public class APSMaintenanceHistory : Entity
	{

		/// <summary>
		/// The user who updated the schedule block for the work center.
		/// <para>DAC Field Name: BlockSizeSyncProcessLastRunByID</para>
		/// <para>DAC: PX.Objects.AM.AMAPSMaintenanceSetup</para>
		/// <para>Display Name: Block Size Sync Process Last Run By</para>
		/// </summary>
		[DataMember(Name="BlockSizeChangeLastRunBy", EmitDefaultValue=false)]
		public StringValue? BlockSizeChangeLastRunBy { get; set; }

		/// <summary>
		/// The date and time when the schedule blocks for the work center were last updated.
		/// <para>DAC Field Name: BlockSizeSyncProcessLastRunDateTime</para>
		/// <para>DAC: PX.Objects.AM.AMAPSMaintenanceSetup</para>
		/// <para>Display Name: Block Size Sync Process Last Run Date Time</para>
		/// </summary>
		[DataMember(Name="BlockSizeChangeLastRunDate", EmitDefaultValue=false)]
		public DateTimeValue? BlockSizeChangeLastRunDate { get; set; }

		/// <summary>
		/// The new block size.
		/// <para>DAC: PX.Objects.AM.AMAPSMaintenanceSetup</para>
		/// <para>Display Name: Current Block Size</para>
		/// </summary>
		[DataMember(Name="CurrentBlockSize", EmitDefaultValue=false)]
		public StringValue? CurrentBlockSize { get; set; }

		/// <summary>
		/// The user who ran the history cleanup.
		/// <para>DAC Field Name: HistoryCleanupProcessLastRunByID</para>
		/// <para>DAC: PX.Objects.AM.AMAPSMaintenanceSetup</para>
		/// <para>Display Name: History Cleanup Process Last Run By</para>
		/// </summary>
		[DataMember(Name="HistoryCleanupLastRunBy", EmitDefaultValue=false)]
		public StringValue? HistoryCleanupLastRunBy { get; set; }

		/// <summary>
		/// The date and time when the history was cleaned up for the last time.
		/// <para>DAC Field Name: HistoryCleanupProcessLastRunDateTime</para>
		/// <para>DAC: PX.Objects.AM.AMAPSMaintenanceSetup</para>
		/// <para>Display Name: History Cleanup Process Last Run Date Time</para>
		/// </summary>
		[DataMember(Name="HistoryCleanupLastRunDate", EmitDefaultValue=false)]
		public DateTimeValue? HistoryCleanupLastRunDate { get; set; }

		/// <summary>
		/// The previous schedule block size.
		/// <para>DAC: PX.Objects.AM.AMAPSMaintenanceSetup</para>
		/// <para>Display Name: Last Block Size</para>
		/// </summary>
		[DataMember(Name="LastBlockSize", EmitDefaultValue=false)]
		public StringValue? LastBlockSize { get; set; }

		/// <summary>
		/// The user who ran the update of the work calendar parameters.
		/// <para>DAC Field Name: WorkCalendarProcessLastRunByID</para>
		/// <para>DAC: PX.Objects.AM.AMAPSMaintenanceSetup</para>
		/// <para>Display Name: Work Calendar Process Last Run By</para>
		/// </summary>
		[DataMember(Name="WorkCalendarLastRunBy", EmitDefaultValue=false)]
		public StringValue? WorkCalendarLastRunBy { get; set; }

		/// <summary>
		/// The date and time when the work calendar process was lately run.
		/// <para>DAC Field Name: WorkCalendarProcessLastRunDateTime</para>
		/// <para>DAC: PX.Objects.AM.AMAPSMaintenanceSetup</para>
		/// <para>Display Name: Work Calendar Process Last Run Date Time</para>
		/// </summary>
		[DataMember(Name="WorkCalendarLastRunDate", EmitDefaultValue=false)]
		public DateTimeValue? WorkCalendarLastRunDate { get; set; }

		/// <summary>
		/// The user who ran the update of the work center schedule.
		/// <para>DAC Field Name: WorkCenterCalendarProcessLastRunByID</para>
		/// <para>DAC: PX.Objects.AM.AMAPSMaintenanceSetup</para>
		/// <para>Display Name: Work Center Calendar Process Last Run By</para>
		/// </summary>
		[DataMember(Name="WorkCenterScheduleLastRunBy", EmitDefaultValue=false)]
		public StringValue? WorkCenterScheduleLastRunBy { get; set; }

		/// <summary>
		/// The date when the work center schedule was updated for the last time.
		/// <para>DAC Field Name: WorkCenterCalendarProcessLastRunDateTime</para>
		/// <para>DAC: PX.Objects.AM.AMAPSMaintenanceSetup</para>
		/// <para>Display Name: Work Center Calendar Process Last Run Date Time</para>
		/// </summary>
		[DataMember(Name="WorkCenterScheduleLastRunDate", EmitDefaultValue=false)]
		public DateTimeValue? WorkCenterScheduleLastRunDate { get; set; }

	}
}