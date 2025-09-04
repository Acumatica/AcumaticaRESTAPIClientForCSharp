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
	public class CustomerPaymentMethodDetail : Entity
	{

		/// <summary>
		/// The name of the payment method setting, such as Card Number,Expiration Date. This field is a part of the compound key of the record.
		/// DAC Field Name: DetailID 
		/// DAC: PX.Objects.AR.CustomerPaymentMethodDetail 
		/// Display Name: Description 
		/// SQL Type: nvarchar(10) 
		/// Key Field
		/// </summary>
		[DataMember(Name="Name", EmitDefaultValue=false)]
		public StringValue? Name { get; set; }

		/// <summary>
		/// The value for the customer payment method setting,such as the actual credit card number, the expiration date.This value in this field can be subject to dynamic valuevalidation depending on the regular expression definedin the corresponding PaymentMethodDetail.
		/// DAC: PX.Objects.AR.CustomerPaymentMethodDetail 
		/// SQL Type: nvarchar(1024) 
		/// </summary>
		[DataMember(Name="Value", EmitDefaultValue=false)]
		public StringValue? Value { get; set; }

	}
}