using System;
using System.Collections.Generic;

using Newtonsoft.Json;

using Acumatica.RESTClient.Client;
using Acumatica.RESTClient.ContractBasedApi;
using Acumatica.RESTClient.ContractBasedApi.Model;

namespace Acumatica.Default_25_200_001.Model
{
	public class ProjectTaskProperties : Entity
	{

		/// <summary>
		/// The EPEmployee that approves or rejects the activities created under the given task.
		/// <para>DAC Field Name: ApproverID</para>
		/// <para>DAC: PX.Objects.PM.PMTask</para>
		/// </summary>
		public StringValue? Approver { get; set; }

		/// <summary>
		/// The task completion state in percents. Depending on settings, this value either maintained manually or can be auto-calculated based on the budget ratio of            actual or revised values.
		/// <para>DAC Field Name: CompletedPercent</para>
		/// <para>DAC: PX.Objects.PM.PMTask</para>
		/// <para>Display Name: Completed (%)</para>
		/// </summary>
		public DecimalValue? Completed { get; set; }

		/// <summary>
		/// The calculation method of the completion.
		/// <para>DAC Field Name: CompletedPctMethod</para>
		/// <para>DAC: PX.Objects.PM.PMTask</para>
		/// <para>Display Name: Completion Method</para>
		/// <para>SQL Type: char(1)</para>
		/// </summary>
		public StringValue? CompletionMethod { get; set; }

		/// <summary>
		/// The actual date when the task is finished.
		/// <para>DAC: PX.Objects.PM.PMTask</para>
		/// <para>Display Name: End Date</para>
		/// </summary>
		public DateTimeValue? EndDate { get; set; }

		/// <summary>
		/// The date when the task is supposed to be finished.
		/// <para>DAC: PX.Objects.PM.PMTask</para>
		/// <para>Display Name: Planned End Date</para>
		/// </summary>
		public DateTimeValue? PlannedEndDate { get; set; }

		/// <summary>
		/// The date when the task is supposed to be started.
		/// <para>DAC: PX.Objects.PM.PMTask</para>
		/// <para>Display Name: Planned Start Date</para>
		/// </summary>
		public DateTimeValue? PlannedStartDate { get; set; }

		/// <summary>
		/// The actual date when the task is started.
		/// <para>DAC: PX.Objects.PM.PMTask</para>
		/// <para>Display Name: Start Date</para>
		/// </summary>
		public DateTimeValue? StartDate { get; set; }

	}
}