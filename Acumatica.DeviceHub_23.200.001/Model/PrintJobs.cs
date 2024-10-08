using System;
using System.Collections.Generic;
using System.Runtime.Serialization;

using Newtonsoft.Json;

using Acumatica.RESTClient.Client;
using Acumatica.RESTClient.ContractBasedApi;
using Acumatica.RESTClient.ContractBasedApi.Model;

namespace Acumatica.DeviceHub_23_200_001.Model
{
	/// <summary>
	/// Corresponds to the screen SM206500 in the Acumatica ERP
	/// </summary>
	[DataContract]
	public class PrintJobs : Entity, ITopLevelEntity
	{

		/// <summary>
		/// DAC: PX.SM.SMPrintJobFilter 
		/// Display Name: End Date 
		/// </summary>
		[DataMember(Name="EndDate", EmitDefaultValue=false)]
		public DateTimeValue? EndDate { get; set; }

		[DataMember(Name="EndModifiedDateTime", EmitDefaultValue=false)]
		public DateTimeValue? EndModifiedDateTime { get; set; }

		/// <summary>
		/// DAC: PX.SM.SMPrintJobFilter 
		/// Display Name: Hide Processed 
		/// </summary>
		[DataMember(Name="HideProcessed", EmitDefaultValue=false)]
		public BooleanValue? HideProcessed { get; set; }

		/// <summary>
		/// DAC: PX.SM.SMPrintJob 
		/// Display Name: Job ID 
		/// Key Field
		/// </summary>
		[DataMember(Name="JobID", EmitDefaultValue=false)]
		public IntValue? JobID { get; set; }

		[DataMember(Name="Jobs", EmitDefaultValue=false)]
		public List<PrintJob>? Jobs { get; set; }

		/// <summary>
		/// DAC: PX.SM.SMPrintJobFilter 
		/// Display Name: Start Date 
		/// </summary>
		[DataMember(Name="StartDate", EmitDefaultValue=false)]
		public DateTimeValue? StartDate { get; set; }

		[DataMember(Name="StartModifiedDateTime", EmitDefaultValue=false)]
		public DateTimeValue? StartModifiedDateTime { get; set; }

		public virtual string GetEndpointPath()
		{
			return "entity/DeviceHub/23.200.001";
		}
	}
}