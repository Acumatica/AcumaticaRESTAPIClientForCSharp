using System;
using System.Collections.Generic;

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
	public class Tool : Entity, ITopLevelEntity
	{

		/// <summary>
		/// <para>DAC Field Name: AcctID</para>
		/// <para>DAC: PX.Objects.AM.AMToolMst</para>
		/// </summary>
		public StringValue? Account { get; set; }

		/// <summary>
		/// <para>DAC: PX.Objects.AM.AMToolMst</para>
		/// </summary>
		public BooleanValue? Active { get; set; }

		/// <summary>
		/// <para>DAC Field Name: ActualCost</para>
		/// <para>DAC: PX.Objects.AM.AMToolMstCurySettings</para>
		/// <para>Display Name: Consumed Cost</para>
		/// </summary>
		public DecimalValue? ConsumedCost { get; set; }

		/// <summary>
		/// <para>DAC Field Name: Descr</para>
		/// <para>DAC: PX.Objects.AM.AMToolMst</para>
		/// <para>SQL Type: nvarchar(256)</para>
		/// </summary>
		public StringValue? Description { get; set; }

		/// <summary>
		/// Indicates the tool is scheduled in APS.(Only used in APS.)
		/// <para>DAC Field Name: ScheduleEnabled</para>
		/// <para>DAC: PX.Objects.AM.AMToolMst</para>
		/// </summary>
		public BooleanValue? Schedule { get; set; }

		/// <summary>
		/// <para>DAC Field Name: SubID</para>
		/// <para>DAC: PX.Objects.AM.AMToolMst</para>
		/// </summary>
		public StringValue? Subaccount { get; set; }

		/// <summary>
		/// <para>DAC: PX.Objects.AM.AMToolMst</para>
		/// <para>Display Name: Tool ID</para>
		/// <para>SQL Type: nvarchar(30)</para>
		/// Key Field
		/// </summary>
		public StringValue? ToolID { get; set; }

		/// <summary>
		/// <para>DAC: PX.Objects.AM.AMToolMstCurySettings</para>
		/// <para>Display Name: Total Cost</para>
		/// </summary>
		public DecimalValue? TotalCost { get; set; }

		/// <summary>
		/// APS Schedule qty/units for scheduling tools. The number of tools available for scheduling.
		/// <para>DAC Field Name: ScheduleQty</para>
		/// <para>DAC: PX.Objects.AM.AMToolMst</para>
		/// <para>Display Name: Total Schedule Qty.</para>
		/// </summary>
		public IntValue? TotalScheduleQty { get; set; }

		/// <summary>
		/// <para>DAC Field Name: ActualUses</para>
		/// <para>DAC: PX.Objects.AM.AMToolMst</para>
		/// <para>Display Name: Total Uses</para>
		/// </summary>
		public DecimalValue? TotalUses { get; set; }

		/// <summary>
		/// <para>DAC: PX.Objects.AM.AMToolMstCurySettings</para>
		/// <para>Display Name: Unit Cost</para>
		/// </summary>
		public DecimalValue? UnitCost { get; set; }

		public static class Expand
		{
			public const string Files = "Files";
			public const string Translations = "Translations";

			//Intentionally excluded
			//public const string All = "Files,Translations";
		}
		public virtual string GetEndpointPath()
		{
			return "entity/MANUFACTURING/24.200.001";
		}
	}
}