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
		/// 
		/// Display Name:
		/// DAC Field Name: InventoryID 
		/// DAC: PX.Objects.AP.APVendorPriceFilter 
		/// </summary>
		/// <remarks>
		/// 
		/// </remarks>
		[DataMember(Name="InventoryID", EmitDefaultValue=false)]
		public StringValue? InventoryID { get; set; }

		/// <summary>
		/// 
		/// Display Name:
		/// DAC Field Name: ItemClassCD 
		/// DAC: PX.Objects.AP.APVendorPriceFilter 
		/// </summary>
		/// <remarks>
		/// 
		/// </remarks>
		[DataMember(Name="ItemClass", EmitDefaultValue=false)]
		public StringValue? ItemClass { get; set; }

		/// <summary>
		/// 
		/// Display Name:
		/// DAC Field Name: OwnerID 
		/// DAC: PX.Objects.AP.APVendorPriceFilter 
		/// </summary>
		/// <remarks>
		/// 
		/// </remarks>
		[DataMember(Name="ProductManager", EmitDefaultValue=false)]
		public StringValue? ProductManager { get; set; }

		/// <summary>
		/// 
		/// Display Name:
		/// DAC Field Name: WorkGroupID 
		/// DAC: PX.Objects.AP.APVendorPriceFilter 
		/// </summary>
		/// <remarks>
		/// 
		/// </remarks>
		[DataMember(Name="ProductWorkgroup", EmitDefaultValue=false)]
		public StringValue? ProductWorkgroup { get; set; }

		/// <summary>
		/// 
		/// Display Name:
		/// DAC Field Name: VendorID 
		/// DAC: PX.Objects.AP.APVendorPriceFilter 
		/// </summary>
		/// <remarks>
		/// 
		/// </remarks>
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