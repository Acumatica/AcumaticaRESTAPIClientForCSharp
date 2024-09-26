using System;
using System.Collections.Generic;
using System.Runtime.Serialization;

using Newtonsoft.Json;

using Acumatica.RESTClient.Client;
using Acumatica.RESTClient.ContractBasedApi;
using Acumatica.RESTClient.ContractBasedApi.Model;

namespace Acumatica.Default_23_200_001.Model
{
	/// <summary>
	/// Corresponds to the screen CS207510 in the Acumatica ERP
	/// </summary>
	[DataContract]
	public class ShippingZones : Entity, ITopLevelEntity
	{

		/// <summary>
		/// 
		/// Display Name:
		/// DAC Field Name: Description 
		/// DAC: PX.Objects.CS.ShippingZone 
		/// </summary>
		/// <remarks>
		/// 
		/// </remarks>
		[DataMember(Name="Description", EmitDefaultValue=false)]
		public StringValue? Description { get; set; }

		/// <summary>
		/// 
		/// Display Name:
		/// DAC Field Name: ZoneID 
		/// DAC: PX.Objects.CS.ShippingZone 
		/// </summary>
		/// <remarks>
		/// 
		/// </remarks>
		[DataMember(Name="ZoneID", EmitDefaultValue=false)]
		public StringValue? ZoneID { get; set; }

		public virtual string GetEndpointPath()
		{
			return "entity/Default/23.200.001";
		}
	}
}