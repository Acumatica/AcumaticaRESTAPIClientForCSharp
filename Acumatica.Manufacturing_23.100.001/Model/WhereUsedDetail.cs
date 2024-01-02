using System.Collections.Generic;
using System.Runtime.Serialization;

using Newtonsoft.Json;

using Acumatica.RESTClient.Client;
using Acumatica.RESTClient.ContractBasedApi;
using Acumatica.RESTClient.ContractBasedApi.Model;

namespace Acumatica.Manufacturing_23_100_001.Model
{
	[DataContract]
	public class WhereUsedDetail : Entity
	{

		[DataMember(Name="Active", EmitDefaultValue=false)]
		public BooleanValue? Active { get; set; }

		[DataMember(Name="BackflushLabor", EmitDefaultValue=false)]
		public BooleanValue? BackflushLabor { get; set; }

		[DataMember(Name="BOMID", EmitDefaultValue=false)]
		public StringValue? BOMID { get; set; }

		[DataMember(Name="BOMIDAMBomItem__BOMID", EmitDefaultValue=false)]
		public StringValue? BOMIDAMBomItem__BOMID { get; set; }

		[DataMember(Name="BomRevision", EmitDefaultValue=false)]
		public StringValue? BomRevision { get; set; }

		[DataMember(Name="BomWarehouse", EmitDefaultValue=false)]
		public StringValue? BomWarehouse { get; set; }

		[DataMember(Name="EndDate", EmitDefaultValue=false)]
		public DateTimeValue? EndDate { get; set; }

		[DataMember(Name="InventoryID", EmitDefaultValue=false)]
		public StringValue? InventoryID { get; set; }

		[DataMember(Name="OperationDescription", EmitDefaultValue=false)]
		public StringValue? OperationDescription { get; set; }

		[DataMember(Name="OperationIDOperationID", EmitDefaultValue=false)]
		public IntValue? OperationIDOperationID { get; set; }

		[DataMember(Name="OperationNbr", EmitDefaultValue=false)]
		public StringValue? OperationNbr { get; set; }

		[DataMember(Name="OperationScrapAction", EmitDefaultValue=false)]
		public StringValue? OperationScrapAction { get; set; }

		[DataMember(Name="OutsideProcess", EmitDefaultValue=false)]
		public BooleanValue? OutsideProcess { get; set; }

		[DataMember(Name="RevisionRevisionID", EmitDefaultValue=false)]
		public StringValue? RevisionRevisionID { get; set; }

		[DataMember(Name="StartDate", EmitDefaultValue=false)]
		public DateTimeValue? StartDate { get; set; }

		[DataMember(Name="Status", EmitDefaultValue=false)]
		public StringValue? Status { get; set; }

	}
}