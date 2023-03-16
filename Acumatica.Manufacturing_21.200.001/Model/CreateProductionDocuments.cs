using System.Collections.Generic;
using System.Runtime.Serialization;

using Newtonsoft.Json;

using Acumatica.RESTClient.Client;
using Acumatica.RESTClient.ContractBasedApi;
using Acumatica.RESTClient.ContractBasedApi.Model;

namespace Acumatica.Manufacturing_21_200_001.Model
{
	[DataContract]
	public class CreateProductionDocuments : Entity
	{

		[DataMember(Name="Customer", EmitDefaultValue=false)]
		public StringValue Customer { get; set; }

		[DataMember(Name="CustomerLocation", EmitDefaultValue=false)]
		public StringValue CustomerLocation { get; set; }

		[DataMember(Name="CustomerName", EmitDefaultValue=false)]
		public StringValue CustomerName { get; set; }

		[DataMember(Name="InventoryID", EmitDefaultValue=false)]
		public StringValue InventoryID { get; set; }

		[DataMember(Name="ItemDescription", EmitDefaultValue=false)]
		public StringValue ItemDescription { get; set; }

		[DataMember(Name="PlanID", EmitDefaultValue=false)]
		public LongValue PlanID { get; set; }

		[DataMember(Name="PlanType", EmitDefaultValue=false)]
		public StringValue PlanType { get; set; }

		[DataMember(Name="ProdOperationID", EmitDefaultValue=false)]
		public StringValue ProdOperationID { get; set; }

		[DataMember(Name="ProdOrderType", EmitDefaultValue=false)]
		public StringValue ProdOrderType { get; set; }

		[DataMember(Name="ProductionNbr", EmitDefaultValue=false)]
		public StringValue ProductionNbr { get; set; }

		[DataMember(Name="Quantity", EmitDefaultValue=false)]
		public DecimalValue Quantity { get; set; }

		[DataMember(Name="RequestedOn", EmitDefaultValue=false)]
		public DateTimeValue RequestedOn { get; set; }

		[DataMember(Name="Selected", EmitDefaultValue=false)]
		public BooleanValue Selected { get; set; }

		[DataMember(Name="SOOrderNbr", EmitDefaultValue=false)]
		public StringValue SOOrderNbr { get; set; }

		[DataMember(Name="SOOrderType", EmitDefaultValue=false)]
		public StringValue SOOrderType { get; set; }

		[DataMember(Name="Subitem", EmitDefaultValue=false)]
		public StringValue Subitem { get; set; }

		[DataMember(Name="UOM", EmitDefaultValue=false)]
		public StringValue UOM { get; set; }

		[DataMember(Name="Warehouse", EmitDefaultValue=false)]
		public StringValue Warehouse { get; set; }

	}
}