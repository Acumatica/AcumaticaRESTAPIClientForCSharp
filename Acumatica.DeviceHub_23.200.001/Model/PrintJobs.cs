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
		/// 
		/// Display Name:
		/// DAC Field Name: EndDate 
		/// DAC: PX.SM.SMPrintJobFilter 
		/// </summary>
		/// <remarks>
		/// 
		/// </remarks>
		[DataMember(Name="EndDate", EmitDefaultValue=false)]
		public DateTimeValue? EndDate { get; set; }

		[DataMember(Name="EndModifiedDateTime", EmitDefaultValue=false)]
		public DateTimeValue? EndModifiedDateTime { get; set; }

		/// <summary>
		/// 
		/// Display Name:
		/// DAC Field Name: HideProcessed 
		/// DAC: PX.SM.SMPrintJobFilter 
		/// </summary>
		/// <remarks>
		/// 
		/// </remarks>
		[DataMember(Name="HideProcessed", EmitDefaultValue=false)]
		public BooleanValue? HideProcessed { get; set; }

		/// <summary>
		/// 
		/// Display Name:
		/// DAC Field Name: JobID 
		/// DAC: PX.SM.SMPrintJob 
		/// </summary>
		/// <remarks>
		/// 
		/// </remarks>
		[DataMember(Name="JobID", EmitDefaultValue=false)]
		public IntValue? JobID { get; set; }

		[DataMember(Name="Jobs", EmitDefaultValue=false)]
		public List<PrintJob>? Jobs { get; set; }

		/// <summary>
		/// 
		/// Display Name:
		/// DAC Field Name: StartDate 
		/// DAC: PX.SM.SMPrintJobFilter 
		/// </summary>
		/// <remarks>
		/// 
		/// </remarks>
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