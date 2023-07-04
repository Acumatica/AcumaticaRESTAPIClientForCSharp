using System.Collections.Generic;
using System.Runtime.Serialization;

using Newtonsoft.Json;

using Acumatica.RESTClient.Client;
using Acumatica.RESTClient.ContractBasedApi;
using Acumatica.RESTClient.ContractBasedApi.Model;

namespace Acumatica.Manufacturing_21_200_001.Model
{
	[DataContract]
	public class MRPRequirementsByItem : Entity, ITopLevelEntity
	{

		[DataMember(Name="BucketID", EmitDefaultValue=false)]
		public StringValue BucketID { get; set; }

		[DataMember(Name="Detail", EmitDefaultValue=false)]
		public List<MRPRequirementsByItemDetail> Detail { get; set; }

		[DataMember(Name="InventoryID", EmitDefaultValue=false)]
		public StringValue InventoryID { get; set; }

		[DataMember(Name="LeadTime", EmitDefaultValue=false)]
		public IntValue LeadTime { get; set; }

		[DataMember(Name="PreferredVendorID", EmitDefaultValue=false)]
		public StringValue PreferredVendorID { get; set; }

		[DataMember(Name="ProductMgr", EmitDefaultValue=false)]
		public IntValue ProductMgr { get; set; }

		[DataMember(Name="ProductMgrContact", EmitDefaultValue=false)]
		public StringValue ProductMgrContact { get; set; }

		[DataMember(Name="QtyonHand", EmitDefaultValue=false)]
		public DecimalValue QtyonHand { get; set; }

		[DataMember(Name="RepSource", EmitDefaultValue=false)]
		public StringValue RepSource { get; set; }

		[DataMember(Name="SafetyStock", EmitDefaultValue=false)]
		public DecimalValue SafetyStock { get; set; }

		[DataMember(Name="Subitem", EmitDefaultValue=false)]
		public StringValue Subitem { get; set; }

		[DataMember(Name="Warehouse", EmitDefaultValue=false)]
		public StringValue Warehouse { get; set; }

		public string GetEndpointPath()
		{
			return "entity/MANUFACTURING/21.200.001";
		}
	}
}