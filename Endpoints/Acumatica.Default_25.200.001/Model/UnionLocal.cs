using System;
using System.Collections.Generic;

using Newtonsoft.Json;

using Acumatica.RESTClient.Client;
using Acumatica.RESTClient.ContractBasedApi;
using Acumatica.RESTClient.ContractBasedApi.Model;

namespace Acumatica.Default_25_200_001.Model
{
	/// <summary>
	/// Corresponds to the screen <c>PM209700</c> in the Acumatica ERP
	/// <para>Key Fields: UnionLocalID</para>
	/// </summary>
	public class UnionLocal : Entity, ITopLevelEntity
	{

		#region Fields
		/// <summary>
		/// The unique identifier of the union local.
		/// <para>DAC Field Name: UnionID</para>
		/// <para>DAC: PX.Objects.PM.PMUnion</para>
		/// <para>Display Name: Union Local ID</para>
		/// <para>SQL Type: nvarchar(15)</para>
		/// Key Field
		/// </summary>
		public StringValue? UnionLocalID { get; set; }

		/// <summary>
		/// A Boolean value that indicates (if set to true) whether the union local is active.
		/// <para>DAC Field Name: IsActive</para>
		/// <para>DAC: PX.Objects.PM.PMUnion</para>
		/// </summary>
		public BooleanValue? Active { get; set; }

		/// <summary>
		/// <para>DAC: PX.Objects.PM.PMUnion</para>
		/// <para>SQL Type: nvarchar(255)</para>
		/// </summary>
		public StringValue? Description { get; set; }

		#endregion

		protected override string GetDebuggerDisplay()
		{
			return $"{nameof(UnionLocal)} - \"{UnionLocalID}\"";
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
			return "entity/Default/25.200.001";
		}
	}
}