using System;
using System.Collections.Generic;
using System.Runtime.Serialization;

using Newtonsoft.Json;

using Acumatica.RESTClient.Client;
using Acumatica.RESTClient.ContractBasedApi;
using Acumatica.RESTClient.ContractBasedApi.Model;

namespace Acumatica.Manufacturing_23_200_001.Model
{
	/// <summary>
	/// Corresponds to the screen AM201100 in the Acumatica ERP
	/// </summary>
	[DataContract]
	public class OrderTypes : Entity, ITopLevelEntity
	{

		/// <summary>
		/// 
		/// Display Name:
		/// DAC Field Name: Active 
		/// DAC: PX.Objects.AM.AMOrderType 
		/// </summary>
		/// <remarks>
		/// 
		/// </remarks>
		[DataMember(Name="Active", EmitDefaultValue=false)]
		public BooleanValue? Active { get; set; }

		/// <summary>
		/// 
		/// Display Name:
		/// DAC Field Name: PreassignLotSerial 
		/// DAC: PX.Objects.AM.AMOrderType 
		/// </summary>
		/// <remarks>
		/// 
		/// </remarks>
		[DataMember(Name="AllowPreassigningLotSerialNumbers", EmitDefaultValue=false)]
		public BooleanValue? AllowPreassigningLotSerialNumbers { get; set; }

		[DataMember(Name="Attributes", EmitDefaultValue=false)]
		public List<OrderTypeAttribute>? Attributes { get; set; }

		/// <summary>
		/// 
		/// Display Name:
		/// DAC Field Name: CheckSchdMatlAvailability 
		/// DAC: PX.Objects.AM.AMOrderType 
		/// </summary>
		/// <remarks>
		/// 
		/// </remarks>
		[DataMember(Name="CheckforMaterialAvailability", EmitDefaultValue=false)]
		public BooleanValue? CheckforMaterialAvailability { get; set; }

		/// <summary>
		/// 
		/// Display Name:
		/// DAC Field Name: DefaultCostMethod 
		/// DAC: PX.Objects.AM.AMOrderType 
		/// </summary>
		/// <remarks>
		/// 
		/// </remarks>
		[DataMember(Name="CostingMethod", EmitDefaultValue=false)]
		public StringValue? CostingMethod { get; set; }

		/// <summary>
		/// 
		/// Display Name:
		/// DAC Field Name: DefaultOperationMoveQty 
		/// DAC: PX.Objects.AM.AMOrderType 
		/// </summary>
		/// <remarks>
		/// 
		/// </remarks>
		[DataMember(Name="Defaultoperationmoveqty", EmitDefaultValue=false)]
		public BooleanValue? Defaultoperationmoveqty { get; set; }

		/// <summary>
		/// 
		/// Display Name:
		/// DAC Field Name: Descr 
		/// DAC: PX.Objects.AM.AMOrderType 
		/// </summary>
		/// <remarks>
		/// 
		/// </remarks>
		[DataMember(Name="Description", EmitDefaultValue=false)]
		public StringValue? Description { get; set; }

		/// <summary>
		/// 
		/// Display Name:
		/// DAC Field Name: ExceedQtyOperations 
		/// DAC: PX.Objects.AM.AMOrderType 
		/// </summary>
		/// <remarks>
		/// 
		/// </remarks>
		[DataMember(Name="ExceedingQtyforOperations", EmitDefaultValue=false)]
		public StringValue? ExceedingQtyforOperations { get; set; }

		/// <summary>
		/// 
		/// Display Name:
		/// DAC Field Name: ExcludeFromMRP 
		/// DAC: PX.Objects.AM.AMOrderType 
		/// </summary>
		/// <remarks>
		/// 
		/// </remarks>
		[DataMember(Name="ExcludefromMRP", EmitDefaultValue=false)]
		public BooleanValue? ExcludefromMRP { get; set; }

		/// <summary>
		/// 
		/// Display Name:
		/// DAC Field Name: Function 
		/// DAC: PX.Objects.AM.AMOrderType 
		/// </summary>
		/// <remarks>
		/// 
		/// </remarks>
		[DataMember(Name="Function", EmitDefaultValue=false)]
		public StringValue? Function { get; set; }

		/// <summary>
		/// 
		/// Display Name:
		/// DAC Field Name: IncludeUnreleasedOverIssueMaterial 
		/// DAC: PX.Objects.AM.AMOrderType 
		/// </summary>
		/// <remarks>
		/// 
		/// </remarks>
		[DataMember(Name="Includeunreleasedbatchqty", EmitDefaultValue=false)]
		public BooleanValue? Includeunreleasedbatchqty { get; set; }

