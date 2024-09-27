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
	public class ProFormaTaxDetail : Entity
	{

		/// <summary>
		/// DAC Field Name: CuryRetainedTaxAmt 
		/// DAC: PX.Objects.PM.PMTaxTran 
		/// Display Name: Retained Tax 
		/// </summary>
		[DataMember(Name="RetainedTax", EmitDefaultValue=false)]
		public DecimalValue? RetainedTax { get; set; }

		/// <summary>
		/// DAC Field Name: CuryRetainedTaxableAmt 
		/// DAC: PX.Objects.PM.PMTaxTran 
		/// Display Name: Retained Taxable 
		/// </summary>
		[DataMember(Name="RetainedTaxable", EmitDefaultValue=false)]
		public DecimalValue? RetainedTaxable { get; set; }

		/// <summary>
		/// DAC Field Name: CuryTaxableAmt 
		/// DAC: PX.Objects.PM.PMTaxTran 
		/// Display Name: Taxable Amount 
		/// </summary>
		[DataMember(Name="TaxableAmount", EmitDefaultValue=false)]
		public DecimalValue? TaxableAmount { get; set; }

		/// <summary>
		/// DAC Field Name: CuryTaxAmt 
		/// DAC: PX.Objects.PM.PMTaxTran 
		/// Display Name: Tax Amount 
		/// </summary>
		[DataMember(Name="TaxAmount", EmitDefaultValue=false)]
		public DecimalValue? TaxAmount { get; set; }

		/// <summary>
		/// DAC: PX.Objects.PM.PMTaxTran 
		/// Display Name: Tax ID 
		/// SQL Type: nvarchar(60) 
		/// Key Field
		/// </summary>
		[DataMember(Name="TaxID", EmitDefaultValue=false)]
		public StringValue? TaxID { get; set; }

		/// <summary>
		/// DAC: PX.Objects.PM.PMTaxTran 
		/// Display Name: Tax Rate 
		/// </summary>
		[DataMember(Name="TaxRate", EmitDefaultValue=false)]
		public DecimalValue? TaxRate { get; set; }

	}
}