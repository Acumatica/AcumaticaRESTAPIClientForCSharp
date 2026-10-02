using System;
using System.Collections.Generic;

using Newtonsoft.Json;

using Acumatica.RESTClient.Client;
using Acumatica.RESTClient.ContractBasedApi;
using Acumatica.RESTClient.ContractBasedApi.Model;

namespace Acumatica.Default_26_200_001.Model
{
	public class SalesOrderShipment : Entity
	{

		#region Fields
		/// <summary>
		/// The reference number of the original invoice (which lists the goods that were ordered andlater returned by the customer).The field is included in the Invoice foreign key.
		/// <para>DAC: PX.Objects.SO.SOOrder</para>
		/// <para>Display Name: Invoice Nbr.</para>
		/// <para>SQL Type: nvarchar(15)</para>
		/// </summary>
		/// <remarks>
		/// This field is available for orders of the CR, RC, RR, and RM types.
		/// </remarks>
		public StringValue? InvoiceNbr { get; set; }

		/// <summary>
		/// The date when the ordered goods are scheduled to be shipped.
		/// <para>DAC Field Name: ShipDate</para>
		/// <para>DAC: PX.Objects.SO.SOOrder</para>
		/// <para>Display Name: Sched. Shipment</para>
		/// </summary>
		/// <remarks>
		/// By default, it is the date that is specified in requestDate minus the number of lead days,but it is not earlier than the current business date.
		/// </remarks>
		public DateTimeValue? ShipmentDate { get; set; }

		/// <summary>
		/// <para>DAC: {}</para>
		/// </summary>
		public StringSingleSelectValue? ShipmentType { get; set; }

		/// <summary>
		/// <para>DAC: {}</para>
		/// </summary>
		public StringValue? ShipmentNbr { get; set; }

		/// <summary>
		/// <para>DAC Field Name: SOShipment__StatusIsNull</para>
		/// <para>DAC: {}</para>
		/// </summary>
		public StringSingleSelectValue? Status { get; set; }

		/// <summary>
		/// <para>DAC Field Name: ShipmentQty</para>
		/// <para>DAC: {}</para>
		/// </summary>
		public DecimalValue? ShippedQty { get; set; }

		/// <summary>
		/// <para>DAC Field Name: ShipmentWeight</para>
		/// <para>DAC: {}</para>
		/// </summary>
		public DecimalValue? ShippedWeight { get; set; }

		/// <summary>
		/// <para>DAC Field Name: ShipmentVolume</para>
		/// <para>DAC: {}</para>
		/// </summary>
		public DecimalValue? ShippedVolume { get; set; }

		/// <summary>
		/// <para>DAC: {}</para>
		/// </summary>
		public StringSingleSelectValue? InvoiceType { get; set; }

		/// <summary>
		/// <para>DAC Field Name: InvtDocType</para>
		/// <para>DAC: {}</para>
		/// </summary>
		public StringSingleSelectValue? InventoryDocType { get; set; }

		/// <summary>
		/// <para>DAC Field Name: InvtRefNbr</para>
		/// <para>DAC: {}</para>
		/// </summary>
		public StringValue? InventoryRefNbr { get; set; }

		public GuidValue? InventoryNoteID { get; set; }

		public DateTimeValue? LastModifiedDateTime { get; set; }

		public GuidValue? OrderNoteID { get; set; }

		public GuidValue? ShippingNoteID { get; set; }

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