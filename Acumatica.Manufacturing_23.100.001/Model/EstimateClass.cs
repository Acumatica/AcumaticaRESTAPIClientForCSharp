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
	/// Corresponds to the screen AM206000 in the Acumatica ERP
	/// </summary>
	[DataContract]
	public class EstimateClass : Entity, ITopLevelEntity
	{

		/// <summary>
		/// 
		/// Display Name:
		/// DAC Field Name: EstimateClassID 
		/// DAC: PX.Objects.AM.AMEstimateClass 
		/// </summary>
		/// <remarks>
		/// 
		/// </remarks>
		[DataMember(Name="ClassID", EmitDefaultValue=false)]
		public StringValue? ClassID { get; set; }

		/// <summary>
		/// 
		/// Display Name:
		/// DAC Field Name: Description 
		/// DAC: PX.Objects.AM.AMEstimateClass 
		/// </summary>
		/// <remarks>
		/// 
		/// </remarks>
		[DataMember(Name="Description", EmitDefaultValue=false)]
		public StringValue? Description { get; set; }

		/// <summary>
		/// 
		/// Display Name:
		/// DAC Field Name: EngineerID 
		/// DAC: PX.Objects.AM.AMEstimateClass 
		/// </summary>
		/// <remarks>
		/// 
		/// </remarks>
		[DataMember(Name="Engineer", EmitDefaultValue=false)]
		public StringValue? Engineer { get; set; }

		/// <summary>
		/// 
		/// Display Name:
		/// DAC Field Name: ItemClassID 
		/// DAC: PX.Objects.AM.AMEstimateClass 
		/// </summary>
		/// <remarks>
		/// 
		/// </remarks>
		[DataMember(Name="ItemClass", EmitDefaultValue=false)]
		public StringValue? ItemClass { get; set; }

		/// <summary>
		/// 
		/// Display Name:
		/// DAC Field Name: LaborMarkupPct 
		/// DAC: PX.Objects.AM.AMEstimateClass 
		/// </summary>
		/// <remarks>
		/// 
		/// </remarks>
		[DataMember(Name="LaborMarkupPct", EmitDefaultValue=false)]
		public DecimalValue? LaborMarkupPct { get; set; }

		/// <summary>
		/// 
		/// Display Name:
		/// DAC Field Name: LeadTime 
		/// DAC: PX.Objects.AM.AMEstimateClass 
		/// </summary>
		/// <remarks>
		/// 
		/// </remarks>
		[DataMember(Name="LeadTimeDays", EmitDefaultValue=false)]
		public IntValue? LeadTimeDays { get; set; }

		/// <summary>
		/// 
		/// Display Name:
		/// DAC Field Name: MachineMarkupPct 
		/// DAC: PX.Objects.AM.AMEstimateClass 
		/// </summary>
		/// <remarks>
		/// 
		/// </remarks>
		[DataMember(Name="MachineMarkupPct", EmitDefaultValue=false)]
		public DecimalValue? MachineMarkupPct { get; set; }

		/// <summary>
		/// 
		/// Display Name:
		/// DAC Field Name: MaterialMarkupPct 
		/// DAC: PX.Objects.AM.AMEstimateClass 
		/// </summary>
		/// <remarks>
		/// 
		/// </remarks>
		[DataMember(Name="MaterialMarkupPct", EmitDefaultValue=false)]
		public DecimalValue? MaterialMarkupPct { get; set; }

		/// <summary>
		/// 
		/// Display Name:
		/// DAC Field Name: OrderQty 
		/// DAC: PX.Objects.AM.AMEstimateClass 
		/// </summary>
		/// <remarks>
		/// 
		/// </remarks>
		[DataMember(Name="OrderQty", EmitDefaultValue=false)]
		public DecimalValue? OrderQty { get; set; }

		/// <summary>
		/// 
		/// Display Name:
		/// DAC Field Name: OverheadMarkupPct 
		/// DAC: PX.Objects.AM.AMEstimateClass 
		/// </summary>
		/// <remarks>
		/// 
		/// </remarks>
		[DataMember(Name="OverheadMarkupPct", EmitDefaultValue=false)]
		public DecimalValue? OverheadMarkupPct { get; set; }

		/// <summary>
		/// 
		/// Display Name:
		/// DAC Field Name: SubcontractMarkupPct 
		/// DAC: PX.Objects.AM.AMEstimateClass 
		/// </summary>
		/// <remarks>
		/// 
		/// </remarks>
		[DataMember(Name="SubcontractMarkupPct", EmitDefaultValue=false)]
		public DecimalValue? SubcontractMarkupPct { get; set; }

		/// <summary>
		/// 
		/// Display Name:
		/// DAC Field Name: TaxCategoryID 
		/// DAC: PX.Objects.AM.AMEstimateClass 
		/// </summary>
		/// <remarks>
		/// 
		/// </remarks>
		[DataMember(Name="TaxCategory", EmitDefaultValue=false)]
		public StringValue? TaxCategory { get; set; }

		/// <summary>
		/// 
		/// Display Name:
		/// DAC Field Name: ToolMarkupPct 
		/// DAC: PX.Objects.AM.AMEstimateClass 
		/// </summary>
		/// <remarks>
		/// 
		/// </remarks>
		[DataMember(Name="ToolMarkupPct", EmitDefaultValue=false)]
		public DecimalValue? ToolMarkupPct { get; set; }

		public virtual string GetEndpointPath()
		{
			return "entity/MANUFACTURING/23.100.001";
		}
	}
}