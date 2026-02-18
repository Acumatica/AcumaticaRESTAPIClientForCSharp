using System;
using System.Collections.Generic;

using Newtonsoft.Json;

using Acumatica.RESTClient.Client;
using Acumatica.RESTClient.ContractBasedApi;
using Acumatica.RESTClient.ContractBasedApi.Model;

namespace Acumatica.MANUFACTURING_25_100_001.Model
{
	/// <summary>
	/// Corresponds to the screen <c>AM102000</c> in the Acumatica ERP
	/// </summary>
	public class ProductionPreferences : Entity, ITopLevelEntity
	{

		/// <summary>
		/// Scheduling block size (in minutes) for APS
		/// <para>DAC Field Name: SchdBlockSize</para>
		/// <para>DAC: PX.Objects.AM.AMPSetup</para>
		/// <para>Display Name: Block Size</para>
		/// </summary>
		public StringValue? BlockSize { get; set; }

		/// <summary>
		/// <para>DAC Field Name: CTPOrderType</para>
		/// <para>DAC: PX.Objects.AM.AMPSetup</para>
		/// <para>Display Name: Capable to Promise Order Type</para>
		/// <para>SQL Type: char(2)</para>
		/// </summary>
		public StringValue? CapabletoPromiseOrderType { get; set; }

		/// <summary>
		/// <para>DAC Field Name: ProdCostNumberingID</para>
		/// <para>DAC: PX.Objects.AM.AMPSetup</para>
		/// <para>Display Name: Cost Numbering Sequence</para>
		/// <para>SQL Type: nvarchar(10)</para>
		/// </summary>
		public StringValue? CostNumberingSequence { get; set; }

		public ProductionDataCollectionSettings? DataCollectionSettings { get; set; }

		/// <summary>
		/// <para>DAC: PX.Objects.AM.AMPSetup</para>
		/// <para>Display Name: Default Disassembly Order Type</para>
		/// <para>SQL Type: char(2)</para>
		/// </summary>
		public StringValue? DefaultDisassembleOrderType { get; set; }

		/// <summary>
		/// <para>DAC: PX.Objects.AM.AMPSetup</para>
		/// <para>Display Name: Default Order Type</para>
		/// <para>SQL Type: char(2)</para>
		/// </summary>
		public StringValue? DefaultOrderType { get; set; }

		/// <summary>
		/// <para>DAC Field Name: DefaultEmployee</para>
		/// <para>DAC: PX.Objects.AM.AMPSetup</para>
		/// <para>Display Name: Insert Current User's Employee ID</para>
		/// </summary>
		public BooleanValue? DefaultUserEmployeeID { get; set; }

		/// <summary>
		/// <para>DAC Field Name: DisassemblyNumberingID</para>
		/// <para>DAC: PX.Objects.AM.AMPSetup</para>
		/// <para>Display Name: Disassembly Numbering Sequence</para>
		/// <para>SQL Type: nvarchar(10)</para>
		/// </summary>
		public StringValue? DisassemblyNumberingSequence { get; set; }

		/// <summary>
		/// <para>DAC Field Name: FixMfgCalendarID</para>
		/// <para>DAC: PX.Objects.AM.AMPSetup</para>
		/// <para>Display Name: Fixed Mfg. Calendar ID</para>
		/// <para>SQL Type: nvarchar(10)</para>
		/// </summary>
		public StringValue? FixedMfgCalendarID { get; set; }

		/// <summary>
		/// <para>DAC Field Name: FMLTimeUnits</para>
		/// <para>DAC: PX.Objects.AM.AMPSetup</para>
		/// <para>Display Name: Fixed Mfg. Units</para>
		/// </summary>
		public StringValue? FixedMfgUnits { get; set; }

		/// <summary>
		/// <para>DAC Field Name: HoldEntry</para>
		/// <para>DAC: PX.Objects.AM.AMPSetup</para>
		/// <para>Display Name: Hold Documents on Entry</para>
		/// </summary>
		public BooleanValue? HoldDocumentsonEntry { get; set; }

		/// <summary>
		/// <para>DAC Field Name: HoldShipmentsOnEntry</para>
		/// <para>DAC: PX.Objects.AM.AMPSetup</para>
		/// <para>Display Name: Hold Shipments on Entry</para>
		/// </summary>
		public BooleanValue? HoldShipmentsonEntry { get; set; }

		/// <summary>
		/// <para>DAC Field Name: InclScrap</para>
		/// <para>DAC: PX.Objects.AM.AMPSetup</para>
		/// <para>Display Name: Include Scrap in Completions</para>
		/// </summary>
		public BooleanValue? IncludeScrapinCompletions { get; set; }

		/// <summary>
		/// <para>DAC Field Name: LaborNumberingID</para>
		/// <para>DAC: PX.Objects.AM.AMPSetup</para>
		/// <para>Display Name: Labor Numbering Sequence</para>
		/// <para>SQL Type: nvarchar(10)</para>
		/// </summary>
		public StringValue? LaborNumberingSequence { get; set; }

		/// <summary>
		/// Lock status on production order preferrence
		/// <para>DAC Field Name: LockWorkflowEnabled</para>
		/// <para>DAC: PX.Objects.AM.AMPSetup</para>
		/// <para>Display Name: Lock Production Orders Before Closing</para>
		/// </summary>
		public BooleanValue? LockProductionOrdersBeforeClosing { get; set; }

