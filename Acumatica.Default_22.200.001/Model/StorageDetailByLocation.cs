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
	public class StorageDetailByLocation : Entity
	{

		/// <summary>
		/// DAC Field Name: InventoryItem_InventoryCD 
		/// DAC: PX.Data.GenericResult 
		/// </summary>
		[DataMember(Name="InventoryID", EmitDefaultValue=false)]
		public StringValue? InventoryID { get; set; }

		/// <summary>
		/// DAC Field Name: INLocationStatus_qtyAvail 
		/// DAC: PX.Data.GenericResult 
		/// </summary>
		[DataMember(Name="LocationAvailable", EmitDefaultValue=false)]
		public DecimalValue? LocationAvailable { get; set; }

		/// <summary>
		/// DAC Field Name: INLocationStatus_qtyActual 
		/// DAC: PX.Data.GenericResult 
		/// </summary>
		[DataMember(Name="LocationAvailableforIssue", EmitDefaultValue=false)]
		public DecimalValue? LocationAvailableforIssue { get; set; }

		/// <summary>
		/// DAC Field Name: INLocationStatus_qtyHardAvail 
		/// DAC: PX.Data.GenericResult 
		/// </summary>
		[DataMember(Name="LocationAvailableforShipping", EmitDefaultValue=false)]
		public DecimalValue? LocationAvailableforShipping { get; set; }

		/// <summary>
		/// DAC Field Name: INLocation_locationCD 
		/// DAC: PX.Data.GenericResult 
		/// </summary>
		[DataMember(Name="LocationID", EmitDefaultValue=false)]
		public StringValue? LocationID { get; set; }

		/// <summary>
		/// DAC Field Name: INLocationStatus_lastModifiedDateTime 
		/// DAC: PX.Data.GenericResult 
		/// </summary>
		[DataMember(Name="LocationLastModifiedDate", EmitDefaultValue=false)]
		public DateTimeValue? LocationLastModifiedDate { get; set; }

		/// <summary>
		/// DAC Field Name: INLocationStatus_qtyOnHand 
		/// DAC: PX.Data.GenericResult 
		/// </summary>
		[DataMember(Name="LocationOnHand", EmitDefaultValue=false)]
		public DecimalValue? LocationOnHand { get; set; }

		/// <summary>
		/// DAC Field Name: INSiteStatus_Formula362ff8e013ad46cd8eac6fb1a45062d8 
		/// DAC: PX.Data.GenericResult 
		/// </summary>
		[DataMember(Name="SiteAvailable", EmitDefaultValue=false)]
		public DecimalValue? SiteAvailable { get; set; }

		/// <summary>
		/// DAC Field Name: INSiteStatus_Formula19d16a8fa78b4ba999e3384f963f3d80 
		/// DAC: PX.Data.GenericResult 
		/// </summary>
		[DataMember(Name="SiteAvailableforIssue", EmitDefaultValue=false)]
		public DecimalValue? SiteAvailableforIssue { get; set; }

		/// <summary>
		/// DAC Field Name: INSiteStatus_Formula8830af1af7074f0985982d2fec1de942 
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
		/// DAC Field Name: INSiteStatus_Formula3b768cac3c944cd98406270c72ecebc1 
		/// DAC: PX.Data.GenericResult 
		/// </summary>
		[DataMember(Name="SiteOnHand", EmitDefaultValue=false)]
		public DecimalValue? SiteOnHand { get; set; }

	}
}