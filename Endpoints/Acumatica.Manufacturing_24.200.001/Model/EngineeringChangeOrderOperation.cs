using System;
using System.Collections.Generic;

using Newtonsoft.Json;

using Acumatica.RESTClient.Client;
using Acumatica.RESTClient.ContractBasedApi;
using Acumatica.RESTClient.ContractBasedApi.Model;

namespace Acumatica.Manufacturing_24_200_001.Model
{
	public class EngineeringChangeOrderOperation : Entity
	{

		/// <summary>
		/// A Boolean value that indicates whether a labor transaction is needed to report labor hours spent for the operation.
		/// <para>DAC Field Name: BFlush</para>
		/// <para>DAC: PX.Objects.AM.AMBomOper</para>
		/// <para>Display Name: Backflush Labor</para>
		/// </summary>
		public BooleanValue? BackflushLabor { get; set; }

		/// <summary>
		/// The change status.
		/// <para>DAC Field Name: RowStatus</para>
		/// <para>DAC: PX.Objects.AM.AMBomOper</para>
		/// <para>Display Name: Change Status</para>
		/// </summary>
		public StringValue? ChangeStatus { get; set; }

		/// <summary>
		/// A Boolean value that indicates whether the operation has been drop shipped to the vendor.
		/// <para>DAC Field Name: DropShippedToVendor</para>
		/// <para>DAC: PX.Objects.AM.AMBomOper</para>
		/// <para>Display Name: Drop Shipped to Vendor</para>
		/// </summary>
		public BooleanValue? DropShippedtoVendor { get; set; }

		/// <summary>
		/// <para>DAC Field Name: BOMID</para>
		/// <para>DAC: PX.Objects.AM.AMECOItem</para>
		/// <para>Display Name: BOM ID</para>
		/// <para>SQL Type: nvarchar(15)</para>
		/// </summary>
		public StringValue? ECOID { get; set; }

		/// <summary>
		/// The time required for the semi-finished item to be prepared for the next operation when the current operation has been finished.
		/// <para>DAC: PX.Objects.AM.AMBomOper</para>
		/// <para>Display Name: Finish Time</para>
		/// </summary>
		public StringValue? FinishTime { get; set; }

		/// <summary>
		/// The time required to produce the number of machine units specified for the operation.
		/// <para>DAC Field Name: MachineUnitTime</para>
		/// <para>DAC: PX.Objects.AM.AMBomOper</para>
		/// <para>Display Name: Machine Time</para>
		/// </summary>
		public StringValue? MachineTime { get; set; }

		/// <summary>
		/// The number of units produced during the specified machine time for the operation.
		/// <para>DAC: PX.Objects.AM.AMBomOper</para>
		/// <para>Display Name: Machine Units</para>
		/// </summary>
		public DecimalValue? MachineUnits { get; set; }

		public List<EngineeringChangeOrderMaterial>? Material { get; set; }

		/// <summary>
		/// The numeric identifier of the operation, which is displayed in the operation.
		/// <para>DAC Field Name: OperationCD</para>
		/// <para>DAC: PX.Objects.AM.AMBomOper</para>
		/// <para>Display Name: Operation ID</para>
		/// <para>SQL Type: nvarchar(10)</para>
		/// Key Field
		/// </summary>
		public StringValue? OperationID { get; set; }

		/// <summary>
		/// <para>DAC Field Name: Descr</para>
		/// <para>DAC: PX.Objects.AM.AMECOItem</para>
		/// <para>Display Name: Description</para>
		/// <para>SQL Type: nvarchar(256)</para>
		/// </summary>
		public StringValue? OperDesc { get; set; }

		/// <summary>
		/// The outside process.
		/// <para>DAC: PX.Objects.AM.AMBomOper</para>
		/// <para>Display Name: Outside Process</para>
		/// </summary>
		public BooleanValue? OutsideProcess { get; set; }

		public List<EngineeringChangeOrderOverhead>? Overheads { get; set; }

		/// <summary>
		/// The time a semi-finished item has to wait in the work center before workers can start processing the item.
		/// <para>DAC: PX.Objects.AM.AMBomOper</para>
		/// <para>Display Name: Queue Time</para>
		/// </summary>
		public StringValue? QueueTime { get; set; }

		/// <summary>
		/// <para>DAC Field Name: RevisionID</para>
		/// <para>DAC: PX.Objects.AM.AMECOItem</para>
		/// <para>SQL Type: nvarchar(10)</para>
		/// </summary>
		public StringValue? Revision { get; set; }

		/// <summary>
		/// The time required to produce the specified run units of the operation.
		/// <para>DAC Field Name: RunUnitTime</para>
		/// <para>DAC: PX.Objects.AM.AMBomOper</para>
		/// <para>Display Name: Run Time</para>
		/// </summary>
		public StringValue? RunTime { get; set; }

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

		/// <summary>
		/// The time it takes to prepare to start the operation.
		/// <para>DAC: PX.Objects.AM.AMBomOper</para>
		/// <para>Display Name: Setup Time</para>
		/// </summary>
		public StringValue? SetupTime { get; set; }

		public List<EngineeringChangeOrderStep>? Steps { get; set; }

		public List<EngineeringChangeOrderTool>? Tools { get; set; }

		/// <summary>
		/// The vendor.
		/// <para>DAC Field Name: VendorID</para>
		/// <para>DAC: PX.Objects.AM.AMBomOper</para>
		/// </summary>
		public StringValue? Vendor { get; set; }

		/// <summary>
		/// The vendor location.
		/// <para>DAC Field Name: VendorLocationID</para>
		/// <para>DAC: PX.Objects.AM.AMBomOper</para>
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