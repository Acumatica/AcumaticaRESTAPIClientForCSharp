using System;
using System.Collections.Generic;

using Newtonsoft.Json;

using Acumatica.RESTClient.Client;
using Acumatica.RESTClient.ContractBasedApi;
using Acumatica.RESTClient.ContractBasedApi.Model;

namespace Acumatica.Default_24_200_001.Model
{
	public class StorageDetailByLocation : Entity
	{

		/// <summary>
		/// <para>DAC Field Name: InventoryItem_InventoryCD</para>
		/// <para>DAC: PX.Data.GenericResult</para>
		/// </summary>
		public StringValue? InventoryID { get; set; }

		/// <summary>
		/// <para>DAC Field Name: INLocationStatus_qtyAvail</para>
		/// <para>DAC: PX.Data.GenericResult</para>
		/// </summary>
		public DecimalValue? QtyAvailableinLocation { get; set; }

		/// <summary>
		/// <para>DAC Field Name: INLocationStatus_qtyActual</para>
		/// <para>DAC: PX.Data.GenericResult</para>
		/// </summary>
		public DecimalValue? QtyAvailableforIssueinLocation { get; set; }

		/// <summary>
		/// <para>DAC Field Name: INLocationStatus_qtyHardAvail</para>
		/// <para>DAC: PX.Data.GenericResult</para>
		/// </summary>
		public DecimalValue? QtyAvailableforShippinginLocation { get; set; }

		/// <summary>
		/// <para>DAC Field Name: INLocation_locationCD</para>
		/// <para>DAC: PX.Data.GenericResult</para>
		/// </summary>
		public StringValue? LocationID { get; set; }

		/// <summary>
		/// <para>DAC Field Name: INLocationStatus_lastModifiedDateTime</para>
		/// <para>DAC: PX.Data.GenericResult</para>
		/// </summary>
		public DateTimeValue? LastModifiedDateofLocationQty { get; set; }

		/// <summary>
		/// <para>DAC Field Name: INLocationStatus_qtyOnHand</para>
		/// <para>DAC: PX.Data.GenericResult</para>
		/// </summary>
		public DecimalValue? QtyOnHandinLocation { get; set; }

		/// <summary>
		/// <para>DAC Field Name: INSiteStatus_Formula362ff8e013ad46cd8eac6fb1a45062d8</para>
		/// <para>DAC: PX.Data.GenericResult</para>
		/// </summary>
		public DecimalValue? QtyAvailableinWarehouse { get; set; }

		/// <summary>
		/// <para>DAC Field Name: INSiteStatus_Formula19d16a8fa78b4ba999e3384f963f3d80</para>
		/// <para>DAC: PX.Data.GenericResult</para>
		/// </summary>
		public DecimalValue? QtyAvailableforIssueinWarehouse { get; set; }

		/// <summary>
		/// <para>DAC Field Name: INSiteStatus_Formula8830af1af7074f0985982d2fec1de942</para>
		/// <para>DAC: PX.Data.GenericResult</para>
		/// </summary>
		public DecimalValue? QtyAvailableforShippinginWarehouse { get; set; }

		/// <summary>
		/// <para>DAC Field Name: INSite_siteCD</para>
		/// <para>DAC: PX.Data.GenericResult</para>
		/// </summary>
		public StringValue? WarehouseID { get; set; }

		/// <summary>
		/// <para>DAC Field Name: INSiteStatus_lastModifiedDateTime</para>
		/// <para>DAC: PX.Data.GenericResult</para>
		/// </summary>
		public DateTimeValue? LastModifiedDateofWarehouseQty { get; set; }

		/// <summary>
		/// <para>DAC Field Name: INSiteStatus_Formula3b768cac3c944cd98406270c72ecebc1</para>
		/// <para>DAC: PX.Data.GenericResult</para>
		/// </summary>
		public DecimalValue? QtyOnHandinWarehouse { get; set; }

	}
}