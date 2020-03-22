using Acumatica.RESTClient.Model;
using System.Collections.Generic;
using System.Runtime.Serialization;

namespace Acumatica.Default_17_200_001.Model
{
	[DataContract]
	public class SalesInvoice : Entity
	{

		[DataMember(Name="Amount", EmitDefaultValue=false)]
		public DecimalValue Amount { get; set; }

		[DataMember(Name="Balance", EmitDefaultValue=false)]
		public DecimalValue Balance { get; set; }

		[DataMember(Name="BillingSettings", EmitDefaultValue=false)]
		public BillToSettings BillingSettings { get; set; }

		[DataMember(Name="CustomerID", EmitDefaultValue=false)]
		public StringValue CustomerID { get; set; }

		[DataMember(Name="CustomerOrder", EmitDefaultValue=false)]
		public StringValue CustomerOrder { get; set; }

		[DataMember(Name="Date", EmitDefaultValue=false)]
		public DateTimeValue Date { get; set; }

		[DataMember(Name="Description", EmitDefaultValue=false)]
		public StringValue Description { get; set; }

		[DataMember(Name="Details", EmitDefaultValue=false)]
		public List<SalesInvoiceDetail> Details { get; set; }

		[DataMember(Name="DueDate", EmitDefaultValue=false)]
		public DateTimeValue DueDate { get; set; }

		[DataMember(Name="FreightDetails", EmitDefaultValue=false)]
		public List<SalesInvoiceFreightDetail> FreightDetails { get; set; }

		[DataMember(Name="Hold", EmitDefaultValue=false)]
		public BooleanValue Hold { get; set; }

		[DataMember(Name="ReferenceNbr", EmitDefaultValue=false)]
		public StringValue ReferenceNbr { get; set; }

		[DataMember(Name="Status", EmitDefaultValue=false)]
		public StringValue Status { get; set; }

		[DataMember(Name="Type", EmitDefaultValue=false)]
		public StringValue Type { get; set; }

	}
}