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
	public class ProductionPreferences : Entity, ITopLevelEntity
	{

		[DataMember(Name="BlockSize", EmitDefaultValue=false)]
		public StringValue? BlockSize { get; set; }

		[DataMember(Name="CapabletoPromiseOrderType", EmitDefaultValue=false)]
		public StringValue? CapabletoPromiseOrderType { get; set; }

		[DataMember(Name="CostNumberingSequence", EmitDefaultValue=false)]
		public StringValue? CostNumberingSequence { get; set; }

		[DataMember(Name="DataCollectionSettings", EmitDefaultValue=false)]
		public ProductionDataCollectionSettings? DataCollectionSettings { get; set; }

		[DataMember(Name="DefaultDisassembleOrderType", EmitDefaultValue=false)]
		public StringValue? DefaultDisassembleOrderType { get; set; }

		[DataMember(Name="DefaultMoveTime", EmitDefaultValue=false)]
		public StringValue? DefaultMoveTime { get; set; }

		[DataMember(Name="DefaultOrderType", EmitDefaultValue=false)]
		public StringValue? DefaultOrderType { get; set; }

		[DataMember(Name="DefaultUserEmployeeID", EmitDefaultValue=false)]
		public BooleanValue? DefaultUserEmployeeID { get; set; }

		[DataMember(Name="DisassemblyNumberingSequence", EmitDefaultValue=false)]
		public StringValue? DisassemblyNumberingSequence { get; set; }

		[DataMember(Name="FixedMfgCalendarID", EmitDefaultValue=false)]
		public StringValue? FixedMfgCalendarID { get; set; }

		[DataMember(Name="FixedMfgUnits", EmitDefaultValue=false)]
		public StringValue? FixedMfgUnits { get; set; }

		[DataMember(Name="HoldDocumentsonEntry", EmitDefaultValue=false)]
		public BooleanValue? HoldDocumentsonEntry { get; set; }

		[DataMember(Name="HoldShipmentsonEntry", EmitDefaultValue=false)]
		public BooleanValue? HoldShipmentsonEntry { get; set; }

		[DataMember(Name="IncludeScrapinCompletions", EmitDefaultValue=false)]
		public BooleanValue? IncludeScrapinCompletions { get; set; }

		[DataMember(Name="LaborNumberingSequence", EmitDefaultValue=false)]
		public StringValue? LaborNumberingSequence { get; set; }

		[DataMember(Name="MachineScheduling", EmitDefaultValue=false)]
		public BooleanValue? MachineScheduling { get; set; }

		[DataMember(Name="MaterialNumberingSequence", EmitDefaultValue=false)]
		public StringValue? MaterialNumberingSequence { get; set; }

		[DataMember(Name="MoveNumberingSequence", EmitDefaultValue=false)]
		public StringValue? MoveNumberingSequence { get; set; }

		[DataMember(Name="PostSummaryonUpdatingGL", EmitDefaultValue=false)]
		public BooleanValue? PostSummaryonUpdatingGL { get; set; }

		[DataMember(Name="RestrictClockEntrytoCurrentUser", EmitDefaultValue=false)]
		public BooleanValue? RestrictClockEntrytoCurrentUser { get; set; }

		[DataMember(Name="ToolScheduling", EmitDefaultValue=false)]
		public BooleanValue? ToolScheduling { get; set; }

		[DataMember(Name="UseFixedManufacturingTimes", EmitDefaultValue=false)]
		public BooleanValue? UseFixedManufacturingTimes { get; set; }

		[DataMember(Name="UseLaborRate", EmitDefaultValue=false)]
		public StringValue? UseLaborRate { get; set; }

		[DataMember(Name="UseOrderStartDateforMRP", EmitDefaultValue=false)]
		public BooleanValue? UseOrderStartDateforMRP { get; set; }

		[DataMember(Name="UseShiftCrewSize", EmitDefaultValue=false)]
		public BooleanValue? UseShiftCrewSize { get; set; }

		[DataMember(Name="ValidateDocumentTotalsonEntry", EmitDefaultValue=false)]
		public BooleanValue? ValidateDocumentTotalsonEntry { get; set; }

		[DataMember(Name="ValidateShipmentTotalonConfirmation", EmitDefaultValue=false)]
		public BooleanValue? ValidateShipmentTotalonConfirmation { get; set; }

		[DataMember(Name="VendorShipmentNumberingSequence", EmitDefaultValue=false)]
		public StringValue? VendorShipmentNumberingSequence { get; set; }

		[DataMember(Name="WipAdjustNumberingSequence", EmitDefaultValue=false)]
		public StringValue? WipAdjustNumberingSequence { get; set; }

		public virtual string GetEndpointPath()
		{
			return "entity/MANUFACTURING/21.200.001";
		}
	}
}