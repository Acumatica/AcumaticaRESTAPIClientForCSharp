using System;
using System.Collections.Generic;

using Newtonsoft.Json;

using Acumatica.RESTClient.Client;
using Acumatica.RESTClient.ContractBasedApi;
using Acumatica.RESTClient.ContractBasedApi.Model;

namespace Acumatica.eCommerce_26_200_001.Model
{
	public class BCShipmentsResult : Entity
	{

		#region Fields
		/// <summary>
		/// <para>DAC Field Name: SOOrderShipment_Formulaa1cc8efe91af4e359f509430a43c1d27</para>
		/// <para>DAC: PX.Data.GenericResult</para>
		/// </summary>
		public StringValue? ShipmentType { get; set; }

		/// <summary>
		/// <para>DAC Field Name: SOOrderShipment_Formulaed3c462824714383866aa59e6fec34e4</para>
		/// <para>DAC: PX.Data.GenericResult</para>
		/// </summary>
		public StringValue? ShipmentNumber { get; set; }

		/// <summary>
		/// <para>DAC Field Name: SOOrderShipment_shippingRefNoteID</para>
		/// <para>DAC: PX.Data.GenericResult</para>
		/// </summary>
		public GuidValue? NoteID { get; set; }

		/// <summary>
		/// <para>DAC Field Name: SOOrderShipment_lastModifiedDateTime</para>
		/// <para>DAC: PX.Data.GenericResult</para>
		/// </summary>
		public DateTimeValue? LastModifiedDateTime { get; set; }

		/// <summary>
		/// <para>DAC Field Name: SOOrderShipment_orderNoteID</para>
		/// <para>DAC: PX.Data.GenericResult</para>
		/// </summary>
		public GuidValue? OrderNoteID { get; set; }

		/// <summary>
		/// <para>DAC Field Name: SOOrderShipment_orderNbr</para>
		/// <para>DAC: PX.Data.GenericResult</para>
		/// </summary>
		public StringValue? OrderNbr { get; set; }

		/// <summary>
		/// <para>DAC Field Name: POReceipt_invoiceNbr</para>
		/// <para>DAC: PX.Data.GenericResult</para>
		/// </summary>
		public StringValue? InvoiceNbr { get; set; }

		/// <summary>
		/// <para>DAC Field Name: SOOrderShipment_confirmed</para>
		/// <para>DAC: PX.Data.GenericResult</para>
		/// </summary>
		public BooleanValue? Confirmed { get; set; }

		/// <summary>
		/// <para>DAC Field Name: SOOrderShipment_invoiceType</para>
		/// <para>DAC: PX.Data.GenericResult</para>
		/// </summary>
		public StringValue? InvoiceType { get; set; }

		public BooleanValue? ExternalShipmentUpdated { get; set; }

		public StringValue? OrderType { get; set; }

		#endregion

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