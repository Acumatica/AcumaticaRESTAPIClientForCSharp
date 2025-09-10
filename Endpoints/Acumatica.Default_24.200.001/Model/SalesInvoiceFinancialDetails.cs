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
	public class SalesInvoiceFinancialDetails : Entity
	{

		/// <summary>
		/// The number of the Batch created from the document on release.
		/// DAC: PX.Objects.AR.ARInvoice 
		/// Display Name: Batch Nbr. 
		/// SQL Type: nvarchar(15) 
		/// </summary>
		[DataMember(Name="BatchNbr", EmitDefaultValue=false)]
		public StringValue? BatchNbr { get; set; }

		/// <summary>
		/// The identifier of the branch to which the document belongs.
		/// DAC Field Name: BranchID 
		/// DAC: PX.Objects.AR.ARInvoice 
		/// </summary>
		[DataMember(Name="Branch", EmitDefaultValue=false)]
		public StringValue? Branch { get; set; }

		/// <summary>
		/// The identifier of the TaxZone associated with the document.
		/// DAC Field Name: TaxZoneID 
		/// DAC: PX.Objects.AR.ARInvoice 
		/// Display Name: Customer Tax Zone 
		/// SQL Type: nvarchar(10) 
		/// </summary>
		[DataMember(Name="CustomerTaxZone", EmitDefaultValue=false)]
		public StringValue? CustomerTaxZone { get; set; }

	}
}