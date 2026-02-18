using System;
using System.Collections.Generic;

using Newtonsoft.Json;

using Acumatica.RESTClient.Client;
using Acumatica.RESTClient.ContractBasedApi;
using Acumatica.RESTClient.ContractBasedApi.Model;

namespace Acumatica.Manufacturing_24_200_001.Model
{
	public class EstimateOverheadDetail : Entity
	{

		/// <summary>
		/// <para>DAC: PX.Objects.AM.AMEstimateOper</para>
		/// <para>Display Name: Operation Desc</para>
		/// <para>SQL Type: nvarchar(256)</para>
		/// </summary>
		public StringValue? Description { get; set; }

		/// <summary>
		/// <para>DAC Field Name: OFactor</para>
		/// <para>DAC: PX.Objects.AM.AMEstimateOvhd</para>
		/// </summary>
		public DecimalValue? Factor { get; set; }

		/// <summary>
		/// <para>DAC Field Name: LineID</para>
		/// <para>DAC: PX.Objects.AM.AMEstimateMatl</para>
		/// <para>Display Name: Line Nbr.</para>
		/// Key Field
		/// </summary>
		public IntValue? LineNbr { get; set; }

		/// <summary>
		/// <para>DAC: PX.Objects.AM.AMEstimateOvhd</para>
		/// <para>Display Name: Overhead Cost Rate</para>
		/// </summary>
		public DecimalValue? OverheadCostRate { get; set; }

		/// <summary>
		/// <para>DAC Field Name: OvhdID</para>
		/// <para>DAC: PX.Objects.AM.AMEstimateOvhd</para>
		/// <para>Display Name: Overhead ID</para>
		/// <para>SQL Type: nvarchar(20)</para>
		/// </summary>
		public StringValue? OverheadID { get; set; }

		/// <summary>
		/// AMOverhead type
		/// <para>DAC Field Name: OvhdType</para>
		/// <para>DAC: PX.Objects.AM.AMEstimateOvhd</para>
		/// <para>SQL Type: char(1)</para>
		/// </summary>
		public StringValue? Type { get; set; }

		/// <summary>
		/// <para>DAC: PX.Objects.AM.AMEstimateOvhd</para>
		/// <para>Display Name: WC Flag</para>
		/// </summary>
		public BooleanValue? WCFlag { get; set; }

	}
}