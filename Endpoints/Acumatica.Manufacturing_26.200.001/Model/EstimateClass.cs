using System;
using System.Collections.Generic;
using System.Runtime.Serialization;

using Newtonsoft.Json;

using Acumatica.RESTClient.Client;
using Acumatica.RESTClient.ContractBasedApi;
using Acumatica.RESTClient.ContractBasedApi.Model;

namespace Acumatica.Manufacturing_26_200_001.Model
{
	/// <summary>
	/// Corresponds to the screen <c>AM206000</c> in the Acumatica ERP
	/// <para>Key Fields: ClassID</para>
	/// </summary>
	[DataContract]
	public class EstimateClass : Entity, ITopLevelEntity
	{

		/// <summary>
		/// <para>DAC Field Name: EstimateClassID</para>
		/// <para>DAC: PX.Objects.AM.AMEstimateClass</para>
		/// <para>Display Name: Class ID</para>
		/// <para>SQL Type: nvarchar(20)</para>
		/// Key Field
		/// </summary>
		[DataMember(Name="ClassID", EmitDefaultValue=false)]
		public StringValue? ClassID { get; set; }

		/// <summary>
		/// <para>DAC: PX.Objects.AM.AMEstimateClass</para>
		/// <para>SQL Type: nvarchar(256)</para>
		/// </summary>
		[DataMember(Name="Description", EmitDefaultValue=false)]
		public StringValue? Description { get; set; }

		/// <summary>
		/// <para>DAC Field Name: EngineerID</para>
		/// <para>DAC: PX.Objects.AM.AMEstimateClass</para>
		/// </summary>
		[DataMember(Name="Engineer", EmitDefaultValue=false)]
		public StringValue? Engineer { get; set; }

		/// <summary>
		/// <para>DAC Field Name: ItemClassID</para>
		/// <para>DAC: PX.Objects.AM.AMEstimateClass</para>
		/// <para>Display Name: Item Class</para>
		/// </summary>
		[DataMember(Name="ItemClass", EmitDefaultValue=false)]
		public StringValue? ItemClass { get; set; }

		/// <summary>
		/// <para>DAC: PX.Objects.AM.AMEstimateClass</para>
		/// <para>Display Name: Labor Markup (%)</para>
		/// </summary>
		[DataMember(Name="LaborMarkupPct", EmitDefaultValue=false)]
		public DecimalValue? LaborMarkupPct { get; set; }

		/// <summary>
		/// <para>DAC Field Name: LeadTime</para>
		/// <para>DAC: PX.Objects.AM.AMEstimateClass</para>
		/// <para>Display Name: Lead Time (Days)</para>
		/// </summary>
		[DataMember(Name="LeadTimeDays", EmitDefaultValue=false)]
		public IntValue? LeadTimeDays { get; set; }

		/// <summary>
		/// <para>DAC: PX.Objects.AM.AMEstimateClass</para>
		/// <para>Display Name: Machine Markup (%)</para>
		/// </summary>
		[DataMember(Name="MachineMarkupPct", EmitDefaultValue=false)]
		public DecimalValue? MachineMarkupPct { get; set; }

		/// <summary>
		/// <para>DAC: PX.Objects.AM.AMEstimateClass</para>
		/// <para>Display Name: Material Markup (%)</para>
		/// </summary>
		[DataMember(Name="MaterialMarkupPct", EmitDefaultValue=false)]
		public DecimalValue? MaterialMarkupPct { get; set; }

		/// <summary>
		/// <para>DAC: PX.Objects.AM.AMEstimateClass</para>
		/// <para>Display Name: Order Qty.</para>
		/// </summary>
		[DataMember(Name="OrderQty", EmitDefaultValue=false)]
		public DecimalValue? OrderQty { get; set; }

		/// <summary>
		/// <para>DAC: PX.Objects.AM.AMEstimateClass</para>
		/// <para>Display Name: Overhead Markup (%)</para>
		/// </summary>
		[DataMember(Name="OverheadMarkupPct", EmitDefaultValue=false)]
		public DecimalValue? OverheadMarkupPct { get; set; }

		/// <summary>
		/// <para>DAC: PX.Objects.AM.AMEstimateClass</para>
		/// <para>Display Name: Subcontract Markup (%)</para>
		/// </summary>
		[DataMember(Name="SubcontractMarkupPct", EmitDefaultValue=false)]
		public DecimalValue? SubcontractMarkupPct { get; set; }

		/// <summary>
		/// <para>DAC Field Name: TaxCategoryID</para>
		/// <para>DAC: PX.Objects.AM.AMEstimateClass</para>
		/// <para>Display Name: Tax Category</para>
		/// <para>SQL Type: nvarchar(15)</para>
		/// </summary>
		[DataMember(Name="TaxCategory", EmitDefaultValue=false)]
		public StringValue? TaxCategory { get; set; }

		/// <summary>
		/// <para>DAC: PX.Objects.AM.AMEstimateClass</para>
		/// <para>Display Name: Tool Markup (%)</para>
		/// </summary>
		[DataMember(Name="ToolMarkupPct", EmitDefaultValue=false)]
		public DecimalValue? ToolMarkupPct { get; set; }

		/// <summary>
		/// Names that can be passed in the <c>$expand</c> parameter.
		/// <para>This endpoint uses system contract 5, where a nested entity is expanded
		/// as <c>Parent($expand=Child)</c> rather than <c>Parent/Child</c>, so only the names
		/// that can be expanded directly on this entity are listed here. Use the nested
		/// entity's own <c>Expand</c> class for the inner names.</para>
		/// </summary>
		public static class Expand
		{
			public const string Files = "Files";
			public const string Translations = "Translations";

			//Intentionally excluded
			//public const string All = "Files,Translations";
		}
		public virtual string GetEndpointPath()
		{
			return "entity/MANUFACTURING/26.200.001";
		}
	}
}