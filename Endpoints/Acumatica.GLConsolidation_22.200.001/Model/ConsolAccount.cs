using System;
using System.Collections.Generic;
using System.Runtime.Serialization;

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
	[DataContract]
	public class ConsolAccount : Entity, ITopLevelEntity
	{

		#region Fields
		/// <summary>
		/// <para>DAC: PX.Objects.GL.GLConsolAccount</para>
		/// <para>Display Name: Account</para>
		/// <para>SQL Type: nvarchar(30)</para>
		/// Key Field
		/// </summary>
		[DataMember(Name="AccountCD", EmitDefaultValue=false)]
		public StringValue? AccountCD { get; set; }

		/// <summary>
		/// <para>DAC: PX.Objects.GL.GLConsolAccount</para>
		/// <para>SQL Type: nvarchar(60)</para>
		/// </summary>
		[DataMember(Name="Description", EmitDefaultValue=false)]
		public StringValue? Description { get; set; }

		#endregion

		protected override string GetDebuggerDisplay()
		{
			return $"{nameof(ConsolAccount)} - \"{AccountCD}\"";
		}

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