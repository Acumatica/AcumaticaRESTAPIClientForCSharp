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
	/// Corresponds to the screen <c>AM207000</c> in the Acumatica ERP
	/// <para>Key Fields: WorkCenterID</para>
	/// </summary>
	[DataContract]
	public class WorkCenter : Entity, ITopLevelEntity
	{

		/// <summary>
		/// <para>DAC Field Name: ActiveFlg</para>
		/// <para>DAC: PX.Objects.AM.AMWC</para>
		/// </summary>
		[DataMember(Name="Active", EmitDefaultValue=false)]
		public BooleanValue? Active { get; set; }

		/// <summary>
		/// <para>DAC Field Name: AllowMultiClockEntry</para>
		/// <para>DAC: PX.Objects.AM.AMWC</para>
		/// <para>Display Name: Allow Clock Entry for Multiple Production Orders</para>
		/// </summary>
		[DataMember(Name="AllowClockEntryforMultipleProductionOrders", EmitDefaultValue=false)]
		public BooleanValue? AllowClockEntryforMultipleProductionOrders { get; set; }

		/// <summary>
		/// <para>DAC Field Name: BflushLbr</para>
		/// <para>DAC: PX.Objects.AM.AMWC</para>
		/// <para>Display Name: Backflush Labor</para>
		/// </summary>
		[DataMember(Name="BackflushLabor", EmitDefaultValue=false)]
		public BooleanValue? BackflushLabor { get; set; }

		/// <summary>
		/// <para>DAC Field Name: BflushMatl</para>
		/// <para>DAC: PX.Objects.AM.AMWC</para>
		/// <para>Display Name: Backflush Materials</para>
		/// </summary>
		[DataMember(Name="BackflushMaterials", EmitDefaultValue=false)]
		public BooleanValue? BackflushMaterials { get; set; }

		/// <summary>
		/// <para>DAC Field Name: WcBasis</para>
		/// <para>DAC: PX.Objects.AM.AMWC</para>
		/// <para>Display Name: Basis for Capacity</para>
		/// <para>SQL Type: char(1)</para>
		/// </summary>
		[DataMember(Name="BasisforCapacity", EmitDefaultValue=false)]
		public StringValue? BasisforCapacity { get; set; }

		/// <summary>
		/// <para>DAC: PX.Objects.AM.AMWC</para>
		/// <para>Display Name: Control Point</para>
		/// </summary>
		[DataMember(Name="ControlPoint", EmitDefaultValue=false)]
		public BooleanValue? ControlPoint { get; set; }

		/// <summary>
		/// <para>DAC: PX.Objects.AM.AMWC</para>
		/// <para>Display Name: Default Finish Time</para>
		/// </summary>
		[DataMember(Name="DefaultFinishTime", EmitDefaultValue=false)]
		public StringValue? DefaultFinishTime { get; set; }

		/// <summary>
		/// <para>DAC: PX.Objects.AM.AMWC</para>
		/// <para>Display Name: Default Move Time</para>
		/// </summary>
		[DataMember(Name="DefaultMoveTime", EmitDefaultValue=false)]
		public StringValue? DefaultMoveTime { get; set; }

		/// <summary>
		/// <para>DAC: PX.Objects.AM.AMWC</para>
		/// <para>Display Name: Default Queue Time</para>
		/// </summary>
		[DataMember(Name="DefaultQueueTime", EmitDefaultValue=false)]
		public StringValue? DefaultQueueTime { get; set; }

		/// <summary>
		/// <para>DAC Field Name: Descr</para>
		/// <para>DAC: PX.Objects.AM.AMWC</para>
		/// <para>SQL Type: nvarchar(256)</para>
		/// </summary>
		[DataMember(Name="Description", EmitDefaultValue=false)]
		public StringValue? Description { get; set; }

		/// <summary>
		/// <para>DAC Field Name: LocationID</para>
		/// <para>DAC: PX.Objects.AM.AMWC</para>
		/// </summary>
		[DataMember(Name="Location", EmitDefaultValue=false)]
		public StringValue? Location { get; set; }

		[DataMember(Name="Machines", EmitDefaultValue=false)]
		public List<MachineDetail>? Machines { get; set; }

		/// <summary>
		/// <para>DAC Field Name: OutsideFlg</para>
		/// <para>DAC: PX.Objects.AM.AMWC</para>
		/// <para>Display Name: Outside Process</para>
		/// </summary>
		[DataMember(Name="OutsideProcessing", EmitDefaultValue=false)]
		public BooleanValue? OutsideProcessing { get; set; }

		[DataMember(Name="Overheads", EmitDefaultValue=false)]
		public List<WorkCenterOverheadDetail>? Overheads { get; set; }

		/// <summary>
		/// <para>DAC Field Name: ScrapAction</para>
		/// <para>DAC: PX.Objects.AM.AMWC</para>
		/// <para>Display Name: Scrap Action Default</para>
		/// </summary>
		[DataMember(Name="ScrapActionDefault", EmitDefaultValue=false)]
		public StringValue? ScrapActionDefault { get; set; }

		[DataMember(Name="Shifts", EmitDefaultValue=false)]
		public List<ShiftDetail>? Shifts { get; set; }

		/// <summary>
		/// <para>DAC Field Name: StdCost</para>
		/// <para>DAC: PX.Objects.AM.AMWCMach</para>
		/// <para>Display Name: Standard Cost</para>
		/// </summary>
		[DataMember(Name="StandardCost", EmitDefaultValue=false)]
		public DecimalValue? StandardCost { get; set; }

		[DataMember(Name="SubstituteWorkCenters", EmitDefaultValue=false)]
		public List<WorkCenterSubstitute>? SubstituteWorkCenters { get; set; }

		/// <summary>
		/// <para>DAC Field Name: SiteID</para>
		/// <para>DAC: PX.Objects.AM.AMWC</para>
		/// </summary>
		[DataMember(Name="Warehouse", EmitDefaultValue=false)]
		public StringValue? Warehouse { get; set; }

		[DataMember(Name="WhereUsed", EmitDefaultValue=false)]
		public List<WhereUsedDetail>? WhereUsed { get; set; }

		/// <summary>
		/// <para>DAC Field Name: WcID</para>
		/// <para>DAC: PX.Objects.AM.AMWC</para>
		/// <para>Display Name: Work Center</para>
		/// <para>SQL Type: nvarchar(20)</para>
		/// Key Field
		/// </summary>
		[DataMember(Name="WorkCenterID", EmitDefaultValue=false)]
		public StringValue? WorkCenterID { get; set; }

		public static class Expand
		{
			public const string Files = "Files";
			public const string Machines = "Machines";
			public const string Machines_Files = "Machines/Files";
			public const string Overheads = "Overheads";
			public const string Overheads_Files = "Overheads/Files";
			public const string Shifts = "Shifts";
			public const string Shifts_Files = "Shifts/Files";
			public const string SubstituteWorkCenters = "SubstituteWorkCenters";
			public const string SubstituteWorkCenters_Files = "SubstituteWorkCenters/Files";
			public const string WhereUsed = "WhereUsed";
			public const string WhereUsed_Files = "WhereUsed/Files";

			//Intentionally excluded
			//public const string All = "Files,Machines,Machines/Files,Overheads,Overheads/Files,Shifts,Shifts/Files,SubstituteWorkCenters,SubstituteWorkCenters/Files,WhereUsed,WhereUsed/Files";
		}
		public virtual string GetEndpointPath()
		{
			return "entity/MANUFACTURING/24.200.001";
		}
	}
}