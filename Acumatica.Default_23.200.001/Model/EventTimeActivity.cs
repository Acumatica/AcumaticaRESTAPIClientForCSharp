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
	public class EventTimeActivity : Entity
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
		/// DAC Field Name: OvertimeSpent 
		/// DAC: PX.Objects.CR.CRChildActivity 
		/// </summary>
		[DataMember(Name="Overtime", EmitDefaultValue=false)]
		public StringValue? Overtime { get; set; }

		/// <summary>
		/// DAC: PX.Objects.CR.CRChildActivity 
		/// Display Name: Time Spent 
		/// </summary>
		[DataMember(Name="TimeSpent", EmitDefaultValue=false)]
		public StringValue? TimeSpent { get; set; }

	}
}