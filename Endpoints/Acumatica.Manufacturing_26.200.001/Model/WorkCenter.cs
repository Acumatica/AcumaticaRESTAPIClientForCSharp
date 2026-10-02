using System;
using System.Collections.Generic;

using Newtonsoft.Json;

using Acumatica.RESTClient.Client;
using Acumatica.RESTClient.ContractBasedApi;
using Acumatica.RESTClient.ContractBasedApi.Model;

namespace Acumatica.Manufacturing_26_200_001.Model
{
	/// <summary>
	/// Corresponds to the screen <c>AM207000</c> in the Acumatica ERP
	/// <para>Key Fields: WorkCenterID</para>
	/// </summary>
	public class WorkCenter : Entity, ITopLevelEntity
	{

		#region Fields
		/// <summary>
		/// <para>DAC Field Name: WcID</para>
		/// <para>DAC: PX.Objects.AM.AMWC</para>
		/// <para>Display Name: Work Center</para>
		/// <para>SQL Type: nvarchar(20)</para>
		/// Key Field
		/// </summary>
		public StringValue? WorkCenterID { get; set; }

		/// <summary>
		/// <para>DAC Field Name: Descr</para>
		/// <para>DAC: PX.Objects.AM.AMWC</para>
		/// <para>SQL Type: nvarchar(256)</para>
		/// </summary>
		public StringValue? Description { get; set; }

		/// <summary>
		/// <para>DAC Field Name: SiteID</para>
		/// <para>DAC: PX.Objects.AM.AMWC</para>
		/// </summary>
		public StringValue? Warehouse { get; set; }

		/// <summary>
		/// <para>DAC Field Name: LocationID</para>
		/// <para>DAC: PX.Objects.AM.AMWC</para>
		/// </summary>
		public StringValue? Location { get; set; }

		/// <summary>
		/// <para>DAC Field Name: ActiveFlg</para>
		/// <para>DAC: PX.Objects.AM.AMWC</para>
		/// </summary>
		public BooleanValue? Active { get; set; }

		/// <summary>
		/// <para>DAC Field Name: WcBasis</para>
		/// <para>DAC: PX.Objects.AM.AMWC</para>
		/// <para>Display Name: Basis for Capacity</para>
		/// <para>SQL Type: char(1)</para>
		/// </summary>
		public StringValue? BasisforCapacity { get; set; }

		/// <summary>
		/// <para>DAC Field Name: ScrapAction</para>
		/// <para>DAC: PX.Objects.AM.AMWC</para>
		/// <para>Display Name: Scrap Action Default</para>
		/// </summary>
		public StringValue? ScrapActionDefault { get; set; }

		/// <summary>
		/// <para>DAC Field Name: BflushMatl</para>
		/// <para>DAC: PX.Objects.AM.AMWC</para>
		/// <para>Display Name: Backflush Materials</para>
		/// </summary>
		public BooleanValue? BackflushMaterials { get; set; }

		/// <summary>
		/// <para>DAC Field Name: BflushLbr</para>
		/// <para>DAC: PX.Objects.AM.AMWC</para>
		/// <para>Display Name: Backflush Labor</para>
		/// </summary>
		public BooleanValue? BackflushLabor { get; set; }

		/// <summary>
		/// <para>DAC Field Name: AllowMultiClockEntry</para>
		/// <para>DAC: PX.Objects.AM.AMWC</para>
		/// <para>Display Name: Allow Clock Entry for Multiple Production Orders</para>
		/// </summary>
		public BooleanValue? AllowClockEntryforMultipleProductionOrders { get; set; }

		/// <summary>
		/// <para>DAC: PX.Objects.AM.AMWC</para>
		/// <para>Display Name: Control Point</para>
		/// </summary>
		public BooleanValue? ControlPoint { get; set; }

		/// <summary>
		/// <para>DAC Field Name: OutsideFlg</para>
		/// <para>DAC: PX.Objects.AM.AMWC</para>
		/// <para>Display Name: Outside Process</para>
		/// </summary>
		public BooleanValue? OutsideProcessing { get; set; }

		/// <summary>
		/// <para>DAC: PX.Objects.AM.AMWC</para>
		/// <para>Display Name: Default Queue Time</para>
		/// </summary>
		public StringValue? DefaultQueueTime { get; set; }

		/// <summary>
		/// <para>DAC: PX.Objects.AM.AMWC</para>
		/// <para>Display Name: Default Finish Time</para>
		/// </summary>
		public StringValue? DefaultFinishTime { get; set; }

		/// <summary>
		/// <para>DAC: PX.Objects.AM.AMWC</para>
		/// <para>Display Name: Default Move Time</para>
		/// </summary>
		public StringValue? DefaultMoveTime { get; set; }

		/// <summary>
		/// <para>DAC Field Name: StdCost</para>
		/// <para>DAC: PX.Objects.AM.AMWCMach</para>
		/// <para>Display Name: Standard Cost</para>
		/// </summary>
		public DecimalValue? StandardCost { get; set; }

		public StringValue? DepartmentID { get; set; }

		#endregion

		#region Details
		public List<MachineDetail>? Machines { get; set; }

		public List<WorkCenterOverheadDetail>? Overheads { get; set; }

		public List<ShiftDetail>? Shifts { get; set; }

		public List<WorkCenterSubstitute>? SubstituteWorkCenters { get; set; }

		public List<WhereUsedDetail>? WhereUsed { get; set; }

		#endregion

		protected override string GetDebuggerDisplay()
		{
			return $"{nameof(WorkCenter)} - \"{WorkCenterID}\"";
		}

		/// <summary>
		/// Names that can be passed in the <c>$expand</c> parameter.
		/// <para>This endpoint uses system contract 5, where a nested entity is expanded
		/// as <c>Parent($expand=Child)</c> rather than <c>Parent/Child</c>, so only the names
		/// that can be expanded directly on this entity are listed here. Use the nested
		/// entity's own <c>Expand</c> class for the inner names.</para>
		/// </summary>
		public static class Expand
		{
			public const string Files = "Files";
			public const string Translations = "Translations";
			public const string Machines = "Machines";
			public const string Overheads = "Overheads";
			public const string Shifts = "Shifts";
			public const string SubstituteWorkCenters = "SubstituteWorkCenters";
			public const string WhereUsed = "WhereUsed";

			//Intentionally excluded
			//public const string All = "Files,Translations,Machines,Overheads,Shifts,SubstituteWorkCenters,WhereUsed";
		}
		public virtual string GetEndpointPath()
		{
			return "entity/MANUFACTURING/26.200.001";
		}
	}
}