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
		/// The EPEmployee that approves or rejects the activities created under the given task.
		/// DAC Field Name: ApproverID 
		/// DAC: PX.Objects.PM.PMTask 
		/// </summary>
		[DataMember(Name="Approver", EmitDefaultValue=false)]
		public StringValue? Approver { get; set; }

		/// <summary>
		/// The task completion state in percents. Depending on settings, this value either maintained manually or can be auto-calculated based on the budget ratio of            actual or revised values.
		/// DAC Field Name: CompletedPercent 
		/// DAC: PX.Objects.PM.PMTask 
		/// Display Name: Completed (%) 
		/// </summary>
		[DataMember(Name="Completed", EmitDefaultValue=false)]
		public DecimalValue? Completed { get; set; }

		/// <summary>
		/// The calculation method of the completion.
		/// DAC Field Name: CompletedPctMethod 
		/// DAC: PX.Objects.PM.PMTask 
		/// Display Name: Completion Method 
		/// SQL Type: char(1) 
		/// </summary>
		[DataMember(Name="CompletionMethod", EmitDefaultValue=false)]
		public StringValue? CompletionMethod { get; set; }

		/// <summary>
		/// The actual date when the task is finished.
		/// DAC: PX.Objects.PM.PMTask 
		/// Display Name: End Date 
		/// </summary>
		[DataMember(Name="EndDate", EmitDefaultValue=false)]
		public DateTimeValue? EndDate { get; set; }

		/// <summary>
		/// The date when the task is supposed to be finished.
		/// DAC: PX.Objects.PM.PMTask 
		/// Display Name: Planned End Date 
		/// </summary>
		[DataMember(Name="PlannedEndDate", EmitDefaultValue=false)]
		public DateTimeValue? PlannedEndDate { get; set; }

		/// <summary>
		/// The date when the task is supposed to be started.
		/// DAC: PX.Objects.PM.PMTask 
		/// Display Name: Planned Start Date 
		/// </summary>
		[DataMember(Name="PlannedStartDate", EmitDefaultValue=false)]
		public DateTimeValue? PlannedStartDate { get; set; }

		/// <summary>
		/// The actual date when the task is started.
		/// DAC: PX.Objects.PM.PMTask 
		/// Display Name: Start Date 
		/// </summary>
		[DataMember(Name="StartDate", EmitDefaultValue=false)]
		public DateTimeValue? StartDate { get; set; }

	}
}