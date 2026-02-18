using System;
using System.Collections.Generic;

using Newtonsoft.Json;

using Acumatica.RESTClient.Client;
using Acumatica.RESTClient.ContractBasedApi;
using Acumatica.RESTClient.ContractBasedApi.Model;

namespace Acumatica.MANUFACTURING_25_100_001.Model
{
	/// <summary>
	/// Corresponds to the screen <c>AM202500</c> in the Acumatica ERP
	/// <para>Key Fields: OverheadID</para>
	/// </summary>
	public class Overhead : Entity, ITopLevelEntity
	{

		/// <summary>
		/// <para>DAC Field Name: AcctID</para>
		/// <para>DAC: PX.Objects.AM.AMOverhead</para>
		/// </summary>
		public StringValue? Account { get; set; }

		/// <summary>
		/// <para>DAC: PX.Objects.AM.AMOverhead</para>
		/// <para>Display Name: Cost Rate</para>
		/// </summary>
		public DecimalValue? CostRate { get; set; }

		/// <summary>
		/// <para>DAC Field Name: Descr</para>
		/// <para>DAC: PX.Objects.AM.AMOverhead</para>
		/// <para>SQL Type: nvarchar(256)</para>
		/// </summary>
		public StringValue? Description { get; set; }

		/// <summary>
		/// <para>DAC Field Name: OvhdID</para>
		/// <para>DAC: PX.Objects.AM.AMOverhead</para>
		/// <para>Display Name: Overhead ID</para>
		/// <para>SQL Type: nvarchar(20)</para>
		/// Key Field
		/// </summary>
		public StringValue? OverheadID { get; set; }

		/// <summary>
		/// <para>DAC Field Name: OvhdType</para>
		/// <para>DAC: PX.Objects.AM.AMOverhead</para>
		/// <para>Display Name: Type</para>
		/// <para>SQL Type: char(1)</para>
		/// </summary>
		public StringValue? OverheadType { get; set; }

		/// <summary>
		/// <para>DAC Field Name: SubID</para>
		/// <para>DAC: PX.Objects.AM.AMOverhead</para>
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