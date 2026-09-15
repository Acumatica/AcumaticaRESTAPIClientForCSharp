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
	/// Corresponds to the screen <c>PR209800</c> in the Acumatica ERP
	/// </summary>
	[DataContract]
	public class PayrollWCCCode : Entity, ITopLevelEntity
	{

		/// <summary>
		/// <para>DAC Field Name: CountryID</para>
		/// <para>DAC: PX.Objects.PR.PRWorkCodeMaint+PRWorkCodeFilter</para>
		/// </summary>
		[DataMember(Name="Country", EmitDefaultValue=false)]
		public StringValue? Country { get; set; }

		[DataMember(Name="WCCCodes", EmitDefaultValue=false)]
		public List<WCCCode>? WCCCodes { get; set; }

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
			public const string WCCCodes = "WCCCodes";

			//Intentionally excluded
			//public const string All = "Files,Translations,WCCCodes";
		}
		public virtual string GetEndpointPath()
		{
			return "entity/Default/26.200.001";
		}
	}
}