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
		/// DAC Field Name: IsActive 
		/// DAC: PX.Objects.PM.PMWorkCode 
		/// </summary>
		[DataMember(Name="Active", EmitDefaultValue=false)]
		public BooleanValue? Active { get; set; }

		/// <summary>
		/// DAC: PX.Objects.PM.PMWorkCodeCostCodeRange 
		/// Display Name: Cost Code From 
		/// SQL Type: nvarchar(30) 
		/// </summary>
		[DataMember(Name="CostCodeFrom", EmitDefaultValue=false)]
		public StringValue? CostCodeFrom { get; set; }

		/// <summary>
		/// DAC: PX.Objects.PM.PMWorkCodeCostCodeRange 
		/// Display Name: Cost Code To 
		/// SQL Type: nvarchar(30) 
		/// </summary>
		[DataMember(Name="CostCodeTo", EmitDefaultValue=false)]
		public StringValue? CostCodeTo { get; set; }

		/// <summary>
		/// DAC: PX.Objects.PM.PMWorkCode 
		/// SQL Type: nvarchar(255) 
		/// </summary>
		[DataMember(Name="Description", EmitDefaultValue=false)]
		public StringValue? Description { get; set; }

		/// <summary>
		/// DAC Field Name: WorkCodeID 
		/// DAC: PX.Objects.PM.PMWorkCode 
		/// Display Name: WCC Code 
		/// SQL Type: nvarchar(15) 
		/// Key Field
		/// </summary>
		[DataMember(Name="WCCCode", EmitDefaultValue=false)]
		public StringValue? WCCCode { get; set; }

		public virtual string GetEndpointPath()
		{
			return "entity/Default/22.200.001";
		}
	}
}