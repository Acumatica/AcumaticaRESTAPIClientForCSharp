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
		/// DAC Field Name: DeviceHubID 
		/// DAC: PX.SM.SMScanJob 
		/// Display Name: DeviceHub ID 
		/// SQL Type: varchar(30) 
		/// </summary>
		[DataMember(Name="DeviceHub", EmitDefaultValue=false)]
		public StringValue? DeviceHub { get; set; }

		/// <summary>
		/// DAC Field Name: Error 
		/// DAC: PX.SM.SMScanJob 
		/// Display Name: Error 
		/// SQL Type: nvarchar(255) 
		/// </summary>
		[DataMember(Name="ErrorMessage", EmitDefaultValue=false)]
		public StringValue? ErrorMessage { get; set; }

		[DataMember(Name="ErrorTrace", EmitDefaultValue=false)]
		public StringValue? ErrorTrace { get; set; }

		/// <summary>
		/// DAC: PX.SM.SMScanJob 
		/// Display Name: Job ID 
		/// Key Field
		/// </summary>
		[DataMember(Name="ScanJobID", EmitDefaultValue=false)]
		public IntValue? ScanJobID { get; set; }

		/// <summary>
		/// DAC Field Name: ScannerName 
		/// DAC: PX.SM.SMScanJob 
		/// Display Name: Scanner ID 
		/// SQL Type: varchar(20) 
		/// </summary>
		[DataMember(Name="Scanner", EmitDefaultValue=false)]
		public StringValue? Scanner { get; set; }

		/// <summary>
		/// DAC: PX.SM.SMScanJob 
		/// SQL Type: char(1) 
		/// </summary>
		[DataMember(Name="Status", EmitDefaultValue=false)]
		public StringValue? Status { get; set; }

		public virtual string GetEndpointPath()
		{
			return "entity/DeviceHub/23.200.001";
		}
	}
}