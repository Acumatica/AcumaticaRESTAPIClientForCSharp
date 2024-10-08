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
	/// Corresponds to the screen AM205500 in the Acumatica ERP
	/// </summary>
	[DataContract]
	public class Tool : Entity, ITopLevelEntity
	{

		/// <summary>
		/// DAC Field Name: AcctID 
		/// DAC: PX.Objects.AM.AMToolMst 
		/// </summary>
		[DataMember(Name="Account", EmitDefaultValue=false)]
		public StringValue? Account { get; set; }

		/// <summary>
		/// DAC: PX.Objects.AM.AMToolMst 
		/// </summary>
		[DataMember(Name="Active", EmitDefaultValue=false)]
		public BooleanValue? Active { get; set; }

		/// <summary>
		/// DAC Field Name: ActualCost 
		/// DAC: PX.Objects.AM.AMToolMstCurySettings 
		/// Display Name: Consumed Cost 
		/// </summary>
		[DataMember(Name="ConsumedCost", EmitDefaultValue=false)]
		public DecimalValue? ConsumedCost { get; set; }

		/// <summary>
		/// DAC Field Name: Descr 
		/// DAC: PX.Objects.AM.AMToolMst 
		/// SQL Type: nvarchar(256) 
		/// </summary>
		[DataMember(Name="Description", EmitDefaultValue=false)]
		public StringValue? Description { get; set; }

		/// <summary>
		/// Indicates the tool is scheduled in APS.(Only used in APS.)
		/// DAC Field Name: ScheduleEnabled 
		/// DAC: PX.Objects.AM.AMToolMst 
		/// </summary>
		[DataMember(Name="Schedule", EmitDefaultValue=false)]
		public BooleanValue? Schedule { get; set; }

		/// <summary>
		/// DAC Field Name: SubID 
		/// DAC: PX.Objects.AM.AMToolMst 
		/// </summary>
		[DataMember(Name="Subaccount", EmitDefaultValue=false)]
		public StringValue? Subaccount { get; set; }

		/// <summary>
		/// DAC: PX.Objects.AM.AMToolMst 
		/// Display Name: Tool ID 
		/// SQL Type: nvarchar(30) 
		/// Key Field
		/// </summary>
		[DataMember(Name="ToolID", EmitDefaultValue=false)]
		public StringValue? ToolID { get; set; }

		/// <summary>
		/// DAC: PX.Objects.AM.AMToolMstCurySettings 
		/// Display Name: Total Cost 
		/// </summary>
		[DataMember(Name="TotalCost", EmitDefaultValue=false)]
		public DecimalValue? TotalCost { get; set; }

		/// <summary>
		/// APS Schedule qty/units for scheduling tools. The number of tools available for scheduling.
		/// DAC Field Name: ScheduleQty 
		/// DAC: PX.Objects.AM.AMToolMst 
		/// Display Name: Total Schedule Qty 
		/// </summary>
		[DataMember(Name="TotalScheduleQty", EmitDefaultValue=false)]
		public IntValue? TotalScheduleQty { get; set; }

		/// <summary>
		/// DAC Field Name: ActualUses 
		/// DAC: PX.Objects.AM.AMToolMst 
		/// Display Name: Total Uses 
		/// </summary>
		[DataMember(Name="TotalUses", EmitDefaultValue=false)]
		public DecimalValue? TotalUses { get; set; }

		/// <summary>
		/// DAC: PX.Objects.AM.AMToolMstCurySettings 
		/// Display Name: Unit Cost 
		/// </summary>
		[DataMember(Name="UnitCost", EmitDefaultValue=false)]
		public DecimalValue? UnitCost { get; set; }

		public virtual string GetEndpointPath()
		{
			return "entity/MANUFACTURING/23.200.001";
		}
	}
}