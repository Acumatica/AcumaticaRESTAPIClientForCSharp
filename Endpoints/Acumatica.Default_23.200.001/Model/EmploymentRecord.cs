using System;
using System.Collections.Generic;
using System.Runtime.Serialization;

using Newtonsoft.Json;

using Acumatica.RESTClient.Client;
using Acumatica.RESTClient.ContractBasedApi;
using Acumatica.RESTClient.ContractBasedApi.Model;

namespace Acumatica.Default_23_200_001.Model
{
	[DataContract]
	public class EmploymentRecord : Entity
	{

		/// <summary>
		/// <para>DAC Field Name: IsActive</para>
		/// <para>DAC: PX.Objects.PR.PREmployeeEarning</para>
		/// </summary>
		[DataMember(Name="Active", EmitDefaultValue=false)]
		public BooleanValue? Active { get; set; }

		/// <summary>
		/// <para>DAC: PX.Objects.PR.PREmployeeEarning</para>
		/// <para>Display Name: End Date</para>
		/// </summary>
		[DataMember(Name="EndDate", EmitDefaultValue=false)]
		public DateTimeValue? EndDate { get; set; }

		/// <summary>
		/// <para>DAC Field Name: SettlementPaycheckRefNoteID</para>
		/// <para>DAC: PX.Objects.EP.EPEmployeePosition</para>
		/// <para>Display Name: Final Payment</para>
		/// </summary>
		[DataMember(Name="FinalPayment", EmitDefaultValue=false)]
		public GuidValue? FinalPayment { get; set; }

		/// <summary>
		/// <para>DAC Field Name: PositionID</para>
		/// <para>DAC: PX.Objects.EP.EPEmployeePosition</para>
		/// <para>SQL Type: nvarchar(20)</para>
		/// </summary>
		[DataMember(Name="Position", EmitDefaultValue=false)]
		public StringValue? Position { get; set; }

		/// <summary>
		/// <para>DAC Field Name: IsRehirable</para>
		/// <para>DAC: PX.Objects.EP.EPEmployeePosition</para>
		/// <para>Display Name: Eligible for Rehire</para>
		/// </summary>
		[DataMember(Name="RehireEligible", EmitDefaultValue=false)]
		public BooleanValue? RehireEligible { get; set; }

		/// <summary>
		/// <para>DAC: PX.Objects.PR.PREmployeeEarning</para>
		/// <para>Display Name: Start Date</para>
		/// </summary>
		[DataMember(Name="StartDate", EmitDefaultValue=false)]
		public DateTimeValue? StartDate { get; set; }

		/// <summary>
		/// <para>DAC: PX.Objects.EP.EPEmployeePosition</para>
		/// <para>Display Name: Start Reason</para>
		/// <para>SQL Type: char(3)</para>
		/// </summary>
		[DataMember(Name="StartReason", EmitDefaultValue=false)]
		public StringValue? StartReason { get; set; }

		/// <summary>
		/// <para>DAC Field Name: IsTerminated</para>
		/// <para>DAC: PX.Objects.EP.EPEmployeePosition</para>
		/// </summary>
		[DataMember(Name="Terminated", EmitDefaultValue=false)]
		public BooleanValue? Terminated { get; set; }

		/// <summary>
		/// <para>DAC Field Name: TermReason</para>
		/// <para>DAC: PX.Objects.EP.EPEmployeePosition</para>
		/// <para>Display Name: Termination Reason</para>
		/// <para>SQL Type: char(3)</para>
		/// </summary>
		[DataMember(Name="TerminationReason", EmitDefaultValue=false)]
		public StringValue? TerminationReason { get; set; }

	}
}