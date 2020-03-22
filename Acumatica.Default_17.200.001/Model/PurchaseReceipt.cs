using Acumatica.RESTClient.Model;
using System.Collections.Generic;
using System.Runtime.Serialization;

namespace Acumatica.Default_17_200_001.Model
{
	[DataContract]
	public class PurchaseReceipt : Entity
	{

		[DataMember(Name="ControlAmount", EmitDefaultValue=false)]
		public DecimalValue ControlAmount { get; set; }

		[DataMember(Name="ControlQty", EmitDefaultValue=false)]
		public DecimalValue ControlQty { get; set; }

		[DataMember(Name="CreateBill", EmitDefaultValue=false)]
		public BooleanValue CreateBill { get; set; }

		[DataMember(Name="CurrencyID", EmitDefaultValue=false)]
		public StringValue CurrencyID { get; set; }

		[DataMember(Name="Date", EmitDefaultValue=false)]
		public DateTimeValue Date { get; set; }

		[DataMember(Name="Details", EmitDefaultValue=false)]
		public List<PurchaseReceiptDetail> Details { get; set; }

		[DataMember(Name="Hold", EmitDefaultValue=false)]
		public BooleanValue Hold { get; set; }

		[DataMember(Name="PostPeriod", EmitDefaultValue=false)]
		public StringValue PostPeriod { get; set; }

		[DataMember(Name="ReceiptNbr", EmitDefaultValue=false)]
		public StringValue ReceiptNbr { get; set; }

		[DataMember(Name="Status", EmitDefaultValue=false)]
		public StringValue Status { get; set; }

		[DataMember(Name="TotalAmount", EmitDefaultValue=false)]
		public DecimalValue TotalAmount { get; set; }

		[DataMember(Name="TotalQty", EmitDefaultValue=false)]
		public DecimalValue TotalQty { get; set; }

		[DataMember(Name="Type", EmitDefaultValue=false)]
		public StringValue Type { get; set; }

		[DataMember(Name="VendorID", EmitDefaultValue=false)]
		public StringValue VendorID { get; set; }

		[DataMember(Name="VendorRef", EmitDefaultValue=false)]
		public StringValue VendorRef { get; set; }

	}
}