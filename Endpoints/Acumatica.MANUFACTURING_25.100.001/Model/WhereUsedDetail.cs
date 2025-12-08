using System;
using System.Collections.Generic;
using System.Runtime.Serialization;

using Newtonsoft.Json;

using Acumatica.RESTClient.Client;
using Acumatica.RESTClient.ContractBasedApi;
using Acumatica.RESTClient.ContractBasedApi.Model;

namespace Acumatica.MANUFACTURING_25_100_001.Model
{
	[DataContract]
	public class WhereUsedDetail : Entity
	{

		[DataMember(Name="Active", EmitDefaultValue=false)]
		public BooleanValue? Active { get; set; }

		/// <summary>
		/// A Boolean value that indicates whether a labor transaction is needed to report labor hours spent for the operation.
		/// <para>DAC Field Name: BFlush</para>
		/// <para>DAC: PX.Objects.AM.AMBomOper</para>
		/// <para>Display Name: Backflush Labor</para>
		/// </summary>
		[DataMember(Name="BackflushLabor", EmitDefaultValue=false)]
		public BooleanValue? BackflushLabor { get; set; }

		[DataMember(Name="BOMID", EmitDefaultValue=false)]
		public StringValue? BOMID { get; set; }

		/// <summary>
		/// <para>DAC Field Name: AMBomItem__BOMID</para>
		/// <para>DAC: PX.Objects.AM.AMBomOper</para>
		/// </summary>
		[DataMember(Name="BOMIDAMBomItem__BOMID", EmitDefaultValue=false)]
		public StringValue? BOMIDAMBomItem__BOMID { get; set; }

		/// <summary>
		/// <para>DAC Field Name: AMBomItem__RevisionID</para>
		/// <para>DAC: PX.Objects.AM.AMBomOper</para>
		/// </summary>
		[DataMember(Name="BomRevision", EmitDefaultValue=false)]
		public StringValue? BomRevision { get; set; }

		/// <summary>
		/// <para>DAC Field Name: AMBomItem__SiteID</para>
		/// <para>DAC: PX.Objects.AM.AMBomOper</para>
		/// </summary>
		[DataMember(Name="BomWarehouse", EmitDefaultValue=false)]
		public StringValue? BomWarehouse { get; set; }

		/// <summary>
		/// <para>DAC Field Name: AMBomItem__EffEndDate</para>
		/// <para>DAC: PX.Objects.AM.AMBomOper</para>
		/// </summary>
		[DataMember(Name="EndDate", EmitDefaultValue=false)]
		public DateTimeValue? EndDate { get; set; }

		/// <summary>
		/// <para>DAC Field Name: AMBomItem__InventoryID</para>
		/// <para>DAC: PX.Objects.AM.AMBomOper</para>
		/// </summary>
		[DataMember(Name="InventoryID", EmitDefaultValue=false)]
		public StringValue? InventoryID { get; set; }

		/// <summary>
		/// <para>DAC Field Name: Descr</para>
		/// <para>DAC: PX.Objects.AM.AMWC</para>
		/// <para>Display Name: Description</para>
		/// <para>SQL Type: nvarchar(256)</para>
		/// </summary>
		[DataMember(Name="OperationDescription", EmitDefaultValue=false)]
		public StringValue? OperationDescription { get; set; }

		[DataMember(Name="OperationIDOperationID", EmitDefaultValue=false)]
		public IntValue? OperationIDOperationID { get; set; }

		/// <summary>
		/// The numeric identifier of the operation, which is displayed in the operation.
		/// <para>DAC Field Name: OperationCD</para>
		/// <para>DAC: PX.Objects.AM.AMBomOper</para>
		/// <para>Display Name: Operation ID</para>
		/// <para>SQL Type: nvarchar(10)</para>
		/// Key Field
		/// </summary>
		[DataMember(Name="OperationNbr", EmitDefaultValue=false)]
		public StringValue? OperationNbr { get; set; }

		/// <summary>
		/// <para>DAC Field Name: ScrapAction</para>
		/// <para>DAC: PX.Objects.AM.AMWC</para>
		/// <para>Display Name: Scrap Action Default</para>
		/// </summary>
		[DataMember(Name="OperationScrapAction", EmitDefaultValue=false)]
		public StringValue? OperationScrapAction { get; set; }

		/// <summary>
		/// The outside process.
		/// <para>DAC: PX.Objects.AM.AMBomOper</para>
		/// <para>Display Name: Outside Process</para>
		/// </summary>
		[DataMember(Name="OutsideProcess", EmitDefaultValue=false)]
		public BooleanValue? OutsideProcess { get; set; }

		[DataMember(Name="RevisionRevisionID", EmitDefaultValue=false)]
		public StringValue? RevisionRevisionID { get; set; }

		/// <summary>
		/// <para>DAC Field Name: AMBomItem__EffStartDate</para>
		/// <para>DAC: PX.Objects.AM.AMBomOper</para>
		/// </summary>
		[DataMember(Name="StartDate", EmitDefaultValue=false)]
		public DateTimeValue? StartDate { get; set; }

		/// <summary>
		/// <para>DAC Field Name: AMBomItem__Status</para>
		/// <para>DAC: PX.Objects.AM.AMBomOper</para>
		/// </summary>
		[DataMember(Name="Status", EmitDefaultValue=false)]
		public StringValue? Status { get; set; }

	}
}