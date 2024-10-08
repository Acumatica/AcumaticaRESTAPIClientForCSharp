using System;
using System.Collections.Generic;
using System.Runtime.Serialization;

using Newtonsoft.Json;

using Acumatica.RESTClient.Client;
using Acumatica.RESTClient.ContractBasedApi;
using Acumatica.RESTClient.ContractBasedApi.Model;

namespace Acumatica.Default_23_200_001.Model
{
	[DataContract]
	public class TaxDetail : Entity
	{

		/// <summary>
		/// The identifier of the tax zone to be used to process customer sales orders.The field is included in the TaxZone foreign key.
		/// DAC Field Name: TaxZoneID 
		/// DAC: PX.Objects.SO.SOOrder 
		/// Display Name: Customer Tax Zone 
		/// SQL Type: nvarchar(10) 
		/// </summary>
		[DataMember(Name="CustomerTaxZone", EmitDefaultValue=false)]
		public StringValue? CustomerTaxZone { get; set; }

		/// <summary>
		/// DAC Field Name: Tax__ExemptTax 
		/// DAC: PX.Objects.SO.SOTaxTran 
		/// </summary>
		[DataMember(Name="IncludeInVATExemptTotal", EmitDefaultValue=false)]
		public BooleanValue? IncludeInVATExemptTotal { get; set; }

		/// <summary>
		/// The line number of the document.
		/// DAC: PX.Objects.SO.SOLine 
		/// Display Name: Line Nbr. 
		/// Key Field
		/// </summary>
		[DataMember(Name="LineNbr", EmitDefaultValue=false)]
		public IntValue? LineNbr { get; set; }

		/// <summary>
		/// The unique reference number of the order.
		/// DAC: PX.Objects.SO.SOOrder 
		/// Display Name: Order Nbr. 
		/// SQL Type: nvarchar(15) 
		/// Key Field
		/// </summary>
		/// <remarks>
		/// When the new sales order is saved for the first time, the system automatically generatesthis number by using the numbering sequence assigned to orders of SOOrderType.
		/// </remarks>
		[DataMember(Name="OrderNbr", EmitDefaultValue=false)]
		public StringValue? OrderNbr { get; set; }

		/// <summary>
		/// The type of the document, which is a part of the identifier of the order.The identifier of the order type.The field is included in the OrderType foreign key.
		/// DAC: PX.Objects.SO.SOOrder 
		/// Display Name: Order Type 
		/// SQL Type: char(2) 
		/// Key Field
		/// </summary>
		/// <remarks>
		/// The type of the document, which is one of the predefined order types or a custom order type created byusing the Order Types (SO201000) form.
		/// </remarks>
		[DataMember(Name="OrderType", EmitDefaultValue=false)]
		public StringValue? OrderType { get; set; }

		/// <summary>
		/// DAC Field Name: Tax__PendingTax 
		/// DAC: PX.Objects.SO.SOTaxTran 
		/// </summary>
		[DataMember(Name="PendingVAT", EmitDefaultValue=false)]
		public BooleanValue? PendingVAT { get; set; }

		[DataMember(Name="RecordID", EmitDefaultValue=false)]
		public IntValue? RecordID { get; set; }

		/// <summary>
		/// DAC Field Name: Tax__ReverseTax 
		/// DAC: PX.Objects.SO.SOTaxTran 
		/// </summary>
		[DataMember(Name="ReverseVAT", EmitDefaultValue=false)]
		public BooleanValue? ReverseVAT { get; set; }

		/// <summary>
		/// DAC Field Name: Tax__StatisticalTax 
		/// DAC: PX.Objects.SO.SOTaxTran 
		/// </summary>
		[DataMember(Name="StatisticalVAT", EmitDefaultValue=false)]
		public BooleanValue? StatisticalVAT { get; set; }

		/// <summary>
		/// The taxable amount for the specific tax calculated through the document(in the currency of the document).
		/// DAC Field Name: CuryTaxableAmt 
		/// DAC: PX.Objects.SO.SOTaxTran 
		/// Display Name: Taxable Amount 
		/// </summary>
		[DataMember(Name="TaxableAmount", EmitDefaultValue=false)]
		public DecimalValue? TaxableAmount { get; set; }

		/// <summary>
		/// The tax amount for the specific tax (in the currency of the document).
		/// DAC Field Name: CuryTaxAmt 
		/// DAC: PX.Objects.SO.SOTaxTran 
		/// Display Name: Tax Amount 
		/// </summary>
		[DataMember(Name="TaxAmount", EmitDefaultValue=false)]
		public DecimalValue? TaxAmount { get; set; }

		/// <summary>
		/// The identifier of the specific tax applied to the document.
		/// DAC: PX.Objects.SO.SOTaxTran 
		/// Display Name: Tax ID 
		/// SQL Type: nvarchar(60) 
		/// Key Field
		/// </summary>
		/// <remarks>
		/// The field is included in the following foreign keys:, the field is a part of the identifier of the parent sales order's tax line., the field is the identifier of the tax.
		/// </remarks>
		[DataMember(Name="TaxID", EmitDefaultValue=false)]
		public StringValue? TaxID { get; set; }

		/// <summary>
		/// DAC: PX.Objects.SO.SOTaxTran 
		/// Display Name: Tax Rate 
		/// </summary>
		[DataMember(Name="TaxRate", EmitDefaultValue=false)]
		public DecimalValue? TaxRate { get; set; }

		/// <summary>
		/// DAC Field Name: Tax__TaxType 
		/// DAC: PX.Objects.SO.SOTaxTran 
		/// </summary>
		[DataMember(Name="TaxType", EmitDefaultValue=false)]
		public StringValue? TaxType { get; set; }

	}
}