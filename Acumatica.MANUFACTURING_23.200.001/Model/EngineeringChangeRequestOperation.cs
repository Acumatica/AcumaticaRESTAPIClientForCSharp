using System;
using System.Collections.Generic;
using System.Runtime.Serialization;

using Newtonsoft.Json;

using Acumatica.RESTClient.Client;
using Acumatica.RESTClient.ContractBasedApi;
using Acumatica.RESTClient.ContractBasedApi.Model;

namespace Acumatica.Manufacturing_23_200_001.Model
{
	[DataContract]
	public class EngineeringChangeRequestOperation : Entity
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
		/// The change status.
		/// DAC Field Name: RowStatus 
		/// DAC: PX.Objects.AM.AMBomOper 
		/// Display Name: Change Status 
		/// </summary>
		[DataMember(Name="ChangeStatus", EmitDefaultValue=false)]
		public StringValue? ChangeStatus { get; set; }

		/// <summary>
		/// A Boolean value that indicates whether the operation has been drop shipped to the vendor.
		/// DAC Field Name: DropShippedToVendor 
		/// DAC: PX.Objects.AM.AMBomOper 
		/// Display Name: Drop Shipped to Vendor 
		/// </summary>
		[DataMember(Name="DropShippedtoVendor", EmitDefaultValue=false)]
		public BooleanValue? DropShippedtoVendor { get; set; }

		/// <summary>
		/// DAC Field Name: BOMID 
		/// DAC: PX.Objects.AM.AMECRItem 
		/// Display Name: BOM ID 
		/// SQL Type: nvarchar(15) 
		/// </summary>
		[DataMember(Name="ECRID", EmitDefaultValue=false)]
		public StringValue? ECRID { get; set; }

		/// <summary>
		/// The time required for the semi-finished item to be prepared for the next operation when the current operation has been finished.
		/// DAC: PX.Objects.AM.AMBomOper 
		/// Display Name: Finish Time 
		/// </summary>
		[DataMember(Name="FinishTime", EmitDefaultValue=false)]
		public StringValue? FinishTime { get; set; }

		/// <summary>
		/// The time required to produce the number of machine units specified for the operation.
		/// DAC Field Name: MachineUnitTime 
		/// DAC: PX.Objects.AM.AMBomOper 
		/// Display Name: Machine Time 
		/// </summary>
		[DataMember(Name="MachineTime", EmitDefaultValue=false)]
		public StringValue? MachineTime { get; set; }

		/// <summary>
		/// The number of units produced during the specified machine time for the operation.
		/// DAC: PX.Objects.AM.AMBomOper 
		/// Display Name: Machine Units 
		/// </summary>
		[DataMember(Name="MachineUnits", EmitDefaultValue=false)]
		public DecimalValue? MachineUnits { get; set; }

		[DataMember(Name="Material", EmitDefaultValue=false)]
		public List<EngineeringChangeRequestMaterial>? Material { get; set; }

		/// <summary>
		/// The numeric identifier of the operation, which is displayed in the operation.
		/// DAC Field Name: OperationCD 
		/// DAC: PX.Objects.AM.AMBomOper 
		/// Display Name: Operation ID 
		/// SQL Type: nvarchar(10) 
		/// Key Field
		/// </summary>
		[DataMember(Name="OperationID", EmitDefaultValue=false)]
		public StringValue? OperationID { get; set; }

		/// <summary>
		/// DAC Field Name: Descr 
		/// DAC: PX.Objects.AM.AMECRItem 
		/// Display Name: Description 
		/// SQL Type: nvarchar(256) 
		/// </summary>
		[DataMember(Name="OperDesc", EmitDefaultValue=false)]
		public StringValue? OperDesc { get; set; }

		/// <summary>
		/// The outside process.
		/// DAC: PX.Objects.AM.AMBomOper 
		/// Display Name: Outside Process 
		/// </summary>
		[DataMember(Name="OutsideProcess", EmitDefaultValue=false)]
		public BooleanValue? OutsideProcess { get; set; }

		[DataMember(Name="Overheads", EmitDefaultValue=false)]
		public List<EngineeringChangeRequestOverhead>? Overheads { get; set; }

		/// <summary>
		/// The time a semi-finished item has to wait in the work center before workers can start processing the item.
		/// DAC: PX.Objects.AM.AMBomOper 
		/// Display Name: Queue Time 
		/// </summary>
		[DataMember(Name="QueueTime", EmitDefaultValue=false)]
		public StringValue? QueueTime { get; set; }

		/// <summary>
		/// DAC Field Name: RevisionID 
		/// DAC: PX.Objects.AM.AMECRItem 
		/// SQL Type: nvarchar(10) 
		/// </summary>
		[DataMember(Name="Revision", EmitDefaultValue=false)]
		public StringValue? Revision { get; set; }

		/// <summary>
		/// The time required to produce the specified run units of the operation.
		/// DAC Field Name: RunUnitTime 
		/// DAC: PX.Objects.AM.AMBomOper 
		/// Display Name: Run Time 
		/// </summary>
		[DataMember(Name="RunTime", EmitDefaultValue=false)]
		public StringValue? RunTime { get; set; }

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

		/// <summary>
		/// The time it takes to prepare to start the operation.
		/// DAC: PX.Objects.AM.AMBomOper 
		/// Display Name: Setup Time 
		/// </summary>
		[DataMember(Name="SetupTime", EmitDefaultValue=false)]
		public StringValue? SetupTime { get; set; }

		[DataMember(Name="Steps", EmitDefaultValue=false)]
		public List<EngineeringChangeRequestStep>? Steps { get; set; }

		[DataMember(Name="Tools", EmitDefaultValue=false)]
		public List<EngineeringChangeRequestTools>? Tools { get; set; }

		/// <summary>
		/// The vendor.
		/// DAC Field Name: VendorID 
		/// DAC: PX.Objects.AM.AMBomOper 
		/// </summary>
		[DataMember(Name="Vendor", EmitDefaultValue=false)]
		public StringValue? Vendor { get; set; }

		/// <summary>
		/// The vendor location.
		/// DAC Field Name: VendorLocationID 
		/// DAC: PX.Objects.AM.AMBomOper 
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