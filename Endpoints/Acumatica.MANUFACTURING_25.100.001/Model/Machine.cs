using System;
using System.Collections.Generic;

using Newtonsoft.Json;

using Acumatica.RESTClient.Client;
using Acumatica.RESTClient.ContractBasedApi;
using Acumatica.RESTClient.ContractBasedApi.Model;

namespace Acumatica.MANUFACTURING_25_100_001.Model
{
	/// <summary>
	/// Corresponds to the screen <c>AM204500</c> in the Acumatica ERP
	/// <para>Key Fields: MachineID</para>
	/// </summary>
	public class Machine : Entity, ITopLevelEntity
	{

		/// <summary>
		/// <para>DAC Field Name: MachAcctID</para>
		/// <para>DAC: PX.Objects.AM.AMMach</para>
		/// </summary>
		public StringValue? Account { get; set; }

		/// <summary>
		/// <para>DAC Field Name: ActiveFlg</para>
		/// <para>DAC: PX.Objects.AM.AMMach</para>
		/// </summary>
		public BooleanValue? Active { get; set; }

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
		/// <para>DAC Field Name: MachEff</para>
		/// <para>DAC: PX.Objects.AM.AMMach</para>
		/// </summary>
		public DecimalValue? Efficiency { get; set; }

		/// <summary>
		/// <para>DAC Field Name: MachID</para>
		/// <para>DAC: PX.Objects.AM.AMMach</para>
		/// <para>Display Name: Machine ID</para>
		/// <para>SQL Type: nvarchar(30)</para>
		/// Key Field
		/// </summary>
		public StringValue? MachineID { get; set; }

		/// <summary>
		/// <para>DAC Field Name: StdCost</para>
		/// <para>DAC: PX.Objects.AM.AMMachCurySettings</para>
		/// <para>Display Name: Standard Cost</para>
		/// </summary>
		public DecimalValue? StandardCost { get; set; }

		/// <summary>
		/// <para>DAC Field Name: MachSubID</para>
		/// <para>DAC: PX.Objects.AM.AMMach</para>
		/// </summary>
		public StringValue? Subaccount { get; set; }

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