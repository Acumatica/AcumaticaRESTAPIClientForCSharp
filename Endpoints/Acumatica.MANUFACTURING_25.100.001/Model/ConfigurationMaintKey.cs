using System;
using System.Collections.Generic;

using Newtonsoft.Json;

using Acumatica.RESTClient.Client;
using Acumatica.RESTClient.ContractBasedApi;
using Acumatica.RESTClient.ContractBasedApi.Model;

namespace Acumatica.MANUFACTURING_25_100_001.Model
{
	public class ConfigurationMaintKey : Entity
	{

		/// <summary>
		/// <para>DAC Field Name: KeyFormat</para>
		/// <para>DAC: PX.Objects.AM.AMConfiguration</para>
		/// <para>SQL Type: char(1)</para>
		/// </summary>
		public StringValue? Format { get; set; }

		/// <summary>
		/// <para>DAC Field Name: KeyEquation</para>
		/// <para>DAC: PX.Objects.AM.AMConfiguration</para>
		/// <para>SQL Type: nvarchar(240)</para>
		/// </summary>
		public StringValue? Formula { get; set; }

		/// <summary>
		/// <para>DAC: PX.Objects.AM.AMConfiguration</para>
		/// <para>Display Name: Key Description</para>
		/// <para>SQL Type: nvarchar(MAX)</para>
		/// </summary>
		public StringValue? KeyDescription { get; set; }

		/// <summary>
		/// <para>DAC Field Name: KeyNumberingID</para>
		/// <para>DAC: PX.Objects.AM.AMConfiguration</para>
		/// <para>Display Name: Number Sequence</para>
		/// <para>SQL Type: nvarchar(10)</para>
		/// </summary>
		public StringValue? NumberSequence { get; set; }

		/// <summary>
		/// Formula field to configure a custom transaction description for sales order tran description.
		/// <para>DAC: PX.Objects.AM.AMConfiguration</para>
		/// <para>Display Name: Tran Description</para>
		/// <para>SQL Type: nvarchar(512)</para>
		/// </summary>
		public StringValue? TranDescription { get; set; }

	}
}