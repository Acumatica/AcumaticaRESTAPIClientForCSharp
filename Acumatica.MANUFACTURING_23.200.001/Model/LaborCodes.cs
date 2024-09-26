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
	/// Corresponds to the screen AM206500 in the Acumatica ERP
	/// </summary>
	[DataContract]
	public class LaborCodes : Entity, ITopLevelEntity
	{

		/// <summary>
		/// 
		/// Display Name:
		/// DAC Field Name: Descr 
		/// DAC: PX.Objects.AM.AMLaborCode 
		/// </summary>
		/// <remarks>
		/// 
		/// </remarks>
		[DataMember(Name="Description", EmitDefaultValue=false)]
		public StringValue? Description { get; set; }

		/// <summary>
		/// 
		/// Display Name:
		/// DAC Field Name: LaborAccountID 
		/// DAC: PX.Objects.AM.AMLaborCode 
		/// </summary>
		/// <remarks>
		/// 
		/// </remarks>
		[DataMember(Name="LaborAccount", EmitDefaultValue=false)]
		public StringValue? LaborAccount { get; set; }

		/// <summary>
		/// 
		/// Display Name:
		/// DAC Field Name: LaborCodeID 
		/// DAC: PX.Objects.AM.AMLaborCode 
		/// </summary>
		/// <remarks>
		/// 
		/// </remarks>
		[DataMember(Name="LaborCode", EmitDefaultValue=false)]
		public StringValue? LaborCode { get; set; }

		/// <summary>
		/// 
		/// Display Name:
		/// DAC Field Name: LaborSubID 
		/// DAC: PX.Objects.AM.AMLaborCode 
		/// </summary>
		/// <remarks>
		/// 
		/// </remarks>
		[DataMember(Name="LaborSub", EmitDefaultValue=false)]
		public StringValue? LaborSub { get; set; }

		/// <summary>
		/// 
		/// Display Name:
		/// DAC Field Name: OverheadAccountID 
		/// DAC: PX.Objects.AM.AMLaborCode 
		/// </summary>
		/// <remarks>
		/// 
		/// </remarks>
		[DataMember(Name="OverheadAccount", EmitDefaultValue=false)]
		public StringValue? OverheadAccount { get; set; }

		/// <summary>
		/// 
		/// Display Name:
		/// DAC Field Name: OverheadSubID 
		/// DAC: PX.Objects.AM.AMLaborCode 
		/// </summary>
		/// <remarks>
		/// 
		/// </remarks>
		[DataMember(Name="OverheadSub", EmitDefaultValue=false)]
		public StringValue? OverheadSub { get; set; }

		/// <summary>
		/// 
		/// Display Name:
		/// DAC Field Name: LaborType 
		/// DAC: PX.Objects.AM.AMLaborCode 
		/// </summary>
		/// <remarks>
		/// 
		/// </remarks>
		[DataMember(Name="Type", EmitDefaultValue=false)]
		public StringValue? Type { get; set; }

		public virtual string GetEndpointPath()
		{
			return "entity/MANUFACTURING/23.200.001";
		}
	}
}