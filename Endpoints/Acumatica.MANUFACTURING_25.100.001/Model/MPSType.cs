using System;
using System.Collections.Generic;

using Newtonsoft.Json;

using Acumatica.RESTClient.Client;
using Acumatica.RESTClient.ContractBasedApi;
using Acumatica.RESTClient.ContractBasedApi.Model;

namespace Acumatica.MANUFACTURING_25_100_001.Model
{
	/// <summary>
	/// Corresponds to the screen <c>AM203000</c> in the Acumatica ERP
	/// <para>Key Fields: TypeID</para>
	/// </summary>
	public class MPSType : Entity, ITopLevelEntity
	{

		/// <summary>
		/// <para>DAC: PX.Objects.AM.AMMPSType</para>
		/// </summary>
		public BooleanValue? Dependent { get; set; }

		/// <summary>
		/// <para>DAC Field Name: Descr</para>
		/// <para>DAC: PX.Objects.AM.AMMPSType</para>
		/// <para>SQL Type: nvarchar(60)</para>
		/// </summary>
		public StringValue? Description { get; set; }

		/// <summary>
		/// <para>DAC Field Name: MPSNumberingID</para>
		/// <para>DAC: PX.Objects.AM.AMMPSType</para>
		/// <para>Display Name: Numbering Sequence</para>
		/// <para>SQL Type: nvarchar(10)</para>
		/// </summary>
		public StringValue? NumberingSequence { get; set; }

		/// <summary>
		/// <para>DAC Field Name: MPSTypeID</para>
		/// <para>DAC: PX.Objects.AM.AMMPSType</para>
		/// <para>Display Name: Type ID</para>
		/// <para>SQL Type: nvarchar(20)</para>
		/// Key Field
		/// </summary>
		public StringValue? TypeID { get; set; }

		public static class Expand
		{
			public const string Files = "Files";
			public const string Translations = "Translations";

			//Intentionally excluded
			//public const string All = "Files,Translations";
		}
		public virtual string GetEndpointPath()
		{
			return "entity/MANUFACTURING/25.100.001";
		}
	}
}