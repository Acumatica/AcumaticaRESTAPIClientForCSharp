using System;
using System.Collections.Generic;
using System.Runtime.Serialization;

using Newtonsoft.Json;

using Acumatica.RESTClient.Client;
using Acumatica.RESTClient.ContractBasedApi;
using Acumatica.RESTClient.ContractBasedApi.Model;

namespace Acumatica.Manufacturing_23_200_001.Model
{
	/// <summary>
	/// Corresponds to the screen AM515000 in the Acumatica ERP
	/// </summary>
	[DataContract]
	public class CapableToPromise : Entity, ITopLevelEntity
	{

		[DataMember(Name="Details", EmitDefaultValue=false)]
		public List<CapableToPromiseDetail>? Details { get; set; }

		/// <summary>
		/// DAC: PX.Objects.AM.CTPProcess+CTPFilter 
		/// </summary>
		[DataMember(Name="ProcessAction", EmitDefaultValue=false)]
		public StringValue? ProcessAction { get; set; }

		/// <summary>
		/// DAC Field Name: DefaultOrderType 
		/// DAC: PX.Objects.AM.CTPProcess+CTPFilter 
		/// </summary>
		[DataMember(Name="RegularProductionOrderType", EmitDefaultValue=false)]
		public StringValue? RegularProductionOrderType { get; set; }

		/// <summary>
		/// DAC Field Name: SOOrderNbr 
		/// DAC: PX.Objects.AM.CTPProcess+CTPFilter 
		/// </summary>
		[DataMember(Name="SONbr", EmitDefaultValue=false)]
		public StringValue? SONbr { get; set; }

		/// <summary>
		/// DAC Field Name: SOOrderType 
		/// DAC: PX.Objects.AM.CTPProcess+CTPFilter 
		/// </summary>
		[DataMember(Name="SOType", EmitDefaultValue=false)]
		public StringValue? SOType { get; set; }

		public virtual string GetEndpointPath()
		{
			return "entity/MANUFACTURING/23.200.001";
		}
	}
}