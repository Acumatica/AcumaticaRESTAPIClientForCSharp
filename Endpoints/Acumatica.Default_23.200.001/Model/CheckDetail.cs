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
	public class CheckDetail : Entity
	{

		/// <summary>
		/// The actual amount paid on the document.Presented in the currency of the document, see CuryID.
		/// DAC Field Name: CuryAdjgAmt 
		/// DAC: PX.Objects.AP.APAdjust 
		/// Display Name: Amount Paid 
		/// </summary>
		[DataMember(Name="AmountPaid", EmitDefaultValue=false)]
		public DecimalValue? AmountPaid { get; set; }

		/// <summary>
		/// The amount of the adjustment before the discount is taken.(Presented in the currency of the document, see CuryID)
		/// DAC Field Name: CuryDocBal 
		/// DAC: PX.Objects.AP.APAdjust 
		/// </summary>
		[DataMember(Name="Balance", EmitDefaultValue=false)]
		public DecimalValue? Balance { get; set; }

		/// <summary>
		/// The difference between the cash discount that was available and the actual amount of cash discount taken.(Presented in the currency of the document, see CuryID)
		/// DAC Field Name: CuryDiscBal 
		/// DAC: PX.Objects.AP.APAdjust 
		/// Display Name: Cash Discount Balance 
		/// </summary>
		[DataMember(Name="CashDiscountBalance", EmitDefaultValue=false)]
		public DecimalValue? CashDiscountBalance { get; set; }

		/// <summary>
		/// DAC Field Name: AdjdLineNbr 
		/// DAC: PX.Objects.AP.APAdjust 
		/// Display Name: Line Nbr. 
		/// Key Field
		/// </summary>
		[DataMember(Name="DocLineNbr", EmitDefaultValue=false)]
		public IntValue? DocLineNbr { get; set; }

		/// <summary>
		/// The type of the adjusted document.
		/// DAC Field Name: AdjdDocType 
		/// DAC: PX.Objects.AP.APAdjust 
		/// Display Name: Document Type 
		/// SQL Type: char(3) 
		/// Key Field
		/// </summary>
		[DataMember(Name="DocType", EmitDefaultValue=false)]
		public StringValue? DocType { get; set; }

		/// <summary>
		/// Reference number of the adjusted document.
		/// DAC Field Name: AdjdRefNbr 
		/// DAC: PX.Objects.AP.APAdjust 
		/// Display Name: Reference Nbr. 
		/// SQL Type: nvarchar(15) 
		/// Key Field
		/// </summary>
		[DataMember(Name="ReferenceNbr", EmitDefaultValue=false)]
		public StringValue? ReferenceNbr { get; set; }

	}
}