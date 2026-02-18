using System;
using System.Collections.Generic;

using Newtonsoft.Json;

using Acumatica.RESTClient.Client;
using Acumatica.RESTClient.ContractBasedApi;
using Acumatica.RESTClient.ContractBasedApi.Model;

namespace Acumatica.Manufacturing_24_200_001.Model
{
	public class DisassemblyEntryAttribute : Entity
	{

		/// <summary>
		/// <para>DAC Field Name: Label</para>
		/// <para>DAC: PX.Objects.AM.AMDisassembleBatchAttribute</para>
		/// <para>SQL Type: nvarchar(30)</para>
		/// </summary>
		public StringValue? Attribute { get; set; }

		/// <summary>
		/// <para>DAC: PX.Objects.AM.AMDisassembleBatchAttribute</para>
		/// <para>Display Name: Attribute ID</para>
		/// <para>SQL Type: nvarchar(10)</para>
		/// </summary>
		public StringValue? AttributeID { get; set; }

		/// <summary>
		/// <para>DAC Field Name: Descr</para>
		/// <para>DAC: PX.Objects.AM.AMDisassembleBatchAttribute</para>
		/// <para>SQL Type: nvarchar(256)</para>
		/// </summary>
		public StringValue? Description { get; set; }

		/// <summary>
		/// <para>DAC: PX.Objects.AM.AMDisassembleTran</para>
		/// <para>Display Name: Line Nbr.</para>
		/// Key Field
		/// </summary>
		public IntValue? LineNbr { get; set; }

		public IntValue? ProdAttributeLineNbr { get; set; }

		/// <summary>
		/// <para>DAC Field Name: TransactionRequired</para>
		/// <para>DAC: PX.Objects.AM.AMDisassembleBatchAttribute</para>
		/// </summary>
		public BooleanValue? Required { get; set; }

		public IntValue? TranLineNbr { get; set; }

		/// <summary>
		/// <para>DAC: PX.Objects.AM.AMDisassembleBatchAttribute</para>
		/// <para>SQL Type: nvarchar(255)</para>
		/// </summary>
		public StringValue? Value { get; set; }

	}
}