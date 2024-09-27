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
	public class TaskRelatedTask : Entity
	{

		/// <summary>
		/// The date and time when activity was completed(UIStatus was set to Completed).
		/// DAC Field Name: CompletedDate 
		/// DAC: PX.Objects.CR.CRActivity 
		/// Display Name: Completed On 
		/// </summary>
		[DataMember(Name="CompletedAt", EmitDefaultValue=false)]
		public DateTimeValue? CompletedAt { get; set; }

		[DataMember(Name="DueDate", EmitDefaultValue=false)]
		public DateTimeValue? DueDate { get; set; }

		[DataMember(Name="RecordID", EmitDefaultValue=false)]
		public IntValue? RecordID { get; set; }

		/// <summary>
		/// The start date and time of the event.
		/// DAC: PX.Objects.CR.CRChildActivity 
		/// Display Name: Start Date 
		/// </summary>
		[DataMember(Name="StartDate", EmitDefaultValue=false)]
		public DateTimeValue? StartDate { get; set; }

		/// <summary>
		/// The status of the activity.
		/// DAC Field Name: UIStatus 
		/// DAC: PX.Objects.CR.CRActivity 
		/// SQL Type: char(2) 
		/// </summary>
		[DataMember(Name="Status", EmitDefaultValue=false)]
		public StringValue? Status { get; set; }

		/// <summary>
		/// The summary description of the activity.
		/// DAC: PX.Objects.CR.CRActivity 
		/// Display Name: Summary 
		/// SQL Type: nvarchar(998) 
		/// </summary>
		[DataMember(Name="Subject", EmitDefaultValue=false)]
		public StringValue? Subject { get; set; }

	}
}