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
	public class PurchaseOrderTaxDetail : Entity
	{

		/// <summary>
		/// <para>DAC Field Name: CuryRetainedTaxableAmt</para>
		/// <para>DAC: PX.Objects.PO.POTaxTran</para>
		/// <para>Display Name: Retained Taxable</para>
		/// </summary>
		[DataMember(Name="RetainedTaxableAmount", EmitDefaultValue=false)]
		public DecimalValue? RetainedTaxableAmount { get; set; }

		/// <summary>
		/// <para>DAC Field Name: CuryRetainedTaxAmt</para>
		/// <para>DAC: PX.Objects.PO.POTaxTran</para>
		/// <para>Display Name: Retained Tax</para>
		/// </summary>
		[DataMember(Name="RetainedTaxAmount", EmitDefaultValue=false)]
		public DecimalValue? RetainedTaxAmount { get; set; }

		/// <summary>
		/// <para>DAC Field Name: CuryTaxableAmt</para>
		/// <para>DAC: PX.Objects.PO.POTaxTran</para>
		/// <para>Display Name: Taxable Amount</para>
		/// </summary>
		[DataMember(Name="TaxableAmount", EmitDefaultValue=false)]
		public DecimalValue? TaxableAmount { get; set; }

		/// <summary>
		/// <para>DAC Field Name: CuryTaxAmt</para>
		/// <para>DAC: PX.Objects.PO.POTaxTran</para>
		/// <para>Display Name: Tax Amount</para>
		/// </summary>
		[DataMember(Name="TaxAmount", EmitDefaultValue=false)]
		public DecimalValue? TaxAmount { get; set; }

		/// <summary>
		/// <para>DAC: PX.Objects.PO.POTaxTran</para>
		/// <para>Display Name: Tax ID</para>
		/// <para>SQL Type: nvarchar(60)</para>
		/// Key Field
		/// </summary>
		[DataMember(Name="TaxID", EmitDefaultValue=false)]
		public StringValue? TaxID { get; set; }

		/// <summary>
		/// <para>DAC: PX.Objects.PO.POTaxTran</para>
		/// <para>Display Name: Tax Rate</para>
		/// </summary>
		[DataMember(Name="TaxRate", EmitDefaultValue=false)]
		public DecimalValue? TaxRate { get; set; }

	}
}