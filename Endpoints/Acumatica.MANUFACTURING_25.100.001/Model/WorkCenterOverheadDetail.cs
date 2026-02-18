using System;
using System.Collections.Generic;

using Newtonsoft.Json;

using Acumatica.RESTClient.Client;
using Acumatica.RESTClient.ContractBasedApi;
using Acumatica.RESTClient.ContractBasedApi.Model;

namespace Acumatica.MANUFACTURING_25_100_001.Model
{
	public class WorkCenterOverheadDetail : Entity
	{

		/// <summary>
		/// <para>DAC Field Name: AMOverhead__Descr</para>
		/// <para>DAC: PX.Objects.AM.AMWCOvhd</para>
		/// </summary>
		public StringValue? Description { get; set; }

		/// <summary>
		/// <para>DAC Field Name: OFactor</para>
		/// <para>DAC: PX.Objects.AM.AMWCOvhd</para>
		/// </summary>
		public DecimalValue? Factor { get; set; }

		/// <summary>
		/// <para>DAC Field Name: OvhdID</para>
		/// <para>DAC: PX.Objects.AM.AMWCOvhd</para>
		/// <para>Display Name: Overhead ID</para>
		/// <para>SQL Type: nvarchar(20)</para>
		/// Key Field
		/// </summary>
		public StringValue? Overhead { get; set; }

		/// <summary>
		/// <para>DAC Field Name: AMOverhead__OvhdType</para>
		/// <para>DAC: PX.Objects.AM.AMWCOvhd</para>
		/// </summary>
		public StringValue? Type { get; set; }

	}
}