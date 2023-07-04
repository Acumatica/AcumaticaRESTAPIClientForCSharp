using System.Collections.Generic;
using System.Runtime.Serialization;

using Newtonsoft.Json;

using Acumatica.RESTClient.Client;
using Acumatica.RESTClient.ContractBasedApi;
using Acumatica.RESTClient.ContractBasedApi.Model;

namespace Acumatica.Manufacturing_23_100_001.Model
{
	[DataContract]
	public class OrderTypes : Entity, ITopLevelEntity
	{

		[DataMember(Name="Active", EmitDefaultValue=false)]
		public BooleanValue Active { get; set; }

		[DataMember(Name="AllowPreassigningLotSerialNumbers", EmitDefaultValue=false)]
		public BooleanValue AllowPreassigningLotSerialNumbers { get; set; }

		[DataMember(Name="Attributes", EmitDefaultValue=false)]
		public List<OrderTypeAttribute> Attributes { get; set; }

		[DataMember(Name="CheckforMaterialAvailability", EmitDefaultValue=false)]
		public BooleanValue CheckforMaterialAvailability { get; set; }

		[DataMember(Name="CostingMethod", EmitDefaultValue=false)]
		public StringValue CostingMethod { get; set; }

		[DataMember(Name="Defaultoperationmoveqty", EmitDefaultValue=false)]
		public BooleanValue Defaultoperationmoveqty { get; set; }

		[DataMember(Name="Description", EmitDefaultValue=false)]
		public StringValue Description { get; set; }

		[DataMember(Name="ExceedingQtyforOperations", EmitDefaultValue=false)]
		public StringValue ExceedingQtyforOperations { get; set; }

		[DataMember(Name="ExcludefromMRP", EmitDefaultValue=false)]
		public BooleanValue ExcludefromMRP { get; set; }

		[DataMember(Name="Function", EmitDefaultValue=false)]
		public StringValue Function { get; set; }

		[DataMember(Name="Includeunreleasedbatchqty", EmitDefaultValue=false)]
		public BooleanValue Includeunreleasedbatchqty { get; set; }

		[DataMember(Name="IssueMaterialNotOnOrder", EmitDefaultValue=false)]
		public StringValue IssueMaterialNotOnOrder { get; set; }

		[DataMember(Name="ItemHeader", EmitDefaultValue=false)]
		public BooleanValue ItemHeader { get; set; }

		[DataMember(Name="Material", EmitDefaultValue=false)]
		public BooleanValue Material { get; set; }

		[DataMember(Name="MoveonCompletedOperations", EmitDefaultValue=false)]
		public StringValue MoveonCompletedOperations { get; set; }

		[DataMember(Name="Operation", EmitDefaultValue=false)]
		public BooleanValue Operation { get; set; }

		[DataMember(Name="OrderNumberingSequence", EmitDefaultValue=false)]
		public StringValue OrderNumberingSequence { get; set; }

		[DataMember(Name="OrderType", EmitDefaultValue=false)]
		public StringValue OrderType { get; set; }

		[DataMember(Name="OverCompleteOrders", EmitDefaultValue=false)]
		public StringValue OverCompleteOrders { get; set; }

		[DataMember(Name="Overhead", EmitDefaultValue=false)]
		public BooleanValue Overhead { get; set; }

		[DataMember(Name="OverIssueMaterial", EmitDefaultValue=false)]
		public StringValue OverIssueMaterial { get; set; }

		[DataMember(Name="PrintProductionReportID", EmitDefaultValue=false)]
		public StringValue PrintProductionReportID { get; set; }

		[DataMember(Name="RequireParentLotSerialNumber", EmitDefaultValue=false)]
		public StringValue RequireParentLotSerialNumber { get; set; }

		[DataMember(Name="ScrapLocation", EmitDefaultValue=false)]
		public StringValue ScrapLocation { get; set; }

		[DataMember(Name="ScrapSource", EmitDefaultValue=false)]
		public StringValue ScrapSource { get; set; }

		[DataMember(Name="ScrapWarehouse", EmitDefaultValue=false)]
		public StringValue ScrapWarehouse { get; set; }

		[DataMember(Name="Step", EmitDefaultValue=false)]
		public BooleanValue Step { get; set; }

		[DataMember(Name="SubstituteWorkCenters", EmitDefaultValue=false)]
		public BooleanValue SubstituteWorkCenters { get; set; }

		[DataMember(Name="Tool", EmitDefaultValue=false)]
		public BooleanValue Tool { get; set; }

		[DataMember(Name="UnderIssueBackflushMaterial", EmitDefaultValue=false)]
		public StringValue UnderIssueBackflushMaterial { get; set; }

		[DataMember(Name="UnderIssueMaterial", EmitDefaultValue=false)]
		public StringValue UnderIssueMaterial { get; set; }

		[DataMember(Name="WIPVarianceAccount", EmitDefaultValue=false)]
		public StringValue WIPVarianceAccount { get; set; }

		[DataMember(Name="WIPVarianceSubaccount", EmitDefaultValue=false)]
		public StringValue WIPVarianceSubaccount { get; set; }

		[DataMember(Name="WorkinProcessAccount", EmitDefaultValue=false)]
		public StringValue WorkinProcessAccount { get; set; }

		[DataMember(Name="WorkInProcessSubaccount", EmitDefaultValue=false)]
		public StringValue WorkInProcessSubaccount { get; set; }

		public string GetEndpointPath()
		{
			return "entity/MANUFACTURING/23.100.001";
		}
	}
}