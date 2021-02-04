using Acumatica.RESTClient.Model;
using System.Collections.Generic;
using System.Runtime.Serialization;

namespace Acumatica.Manufacturing_20_200_001.Model
{
	[DataContract]
	public class MRPException : Entity_v4
	{

		[DataMember(Name="Description", EmitDefaultValue=false)]
		public StringValue Description { get; set; }

		[DataMember(Name="EmployeeName", EmitDefaultValue=false)]
		public StringValue EmployeeName { get; set; }

		[DataMember(Name="InventoryID", EmitDefaultValue=false)]
		public StringValue InventoryID { get; set; }

		[DataMember(Name="ItemClass", EmitDefaultValue=false)]
		public StringValue ItemClass { get; set; }

		[DataMember(Name="ProductManagerID", EmitDefaultValue=false)]
		public StringValue ProductManagerID { get; set; }

		[DataMember(Name="PromiseDate", EmitDefaultValue=false)]
		public DateTimeValue PromiseDate { get; set; }

		[DataMember(Name="Quantity", EmitDefaultValue=false)]
		public DecimalValue Quantity { get; set; }

		[DataMember(Name="RecordID", EmitDefaultValue=false)]
		public IntValue RecordID { get; set; }

		[DataMember(Name="RefType", EmitDefaultValue=false)]
		public StringValue RefType { get; set; }

		[DataMember(Name="RelatedDocument", EmitDefaultValue=false)]
		public GuidValue RelatedDocument { get; set; }

		[DataMember(Name="RequiredDate", EmitDefaultValue=false)]
		public DateTimeValue RequiredDate { get; set; }

		[DataMember(Name="Subitem", EmitDefaultValue=false)]
		public StringValue Subitem { get; set; }

		[DataMember(Name="SupplyQty", EmitDefaultValue=false)]
		public DecimalValue SupplyQty { get; set; }

		[DataMember(Name="SupplyWarehouse", EmitDefaultValue=false)]
		public StringValue SupplyWarehouse { get; set; }

		[DataMember(Name="Type", EmitDefaultValue=false)]
		public StringValue Type { get; set; }

		[DataMember(Name="Warehouse", EmitDefaultValue=false)]
		public StringValue Warehouse { get; set; }

	}
}