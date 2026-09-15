using System;
using System.Collections.Generic;
using System.Runtime.Serialization;

using Newtonsoft.Json;

using Acumatica.RESTClient.Client;
using Acumatica.RESTClient.ContractBasedApi;
using Acumatica.RESTClient.ContractBasedApi.Model;

namespace Acumatica.Default_26_200_001.Model
{
	[DataContract]
	public class StorageDetailByLocation : Entity
	{

		/// <summary>
		/// <para>DAC Field Name: InventoryItem_InventoryCD</para>
		/// <para>DAC: PX.Data.GenericResult</para>
		/// </summary>
		[DataMember(Name="InventoryID", EmitDefaultValue=false)]
		public StringValue? InventoryID { get; set; }

		/// <summary>
		/// <para>DAC Field Name: INLocationStatus_qtyAvail</para>
		/// <para>DAC: PX.Data.GenericResult</para>
		/// </summary>
		[DataMember(Name="QtyAvailableinLocation", EmitDefaultValue=false)]
		public DecimalValue? QtyAvailableinLocation { get; set; }

		/// <summary>
		/// <para>DAC Field Name: INLocationStatus_qtyActual</para>
		/// <para>DAC: PX.Data.GenericResult</para>
		/// </summary>
		[DataMember(Name="QtyAvailableforIssueinLocation", EmitDefaultValue=false)]
		public DecimalValue? QtyAvailableforIssueinLocation { get; set; }

		/// <summary>
		/// <para>DAC Field Name: INLocationStatus_qtyHardAvail</para>
		/// <para>DAC: PX.Data.GenericResult</para>
		/// </summary>
		[DataMember(Name="QtyAvailableforShippinginLocation", EmitDefaultValue=false)]
		public DecimalValue? QtyAvailableforShippinginLocation { get; set; }

		/// <summary>
		/// <para>DAC Field Name: INLocation_locationCD</para>
		/// <para>DAC: PX.Data.GenericResult</para>
		/// </summary>
		[DataMember(Name="LocationID", EmitDefaultValue=false)]
		public StringValue? LocationID { get; set; }

		/// <summary>
		/// <para>DAC Field Name: INLocationStatus_lastModifiedDateTime</para>
		/// <para>DAC: PX.Data.GenericResult</para>
		/// </summary>
		[DataMember(Name="LastModifiedDateofLocationQty", EmitDefaultValue=false)]
		public DateTimeValue? LastModifiedDateofLocationQty { get; set; }

		/// <summary>
		/// <para>DAC Field Name: INLocationStatus_qtyOnHand</para>
		/// <para>DAC: PX.Data.GenericResult</para>
		/// </summary>
		[DataMember(Name="QtyOnHandinLocation", EmitDefaultValue=false)]
		public DecimalValue? QtyOnHandinLocation { get; set; }

		/// <summary>
		/// <para>DAC Field Name: INSiteStatus_Formula362ff8e013ad46cd8eac6fb1a45062d8</para>
		/// <para>DAC: PX.Data.GenericResult</para>
		/// </summary>
		[DataMember(Name="QtyAvailableinWarehouse", EmitDefaultValue=false)]
		public DecimalValue? QtyAvailableinWarehouse { get; set; }

		/// <summary>
		/// <para>DAC Field Name: INSiteStatus_Formula19d16a8fa78b4ba999e3384f963f3d80</para>
		/// <para>DAC: PX.Data.GenericResult</para>
		/// </summary>
		[DataMember(Name="QtyAvailableforIssueinWarehouse", EmitDefaultValue=false)]
		public DecimalValue? QtyAvailableforIssueinWarehouse { get; set; }

		/// <summary>
		/// <para>DAC Field Name: INSiteStatus_Formula8830af1af7074f0985982d2fec1de942</para>
		/// <para>DAC: PX.Data.GenericResult</para>
		/// </summary>
		[DataMember(Name="QtyAvailableforShippinginWarehouse", EmitDefaultValue=false)]
		public DecimalValue? QtyAvailableforShippinginWarehouse { get; set; }

		/// <summary>
		/// <para>DAC Field Name: INSite_siteCD</para>
		/// <para>DAC: PX.Data.GenericResult</para>
		/// </summary>
		[DataMember(Name="WarehouseID", EmitDefaultValue=false)]
		public StringValue? WarehouseID { get; set; }

		/// <summary>
		/// <para>DAC Field Name: INSiteStatus_lastModifiedDateTime</para>
		/// <para>DAC: PX.Data.GenericResult</para>
		/// </summary>
		[DataMember(Name="LastModifiedDateofWarehouseQty", EmitDefaultValue=false)]
		public DateTimeValue? LastModifiedDateofWarehouseQty { get; set; }

		/// <summary>
		/// <para>DAC Field Name: INSiteStatus_Formula3b768cac3c944cd98406270c72ecebc1</para>
		/// <para>DAC: PX.Data.GenericResult</para>
		/// </summary>
		[DataMember(Name="QtyOnHandinWarehouse", EmitDefaultValue=false)]
		public DecimalValue? QtyOnHandinWarehouse { get; set; }

		/// <summary>
		/// Names that can be passed in the <c>$expand</c> parameter.
		/// <para>This endpoint uses system contract 5, where a nested entity is expanded
		/// as <c>Parent($expand=Child)</c> rather than <c>Parent/Child</c>, so only the names
		/// that can be expanded directly on this entity are listed here. Use the nested
		/// entity's own <c>Expand</c> class for the inner names.</para>
		/// </summary>
		public static class Expand
		{
			public const string Files = "Files";

			//Intentionally excluded
			//public const string All = "Files";
		}
	}
}