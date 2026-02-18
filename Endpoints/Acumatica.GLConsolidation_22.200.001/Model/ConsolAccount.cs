using System;
using System.Collections.Generic;

using Newtonsoft.Json;

using Acumatica.RESTClient.Client;
using Acumatica.RESTClient.ContractBasedApi;
using Acumatica.RESTClient.ContractBasedApi.Model;

namespace Acumatica.GLConsolidation_22_200_001.Model
{
	/// <summary>
	/// Corresponds to the screen <c>GL103001</c> in the Acumatica ERP
	/// <para>Key Fields: AccountCD</para>
	/// </summary>
	public class ConsolAccount : Entity, ITopLevelEntity
	{

		/// <summary>
		/// <para>DAC: PX.Objects.GL.GLConsolAccount</para>
		/// <para>Display Name: Account</para>
		/// <para>SQL Type: nvarchar(30)</para>
		/// Key Field
		/// </summary>
		public StringValue? AccountCD { get; set; }

		/// <summary>
		/// <para>DAC: PX.Objects.GL.GLConsolAccount</para>
		/// <para>SQL Type: nvarchar(60)</para>
		/// </summary>
		public StringValue? Description { get; set; }

		public static class Expand
		{
			public const string Files = "Files";
			public const string Translations = "Translations";

			//Intentionally excluded
			//public const string All = "Files,Translations";
		}
		public virtual string GetEndpointPath()
		{
			return "entity/GLConsolidation/22.200.001";
		}
	}
}