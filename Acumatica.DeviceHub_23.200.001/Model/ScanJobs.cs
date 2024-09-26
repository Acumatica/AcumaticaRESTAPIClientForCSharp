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
	/// Corresponds to the screen SM206505 in the Acumatica ERP
	/// </summary>
	[DataContract]
	public class ScanJobs : Entity, ITopLevelEntity
	{

		/// <summary>
		/// 
		/// Display Name:
		/// DAC Field Name: DeviceHubID 
		/// DAC: PX.SM.SMScanJob 
		/// </summary>
		/// <remarks>
		/// 
		/// </remarks>
		[DataMember(Name="DeviceHub", EmitDefaultValue=false)]
		public StringValue? DeviceHub { get; set; }

		/// <summary>
		/// 
		/// Display Name:
		/// DAC Field Name: Error 
		/// DAC: PX.SM.SMScanJob 
		/// </summary>
		/// <remarks>
		/// 
		/// </remarks>
		[DataMember(Name="ErrorMessage", EmitDefaultValue=false)]
		public StringValue? ErrorMessage { get; set; }

		[DataMember(Name="ErrorTrace", EmitDefaultValue=false)]
		public StringValue? ErrorTrace { get; set; }

		/// <summary>
		/// 
		/// Display Name:
		/// DAC Field Name: ScanJobID 
		/// DAC: PX.SM.SMScanJob 
		/// </summary>
		/// <remarks>
		/// 
		/// </remarks>
		[DataMember(Name="ScanJobID", EmitDefaultValue=false)]
		public IntValue? ScanJobID { get; set; }

		/// <summary>
		/// 
		/// Display Name:
		/// DAC Field Name: ScannerName 
		/// DAC: PX.SM.SMScanJob 
		/// </summary>
		/// <remarks>
		/// 
		/// </remarks>
		[DataMember(Name="Scanner", EmitDefaultValue=false)]
		public StringValue? Scanner { get; set; }

		/// <summary>
		/// 
		/// Display Name:
		/// DAC Field Name: Status 
		/// DAC: PX.SM.SMScanJob 
		/// </summary>
		/// <remarks>
		/// 
		/// </remarks>
		[DataMember(Name="Status", EmitDefaultValue=false)]
		public StringValue? Status { get; set; }

		public virtual string GetEndpointPath()
		{
			return "entity/DeviceHub/23.200.001";
		}
	}
}