		/// <summary>
		/// 
		/// Display Name:
		/// DAC Field Name: IssueMaterialOnTheFly 
		/// DAC: PX.Objects.AM.AMOrderType 
		/// </summary>
		/// <remarks>
		/// 
		/// </remarks>
		[DataMember(Name="IssueMaterialNotOnOrder", EmitDefaultValue=false)]
		public StringValue? IssueMaterialNotOnOrder { get; set; }

		/// <summary>
		/// 
		/// Display Name:
		/// DAC Field Name: CopyNotesItem 
		/// DAC: PX.Objects.AM.AMOrderType 
		/// </summary>
		/// <remarks>
		/// 
		/// </remarks>
		[DataMember(Name="ItemHeader", EmitDefaultValue=false)]
		public BooleanValue? ItemHeader { get; set; }

		/// <summary>
		/// 
		/// Display Name:
		/// DAC Field Name: CopyNotesMatl 
		/// DAC: PX.Objects.AM.AMOrderType 
		/// </summary>
		/// <remarks>
		/// 
		/// </remarks>
		[DataMember(Name="Material", EmitDefaultValue=false)]
		public BooleanValue? Material { get; set; }

		/// <summary>
		/// 
		/// Display Name:
		/// DAC Field Name: MoveCompletedOrders 
		/// DAC: PX.Objects.AM.AMOrderType 
		/// </summary>
		/// <remarks>
		/// 
		/// </remarks>
		[DataMember(Name="MoveonCompletedOperations", EmitDefaultValue=false)]
		public StringValue? MoveonCompletedOperations { get; set; }

		/// <summary>
		/// 
		/// Display Name:
		/// DAC Field Name: CopyNotesOper 
		/// DAC: PX.Objects.AM.AMOrderType 
		/// </summary>
		/// <remarks>
		/// 
		/// </remarks>
		[DataMember(Name="Operation", EmitDefaultValue=false)]
		public BooleanValue? Operation { get; set; }

		/// <summary>
		/// 
		/// Display Name:
		/// DAC Field Name: ProdNumberingID 
		/// DAC: PX.Objects.AM.AMOrderType 
		/// </summary>
		/// <remarks>
		/// 
		/// </remarks>
		[DataMember(Name="OrderNumberingSequence", EmitDefaultValue=false)]
		public StringValue? OrderNumberingSequence { get; set; }

		/// <summary>
		/// 
		/// Display Name:
		/// DAC Field Name: OrderType 
		/// DAC: PX.Objects.AM.AMOrderType 
		/// </summary>
		/// <remarks>
		/// 
		/// </remarks>
		[DataMember(Name="OrderType", EmitDefaultValue=false)]
		public StringValue? OrderType { get; set; }

		/// <summary>
		/// 
		/// Display Name:
		/// DAC Field Name: OverCompleteOrders 
		/// DAC: PX.Objects.AM.AMOrderType 
		/// </summary>
		/// <remarks>
		/// 
		/// </remarks>
		[DataMember(Name="OverCompleteOrders", EmitDefaultValue=false)]
		public StringValue? OverCompleteOrders { get; set; }

		/// <summary>
		/// 
		/// Display Name:
		/// DAC Field Name: CopyNotesOvhd 
		/// DAC: PX.Objects.AM.AMOrderType 
		/// </summary>
		/// <remarks>
		/// 
		/// </remarks>
		[DataMember(Name="Overhead", EmitDefaultValue=false)]
		public BooleanValue? Overhead { get; set; }

		/// <summary>
		/// 
		/// Display Name:
		/// DAC Field Name: OverIssueMaterial 
		/// DAC: PX.Objects.AM.AMOrderType 
		/// </summary>
		/// <remarks>
		/// 
		/// </remarks>
		[DataMember(Name="OverIssueMaterial", EmitDefaultValue=false)]
		public StringValue? OverIssueMaterial { get; set; }

		/// <summary>
		/// 
		/// Display Name:
		/// DAC Field Name: ProductionReportID 
		/// DAC: PX.Objects.AM.AMOrderType 
		/// </summary>
		/// <remarks>
		/// 
		/// </remarks>
		[DataMember(Name="PrintProductionReportID", EmitDefaultValue=false)]
		public StringValue? PrintProductionReportID { get; set; }

		/// <summary>
		/// 
		/// Display Name:
		/// DAC Field Name: ParentLotSerialRequired 
		/// DAC: PX.Objects.AM.AMOrderType 
		/// </summary>
		/// <remarks>
		/// 
		/// </remarks>
		[DataMember(Name="RequireParentLotSerialNumber", EmitDefaultValue=false)]
		public StringValue? RequireParentLotSerialNumber { get; set; }

