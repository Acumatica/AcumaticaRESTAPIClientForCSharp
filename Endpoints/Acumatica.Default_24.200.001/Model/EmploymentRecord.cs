using System;
using System.Collections.Generic;

using Newtonsoft.Json;

using Acumatica.RESTClient.Client;
using Acumatica.RESTClient.ContractBasedApi;
using Acumatica.RESTClient.ContractBasedApi.Model;

namespace Acumatica.Default_24_200_001.Model
{
	public class EmploymentRecord : Entity
	{

		/// <summary>
		/// <para>DAC Field Name: IsActive</para>
		/// <para>DAC: PX.Objects.PR.PREmployeeEarning</para>
		/// </summary>
		public BooleanValue? Active { get; set; }

		/// <summary>
		/// <para>DAC: PX.Objects.PR.PREmployeeEarning</para>
		/// <para>Display Name: End Date</para>
		/// </summary>
		public DateTimeValue? EndDate { get; set; }

		/// <summary>
		/// <para>DAC Field Name: SettlementPaycheckRefNoteID</para>
		/// <para>DAC: PX.Objects.EP.EPEmployeePosition</para>
		/// <para>Display Name: Final Payment</para>
		/// </summary>
		public GuidValue? FinalPayment { get; set; }

		/// <summary>
		/// <para>DAC Field Name: PositionID</para>
		/// <para>DAC: PX.Objects.EP.EPEmployeePosition</para>
		/// <para>SQL Type: nvarchar(20)</para>
		/// </summary>
		public StringValue? Position { get; set; }

		/// <summary>
		/// <para>DAC Field Name: IsRehirable</para>
		/// <para>DAC: PX.Objects.EP.EPEmployeePosition</para>
		/// <para>Display Name: Eligible for Rehire</para>
		/// </summary>
		public BooleanValue? RehireEligible { get; set; }

		/// <summary>
		/// <para>DAC: PX.Objects.PR.PREmployeeEarning</para>
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
		/// Probation period end date.
		/// <para>DAC: PX.Objects.PR.EmploymentHistory</para>
		/// <para>Display Name: Probation Period End Date</para>
		/// </summary>
		public DateTimeValue? ProbationPeriodEndDate { get; set; }

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