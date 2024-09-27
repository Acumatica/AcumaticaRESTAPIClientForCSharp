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
	public class TaskTimeActivity : Entity
	{

		/// <summary>
		/// DAC Field Name: OvertimeBillable 
		/// DAC: PX.Objects.CR.CRChildActivity 
		/// Display Name: Billable Overtime 
		/// </summary>
		[DataMember(Name="BillableOvertime", EmitDefaultValue=false)]
		public StringValue? BillableOvertime { get; set; }

		/// <summary>
		/// DAC Field Name: TimeBillable 
		/// DAC: PX.Objects.CR.CRChildActivity 
		/// Display Name: Billable Time 
		/// </summary>
		[DataMember(Name="BillableTime", EmitDefaultValue=false)]
		public StringValue? BillableTime { get; set; }

		/// <summary>
		/// DAC Field Name: CostCodeID 
		/// DAC: PX.Objects.CR.CRChildActivity 
		/// Display Name: Cost Code 
		/// </summary>
		[DataMember(Name="CostCode", EmitDefaultValue=false)]
		public StringValue? CostCode { get; set; }

		/// <summary>
		/// DAC Field Name: OvertimeSpent 
		/// DAC: PX.Objects.CR.CRChildActivity 
		/// </summary>
		[DataMember(Name="Overtime", EmitDefaultValue=false)]
		public StringValue? Overtime { get; set; }

		/// <summary>
		/// DAC Field Name: ProjectID 
		/// DAC: PX.Objects.CR.PMTimeActivity 
		/// </summary>
		[DataMember(Name="Project", EmitDefaultValue=false)]
		public StringValue? Project { get; set; }

		/// <summary>
		/// DAC Field Name: ProjectTaskID 
		/// DAC: PX.Objects.CR.PMTimeActivity 
		/// Display Name: Project Task 
		/// </summary>
		[DataMember(Name="ProjectTask", EmitDefaultValue=false)]
		public StringValue? ProjectTask { get; set; }

		/// <summary>
		/// DAC: PX.Objects.CR.CRChildActivity 
		/// Display Name: Time Spent 
		/// </summary>
		[DataMember(Name="TimeSpent", EmitDefaultValue=false)]
		public StringValue? TimeSpent { get; set; }

	}
}