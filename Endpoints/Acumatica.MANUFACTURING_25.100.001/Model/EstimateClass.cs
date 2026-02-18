using System;
using System.Collections.Generic;

using Newtonsoft.Json;

using Acumatica.RESTClient.Client;
using Acumatica.RESTClient.ContractBasedApi;
using Acumatica.RESTClient.ContractBasedApi.Model;

namespace Acumatica.MANUFACTURING_25_100_001.Model
{
	/// <summary>
	/// Corresponds to the screen <c>AM206000</c> in the Acumatica ERP
	/// <para>Key Fields: ClassID</para>
	/// </summary>
	public class EstimateClass : Entity, ITopLevelEntity
	{

		/// <summary>
		/// <para>DAC Field Name: EstimateClassID</para>
		/// <para>DAC: PX.Objects.AM.AMEstimateClass</para>
		/// <para>Display Name: Class ID</para>
		/// <para>SQL Type: nvarchar(20)</para>
		/// Key Field
		/// </summary>
		public StringValue? ClassID { get; set; }

		/// <summary>
		/// <para>DAC: PX.Objects.AM.AMEstimateClass</para>
		/// <para>SQL Type: nvarchar(256)</para>
		/// </summary>
		public StringValue? Description { get; set; }

		/// <summary>
		/// <para>DAC Field Name: EngineerID</para>
		/// <para>DAC: PX.Objects.AM.AMEstimateClass</para>
		/// </summary>
		public StringValue? Engineer { get; set; }

		/// <summary>
		/// <para>DAC Field Name: ItemClassID</para>
		/// <para>DAC: PX.Objects.AM.AMEstimateClass</para>
		/// <para>Display Name: Item Class</para>
		/// </summary>
		public StringValue? ItemClass { get; set; }

		/// <summary>
		/// <para>DAC: PX.Objects.AM.AMEstimateClass</para>
		/// <para>Display Name: Labor Markup (%)</para>
		/// </summary>
		public DecimalValue? LaborMarkupPct { get; set; }

		/// <summary>
		/// <para>DAC Field Name: LeadTime</para>
		/// <para>DAC: PX.Objects.AM.AMEstimateClass</para>
		/// <para>Display Name: Lead Time (Days)</para>
		/// </summary>
		public IntValue? LeadTimeDays { get; set; }

		/// <summary>
		/// <para>DAC: PX.Objects.AM.AMEstimateClass</para>
		/// <para>Display Name: Machine Markup (%)</para>
		/// </summary>
		public DecimalValue? MachineMarkupPct { get; set; }

		/// <summary>
		/// <para>DAC: PX.Objects.AM.AMEstimateClass</para>
		/// <para>Display Name: Material Markup (%)</para>
		/// </summary>
		public DecimalValue? MaterialMarkupPct { get; set; }

		/// <summary>
		/// <para>DAC: PX.Objects.AM.AMEstimateClass</para>
		/// <para>Display Name: Order Qty.</para>
		/// </summary>
		public DecimalValue? OrderQty { get; set; }

		/// <summary>
		/// <para>DAC: PX.Objects.AM.AMEstimateClass</para>
		/// <para>Display Name: Overhead Markup (%)</para>
		/// </summary>
		public DecimalValue? OverheadMarkupPct { get; set; }

		/// <summary>
		/// <para>DAC: PX.Objects.AM.AMEstimateClass</para>
		/// <para>Display Name: Subcontract Markup (%)</para>
		/// </summary>
		public DecimalValue? SubcontractMarkupPct { get; set; }

		/// <summary>
		/// <para>DAC Field Name: TaxCategoryID</para>
		/// <para>DAC: PX.Objects.AM.AMEstimateClass</para>
		/// <para>Display Name: Tax Category</para>
		/// <para>SQL Type: nvarchar(15)</para>
		/// </summary>
		public StringValue? TaxCategory { get; set; }

		/// <summary>
		/// <para>DAC: PX.Objects.AM.AMEstimateClass</para>
		/// <para>Display Name: Tool Markup (%)</para>
		/// </summary>
		public DecimalValue? ToolMarkupPct { get; set; }

		public static class Expand
		{
			public const string Files = "Files";
			public const string Translations = "Translations";

			//Intentionally excluded
			//public const string All = "Files,Translations";
		}
		public virtual string GetEndpointPath()
		{
			return "entity/MANUFACTURING/25.100.001";
		}
	}
}