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
	public class CreditCardTransactionDetail : Entity
	{

		/// <summary>
		/// DAC Field Name: PCTranNumber 
		/// DAC: PX.Objects.AR.CCProcTran 
		/// Display Name: Proc. Center Tran. Nbr. 
		/// SQL Type: nvarchar(50) 
		/// </summary>
		[DataMember(Name="TranNbr", EmitDefaultValue=false)]
		public StringValue? TranNbr { get; set; }

		/// <summary>
		/// DAC: PX.Objects.AR.CCProcTran 
		/// Display Name: Tran. Type 
		/// SQL Type: char(3) 
		/// </summary>
		[DataMember(Name="TranType", EmitDefaultValue=false)]
		public StringValue? TranType { get; set; }

		/// <summary>
		/// DAC Field Name: AuthNumber 
		/// DAC: PX.Objects.AR.CCProcTran 
		/// Display Name: Proc. Center Auth. Nbr. 
		/// SQL Type: nvarchar(50) 
		/// </summary>
		[DataMember(Name="AuthNbr", EmitDefaultValue=false)]
		public StringValue? AuthNbr { get; set; }

		[DataMember(Name="TranDate", EmitDefaultValue=false)]
		public DateTimeValue? TranDate { get; set; }

		[DataMember(Name="ExtProfileId", EmitDefaultValue=false)]
		public StringValue? ExtProfileId { get; set; }

		[DataMember(Name="NeedValidation", EmitDefaultValue=false)]
		public BooleanValue? NeedValidation { get; set; }

		[DataMember(Name="OrigTranNbr", EmitDefaultValue=false)]
		public StringValue? OrigTranNbr { get; set; }

		[DataMember(Name="ExpirationDate", EmitDefaultValue=false)]
		public DateTimeValue? ExpirationDate { get; set; }

		[DataMember(Name="CardType", EmitDefaultValue=false)]
		public StringValue? CardType { get; set; }

	}
}