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
	public class CheckDetail : Entity
	{

		/// <summary>
		/// The actual amount paid on the document.Presented in the currency of the document, see CuryID.
		/// <para>DAC Field Name: CuryAdjgAmt</para>
		/// <para>DAC: PX.Objects.AP.APAdjust</para>
		/// <para>Display Name: Amount Paid</para>
		/// </summary>
		[DataMember(Name="AmountPaid", EmitDefaultValue=false)]
		public DecimalValue? AmountPaid { get; set; }

		/// <summary>
		/// The amount of the adjustment before the discount is taken.(Presented in the currency of the document, see CuryID)
		/// <para>DAC Field Name: CuryDocBal</para>
		/// <para>DAC: PX.Objects.AP.APAdjust</para>
		/// </summary>
		[DataMember(Name="Balance", EmitDefaultValue=false)]
		public DecimalValue? Balance { get; set; }

		/// <summary>
		/// The difference between the cash discount that was available and the actual amount of cash discount taken.(Presented in the currency of the document, see CuryID)
		/// <para>DAC Field Name: CuryDiscBal</para>
		/// <para>DAC: PX.Objects.AP.APAdjust</para>
		/// <para>Display Name: Cash Discount Balance</para>
		/// </summary>
		[DataMember(Name="CashDiscountBalance", EmitDefaultValue=false)]
		public DecimalValue? CashDiscountBalance { get; set; }

		/// <summary>
		/// <para>DAC Field Name: AdjdLineNbr</para>
		/// <para>DAC: PX.Objects.AP.APAdjust</para>
		/// <para>Display Name: Line Nbr.</para>
		/// Key Field
		/// </summary>
		[DataMember(Name="DocLineNbr", EmitDefaultValue=false)]
		public IntValue? DocLineNbr { get; set; }

		/// <summary>
		/// The type of the adjusted document.
		/// <para>DAC Field Name: AdjdDocType</para>
		/// <para>DAC: PX.Objects.AP.APAdjust</para>
		/// <para>Display Name: Document Type</para>
		/// <para>SQL Type: char(3)</para>
		/// Key Field
		/// </summary>
		[DataMember(Name="DocType", EmitDefaultValue=false)]
		public StringValue? DocType { get; set; }

		/// <summary>
		/// Reference number of the adjusted document.
		/// <para>DAC Field Name: AdjdRefNbr</para>
		/// <para>DAC: PX.Objects.AP.APAdjust</para>
		/// <para>Display Name: Reference Nbr.</para>
		/// <para>SQL Type: nvarchar(15)</para>
		/// Key Field
		/// </summary>
		[DataMember(Name="ReferenceNbr", EmitDefaultValue=false)]
		public StringValue? ReferenceNbr { get; set; }

	}
}