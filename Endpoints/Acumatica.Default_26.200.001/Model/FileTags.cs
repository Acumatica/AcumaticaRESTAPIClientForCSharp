using System;
using System.Collections.Generic;

using Newtonsoft.Json;

using Acumatica.RESTClient.Client;
using Acumatica.RESTClient.ContractBasedApi;
using Acumatica.RESTClient.ContractBasedApi.Model;

namespace Acumatica.Default_26_200_001.Model
{
	/// <summary>
	/// Corresponds to the screen <c>SM202561</c> in the Acumatica ERP
	/// </summary>
	public class FileTags : Entity, ITopLevelEntity
	{

		#region Fields
		public StringValue? Description { get; set; }

		public GuidValue? TagID { get; set; }

		public StringValue? TagName { get; set; }

		#endregion

		#region Details
		public List<AccessRights>? AccessRights { get; set; }

		#endregion

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
			public const string AccessRights = "AccessRights";

			//Intentionally excluded
			//public const string All = "Files,Translations,AccessRights";
		}
		public virtual string GetEndpointPath()
		{
			return "entity/Default/26.200.001";
		}
	}
}