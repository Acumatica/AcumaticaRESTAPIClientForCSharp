using System;
using System.Collections.Generic;
using System.Runtime.Serialization;

using Newtonsoft.Json;

using Acumatica.RESTClient.Client;
using Acumatica.RESTClient.ContractBasedApi;
using Acumatica.RESTClient.ContractBasedApi.Model;

namespace Acumatica.Default_24_200_001.Model
{
	[DataContract]
	public class StorageDetail : Entity
	{

		/// <summary>
		/// DAC Field Name: InventoryItem_InventoryCD 
		/// DAC: PX.Data.GenericResult 
		/// </summary>
		[DataMember(Name="InventoryID", EmitDefaultValue=false)]
		public StringValue? InventoryID { get; set; }

		/// <summary>
		/// DAC Field Name: INSiteStatus_Formula35008a244cf145b19d8736b1575e86b4 
		/// DAC: PX.Data.GenericResult 
		/// </summary>
		[DataMember(Name="QtyAvailable", EmitDefaultValue=false)]
		public DecimalValue? QtyAvailable { get; set; }

		/// <summary>
		/// DAC Field Name: INSiteStatus_Formula7bc6165efc984511a3f7952beb2337e8 
		/// DAC: PX.Data.GenericResult 
		/// </summary>
		[DataMember(Name="QtyAvailableforIssue", EmitDefaultValue=false)]
		public DecimalValue? QtyAvailableforIssue { get; set; }

		/// <summary>
		/// DAC Field Name: INSiteStatus_Formula9ec92e4846854af1b90f879c98828563 
		/// DAC: PX.Data.GenericResult 
		/// </summary>
		[DataMember(Name="QtyHardAvailable", EmitDefaultValue=false)]
		public DecimalValue? QtyHardAvailable { get; set; }

		/// <summary>
		/// DAC Field Name: INSite_siteCD 
		/// DAC: PX.Data.GenericResult 
		/// </summary>
		[DataMember(Name="WarehouseID", EmitDefaultValue=false)]
		public StringValue? WarehouseID { get; set; }

		/// <summary>
		/// DAC Field Name: INSiteStatus_lastModifiedDateTime 
		/// DAC: PX.Data.GenericResult 
		/// </summary>
		[DataMember(Name="LastModifiedDateofWarehouseQty", EmitDefaultValue=false)]
		public DateTimeValue? LastModifiedDateofWarehouseQty { get; set; }

		/// <summary>
		/// DAC Field Name: INSiteStatus_Formulac4a8e9dac5ed48729b5908f18d941567 
		/// DAC: PX.Data.GenericResult 
		/// </summary>
		[DataMember(Name="QtyOnHand", EmitDefaultValue=false)]
		public DecimalValue? QtyOnHand { get; set; }

	}
}