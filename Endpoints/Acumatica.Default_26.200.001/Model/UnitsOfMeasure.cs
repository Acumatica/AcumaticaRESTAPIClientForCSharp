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
	/// Corresponds to the screen <c>CS203500</c> in the Acumatica ERP
	/// </summary>
	[DataContract]
	public class UnitsOfMeasure : Entity, ITopLevelEntity
	{

		/// <summary>
		/// <para>DAC Field Name: Unit</para>
		/// <para>DAC: PX.Objects.Localizations.CA.CS.UnitOfMeasure</para>
		/// </summary>
		[DataMember(Name="UnitID", EmitDefaultValue=false)]
		public StringValue? UnitID { get; set; }

		/// <summary>
		/// <para>DAC Field Name: Descr</para>
		/// <para>DAC: PX.Objects.Localizations.CA.CS.UnitOfMeasure</para>
		/// </summary>
		[DataMember(Name="Description", EmitDefaultValue=false)]
		public StringValue? Description { get; set; }

		/// <summary>
		/// <para>DAC: PX.Objects.Localizations.CA.CS.UnitOfMeasure</para>
		/// </summary>
		[DataMember(Name="L3Code", EmitDefaultValue=false)]
		public StringValue? L3Code { get; set; }

		[DataMember(Name="Conversion", EmitDefaultValue=false)]
		public List<Units>? Conversion { get; set; }

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
			public const string Conversion = "Conversion";

			//Intentionally excluded
			//public const string All = "Files,Translations,Conversion";
		}
		public virtual string GetEndpointPath()
		{
			return "entity/Default/26.200.001";
		}
	}
}