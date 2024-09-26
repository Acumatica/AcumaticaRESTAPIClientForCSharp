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
	/// Corresponds to the screen AM401000 in the Acumatica ERP
	/// </summary>
	[DataContract]
	public class CriticalMaterials : Entity, ITopLevelEntity
	{

		[DataMember(Name="Detail", EmitDefaultValue=false)]
		public List<CriticalMaterialDetail>? Detail { get; set; }

		/// <summary>
		/// 
		/// Display Name:
		/// DAC Field Name: OrderType 
		/// DAC: PX.Objects.AM.ProdItemFilter 
		/// </summary>
		/// <remarks>
		/// 
		/// </remarks>
		[DataMember(Name="OrderType", EmitDefaultValue=false)]
		public StringValue? OrderType { get; set; }

		/// <summary>
		/// 
		/// Display Name:
		/// DAC Field Name: ProdOrdID 
		/// DAC: PX.Objects.AM.ProdItemFilter 
		/// </summary>
		/// <remarks>
		/// 
		/// </remarks>
		[DataMember(Name="ProductionNbr", EmitDefaultValue=false)]
		public StringValue? ProductionNbr { get; set; }

		/// <summary>
		/// 
		/// Display Name:
		/// DAC Field Name: ShowAll 
		/// DAC: PX.Objects.AM.ProdItemFilter 
		/// </summary>
		/// <remarks>
		/// 
		/// </remarks>
		[DataMember(Name="ShowAllItems", EmitDefaultValue=false)]
		public BooleanValue? ShowAllItems { get; set; }

		/// <summary>
		/// 
		/// Display Name:
		/// DAC Field Name: ShowAllocated 
		/// DAC: PX.Objects.AM.ProdItemFilter 
		/// </summary>
		/// <remarks>
		/// 
		/// </remarks>
		[DataMember(Name="ShowAllocated", EmitDefaultValue=false)]
		public BooleanValue? ShowAllocated { get; set; }

		public virtual string GetEndpointPath()
		{
			return "entity/MANUFACTURING/23.100.001";
		}
	}
}