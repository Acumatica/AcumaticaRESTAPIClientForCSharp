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
	public class CreditCardProcessingDetail : Entity
	{

		/// <summary>
		/// DAC Field Name: Amount 
		/// DAC: PX.Objects.AR.CCProcTran 
		/// Display Name: Tran. Amount 
		/// </summary>
		[DataMember(Name="TransactionAmount", EmitDefaultValue=false)]
		public DecimalValue? TransactionAmount { get; set; }

		/// <summary>
		/// DAC Field Name: TranStatus 
		/// DAC: PX.Objects.AR.CCProcTran 
		/// Display Name: Tran. Status 
		/// SQL Type: char(3) 
		/// </summary>
		[DataMember(Name="TransactionStatus", EmitDefaultValue=false)]
		public StringValue? TransactionStatus { get; set; }

	}
}