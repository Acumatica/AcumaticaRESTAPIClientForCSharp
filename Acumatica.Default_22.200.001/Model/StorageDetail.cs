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
		[DataMember(Name="SiteAvailable", EmitDefaultValue=false)]
		public DecimalValue? SiteAvailable { get; set; }

		/// <summary>
		/// DAC Field Name: INSiteStatus_Formula7bc6165efc984511a3f7952beb2337e8 
		/// DAC: PX.Data.GenericResult 
		/// </summary>
		[DataMember(Name="SiteAvailableforIssue", EmitDefaultValue=false)]
		public DecimalValue? SiteAvailableforIssue { get; set; }

		/// <summary>
		/// DAC Field Name: INSiteStatus_Formula9ec92e4846854af1b90f879c98828563 
		/// DAC: PX.Data.GenericResult 
		/// </summary>
		[DataMember(Name="SiteAvailableforShipping", EmitDefaultValue=false)]
		public DecimalValue? SiteAvailableforShipping { get; set; }

		/// <summary>
		/// DAC Field Name: INSite_siteCD 
		/// DAC: PX.Data.GenericResult 
		/// </summary>
		[DataMember(Name="SiteID", EmitDefaultValue=false)]
		public StringValue? SiteID { get; set; }

		/// <summary>
		/// DAC Field Name: INSiteStatus_lastModifiedDateTime 
		/// DAC: PX.Data.GenericResult 
		/// </summary>
		[DataMember(Name="SiteLastModifiedDate", EmitDefaultValue=false)]
		public DateTimeValue? SiteLastModifiedDate { get; set; }

		/// <summary>
		/// DAC Field Name: INSiteStatus_Formulac4a8e9dac5ed48729b5908f18d941567 
		/// DAC: PX.Data.GenericResult 
		/// </summary>
		[DataMember(Name="SiteOnHand", EmitDefaultValue=false)]
		public DecimalValue? SiteOnHand { get; set; }

	}
}