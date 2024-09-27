using System;
using System.Collections.Generic;
using System.Runtime.Serialization;

using Newtonsoft.Json;

using Acumatica.RESTClient.Client;
using Acumatica.RESTClient.ContractBasedApi;
using Acumatica.RESTClient.ContractBasedApi.Model;

namespace Acumatica.Default_23_200_001.Model
{
	/// <summary>
	/// Corresponds to the screen AP202000 in the Acumatica ERP
	/// </summary>
	[DataContract]
	public class VendorPricesInquiry : Entity, ITopLevelEntity
	{

		/// <summary>
		/// DAC: PX.Objects.AP.APVendorPriceFilter 
		/// Display Name: Inventory ID 
		/// </summary>
		[DataMember(Name="InventoryID", EmitDefaultValue=false)]
		public StringValue? InventoryID { get; set; }

		/// <summary>
		/// DAC Field Name: ItemClassCD 
		/// DAC: PX.Objects.AP.APVendorPriceFilter 
		/// Display Name: Item Class 
		/// SQL Type: nvarchar(30) 
		/// </summary>
		[DataMember(Name="ItemClass", EmitDefaultValue=false)]
		public StringValue? ItemClass { get; set; }

		/// <summary>
		/// DAC Field Name: OwnerID 
		/// DAC: PX.Objects.AP.APVendorPriceFilter 
		/// Display Name: Product Manager 
		/// </summary>
		[DataMember(Name="ProductManager", EmitDefaultValue=false)]
		public StringValue? ProductManager { get; set; }

		/// <summary>
		/// DAC Field Name: WorkGroupID 
		/// DAC: PX.Objects.AP.APVendorPriceFilter 
		/// Display Name: Product Workgroup 
		/// </summary>
		[DataMember(Name="ProductWorkgroup", EmitDefaultValue=false)]
		public StringValue? ProductWorkgroup { get; set; }

		/// <summary>
		/// DAC Field Name: VendorID 
		/// DAC: PX.Objects.AP.APVendorPriceFilter 
		/// </summary>
		[DataMember(Name="Vendor", EmitDefaultValue=false)]
		public StringValue? Vendor { get; set; }

		[DataMember(Name="VendorPriceDetails", EmitDefaultValue=false)]
		public List<VendorPriceDetail>? VendorPriceDetails { get; set; }

		public virtual string GetEndpointPath()
		{
			return "entity/Default/23.200.001";
		}
	}
}