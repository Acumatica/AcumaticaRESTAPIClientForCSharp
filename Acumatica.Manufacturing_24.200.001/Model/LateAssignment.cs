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
	public class LateAssignment : Entity, ITopLevelEntity
	{

		[DataMember(Name="AllocatedDetail", EmitDefaultValue=false)]
		public List<LateAssignmentAllocatedDetail>? AllocatedDetail { get; set; }

		[DataMember(Name="CompleteQty", EmitDefaultValue=false)]
		public DecimalValue? CompleteQty { get; set; }

		[DataMember(Name="InventoryID", EmitDefaultValue=false)]
		public StringValue? InventoryID { get; set; }

		[DataMember(Name="LotSerialNbr", EmitDefaultValue=false)]
		public StringValue? LotSerialNbr { get; set; }

		[DataMember(Name="OrderType", EmitDefaultValue=false)]
		public StringValue? OrderType { get; set; }

		[DataMember(Name="ProductionNbr", EmitDefaultValue=false)]
		public StringValue? ProductionNbr { get; set; }

		[DataMember(Name="QtytoProduce", EmitDefaultValue=false)]
		public DecimalValue? QtytoProduce { get; set; }

		[DataMember(Name="RemainingQty", EmitDefaultValue=false)]
		public DecimalValue? RemainingQty { get; set; }

		[DataMember(Name="ScrappedQty", EmitDefaultValue=false)]
		public DecimalValue? ScrappedQty { get; set; }

		[DataMember(Name="Status", EmitDefaultValue=false)]
		public StringValue? Status { get; set; }

		[DataMember(Name="UnallocatedDetail", EmitDefaultValue=false)]
		public List<LateAssignmentUnallocatedDetail>? UnallocatedDetail { get; set; }

		[DataMember(Name="Warehouse", EmitDefaultValue=false)]
		public StringValue? Warehouse { get; set; }

		public virtual string GetEndpointPath()
		{
			return "entity/MANUFACTURING/24.200.001";
		}
	}
}