		/// <summary>
		/// 
		/// Display Name:
		/// DAC Field Name: ScrapLocationID 
		/// DAC: PX.Objects.AM.AMOrderType 
		/// </summary>
		/// <remarks>
		/// 
		/// </remarks>
		[DataMember(Name="ScrapLocation", EmitDefaultValue=false)]
		public StringValue? ScrapLocation { get; set; }

		/// <summary>
		/// 
		/// Display Name:
		/// DAC Field Name: ScrapSource 
		/// DAC: PX.Objects.AM.AMOrderType 
		/// </summary>
		/// <remarks>
		/// 
		/// </remarks>
		[DataMember(Name="ScrapSource", EmitDefaultValue=false)]
		public StringValue? ScrapSource { get; set; }

		/// <summary>
		/// 
		/// Display Name:
		/// DAC Field Name: ScrapSiteID 
		/// DAC: PX.Objects.AM.AMOrderType 
		/// </summary>
		/// <remarks>
		/// 
		/// </remarks>
		[DataMember(Name="ScrapWarehouse", EmitDefaultValue=false)]
		public StringValue? ScrapWarehouse { get; set; }

		/// <summary>
		/// 
		/// Display Name:
		/// DAC Field Name: CopyNotesStep 
		/// DAC: PX.Objects.AM.AMOrderType 
		/// </summary>
		/// <remarks>
		/// 
		/// </remarks>
		[DataMember(Name="Step", EmitDefaultValue=false)]
		public BooleanValue? Step { get; set; }

		/// <summary>
		/// 
		/// Display Name:
		/// DAC Field Name: SubstituteWorkCenters 
		/// DAC: PX.Objects.AM.AMOrderType 
		/// </summary>
		/// <remarks>
		/// 
		/// </remarks>
		[DataMember(Name="SubstituteWorkCenters", EmitDefaultValue=false)]
		public BooleanValue? SubstituteWorkCenters { get; set; }

		/// <summary>
		/// 
		/// Display Name:
		/// DAC Field Name: CopyNotesTool 
		/// DAC: PX.Objects.AM.AMOrderType 
		/// </summary>
		/// <remarks>
		/// 
		/// </remarks>
		[DataMember(Name="Tool", EmitDefaultValue=false)]
		public BooleanValue? Tool { get; set; }

		/// <summary>
		/// 
		/// Display Name:
		/// DAC Field Name: BackflushUnderIssueMaterial 
		/// DAC: PX.Objects.AM.AMOrderType 
		/// </summary>
		/// <remarks>
		/// 
		/// </remarks>
		[DataMember(Name="UnderIssueBackflushMaterial", EmitDefaultValue=false)]
		public StringValue? UnderIssueBackflushMaterial { get; set; }

		/// <summary>
		/// 
		/// Display Name:
		/// DAC Field Name: UnderIssueMaterial 
		/// DAC: PX.Objects.AM.AMOrderType 
		/// </summary>
		/// <remarks>
		/// 
		/// </remarks>
		[DataMember(Name="UnderIssueMaterial", EmitDefaultValue=false)]
		public StringValue? UnderIssueMaterial { get; set; }

		/// <summary>
		/// 
		/// Display Name:
		/// DAC Field Name: WIPVarianceAcctID 
		/// DAC: PX.Objects.AM.AMOrderType 
		/// </summary>
		/// <remarks>
		/// 
		/// </remarks>
		[DataMember(Name="WIPVarianceAccount", EmitDefaultValue=false)]
		public StringValue? WIPVarianceAccount { get; set; }

		/// <summary>
		/// 
		/// Display Name:
		/// DAC Field Name: WIPVarianceSubID 
		/// DAC: PX.Objects.AM.AMOrderType 
		/// </summary>
		/// <remarks>
		/// 
		/// </remarks>
		[DataMember(Name="WIPVarianceSubaccount", EmitDefaultValue=false)]
		public StringValue? WIPVarianceSubaccount { get; set; }

		/// <summary>
		/// 
		/// Display Name:
		/// DAC Field Name: WIPAcctID 
		/// DAC: PX.Objects.AM.AMOrderType 
		/// </summary>
		/// <remarks>
		/// 
		/// </remarks>
		[DataMember(Name="WorkinProcessAccount", EmitDefaultValue=false)]
		public StringValue? WorkinProcessAccount { get; set; }

		/// <summary>
		/// 
		/// Display Name:
		/// DAC Field Name: WIPSubID 
		/// DAC: PX.Objects.AM.AMOrderType 
		/// </summary>
		/// <remarks>
		/// 
		/// </remarks>
		[DataMember(Name="WorkInProcessSubaccount", EmitDefaultValue=false)]
		public StringValue? WorkInProcessSubaccount { get; set; }

		public virtual string GetEndpointPath()
		{
			return "entity/MANUFACTURING/23.200.001";
		}
	}
}