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
	public class PaymentMethodAllowedCashAccountDetail : Entity
	{

		/// <summary>
		/// <para>DAC Field Name: APIsDefault</para>
		/// <para>DAC: PX.Objects.CA.PaymentMethodAccount</para>
		/// <para>Display Name: AP Default</para>
		/// </summary>
		[DataMember(Name="APDefault", EmitDefaultValue=false)]
		public BooleanValue? APDefault { get; set; }

		/// <summary>
		/// <para>DAC: PX.Objects.CA.PaymentMethodAccount</para>
		/// <para>Display Name: AP Last Reference Number</para>
		/// <para>SQL Type: nvarchar(40)</para>
		/// </summary>
		[DataMember(Name="APLastRefNbr", EmitDefaultValue=false)]
		public StringValue? APLastRefNbr { get; set; }

		/// <summary>
		/// <para>DAC Field Name: APAutoNextNbr</para>
		/// <para>DAC: PX.Objects.CA.PaymentMethodAccount</para>
		/// <para>Display Name: AP - Suggest Next Number</para>
		/// </summary>
		[DataMember(Name="APSuggestNextNbr", EmitDefaultValue=false)]
		public BooleanValue? APSuggestNextNbr { get; set; }

		/// <summary>
		/// <para>DAC Field Name: ARIsDefault</para>
		/// <para>DAC: PX.Objects.CA.PaymentMethodAccount</para>
		/// <para>Display Name: AR Default</para>
		/// </summary>
		[DataMember(Name="ARDefault", EmitDefaultValue=false)]
		public BooleanValue? ARDefault { get; set; }

		/// <summary>
		/// <para>DAC Field Name: ARIsDefaultForRefund</para>
		/// <para>DAC: PX.Objects.CA.PaymentMethodAccount</para>
		/// <para>Display Name: AR Default For Refund</para>
		/// </summary>
		[DataMember(Name="ARDefaultForRefund", EmitDefaultValue=false)]
		public BooleanValue? ARDefaultForRefund { get; set; }

		/// <summary>
		/// <para>DAC: PX.Objects.CA.PaymentMethodAccount</para>
		/// <para>Display Name: AR Last Reference Number</para>
		/// <para>SQL Type: nvarchar(40)</para>
		/// </summary>
		[DataMember(Name="ARLastRefNbr", EmitDefaultValue=false)]
		public StringValue? ARLastRefNbr { get; set; }

		/// <summary>
		/// <para>DAC Field Name: ARAutoNextNbr</para>
		/// <para>DAC: PX.Objects.CA.PaymentMethodAccount</para>
		/// <para>Display Name: AR - Suggest Next Number</para>
		/// </summary>
		[DataMember(Name="ARSuggestNextNbr", EmitDefaultValue=false)]
		public BooleanValue? ARSuggestNextNbr { get; set; }

		/// <summary>
		/// <para>DAC Field Name: APBatchLastRefNbr</para>
		/// <para>DAC: PX.Objects.CA.PaymentMethodAccount</para>
		/// <para>Display Name: Batch Last Reference Number</para>
		/// <para>SQL Type: nvarchar(15)</para>
		/// </summary>
		[DataMember(Name="BatchLastRefNbr", EmitDefaultValue=false)]
		public StringValue? BatchLastRefNbr { get; set; }

		/// <summary>
		/// <para>DAC Field Name: CashAccount__BranchID</para>
		/// <para>DAC: PX.Objects.CA.PaymentMethodAccount</para>
		/// </summary>
		[DataMember(Name="Branch", EmitDefaultValue=false)]
		public StringValue? Branch { get; set; }

		/// <summary>
		/// <para>DAC Field Name: CashAccountID</para>
		/// <para>DAC: PX.Objects.CA.PaymentMethodAccount</para>
		/// <para>Display Name: Cash Account</para>
		/// Key Field
		/// </summary>
		[DataMember(Name="CashAccount", EmitDefaultValue=false)]
		public StringValue? CashAccount { get; set; }

		/// <summary>
		/// <para>DAC Field Name: CashAccountID_CashAccount_Descr</para>
		/// <para>DAC: PX.Objects.CA.PaymentMethodAccount</para>
		/// </summary>
		[DataMember(Name="Description", EmitDefaultValue=false)]
		public StringValue? Description { get; set; }

		/// <summary>
		/// <para>DAC Field Name: PaymentMethodID</para>
		/// <para>DAC: PX.Objects.CA.PaymentMethod</para>
		/// <para>Display Name:  Payment Method ID</para>
		/// <para>SQL Type: nvarchar(10)</para>
		/// Key Field
		/// </summary>
		[DataMember(Name="PaymentMethod", EmitDefaultValue=false)]
		public StringValue? PaymentMethod { get; set; }

		/// <summary>
		/// <para>DAC Field Name: UseForAP</para>
		/// <para>DAC: PX.Objects.CA.PaymentMethod</para>
		/// <para>Display Name: Use in AP</para>
		/// </summary>
		[DataMember(Name="UseInAP", EmitDefaultValue=false)]
		public BooleanValue? UseInAP { get; set; }

		/// <summary>
		/// <para>DAC Field Name: UseForAR</para>
		/// <para>DAC: PX.Objects.CA.PaymentMethod</para>
		/// <para>Display Name: Use in AR</para>
		/// </summary>
		[DataMember(Name="UseInAR", EmitDefaultValue=false)]
		public BooleanValue? UseInAR { get; set; }

		[DataMember(Name="LastModifiedDateTime", EmitDefaultValue=false)]
		public DateTimeValue? LastModifiedDateTime { get; set; }

		/// <summary>
		/// <para>DAC Field Name: UseForPR</para>
		/// <para>DAC: PX.Objects.CA.PaymentMethod</para>
		/// <para>Display Name: Use in PR</para>
		/// </summary>
		[DataMember(Name="UseInPR", EmitDefaultValue=false)]
		public BooleanValue? UseInPR { get; set; }

	}
}