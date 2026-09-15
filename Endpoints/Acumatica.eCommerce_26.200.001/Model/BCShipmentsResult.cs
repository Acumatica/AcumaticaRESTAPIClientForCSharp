using System;
using System.Collections.Generic;
using System.Runtime.Serialization;

using Newtonsoft.Json;

using Acumatica.RESTClient.Client;
using Acumatica.RESTClient.ContractBasedApi;
using Acumatica.RESTClient.ContractBasedApi.Model;

namespace Acumatica.eCommerce_26_200_001.Model
{
	[DataContract]
	public class BCShipmentsResult : Entity
	{

		[DataMember(Name="ExternalShipmentUpdated", EmitDefaultValue=false)]
		public BooleanValue? ExternalShipmentUpdated { get; set; }

		/// <summary>
		/// <para>DAC Field Name: POReceipt_invoiceNbr</para>
		/// <para>DAC: PX.Data.GenericResult</para>
		/// </summary>
		[DataMember(Name="InvoiceNbr", EmitDefaultValue=false)]
		public StringValue? InvoiceNbr { get; set; }

		/// <summary>
		/// <para>DAC Field Name: SOOrderShipment_invoiceType</para>
		/// <para>DAC: PX.Data.GenericResult</para>
		/// </summary>
		[DataMember(Name="InvoiceType", EmitDefaultValue=false)]
		public StringValue? InvoiceType { get; set; }

		/// <summary>
		/// <para>DAC Field Name: SOOrderShipment_confirmed</para>
		/// <para>DAC: PX.Data.GenericResult</para>
		/// </summary>
		[DataMember(Name="Confirmed", EmitDefaultValue=false)]
		public BooleanValue? Confirmed { get; set; }

		/// <summary>
		/// <para>DAC Field Name: SOOrderShipment_lastModifiedDateTime</para>
		/// <para>DAC: PX.Data.GenericResult</para>
		/// </summary>
		[DataMember(Name="LastModifiedDateTime", EmitDefaultValue=false)]
		public DateTimeValue? LastModifiedDateTime { get; set; }

		/// <summary>
		/// <para>DAC Field Name: SOOrderShipment_shippingRefNoteID</para>
		/// <para>DAC: PX.Data.GenericResult</para>
		/// </summary>
		[DataMember(Name="NoteID", EmitDefaultValue=false)]
		public GuidValue? NoteID { get; set; }

		/// <summary>
		/// <para>DAC Field Name: SOOrderShipment_orderNbr</para>
		/// <para>DAC: PX.Data.GenericResult</para>
		/// </summary>
		[DataMember(Name="OrderNbr", EmitDefaultValue=false)]
		public StringValue? OrderNbr { get; set; }

		/// <summary>
		/// <para>DAC Field Name: SOOrderShipment_orderNoteID</para>
		/// <para>DAC: PX.Data.GenericResult</para>
		/// </summary>
		[DataMember(Name="OrderNoteID", EmitDefaultValue=false)]
		public GuidValue? OrderNoteID { get; set; }

		[DataMember(Name="OrderType", EmitDefaultValue=false)]
		public StringValue? OrderType { get; set; }

		/// <summary>
		/// <para>DAC Field Name: SOOrderShipment_Formulaed3c462824714383866aa59e6fec34e4</para>
		/// <para>DAC: PX.Data.GenericResult</para>
		/// </summary>
		[DataMember(Name="ShipmentNumber", EmitDefaultValue=false)]
		public StringValue? ShipmentNumber { get; set; }

		/// <summary>
		/// <para>DAC Field Name: SOOrderShipment_Formulaa1cc8efe91af4e359f509430a43c1d27</para>
		/// <para>DAC: PX.Data.GenericResult</para>
		/// </summary>
		[DataMember(Name="ShipmentType", EmitDefaultValue=false)]
		public StringValue? ShipmentType { get; set; }

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