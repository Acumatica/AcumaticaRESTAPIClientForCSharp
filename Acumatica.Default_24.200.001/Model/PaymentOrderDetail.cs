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
	public class PaymentOrderDetail : Entity
	{

		/// <summary>
		/// DAC Field Name: CuryAdjgAmt 
		/// DAC: PX.Objects.AR.ARAdjust 
		/// Display Name: Amount Paid 
		/// </summary>
		[DataMember(Name="AppliedToOrder", EmitDefaultValue=false)]
		public DecimalValue? AppliedToOrder { get; set; }

		/// <summary>
		/// DAC Field Name: AdjdOrderNbr 
		/// DAC: PX.Objects.SO.SOAdjust 
		/// Display Name: Order Nbr. 
		/// SQL Type: nvarchar(15) 
		/// Key Field
		/// </summary>
		[DataMember(Name="OrderNbr", EmitDefaultValue=false)]
		public StringValue? OrderNbr { get; set; }

		/// <summary>
		/// DAC Field Name: AdjdOrderType 
		/// DAC: PX.Objects.SO.SOAdjust 
		/// Display Name: Order Type 
		/// SQL Type: char(2) 
		/// Key Field
		/// </summary>
		[DataMember(Name="OrderType", EmitDefaultValue=false)]
		public StringValue? OrderType { get; set; }

	}
}