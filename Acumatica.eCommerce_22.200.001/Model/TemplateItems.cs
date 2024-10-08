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
		/// The ABC code, to which the item is assigned for the purpose of physical inventories.The field is relevant only for Stock Items (see StkItem).
		/// DAC Field Name: ABCCodeID 
		/// DAC: PX.Objects.IN.InventoryItem 
		/// Display Name: ABC Code 
		/// SQL Type: char(1) 
		/// </summary>
		[DataMember(Name="ABCCode", EmitDefaultValue=false)]
		public StringValue? ABCCode { get; set; }

		/// <summary>
		/// The type of the Inventory Item.
		/// DAC: PX.Objects.IN.InventoryItem 
		/// Display Name: Type 
		/// SQL Type: char(1) 
		/// </summary>
		[DataMember(Name="ItemType", EmitDefaultValue=false)]
		public StringValue? ItemType { get; set; }

		/// <summary>
		/// The standard cost assigned to the item before the current standard cost was set.
		/// DAC Field Name: LastStdCost 
		/// DAC: PX.Objects.IN.Matrix.DAC.Unbound.MatrixInventoryItem 
		/// Display Name: Last Cost 
		/// </summary>
		[DataMember(Name="LastCost", EmitDefaultValue=false)]
		public DecimalValue? LastCost { get; set; }

		/// <summary>
		/// Identifier of the Posting Class associated with the item.
		/// DAC Field Name: PostClassID 
		/// DAC: PX.Objects.IN.InventoryItem 
		/// Display Name: Posting Class 
		/// SQL Type: nvarchar(10) 
		/// </summary>
		[DataMember(Name="PostingClass", EmitDefaultValue=false)]
		public StringValue? PostingClass { get; set; }

		[DataMember(Name="PriceClass", EmitDefaultValue=false)]
		public StringValue? PriceClass { get; set; }

		/// <summary>
		/// The Unit of Measure used for the Volume of the item.
		/// DAC: PX.Objects.IN.InventoryItem 
		/// Display Name: Volume UOM 
		/// SQL Type: nvarchar(6) 
		/// </summary>
		[DataMember(Name="VolumeUOM", EmitDefaultValue=false)]
		public StringValue? VolumeUOM { get; set; }

		public override string GetEndpointPath()
		{
			return "entity/eCommerce/22.200.001";
		}
	}
}