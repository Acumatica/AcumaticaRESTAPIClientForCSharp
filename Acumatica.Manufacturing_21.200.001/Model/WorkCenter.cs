using System;
using System.Collections.Generic;
using System.Runtime.Serialization;

using Newtonsoft.Json;

using Acumatica.RESTClient.Client;
using Acumatica.RESTClient.ContractBasedApi;
using Acumatica.RESTClient.ContractBasedApi.Model;

namespace Acumatica.Manufacturing_21_200_001.Model
{
	[DataContract]
	public class WorkCenter : Entity, ITopLevelEntity
	{

		[DataMember(Name="Active", EmitDefaultValue=false)]
		public BooleanValue? Active { get; set; }

		[DataMember(Name="BackflushLabor", EmitDefaultValue=false)]
		public BooleanValue? BackflushLabor { get; set; }

		[DataMember(Name="BackflushMaterials", EmitDefaultValue=false)]
		public BooleanValue? BackflushMaterials { get; set; }

		[DataMember(Name="BasisforCapacity", EmitDefaultValue=false)]
		public StringValue? BasisforCapacity { get; set; }

		[DataMember(Name="Description", EmitDefaultValue=false)]
		public StringValue? Description { get; set; }

		[DataMember(Name="Location", EmitDefaultValue=false)]
		public StringValue? Location { get; set; }

		[DataMember(Name="Machines", EmitDefaultValue=false)]
		public List<MachineDetail>? Machines { get; set; }

		[DataMember(Name="OutsideProcessing", EmitDefaultValue=false)]
		public BooleanValue? OutsideProcessing { get; set; }

		[DataMember(Name="Overheads", EmitDefaultValue=false)]
		public List<WorkCenterOverheadDetail>? Overheads { get; set; }

		[DataMember(Name="ScrapActionDefault", EmitDefaultValue=false)]
		public StringValue? ScrapActionDefault { get; set; }

		[DataMember(Name="Shifts", EmitDefaultValue=false)]
		public List<ShiftDetail>? Shifts { get; set; }

		[DataMember(Name="StandardCost", EmitDefaultValue=false)]
		public DecimalValue? StandardCost { get; set; }

		[DataMember(Name="SubstituteWorkCenters", EmitDefaultValue=false)]
		public List<WorkCenterSubstitute>? SubstituteWorkCenters { get; set; }

		[DataMember(Name="Warehouse", EmitDefaultValue=false)]
		public StringValue? Warehouse { get; set; }

		[DataMember(Name="WhereUsed", EmitDefaultValue=false)]
		public List<WhereUsedDetail>? WhereUsed { get; set; }

		[DataMember(Name="WorkCenterID", EmitDefaultValue=false)]
		public StringValue? WorkCenterID { get; set; }

		public virtual string GetEndpointPath()
		{
			return "entity/MANUFACTURING/21.200.001";
		}
	}
}