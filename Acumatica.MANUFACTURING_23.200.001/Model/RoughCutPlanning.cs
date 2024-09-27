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
	/// Corresponds to the screen AM501000 in the Acumatica ERP
	/// </summary>
	[DataContract]
	public class RoughCutPlanning : Entity, ITopLevelEntity
	{

		[DataMember(Name="Detail", EmitDefaultValue=false)]
		public List<RoughCutPlanningDetail>? Detail { get; set; }

		/// <summary>
		/// Show/hide orders which are schedule status Firm
		/// DAC: PX.Objects.AM.APSRoughCutProcessFilter 
		/// Display Name: Exclude Firm Orders 
		/// </summary>
		[DataMember(Name="ExcludeFirmOrders", EmitDefaultValue=false)]
		public BooleanValue? ExcludeFirmOrders { get; set; }

		/// <summary>
		/// Show/hide planning type orders
		/// DAC: PX.Objects.AM.APSRoughCutProcessFilter 
		/// Display Name: Exclude Planning Orders 
		/// </summary>
		[DataMember(Name="ExcludePlanningOrders", EmitDefaultValue=false)]
		public BooleanValue? ExcludePlanningOrders { get; set; }

		/// <summary>
		/// DAC: PX.Objects.AM.APSRoughCutProcessFilter 
		/// Display Name: Action 
		/// SQL Type: nchar(1) 
		/// </summary>
		[DataMember(Name="ProcessAction", EmitDefaultValue=false)]
		public StringValue? ProcessAction { get; set; }

		/// <summary>
		/// During processing, should the selected orders be released (true)
		/// DAC: PX.Objects.AM.APSRoughCutProcessFilter 
		/// Display Name: Release Orders 
		/// </summary>
		[DataMember(Name="ReleaseOrders", EmitDefaultValue=false)]
		public BooleanValue? ReleaseOrders { get; set; }

		public virtual string GetEndpointPath()
		{
			return "entity/MANUFACTURING/23.200.001";
		}
	}
}