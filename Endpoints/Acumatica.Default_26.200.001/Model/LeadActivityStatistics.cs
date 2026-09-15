using System;
using System.Collections.Generic;
using System.Runtime.Serialization;

using Newtonsoft.Json;

using Acumatica.RESTClient.Client;
using Acumatica.RESTClient.ContractBasedApi;
using Acumatica.RESTClient.ContractBasedApi.Model;

namespace Acumatica.Default_26_200_001.Model
{
	[DataContract]
	public class LeadActivityStatistics : Entity
	{

		[DataMember(Name="InitialOutgoingActivityCompletedAt", EmitDefaultValue=false)]
		public DateTimeValue? InitialOutgoingActivityCompletedAt { get; set; }

		[DataMember(Name="LastActivityAging", EmitDefaultValue=false)]
		public IntValue? LastActivityAging { get; set; }

		[DataMember(Name="LastActivityDate", EmitDefaultValue=false)]
		public DateTimeValue? LastActivityDate { get; set; }

		/// <summary>
		/// <para>DAC Field Name: LastIncomingActivityDate</para>
		/// <para>DAC: PX.Objects.CR.CRActivityStatistics</para>
		/// <para>Display Name: Last Incoming Activity</para>
		/// </summary>
		[DataMember(Name="LastIncomingActivity", EmitDefaultValue=false)]
		public DateTimeValue? LastIncomingActivity { get; set; }

		/// <summary>
		/// <para>DAC Field Name: LastOutgoingActivityDate</para>
		/// <para>DAC: PX.Objects.CR.CRActivityStatistics</para>
		/// <para>Display Name: Last Outgoing Activity</para>
		/// </summary>
		[DataMember(Name="LastOutgoingActivity", EmitDefaultValue=false)]
		public DateTimeValue? LastOutgoingActivity { get; set; }

		[DataMember(Name="LeadQualificationTime", EmitDefaultValue=false)]
		public IntValue? LeadQualificationTime { get; set; }

		[DataMember(Name="LeadResponseTime", EmitDefaultValue=false)]
		public IntValue? LeadResponseTime { get; set; }

	}
}