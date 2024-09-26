using System;
using System.Collections.Generic;
using System.Runtime.Serialization;

using Newtonsoft.Json;

using Acumatica.RESTClient.Client;
using Acumatica.RESTClient.ContractBasedApi;
using Acumatica.RESTClient.ContractBasedApi.Model;

namespace Acumatica.Manufacturing_23_100_001.Model
{
	/// <summary>
	/// Corresponds to the screen AM202500 in the Acumatica ERP
	/// </summary>
	[DataContract]
	public class Overhead : Entity, ITopLevelEntity
	{

		/// <summary>
		/// 
		/// Display Name:
		/// DAC Field Name: AcctID 
		/// DAC: PX.Objects.AM.AMOverhead 
		/// </summary>
		/// <remarks>
		/// 
		/// </remarks>
		[DataMember(Name="Account", EmitDefaultValue=false)]
		public StringValue? Account { get; set; }

		/// <summary>
		/// 
		/// Display Name:
		/// DAC Field Name: CostRate 
		/// DAC: PX.Objects.AM.AMOverhead 
		/// </summary>
		/// <remarks>
		/// 
		/// </remarks>
		[DataMember(Name="CostRate", EmitDefaultValue=false)]
		public DecimalValue? CostRate { get; set; }

		/// <summary>
		/// 
		/// Display Name:
		/// DAC Field Name: Descr 
		/// DAC: PX.Objects.AM.AMOverhead 
		/// </summary>
		/// <remarks>
		/// 
		/// </remarks>
		[DataMember(Name="Description", EmitDefaultValue=false)]
		public StringValue? Description { get; set; }

		/// <summary>
		/// 
		/// Display Name:
		/// DAC Field Name: OvhdID 
		/// DAC: PX.Objects.AM.AMOverhead 
		/// </summary>
		/// <remarks>
		/// 
		/// </remarks>
		[DataMember(Name="OverheadID", EmitDefaultValue=false)]
		public StringValue? OverheadID { get; set; }

		/// <summary>
		/// 
		/// Display Name:
		/// DAC Field Name: OvhdType 
		/// DAC: PX.Objects.AM.AMOverhead 
		/// </summary>
		/// <remarks>
		/// 
		/// </remarks>
		[DataMember(Name="OverheadType", EmitDefaultValue=false)]
		public StringValue? OverheadType { get; set; }

		/// <summary>
		/// 
		/// Display Name:
		/// DAC Field Name: SubID 
		/// DAC: PX.Objects.AM.AMOverhead 
		/// </summary>
		/// <remarks>
		/// 
		/// </remarks>
		[DataMember(Name="Subaccount", EmitDefaultValue=false)]
		public StringValue? Subaccount { get; set; }

		public virtual string GetEndpointPath()
		{
			return "entity/MANUFACTURING/23.100.001";
		}
	}
}