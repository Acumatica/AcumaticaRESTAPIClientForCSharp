using System;
using System.Collections.Generic;

using Newtonsoft.Json;

using Acumatica.RESTClient.Client;
using Acumatica.RESTClient.ContractBasedApi;
using Acumatica.RESTClient.ContractBasedApi.Model;

namespace Acumatica.Manufacturing_24_200_001.Model
{
	public class OrderAttributeDetail : Entity
	{

		/// <summary>
		/// <para>DAC: PX.Objects.AM.AMProdAttribute</para>
		/// <para>Display Name: Attribute ID</para>
		/// <para>SQL Type: nvarchar(10)</para>
		/// </summary>
		public StringValue? AttributeID { get; set; }

		/// <summary>
		/// <para>DAC Field Name: Descr</para>
		/// <para>DAC: PX.Objects.AM.AMProdItem</para>
		/// <para>Display Name: Order Description</para>
		/// <para>SQL Type: nvarchar(256)</para>
		/// </summary>
		public StringValue? Description { get; set; }

		/// <summary>
		/// <para>DAC: PX.Objects.AM.AMProdAttribute</para>
		/// </summary>
		public BooleanValue? Enabled { get; set; }

		/// <summary>
		/// <para>DAC: PX.Objects.AM.AMProdAttribute</para>
		/// <para>SQL Type: nvarchar(30)</para>
		/// </summary>
		public StringValue? Label { get; set; }

		/// <summary>
		/// <para>DAC: PX.Objects.AM.AMProdAttribute</para>
		/// </summary>
		public StringValue? Level { get; set; }

		/// <summary>
		/// <para>DAC: PX.Objects.AM.AMProdEvnt</para>
		/// <para>Display Name: Event Line Number</para>
		/// Key Field
		/// </summary>
		public IntValue? LineNbr { get; set; }

		/// <summary>
		/// <para>DAC Field Name: OperationID</para>
		/// <para>DAC: PX.Objects.AM.AMProdAttribute</para>
		/// <para>Display Name: Operation ID</para>
		/// </summary>
		public StringValue? OperationNbr { get; set; }

		/// <summary>
		/// <para>DAC: PX.Objects.AM.AMProdItem</para>
		/// <para>Display Name: Order Type</para>
		/// <para>SQL Type: char(2)</para>
		/// Key Field
		/// </summary>
		public StringValue? OrderType { get; set; }

		/// <summary>
		/// <para>DAC Field Name: ProdOrdID</para>
		/// <para>DAC: PX.Objects.AM.AMProdItem</para>
		/// <para>Display Name: Production Nbr.</para>
		/// <para>SQL Type: nvarchar(19)</para>
		/// Key Field
		/// </summary>
		public StringValue? ProductionNbr { get; set; }

		/// <summary>
		/// <para>DAC: PX.Objects.AM.AMProdAttribute</para>
		/// </summary>
		public StringValue? Source { get; set; }

		/// <summary>
		/// <para>DAC: PX.Objects.AM.AMProdAttribute</para>
		/// <para>Display Name: Transaction Required</para>
		/// </summary>
		public BooleanValue? TransactionRequired { get; set; }

		/// <summary>
		/// <para>DAC: PX.Objects.AM.AMProdAttribute</para>
		/// <para>SQL Type: nvarchar(255)</para>
		/// </summary>
		public StringValue? Value { get; set; }

	}
}