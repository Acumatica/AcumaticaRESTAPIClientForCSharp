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
	/// Corresponds to the screen <c>CS208000</c> in the Acumatica ERP
	/// <para>Key Fields: TermID</para>
	/// </summary>
	[DataContract]
	public class ShippingTerm : Entity, ITopLevelEntity
	{

		/// <summary>
		/// <para>DAC: PX.Objects.CS.ShipTerms</para>
		/// <para>SQL Type: nvarchar(255)</para>
		/// </summary>
		[DataMember(Name="Description", EmitDefaultValue=false)]
		public StringValue? Description { get; set; }

		[DataMember(Name="Details", EmitDefaultValue=false)]
		public List<ShippingTermDetail>? Details { get; set; }

		/// <summary>
		/// <para>DAC Field Name: ShipTermsID</para>
		/// <para>DAC: PX.Objects.CS.ShipTerms</para>
		/// <para>Display Name: Term ID</para>
		/// <para>SQL Type: nvarchar(10)</para>
		/// Key Field
		/// </summary>
		[DataMember(Name="TermID", EmitDefaultValue=false)]
		public StringValue? TermID { get; set; }

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
			public const string Details = "Details";

			//Intentionally excluded
			//public const string All = "Files,Translations,Details";
		}
		public virtual string GetEndpointPath()
		{
			return "entity/Default/26.200.001";
		}
	}
}