using System;
using System.Collections.Generic;

using Newtonsoft.Json;

using Acumatica.RESTClient.Client;
using Acumatica.RESTClient.ContractBasedApi;
using Acumatica.RESTClient.ContractBasedApi.Model;

namespace Acumatica.Manufacturing_24_200_001.Model
{
	/// <summary>
	/// Corresponds to the screen <c>AM206500</c> in the Acumatica ERP
	/// <para>Key Fields: LaborCode</para>
	/// </summary>
	public class LaborCodes : Entity, ITopLevelEntity
	{

		/// <summary>
		/// <para>DAC Field Name: Descr</para>
		/// <para>DAC: PX.Objects.AM.AMLaborCode</para>
		/// <para>SQL Type: nvarchar(60)</para>
		/// </summary>
		public StringValue? Description { get; set; }

		/// <summary>
		/// <para>DAC Field Name: LaborAccountID</para>
		/// <para>DAC: PX.Objects.AM.AMLaborCode</para>
		/// <para>Display Name: Labor Account</para>
		/// </summary>
		public StringValue? LaborAccount { get; set; }

		/// <summary>
		/// <para>DAC Field Name: LaborCodeID</para>
		/// <para>DAC: PX.Objects.AM.AMLaborCode</para>
		/// <para>Display Name: Labor Code</para>
		/// <para>SQL Type: nvarchar(15)</para>
		/// Key Field
		/// </summary>
		public StringValue? LaborCode { get; set; }

		/// <summary>
		/// <para>DAC Field Name: LaborSubID</para>
		/// <para>DAC: PX.Objects.AM.AMLaborCode</para>
		/// <para>Display Name: Labor Sub</para>
		/// </summary>
		public StringValue? LaborSub { get; set; }

		/// <summary>
		/// <para>DAC Field Name: OverheadAccountID</para>
		/// <para>DAC: PX.Objects.AM.AMLaborCode</para>
		/// <para>Display Name: Overhead Account</para>
		/// </summary>
		public StringValue? OverheadAccount { get; set; }

		/// <summary>
		/// <para>DAC Field Name: OverheadSubID</para>
		/// <para>DAC: PX.Objects.AM.AMLaborCode</para>
		/// <para>Display Name: Overhead Sub</para>
		/// </summary>
		public StringValue? OverheadSub { get; set; }

		/// <summary>
		/// <para>DAC Field Name: LaborType</para>
		/// <para>DAC: PX.Objects.AM.AMLaborCode</para>
		/// <para>SQL Type: char(1)</para>
		/// </summary>
		public StringValue? Type { get; set; }

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