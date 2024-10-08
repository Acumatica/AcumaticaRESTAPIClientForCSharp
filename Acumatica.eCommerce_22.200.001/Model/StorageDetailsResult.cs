using System;
using System.Collections.Generic;
using System.Runtime.Serialization;

using Newtonsoft.Json;

using Acumatica.RESTClient.Client;
using Acumatica.RESTClient.ContractBasedApi;
using Acumatica.RESTClient.ContractBasedApi.Model;

namespace Acumatica.eCommerce_22_200_001.Model
{
	[DataContract]
	public class StorageDetailsResult : Entity
	{

		/// <summary>
		/// DAC Field Name: BCSyncStatus_externID 
		/// DAC: PX.Data.GenericResult 
		/// </summary>
		[DataMember(Name="ProductExternID", EmitDefaultValue=false)]
		public StringValue? ProductExternID { get; set; }

		/// <summary>
		/// DAC Field Name: INSite_descr 
		/// DAC: PX.Data.GenericResult 
		/// </summary>
		[DataMember(Name="SiteCD", EmitDefaultValue=false)]
		public StringValue? SiteCD { get; set; }

		/// <summary>
		/// DAC Field Name: BCSyncDetail_externID 
		/// DAC: PX.Data.GenericResult 
		/// </summary>
		[DataMember(Name="VariantExternID", EmitDefaultValue=false)]
		public StringValue? VariantExternID { get; set; }

		[DataMember(Name="Availability", EmitDefaultValue=false)]
		public StringValue? Availability { get; set; }

		[DataMember(Name="IdentifyNoteID", EmitDefaultValue=false)]
		public StringValue? IdentifyNoteID { get; set; }

		[DataMember(Name="InventoryDescription", EmitDefaultValue=false)]
		public StringValue? InventoryDescription { get; set; }

		[DataMember(Name="InventoryCD", EmitDefaultValue=false)]
		public StringValue? InventoryCD { get; set; }

		[DataMember(Name="InventoryLastModifiedDate", EmitDefaultValue=false)]
		public DateTimeValue? InventoryLastModifiedDate { get; set; }

		[DataMember(Name="InventoryNoteID", EmitDefaultValue=false)]
		public GuidValue? InventoryNoteID { get; set; }

		[DataMember(Name="IsTemplate", EmitDefaultValue=false)]
		public BooleanValue? IsTemplate { get; set; }

		[DataMember(Name="ItemStatus", EmitDefaultValue=false)]
		public StringValue? ItemStatus { get; set; }

		[DataMember(Name="Location", EmitDefaultValue=false)]
		public StringValue? Location { get; set; }

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
		/// DAC Field Name: INLocation_descr 
		/// DAC: PX.Data.GenericResult 
		/// </summary>
		[DataMember(Name="LocationDescription", EmitDefaultValue=false)]
		public StringValue? LocationDescription { get; set; }

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

		[DataMember(Name="LotSerialNbr", EmitDefaultValue=false)]
		public StringValue? LotSerialNbr { get; set; }

		[DataMember(Name="NotAvailMode", EmitDefaultValue=false)]
		public StringValue? NotAvailMode { get; set; }

		/// <summary>
		/// DAC Field Name: BCSyncStatus_syncID 
		/// DAC: PX.Data.GenericResult 
		/// </summary>
		[DataMember(Name="ParentSyncId", EmitDefaultValue=false)]
		public IntValue? ParentSyncId { get; set; }

		/// <summary>
		/// DAC Field Name: INSiteStatus_Formula0a16a01fed80413f8bf9e3dad9e06825 
		/// DAC: PX.Data.GenericResult 
		/// </summary>
		[DataMember(Name="SiteAvailable", EmitDefaultValue=false)]
		public DecimalValue? SiteAvailable { get; set; }

		/// <summary>
		/// DAC Field Name: INSiteStatus_Formula471f423154524410bbc6ea05048fed9d 
		/// DAC: PX.Data.GenericResult 
		/// </summary>
		[DataMember(Name="SiteAvailableforIssue", EmitDefaultValue=false)]
		public DecimalValue? SiteAvailableforIssue { get; set; }

		/// <summary>
		/// DAC Field Name: INSiteStatus_Formulafa66d83f3f674cb5b8da9d9b4fdbbe5d 
		/// DAC: PX.Data.GenericResult 
		/// </summary>
		[DataMember(Name="SiteAvailableforShipping", EmitDefaultValue=false)]
		public DecimalValue? SiteAvailableforShipping { get; set; }

		/// <summary>
		/// DAC Field Name: INSite_descr 
		/// DAC: PX.Data.GenericResult 
		/// </summary>
		[DataMember(Name="SiteDescription", EmitDefaultValue=false)]
		public StringValue? SiteDescription { get; set; }

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
		/// DAC Field Name: INSiteStatus_Formuladc83c8574eec4cc3b128d402289eef80 
		/// DAC: PX.Data.GenericResult 
		/// </summary>
		[DataMember(Name="SiteOnHand", EmitDefaultValue=false)]
		public DecimalValue? SiteOnHand { get; set; }

		[DataMember(Name="TemplateItemID", EmitDefaultValue=false)]
		public StringValue? TemplateItemID { get; set; }

	}
}