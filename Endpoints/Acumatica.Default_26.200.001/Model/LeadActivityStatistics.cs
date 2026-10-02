using System;
using System.Collections.Generic;

using Newtonsoft.Json;

using Acumatica.RESTClient.Client;
using Acumatica.RESTClient.ContractBasedApi;
using Acumatica.RESTClient.ContractBasedApi.Model;

namespace Acumatica.Default_26_200_001.Model
{
	public class LeadActivityStatistics : Entity
	{

		#region Fields
		/// <summary>
		/// <para>DAC Field Name: LastIncomingActivityDate</para>
		/// <para>DAC: PX.Objects.CR.CRActivityStatistics</para>
		/// <para>Display Name: Last Incoming Activity</para>
		/// </summary>
		public DateTimeValue? LastIncomingActivity { get; set; }

		/// <summary>
		/// <para>DAC Field Name: LastOutgoingActivityDate</para>
		/// <para>DAC: PX.Objects.CR.CRActivityStatistics</para>
		/// <para>Display Name: Last Outgoing Activity</para>
		/// </summary>
		public DateTimeValue? LastOutgoingActivity { get; set; }

		public DateTimeValue? InitialOutgoingActivityCompletedAt { get; set; }

		public IntValue? LastActivityAging { get; set; }

		public DateTimeValue? LastActivityDate { get; set; }

		public IntValue? LeadQualificationTime { get; set; }

		public IntValue? LeadResponseTime { get; set; }

		#endregion

	}
}