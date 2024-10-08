using System;
using System.Collections.Generic;
using System.Runtime.Serialization;

using Newtonsoft.Json;

using Acumatica.RESTClient.Client;
using Acumatica.RESTClient.ContractBasedApi;
using Acumatica.RESTClient.ContractBasedApi.Model;

namespace Acumatica.Manufacturing_24_200_001.Model
{
	[DataContract]
	public class OperationDetail : Entity
	{

		/// <summary>
		/// A Boolean value that indicates whether a labor transaction is needed to report labor hours spent for the operation.
		/// DAC Field Name: BFlush 
		/// DAC: PX.Objects.AM.AMBomOper 
		/// Display Name: Backflush Labor 
		/// </summary>
		[DataMember(Name="BackflushLabor", EmitDefaultValue=false)]
		public BooleanValue? BackflushLabor { get; set; }

		/// <summary>
		/// The identifier of the bill of material.
		/// DAC: PX.Objects.AM.AMBomItem 
		/// Display Name: BOM ID 
		/// SQL Type: nvarchar(15) 
		/// Key Field
		/// </summary>
		[DataMember(Name="BOMID", EmitDefaultValue=false)]
		public StringValue? BOMID { get; set; }

		/// <summary>
		/// A Boolean value that indicates whether the operation is a control point.
		/// DAC: PX.Objects.AM.AMBomOper 
		/// Display Name: Control Point 
		/// </summary>
		[DataMember(Name="ControlPoint", EmitDefaultValue=false)]
		public BooleanValue? ControlPoint { get; set; }

		/// <summary>
		/// A Boolean value that indicates whether the operation has been drop shipped to the vendor.
		/// DAC Field Name: DropShippedToVendor 
		/// DAC: PX.Objects.AM.AMBomOper 
		/// Display Name: Drop Shipped to Vendor 
		/// </summary>
		[DataMember(Name="DropShippedtoVendor", EmitDefaultValue=false)]
		public BooleanValue? DropShippedtoVendor { get; set; }

		[DataMember(Name="FinishTime", EmitDefaultValue=false)]
		public IntValue? FinishTime { get; set; }

		[DataMember(Name="MachineTime", EmitDefaultValue=false)]
		public IntValue? MachineTime { get; set; }

		/// <summary>
		/// The number of units produced during the specified machine time for the operation.
		/// DAC: PX.Objects.AM.AMBomOper 
		/// Display Name: Machine Units 
		/// </summary>
		[DataMember(Name="MachineUnits", EmitDefaultValue=false)]
		public DecimalValue? MachineUnits { get; set; }

		[DataMember(Name="Material", EmitDefaultValue=false)]
		public List<MaterialDetail>? Material { get; set; }

		[DataMember(Name="MoveTime", EmitDefaultValue=false)]
		public IntValue? MoveTime { get; set; }

		/// <summary>
		/// A description of the bill of material. The system copies the description to production orders that are created by using the bill of material.
		/// DAC Field Name: Descr 
		/// DAC: PX.Objects.AM.AMBomItem 
		/// Display Name: Description 
		/// SQL Type: nvarchar(256) 
		/// </summary>
		[DataMember(Name="OperationDescription", EmitDefaultValue=false)]
		public StringValue? OperationDescription { get; set; }

		/// <summary>
		/// The numeric identifier of the operation, which is displayed in the operation.
		/// DAC Field Name: OperationCD 
		/// DAC: PX.Objects.AM.AMBomOper 
		/// Display Name: Operation ID 
		/// SQL Type: nvarchar(10) 
		/// Key Field
		/// </summary>
		[DataMember(Name="OperationNbr", EmitDefaultValue=false)]
		public StringValue? OperationNbr { get; set; }

		/// <summary>
		/// The outside process.
		/// DAC: PX.Objects.AM.AMBomOper 
		/// Display Name: Outside Process 
		/// </summary>
		[DataMember(Name="OutsideProcess", EmitDefaultValue=false)]
		public BooleanValue? OutsideProcess { get; set; }

		[DataMember(Name="Overheads", EmitDefaultValue=false)]
		public List<BomOverheadDetail>? Overheads { get; set; }

		[DataMember(Name="QueueTime", EmitDefaultValue=false)]
		public IntValue? QueueTime { get; set; }

		/// <summary>
		/// The identifier of the BOM revision, which is the modification of the bill of material.
		/// DAC Field Name: RevisionID 
		/// DAC: PX.Objects.AM.AMBomItem 
		/// SQL Type: nvarchar(10) 
		/// Key Field
		/// </summary>
		[DataMember(Name="Revision", EmitDefaultValue=false)]
		public StringValue? Revision { get; set; }

		[DataMember(Name="RunTime", EmitDefaultValue=false)]
		public IntValue? RunTime { get; set; }

		/// <summary>
		/// The number of units produced during the specified run time for the operation.
		/// DAC: PX.Objects.AM.AMBomOper 
		/// Display Name: Run Units 
		/// </summary>
		[DataMember(Name="RunUnits", EmitDefaultValue=false)]
		public DecimalValue? RunUnits { get; set; }

		/// <summary>
		/// The default scrap action for the operation in new production orders.
		/// DAC: PX.Objects.AM.AMBomOper 
		/// Display Name: Scrap Action 
		/// </summary>
		[DataMember(Name="ScrapAction", EmitDefaultValue=false)]
		public StringValue? ScrapAction { get; set; }

		[DataMember(Name="SetupTime", EmitDefaultValue=false)]
		public IntValue? SetupTime { get; set; }

		[DataMember(Name="Steps", EmitDefaultValue=false)]
		public List<StepDetail>? Steps { get; set; }

		[DataMember(Name="Tools", EmitDefaultValue=false)]
		public List<ToolDetail>? Tools { get; set; }

		/// <summary>
		/// The vendor ID.
		/// DAC Field Name: VendorID 
		/// DAC: PX.Objects.AM.AMBomOperCury 
		/// </summary>
		[DataMember(Name="Vendor", EmitDefaultValue=false)]
		public StringValue? Vendor { get; set; }

		/// <summary>
		/// The vendor location.
		/// DAC Field Name: VendorLocationID 
		/// DAC: PX.Objects.AM.AMBomOperCury 
		/// Display Name: Vendor Location 
		/// </summary>
		[DataMember(Name="VendorLocation", EmitDefaultValue=false)]
		public StringValue? VendorLocation { get; set; }

		/// <summary>
		/// The active work center where the operation takes place.
		/// DAC Field Name: WcID 
		/// DAC: PX.Objects.AM.AMBomOper 
		/// Display Name: Work Center 
		/// SQL Type: nvarchar(20) 
		/// </summary>
		[DataMember(Name="WorkCenter", EmitDefaultValue=false)]
		public StringValue? WorkCenter { get; set; }

	}
}