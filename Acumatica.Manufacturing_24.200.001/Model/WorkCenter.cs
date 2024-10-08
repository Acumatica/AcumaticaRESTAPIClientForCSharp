using System;
using System.Collections.Generic;
using System.Runtime.Serialization;

using Newtonsoft.Json;

using Acumatica.RESTClient.Client;
using Acumatica.RESTClient.ContractBasedApi;
using Acumatica.RESTClient.ContractBasedApi.Model;

namespace Acumatica.Manufacturing_24_200_001.Model
{
	/// <summary>
	/// Corresponds to the screen AM207000 in the Acumatica ERP
	/// </summary>
	[DataContract]
	public class WorkCenter : Entity, ITopLevelEntity
	{

		/// <summary>
		/// DAC Field Name: ActiveFlg 
		/// DAC: PX.Objects.AM.AMWC 
		/// </summary>
		[DataMember(Name="Active", EmitDefaultValue=false)]
		public BooleanValue? Active { get; set; }

		/// <summary>
		/// DAC Field Name: AllowMultiClockEntry 
		/// DAC: PX.Objects.AM.AMWC 
		/// Display Name: Allow Clock Entry for Multiple Production Orders 
		/// </summary>
		[DataMember(Name="AllowClockEntryforMultipleProductionOrders", EmitDefaultValue=false)]
		public BooleanValue? AllowClockEntryforMultipleProductionOrders { get; set; }

		/// <summary>
		/// DAC Field Name: BflushLbr 
		/// DAC: PX.Objects.AM.AMWC 
		/// Display Name: Backflush Labor 
		/// </summary>
		[DataMember(Name="BackflushLabor", EmitDefaultValue=false)]
		public BooleanValue? BackflushLabor { get; set; }

		/// <summary>
		/// DAC Field Name: BflushMatl 
		/// DAC: PX.Objects.AM.AMWC 
		/// Display Name: Backflush Materials 
		/// </summary>
		[DataMember(Name="BackflushMaterials", EmitDefaultValue=false)]
		public BooleanValue? BackflushMaterials { get; set; }

		/// <summary>
		/// DAC Field Name: WcBasis 
		/// DAC: PX.Objects.AM.AMWC 
		/// Display Name: Basis for Capacity 
		/// SQL Type: char(1) 
		/// </summary>
		[DataMember(Name="BasisforCapacity", EmitDefaultValue=false)]
		public StringValue? BasisforCapacity { get; set; }

		/// <summary>
		/// DAC: PX.Objects.AM.AMWC 
		/// Display Name: Control Point 
		/// </summary>
		[DataMember(Name="ControlPoint", EmitDefaultValue=false)]
		public BooleanValue? ControlPoint { get; set; }

		/// <summary>
		/// DAC: PX.Objects.AM.AMWC 
		/// Display Name: Default Finish Time 
		/// </summary>
		[DataMember(Name="DefaultFinishTime", EmitDefaultValue=false)]
		public StringValue? DefaultFinishTime { get; set; }

		/// <summary>
		/// DAC: PX.Objects.AM.AMWC 
		/// Display Name: Default Move Time 
		/// </summary>
		[DataMember(Name="DefaultMoveTime", EmitDefaultValue=false)]
		public StringValue? DefaultMoveTime { get; set; }

		/// <summary>
		/// DAC: PX.Objects.AM.AMWC 
		/// Display Name: Default Queue Time 
		/// </summary>
		[DataMember(Name="DefaultQueueTime", EmitDefaultValue=false)]
		public StringValue? DefaultQueueTime { get; set; }

		/// <summary>
		/// DAC Field Name: Descr 
		/// DAC: PX.Objects.AM.AMWC 
		/// SQL Type: nvarchar(256) 
		/// </summary>
		[DataMember(Name="Description", EmitDefaultValue=false)]
		public StringValue? Description { get; set; }

		/// <summary>
		/// DAC Field Name: LocationID 
		/// DAC: PX.Objects.AM.AMWC 
		/// </summary>
		[DataMember(Name="Location", EmitDefaultValue=false)]
		public StringValue? Location { get; set; }

		[DataMember(Name="Machines", EmitDefaultValue=false)]
		public List<MachineDetail>? Machines { get; set; }

		/// <summary>
		/// DAC Field Name: OutsideFlg 
		/// DAC: PX.Objects.AM.AMWC 
		/// Display Name: Outside Process 
		/// </summary>
		[DataMember(Name="OutsideProcessing", EmitDefaultValue=false)]
		public BooleanValue? OutsideProcessing { get; set; }

		[DataMember(Name="Overheads", EmitDefaultValue=false)]
		public List<WorkCenterOverheadDetail>? Overheads { get; set; }

		/// <summary>
		/// DAC Field Name: ScrapAction 
		/// DAC: PX.Objects.AM.AMWC 
		/// Display Name: Scrap Action Default 
		/// </summary>
		[DataMember(Name="ScrapActionDefault", EmitDefaultValue=false)]
		public StringValue? ScrapActionDefault { get; set; }

		[DataMember(Name="Shifts", EmitDefaultValue=false)]
		public List<ShiftDetail>? Shifts { get; set; }

		/// <summary>
		/// DAC Field Name: StdCost 
		/// DAC: PX.Objects.AM.AMWCMach 
		/// Display Name: Standard Cost 
		/// </summary>
		[DataMember(Name="StandardCost", EmitDefaultValue=false)]
		public DecimalValue? StandardCost { get; set; }

		[DataMember(Name="SubstituteWorkCenters", EmitDefaultValue=false)]
		public List<WorkCenterSubstitute>? SubstituteWorkCenters { get; set; }

		/// <summary>
		/// DAC Field Name: SiteID 
		/// DAC: PX.Objects.AM.AMWC 
		/// </summary>
		[DataMember(Name="Warehouse", EmitDefaultValue=false)]
		public StringValue? Warehouse { get; set; }

		[DataMember(Name="WhereUsed", EmitDefaultValue=false)]
		public List<WhereUsedDetail>? WhereUsed { get; set; }

		/// <summary>
		/// DAC Field Name: WcID 
		/// DAC: PX.Objects.AM.AMWC 
		/// Display Name: Work Center 
		/// SQL Type: nvarchar(20) 
		/// Key Field
		/// </summary>
		[DataMember(Name="WorkCenterID", EmitDefaultValue=false)]
		public StringValue? WorkCenterID { get; set; }

		public virtual string GetEndpointPath()
		{
			return "entity/MANUFACTURING/24.200.001";
		}
	}
}