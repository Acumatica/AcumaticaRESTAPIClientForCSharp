using System;
using System.Collections.Generic;

using Newtonsoft.Json;

using Acumatica.RESTClient.Client;
using Acumatica.RESTClient.ContractBasedApi;
using Acumatica.RESTClient.ContractBasedApi.Model;

namespace Acumatica.Default_23_200_001.Model
{
	public class EmploymentHistoryRecord : Entity
	{

		/// <summary>
		/// <para>DAC Field Name: IsActive</para>
		/// <para>DAC: PX.Objects.EP.EPEmployeePosition</para>
		/// </summary>
		public BooleanValue? Active { get; set; }

		/// <summary>
		/// <para>DAC: PX.Objects.EP.EPEmployeePosition</para>
		/// <para>Display Name: End Date</para>
		/// </summary>
		public DateTimeValue? EndDate { get; set; }

		public IntValue? LineNbr { get; set; }

		/// <summary>
		/// <para>DAC: PX.Objects.EP.EPEmployeePosition</para>
		/// <para>Display Name: Position</para>
		/// <para>SQL Type: nvarchar(20)</para>
		/// </summary>
		public StringValue? PositionID { get; set; }

		/// <summary>
		/// <para>DAC Field Name: IsRehirable</para>
		/// <para>DAC: PX.Objects.EP.EPEmployeePosition</para>
		/// <para>Display Name: Eligible for Rehire</para>
		/// </summary>
		public BooleanValue? RehireEligible { get; set; }

		/// <summary>
		/// <para>DAC: PX.Objects.EP.EPEmployeePosition</para>
		/// <para>Display Name: Start Date</para>
		/// </summary>
		public DateTimeValue? StartDate { get; set; }

		/// <summary>
		/// <para>DAC: PX.Objects.EP.EPEmployeePosition</para>
		/// <para>Display Name: Start Reason</para>
		/// <para>SQL Type: char(3)</para>
		/// </summary>
		public StringValue? StartReason { get; set; }

		/// <summary>
		/// <para>DAC Field Name: IsTerminated</para>
		/// <para>DAC: PX.Objects.EP.EPEmployeePosition</para>
		/// </summary>
		public BooleanValue? Terminated { get; set; }

		/// <summary>
		/// <para>DAC Field Name: TermReason</para>
		/// <para>DAC: PX.Objects.EP.EPEmployeePosition</para>
		/// <para>Display Name: Termination Reason</para>
		/// <para>SQL Type: char(3)</para>
		/// </summary>
		public StringValue? TerminationReason { get; set; }

	}
}