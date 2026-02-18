using System;
using System.Collections.Generic;

using Newtonsoft.Json;

using Acumatica.RESTClient.Client;
using Acumatica.RESTClient.ContractBasedApi;
using Acumatica.RESTClient.ContractBasedApi.Model;

namespace Acumatica.Default_25_200_001.Model
{
	public class InventoryItemUOMConversion : Entity
	{

		/// <summary>
		/// <para>DAC Field Name: UnitRate</para>
		/// <para>DAC: PX.Objects.IN.INUnit</para>
		/// <para>Display Name: Conversion Factor</para>
		/// </summary>
		public DecimalValue? ConversionFactor { get; set; }

		/// <summary>
		/// <para>DAC Field Name: FromUnit</para>
		/// <para>DAC: PX.Objects.IN.INUnit</para>
		/// <para>Display Name: From Unit</para>
		/// <para>SQL Type: nvarchar(6)</para>
		/// Key Field
		/// </summary>
		public StringValue? FromUOM { get; set; }

		/// <summary>
		/// <para>DAC Field Name: UnitMultDiv</para>
		/// <para>DAC: PX.Objects.IN.INUnit</para>
		/// <para>Display Name: Multiply/Divide</para>
		/// <para>SQL Type: char(1)</para>
		/// </summary>
		public StringValue? MultiplyOrDivide { get; set; }

		public StringValue? ToUOM { get; set; }

	}
}