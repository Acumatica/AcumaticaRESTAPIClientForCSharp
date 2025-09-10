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
		[DataMember(Name="QtyAvailableinLocation", EmitDefaultValue=false)]
		public DecimalValue? QtyAvailableinLocation { get; set; }

		/// <summary>
		/// DAC Field Name: INLocationStatus_qtyActual 
		/// DAC: PX.Data.GenericResult 
		/// </summary>
		[DataMember(Name="QtyAvailableforIssueinLocation", EmitDefaultValue=false)]
		public DecimalValue? QtyAvailableforIssueinLocation { get; set; }

		/// <summary>
		/// DAC Field Name: INLocationStatus_qtyHardAvail 
		/// DAC: PX.Data.GenericResult 
		/// </summary>
		[DataMember(Name="QtyAvailableforShippinginLocation", EmitDefaultValue=false)]
		public DecimalValue? QtyAvailableforShippinginLocation { get; set; }

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
		[DataMember(Name="LastModifiedDateofLocationQty", EmitDefaultValue=false)]
		public DateTimeValue? LastModifiedDateofLocationQty { get; set; }

		/// <summary>
		/// DAC Field Name: INLocationStatus_qtyOnHand 
		/// DAC: PX.Data.GenericResult 
		/// </summary>
		[DataMember(Name="QtyOnHandinLocation", EmitDefaultValue=false)]
		public DecimalValue? QtyOnHandinLocation { get; set; }

		/// <summary>
		/// DAC Field Name: INSiteStatus_Formula362ff8e013ad46cd8eac6fb1a45062d8 
		/// DAC: PX.Data.GenericResult 
		/// </summary>
		[DataMember(Name="QtyAvailableinWarehouse", EmitDefaultValue=false)]
		public DecimalValue? QtyAvailableinWarehouse { get; set; }

		/// <summary>
		/// DAC Field Name: INSiteStatus_Formula19d16a8fa78b4ba999e3384f963f3d80 
		/// DAC: PX.Data.GenericResult 
		/// </summary>
		[DataMember(Name="QtyAvailableforIssueinWarehouse", EmitDefaultValue=false)]
		public DecimalValue? QtyAvailableforIssueinWarehouse { get; set; }

		/// <summary>
		/// DAC Field Name: INSiteStatus_Formula8830af1af7074f0985982d2fec1de942 
		/// DAC: PX.Data.GenericResult 
		/// </summary>
		[DataMember(Name="QtyAvailableforShippinginWarehouse", EmitDefaultValue=false)]
		public DecimalValue? QtyAvailableforShippinginWarehouse { get; set; }

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
		/// DAC Field Name: INSiteStatus_Formula3b768cac3c944cd98406270c72ecebc1 
		/// DAC: PX.Data.GenericResult 
		/// </summary>
		[DataMember(Name="QtyOnHandinWarehouse", EmitDefaultValue=false)]
		public DecimalValue? QtyOnHandinWarehouse { get; set; }

	}
}