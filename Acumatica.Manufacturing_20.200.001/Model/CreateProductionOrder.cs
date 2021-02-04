using Acumatica.RESTClient.Model;
using System.Collections.Generic;
using System.Runtime.Serialization;

namespace Acumatica.Manufacturing_20_200_001.Model
{
	[DataContract]
	public class CreateProductionOrder : Entity_v4
	{

		[DataMember(Name="CreationDate", EmitDefaultValue=false)]
		public DateTimeValue CreationDate { get; set; }

		[DataMember(Name="CreationOrderType", EmitDefaultValue=false)]
		public StringValue CreationOrderType { get; set; }

		[DataMember(Name="Customer", EmitDefaultValue=false)]
		public StringValue Customer { get; set; }

		[DataMember(Name="Documents", EmitDefaultValue=false)]
		public List<CreateProductionDocuments> Documents { get; set; }

		[DataMember(Name="InventoryID", EmitDefaultValue=false)]
		public StringValue InventoryID { get; set; }

		[DataMember(Name="ItemClassID", EmitDefaultValue=false)]
		public StringValue ItemClassID { get; set; }

		[DataMember(Name="Me", EmitDefaultValue=false)]
		public BooleanValue Me { get; set; }

		[DataMember(Name="My", EmitDefaultValue=false)]
		public BooleanValue My { get; set; }

		[DataMember(Name="ProdOrderType", EmitDefaultValue=false)]
		public StringValue ProdOrderType { get; set; }

		[DataMember(Name="ProductionNbr", EmitDefaultValue=false)]
		public StringValue ProductionNbr { get; set; }

		[DataMember(Name="ProductManager", EmitDefaultValue=false)]
		public StringValue ProductManager { get; set; }

		[DataMember(Name="ProductWorkgroup", EmitDefaultValue=false)]
		public StringValue ProductWorkgroup { get; set; }

		[DataMember(Name="RequestedOnEndDate", EmitDefaultValue=false)]
		public DateTimeValue RequestedOnEndDate { get; set; }

		[DataMember(Name="RequestedOnStartDate", EmitDefaultValue=false)]
		public DateTimeValue RequestedOnStartDate { get; set; }

		[DataMember(Name="SOOrderNbr", EmitDefaultValue=false)]
		public StringValue SOOrderNbr { get; set; }

		[DataMember(Name="SOOrderType", EmitDefaultValue=false)]
		public StringValue SOOrderType { get; set; }

		[DataMember(Name="WarehouseID", EmitDefaultValue=false)]
		public StringValue WarehouseID { get; set; }

	}
}