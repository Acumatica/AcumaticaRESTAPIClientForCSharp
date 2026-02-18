using System;
using System.Collections.Generic;

using Newtonsoft.Json;

using Acumatica.RESTClient.Client;
using Acumatica.RESTClient.ContractBasedApi;
using Acumatica.RESTClient.ContractBasedApi.Model;

namespace Acumatica.Default_24_200_001.Model
{
	public class TaxDetail : Entity
	{

		/// <summary>
		/// The identifier of the tax zone to be used to process customer sales orders.The field is included in the TaxZone foreign key.
		/// <para>DAC Field Name: TaxZoneID</para>
		/// <para>DAC: PX.Objects.SO.SOOrder</para>
		/// <para>Display Name: Customer Tax Zone</para>
		/// <para>SQL Type: nvarchar(10)</para>
		/// </summary>
		public StringValue? CustomerTaxZone { get; set; }

		/// <summary>
		/// <para>DAC Field Name: Tax__ExemptTax</para>
		/// <para>DAC: PX.Objects.SO.SOTaxTran</para>
		/// </summary>
		public BooleanValue? IncludeInVATExemptTotal { get; set; }

		/// <summary>
		/// The line number of the document.
		/// <para>DAC: PX.Objects.SO.SOLine</para>
		/// <para>Display Name: Line Nbr.</para>
		/// Key Field
		/// </summary>
		public IntValue? LineNbr { get; set; }

		/// <summary>
		/// The unique reference number of the order.
		/// <para>DAC: PX.Objects.SO.SOOrder</para>
		/// <para>Display Name: Order Nbr.</para>
		/// <para>SQL Type: nvarchar(15)</para>
		/// Key Field
		/// </summary>
		/// <remarks>
		/// When the new sales order is saved for the first time, the system automatically generatesthis number by using the numbering sequence assigned to orders of SOOrderType.
		/// </remarks>
		public StringValue? OrderNbr { get; set; }

		/// <summary>
		/// The type of the document, which is a part of the identifier of the order.The identifier of the order type.The field is included in the OrderType foreign key.
		/// <para>DAC: PX.Objects.SO.SOOrder</para>
		/// <para>Display Name: Order Type</para>
		/// <para>SQL Type: char(2)</para>
		/// Key Field
		/// </summary>
		/// <remarks>
		/// The type of the document, which is one of the predefined order types or a custom order type created byusing the Order Types (SO201000) form.
		/// </remarks>
		public StringValue? OrderType { get; set; }

		/// <summary>
		/// <para>DAC Field Name: Tax__PendingTax</para>
		/// <para>DAC: PX.Objects.SO.SOTaxTran</para>
		/// </summary>
		public BooleanValue? PendingVAT { get; set; }

		public IntValue? RecordID { get; set; }

		/// <summary>
		/// <para>DAC Field Name: Tax__ReverseTax</para>
		/// <para>DAC: PX.Objects.SO.SOTaxTran</para>
		/// </summary>
		public BooleanValue? ReverseVAT { get; set; }

		/// <summary>
		/// <para>DAC Field Name: Tax__StatisticalTax</para>
		/// <para>DAC: PX.Objects.SO.SOTaxTran</para>
		/// </summary>
		public BooleanValue? StatisticalVAT { get; set; }

		/// <summary>
		/// The taxable amount for the specific tax calculated through the document(in the currency of the document).
		/// <para>DAC Field Name: CuryTaxableAmt</para>
		/// <para>DAC: PX.Objects.SO.SOTaxTran</para>
		/// <para>Display Name: Taxable Amount</para>
		/// </summary>
		public DecimalValue? TaxableAmount { get; set; }

		/// <summary>
		/// The tax amount for the specific tax (in the currency of the document).
		/// <para>DAC Field Name: CuryTaxAmt</para>
		/// <para>DAC: PX.Objects.SO.SOTaxTran</para>
		/// <para>Display Name: Tax Amount</para>
		/// </summary>
		public DecimalValue? TaxAmount { get; set; }

		/// <summary>
		/// The identifier of the specific tax applied to the document.
		/// <para>DAC: PX.Objects.SO.SOTaxTran</para>
		/// <para>Display Name: Tax ID</para>
		/// <para>SQL Type: nvarchar(60)</para>
		/// Key Field
		/// </summary>
		/// <remarks>
		/// The field is included in the following foreign keys:, the field is a part of the identifier of the parent sales order's tax line., the field is the identifier of the tax.
		/// </remarks>
		public StringValue? TaxID { get; set; }

		/// <summary>
		/// <para>DAC: PX.Objects.SO.SOTaxTran</para>
		/// <para>Display Name: Tax Rate</para>
		/// </summary>
		public DecimalValue? TaxRate { get; set; }

		/// <summary>
		/// <para>DAC Field Name: Tax__TaxType</para>
		/// <para>DAC: PX.Objects.SO.SOTaxTran</para>
		/// </summary>
		public StringValue? TaxType { get; set; }

	}
}