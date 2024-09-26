using System;
using System.Collections.Generic;
using System.Runtime.Serialization;

using Newtonsoft.Json;

using Acumatica.RESTClient.Client;
using Acumatica.RESTClient.ContractBasedApi;
using Acumatica.RESTClient.ContractBasedApi.Model;

namespace Acumatica.eCommerce_22_200_001.Model
{
	/// <summary>
	/// Corresponds to the screen IN203000 in the Acumatica ERP
	/// </summary>
	[DataContract]
	public class TemplateItems : Acumatica.Default_22_200_001.Model.TemplateItems, ITopLevelEntity
	{

		/// <summary>
		/// 
		/// Display Name:
		/// DAC Field Name: ABCCodeID 
		/// DAC: PX.Objects.IN.InventoryItem 
		/// </summary>
		/// <remarks>
		/// 
		/// </remarks>
		[DataMember(Name="ABCCode", EmitDefaultValue=false)]
		public StringValue? ABCCode { get; set; }

		/// <summary>
		/// 
		/// Display Name:
		/// DAC Field Name: ItemType 
		/// DAC: PX.Objects.IN.InventoryItem 
		/// </summary>
		/// <remarks>
		/// 
		/// </remarks>
		[DataMember(Name="ItemType", EmitDefaultValue=false)]
		public StringValue? ItemType { get; set; }

		/// <summary>
		/// 
		/// Display Name:
		/// DAC Field Name: LastStdCost 
		/// DAC: PX.Objects.IN.Matrix.DAC.Unbound.MatrixInventoryItem 
		/// </summary>
		/// <remarks>
		/// 
		/// </remarks>
		[DataMember(Name="LastCost", EmitDefaultValue=false)]
		public DecimalValue? LastCost { get; set; }

		/// <summary>
		/// 
		/// Display Name:
		/// DAC Field Name: PostClassID 
		/// DAC: PX.Objects.IN.InventoryItem 
		/// </summary>
		/// <remarks>
		/// 
		/// </remarks>
		[DataMember(Name="PostingClass", EmitDefaultValue=false)]
		public StringValue? PostingClass { get; set; }

		[DataMember(Name="PriceClass", EmitDefaultValue=false)]
		public StringValue? PriceClass { get; set; }

		/// <summary>
		/// 
		/// Display Name:
		/// DAC Field Name: VolumeUOM 
		/// DAC: PX.Objects.IN.InventoryItem 
		/// </summary>
		/// <remarks>
		/// 
		/// </remarks>
		[DataMember(Name="VolumeUOM", EmitDefaultValue=false)]
		public StringValue? VolumeUOM { get; set; }

		public override string GetEndpointPath()
		{
			return "entity/eCommerce/22.200.001";
		}
	}
}