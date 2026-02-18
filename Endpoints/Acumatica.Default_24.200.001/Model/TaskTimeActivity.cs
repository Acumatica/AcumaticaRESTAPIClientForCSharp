using System;
using System.Collections.Generic;

using Newtonsoft.Json;

using Acumatica.RESTClient.Client;
using Acumatica.RESTClient.ContractBasedApi;
using Acumatica.RESTClient.ContractBasedApi.Model;

namespace Acumatica.Default_24_200_001.Model
{
	public class TaskTimeActivity : Entity
	{

		/// <summary>
		/// <para>DAC Field Name: OvertimeBillable</para>
		/// <para>DAC: PX.Objects.CR.CRChildActivity</para>
		/// <para>Display Name: Billable Overtime</para>
		/// </summary>
		public StringValue? BillableOvertime { get; set; }

		/// <summary>
		/// <para>DAC Field Name: TimeBillable</para>
		/// <para>DAC: PX.Objects.CR.CRChildActivity</para>
		/// <para>Display Name: Billable Time</para>
		/// </summary>
		public StringValue? BillableTime { get; set; }

		/// <summary>
		/// <para>DAC Field Name: CostCodeID</para>
		/// <para>DAC: PX.Objects.CR.CRChildActivity</para>
		/// <para>Display Name: Cost Code</para>
		/// </summary>
		public StringValue? CostCode { get; set; }

		/// <summary>
		/// <para>DAC Field Name: OvertimeSpent</para>
		/// <para>DAC: PX.Objects.CR.CRChildActivity</para>
		/// </summary>
		public StringValue? Overtime { get; set; }

		/// <summary>
		/// <para>DAC Field Name: ProjectID</para>
		/// <para>DAC: PX.Objects.CR.PMTimeActivity</para>
		/// </summary>
		public StringValue? Project { get; set; }

		/// <summary>
		/// <para>DAC Field Name: ProjectTaskID</para>
		/// <para>DAC: PX.Objects.CR.PMTimeActivity</para>
		/// <para>Display Name: Project Task</para>
		/// </summary>
		public StringValue? ProjectTask { get; set; }

		/// <summary>
		/// <para>DAC: PX.Objects.CR.CRChildActivity</para>
		/// <para>Display Name: Time Spent</para>
		/// </summary>
		public StringValue? TimeSpent { get; set; }

	}
}