using System;
using System.Collections.Generic;

using Newtonsoft.Json;

using Acumatica.RESTClient.Client;
using Acumatica.RESTClient.ContractBasedApi;
using Acumatica.RESTClient.ContractBasedApi.Model;

namespace Acumatica.Manufacturing_24_200_001.Model
{
	public class OrderTypeAttribute : Entity
	{

		/// <summary>
		/// <para>DAC: PX.Objects.AM.AMOrderTypeAttribute</para>
		/// <para>Display Name: Attribute ID</para>
		/// <para>SQL Type: nvarchar(10)</para>
		/// </summary>
		public StringValue? AttributeID { get; set; }

		/// <summary>
		/// <para>DAC Field Name: Descr</para>
		/// <para>DAC: PX.Objects.AM.AMOrderType</para>
		/// <para>SQL Type: nvarchar(60)</para>
		/// </summary>
		public StringValue? Description { get; set; }

		/// <summary>
		/// <para>DAC: PX.Objects.AM.AMOrderTypeAttribute</para>
		/// </summary>
		public BooleanValue? Enabled { get; set; }

		/// <summary>
		/// <para>DAC: PX.Objects.AM.AMOrderTypeAttribute</para>
		/// <para>SQL Type: nvarchar(30)</para>
		/// </summary>
		public StringValue? Label { get; set; }

		/// <summary>
		/// <para>DAC: PX.Objects.AM.AMOrderTypeAttribute</para>
		/// <para>Display Name: Line Nbr</para>
		/// Key Field
		/// </summary>
		public IntValue? LineNbr { get; set; }

		/// <summary>
		/// <para>DAC: PX.Objects.AM.AMOrderTypeAttribute</para>
		/// <para>Display Name: Transaction Required</para>
		/// </summary>
		public BooleanValue? TransactionRequired { get; set; }

		/// <summary>
		/// <para>DAC: PX.Objects.AM.AMOrderTypeAttribute</para>
		/// <para>SQL Type: nvarchar(255)</para>
		/// </summary>
		public StringValue? Value { get; set; }

	}
}