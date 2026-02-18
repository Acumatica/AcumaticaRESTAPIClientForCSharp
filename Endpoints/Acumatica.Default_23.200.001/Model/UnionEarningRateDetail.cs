using System;
using System.Collections.Generic;

using Newtonsoft.Json;

using Acumatica.RESTClient.Client;
using Acumatica.RESTClient.ContractBasedApi;
using Acumatica.RESTClient.ContractBasedApi.Model;

namespace Acumatica.Default_23_200_001.Model
{
	public class UnionEarningRateDetail : Entity
	{

		/// <summary>
		/// <para>DAC: PX.Objects.PM.PMUnion</para>
		/// <para>SQL Type: nvarchar(255)</para>
		/// </summary>
		public StringValue? Description { get; set; }

		/// <summary>
		/// <para>DAC: PX.Objects.PM.PMLaborCostRate</para>
		/// <para>Display Name: Effective Date</para>
		/// </summary>
		public DateTimeValue? EffectiveDate { get; set; }

		/// <summary>
		/// <para>DAC Field Name: InventoryID</para>
		/// <para>DAC: PX.Objects.PM.PMLaborCostRate</para>
		/// <para>Display Name: Labor Item</para>
		/// </summary>
		public StringValue? LaborItem { get; set; }

		public DateTimeValue? LastModifiedDateTime { get; set; }

		/// <summary>
		/// <para>DAC: PX.Objects.PM.PMLaborCostRate</para>
		/// <para>Display Name: Wage Rate</para>
		/// </summary>
		public DecimalValue? WageRate { get; set; }

	}
}