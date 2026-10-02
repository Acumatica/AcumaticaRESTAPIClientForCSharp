using System;
using System.Collections.Generic;

using Newtonsoft.Json;

using Acumatica.RESTClient.Client;
using Acumatica.RESTClient.ContractBasedApi;
using Acumatica.RESTClient.ContractBasedApi.Model;

namespace Acumatica.Default_26_200_001.Model
{
	public class EventTimeActivity : Entity
	{

		#region Fields
		/// <summary>
		/// <para>DAC: PX.Objects.CR.CRChildActivity</para>
		/// <para>Display Name: Time Spent</para>
		/// </summary>
		public IntSingleSelectValue? TimeSpent { get; set; }

		/// <summary>
		/// <para>DAC Field Name: OvertimeSpent</para>
		/// <para>DAC: PX.Objects.CR.CRChildActivity</para>
		/// </summary>
		public IntSingleSelectValue? Overtime { get; set; }

		/// <summary>
		/// <para>DAC Field Name: TimeBillable</para>
		/// <para>DAC: PX.Objects.CR.CRChildActivity</para>
		/// <para>Display Name: Billable Time</para>
		/// </summary>
		public IntSingleSelectValue? BillableTime { get; set; }

		/// <summary>
		/// <para>DAC Field Name: OvertimeBillable</para>
		/// <para>DAC: PX.Objects.CR.CRChildActivity</para>
		/// <para>Display Name: Billable Overtime</para>
		/// </summary>
		public IntSingleSelectValue? BillableOvertime { get; set; }

		#endregion

	}
}