using System;
using System.Collections.Generic;
using System.Runtime.Serialization;

using Newtonsoft.Json;

using Acumatica.RESTClient.Client;
using Acumatica.RESTClient.ContractBasedApi;
using Acumatica.RESTClient.ContractBasedApi.Model;

namespace Acumatica.eCommerce_23_200_001.Model
{
	[DataContract]
	public class BCShipmentsResult : Entity
	{

		[DataMember(Name="ExternalShipmentUpdated", EmitDefaultValue=false)]
		public BooleanValue? ExternalShipmentUpdated { get; set; }

		/// <summary>
		/// DAC Field Name: POReceipt_invoiceNbr 
		/// DAC: PX.Data.GenericResult 
		/// </summary>
		[DataMember(Name="InvoiceNbr", EmitDefaultValue=false)]
		public StringValue? InvoiceNbr { get; set; }

		/// <summary>
		/// DAC Field Name: SOOrderShipment_invoiceType 
		/// DAC: PX.Data.GenericResult 
		/// </summary>
		[DataMember(Name="InvoiceType", EmitDefaultValue=false)]
		public StringValue? InvoiceType { get; set; }

		/// <summary>
		/// DAC Field Name: SOOrderShipment_confirmed 
		/// DAC: PX.Data.GenericResult 
		/// </summary>
		[DataMember(Name="Confirmed", EmitDefaultValue=false)]
		public BooleanValue? Confirmed { get; set; }

		/// <summary>
		/// DAC Field Name: SOOrderShipment_lastModifiedDateTime 
		/// DAC: PX.Data.GenericResult 
		/// </summary>
		[DataMember(Name="LastModifiedDateTime", EmitDefaultValue=false)]
		public DateTimeValue? LastModifiedDateTime { get; set; }

		/// <summary>
		/// DAC Field Name: SOOrderShipment_shippingRefNoteID 
		/// DAC: PX.Data.GenericResult 
		/// </summary>
		[DataMember(Name="NoteID", EmitDefaultValue=false)]
		public GuidValue? NoteID { get; set; }

		/// <summary>
		/// DAC Field Name: SOOrderShipment_orderNbr 
		/// DAC: PX.Data.GenericResult 
		/// </summary>
		[DataMember(Name="OrderNbr", EmitDefaultValue=false)]
		public StringValue? OrderNbr { get; set; }

		/// <summary>
		/// DAC Field Name: SOOrderShipment_orderNoteID 
		/// DAC: PX.Data.GenericResult 
		/// </summary>
		[DataMember(Name="OrderNoteID", EmitDefaultValue=false)]
		public GuidValue? OrderNoteID { get; set; }

		[DataMember(Name="OrderType", EmitDefaultValue=false)]
		public StringValue? OrderType { get; set; }

		/// <summary>
		/// DAC Field Name: SOOrderShipment_Formulaed3c462824714383866aa59e6fec34e4 
		/// DAC: PX.Data.GenericResult 
		/// </summary>
		[DataMember(Name="ShipmentNumber", EmitDefaultValue=false)]
		public StringValue? ShipmentNumber { get; set; }

		/// <summary>
		/// DAC Field Name: SOOrderShipment_Formulaa1cc8efe91af4e359f509430a43c1d27 
		/// DAC: PX.Data.GenericResult 
		/// </summary>
		[DataMember(Name="ShipmentType", EmitDefaultValue=false)]
		public StringValue? ShipmentType { get; set; }

	}
}