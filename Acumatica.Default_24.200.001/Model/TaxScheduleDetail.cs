using System;
using System.Collections.Generic;
using System.Runtime.Serialization;

using Newtonsoft.Json;

using Acumatica.RESTClient.Client;
using Acumatica.RESTClient.ContractBasedApi;
using Acumatica.RESTClient.ContractBasedApi.Model;

namespace Acumatica.Default_24_200_001.Model
{
	[DataContract]
	public class TaxScheduleDetail : Entity
	{

		/// <summary>
		/// DAC Field Name: NonDeductibleTaxRate 
		/// DAC: PX.Objects.TX.TaxRev 
		/// Display Name: Deductible Tax Rate 
		/// </summary>
		[DataMember(Name="DeductibleTaxRate", EmitDefaultValue=false)]
		public DecimalValue? DeductibleTaxRate { get; set; }

		/// <summary>
		/// DAC Field Name: TaxableMax 
		/// DAC: PX.Objects.TX.TaxRev 
		/// Display Name: Max. Taxable Amount 
		/// </summary>
		[DataMember(Name="MaxTaxableAmount", EmitDefaultValue=false)]
		public DecimalValue? MaxTaxableAmount { get; set; }

		/// <summary>
		/// DAC Field Name: TaxableMin 
		/// DAC: PX.Objects.TX.TaxRev 
		/// Display Name: Min. Taxable Amount 
		/// </summary>
		[DataMember(Name="MinTaxableAmount", EmitDefaultValue=false)]
		public DecimalValue? MinTaxableAmount { get; set; }

		/// <summary>
		/// DAC Field Name: TaxBucketID 
		/// DAC: PX.Objects.TX.TaxRev 
		/// Display Name: Reporting Group 
		/// </summary>
		[DataMember(Name="ReportingGroup", EmitDefaultValue=false)]
		public StringValue? ReportingGroup { get; set; }

		[DataMember(Name="RevisionID", EmitDefaultValue=false)]
		public IntValue? RevisionID { get; set; }

		/// <summary>
		/// DAC: PX.Objects.TX.TaxRev 
		/// Display Name: Start Date 
		/// </summary>
		[DataMember(Name="StartDate", EmitDefaultValue=false)]
		public DateTimeValue? StartDate { get; set; }

		/// <summary>
		/// The tax ID. This is the key field, which can be specified by the user.
		/// DAC: PX.Objects.TX.Tax 
		/// Display Name: Tax ID 
		/// SQL Type: nvarchar(60) 
		/// Key Field
		/// </summary>
		[DataMember(Name="TaxID", EmitDefaultValue=false)]
		public StringValue? TaxID { get; set; }

		/// <summary>
		/// DAC: PX.Objects.TX.TaxRev 
		/// Display Name: Tax Rate 
		/// </summary>
		[DataMember(Name="TaxRate", EmitDefaultValue=false)]
		public DecimalValue? TaxRate { get; set; }

	}
}