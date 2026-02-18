using System;
using System.Collections.Generic;

using Newtonsoft.Json;

using Acumatica.RESTClient.Client;
using Acumatica.RESTClient.ContractBasedApi;
using Acumatica.RESTClient.ContractBasedApi.Model;

namespace Acumatica.Default_25_200_001.Model
{
	public class CustomerPaymentMethodDetail : Entity
	{

		/// <summary>
		/// The name of the payment method setting, such as Card Number,Expiration Date. This field is a part of the compound key of the record.
		/// <para>DAC Field Name: DetailID</para>
		/// <para>DAC: PX.Objects.AR.CustomerPaymentMethodDetail</para>
		/// <para>Display Name: Description</para>
		/// <para>SQL Type: nvarchar(10)</para>
		/// Key Field
		/// </summary>
		public StringValue? Name { get; set; }

		/// <summary>
		/// The value for the customer payment method setting,such as the actual credit card number, the expiration date.This value in this field can be subject to dynamic valuevalidation depending on the regular expression definedin the corresponding PaymentMethodDetail.
		/// <para>DAC: PX.Objects.AR.CustomerPaymentMethodDetail</para>
		/// <para>SQL Type: nvarchar(1024)</para>
		/// </summary>
		public StringValue? Value { get; set; }

	}
}