using System;
using System.Collections.Generic;
using System.Runtime.Serialization;

using Newtonsoft.Json;

using Acumatica.RESTClient.Client;
using Acumatica.RESTClient.ContractBasedApi;
using Acumatica.RESTClient.ContractBasedApi.Model;

namespace Acumatica.Manufacturing_23_200_001.Model
{
	/// <summary>
	/// Corresponds to the screen AM206000 in the Acumatica ERP
	/// </summary>
	[DataContract]
	public class EstimateClass : Entity, ITopLevelEntity
	{

		/// <summary>
		/// DAC Field Name: EstimateClassID 
		/// DAC: PX.Objects.AM.AMEstimateClass 
		/// Display Name: Class ID 
		/// SQL Type: nvarchar(20) 
		/// Key Field
		/// </summary>
		[DataMember(Name="ClassID", EmitDefaultValue=false)]
		public StringValue? ClassID { get; set; }

		/// <summary>
		/// DAC: PX.Objects.AM.AMEstimateClass 
		/// SQL Type: nvarchar(256) 
		/// </summary>
		[DataMember(Name="Description", EmitDefaultValue=false)]
		public StringValue? Description { get; set; }

		/// <summary>
		/// DAC Field Name: EngineerID 
		/// DAC: PX.Objects.AM.AMEstimateClass 
		/// </summary>
		[DataMember(Name="Engineer", EmitDefaultValue=false)]
		public StringValue? Engineer { get; set; }

		/// <summary>
		/// DAC Field Name: ItemClassID 
		/// DAC: PX.Objects.AM.AMEstimateClass 
		/// Display Name: Item Class 
		/// </summary>
		[DataMember(Name="ItemClass", EmitDefaultValue=false)]
		public StringValue? ItemClass { get; set; }

		/// <summary>
		/// DAC: PX.Objects.AM.AMEstimateClass 
		/// Display Name: Labor Markup (%) 
		/// </summary>
		[DataMember(Name="LaborMarkupPct", EmitDefaultValue=false)]
		public DecimalValue? LaborMarkupPct { get; set; }

		/// <summary>
		/// DAC Field Name: LeadTime 
		/// DAC: PX.Objects.AM.AMEstimateClass 
		/// Display Name: Lead Time (Days) 
		/// </summary>
		[DataMember(Name="LeadTimeDays", EmitDefaultValue=false)]
		public IntValue? LeadTimeDays { get; set; }

		/// <summary>
		/// DAC: PX.Objects.AM.AMEstimateClass 
		/// Display Name: Machine Markup (%) 
		/// </summary>
		[DataMember(Name="MachineMarkupPct", EmitDefaultValue=false)]
		public DecimalValue? MachineMarkupPct { get; set; }

		/// <summary>
		/// DAC: PX.Objects.AM.AMEstimateClass 
		/// Display Name: Material Markup (%) 
		/// </summary>
		[DataMember(Name="MaterialMarkupPct", EmitDefaultValue=false)]
		public DecimalValue? MaterialMarkupPct { get; set; }

		/// <summary>
		/// DAC: PX.Objects.AM.AMEstimateClass 
		/// Display Name: Order Qty 
		/// </summary>
		[DataMember(Name="OrderQty", EmitDefaultValue=false)]
		public DecimalValue? OrderQty { get; set; }

		/// <summary>
		/// DAC: PX.Objects.AM.AMEstimateClass 
		/// Display Name: Overhead Markup (%) 
		/// </summary>
		[DataMember(Name="OverheadMarkupPct", EmitDefaultValue=false)]
		public DecimalValue? OverheadMarkupPct { get; set; }

		/// <summary>
		/// DAC: PX.Objects.AM.AMEstimateClass 
		/// Display Name: Subcontract Markup (%) 
		/// </summary>
		[DataMember(Name="SubcontractMarkupPct", EmitDefaultValue=false)]
		public DecimalValue? SubcontractMarkupPct { get; set; }

		/// <summary>
		/// DAC Field Name: TaxCategoryID 
		/// DAC: PX.Objects.AM.AMEstimateClass 
		/// Display Name: Tax Category 
		/// SQL Type: nvarchar(15) 
		/// </summary>
		[DataMember(Name="TaxCategory", EmitDefaultValue=false)]
		public StringValue? TaxCategory { get; set; }

		/// <summary>
		/// DAC: PX.Objects.AM.AMEstimateClass 
		/// Display Name: Tool Markup (%) 
		/// </summary>
		[DataMember(Name="ToolMarkupPct", EmitDefaultValue=false)]
		public DecimalValue? ToolMarkupPct { get; set; }

		public virtual string GetEndpointPath()
		{
			return "entity/MANUFACTURING/23.200.001";
		}
	}
}