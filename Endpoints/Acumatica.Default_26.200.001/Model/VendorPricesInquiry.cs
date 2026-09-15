using System;
using System.Collections.Generic;
using System.Runtime.Serialization;

using Newtonsoft.Json;

using Acumatica.RESTClient.Client;
using Acumatica.RESTClient.ContractBasedApi;
using Acumatica.RESTClient.ContractBasedApi.Model;

namespace Acumatica.Default_26_200_001.Model
{
	/// <summary>
	/// Corresponds to the screen <c>AP202000</c> in the Acumatica ERP
	/// </summary>
	[DataContract]
	public class VendorPricesInquiry : Entity, ITopLevelEntity
	{

		/// <summary>
		/// <para>DAC: PX.Objects.AP.APVendorPriceFilter</para>
		/// <para>Display Name: Inventory ID</para>
		/// </summary>
		[DataMember(Name="InventoryID", EmitDefaultValue=false)]
		public StringValue? InventoryID { get; set; }

		/// <summary>
		/// <para>DAC Field Name: ItemClassCD</para>
		/// <para>DAC: PX.Objects.AP.APVendorPriceFilter</para>
		/// <para>Display Name: Item Class</para>
		/// <para>SQL Type: nvarchar(30)</para>
		/// </summary>
		[DataMember(Name="ItemClass", EmitDefaultValue=false)]
		public StringValue? ItemClass { get; set; }

		/// <summary>
		/// <para>DAC Field Name: OwnerID</para>
		/// <para>DAC: PX.Objects.AP.APVendorPriceFilter</para>
		/// <para>Display Name: Product Manager</para>
		/// </summary>
		[DataMember(Name="ProductManager", EmitDefaultValue=false)]
		public StringValue? ProductManager { get; set; }

		/// <summary>
		/// <para>DAC Field Name: WorkGroupID</para>
		/// <para>DAC: PX.Objects.AP.APVendorPriceFilter</para>
		/// <para>Display Name: Product Workgroup</para>
		/// </summary>
		[DataMember(Name="ProductWorkgroup", EmitDefaultValue=false)]
		public StringValue? ProductWorkgroup { get; set; }

		/// <summary>
		/// <para>DAC Field Name: VendorID</para>
		/// <para>DAC: PX.Objects.AP.APVendorPriceFilter</para>
		/// </summary>
		[DataMember(Name="Vendor", EmitDefaultValue=false)]
		public StringValue? Vendor { get; set; }

		[DataMember(Name="VendorPriceDetails", EmitDefaultValue=false)]
		public List<VendorPriceDetail>? VendorPriceDetails { get; set; }

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
			public const string Translations = "Translations";
			public const string VendorPriceDetails = "VendorPriceDetails";

			//Intentionally excluded
			//public const string All = "Files,Translations,VendorPriceDetails";
		}
		public virtual string GetEndpointPath()
		{
			return "entity/Default/26.200.001";
		}
	}
}