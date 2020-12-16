using Acumatica.RESTClient.Model;
using System.Collections.Generic;
using System.Runtime.Serialization;

namespace Acumatica.Default_20_200_001.Model
{
	[DataContract]
	public class ItemClass : Entity_v4
	{

		[DataMember(Name="Attributes", EmitDefaultValue=false)]
		public List<ItemClassAtrribute> Attributes { get; set; }

		[DataMember(Name="AvailabilityCalculationRule", EmitDefaultValue=false)]
		public StringValue AvailabilityCalculationRule { get; set; }

		[DataMember(Name="BaseUOM", EmitDefaultValue=false)]
		public StringValue BaseUOM { get; set; }

		[DataMember(Name="ClassID", EmitDefaultValue=false)]
		public StringValue ClassID { get; set; }

		[DataMember(Name="DefaultWarehouseID", EmitDefaultValue=false)]
		public StringValue DefaultWarehouseID { get; set; }

		[DataMember(Name="Description", EmitDefaultValue=false)]
		public StringValue Description { get; set; }

		[DataMember(Name="ItemType", EmitDefaultValue=false)]
		public StringValue ItemType { get; set; }

		[DataMember(Name="LastModifiedDateTime", EmitDefaultValue=false)]
		public DateTimeValue LastModifiedDateTime { get; set; }

		[DataMember(Name="LotSerialClass", EmitDefaultValue=false)]
		public StringValue LotSerialClass { get; set; }

		[DataMember(Name="PostingClass", EmitDefaultValue=false)]
		public StringValue PostingClass { get; set; }

		[DataMember(Name="PriceClass", EmitDefaultValue=false)]
		public StringValue PriceClass { get; set; }

		[DataMember(Name="PurchaseUOM", EmitDefaultValue=false)]
		public StringValue PurchaseUOM { get; set; }

		[DataMember(Name="SalesUOM", EmitDefaultValue=false)]
		public StringValue SalesUOM { get; set; }

		[DataMember(Name="StockItem", EmitDefaultValue=false)]
		public BooleanValue StockItem { get; set; }

		[DataMember(Name="TaxCategoryID", EmitDefaultValue=false)]
		public StringValue TaxCategoryID { get; set; }

		[DataMember(Name="ValuationMethod", EmitDefaultValue=false)]
		public StringValue ValuationMethod { get; set; }

	}
}