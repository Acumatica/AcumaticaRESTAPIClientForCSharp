using Acumatica.RESTClient.Model;
using System.Collections.Generic;
using System.Runtime.Serialization;

namespace Acumatica.Default_20_200_001.Model
{
	[DataContract]
	public class StockItemVendorDetail : Entity_v4
	{

		[DataMember(Name="Active", EmitDefaultValue=false)]
		public BooleanValue Active { get; set; }

		[DataMember(Name="AddLeadTimeDays", EmitDefaultValue=false)]
		public ShortValue AddLeadTimeDays { get; set; }

		[DataMember(Name="CurrencyID", EmitDefaultValue=false)]
		public StringValue CurrencyID { get; set; }

		[DataMember(Name="Default", EmitDefaultValue=false)]
		public BooleanValue Default { get; set; }

		[DataMember(Name="EOQ", EmitDefaultValue=false)]
		public DecimalValue EOQ { get; set; }

		[DataMember(Name="LastVendorPrice", EmitDefaultValue=false)]
		public DecimalValue LastVendorPrice { get; set; }

		[DataMember(Name="LeadTimeDays", EmitDefaultValue=false)]
		public ShortValue LeadTimeDays { get; set; }

		[DataMember(Name="Location", EmitDefaultValue=false)]
		public StringValue Location { get; set; }

		[DataMember(Name="LotSize", EmitDefaultValue=false)]
		public DecimalValue LotSize { get; set; }

		[DataMember(Name="MaxOrderQty", EmitDefaultValue=false)]
		public DecimalValue MaxOrderQty { get; set; }

		[DataMember(Name="MinOrderFrequencyInDays", EmitDefaultValue=false)]
		public IntValue MinOrderFrequencyInDays { get; set; }

		[DataMember(Name="MinOrderQty", EmitDefaultValue=false)]
		public DecimalValue MinOrderQty { get; set; }

		[DataMember(Name="Override", EmitDefaultValue=false)]
		public BooleanValue Override { get; set; }

		[DataMember(Name="PurchaseUnit", EmitDefaultValue=false)]
		public StringValue PurchaseUnit { get; set; }

		[DataMember(Name="RecordID", EmitDefaultValue=false)]
		public IntValue RecordID { get; set; }

		[DataMember(Name="Subitem", EmitDefaultValue=false)]
		public StringValue Subitem { get; set; }

		[DataMember(Name="VendorID", EmitDefaultValue=false)]
		public StringValue VendorID { get; set; }

		[DataMember(Name="VendorName", EmitDefaultValue=false)]
		public StringValue VendorName { get; set; }

		[DataMember(Name="Warehouse", EmitDefaultValue=false)]
		public StringValue Warehouse { get; set; }

	}
}