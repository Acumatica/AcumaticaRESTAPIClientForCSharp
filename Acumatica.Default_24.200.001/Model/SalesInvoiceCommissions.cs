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
	public class SalesInvoiceCommissions : Entity
	{

		/// <summary>
		/// The commission amount calculated on this document for the salesperson.Given in the currency of the document.
		/// DAC Field Name: CuryCommnAmt 
		/// DAC: PX.Objects.AR.ARInvoice 
		/// Display Name: Commission Amt. 
		/// </summary>
		[DataMember(Name="CommissionAmount", EmitDefaultValue=false)]
		public DecimalValue? CommissionAmount { get; set; }

		[DataMember(Name="SalesPersons", EmitDefaultValue=false)]
		public List<SalesInvoiceSalesPersonDetail>? SalesPersons { get; set; }

		/// <summary>
		/// The amount used as the base to calculate commission for this document.Given in the currency of the document.
		/// DAC Field Name: CuryCommnblAmt 
		/// DAC: PX.Objects.AR.ARInvoice 
		/// Display Name: Total Commissionable 
		/// </summary>
		[DataMember(Name="TotalCommissionableAmount", EmitDefaultValue=false)]
		public DecimalValue? TotalCommissionableAmount { get; set; }

	}
}