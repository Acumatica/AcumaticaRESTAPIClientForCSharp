using System;
using System.Collections.Generic;

using Newtonsoft.Json;

using Acumatica.RESTClient.Client;
using Acumatica.RESTClient.ContractBasedApi;
using Acumatica.RESTClient.ContractBasedApi.Model;

namespace Acumatica.Default_25_200_001.Model
{
	public class TaskRelatedTask : Entity
	{

		/// <summary>
		/// The date and time when activity was completed(UIStatus was set to Completed).
		/// <para>DAC Field Name: CompletedDate</para>
		/// <para>DAC: PX.Objects.CR.CRActivity</para>
		/// <para>Display Name: Completed On</para>
		/// </summary>
		public DateTimeValue? CompletedAt { get; set; }

		public DateTimeValue? DueDate { get; set; }

		public IntValue? RecordID { get; set; }

		/// <summary>
		/// The start date and time of the event.
		/// <para>DAC: PX.Objects.CR.CRChildActivity</para>
		/// <para>Display Name: Start Date</para>
		/// </summary>
		public DateTimeValue? StartDate { get; set; }

		/// <summary>
		/// The status of the activity.
		/// <para>DAC Field Name: UIStatus</para>
		/// <para>DAC: PX.Objects.CR.CRActivity</para>
		/// <para>SQL Type: char(2)</para>
		/// </summary>
		public StringValue? Status { get; set; }

		/// <summary>
		/// The summary description of the activity.
		/// <para>DAC: PX.Objects.CR.CRActivity</para>
		/// <para>Display Name: Summary</para>
		/// <para>SQL Type: nvarchar(998)</para>
		/// </summary>
		public StringValue? Subject { get; set; }

	}
}