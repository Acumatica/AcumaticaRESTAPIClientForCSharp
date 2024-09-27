using System;
using System.Collections.Generic;
using System.Runtime.Serialization;

using Newtonsoft.Json;

using Acumatica.RESTClient.Client;
using Acumatica.RESTClient.ContractBasedApi;
using Acumatica.RESTClient.ContractBasedApi.Model;

namespace Acumatica.Default_22_200_001.Model
{
	[DataContract]
	public class SubItemStockItem : Entity
	{

		/// <summary>
		/// DAC: PX.Objects.PO.POVendorInventory 
		/// </summary>
		[DataMember(Name="Active", EmitDefaultValue=false)]
		public BooleanValue? Active { get; set; }

		/// <summary>
		/// The description of the Inventory Item.
		/// DAC Field Name: Descr 
		/// DAC: PX.Objects.IN.InventoryItem 
		/// SQL Type: nvarchar(256) 
		/// </summary>
		[DataMember(Name="Description", EmitDefaultValue=false)]
		public StringValue? Description { get; set; }

		/// <summary>
		/// DAC: PX.Objects.IN.INSubItemSegmentValue 
		/// Display Name: Segment ID 
		/// Key Field
		/// </summary>
		[DataMember(Name="SegmentID", EmitDefaultValue=false)]
		public ShortValue? SegmentID { get; set; }

		/// <summary>
		/// DAC: PX.Objects.IN.INSubItemSegmentValue 
		/// SQL Type: nvarchar(30) 
		/// Key Field
		/// </summary>
		[DataMember(Name="Value", EmitDefaultValue=false)]
		public StringValue? Value { get; set; }

	}
}