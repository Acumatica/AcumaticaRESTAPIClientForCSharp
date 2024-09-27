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
	public class CarrierPluginParameter : Entity
	{

		/// <summary>
		/// DAC Field Name: Descr 
		/// DAC: PX.Objects.CS.CarrierPluginDetail 
		/// SQL Type: nvarchar(255) 
		/// </summary>
		[DataMember(Name="Description", EmitDefaultValue=false)]
		public StringValue? Description { get; set; }

		/// <summary>
		/// DAC Field Name: DetailID 
		/// DAC: PX.Objects.CS.CarrierPluginDetail 
		/// Display Name: ID 
		/// SQL Type: nvarchar(30) 
		/// Key Field
		/// </summary>
		[DataMember(Name="PluginID", EmitDefaultValue=false)]
		public StringValue? PluginID { get; set; }

		/// <summary>
		/// DAC: PX.Objects.CS.CarrierPluginDetail 
		/// SQL Type: nvarchar(1024) 
		/// </summary>
		[DataMember(Name="Value", EmitDefaultValue=false)]
		public StringValue? Value { get; set; }

	}
}