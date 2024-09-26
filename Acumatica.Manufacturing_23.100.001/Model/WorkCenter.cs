using System;
using System.Collections.Generic;
using System.Runtime.Serialization;

using Newtonsoft.Json;

using Acumatica.RESTClient.Client;
using Acumatica.RESTClient.ContractBasedApi;
using Acumatica.RESTClient.ContractBasedApi.Model;

namespace Acumatica.Manufacturing_23_100_001.Model
{
	/// <summary>
	/// Corresponds to the screen AM207000 in the Acumatica ERP
	/// </summary>
	[DataContract]
	public class WorkCenter : Entity, ITopLevelEntity
	{

		/// <summary>
		/// 
		/// Display Name:
		/// DAC Field Name: ActiveFlg 
		/// DAC: PX.Objects.AM.AMWC 
		/// </summary>
		/// <remarks>
		/// 
		/// </remarks>
		[DataMember(Name="Active", EmitDefaultValue=false)]
		public BooleanValue? Active { get; set; }

		/// <summary>
		/// 
		/// Display Name:
		/// DAC Field Name: BflushLbr 
		/// DAC: PX.Objects.AM.AMWC 
		/// </summary>
		/// <remarks>
		/// 
		/// </remarks>
		[DataMember(Name="BackflushLabor", EmitDefaultValue=false)]
		public BooleanValue? BackflushLabor { get; set; }

		/// <summary>
		/// 
		/// Display Name:
		/// DAC Field Name: BflushMatl 
		/// DAC: PX.Objects.AM.AMWC 
		/// </summary>
		/// <remarks>
		/// 
		/// </remarks>
		[DataMember(Name="BackflushMaterials", EmitDefaultValue=false)]
		public BooleanValue? BackflushMaterials { get; set; }

		/// <summary>
		/// 
		/// Display Name:
		/// DAC Field Name: WcBasis 
		/// DAC: PX.Objects.AM.AMWC 
		/// </summary>
		/// <remarks>
		/// 
		/// </remarks>
		[DataMember(Name="BasisforCapacity", EmitDefaultValue=false)]
		public StringValue? BasisforCapacity { get; set; }

		/// <summary>
		/// 
		/// Display Name:
		/// DAC Field Name: ControlPoint 
		/// DAC: PX.Objects.AM.AMWC 
		/// </summary>
		/// <remarks>
		/// 
		/// </remarks>
		[DataMember(Name="ControlPoint", EmitDefaultValue=false)]
		public BooleanValue? ControlPoint { get; set; }

		/// <summary>
		/// 
		/// Display Name:
		/// DAC Field Name: DefaultFinishTime 
		/// DAC: PX.Objects.AM.AMWC 
		/// </summary>
		/// <remarks>
		/// 
		/// </remarks>
		[DataMember(Name="DefaultFinishTime", EmitDefaultValue=false)]
		public StringValue? DefaultFinishTime { get; set; }

		/// <summary>
		/// 
		/// Display Name:
		/// DAC Field Name: DefaultMoveTime 
		/// DAC: PX.Objects.AM.AMWC 
		/// </summary>
		/// <remarks>
		/// 
		/// </remarks>
		[DataMember(Name="DefaultMoveTime", EmitDefaultValue=false)]
		public StringValue? DefaultMoveTime { get; set; }

		/// <summary>
		/// 
		/// Display Name:
		/// DAC Field Name: DefaultQueueTime 
		/// DAC: PX.Objects.AM.AMWC 
		/// </summary>
		/// <remarks>
		/// 
		/// </remarks>
		[DataMember(Name="DefaultQueueTime", EmitDefaultValue=false)]
		public StringValue? DefaultQueueTime { get; set; }

		/// <summary>
		/// 
		/// Display Name:
		/// DAC Field Name: Descr 
		/// DAC: PX.Objects.AM.AMWC 
		/// </summary>
		/// <remarks>
		/// 
		/// </remarks>
		[DataMember(Name="Description", EmitDefaultValue=false)]
		public StringValue? Description { get; set; }

		/// <summary>
		/// 
		/// Display Name:
		/// DAC Field Name: LocationID 
		/// DAC: PX.Objects.AM.AMWC 
		/// </summary>
		/// <remarks>
		/// 
		/// </remarks>
		[DataMember(Name="Location", EmitDefaultValue=false)]
		public StringValue? Location { get; set; }

		[DataMember(Name="Machines", EmitDefaultValue=false)]
		public List<MachineDetail>? Machines { get; set; }

		/// <summary>
		/// 
		/// Display Name:
		/// DAC Field Name: OutsideFlg 
		/// DAC: PX.Objects.AM.AMWC 
		/// </summary>
		/// <remarks>
		/// 
		/// </remarks>
		[DataMember(Name="OutsideProcessing", EmitDefaultValue=false)]
		public BooleanValue? OutsideProcessing { get; set; }

		[DataMember(Name="Overheads", EmitDefaultValue=false)]
		public List<WorkCenterOverheadDetail>? Overheads { get; set; }

		/// <summary>
		/// 
		/// Display Name:
		/// DAC Field Name: ScrapAction 
		/// DAC: PX.Objects.AM.AMWC 
		/// </summary>
		/// <remarks>
		/// 
		/// </remarks>
		[DataMember(Name="ScrapActionDefault", EmitDefaultValue=false)]
		public StringValue? ScrapActionDefault { get; set; }

		[DataMember(Name="Shifts", EmitDefaultValue=false)]
		public List<ShiftDetail>? Shifts { get; set; }

		/// <summary>
		/// 
		/// Display Name:
		/// DAC Field Name: StdCost 
		/// DAC: PX.Objects.AM.AMWCMach 
		/// </summary>
		/// <remarks>
		/// 
		/// </remarks>
		[DataMember(Name="StandardCost", EmitDefaultValue=false)]
		public DecimalValue? StandardCost { get; set; }

		[DataMember(Name="SubstituteWorkCenters", EmitDefaultValue=false)]
		public List<WorkCenterSubstitute>? SubstituteWorkCenters { get; set; }

		/// <summary>
		/// 
		/// Display Name:
		/// DAC Field Name: SiteID 
		/// DAC: PX.Objects.AM.AMWC 
		/// </summary>
		/// <remarks>
		/// 
		/// </remarks>
		[DataMember(Name="Warehouse", EmitDefaultValue=false)]
		public StringValue? Warehouse { get; set; }

		[DataMember(Name="WhereUsed", EmitDefaultValue=false)]
		public List<WhereUsedDetail>? WhereUsed { get; set; }

		/// <summary>
		/// 
		/// Display Name:
		/// DAC Field Name: WcID 
		/// DAC: PX.Objects.AM.AMWC 
		/// </summary>
		/// <remarks>
		/// 
		/// </remarks>
		[DataMember(Name="WorkCenterID", EmitDefaultValue=false)]
		public StringValue? WorkCenterID { get; set; }

		/// <summary>
		/// 
		/// Display Name:
		/// DAC Field Name: AllowMultiClockEntry 
		/// DAC: PX.Objects.AM.AMWC 
		/// </summary>
		/// <remarks>
		/// 
		/// </remarks>
		[DataMember(Name="AllowClockEntryforMultipleProductionOrders", EmitDefaultValue=false)]
		public BooleanValue? AllowClockEntryforMultipleProductionOrders { get; set; }

		public virtual string GetEndpointPath()
		{
			return "entity/MANUFACTURING/23.100.001";
		}
	}
}