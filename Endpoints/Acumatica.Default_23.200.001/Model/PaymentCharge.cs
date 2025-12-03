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
		/// <para>DAC Field Name: CuryTranAmt</para>
		/// <para>DAC: PX.Objects.AR.ARPaymentChargeTran</para>
		/// </summary>
		[DataMember(Name="Amount", EmitDefaultValue=false)]
		public DecimalValue? Amount { get; set; }

		/// <summary>
		/// <para>DAC Field Name: TranDesc</para>
		/// <para>DAC: PX.Objects.AR.ARPaymentChargeTran</para>
		/// <para>SQL Type: nvarchar(256)</para>
		/// </summary>
		[DataMember(Name="Description", EmitDefaultValue=false)]
		public StringValue? Description { get; set; }

		/// <summary>
		/// <para>DAC: PX.Objects.AR.ARPayment</para>
		/// <para>Display Name: Type</para>
		/// <para>SQL Type: char(3)</para>
		/// Key Field
		/// </summary>
		[DataMember(Name="DocType", EmitDefaultValue=false)]
		public StringValue? DocType { get; set; }

		/// <summary>
		/// <para>DAC: PX.Objects.AR.ARPaymentChargeTran</para>
		/// <para>Display Name: Entry Type</para>
		/// <para>SQL Type: nvarchar(10)</para>
		/// </summary>
		[DataMember(Name="EntryTypeID", EmitDefaultValue=false)]
		public StringValue? EntryTypeID { get; set; }

		/// <summary>
		/// <para>DAC: PX.Objects.AR.ARTranPostBal</para>
		/// <para>Display Name: Line Nbr.</para>
		/// </summary>
		[DataMember(Name="LineNbr", EmitDefaultValue=false)]
		public IntValue? LineNbr { get; set; }

		/// <summary>
		/// <para>DAC: PX.Objects.AR.ARPayment</para>
		/// <para>Display Name: Reference Nbr.</para>
		/// <para>SQL Type: nvarchar(15)</para>
		/// Key Field
		/// </summary>
		[DataMember(Name="RefNbr", EmitDefaultValue=false)]
		public StringValue? RefNbr { get; set; }

		[DataMember(Name="SubID", EmitDefaultValue=false)]
		public StringValue? SubID { get; set; }

	}
}