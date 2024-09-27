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
	public class OpportunityTaxDetail : Entity
	{

		/// <summary>
		/// DAC Field Name: Tax__ExemptTax 
		/// DAC: PX.Objects.CR.CRTaxTran 
		/// </summary>
		[DataMember(Name="IncludeInVATExemptTotal", EmitDefaultValue=false)]
		public BooleanValue? IncludeInVATExemptTotal { get; set; }

		/// <summary>
		/// DAC: PX.Objects.CR.CROpportunityProducts 
		/// Display Name: Line Nbr. 
		/// Key Field
		/// </summary>
		[DataMember(Name="LineNbr", EmitDefaultValue=false)]
		public IntValue? LineNbr { get; set; }

		/// <summary>
		/// DAC Field Name: Tax__PendingTax 
		/// DAC: PX.Objects.CR.CRTaxTran 
		/// </summary>
		[DataMember(Name="PendingVAT", EmitDefaultValue=false)]
		public BooleanValue? PendingVAT { get; set; }

		/// <summary>
		/// DAC Field Name: Tax__ReverseTax 
		/// DAC: PX.Objects.CR.CRTaxTran 
		/// </summary>
		[DataMember(Name="ReverseVAT", EmitDefaultValue=false)]
		public BooleanValue? ReverseVAT { get; set; }

		/// <summary>
		/// DAC Field Name: Tax__StatisticalTax 
		/// DAC: PX.Objects.CR.CRTaxTran 
		/// </summary>
		[DataMember(Name="StatisticalVAT", EmitDefaultValue=false)]
		public BooleanValue? StatisticalVAT { get; set; }

		/// <summary>
		/// DAC Field Name: CuryTaxableAmt 
		/// DAC: PX.Objects.CR.CRTaxTran 
		/// Display Name: Taxable Amount 
		/// </summary>
		[DataMember(Name="TaxableAmount", EmitDefaultValue=false)]
		public DecimalValue? TaxableAmount { get; set; }

		/// <summary>
		/// DAC Field Name: CuryTaxAmt 
		/// DAC: PX.Objects.CR.CRTaxTran 
		/// Display Name: Tax Amount 
		/// </summary>
		[DataMember(Name="TaxAmount", EmitDefaultValue=false)]
		public DecimalValue? TaxAmount { get; set; }

		/// <summary>
		/// DAC: PX.Objects.CR.CRTaxTran 
		/// Display Name: Tax ID 
		/// SQL Type: nvarchar(60) 
		/// Key Field
		/// </summary>
		[DataMember(Name="TaxID", EmitDefaultValue=false)]
		public StringValue? TaxID { get; set; }

		/// <summary>
		/// DAC: PX.Objects.CR.CRTaxTran 
		/// </summary>
		[DataMember(Name="TaxRate", EmitDefaultValue=false)]
		public DecimalValue? TaxRate { get; set; }

		/// <summary>
		/// DAC Field Name: Tax__TaxType 
		/// DAC: PX.Objects.CR.CRTaxTran 
		/// </summary>
		[DataMember(Name="TaxType", EmitDefaultValue=false)]
		public StringValue? TaxType { get; set; }

	}
}