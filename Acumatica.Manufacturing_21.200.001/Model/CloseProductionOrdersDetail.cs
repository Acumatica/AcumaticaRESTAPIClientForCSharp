using System.Collections.Generic;
using System.Runtime.Serialization;

using Newtonsoft.Json;

using Acumatica.RESTClient.Client;
using Acumatica.RESTClient.ContractBasedApi;
using Acumatica.RESTClient.ContractBasedApi.Model;

namespace Acumatica.Manufacturing_21_200_001.Model
{
	[DataContract]
	public class CloseProductionOrdersDetail : Entity
	{

		[DataMember(Name="CostCode", EmitDefaultValue=false)]
		public StringValue? CostCode { get; set; }

		[DataMember(Name="InventoryID", EmitDefaultValue=false)]
		public StringValue? InventoryID { get; set; }

		[DataMember(Name="OrderType", EmitDefaultValue=false)]
		public StringValue? OrderType { get; set; }

		[DataMember(Name="ProductionNbr", EmitDefaultValue=false)]
		public StringValue? ProductionNbr { get; set; }

		[DataMember(Name="Project", EmitDefaultValue=false)]
		public StringValue? Project { get; set; }

		[DataMember(Name="ProjectTask", EmitDefaultValue=false)]
		public StringValue? ProjectTask { get; set; }

		[DataMember(Name="QtyComplete", EmitDefaultValue=false)]
		public DecimalValue? QtyComplete { get; set; }

		[DataMember(Name="QtytoProduce", EmitDefaultValue=false)]
		public DecimalValue? QtytoProduce { get; set; }

		[DataMember(Name="Selected", EmitDefaultValue=false)]
		public BooleanValue? Selected { get; set; }

		[DataMember(Name="Subitem", EmitDefaultValue=false)]
		public StringValue? Subitem { get; set; }

		[DataMember(Name="Warehouse", EmitDefaultValue=false)]
		public StringValue? Warehouse { get; set; }

		[DataMember(Name="WIPBalance", EmitDefaultValue=false)]
		public DecimalValue? WIPBalance { get; set; }

		[DataMember(Name="WIPVarianceAccount", EmitDefaultValue=false)]
		public StringValue? WIPVarianceAccount { get; set; }

		[DataMember(Name="WIPVarianceSubaccount", EmitDefaultValue=false)]
		public StringValue? WIPVarianceSubaccount { get; set; }

	}
}