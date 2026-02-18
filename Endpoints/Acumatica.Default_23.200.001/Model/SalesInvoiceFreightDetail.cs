using System;
using System.Collections.Generic;

using Newtonsoft.Json;

using Acumatica.RESTClient.Client;
using Acumatica.RESTClient.ContractBasedApi;
using Acumatica.RESTClient.ContractBasedApi.Model;

namespace Acumatica.Default_23_200_001.Model
{
	public class SalesInvoiceFreightDetail : Entity
	{

		/// <summary>
		/// <para>DAC Field Name: AccountID_Account_description</para>
		/// <para>DAC: PX.Objects.AR.ARTran</para>
		/// </summary>
		public StringValue? Description { get; set; }

		/// <summary>
		/// The amount of freight associated with the document.Given in the currency of the document.
		/// <para>DAC Field Name: CuryFreightAmt</para>
		/// <para>DAC: PX.Objects.AR.ARInvoice</para>
		/// <para>Display Name: Freight Price</para>
		/// </summary>
		public DecimalValue? FreightAmount { get; set; }

		/// <summary>
		/// <para>DAC Field Name: CuryFreightCost</para>
		/// <para>DAC: PX.Objects.SO.SOFreightDetail</para>
		/// <para>Display Name: Freight Cost</para>
		/// </summary>
		public DecimalValue? FreightCost { get; set; }

		/// <summary>
		/// <para>DAC Field Name: CuryLineTotal</para>
		/// <para>DAC: PX.Objects.SO.SOFreightDetail</para>
		/// <para>Display Name: Line Total</para>
		/// </summary>
		public DecimalValue? LineTotal { get; set; }

		/// <summary>
		/// The amount of premium freight associated with the document.Given in the currency of the document.
		/// <para>DAC Field Name: CuryPremiumFreightAmt</para>
		/// <para>DAC: PX.Objects.AR.ARInvoice</para>
		/// <para>Display Name: Premium Freight Price</para>
		/// </summary>
		public DecimalValue? PremiumFreightAmount { get; set; }

		/// <summary>
		/// <para>DAC: PX.Objects.SO.SOFreightDetail</para>
		/// <para>Display Name: Shipment Nbr.</para>
		/// <para>SQL Type: nvarchar(15)</para>
		/// Key Field
		/// </summary>
		public StringValue? ShipmentNbr { get; set; }

		/// <summary>
		/// <para>DAC: PX.Objects.SO.SOFreightDetail</para>
		/// <para>Display Name: Shipment Type</para>
		/// <para>SQL Type: char(1)</para>
		/// Key Field
		/// </summary>
		public StringValue? ShipmentType { get; set; }

		/// <summary>
		/// <para>DAC Field Name: CuryTotalFreightAmt</para>
		/// <para>DAC: PX.Objects.SO.SOFreightDetail</para>
		/// <para>Display Name: Total Freight Price</para>
		/// </summary>
		public DecimalValue? TotalFreightAmount { get; set; }

		/// <summary>
		/// <para>DAC: PX.Objects.SO.SOFreightDetail</para>
		/// </summary>
		public DecimalValue? Volume { get; set; }

		/// <summary>
		/// <para>DAC: PX.Objects.SO.SOFreightDetail</para>
		/// </summary>
		public DecimalValue? Weight { get; set; }

	}
}