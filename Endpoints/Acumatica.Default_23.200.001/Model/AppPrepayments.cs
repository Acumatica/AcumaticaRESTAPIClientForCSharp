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
	public class AppPrepayments : Entity
	{

		/// <summary>
		/// <para>DAC Field Name: AdjDate</para>
		/// <para>DAC: PX.Objects.AR.ARPayment</para>
		/// <para>Display Name: Application Date</para>
		/// </summary>
		[DataMember(Name="ApplicationDate", EmitDefaultValue=false)]
		public DateTimeValue? ApplicationDate { get; set; }

		/// <summary>
		/// <para>DAC Field Name: CurySOApplAmt</para>
		/// <para>DAC: PX.Objects.AR.ARPayment</para>
		/// <para>Display Name: Applied to Orders</para>
		/// </summary>
		[DataMember(Name="AppliedtoOrders", EmitDefaultValue=false)]
		public DecimalValue? AppliedtoOrders { get; set; }

		/// <summary>
		/// <para>DAC Field Name: CuryUnappliedBal</para>
		/// <para>DAC: PX.Objects.AR.ARPayment</para>
		/// <para>Display Name: Available Balance</para>
		/// </summary>
		[DataMember(Name="AvailableBalance", EmitDefaultValue=false)]
		public DecimalValue? AvailableBalance { get; set; }

		/// <summary>
		/// <para>DAC Field Name: CashAccountID</para>
		/// <para>DAC: PX.Objects.AR.ARPayment</para>
		/// <para>Display Name: Cash Account</para>
		/// </summary>
		[DataMember(Name="CashAccount", EmitDefaultValue=false)]
		public IntValue? CashAccount { get; set; }

		/// <summary>
		/// The code of the Currency of the document.
		/// <para>DAC Field Name: CuryID</para>
		/// <para>DAC: PX.Objects.AR.ARPayment</para>
		/// <para>SQL Type: nvarchar(5)</para>
		/// </summary>
		[DataMember(Name="Currency", EmitDefaultValue=false)]
		public StringValue? Currency { get; set; }

		/// <summary>
		/// <para>DAC Field Name: CuryOrigDocAmt</para>
		/// <para>DAC: PX.Objects.AR.ARPayment</para>
		/// <para>Display Name: Payment Amount</para>
		/// </summary>
		[DataMember(Name="PaymentAmount", EmitDefaultValue=false)]
		public DecimalValue? PaymentAmount { get; set; }

		/// <summary>
		/// <para>DAC Field Name: PaymentMethodID</para>
		/// <para>DAC: PX.Objects.AR.ARPayment</para>
		/// <para>Display Name: Payment Method</para>
		/// <para>SQL Type: nvarchar(10)</para>
		/// </summary>
		[DataMember(Name="PaymentMethod", EmitDefaultValue=false)]
		public StringValue? PaymentMethod { get; set; }

		/// <summary>
		/// <para>DAC Field Name: ExtRefNbr</para>
		/// <para>DAC: PX.Objects.AR.ARPayment</para>
		/// <para>Display Name: Payment Ref.</para>
		/// <para>SQL Type: nvarchar(40)</para>
		/// </summary>
		[DataMember(Name="PaymentRef", EmitDefaultValue=false)]
		public StringValue? PaymentRef { get; set; }

		/// <summary>
		/// <para>DAC Field Name: RefNbr</para>
		/// <para>DAC: PX.Objects.FS.FSAppointment</para>
		/// <para>Display Name: Appointment Nbr.</para>
		/// <para>SQL Type: nvarchar(20)</para>
		/// Key Field
		/// </summary>
		[DataMember(Name="ReferenceNbr", EmitDefaultValue=false)]
		public StringValue? ReferenceNbr { get; set; }

		/// <summary>
		/// <para>DAC Field Name: FSAdjust__AdjdAppRefNbr</para>
		/// <para>DAC: PX.Objects.AR.ARPayment</para>
		/// </summary>
		[DataMember(Name="SourceAppointmentNbr", EmitDefaultValue=false)]
		public StringValue? SourceAppointmentNbr { get; set; }

		/// <summary>
		/// <para>DAC: PX.Objects.FS.FSAppointment</para>
		/// <para>SQL Type: char(1)</para>
		/// </summary>
		[DataMember(Name="Status", EmitDefaultValue=false)]
		public StringValue? Status { get; set; }

		/// <summary>
		/// <para>DAC Field Name: DocType</para>
		/// <para>DAC: PX.Objects.AR.ARPayment</para>
		/// <para>SQL Type: char(3)</para>
		/// Key Field
		/// </summary>
		[DataMember(Name="Type", EmitDefaultValue=false)]
		public StringValue? Type { get; set; }

	}
}