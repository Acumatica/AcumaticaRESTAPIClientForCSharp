using System;
using System.Collections.Generic;
using System.Runtime.Serialization;

using Newtonsoft.Json;

using Acumatica.RESTClient.Client;
using Acumatica.RESTClient.ContractBasedApi;
using Acumatica.RESTClient.ContractBasedApi.Model;

namespace Acumatica.Default_22_200_001.Model
{
	[DataContract]
	public class EmploymentHistoryRecord : Entity
	{

		/// <summary>
		/// DAC Field Name: IsActive 
		/// DAC: PX.Objects.EP.EPEmployeePosition 
		/// </summary>
		[DataMember(Name="Active", EmitDefaultValue=false)]
		public BooleanValue? Active { get; set; }

		/// <summary>
		/// DAC: PX.Objects.EP.EPEmployeePosition 
		/// Display Name: End Date 
		/// </summary>
		[DataMember(Name="EndDate", EmitDefaultValue=false)]
		public DateTimeValue? EndDate { get; set; }

		[DataMember(Name="LineNbr", EmitDefaultValue=false)]
		public IntValue? LineNbr { get; set; }

		/// <summary>
		/// DAC: PX.Objects.EP.EPEmployeePosition 
		/// Display Name: Position 
		/// SQL Type: nvarchar(20) 
		/// </summary>
		[DataMember(Name="PositionID", EmitDefaultValue=false)]
		public StringValue? PositionID { get; set; }

		/// <summary>
		/// DAC Field Name: IsRehirable 
		/// DAC: PX.Objects.EP.EPEmployeePosition 
		/// Display Name: Eligible for Rehire 
		/// </summary>
		[DataMember(Name="RehireEligible", EmitDefaultValue=false)]
		public BooleanValue? RehireEligible { get; set; }

		/// <summary>
		/// DAC: PX.Objects.EP.EPEmployeePosition 
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