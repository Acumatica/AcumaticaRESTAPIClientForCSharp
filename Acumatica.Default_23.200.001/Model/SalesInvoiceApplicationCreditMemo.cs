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
	public class SalesInvoiceApplicationCreditMemo : Entity
	{

		[DataMember(Name="AmountPaid", EmitDefaultValue=false)]
		public DecimalValue? AmountPaid { get; set; }

		[DataMember(Name="Balance", EmitDefaultValue=false)]
		public DecimalValue? Balance { get; set; }

		[DataMember(Name="Currency", EmitDefaultValue=false)]
		public StringValue? Currency { get; set; }

		[DataMember(Name="Customer", EmitDefaultValue=false)]
		public StringValue? Customer { get; set; }

		[DataMember(Name="CustomerOrder", EmitDefaultValue=false)]
		public StringValue? CustomerOrder { get; set; }

		[DataMember(Name="Date", EmitDefaultValue=false)]
		public DateTimeValue? Date { get; set; }

		[DataMember(Name="Description", EmitDefaultValue=false)]
		public StringValue? Description { get; set; }

		[DataMember(Name="DocType", EmitDefaultValue=false)]
		public StringValue? DocType { get; set; }

		[DataMember(Name="PostPeriod", EmitDefaultValue=false)]
		public StringValue? PostPeriod { get; set; }

		[DataMember(Name="ReferenceNbr", EmitDefaultValue=false)]
		public StringValue? ReferenceNbr { get; set; }

		[DataMember(Name="Status", EmitDefaultValue=false)]
		public StringValue? Status { get; set; }

	}
}