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
	public class AppPrepayments : Entity
	{

		/// <summary>
		/// DAC Field Name: AdjDate 
		/// DAC: PX.Objects.AR.ARPayment 
		/// Display Name: Application Date 
		/// </summary>
		[DataMember(Name="ApplicationDate", EmitDefaultValue=false)]
		public DateTimeValue? ApplicationDate { get; set; }

		/// <summary>
		/// DAC Field Name: CurySOApplAmt 
		/// DAC: PX.Objects.AR.ARPayment 
		/// Display Name: Applied to Orders 
		/// </summary>
		[DataMember(Name="AppliedtoOrders", EmitDefaultValue=false)]
		public DecimalValue? AppliedtoOrders { get; set; }

		/// <summary>
		/// DAC Field Name: CuryUnappliedBal 
		/// DAC: PX.Objects.AR.ARPayment 
		/// Display Name: Available Balance 
		/// </summary>
		[DataMember(Name="AvailableBalance", EmitDefaultValue=false)]
		public DecimalValue? AvailableBalance { get; set; }

		/// <summary>
		/// DAC Field Name: CashAccountID 
		/// DAC: PX.Objects.AR.ARPayment 
		/// Display Name: Cash Account 
		/// </summary>
		[DataMember(Name="CashAccount", EmitDefaultValue=false)]
		public IntValue? CashAccount { get; set; }

		/// <summary>
		/// The code of the Currency of the document.
		/// DAC Field Name: CuryID 
		/// DAC: PX.Objects.AR.ARPayment 
		/// SQL Type: nvarchar(5) 
		/// </summary>
		[DataMember(Name="Currency", EmitDefaultValue=false)]
		public StringValue? Currency { get; set; }

		/// <summary>
		/// DAC Field Name: CuryOrigDocAmt 
		/// DAC: PX.Objects.AR.ARPayment 
		/// Display Name: Payment Amount 
		/// </summary>
		[DataMember(Name="PaymentAmount", EmitDefaultValue=false)]
		public DecimalValue? PaymentAmount { get; set; }

		/// <summary>
		/// DAC Field Name: PaymentMethodID 
		/// DAC: PX.Objects.AR.ARPayment 
		/// Display Name: Payment Method 
		/// SQL Type: nvarchar(10) 
		/// </summary>
		[DataMember(Name="PaymentMethod", EmitDefaultValue=false)]
		public StringValue? PaymentMethod { get; set; }

		/// <summary>
		/// DAC Field Name: ExtRefNbr 
		/// DAC: PX.Objects.AR.ARPayment 
		/// Display Name: Payment Ref. 
		/// SQL Type: nvarchar(40) 
		/// </summary>
		[DataMember(Name="PaymentRef", EmitDefaultValue=false)]
		public StringValue? PaymentRef { get; set; }

		/// <summary>
		/// DAC Field Name: RefNbr 
		/// DAC: PX.Objects.FS.FSAppointment 
		/// Display Name: Appointment Nbr. 
		/// SQL Type: nvarchar(20) 
		/// Key Field
		/// </summary>
		[DataMember(Name="ReferenceNbr", EmitDefaultValue=false)]
		public StringValue? ReferenceNbr { get; set; }

		/// <summary>
		/// DAC Field Name: FSAdjust__AdjdAppRefNbr 
		/// DAC: PX.Objects.AR.ARPayment 
		/// </summary>
		[DataMember(Name="SourceAppointmentNbr", EmitDefaultValue=false)]
		public StringValue? SourceAppointmentNbr { get; set; }

		/// <summary>
		/// DAC: PX.Objects.FS.FSAppointment 
		/// SQL Type: char(1) 
		/// </summary>
		[DataMember(Name="Status", EmitDefaultValue=false)]
		public StringValue? Status { get; set; }

		/// <summary>
		/// DAC Field Name: DocType 
		/// DAC: PX.Objects.AR.ARPayment 
		/// SQL Type: char(3) 
		/// Key Field
		/// </summary>
		[DataMember(Name="Type", EmitDefaultValue=false)]
		public StringValue? Type { get; set; }

	}
}