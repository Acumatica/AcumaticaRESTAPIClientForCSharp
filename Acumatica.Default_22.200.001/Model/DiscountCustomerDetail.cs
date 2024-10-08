using System;
using System.Collections.Generic;
using System.Runtime.Serialization;

using Newtonsoft.Json;

using Acumatica.RESTClient.Client;
using Acumatica.RESTClient.ContractBasedApi;
using Acumatica.RESTClient.ContractBasedApi.Model;

namespace Acumatica.Default_22_200_001.Model
{
	[DataContract]
	public class DiscountCustomerDetail : Entity
	{

		/// <summary>
		/// DAC: PX.Objects.AR.DiscountCustomer 
		/// Display Name: Customer 
		/// Key Field
		/// </summary>
		[DataMember(Name="CustomerID", EmitDefaultValue=false)]
		public StringValue? CustomerID { get; set; }

		/// <summary>
		/// DAC Field Name: Customer__AcctName 
		/// DAC: PX.Objects.AR.DiscountCustomer 
		/// </summary>
		[DataMember(Name="CustomerName", EmitDefaultValue=false)]
		public StringValue? CustomerName { get; set; }

	}
}