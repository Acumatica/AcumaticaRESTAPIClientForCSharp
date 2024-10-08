using System;
using System.Collections.Generic;
using System.Runtime.Serialization;

using Newtonsoft.Json;

using Acumatica.RESTClient.Client;
using Acumatica.RESTClient.ContractBasedApi;
using Acumatica.RESTClient.ContractBasedApi.Model;

namespace Acumatica.eCommerce_23_200_001.Model
{
	[DataContract]
	public class CashTransactionDetail : Entity
	{

		/// <summary>
		/// The unit price for the item in the selected currency.
		/// DAC Field Name: CuryUnitPrice 
		/// DAC: PX.Objects.CA.CASplit 
		/// Display Name: Price 
		/// </summary>
		[DataMember(Name="Amount", EmitDefaultValue=false)]
		public DecimalValue? Amount { get; set; }

		/// <summary>
		/// The description of the transaction.
		/// DAC Field Name: TranDesc 
		/// DAC: PX.Objects.CA.CAAdj 
		/// Display Name: Description 
		/// SQL Type: nvarchar(512) 
		/// </summary>
		[DataMember(Name="AmountDescription", EmitDefaultValue=false)]
		public StringValue? AmountDescription { get; set; }

	}
}