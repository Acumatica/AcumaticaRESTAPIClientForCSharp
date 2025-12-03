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
	/// Corresponds to the screen <c>AM205500</c> in the Acumatica ERP
	/// <para>Key Fields: ToolID</para>
	/// </summary>
	[DataContract]
	public class Tool : Entity, ITopLevelEntity
	{

		/// <summary>
		/// <para>DAC Field Name: AcctID</para>
		/// <para>DAC: PX.Objects.AM.AMToolMst</para>
		/// </summary>
		[DataMember(Name="Account", EmitDefaultValue=false)]
		public StringValue? Account { get; set; }

		/// <summary>
		/// <para>DAC: PX.Objects.AM.AMToolMst</para>
		/// </summary>
		[DataMember(Name="Active", EmitDefaultValue=false)]
		public BooleanValue? Active { get; set; }

		/// <summary>
		/// <para>DAC Field Name: ActualCost</para>
		/// <para>DAC: PX.Objects.AM.AMToolMstCurySettings</para>
		/// <para>Display Name: Consumed Cost</para>
		/// </summary>
		[DataMember(Name="ConsumedCost", EmitDefaultValue=false)]
		public DecimalValue? ConsumedCost { get; set; }

		/// <summary>
		/// <para>DAC Field Name: Descr</para>
		/// <para>DAC: PX.Objects.AM.AMToolMst</para>
		/// <para>SQL Type: nvarchar(256)</para>
		/// </summary>
		[DataMember(Name="Description", EmitDefaultValue=false)]
		public StringValue? Description { get; set; }

		/// <summary>
		/// Indicates the tool is scheduled in APS.(Only used in APS.)
		/// <para>DAC Field Name: ScheduleEnabled</para>
		/// <para>DAC: PX.Objects.AM.AMToolMst</para>
		/// </summary>
		[DataMember(Name="Schedule", EmitDefaultValue=false)]
		public BooleanValue? Schedule { get; set; }

		/// <summary>
		/// <para>DAC Field Name: SubID</para>
		/// <para>DAC: PX.Objects.AM.AMToolMst</para>
		/// </summary>
		[DataMember(Name="Subaccount", EmitDefaultValue=false)]
		public StringValue? Subaccount { get; set; }

		/// <summary>
		/// <para>DAC: PX.Objects.AM.AMToolMst</para>
		/// <para>Display Name: Tool ID</para>
		/// <para>SQL Type: nvarchar(30)</para>
		/// Key Field
		/// </summary>
		[DataMember(Name="ToolID", EmitDefaultValue=false)]
		public StringValue? ToolID { get; set; }

		/// <summary>
		/// <para>DAC: PX.Objects.AM.AMToolMstCurySettings</para>
		/// <para>Display Name: Total Cost</para>
		/// </summary>
		[DataMember(Name="TotalCost", EmitDefaultValue=false)]
		public DecimalValue? TotalCost { get; set; }

		/// <summary>
		/// APS Schedule qty/units for scheduling tools. The number of tools available for scheduling.
		/// <para>DAC Field Name: ScheduleQty</para>
		/// <para>DAC: PX.Objects.AM.AMToolMst</para>
		/// <para>Display Name: Total Schedule Qty</para>
		/// </summary>
		[DataMember(Name="TotalScheduleQty", EmitDefaultValue=false)]
		public IntValue? TotalScheduleQty { get; set; }

		/// <summary>
		/// <para>DAC Field Name: ActualUses</para>
		/// <para>DAC: PX.Objects.AM.AMToolMst</para>
		/// <para>Display Name: Total Uses</para>
		/// </summary>
		[DataMember(Name="TotalUses", EmitDefaultValue=false)]
		public DecimalValue? TotalUses { get; set; }

		/// <summary>
		/// <para>DAC: PX.Objects.AM.AMToolMstCurySettings</para>
		/// <para>Display Name: Unit Cost</para>
		/// </summary>
		[DataMember(Name="UnitCost", EmitDefaultValue=false)]
		public DecimalValue? UnitCost { get; set; }

		public static class Expand
		{
			public const string Files = "Files";

			//Intentionally excluded
			//public const string All = "Files";
		}
		public virtual string GetEndpointPath()
		{
			return "entity/MANUFACTURING/24.200.001";
		}
	}
}