using System;
using System.Collections.Generic;
using System.Runtime.Serialization;

using Newtonsoft.Json;

using Acumatica.RESTClient.Client;
using Acumatica.RESTClient.ContractBasedApi;
using Acumatica.RESTClient.ContractBasedApi.Model;

namespace Acumatica.Manufacturing_24_200_001.Model
{
	/// <summary>
	/// Corresponds to the screen AM205500 in the Acumatica ERP
	/// </summary>
	[DataContract]
	public class Tool : Entity, ITopLevelEntity
	{

		/// <summary>
		/// 
		/// Display Name:
		/// DAC Field Name: AcctID 
		/// DAC: PX.Objects.AM.AMToolMst 
		/// </summary>
		/// <remarks>
		/// 
		/// </remarks>
		[DataMember(Name="Account", EmitDefaultValue=false)]
		public StringValue? Account { get; set; }

		/// <summary>
		/// 
		/// Display Name:
		/// DAC Field Name: Active 
		/// DAC: PX.Objects.AM.AMToolMst 
		/// </summary>
		/// <remarks>
		/// 
		/// </remarks>
		[DataMember(Name="Active", EmitDefaultValue=false)]
		public BooleanValue? Active { get; set; }

		/// <summary>
		/// 
		/// Display Name:
		/// DAC Field Name: ActualCost 
		/// DAC: PX.Objects.AM.AMToolMstCurySettings 
		/// </summary>
		/// <remarks>
		/// 
		/// </remarks>
		[DataMember(Name="ConsumedCost", EmitDefaultValue=false)]
		public DecimalValue? ConsumedCost { get; set; }

		/// <summary>
		/// 
		/// Display Name:
		/// DAC Field Name: Descr 
		/// DAC: PX.Objects.AM.AMToolMst 
		/// </summary>
		/// <remarks>
		/// 
		/// </remarks>
		[DataMember(Name="Description", EmitDefaultValue=false)]
		public StringValue? Description { get; set; }

		/// <summary>
		/// 
		/// Display Name:
		/// DAC Field Name: ScheduleEnabled 
		/// DAC: PX.Objects.AM.AMToolMst 
		/// </summary>
		/// <remarks>
		/// 
		/// </remarks>
		[DataMember(Name="Schedule", EmitDefaultValue=false)]
		public BooleanValue? Schedule { get; set; }

		/// <summary>
		/// 
		/// Display Name:
		/// DAC Field Name: SubID 
		/// DAC: PX.Objects.AM.AMToolMst 
		/// </summary>
		/// <remarks>
		/// 
		/// </remarks>
		[DataMember(Name="Subaccount", EmitDefaultValue=false)]
		public StringValue? Subaccount { get; set; }

		/// <summary>
		/// 
		/// Display Name:
		/// DAC Field Name: ToolID 
		/// DAC: PX.Objects.AM.AMToolMst 
		/// </summary>
		/// <remarks>
		/// 
		/// </remarks>
		[DataMember(Name="ToolID", EmitDefaultValue=false)]
		public StringValue? ToolID { get; set; }

		/// <summary>
		/// 
		/// Display Name:
		/// DAC Field Name: TotalCost 
		/// DAC: PX.Objects.AM.AMToolMstCurySettings 
		/// </summary>
		/// <remarks>
		/// 
		/// </remarks>
		[DataMember(Name="TotalCost", EmitDefaultValue=false)]
		public DecimalValue? TotalCost { get; set; }

		/// <summary>
		/// 
		/// Display Name:
		/// DAC Field Name: ScheduleQty 
		/// DAC: PX.Objects.AM.AMToolMst 
		/// </summary>
		/// <remarks>
		/// 
		/// </remarks>
		[DataMember(Name="TotalScheduleQty", EmitDefaultValue=false)]
		public IntValue? TotalScheduleQty { get; set; }

		/// <summary>
		/// 
		/// Display Name:
		/// DAC Field Name: ActualUses 
		/// DAC: PX.Objects.AM.AMToolMst 
		/// </summary>
		/// <remarks>
		/// 
		/// </remarks>
		[DataMember(Name="TotalUses", EmitDefaultValue=false)]
		public DecimalValue? TotalUses { get; set; }

		/// <summary>
		/// 
		/// Display Name:
		/// DAC Field Name: UnitCost 
		/// DAC: PX.Objects.AM.AMToolMstCurySettings 
		/// </summary>
		/// <remarks>
		/// 
		/// </remarks>
		[DataMember(Name="UnitCost", EmitDefaultValue=false)]
		public DecimalValue? UnitCost { get; set; }

		public virtual string GetEndpointPath()
		{
			return "entity/MANUFACTURING/24.200.001";
		}
	}
}