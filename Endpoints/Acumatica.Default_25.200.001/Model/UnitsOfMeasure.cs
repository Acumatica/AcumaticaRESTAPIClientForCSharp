using System;
using System.Collections.Generic;

using Newtonsoft.Json;

using Acumatica.RESTClient.Client;
using Acumatica.RESTClient.ContractBasedApi;
using Acumatica.RESTClient.ContractBasedApi.Model;

namespace Acumatica.Default_25_200_001.Model
{
	/// <summary>
	/// Corresponds to the screen <c>CS203500</c> in the Acumatica ERP
	/// </summary>
	public class UnitsOfMeasure : Entity, ITopLevelEntity
	{

		/// <summary>
		/// <para>DAC Field Name: Unit</para>
		/// <para>DAC: PX.Objects.Localizations.CA.CS.UnitOfMeasure</para>
		/// </summary>
		public StringValue? UnitID { get; set; }

		/// <summary>
		/// <para>DAC Field Name: Descr</para>
		/// <para>DAC: PX.Objects.Localizations.CA.CS.UnitOfMeasure</para>
		/// </summary>
		public StringValue? Description { get; set; }

		/// <summary>
		/// <para>DAC: PX.Objects.Localizations.CA.CS.UnitOfMeasure</para>
		/// </summary>
		public StringValue? L3Code { get; set; }

		public List<Units>? Conversion { get; set; }

		public static class Expand
		{
			public const string Files = "Files";
			public const string Translations = "Translations";
			public const string Conversion = "Conversion";
			public const string Conversion_Files = "Conversion/Files";

			//Intentionally excluded
			//public const string All = "Files,Translations,Conversion,Conversion/Files";
		}
		public virtual string GetEndpointPath()
		{
			return "entity/Default/25.200.001";
		}
	}
}