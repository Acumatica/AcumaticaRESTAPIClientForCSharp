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
	public class PaymentCharge : Entity
	{

		[DataMember(Name="AccountID", EmitDefaultValue=false)]
		public StringValue? AccountID { get; set; }

		/// <summary>
		/// DAC Field Name: CuryTranAmt 
		/// DAC: PX.Objects.AR.ARPaymentChargeTran 
		/// </summary>
		[DataMember(Name="Amount", EmitDefaultValue=false)]
		public DecimalValue? Amount { get; set; }

		/// <summary>
		/// DAC Field Name: TranDesc 
		/// DAC: PX.Objects.AR.ARPaymentChargeTran 
		/// SQL Type: nvarchar(256) 
		/// </summary>
		[DataMember(Name="Description", EmitDefaultValue=false)]
		public StringValue? Description { get; set; }

		/// <summary>
		/// DAC: PX.Objects.AR.ARPayment 
		/// Display Name: Type 
		/// SQL Type: char(3) 
		/// Key Field
		/// </summary>
		[DataMember(Name="DocType", EmitDefaultValue=false)]
		public StringValue? DocType { get; set; }

		/// <summary>
		/// DAC: PX.Objects.AR.ARPaymentChargeTran 
		/// Display Name: Entry Type 
		/// SQL Type: nvarchar(10) 
		/// </summary>
		[DataMember(Name="EntryTypeID", EmitDefaultValue=false)]
		public StringValue? EntryTypeID { get; set; }

		/// <summary>
		/// DAC: PX.Objects.AR.ARTranPostBal 
		/// Display Name: Line Nbr. 
		/// </summary>
		[DataMember(Name="LineNbr", EmitDefaultValue=false)]
		public IntValue? LineNbr { get; set; }

		/// <summary>
		/// DAC: PX.Objects.AR.ARPayment 
		/// Display Name: Reference Nbr. 
		/// SQL Type: nvarchar(15) 
		/// Key Field
		/// </summary>
		[DataMember(Name="RefNbr", EmitDefaultValue=false)]
		public StringValue? RefNbr { get; set; }

		[DataMember(Name="SubID", EmitDefaultValue=false)]
		public StringValue? SubID { get; set; }

	}
}