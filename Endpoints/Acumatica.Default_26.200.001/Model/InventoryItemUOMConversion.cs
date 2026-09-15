using System;
using System.Collections.Generic;
using System.Runtime.Serialization;

using Newtonsoft.Json;

using Acumatica.RESTClient.Client;
using Acumatica.RESTClient.ContractBasedApi;
using Acumatica.RESTClient.ContractBasedApi.Model;

namespace Acumatica.Default_26_200_001.Model
{
	[DataContract]
	public class InventoryItemUOMConversion : Entity
	{

		/// <summary>
		/// <para>DAC Field Name: UnitRate</para>
		/// <para>DAC: PX.Objects.IN.INUnit</para>
		/// <para>Display Name: Conversion Factor</para>
		/// </summary>
		[DataMember(Name="ConversionFactor", EmitDefaultValue=false)]
		public DecimalValue? ConversionFactor { get; set; }

		/// <summary>
		/// <para>DAC Field Name: FromUnit</para>
		/// <para>DAC: PX.Objects.IN.INUnit</para>
		/// <para>Display Name: From Unit</para>
		/// <para>SQL Type: nvarchar(6)</para>
		/// Key Field
		/// </summary>
		[DataMember(Name="FromUOM", EmitDefaultValue=false)]
		public StringValue? FromUOM { get; set; }

		/// <summary>
		/// <para>DAC Field Name: UnitMultDiv</para>
		/// <para>DAC: PX.Objects.IN.INUnit</para>
		/// <para>Display Name: Multiply/Divide</para>
		/// <para>SQL Type: char(1)</para>
		/// </summary>
		[DataMember(Name="MultiplyOrDivide", EmitDefaultValue=false)]
		public StringValue? MultiplyOrDivide { get; set; }

		[DataMember(Name="ToUOM", EmitDefaultValue=false)]
		public StringValue? ToUOM { get; set; }

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

			//Intentionally excluded
			//public const string All = "Files";
		}
	}
}