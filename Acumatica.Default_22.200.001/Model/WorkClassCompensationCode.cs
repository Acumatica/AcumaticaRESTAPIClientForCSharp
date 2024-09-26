using System;
using System.Collections.Generic;
using System.Runtime.Serialization;

using Newtonsoft.Json;

using Acumatica.RESTClient.Client;
using Acumatica.RESTClient.ContractBasedApi;
using Acumatica.RESTClient.ContractBasedApi.Model;

namespace Acumatica.Default_22_200_001.Model
{
	/// <summary>
	/// Corresponds to the screen PM209800 in the Acumatica ERP
	/// </summary>
	[DataContract]
	public class WorkClassCompensationCode : Entity, ITopLevelEntity
	{

		/// <summary>
		/// 
		/// Display Name:
		/// DAC Field Name: IsActive 
		/// DAC: PX.Objects.PM.PMWorkCode 
		/// </summary>
		/// <remarks>
		/// 
		/// </remarks>
		[DataMember(Name="Active", EmitDefaultValue=false)]
		public BooleanValue? Active { get; set; }

		/// <summary>
		/// 
		/// Display Name:
		/// DAC Field Name: CostCodeFrom 
		/// DAC: PX.Objects.PM.PMWorkCodeCostCodeRange 
		/// </summary>
		/// <remarks>
		/// 
		/// </remarks>
		[DataMember(Name="CostCodeFrom", EmitDefaultValue=false)]
		public StringValue? CostCodeFrom { get; set; }

		/// <summary>
		/// 
		/// Display Name:
		/// DAC Field Name: CostCodeTo 
		/// DAC: PX.Objects.PM.PMWorkCodeCostCodeRange 
		/// </summary>
		/// <remarks>
		/// 
		/// </remarks>
		[DataMember(Name="CostCodeTo", EmitDefaultValue=false)]
		public StringValue? CostCodeTo { get; set; }

		/// <summary>
		/// 
		/// Display Name:
		/// DAC Field Name: Description 
		/// DAC: PX.Objects.PM.PMWorkCode 
		/// </summary>
		/// <remarks>
		/// 
		/// </remarks>
		[DataMember(Name="Description", EmitDefaultValue=false)]
		public StringValue? Description { get; set; }

		/// <summary>
		/// 
		/// Display Name:
		/// DAC Field Name: WorkCodeID 
		/// DAC: PX.Objects.PM.PMWorkCode 
		/// </summary>
		/// <remarks>
		/// 
		/// </remarks>
		[DataMember(Name="WCCCode", EmitDefaultValue=false)]
		public StringValue? WCCCode { get; set; }

		public virtual string GetEndpointPath()
		{
			return "entity/Default/22.200.001";
		}
	}
}