		/// <summary>
		/// <para>DAC: PX.Objects.AM.AMPSetup</para>
		/// <para>Display Name: Consider Machine Resources</para>
		/// </summary>
		public BooleanValue? MachineScheduling { get; set; }

		/// <summary>
		/// <para>DAC Field Name: MaterialNumberingID</para>
		/// <para>DAC: PX.Objects.AM.AMPSetup</para>
		/// <para>Display Name: Material Numbering Sequence</para>
		/// <para>SQL Type: nvarchar(10)</para>
		/// </summary>
		public StringValue? MaterialNumberingSequence { get; set; }

		/// <summary>
		/// <para>DAC Field Name: MoveNumberingID</para>
		/// <para>DAC: PX.Objects.AM.AMPSetup</para>
		/// <para>Display Name: Move Numbering Sequence</para>
		/// <para>SQL Type: nvarchar(10)</para>
		/// </summary>
		public StringValue? MoveNumberingSequence { get; set; }

		/// <summary>
		/// <para>DAC Field Name: SummPost</para>
		/// <para>DAC: PX.Objects.AM.AMPSetup</para>
		/// <para>Display Name: Post Summary on Updating GL</para>
		/// </summary>
		public BooleanValue? PostSummaryonUpdatingGL { get; set; }

		/// <summary>
		/// <para>DAC Field Name: RestrictClockCurrentUser</para>
		/// <para>DAC: PX.Objects.AM.AMPSetup</para>
		/// <para>Display Name: Restrict Clock Entry to Current User</para>
		/// </summary>
		public BooleanValue? RestrictClockEntrytoCurrentUser { get; set; }

		/// <summary>
		/// <para>DAC: PX.Objects.AM.AMPSetup</para>
		/// <para>Display Name: Consider Tools</para>
		/// </summary>
		public BooleanValue? ToolScheduling { get; set; }

		/// <summary>
		/// <para>DAC Field Name: FMLTime</para>
		/// <para>DAC: PX.Objects.AM.AMPSetup</para>
		/// <para>Display Name: Use Fixed Manufacturing Times</para>
		/// </summary>
		public BooleanValue? UseFixedManufacturingTimes { get; set; }

		/// <summary>
		/// <para>DAC Field Name: DfltLbrRate</para>
		/// <para>DAC: PX.Objects.AM.AMPSetup</para>
		/// <para>Display Name: Use Labor Rate</para>
		/// <para>SQL Type: char(1)</para>
		/// </summary>
		public StringValue? UseLaborRate { get; set; }

		/// <summary>
		/// <para>DAC Field Name: FMLTMRPOrdorOP</para>
		/// <para>DAC: PX.Objects.AM.AMPSetup</para>
		/// <para>Display Name: Use Order Start Date for MRP</para>
		/// </summary>
		public BooleanValue? UseOrderStartDateforMRP { get; set; }

		/// <summary>
		/// When scheduling a production order should the process use crew size and efficiencyDefault is false to match logic before upgrade. Requires APS
		/// <para>DAC: PX.Objects.AM.AMPSetup</para>
		/// <para>Display Name: Use Shift Crew Size</para>
		/// </summary>
		public BooleanValue? UseShiftCrewSize { get; set; }

		/// <summary>
		/// <para>DAC Field Name: RequireControlTotal</para>
		/// <para>DAC: PX.Objects.AM.AMPSetup</para>
		/// <para>Display Name: Validate Document Totals on Entry</para>
		/// </summary>
		public BooleanValue? ValidateDocumentTotalsonEntry { get; set; }

		/// <summary>
		/// <para>DAC Field Name: ValidateShipmentTotalOnConfirm</para>
		/// <para>DAC: PX.Objects.AM.AMPSetup</para>
		/// <para>Display Name: Validate Shipment Total on Confirmation</para>
		/// </summary>
		public BooleanValue? ValidateShipmentTotalonConfirmation { get; set; }

		/// <summary>
		/// <para>DAC Field Name: VendorShipmentNumberingID</para>
		/// <para>DAC: PX.Objects.AM.AMPSetup</para>
		/// <para>Display Name: Vendor Shipment Numbering Sequence</para>
		/// <para>SQL Type: nvarchar(10)</para>
		/// </summary>
		public StringValue? VendorShipmentNumberingSequence { get; set; }

		/// <summary>
		/// <para>DAC Field Name: WipAdjustNumberingID</para>
		/// <para>DAC: PX.Objects.AM.AMPSetup</para>
		/// <para>Display Name: WIP Adjustment Numbering Sequence</para>
		/// <para>SQL Type: nvarchar(10)</para>
		/// </summary>
		public StringValue? WipAdjustNumberingSequence { get; set; }

		public static class Expand
		{
			public const string Files = "Files";
			public const string Translations = "Translations";
			public const string DataCollectionSettings = "DataCollectionSettings";

			//Intentionally excluded
			//public const string All = "Files,Translations,DataCollectionSettings";
		}
		public virtual string GetEndpointPath()
		{
			return "entity/MANUFACTURING/25.100.001";
		}
	}
}