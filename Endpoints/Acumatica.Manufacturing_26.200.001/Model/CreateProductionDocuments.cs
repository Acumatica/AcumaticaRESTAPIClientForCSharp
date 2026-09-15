using System;
using System.Collections.Generic;
using System.Runtime.Serialization;

using Newtonsoft.Json;

using Acumatica.RESTClient.Client;
using Acumatica.RESTClient.ContractBasedApi;
using Acumatica.RESTClient.ContractBasedApi.Model;

namespace Acumatica.Manufacturing_26_200_001.Model
{
	[DataContract]
	public class CreateProductionDocuments : Entity
	{

		/// <summary>
		/// <para>DAC Field Name: SOOrder__CustomerID</para>
		/// <para>DAC: PX.Objects.AM.AMFixedDemand</para>
		/// </summary>
		[DataMember(Name="Customer", EmitDefaultValue=false)]
		public StringValue? Customer { get; set; }

		/// <summary>
		/// <para>DAC Field Name: SOOrder__CustomerLocationID</para>
		/// <para>DAC: PX.Objects.AM.AMFixedDemand</para>
		/// </summary>
		[DataMember(Name="CustomerLocation", EmitDefaultValue=false)]
		public StringValue? CustomerLocation { get; set; }

		/// <summary>
		/// <para>DAC Field Name: SOOrder__CustomerID_BAccountR_acctName</para>
		/// <para>DAC: PX.Objects.AM.AMFixedDemand</para>
		/// </summary>
		[DataMember(Name="CustomerName", EmitDefaultValue=false)]
		public StringValue? CustomerName { get; set; }

		/// <summary>
		/// <para>DAC: PX.Objects.AM.CreateProductionOrdersProcess+ProductionOrdersCreateFilter</para>
		/// </summary>
		[DataMember(Name="InventoryID", EmitDefaultValue=false)]
		public StringValue? InventoryID { get; set; }

		/// <summary>
		/// <para>DAC Field Name: InventoryID_InventoryItem_descr</para>
		/// <para>DAC: PX.Objects.AM.AMFixedDemand</para>
		/// </summary>
		[DataMember(Name="ItemDescription", EmitDefaultValue=false)]
		public StringValue? ItemDescription { get; set; }

		[DataMember(Name="PlanID", EmitDefaultValue=false)]
		public LongValue? PlanID { get; set; }

		/// <summary>
		/// <para>DAC Field Name: PlanType_INPlanType_descr</para>
		/// <para>DAC: PX.Objects.AM.AMFixedDemand</para>
		/// </summary>
		[DataMember(Name="PlanType", EmitDefaultValue=false)]
		public StringValue? PlanType { get; set; }

		/// <summary>
		/// <para>DAC Field Name: AMOperationID</para>
		/// <para>DAC: PX.Objects.AM.AMFixedDemand</para>
		/// <para>Display Name: Prod. Operation ID</para>
		/// </summary>
		[DataMember(Name="ProdOperationID", EmitDefaultValue=false)]
		public StringValue? ProdOperationID { get; set; }

		/// <summary>
		/// <para>DAC Field Name: AMOrderType</para>
		/// <para>DAC: PX.Objects.AM.AMFixedDemand</para>
		/// <para>Display Name: Prod. Order Type</para>
		/// <para>SQL Type: char(2)</para>
		/// </summary>
		[DataMember(Name="ProdOrderType", EmitDefaultValue=false)]
		public StringValue? ProdOrderType { get; set; }

		/// <summary>
		/// <para>DAC Field Name: AMProdOrdID</para>
		/// <para>DAC: PX.Objects.AM.AMFixedDemand</para>
		/// <para>Display Name: Production Nbr.</para>
		/// <para>SQL Type: nvarchar(19)</para>
		/// </summary>
		[DataMember(Name="ProductionNbr", EmitDefaultValue=false)]
		public StringValue? ProductionNbr { get; set; }

		/// <summary>
		/// <para>DAC Field Name: OrderQty</para>
		/// <para>DAC: PX.Objects.AM.AMFixedDemand</para>
		/// </summary>
		[DataMember(Name="Quantity", EmitDefaultValue=false)]
		public DecimalValue? Quantity { get; set; }

		/// <summary>
		/// <para>DAC Field Name: PlanDate</para>
		/// <para>DAC: PX.Objects.AM.AMFixedDemand</para>
		/// <para>Display Name: Requested On</para>
		/// </summary>
		[DataMember(Name="RequestedOn", EmitDefaultValue=false)]
		public DateTimeValue? RequestedOn { get; set; }

		/// <summary>
		/// Specifies (if set to true) that a user has selected the record in the table on the form for processing.
		/// <para>DAC: PX.Objects.AM.AMFixedDemand</para>
		/// </summary>
		[DataMember(Name="Selected", EmitDefaultValue=false)]
		public BooleanValue? Selected { get; set; }

		/// <summary>
		/// <para>DAC: PX.Objects.AM.CreateProductionOrdersProcess+ProductionOrdersCreateFilter</para>
		/// </summary>
		[DataMember(Name="SOOrderNbr", EmitDefaultValue=false)]
		public StringValue? SOOrderNbr { get; set; }

		/// <summary>
		/// <para>DAC: PX.Objects.AM.CreateProductionOrdersProcess+ProductionOrdersCreateFilter</para>
		/// </summary>
		[DataMember(Name="SOOrderType", EmitDefaultValue=false)]
		public StringValue? SOOrderType { get; set; }

		/// <summary>
		/// <para>DAC Field Name: SubItemID</para>
		/// <para>DAC: PX.Objects.AM.AMFixedDemand</para>
		/// </summary>
		[DataMember(Name="Subitem", EmitDefaultValue=false)]
		public StringValue? Subitem { get; set; }

		/// <summary>
		/// <para>DAC: PX.Objects.AM.AMFixedDemand</para>
		/// <para>SQL Type: varchar(MAX)</para>
		/// </summary>
		[DataMember(Name="UOM", EmitDefaultValue=false)]
		public StringValue? UOM { get; set; }

		/// <summary>
		/// <para>DAC Field Name: SiteID</para>
		/// <para>DAC: PX.Objects.AM.CreateProductionOrdersProcess+ProductionOrdersCreateFilter</para>
		/// </summary>
		[DataMember(Name="Warehouse", EmitDefaultValue=false)]
		public StringValue? Warehouse { get; set; }

		/// <summary>
		/// Names that can be passed in the <c>$expand</c> parameter.
		/// <para>This endpoint uses system contract 5, where a nested entity is expanded
		/// as <c>Parent($expand=Child)</c> rather than <c>Parent/Child</c>, so only the names
		/// that can be expanded directly on this entity are listed here. Use the nested
		/// entity's own <c>Expand</c> class for the inner names.</para>
		/// </summary>
		public static class Expand
		{
			public const string Files = "Files";

			//Intentionally excluded
			//public const string All = "Files";
		}
	}
}