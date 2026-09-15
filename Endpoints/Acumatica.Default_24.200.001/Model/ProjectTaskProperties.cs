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
	public class ProjectTaskProperties : Entity
	{

		/// <summary>
		/// The identifier of the employee that approves or rejects the activities created under the given task.
		/// <para>DAC Field Name: ApproverID</para>
		/// <para>DAC: PX.Objects.PM.PMTask</para>
		/// </summary>
		[DataMember(Name="Approver", EmitDefaultValue=false)]
		public StringValue? Approver { get; set; }

		/// <summary>
		/// The task completion percentage.The value is either entered manually or calculated automaticallydepending on the CompletedPctMethod selected for the task.
		/// <para>DAC Field Name: CompletedPercent</para>
		/// <para>DAC: PX.Objects.PM.PMTask</para>
		/// <para>Display Name: Completed (%)</para>
		/// </summary>
		[DataMember(Name="Completed", EmitDefaultValue=false)]
		public DecimalValue? Completed { get; set; }

		/// <summary>
		/// The calculation method of the completion.
		/// <para>DAC Field Name: CompletedPctMethod</para>
		/// <para>DAC: PX.Objects.PM.PMTask</para>
		/// <para>Display Name: Completion Method</para>
		/// <para>SQL Type: char(1)</para>
		/// </summary>
		[DataMember(Name="CompletionMethod", EmitDefaultValue=false)]
		public StringValue? CompletionMethod { get; set; }

		/// <summary>
		/// The actual date when the task is finished.
		/// <para>DAC: PX.Objects.PM.PMTask</para>
		/// <para>Display Name: End Date</para>
		/// </summary>
		[DataMember(Name="EndDate", EmitDefaultValue=false)]
		public DateTimeValue? EndDate { get; set; }

		/// <summary>
		/// The date when the task is supposed to be finished.
		/// <para>DAC: PX.Objects.PM.PMTask</para>
		/// <para>Display Name: Planned End Date</para>
		/// </summary>
		[DataMember(Name="PlannedEndDate", EmitDefaultValue=false)]
		public DateTimeValue? PlannedEndDate { get; set; }

		/// <summary>
		/// The date when the task is supposed to be started.
		/// <para>DAC: PX.Objects.PM.PMTask</para>
		/// <para>Display Name: Planned Start Date</para>
		/// </summary>
		[DataMember(Name="PlannedStartDate", EmitDefaultValue=false)]
		public DateTimeValue? PlannedStartDate { get; set; }

		/// <summary>
		/// The actual date when the task is started.
		/// <para>DAC: PX.Objects.PM.PMTask</para>
		/// <para>Display Name: Start Date</para>
		/// </summary>
		[DataMember(Name="StartDate", EmitDefaultValue=false)]
		public DateTimeValue? StartDate { get; set; }

	}
}