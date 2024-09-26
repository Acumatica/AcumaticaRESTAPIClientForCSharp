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
	/// Corresponds to the screen AM102000 in the Acumatica ERP
	/// </summary>
	[DataContract]
	public class ProductionPreferences : Entity, ITopLevelEntity
	{

		/// <summary>
		/// 
		/// Display Name:
		/// DAC Field Name: SchdBlockSize 
		/// DAC: PX.Objects.AM.AMPSetup 
		/// </summary>
		/// <remarks>
		/// 
		/// </remarks>
		[DataMember(Name="BlockSize", EmitDefaultValue=false)]
		public StringValue? BlockSize { get; set; }

		/// <summary>
		/// 
		/// Display Name:
		/// DAC Field Name: CTPOrderType 
		/// DAC: PX.Objects.AM.AMPSetup 
		/// </summary>
		/// <remarks>
		/// 
		/// </remarks>
		[DataMember(Name="CapabletoPromiseOrderType", EmitDefaultValue=false)]
		public StringValue? CapabletoPromiseOrderType { get; set; }

		/// <summary>
		/// 
		/// Display Name:
		/// DAC Field Name: ProdCostNumberingID 
		/// DAC: PX.Objects.AM.AMPSetup 
		/// </summary>
		/// <remarks>
		/// 
		/// </remarks>
		[DataMember(Name="CostNumberingSequence", EmitDefaultValue=false)]
		public StringValue? CostNumberingSequence { get; set; }

		[DataMember(Name="DataCollectionSettings", EmitDefaultValue=false)]
		public ProductionDataCollectionSettings? DataCollectionSettings { get; set; }

		/// <summary>
		/// 
		/// Display Name:
		/// DAC Field Name: DefaultDisassembleOrderType 
		/// DAC: PX.Objects.AM.AMPSetup 
		/// </summary>
		/// <remarks>
		/// 
		/// </remarks>
		[DataMember(Name="DefaultDisassembleOrderType", EmitDefaultValue=false)]
		public StringValue? DefaultDisassembleOrderType { get; set; }

		/// <summary>
		/// 
		/// Display Name:
		/// DAC Field Name: DefaultOrderType 
		/// DAC: PX.Objects.AM.AMPSetup 
		/// </summary>
		/// <remarks>
		/// 
		/// </remarks>
		[DataMember(Name="DefaultOrderType", EmitDefaultValue=false)]
		public StringValue? DefaultOrderType { get; set; }

		/// <summary>
		/// 
		/// Display Name:
		/// DAC Field Name: DefaultEmployee 
		/// DAC: PX.Objects.AM.AMPSetup 
		/// </summary>
		/// <remarks>
		/// 
		/// </remarks>
		[DataMember(Name="DefaultUserEmployeeID", EmitDefaultValue=false)]
		public BooleanValue? DefaultUserEmployeeID { get; set; }

		/// <summary>
		/// 
		/// Display Name:
		/// DAC Field Name: DisassemblyNumberingID 
		/// DAC: PX.Objects.AM.AMPSetup 
		/// </summary>
		/// <remarks>
		/// 
		/// </remarks>
		[DataMember(Name="DisassemblyNumberingSequence", EmitDefaultValue=false)]
		public StringValue? DisassemblyNumberingSequence { get; set; }

		/// <summary>
		/// 
		/// Display Name:
		/// DAC Field Name: FixMfgCalendarID 
		/// DAC: PX.Objects.AM.AMPSetup 
		/// </summary>
		/// <remarks>
		/// 
		/// </remarks>
		[DataMember(Name="FixedMfgCalendarID", EmitDefaultValue=false)]
		public StringValue? FixedMfgCalendarID { get; set; }

		/// <summary>
		/// 
		/// Display Name:
		/// DAC Field Name: FMLTimeUnits 
		/// DAC: PX.Objects.AM.AMPSetup 
		/// </summary>
		/// <remarks>
		/// 
		/// </remarks>
		[DataMember(Name="FixedMfgUnits", EmitDefaultValue=false)]
		public StringValue? FixedMfgUnits { get; set; }

		/// <summary>
		/// 
		/// Display Name:
		/// DAC Field Name: HoldEntry 
		/// DAC: PX.Objects.AM.AMPSetup 
		/// </summary>
		/// <remarks>
		/// 
		/// </remarks>
		[DataMember(Name="HoldDocumentsonEntry", EmitDefaultValue=false)]
		public BooleanValue? HoldDocumentsonEntry { get; set; }

		/// <summary>
		/// 
		/// Display Name:
		/// DAC Field Name: HoldShipmentsOnEntry 
		/// DAC: PX.Objects.AM.AMPSetup 
		/// </summary>
		/// <remarks>
		/// 
		/// </remarks>
		[DataMember(Name="HoldShipmentsonEntry", EmitDefaultValue=false)]
		public BooleanValue? HoldShipmentsonEntry { get; set; }

		/// <summary>
		/// 
		/// Display Name:
		/// DAC Field Name: InclScrap 
		/// DAC: PX.Objects.AM.AMPSetup 
		/// </summary>
		/// <remarks>
		/// 
		/// </remarks>
		[DataMember(Name="IncludeScrapinCompletions", EmitDefaultValue=false)]
		public BooleanValue? IncludeScrapinCompletions { get; set; }

		/// <summary>
		/// 
		/// Display Name:
		/// DAC Field Name: LaborNumberingID 
		/// DAC: PX.Objects.AM.AMPSetup 
		/// </summary>
		/// <remarks>
		/// 
		/// </remarks>
		[DataMember(Name="LaborNumberingSequence", EmitDefaultValue=false)]
		public StringValue? LaborNumberingSequence { get; set; }

		/// <summary>
		/// 
		/// Display Name:
		/// DAC Field Name: MachineScheduling 
		/// DAC: PX.Objects.AM.AMPSetup 
		/// </summary>
		/// <remarks>
		/// 
		/// </remarks>
		[DataMember(Name="MachineScheduling", EmitDefaultValue=false)]
		public BooleanValue? MachineScheduling { get; set; }

		/// <summary>
		/// 
		/// Display Name:
		/// DAC Field Name: MaterialNumberingID 
		/// DAC: PX.Objects.AM.AMPSetup 
		/// </summary>
		/// <remarks>
		/// 
		/// </remarks>
		[DataMember(Name="MaterialNumberingSequence", EmitDefaultValue=false)]
		public StringValue? MaterialNumberingSequence { get; set; }

		/// <summary>
		/// 
		/// Display Name:
		/// DAC Field Name: MoveNumberingID 
		/// DAC: PX.Objects.AM.AMPSetup 
		/// </summary>
		/// <remarks>
		/// 
		/// </remarks>
		[DataMember(Name="MoveNumberingSequence", EmitDefaultValue=false)]
		public StringValue? MoveNumberingSequence { get; set; }

		/// <summary>
		/// 
		/// Display Name:
		/// DAC Field Name: SummPost 
		/// DAC: PX.Objects.AM.AMPSetup 
		/// </summary>
		/// <remarks>
		/// 
		/// </remarks>
		[DataMember(Name="PostSummaryonUpdatingGL", EmitDefaultValue=false)]
		public BooleanValue? PostSummaryonUpdatingGL { get; set; }

		/// <summary>
		/// 
		/// Display Name:
		/// DAC Field Name: RestrictClockCurrentUser 
		/// DAC: PX.Objects.AM.AMPSetup 
		/// </summary>
		/// <remarks>
		/// 
		/// </remarks>
		[DataMember(Name="RestrictClockEntrytoCurrentUser", EmitDefaultValue=false)]
		public BooleanValue? RestrictClockEntrytoCurrentUser { get; set; }

		/// <summary>
		/// 
		/// Display Name:
		/// DAC Field Name: ToolScheduling 
		/// DAC: PX.Objects.AM.AMPSetup 
		/// </summary>
		/// <remarks>
		/// 
		/// </remarks>
		[DataMember(Name="ToolScheduling", EmitDefaultValue=false)]
		public BooleanValue? ToolScheduling { get; set; }

		/// <summary>
		/// 
		/// Display Name:
		/// DAC Field Name: FMLTime 
		/// DAC: PX.Objects.AM.AMPSetup 
		/// </summary>
		/// <remarks>
		/// 
		/// </remarks>
		[DataMember(Name="UseFixedManufacturingTimes", EmitDefaultValue=false)]
		public BooleanValue? UseFixedManufacturingTimes { get; set; }

		/// <summary>
		/// 
		/// Display Name:
		/// DAC Field Name: DfltLbrRate 
		/// DAC: PX.Objects.AM.AMPSetup 
		/// </summary>
		/// <remarks>
		/// 
		/// </remarks>
		[DataMember(Name="UseLaborRate", EmitDefaultValue=false)]
		public StringValue? UseLaborRate { get; set; }

		/// <summary>
		/// 
		/// Display Name:
		/// DAC Field Name: FMLTMRPOrdorOP 
		/// DAC: PX.Objects.AM.AMPSetup 
		/// </summary>
		/// <remarks>
		/// 
		/// </remarks>
		[DataMember(Name="UseOrderStartDateforMRP", EmitDefaultValue=false)]
		public BooleanValue? UseOrderStartDateforMRP { get; set; }

		/// <summary>
		/// 
		/// Display Name:
		/// DAC Field Name: UseShiftCrewSize 
		/// DAC: PX.Objects.AM.AMPSetup 
		/// </summary>
		/// <remarks>
		/// 
		/// </remarks>
		[DataMember(Name="UseShiftCrewSize", EmitDefaultValue=false)]
		public BooleanValue? UseShiftCrewSize { get; set; }

		/// <summary>
		/// 
		/// Display Name:
		/// DAC Field Name: RequireControlTotal 
		/// DAC: PX.Objects.AM.AMPSetup 
		/// </summary>
		/// <remarks>
		/// 
		/// </remarks>
		[DataMember(Name="ValidateDocumentTotalsonEntry", EmitDefaultValue=false)]
		public BooleanValue? ValidateDocumentTotalsonEntry { get; set; }

		/// <summary>
		/// 
		/// Display Name:
		/// DAC Field Name: ValidateShipmentTotalOnConfirm 
		/// DAC: PX.Objects.AM.AMPSetup 
		/// </summary>
		/// <remarks>
		/// 
		/// </remarks>
		[DataMember(Name="ValidateShipmentTotalonConfirmation", EmitDefaultValue=false)]
		public BooleanValue? ValidateShipmentTotalonConfirmation { get; set; }

		/// <summary>
		/// 
		/// Display Name:
		/// DAC Field Name: VendorShipmentNumberingID 
		/// DAC: PX.Objects.AM.AMPSetup 
		/// </summary>
		/// <remarks>
		/// 
		/// </remarks>
		[DataMember(Name="VendorShipmentNumberingSequence", EmitDefaultValue=false)]
		public StringValue? VendorShipmentNumberingSequence { get; set; }

		/// <summary>
		/// 
		/// Display Name:
		/// DAC Field Name: WipAdjustNumberingID 
		/// DAC: PX.Objects.AM.AMPSetup 
		/// </summary>
		/// <remarks>
		/// 
		/// </remarks>
		[DataMember(Name="WipAdjustNumberingSequence", EmitDefaultValue=false)]
		public StringValue? WipAdjustNumberingSequence { get; set; }

		public virtual string GetEndpointPath()
		{
			return "entity/MANUFACTURING/23.100.001";
		}
	}
}