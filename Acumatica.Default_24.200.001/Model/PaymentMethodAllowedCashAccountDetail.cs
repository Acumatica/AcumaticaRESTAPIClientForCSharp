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
		/// DAC Field Name: APIsDefault 
		/// DAC: PX.Objects.CA.PaymentMethodAccount 
		/// Display Name: AP Default 
		/// </summary>
		[DataMember(Name="APDefault", EmitDefaultValue=false)]
		public BooleanValue? APDefault { get; set; }

		/// <summary>
		/// DAC: PX.Objects.CA.PaymentMethodAccount 
		/// Display Name: AP Last Reference Number 
		/// SQL Type: nvarchar(40) 
		/// </summary>
		[DataMember(Name="APLastRefNbr", EmitDefaultValue=false)]
		public StringValue? APLastRefNbr { get; set; }

		/// <summary>
		/// DAC Field Name: APAutoNextNbr 
		/// DAC: PX.Objects.CA.PaymentMethodAccount 
		/// Display Name: AP - Suggest Next Number 
		/// </summary>
		[DataMember(Name="APSuggestNextNbr", EmitDefaultValue=false)]
		public BooleanValue? APSuggestNextNbr { get; set; }

		/// <summary>
		/// DAC Field Name: ARIsDefault 
		/// DAC: PX.Objects.CA.PaymentMethodAccount 
		/// Display Name: AR Default 
		/// </summary>
		[DataMember(Name="ARDefault", EmitDefaultValue=false)]
		public BooleanValue? ARDefault { get; set; }

		/// <summary>
		/// DAC Field Name: ARIsDefaultForRefund 
		/// DAC: PX.Objects.CA.PaymentMethodAccount 
		/// Display Name: AR Default For Refund 
		/// </summary>
		[DataMember(Name="ARDefaultForRefund", EmitDefaultValue=false)]
		public BooleanValue? ARDefaultForRefund { get; set; }

		/// <summary>
		/// DAC: PX.Objects.CA.PaymentMethodAccount 
		/// Display Name: AR Last Reference Number 
		/// SQL Type: nvarchar(40) 
		/// </summary>
		[DataMember(Name="ARLastRefNbr", EmitDefaultValue=false)]
		public StringValue? ARLastRefNbr { get; set; }

		/// <summary>
		/// DAC Field Name: ARAutoNextNbr 
		/// DAC: PX.Objects.CA.PaymentMethodAccount 
		/// Display Name: AR - Suggest Next Number 
		/// </summary>
		[DataMember(Name="ARSuggestNextNbr", EmitDefaultValue=false)]
		public BooleanValue? ARSuggestNextNbr { get; set; }

		/// <summary>
		/// DAC Field Name: APBatchLastRefNbr 
		/// DAC: PX.Objects.CA.PaymentMethodAccount 
		/// Display Name: Batch Last Reference Number 
		/// SQL Type: nvarchar(15) 
		/// </summary>
		[DataMember(Name="BatchLastRefNbr", EmitDefaultValue=false)]
		public StringValue? BatchLastRefNbr { get; set; }

		/// <summary>
		/// DAC Field Name: CashAccount__BranchID 
		/// DAC: PX.Objects.CA.PaymentMethodAccount 
		/// </summary>
		[DataMember(Name="Branch", EmitDefaultValue=false)]
		public StringValue? Branch { get; set; }

		/// <summary>
		/// DAC Field Name: CashAccountID 
		/// DAC: PX.Objects.CA.PaymentMethodAccount 
		/// Display Name: Cash Account 
		/// Key Field
		/// </summary>
		[DataMember(Name="CashAccount", EmitDefaultValue=false)]
		public StringValue? CashAccount { get; set; }

		/// <summary>
		/// DAC Field Name: CashAccountID_CashAccount_Descr 
		/// DAC: PX.Objects.CA.PaymentMethodAccount 
		/// </summary>
		[DataMember(Name="Description", EmitDefaultValue=false)]
		public StringValue? Description { get; set; }

		/// <summary>
		/// DAC Field Name: PaymentMethodID 
		/// DAC: PX.Objects.CA.PaymentMethod 
		/// Display Name:  Payment Method ID 
		/// SQL Type: nvarchar(10) 
		/// Key Field
		/// </summary>
		[DataMember(Name="PaymentMethod", EmitDefaultValue=false)]
		public StringValue? PaymentMethod { get; set; }

		/// <summary>
		/// DAC Field Name: UseForAP 
		/// DAC: PX.Objects.CA.PaymentMethod 
		/// Display Name: Use in AP 
		/// </summary>
		[DataMember(Name="UseInAP", EmitDefaultValue=false)]
		public BooleanValue? UseInAP { get; set; }

		/// <summary>
		/// DAC Field Name: UseForAR 
		/// DAC: PX.Objects.CA.PaymentMethod 
		/// Display Name: Use in AR 
		/// </summary>
		[DataMember(Name="UseInAR", EmitDefaultValue=false)]
		public BooleanValue? UseInAR { get; set; }

		[DataMember(Name="LastModifiedDateTime", EmitDefaultValue=false)]
		public DateTimeValue? LastModifiedDateTime { get; set; }

		/// <summary>
		/// DAC Field Name: UseForPR 
		/// DAC: PX.Objects.CA.PaymentMethod 
		/// Display Name: Use in PR 
		/// </summary>
		[DataMember(Name="UseInPR", EmitDefaultValue=false)]
		public BooleanValue? UseInPR { get; set; }

	}
}