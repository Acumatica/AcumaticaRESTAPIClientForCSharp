using System;
using System.Collections.Generic;

using Newtonsoft.Json;

using Acumatica.RESTClient.Client;
using Acumatica.RESTClient.ContractBasedApi;
using Acumatica.RESTClient.ContractBasedApi.Model;

namespace Acumatica.Default_25_200_001.Model
{
	public class UnionEarningRateDetail : Entity
	{

		#region Fields
		/// <summary>
		/// <para>DAC: PX.Objects.PM.PMUnion</para>
		/// <para>SQL Type: nvarchar(255)</para>
		/// </summary>
		public StringValue? Description { get; set; }

		/// <summary>
		/// The identifier of the inventory item associated with the labor cost rate.
		/// <para>DAC Field Name: InventoryID</para>
		/// <para>DAC: PX.Objects.PM.PMLaborCostRate</para>
		/// <para>Display Name: Labor Item</para>
		/// </summary>
		public StringValue? LaborItem { get; set; }

		/// <summary>
		/// The wage rate for the labor cost rate.
		/// <para>DAC: PX.Objects.PM.PMLaborCostRate</para>
		/// <para>Display Name: Wage Rate</para>
		/// </summary>
		public DecimalValue? WageRate { get; set; }

		/// <summary>
		/// The date on which the labor cost rate becomes effective.
		/// <para>DAC: PX.Objects.PM.PMLaborCostRate</para>
		/// <para>Display Name: Effective Date</para>
		/// </summary>
		public DateTimeValue? EffectiveDate { get; set; }

		public DateTimeValue? LastModifiedDateTime { get; set; }

		#endregion

	}
}