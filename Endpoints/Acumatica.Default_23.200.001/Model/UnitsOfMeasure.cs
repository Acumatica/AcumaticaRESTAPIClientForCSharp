using System;
using System.Collections.Generic;

using Newtonsoft.Json;

using Acumatica.RESTClient.Client;
using Acumatica.RESTClient.ContractBasedApi;
using Acumatica.RESTClient.ContractBasedApi.Model;

namespace Acumatica.Default_23_200_001.Model
{
	/// <summary>
	/// Corresponds to the screen <c>CS203100</c> in the Acumatica ERP
	/// <para>Key Fields: FromUOM, ToUOM</para>
	/// </summary>
	public class UnitsOfMeasure : Entity, ITopLevelEntity
	{

		/// <summary>
		/// <para>DAC Field Name: UnitRate</para>
		/// <para>DAC: PX.Objects.IN.INUnit</para>
		/// <para>Display Name: Conversion Factor</para>
		/// </summary>
		public DecimalValue? ConversionFactor { get; set; }

		public DateTimeValue? CreatedDateTime { get; set; }

		/// <summary>
		/// <para>DAC Field Name: FromUnit</para>
		/// <para>DAC: PX.Objects.IN.INUnit</para>
		/// <para>Display Name: From Unit</para>
		/// <para>SQL Type: nvarchar(6)</para>
		/// Key Field
		/// </summary>
		public StringValue? FromUOM { get; set; }

		public DateTimeValue? LastModifiedDateTime { get; set; }

		/// <summary>
		/// <para>DAC Field Name: UnitMultDiv</para>
		/// <para>DAC: PX.Objects.IN.INUnit</para>
		/// <para>Display Name: Multiply/Divide</para>
		/// <para>SQL Type: char(1)</para>
		/// </summary>
		public StringValue? MultiplyOrDivide { get; set; }

		/// <summary>
		/// <para>DAC Field Name: ToUnit</para>
		/// <para>DAC: PX.Objects.IN.INUnit</para>
		/// <para>Display Name: To Unit</para>
		/// <para>SQL Type: nvarchar(6)</para>
		/// Key Field
		/// </summary>
		public StringValue? ToUOM { get; set; }

		public static class Expand
		{
			public const string Files = "Files";
			public const string Translations = "Translations";

			//Intentionally excluded
			//public const string All = "Files,Translations";
		}
		public virtual string GetEndpointPath()
		{
			return "entity/Default/23.200.001";
		}
	}
}