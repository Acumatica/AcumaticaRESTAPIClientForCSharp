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
	public class WhereUsedDetail : Entity
	{

		[DataMember(Name="Active", EmitDefaultValue=false)]
		public BooleanValue? Active { get; set; }

		/// <summary>
		/// A Boolean value that indicates whether a labor transaction is needed to report labor hours spent for the operation.
		/// DAC Field Name: BFlush 
		/// DAC: PX.Objects.AM.AMBomOper 
		/// Display Name: Backflush Labor 
		/// </summary>
		[DataMember(Name="BackflushLabor", EmitDefaultValue=false)]
		public BooleanValue? BackflushLabor { get; set; }

		[DataMember(Name="BOMID", EmitDefaultValue=false)]
		public StringValue? BOMID { get; set; }

		/// <summary>
		/// DAC Field Name: AMBomItem__BOMID 
		/// DAC: PX.Objects.AM.AMBomOper 
		/// </summary>
		[DataMember(Name="BOMIDAMBomItem__BOMID", EmitDefaultValue=false)]
		public StringValue? BOMIDAMBomItem__BOMID { get; set; }

		/// <summary>
		/// DAC Field Name: AMBomItem__RevisionID 
		/// DAC: PX.Objects.AM.AMBomOper 
		/// </summary>
		[DataMember(Name="BomRevision", EmitDefaultValue=false)]
		public StringValue? BomRevision { get; set; }

		/// <summary>
		/// DAC Field Name: AMBomItem__SiteID 
		/// DAC: PX.Objects.AM.AMBomOper 
		/// </summary>
		[DataMember(Name="BomWarehouse", EmitDefaultValue=false)]
		public StringValue? BomWarehouse { get; set; }

		/// <summary>
		/// DAC Field Name: AMBomItem__EffEndDate 
		/// DAC: PX.Objects.AM.AMBomOper 
		/// </summary>
		[DataMember(Name="EndDate", EmitDefaultValue=false)]
		public DateTimeValue? EndDate { get; set; }

		/// <summary>
		/// DAC Field Name: AMBomItem__InventoryID 
		/// DAC: PX.Objects.AM.AMBomOper 
		/// </summary>
		[DataMember(Name="InventoryID", EmitDefaultValue=false)]
		public StringValue? InventoryID { get; set; }

		/// <summary>
		/// DAC Field Name: Descr 
		/// DAC: PX.Objects.AM.AMWC 
		/// Display Name: Description 
		/// SQL Type: nvarchar(256) 
		/// </summary>
		[DataMember(Name="OperationDescription", EmitDefaultValue=false)]
		public StringValue? OperationDescription { get; set; }

		[DataMember(Name="OperationIDOperationID", EmitDefaultValue=false)]
		public IntValue? OperationIDOperationID { get; set; }

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
		/// DAC Field Name: ScrapAction 
		/// DAC: PX.Objects.AM.AMWC 
		/// Display Name: Scrap Action Default 
		/// </summary>
		[DataMember(Name="OperationScrapAction", EmitDefaultValue=false)]
		public StringValue? OperationScrapAction { get; set; }

		/// <summary>
		/// The outside process.
		/// DAC: PX.Objects.AM.AMBomOper 
		/// Display Name: Outside Process 
		/// </summary>
		[DataMember(Name="OutsideProcess", EmitDefaultValue=false)]
		public BooleanValue? OutsideProcess { get; set; }

		[DataMember(Name="RevisionRevisionID", EmitDefaultValue=false)]
		public StringValue? RevisionRevisionID { get; set; }

		/// <summary>
		/// DAC Field Name: AMBomItem__EffStartDate 
		/// DAC: PX.Objects.AM.AMBomOper 
		/// </summary>
		[DataMember(Name="StartDate", EmitDefaultValue=false)]
		public DateTimeValue? StartDate { get; set; }

		/// <summary>
		/// DAC Field Name: AMBomItem__Status 
		/// DAC: PX.Objects.AM.AMBomOper 
		/// </summary>
		[DataMember(Name="Status", EmitDefaultValue=false)]
		public StringValue? Status { get; set; }

	}
}