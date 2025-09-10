using System;
using System.Collections.Generic;
using System.Runtime.Serialization;

using Newtonsoft.Json;

using Acumatica.RESTClient.Client;
using Acumatica.RESTClient.ContractBasedApi;
using Acumatica.RESTClient.ContractBasedApi.Model;

namespace Acumatica.Manufacturing_24_200_001.Model
{
	[DataContract]
	public class CreateProductionDocuments : Entity
	{

		/// <summary>
		/// DAC Field Name: SOOrder__CustomerID 
		/// DAC: PX.Objects.AM.AMFixedDemand 
		/// </summary>
		[DataMember(Name="Customer", EmitDefaultValue=false)]
		public StringValue? Customer { get; set; }

		/// <summary>
		/// DAC Field Name: SOOrder__CustomerLocationID 
		/// DAC: PX.Objects.AM.AMFixedDemand 
		/// </summary>
		[DataMember(Name="CustomerLocation", EmitDefaultValue=false)]
		public StringValue? CustomerLocation { get; set; }

		/// <summary>
		/// DAC Field Name: SOOrder__CustomerID_BAccountR_acctName 
		/// DAC: PX.Objects.AM.AMFixedDemand 
		/// </summary>
		[DataMember(Name="CustomerName", EmitDefaultValue=false)]
		public StringValue? CustomerName { get; set; }

		/// <summary>
		/// DAC: PX.Objects.AM.CreateProductionOrdersProcess+ProductionOrdersCreateFilter 
		/// </summary>
		[DataMember(Name="InventoryID", EmitDefaultValue=false)]
		public StringValue? InventoryID { get; set; }

		/// <summary>
		/// DAC Field Name: InventoryID_InventoryItem_descr 
		/// DAC: PX.Objects.AM.AMFixedDemand 
		/// </summary>
		[DataMember(Name="ItemDescription", EmitDefaultValue=false)]
		public StringValue? ItemDescription { get; set; }

		[DataMember(Name="PlanID", EmitDefaultValue=false)]
		public LongValue? PlanID { get; set; }

		/// <summary>
		/// DAC Field Name: PlanType_INPlanType_descr 
		/// DAC: PX.Objects.AM.AMFixedDemand 
		/// </summary>
		[DataMember(Name="PlanType", EmitDefaultValue=false)]
		public StringValue? PlanType { get; set; }

		/// <summary>
		/// DAC Field Name: AMOperationID 
		/// DAC: PX.Objects.AM.AMFixedDemand 
		/// Display Name: Prod. Operation ID 
		/// </summary>
		[DataMember(Name="ProdOperationID", EmitDefaultValue=false)]
		public StringValue? ProdOperationID { get; set; }

		/// <summary>
		/// DAC Field Name: AMOrderType 
		/// DAC: PX.Objects.AM.AMFixedDemand 
		/// Display Name: Prod. Order Type 
		/// SQL Type: char(2) 
		/// </summary>
		[DataMember(Name="ProdOrderType", EmitDefaultValue=false)]
		public StringValue? ProdOrderType { get; set; }

		/// <summary>
		/// DAC Field Name: AMProdOrdID 
		/// DAC: PX.Objects.AM.AMFixedDemand 
		/// Display Name: Production Nbr. 
		/// SQL Type: nvarchar(15) 
		/// </summary>
		[DataMember(Name="ProductionNbr", EmitDefaultValue=false)]
		public StringValue? ProductionNbr { get; set; }

		/// <summary>
		/// DAC Field Name: OrderQty 
		/// DAC: PX.Objects.AM.AMFixedDemand 
		/// </summary>
		[DataMember(Name="Quantity", EmitDefaultValue=false)]
		public DecimalValue? Quantity { get; set; }

		/// <summary>
		/// DAC Field Name: PlanDate 
		/// DAC: PX.Objects.AM.AMFixedDemand 
		/// Display Name: Requested On 
		/// </summary>
		[DataMember(Name="RequestedOn", EmitDefaultValue=false)]
		public DateTimeValue? RequestedOn { get; set; }

		/// <summary>
		/// Specifies (if set to true) that a user has selected the record in the table on the form for processing.
		/// DAC: PX.Objects.AM.AMFixedDemand 
		/// </summary>
		[DataMember(Name="Selected", EmitDefaultValue=false)]
		public BooleanValue? Selected { get; set; }

		/// <summary>
		/// DAC: PX.Objects.AM.CreateProductionOrdersProcess+ProductionOrdersCreateFilter 
		/// </summary>
		[DataMember(Name="SOOrderNbr", EmitDefaultValue=false)]
		public StringValue? SOOrderNbr { get; set; }

		/// <summary>
		/// DAC: PX.Objects.AM.CreateProductionOrdersProcess+ProductionOrdersCreateFilter 
		/// </summary>
		[DataMember(Name="SOOrderType", EmitDefaultValue=false)]
		public StringValue? SOOrderType { get; set; }

		/// <summary>
		/// DAC Field Name: SubItemID 
		/// DAC: PX.Objects.AM.AMFixedDemand 
		/// </summary>
		[DataMember(Name="Subitem", EmitDefaultValue=false)]
		public StringValue? Subitem { get; set; }

		/// <summary>
		/// DAC: PX.Objects.AM.AMFixedDemand 
		/// SQL Type: varchar(MAX) 
		/// </summary>
		[DataMember(Name="UOM", EmitDefaultValue=false)]
		public StringValue? UOM { get; set; }

		/// <summary>
		/// DAC Field Name: SiteID 
		/// DAC: PX.Objects.AM.CreateProductionOrdersProcess+ProductionOrdersCreateFilter 
		/// </summary>
		[DataMember(Name="Warehouse", EmitDefaultValue=false)]
		public StringValue? Warehouse { get; set; }

	}
}