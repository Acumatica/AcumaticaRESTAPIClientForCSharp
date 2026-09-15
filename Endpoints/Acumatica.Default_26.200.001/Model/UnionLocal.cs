using System;
using System.Collections.Generic;
using System.Runtime.Serialization;

using Newtonsoft.Json;

using Acumatica.RESTClient.Client;
using Acumatica.RESTClient.ContractBasedApi;
using Acumatica.RESTClient.ContractBasedApi.Model;

namespace Acumatica.Default_26_200_001.Model
{
	/// <summary>
	/// Corresponds to the screen <c>PM209700</c> in the Acumatica ERP
	/// <para>Key Fields: UnionLocalID</para>
	/// </summary>
	[DataContract]
	public class UnionLocal : Entity, ITopLevelEntity
	{

		/// <summary>
		/// A Boolean value that indicates (if set to true) whether the union local is active.
		/// <para>DAC Field Name: IsActive</para>
		/// <para>DAC: PX.Objects.PM.PMUnion</para>
		/// </summary>
		[DataMember(Name="Active", EmitDefaultValue=false)]
		public BooleanValue? Active { get; set; }

		/// <summary>
		/// <para>DAC: PX.Objects.PM.PMUnion</para>
		/// <para>SQL Type: nvarchar(255)</para>
		/// </summary>
		[DataMember(Name="Description", EmitDefaultValue=false)]
		public StringValue? Description { get; set; }

		/// <summary>
		/// The unique identifier of the union local.
		/// <para>DAC Field Name: UnionID</para>
		/// <para>DAC: PX.Objects.PM.PMUnion</para>
		/// <para>Display Name: Union Local ID</para>
		/// <para>SQL Type: nvarchar(15)</para>
		/// Key Field
		/// </summary>
		[DataMember(Name="UnionLocalID", EmitDefaultValue=false)]
		public StringValue? UnionLocalID { get; set; }

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
			return "entity/Default/26.200.001";
		}
	}
}