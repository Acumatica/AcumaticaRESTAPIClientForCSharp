using System;
using System.Collections.Generic;

using Newtonsoft.Json;

using Acumatica.RESTClient.Client;
using Acumatica.RESTClient.ContractBasedApi;
using Acumatica.RESTClient.ContractBasedApi.Model;

namespace Acumatica.Manufacturing_24_200_001.Model
{
	public class AttributeDetail : Entity
	{

		/// <summary>
		/// The identifier of the bill of material.
		/// <para>DAC Field Name: BOMID</para>
		/// <para>DAC: PX.Objects.AM.AMBomItem</para>
		/// <para>Display Name: BOM ID</para>
		/// <para>SQL Type: nvarchar(15)</para>
		/// Key Field
		/// </summary>
		public StringValue? AttributeBOMID { get; set; }

		/// <summary>
		/// The ID of the attribute.
		/// <para>DAC: PX.Objects.AM.AMBomAttribute</para>
		/// <para>Display Name: Attribute ID</para>
		/// <para>SQL Type: nvarchar(10)</para>
		/// </summary>
		public StringValue? AttributeID { get; set; }

		/// <summary>
		/// The default value that is copied onto the production order or operation.
		/// <para>DAC Field Name: Value</para>
		/// <para>DAC: PX.Objects.AM.AMBomAttribute</para>
		/// <para>Display Name: Value</para>
		/// <para>SQL Type: nvarchar(255)</para>
		/// </summary>
		public StringValue? DefaultValue { get; set; }

		/// <summary>
		/// A description of the bill of material. The system copies the description to production orders that are created by using the bill of material.
		/// <para>DAC Field Name: Descr</para>
		/// <para>DAC: PX.Objects.AM.AMBomItem</para>
		/// <para>SQL Type: nvarchar(256)</para>
		/// </summary>
		public StringValue? Description { get; set; }

		/// <summary>
		/// A Boolean value that indicates (if set to true) that the value can be changed in the production order and entered when reporting production.
		/// <para>DAC: PX.Objects.AM.AMBomAttribute</para>
		/// </summary>
		public BooleanValue? Enabled { get; set; }

		/// <summary>
		/// The unique label.
		/// <para>DAC: PX.Objects.AM.AMBomAttribute</para>
		/// <para>SQL Type: nvarchar(30)</para>
		/// </summary>
		public StringValue? Label { get; set; }

		/// <summary>
		/// The attribute level, which is specified automatically.
		/// <para>DAC: PX.Objects.AM.AMBomAttribute</para>
		/// </summary>
		public StringValue? Level { get; set; }

		/// <summary>
		/// The line number.
		/// <para>DAC: PX.Objects.AM.AMBomAttribute</para>
		/// <para>Display Name: Line Nbr.</para>
		/// Key Field
		/// </summary>
		public IntValue? LineNbr { get; set; }

		/// <summary>
		/// The operation number from the bill of material.
		/// <para>DAC Field Name: OperationID</para>
		/// <para>DAC: PX.Objects.AM.AMBomAttribute</para>
		/// <para>Display Name: Operation ID</para>
		/// </summary>
		public StringValue? OperNbr { get; set; }

		/// <summary>
		/// The field that specifies where the attribute can be used.
		/// <para>DAC: PX.Objects.AM.AMBomAttribute</para>
		/// <para>Display Name: Order Function</para>
		/// </summary>
		public StringValue? OrderFunction { get; set; }

		/// <summary>
		/// A Boolean value that indicates (if set to true) that the value must be specified before the production transaction batch is released.
		/// <para>DAC: PX.Objects.AM.AMBomAttribute</para>
		/// <para>Display Name: Transaction Required</para>
		/// </summary>
		public BooleanValue? TransactionRequired { get; set; }

	}
}