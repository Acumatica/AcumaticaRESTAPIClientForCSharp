using System;
using System.Collections.Generic;
using System.Runtime.Serialization;

using Newtonsoft.Json;

using Acumatica.RESTClient.Client;
using Acumatica.RESTClient.ContractBasedApi;
using Acumatica.RESTClient.ContractBasedApi.Model;

namespace Acumatica.Default_23_200_001.Model
{
	[DataContract]
	public class ItemSalesCategoryMember : Entity
	{

		/// <summary>
		/// DAC Field Name: InventoryItem__Descr 
		/// DAC: PX.Objects.IN.INItemCategory 
		/// </summary>
		[DataMember(Name="Description", EmitDefaultValue=false)]
		public StringValue? Description { get; set; }

		/// <summary>
		/// DAC: PX.Objects.IN.INItemCategory 
		/// Display Name: Inventory ID 
		/// Key Field
		/// </summary>
		[DataMember(Name="InventoryID", EmitDefaultValue=false)]
		public StringValue? InventoryID { get; set; }

		/// <summary>
		/// DAC Field Name: InventoryItem__ItemClassID 
		/// DAC: PX.Objects.IN.INItemCategory 
		/// </summary>
		[DataMember(Name="ItemClass", EmitDefaultValue=false)]
		public StringValue? ItemClass { get; set; }

		/// <summary>
		/// DAC Field Name: InventoryItem__ItemStatus 
		/// DAC: PX.Objects.IN.INItemCategory 
		/// </summary>
		[DataMember(Name="ItemStatus", EmitDefaultValue=false)]
		public StringValue? ItemStatus { get; set; }

	}
}