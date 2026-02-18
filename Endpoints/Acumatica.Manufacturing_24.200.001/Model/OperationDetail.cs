using System;
using System.Collections.Generic;

using Newtonsoft.Json;

using Acumatica.RESTClient.Client;
using Acumatica.RESTClient.ContractBasedApi;
using Acumatica.RESTClient.ContractBasedApi.Model;

namespace Acumatica.Manufacturing_24_200_001.Model
{
	public class OperationDetail : Entity
	{

		/// <summary>
		/// A Boolean value that indicates whether a labor transaction is needed to report labor hours spent for the operation.
		/// <para>DAC Field Name: BFlush</para>
		/// <para>DAC: PX.Objects.AM.AMBomOper</para>
		/// <para>Display Name: Backflush Labor</para>
		/// </summary>
		public BooleanValue? BackflushLabor { get; set; }

		/// <summary>
		/// The identifier of the bill of material.
		/// <para>DAC: PX.Objects.AM.AMBomItem</para>
		/// <para>Display Name: BOM ID</para>
		/// <para>SQL Type: nvarchar(15)</para>
		/// Key Field
		/// </summary>
		public StringValue? BOMID { get; set; }

		/// <summary>
		/// A Boolean value that indicates whether the operation is a control point.
		/// <para>DAC: PX.Objects.AM.AMBomOper</para>
		/// <para>Display Name: Control Point</para>
		/// </summary>
		public BooleanValue? ControlPoint { get; set; }

		/// <summary>
		/// A Boolean value that indicates whether the operation has been drop shipped to the vendor.
		/// <para>DAC Field Name: DropShippedToVendor</para>
		/// <para>DAC: PX.Objects.AM.AMBomOper</para>
		/// <para>Display Name: Drop Shipped to Vendor</para>
		/// </summary>
		public BooleanValue? DropShippedtoVendor { get; set; }

		public IntValue? FinishTime { get; set; }

		public IntValue? MachineTime { get; set; }

		/// <summary>
		/// The number of units produced during the specified machine time for the operation.
		/// <para>DAC: PX.Objects.AM.AMBomOper</para>
		/// <para>Display Name: Machine Units</para>
		/// </summary>
		public DecimalValue? MachineUnits { get; set; }

		public List<MaterialDetail>? Material { get; set; }

		public IntValue? MoveTime { get; set; }

		/// <summary>
		/// A description of the bill of material. The system copies the description to production orders that are created by using the bill of material.
		/// <para>DAC Field Name: Descr</para>
		/// <para>DAC: PX.Objects.AM.AMBomItem</para>
		/// <para>Display Name: Description</para>
		/// <para>SQL Type: nvarchar(256)</para>
		/// </summary>
		public StringValue? OperationDescription { get; set; }

		/// <summary>
		/// The numeric identifier of the operation, which is displayed in the operation.
		/// <para>DAC Field Name: OperationCD</para>
		/// <para>DAC: PX.Objects.AM.AMBomOper</para>
		/// <para>Display Name: Operation ID</para>
		/// <para>SQL Type: nvarchar(10)</para>
		/// Key Field
		/// </summary>
		public StringValue? OperationNbr { get; set; }

		/// <summary>
		/// The outside process.
		/// <para>DAC: PX.Objects.AM.AMBomOper</para>
		/// <para>Display Name: Outside Process</para>
		/// </summary>
		public BooleanValue? OutsideProcess { get; set; }

		public List<BomOverheadDetail>? Overheads { get; set; }

		public IntValue? QueueTime { get; set; }

		/// <summary>
		/// The identifier of the BOM revision, which is the modification of the bill of material.
		/// <para>DAC Field Name: RevisionID</para>
		/// <para>DAC: PX.Objects.AM.AMBomItem</para>
		/// <para>SQL Type: nvarchar(10)</para>
		/// Key Field
		/// </summary>
		public StringValue? Revision { get; set; }

		public IntValue? RunTime { get; set; }

		/// <summary>
		/// The number of units produced during the specified run time for the operation.
		/// <para>DAC: PX.Objects.AM.AMBomOper</para>
		/// <para>Display Name: Run Units</para>
		/// </summary>
		public DecimalValue? RunUnits { get; set; }

		/// <summary>
		/// The default scrap action for the operation in new production orders.
		/// <para>DAC: PX.Objects.AM.AMBomOper</para>
		/// <para>Display Name: Scrap Action</para>
		/// </summary>
		public StringValue? ScrapAction { get; set; }

		public IntValue? SetupTime { get; set; }

		public List<StepDetail>? Steps { get; set; }

		public List<ToolDetail>? Tools { get; set; }

		/// <summary>
		/// The vendor ID.
		/// <para>DAC Field Name: VendorID</para>
		/// <para>DAC: PX.Objects.AM.AMBomOperCury</para>
		/// </summary>
		public StringValue? Vendor { get; set; }

		/// <summary>
		/// The vendor location.
		/// <para>DAC Field Name: VendorLocationID</para>
		/// <para>DAC: PX.Objects.AM.AMBomOperCury</para>
		/// <para>Display Name: Vendor Location</para>
		/// </summary>
		public StringValue? VendorLocation { get; set; }

		/// <summary>
		/// The active work center where the operation takes place.
		/// <para>DAC Field Name: WcID</para>
		/// <para>DAC: PX.Objects.AM.AMBomOper</para>
		/// <para>Display Name: Work Center</para>
		/// <para>SQL Type: nvarchar(20)</para>
		/// </summary>
		public StringValue? WorkCenter { get; set; }

	}
}