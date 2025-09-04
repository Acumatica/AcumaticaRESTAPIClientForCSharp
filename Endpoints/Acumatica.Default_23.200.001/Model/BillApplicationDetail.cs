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
	public class BillApplicationDetail : Entity
	{

		/// <summary>
		/// DAC Field Name: CuryAdjdAmt 
		/// DAC: PX.Objects.AP.APInvoiceEntry+APAdjust 
		/// </summary>
		[DataMember(Name="AmountPaid", EmitDefaultValue=false)]
		public DecimalValue? AmountPaid { get; set; }

		/// <summary>
		/// The balance of the Accounts Payable document after tax (if inclusive) and the discount in the currency of the document. (See CuryID)
		/// DAC Field Name: CuryDocBal 
		/// DAC: PX.Objects.AP.APInvoice 
		/// </summary>
		[DataMember(Name="Balance", EmitDefaultValue=false)]
		public DecimalValue? Balance { get; set; }

		/// <summary>
		/// DAC Field Name: DisplayDocType 
		/// DAC: PX.Objects.AP.APInvoiceEntry+APAdjust 
		/// </summary>
		[DataMember(Name="DocType", EmitDefaultValue=false)]
		public StringValue? DocType { get; set; }

		/// <summary>
		/// DAC Field Name: DisplayRefNbr 
		/// DAC: PX.Objects.AP.APInvoiceEntry+APAdjust 
		/// </summary>
		[DataMember(Name="ReferenceNbr", EmitDefaultValue=false)]
		public StringValue? ReferenceNbr { get; set; }

		/// <summary>
		/// DAC Field Name: DisplayStatus 
		/// DAC: PX.Objects.AP.APInvoiceEntry+APAdjust 
		/// </summary>
		[DataMember(Name="Status", EmitDefaultValue=false)]
		public StringValue? Status { get; set; }

	}
}