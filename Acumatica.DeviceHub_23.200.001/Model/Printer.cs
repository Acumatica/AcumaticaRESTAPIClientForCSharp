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
	/// Corresponds to the screen SM206510 in the Acumatica ERP
	/// </summary>
	[DataContract]
	public class Printer : Entity, ITopLevelEntity
	{

		/// <summary>
		/// DAC: PX.SM.SMPrinter 
		/// SQL Type: nvarchar(255) 
		/// </summary>
		[DataMember(Name="Description", EmitDefaultValue=false)]
		public StringValue? Description { get; set; }

		/// <summary>
		/// DAC Field Name: DeviceHubID 
		/// DAC: PX.SM.SMPrinter 
		/// Display Name: DeviceHub ID 
		/// SQL Type: varchar(30) 
		/// Key Field
		/// </summary>
		[DataMember(Name="DeviceHub", EmitDefaultValue=false)]
		public StringValue? DeviceHub { get; set; }

		/// <summary>
		/// DAC: PX.SM.SMPrinter 
		/// Display Name: Active 
		/// </summary>
		[DataMember(Name="IsActive", EmitDefaultValue=false)]
		public BooleanValue? IsActive { get; set; }

		/// <summary>
		/// DAC: PX.SM.SMPrinter 
		/// Display Name: Printer 
		/// SQL Type: varchar(20) 
		/// Key Field
		/// </summary>
		[DataMember(Name="PrinterName", EmitDefaultValue=false)]
		public StringValue? PrinterName { get; set; }

		public virtual string GetEndpointPath()
		{
			return "entity/DeviceHub/23.200.001";
		}
	}
}