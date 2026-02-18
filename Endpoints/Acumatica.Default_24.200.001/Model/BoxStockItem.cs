using System;
using System.Collections.Generic;

using Newtonsoft.Json;

using Acumatica.RESTClient.Client;
using Acumatica.RESTClient.ContractBasedApi;
using Acumatica.RESTClient.ContractBasedApi.Model;

namespace Acumatica.Default_24_200_001.Model
{
	public class BoxStockItem : Entity
	{

		/// <summary>
		/// <para>DAC: PX.Objects.IN.INItemBoxEx</para>
		/// <para>Display Name: Box ID</para>
		/// <para>SQL Type: nvarchar(15)</para>
		/// Key Field
		/// </summary>
		public StringValue? BoxID { get; set; }

		/// <summary>
		/// <para>DAC: PX.Objects.IN.INItemBoxEx</para>
		/// <para>SQL Type: nvarchar(255)</para>
		/// </summary>
		public StringValue? Description { get; set; }

		/// <summary>
		/// <para>DAC: PX.Objects.IN.INItemRep</para>
		/// <para>Display Name: Max Qty.</para>
		/// </summary>
		public DecimalValue? MaxQty { get; set; }

		/// <summary>
		/// <para>DAC: PX.Objects.IN.INItemBoxEx</para>
		/// <para>Display Name: Max Volume</para>
		/// </summary>
		public DecimalValue? MaxVolume { get; set; }

		/// <summary>
		/// <para>DAC: PX.Objects.IN.INItemBoxEx</para>
		/// <para>Display Name: Max. Weight</para>
		/// </summary>
		public DecimalValue? MaxWeight { get; set; }

		/// <summary>
		/// <para>DAC: PX.Objects.IN.INComponent</para>
		/// <para>Display Name: Quantity</para>
		/// </summary>
		public DecimalValue? Qty { get; set; }

		/// <summary>
		/// <para>DAC: PX.Objects.IN.INComponent</para>
		/// <para>SQL Type: nvarchar(6)</para>
		/// </summary>
		public StringValue? UOM { get; set; }

	}
}