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
	public class EmploymentRecord : Entity
	{

		/// <summary>
		/// DAC Field Name: IsActive 
		/// DAC: PX.Objects.PR.PREmployeeEarning 
		/// </summary>
		[DataMember(Name="Active", EmitDefaultValue=false)]
		public BooleanValue? Active { get; set; }

		/// <summary>
		/// DAC: PX.Objects.PR.PREmployeeEarning 
		/// Display Name: End Date 
		/// </summary>
		[DataMember(Name="EndDate", EmitDefaultValue=false)]
		public DateTimeValue? EndDate { get; set; }

		/// <summary>
		/// DAC Field Name: SettlementPaycheckRefNoteID 
		/// DAC: PX.Objects.EP.EPEmployeePosition 
		/// Display Name: Final Payment 
		/// </summary>
		[DataMember(Name="FinalPayment", EmitDefaultValue=false)]
		public GuidValue? FinalPayment { get; set; }

		/// <summary>
		/// DAC Field Name: PositionID 
		/// DAC: PX.Objects.EP.EPEmployeePosition 
		/// SQL Type: nvarchar(20) 
		/// </summary>
		[DataMember(Name="Position", EmitDefaultValue=false)]
		public StringValue? Position { get; set; }

		/// <summary>
		/// DAC Field Name: IsRehirable 
		/// DAC: PX.Objects.EP.EPEmployeePosition 
		/// Display Name: Eligible for Rehire 
		/// </summary>
		[DataMember(Name="RehireEligible", EmitDefaultValue=false)]
		public BooleanValue? RehireEligible { get; set; }

		/// <summary>
		/// DAC: PX.Objects.PR.PREmployeeEarning 
		/// Display Name: Start Date 
		/// </summary>
		[DataMember(Name="StartDate", EmitDefaultValue=false)]
		public DateTimeValue? StartDate { get; set; }

		/// <summary>
		/// DAC: PX.Objects.EP.EPEmployeePosition 
		/// Display Name: Start Reason 
		/// SQL Type: char(3) 
		/// </summary>
		[DataMember(Name="StartReason", EmitDefaultValue=false)]
		public StringValue? StartReason { get; set; }

		/// <summary>
		/// Probation period end date.
		/// DAC: PX.Objects.PR.EmploymentHistory 
		/// Display Name: Probation Period End Date 
		/// </summary>
		[DataMember(Name="ProbationPeriodEndDate", EmitDefaultValue=false)]
		public DateTimeValue? ProbationPeriodEndDate { get; set; }

		/// <summary>
		/// DAC Field Name: IsTerminated 
		/// DAC: PX.Objects.EP.EPEmployeePosition 
		/// </summary>
		[DataMember(Name="Terminated", EmitDefaultValue=false)]
		public BooleanValue? Terminated { get; set; }

		/// <summary>
		/// DAC Field Name: TermReason 
		/// DAC: PX.Objects.EP.EPEmployeePosition 
		/// Display Name: Termination Reason 
		/// SQL Type: char(3) 
		/// </summary>
		[DataMember(Name="TerminationReason", EmitDefaultValue=false)]
		public StringValue? TerminationReason { get; set; }

	}
}