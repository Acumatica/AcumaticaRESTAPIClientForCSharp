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
	/// Corresponds to the screen AM102000 in the Acumatica ERP
	/// </summary>
	[DataContract]
	public class ProductionPreferences : Entity, ITopLevelEntity
	{

		/// <summary>
		/// Scheduling block size (in minutes) for APS
		/// DAC Field Name: SchdBlockSize 
		/// DAC: PX.Objects.AM.AMPSetup 
		/// Display Name: Block Size 
		/// </summary>
		[DataMember(Name="BlockSize", EmitDefaultValue=false)]
		public StringValue? BlockSize { get; set; }

		/// <summary>
		/// DAC Field Name: CTPOrderType 
		/// DAC: PX.Objects.AM.AMPSetup 
		/// Display Name: Capable to Promise Order Type 
		/// SQL Type: char(2) 
		/// </summary>
		[DataMember(Name="CapabletoPromiseOrderType", EmitDefaultValue=false)]
		public StringValue? CapabletoPromiseOrderType { get; set; }

		/// <summary>
		/// DAC Field Name: ProdCostNumberingID 
		/// DAC: PX.Objects.AM.AMPSetup 
		/// Display Name: Cost Numbering Sequence 
		/// SQL Type: nvarchar(10) 
		/// </summary>
		[DataMember(Name="CostNumberingSequence", EmitDefaultValue=false)]
		public StringValue? CostNumberingSequence { get; set; }

		[DataMember(Name="DataCollectionSettings", EmitDefaultValue=false)]
		public ProductionDataCollectionSettings? DataCollectionSettings { get; set; }

		/// <summary>
		/// DAC: PX.Objects.AM.AMPSetup 
		/// Display Name: Default Disassemble Order Type 
		/// SQL Type: char(2) 
		/// </summary>
		[DataMember(Name="DefaultDisassembleOrderType", EmitDefaultValue=false)]
		public StringValue? DefaultDisassembleOrderType { get; set; }

		/// <summary>
		/// DAC: PX.Objects.AM.AMPSetup 
		/// Display Name: Default Order Type 
		/// SQL Type: char(2) 
		/// </summary>
		[DataMember(Name="DefaultOrderType", EmitDefaultValue=false)]
		public StringValue? DefaultOrderType { get; set; }

		/// <summary>
		/// DAC Field Name: DefaultEmployee 
		/// DAC: PX.Objects.AM.AMPSetup 
		/// Display Name: Default User Employee ID 
		/// </summary>
		[DataMember(Name="DefaultUserEmployeeID", EmitDefaultValue=false)]
		public BooleanValue? DefaultUserEmployeeID { get; set; }

		/// <summary>
		/// DAC Field Name: DisassemblyNumberingID 
		/// DAC: PX.Objects.AM.AMPSetup 
		/// Display Name: Disassembly Numbering Sequence 
		/// SQL Type: nvarchar(10) 
		/// </summary>
		[DataMember(Name="DisassemblyNumberingSequence", EmitDefaultValue=false)]
		public StringValue? DisassemblyNumberingSequence { get; set; }

		/// <summary>
		/// DAC Field Name: FixMfgCalendarID 
		/// DAC: PX.Objects.AM.AMPSetup 
		/// Display Name: Fixed Mfg Calendar ID 
		/// SQL Type: nvarchar(10) 
		/// </summary>
		[DataMember(Name="FixedMfgCalendarID", EmitDefaultValue=false)]
		public StringValue? FixedMfgCalendarID { get; set; }

		/// <summary>
		/// DAC Field Name: FMLTimeUnits 
		/// DAC: PX.Objects.AM.AMPSetup 
		/// Display Name: Fixed Mfg Units 
		/// </summary>
		[DataMember(Name="FixedMfgUnits", EmitDefaultValue=false)]
		public StringValue? FixedMfgUnits { get; set; }

		/// <summary>
		/// DAC Field Name: HoldEntry 
		/// DAC: PX.Objects.AM.AMPSetup 
		/// Display Name: Hold Documents on Entry 
		/// </summary>
		[DataMember(Name="HoldDocumentsonEntry", EmitDefaultValue=false)]
		public BooleanValue? HoldDocumentsonEntry { get; set; }

		/// <summary>
		/// DAC Field Name: HoldShipmentsOnEntry 
		/// DAC: PX.Objects.AM.AMPSetup 
		/// Display Name: Hold Shipments on Entry 
		/// </summary>
		[DataMember(Name="HoldShipmentsonEntry", EmitDefaultValue=false)]
		public BooleanValue? HoldShipmentsonEntry { get; set; }

		/// <summary>
		/// DAC Field Name: InclScrap 
		/// DAC: PX.Objects.AM.AMPSetup 
		/// Display Name: Include Scrap in Completions 
		/// </summary>
		[DataMember(Name="IncludeScrapinCompletions", EmitDefaultValue=false)]
		public BooleanValue? IncludeScrapinCompletions { get; set; }

		/// <summary>
		/// DAC Field Name: LaborNumberingID 
		/// DAC: PX.Objects.AM.AMPSetup 
		/// Display Name: Labor Numbering Sequence 
		/// SQL Type: nvarchar(10) 
		/// </summary>
		[DataMember(Name="LaborNumberingSequence", EmitDefaultValue=false)]
		public StringValue? LaborNumberingSequence { get; set; }

		/// <summary>
		/// Lock status on production order preferrence
		/// DAC Field Name: LockWorkflowEnabled 
		/// DAC: PX.Objects.AM.AMPSetup 
		/// Display Name: Lock Production Orders before Closing 
		/// </summary>
		[DataMember(Name="LockProductionOrdersBeforeClosing", EmitDefaultValue=false)]
		public BooleanValue? LockProductionOrdersBeforeClosing { get; set; }

		/// <summary>
		/// DAC: PX.Objects.AM.AMPSetup 
		/// Display Name: Machine Scheduling 
		/// </summary>
		[DataMember(Name="MachineScheduling", EmitDefaultValue=false)]
		public BooleanValue? MachineScheduling { get; set; }

		/// <summary>
		/// DAC Field Name: MaterialNumberingID 
		/// DAC: PX.Objects.AM.AMPSetup 
		/// Display Name: Material Numbering Sequence 
		/// SQL Type: nvarchar(10) 
		/// </summary>
		[DataMember(Name="MaterialNumberingSequence", EmitDefaultValue=false)]
		public StringValue? MaterialNumberingSequence { get; set; }

		/// <summary>
		/// DAC Field Name: MoveNumberingID 
		/// DAC: PX.Objects.AM.AMPSetup 
		/// Display Name: Move Numbering Sequence 
		/// SQL Type: nvarchar(10) 
		/// </summary>
		[DataMember(Name="MoveNumberingSequence", EmitDefaultValue=false)]
		public StringValue? MoveNumberingSequence { get; set; }

		/// <summary>
		/// DAC Field Name: SummPost 
		/// DAC: PX.Objects.AM.AMPSetup 
		/// Display Name: Post Summary on Updating GL 
		/// </summary>
		[DataMember(Name="PostSummaryonUpdatingGL", EmitDefaultValue=false)]
		public BooleanValue? PostSummaryonUpdatingGL { get; set; }

		/// <summary>
		/// DAC Field Name: RestrictClockCurrentUser 
		/// DAC: PX.Objects.AM.AMPSetup 
		/// Display Name: Restrict Clock Entry to Current User 
		/// </summary>
		[DataMember(Name="RestrictClockEntrytoCurrentUser", EmitDefaultValue=false)]
		public BooleanValue? RestrictClockEntrytoCurrentUser { get; set; }

		/// <summary>
		/// DAC: PX.Objects.AM.AMPSetup 
		/// Display Name: Tool Scheduling 
		/// </summary>
		[DataMember(Name="ToolScheduling", EmitDefaultValue=false)]
		public BooleanValue? ToolScheduling { get; set; }

		/// <summary>
		/// DAC Field Name: FMLTime 
		/// DAC: PX.Objects.AM.AMPSetup 
		/// Display Name: Use Fixed Manufacturing Times 
		/// </summary>
		[DataMember(Name="UseFixedManufacturingTimes", EmitDefaultValue=false)]
		public BooleanValue? UseFixedManufacturingTimes { get; set; }

		/// <summary>
		/// DAC Field Name: DfltLbrRate 
		/// DAC: PX.Objects.AM.AMPSetup 
		/// Display Name: Use Labor Rate 
		/// SQL Type: char(1) 
		/// </summary>
		[DataMember(Name="UseLaborRate", EmitDefaultValue=false)]
		public StringValue? UseLaborRate { get; set; }

		/// <summary>
		/// DAC Field Name: FMLTMRPOrdorOP 
		/// DAC: PX.Objects.AM.AMPSetup 
		/// Display Name: Use Order Start Date for MRP 
		/// </summary>
		[DataMember(Name="UseOrderStartDateforMRP", EmitDefaultValue=false)]
		public BooleanValue? UseOrderStartDateforMRP { get; set; }

		/// <summary>
		/// When scheduling a production order should the process use crew size and efficiencyDefault is false to match logic before upgrade. Requires APS
		/// DAC: PX.Objects.AM.AMPSetup 
		/// Display Name: Use Shift Crew Size 
		/// </summary>
		[DataMember(Name="UseShiftCrewSize", EmitDefaultValue=false)]
		public BooleanValue? UseShiftCrewSize { get; set; }

		/// <summary>
		/// DAC Field Name: RequireControlTotal 
		/// DAC: PX.Objects.AM.AMPSetup 
		/// Display Name: Validate Document Totals on Entry 
		/// </summary>
		[DataMember(Name="ValidateDocumentTotalsonEntry", EmitDefaultValue=false)]
		public BooleanValue? ValidateDocumentTotalsonEntry { get; set; }

		/// <summary>
		/// DAC Field Name: ValidateShipmentTotalOnConfirm 
		/// DAC: PX.Objects.AM.AMPSetup 
		/// Display Name: Validate Shipment Total on Confirmation 
		/// </summary>
		[DataMember(Name="ValidateShipmentTotalonConfirmation", EmitDefaultValue=false)]
		public BooleanValue? ValidateShipmentTotalonConfirmation { get; set; }

		/// <summary>
		/// DAC Field Name: VendorShipmentNumberingID 
		/// DAC: PX.Objects.AM.AMPSetup 
		/// Display Name: Vendor Shipment Numbering Sequence 
		/// SQL Type: nvarchar(10) 
		/// </summary>
		[DataMember(Name="VendorShipmentNumberingSequence", EmitDefaultValue=false)]
		public StringValue? VendorShipmentNumberingSequence { get; set; }

		/// <summary>
		/// DAC Field Name: WipAdjustNumberingID 
		/// DAC: PX.Objects.AM.AMPSetup 
		/// Display Name: Wip Adjust Numbering Sequence 
		/// SQL Type: nvarchar(10) 
		/// </summary>
		[DataMember(Name="WipAdjustNumberingSequence", EmitDefaultValue=false)]
		public StringValue? WipAdjustNumberingSequence { get; set; }

		public virtual string GetEndpointPath()
		{
			return "entity/MANUFACTURING/24.200.001";
		}
	}
}