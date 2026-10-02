using System;
using System.Collections.Generic;

using Newtonsoft.Json;

using Acumatica.RESTClient.Client;
using Acumatica.RESTClient.ContractBasedApi;
using Acumatica.RESTClient.ContractBasedApi.Model;

namespace Acumatica.Manufacturing_26_200_001.Model
{
	/// <summary>
	/// Corresponds to the screen <c>AM204500</c> in the Acumatica ERP
	/// <para>Key Fields: MachineID</para>
	/// </summary>
	public class Machine : Entity, ITopLevelEntity
	{

		#region Fields
		/// <summary>
		/// <para>DAC Field Name: MachID</para>
		/// <para>DAC: PX.Objects.AM.AMMach</para>
		/// <para>Display Name: Machine ID</para>
		/// <para>SQL Type: nvarchar(30)</para>
		/// Key Field
		/// </summary>
		public StringValue? MachineID { get; set; }

		/// <summary>
		/// <para>DAC Field Name: ActiveFlg</para>
		/// <para>DAC: PX.Objects.AM.AMMach</para>
		/// </summary>
		public BooleanValue? Active { get; set; }

		/// <summary>
		/// <para>DAC Field Name: Descr</para>
		/// <para>DAC: PX.Objects.AM.AMMach</para>
		/// <para>SQL Type: nvarchar(120)</para>
		/// </summary>
		public StringValue? Description { get; set; }

		/// <summary>
		/// <para>DAC Field Name: DownFlg</para>
		/// <para>DAC: PX.Objects.AM.AMMach</para>
		/// </summary>
		public BooleanValue? Down { get; set; }

		/// <summary>
		/// <para>DAC: PX.Objects.AM.AMMach</para>
		/// <para>Display Name: Asset ID</para>
		/// <para>SQL Type: nvarchar(30)</para>
		/// </summary>
		public StringValue? AssetID { get; set; }

		/// <summary>
		/// <para>DAC: PX.Objects.AM.AMMach</para>
		/// <para>Display Name: Calendar ID</para>
		/// <para>SQL Type: nvarchar(10)</para>
		/// </summary>
		public StringValue? CalendarID { get; set; }

		/// <summary>
		/// <para>DAC Field Name: MachEff</para>
		/// <para>DAC: PX.Objects.AM.AMMach</para>
		/// </summary>
		public DecimalValue? Efficiency { get; set; }

		/// <summary>
		/// <para>DAC Field Name: MachAcctID</para>
		/// <para>DAC: PX.Objects.AM.AMMach</para>
		/// </summary>
		public StringValue? Account { get; set; }

		/// <summary>
		/// <para>DAC Field Name: MachSubID</para>
		/// <para>DAC: PX.Objects.AM.AMMach</para>
		/// </summary>
		public StringValue? Subaccount { get; set; }

		/// <summary>
		/// <para>DAC Field Name: StdCost</para>
		/// <para>DAC: PX.Objects.AM.AMMachCurySettings</para>
		/// <para>Display Name: Standard Cost</para>
		/// </summary>
		public DecimalValue? StandardCost { get; set; }

		#endregion

		protected override string GetDebuggerDisplay()
		{
			return $"{nameof(Machine)} - \"{MachineID}\"";
		}

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