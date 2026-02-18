using System;
using System.Collections.Generic;

using Newtonsoft.Json;

using Acumatica.RESTClient.Client;
using Acumatica.RESTClient.ContractBasedApi;
using Acumatica.RESTClient.ContractBasedApi.Model;

namespace Acumatica.eCommerce_23_200_001.Model
{
	public class BCShipmentsResult : Entity
	{

		public BooleanValue? ExternalShipmentUpdated { get; set; }

		/// <summary>
		/// <para>DAC Field Name: POReceipt_invoiceNbr</para>
		/// <para>DAC: PX.Data.GenericResult</para>
		/// </summary>
		public StringValue? InvoiceNbr { get; set; }

		/// <summary>
		/// <para>DAC Field Name: SOOrderShipment_invoiceType</para>
		/// <para>DAC: PX.Data.GenericResult</para>
		/// </summary>
		public StringValue? InvoiceType { get; set; }

		/// <summary>
		/// <para>DAC Field Name: SOOrderShipment_confirmed</para>
		/// <para>DAC: PX.Data.GenericResult</para>
		/// </summary>
		public BooleanValue? Confirmed { get; set; }

		/// <summary>
		/// <para>DAC Field Name: SOOrderShipment_lastModifiedDateTime</para>
		/// <para>DAC: PX.Data.GenericResult</para>
		/// </summary>
		public DateTimeValue? LastModifiedDateTime { get; set; }

		/// <summary>
		/// <para>DAC Field Name: SOOrderShipment_shippingRefNoteID</para>
		/// <para>DAC: PX.Data.GenericResult</para>
		/// </summary>
		public GuidValue? NoteID { get; set; }

		/// <summary>
		/// <para>DAC Field Name: SOOrderShipment_orderNbr</para>
		/// <para>DAC: PX.Data.GenericResult</para>
		/// </summary>
		public StringValue? OrderNbr { get; set; }

		/// <summary>
		/// <para>DAC Field Name: SOOrderShipment_orderNoteID</para>
		/// <para>DAC: PX.Data.GenericResult</para>
		/// </summary>
		public GuidValue? OrderNoteID { get; set; }

		public StringValue? OrderType { get; set; }

		/// <summary>
		/// <para>DAC Field Name: SOOrderShipment_Formulaed3c462824714383866aa59e6fec34e4</para>
		/// <para>DAC: PX.Data.GenericResult</para>
		/// </summary>
		public StringValue? ShipmentNumber { get; set; }

		/// <summary>
		/// <para>DAC Field Name: SOOrderShipment_Formulaa1cc8efe91af4e359f509430a43c1d27</para>
		/// <para>DAC: PX.Data.GenericResult</para>
		/// </summary>
		public StringValue? ShipmentType { get; set; }

	}
}