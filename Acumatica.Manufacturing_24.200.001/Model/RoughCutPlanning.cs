using System;
using System.Collections.Generic;
using System.Runtime.Serialization;

using Newtonsoft.Json;

using Acumatica.RESTClient.Client;
using Acumatica.RESTClient.ContractBasedApi;
using Acumatica.RESTClient.ContractBasedApi.Model;

namespace Acumatica.Manufacturing_24_200_001.Model
{
	/// <summary>
	/// Corresponds to the screen AM501000 in the Acumatica ERP
	/// </summary>
	[DataContract]
	public class RoughCutPlanning : Entity, ITopLevelEntity
	{

		[DataMember(Name="Detail", EmitDefaultValue=false)]
		public List<RoughCutPlanningDetail>? Detail { get; set; }

		/// <summary>
		/// 
		/// Display Name:
		/// DAC Field Name: ExcludeFirmOrders 
		/// DAC: PX.Objects.AM.APSRoughCutProcessFilter 
		/// </summary>
		/// <remarks>
		/// 
		/// </remarks>
		[DataMember(Name="ExcludeFirmOrders", EmitDefaultValue=false)]
		public BooleanValue? ExcludeFirmOrders { get; set; }

		/// <summary>
		/// 
		/// Display Name:
		/// DAC Field Name: ExcludePlanningOrders 
		/// DAC: PX.Objects.AM.APSRoughCutProcessFilter 
		/// </summary>
		/// <remarks>
		/// 
		/// </remarks>
		[DataMember(Name="ExcludePlanningOrders", EmitDefaultValue=false)]
		public BooleanValue? ExcludePlanningOrders { get; set; }

		/// <summary>
		/// 
		/// Display Name:
		/// DAC Field Name: ProcessAction 
		/// DAC: PX.Objects.AM.APSRoughCutProcessFilter 
		/// </summary>
		/// <remarks>
		/// 
		/// </remarks>
		[DataMember(Name="ProcessAction", EmitDefaultValue=false)]
		public StringValue? ProcessAction { get; set; }

		/// <summary>
		/// 
		/// Display Name:
		/// DAC Field Name: ReleaseOrders 
		/// DAC: PX.Objects.AM.APSRoughCutProcessFilter 
		/// </summary>
		/// <remarks>
		/// 
		/// </remarks>
		[DataMember(Name="ReleaseOrders", EmitDefaultValue=false)]
		public BooleanValue? ReleaseOrders { get; set; }

		public virtual string GetEndpointPath()
		{
			return "entity/MANUFACTURING/24.200.001";
		}
	}
}