using System;
using System.Collections.Generic;
using System.Runtime.Serialization;

using Newtonsoft.Json;

using Acumatica.RESTClient.Client;
using Acumatica.RESTClient.ContractBasedApi;
using Acumatica.RESTClient.ContractBasedApi.Model;

namespace Acumatica.eCommerce_20_200_001.Model
{
	[DataContract]
	public class SrvOrdPrepayments : Entity
	{

		[DataMember(Name="ApplicationDate", EmitDefaultValue=false)]
		public DateTimeValue? ApplicationDate { get; set; }

		[DataMember(Name="AppliedtoOrders", EmitDefaultValue=false)]
		public DecimalValue? AppliedtoOrders { get; set; }

		[DataMember(Name="AvailableBalance", EmitDefaultValue=false)]
		public DecimalValue? AvailableBalance { get; set; }

		[DataMember(Name="CashAccount", EmitDefaultValue=false)]
		public IntValue? CashAccount { get; set; }

		[DataMember(Name="Currency", EmitDefaultValue=false)]
		public StringValue? Currency { get; set; }

		[DataMember(Name="PaymentAmount", EmitDefaultValue=false)]
		public DecimalValue? PaymentAmount { get; set; }

		[DataMember(Name="PaymentMethod", EmitDefaultValue=false)]
		public StringValue? PaymentMethod { get; set; }

		[DataMember(Name="PaymentRef", EmitDefaultValue=false)]
		public StringValue? PaymentRef { get; set; }

		[DataMember(Name="ReferenceNbr", EmitDefaultValue=false)]
		public StringValue? ReferenceNbr { get; set; }

		[DataMember(Name="SourceAppointmentNbr", EmitDefaultValue=false)]
		public StringValue? SourceAppointmentNbr { get; set; }

		[DataMember(Name="Status", EmitDefaultValue=false)]
		public StringValue? Status { get; set; }

		[DataMember(Name="Type", EmitDefaultValue=false)]
		public StringValue? Type { get; set; }

	}
}