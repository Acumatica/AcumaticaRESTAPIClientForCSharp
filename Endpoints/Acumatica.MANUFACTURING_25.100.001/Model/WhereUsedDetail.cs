using System;
using System.Collections.Generic;

using Newtonsoft.Json;

using Acumatica.RESTClient.Client;
using Acumatica.RESTClient.ContractBasedApi;
using Acumatica.RESTClient.ContractBasedApi.Model;

namespace Acumatica.MANUFACTURING_25_100_001.Model
{
	public class WhereUsedDetail : Entity
	{

		public BooleanValue? Active { get; set; }

		/// <summary>
		/// A Boolean value that indicates whether a labor transaction is needed to report labor hours spent for the operation.
		/// <para>DAC Field Name: BFlush</para>
		/// <para>DAC: PX.Objects.AM.AMBomOper</para>
		/// <para>Display Name: Backflush Labor</para>
		/// </summary>
		public BooleanValue? BackflushLabor { get; set; }

		public StringValue? BOMID { get; set; }

		/// <summary>
		/// <para>DAC Field Name: AMBomItem__BOMID</para>
		/// <para>DAC: PX.Objects.AM.AMBomOper</para>
		/// </summary>
		public StringValue? BOMIDAMBomItem__BOMID { get; set; }

		/// <summary>
		/// <para>DAC Field Name: AMBomItem__RevisionID</para>
		/// <para>DAC: PX.Objects.AM.AMBomOper</para>
		/// </summary>
		public StringValue? BomRevision { get; set; }

		/// <summary>
		/// <para>DAC Field Name: AMBomItem__SiteID</para>
		/// <para>DAC: PX.Objects.AM.AMBomOper</para>
		/// </summary>
		public StringValue? BomWarehouse { get; set; }

		/// <summary>
		/// <para>DAC Field Name: AMBomItem__EffEndDate</para>
		/// <para>DAC: PX.Objects.AM.AMBomOper</para>
		/// </summary>
		public DateTimeValue? EndDate { get; set; }

		/// <summary>
		/// <para>DAC Field Name: AMBomItem__InventoryID</para>
		/// <para>DAC: PX.Objects.AM.AMBomOper</para>
		/// </summary>
		public StringValue? InventoryID { get; set; }

		/// <summary>
		/// <para>DAC Field Name: Descr</para>
		/// <para>DAC: PX.Objects.AM.AMWC</para>
		/// <para>Display Name: Description</para>
		/// <para>SQL Type: nvarchar(256)</para>
		/// </summary>
		public StringValue? OperationDescription { get; set; }

		public IntValue? OperationIDOperationID { get; set; }

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
		/// <para>DAC Field Name: ScrapAction</para>
		/// <para>DAC: PX.Objects.AM.AMWC</para>
		/// <para>Display Name: Scrap Action Default</para>
		/// </summary>
		public StringValue? OperationScrapAction { get; set; }

		/// <summary>
		/// The outside process.
		/// <para>DAC: PX.Objects.AM.AMBomOper</para>
		/// <para>Display Name: Outside Process</para>
		/// </summary>
		public BooleanValue? OutsideProcess { get; set; }

		public StringValue? RevisionRevisionID { get; set; }

		/// <summary>
		/// <para>DAC Field Name: AMBomItem__EffStartDate</para>
		/// <para>DAC: PX.Objects.AM.AMBomOper</para>
		/// </summary>
		public DateTimeValue? StartDate { get; set; }

		/// <summary>
		/// <para>DAC Field Name: AMBomItem__Status</para>
		/// <para>DAC: PX.Objects.AM.AMBomOper</para>
		/// </summary>
		public StringValue? Status { get; set; }

	}
}