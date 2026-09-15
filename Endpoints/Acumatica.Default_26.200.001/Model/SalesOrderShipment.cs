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
	public class SalesOrderShipment : Entity
	{

		/// <summary>
		/// <para>DAC Field Name: InvtDocType</para>
		/// <para>DAC: {}</para>
		/// </summary>
		[DataMember(Name="InventoryDocType", EmitDefaultValue=false)]
		public StringSingleSelectValue? InventoryDocType { get; set; }

		/// <summary>
		/// <para>DAC Field Name: InvtRefNbr</para>
		/// <para>DAC: {}</para>
		/// </summary>
		[DataMember(Name="InventoryRefNbr", EmitDefaultValue=false)]
		public StringValue? InventoryRefNbr { get; set; }

		/// <summary>
		/// The reference number of the original invoice (which lists the goods that were ordered andlater returned by the customer).The field is included in the Invoice foreign key.
		/// <para>DAC: PX.Objects.SO.SOOrder</para>
		/// <para>Display Name: Invoice Nbr.</para>
		/// <para>SQL Type: nvarchar(15)</para>
		/// </summary>
		/// <remarks>
		/// This field is available for orders of the CR, RC, RR, and RM types.
		/// </remarks>
		[DataMember(Name="InvoiceNbr", EmitDefaultValue=false)]
		public StringValue? InvoiceNbr { get; set; }

		/// <summary>
		/// <para>DAC: {}</para>
		/// </summary>
		[DataMember(Name="InvoiceType", EmitDefaultValue=false)]
		public StringSingleSelectValue? InvoiceType { get; set; }

		/// <summary>
		/// The date when the ordered goods are scheduled to be shipped.
		/// <para>DAC Field Name: ShipDate</para>
		/// <para>DAC: PX.Objects.SO.SOOrder</para>
		/// <para>Display Name: Sched. Shipment</para>
		/// </summary>
		/// <remarks>
		/// By default, it is the date that is specified in requestDate minus the number of lead days,but it is not earlier than the current business date.
		/// </remarks>
		[DataMember(Name="ShipmentDate", EmitDefaultValue=false)]
		public DateTimeValue? ShipmentDate { get; set; }

		/// <summary>
		/// <para>DAC: {}</para>
		/// </summary>
		[DataMember(Name="ShipmentNbr", EmitDefaultValue=false)]
		public StringValue? ShipmentNbr { get; set; }

		/// <summary>
		/// <para>DAC: {}</para>
		/// </summary>
		[DataMember(Name="ShipmentType", EmitDefaultValue=false)]
		public StringSingleSelectValue? ShipmentType { get; set; }

		/// <summary>
		/// <para>DAC Field Name: ShipmentQty</para>
		/// <para>DAC: {}</para>
		/// </summary>
		[DataMember(Name="ShippedQty", EmitDefaultValue=false)]
		public DecimalValue? ShippedQty { get; set; }

		/// <summary>
		/// <para>DAC Field Name: ShipmentVolume</para>
		/// <para>DAC: {}</para>
		/// </summary>
		[DataMember(Name="ShippedVolume", EmitDefaultValue=false)]
		public DecimalValue? ShippedVolume { get; set; }

		/// <summary>
		/// <para>DAC Field Name: ShipmentWeight</para>
		/// <para>DAC: {}</para>
		/// </summary>
		[DataMember(Name="ShippedWeight", EmitDefaultValue=false)]
		public DecimalValue? ShippedWeight { get; set; }

		/// <summary>
		/// <para>DAC Field Name: SOShipment__StatusIsNull</para>
		/// <para>DAC: {}</para>
		/// </summary>
		[DataMember(Name="Status", EmitDefaultValue=false)]
		public StringSingleSelectValue? Status { get; set; }

		[DataMember(Name="InventoryNoteID", EmitDefaultValue=false)]
		public GuidValue? InventoryNoteID { get; set; }

		[DataMember(Name="LastModifiedDateTime", EmitDefaultValue=false)]
		public DateTimeValue? LastModifiedDateTime { get; set; }

		[DataMember(Name="OrderNoteID", EmitDefaultValue=false)]
		public GuidValue? OrderNoteID { get; set; }

		[DataMember(Name="ShippingNoteID", EmitDefaultValue=false)]
		public GuidValue? ShippingNoteID { get; set; }

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