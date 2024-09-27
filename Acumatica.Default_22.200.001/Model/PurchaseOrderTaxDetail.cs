using System;
using System.Collections.Generic;
using System.Runtime.Serialization;

using Newtonsoft.Json;

using Acumatica.RESTClient.Client;
using Acumatica.RESTClient.ContractBasedApi;
using Acumatica.RESTClient.ContractBasedApi.Model;

namespace Acumatica.Default_22_200_001.Model
{
	[DataContract]
	public class PurchaseOrderTaxDetail : Entity
	{

		/// <summary>
		/// DAC Field Name: CuryRetainedTaxableAmt 
		/// DAC: PX.Objects.PO.POTaxTran 
		/// Display Name: Retained Taxable 
		/// </summary>
		[DataMember(Name="RetainedTaxableAmount", EmitDefaultValue=false)]
		public DecimalValue? RetainedTaxableAmount { get; set; }

		/// <summary>
		/// DAC Field Name: CuryRetainedTaxAmt 
		/// DAC: PX.Objects.PO.POTaxTran 
		/// Display Name: Retained Tax 
		/// </summary>
		[DataMember(Name="RetainedTaxAmount", EmitDefaultValue=false)]
		public DecimalValue? RetainedTaxAmount { get; set; }

		/// <summary>
		/// DAC Field Name: CuryTaxableAmt 
		/// DAC: PX.Objects.PO.POTaxTran 
		/// Display Name: Taxable Amount 
		/// </summary>
		[DataMember(Name="TaxableAmount", EmitDefaultValue=false)]
		public DecimalValue? TaxableAmount { get; set; }

		/// <summary>
		/// DAC Field Name: CuryTaxAmt 
		/// DAC: PX.Objects.PO.POTaxTran 
		/// Display Name: Tax Amount 
		/// </summary>
		[DataMember(Name="TaxAmount", EmitDefaultValue=false)]
		public DecimalValue? TaxAmount { get; set; }

		/// <summary>
		/// DAC: PX.Objects.PO.POTaxTran 
		/// Display Name: Tax ID 
		/// SQL Type: nvarchar(60) 
		/// Key Field
		/// </summary>
		[DataMember(Name="TaxID", EmitDefaultValue=false)]
		public StringValue? TaxID { get; set; }

		/// <summary>
		/// DAC: PX.Objects.PO.POTaxTran 
		/// Display Name: Tax Rate 
		/// </summary>
		[DataMember(Name="TaxRate", EmitDefaultValue=false)]
		public DecimalValue? TaxRate { get; set; }

	}
}