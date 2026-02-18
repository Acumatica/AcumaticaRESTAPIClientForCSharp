using System;
using System.Collections.Generic;

using Newtonsoft.Json;

using Acumatica.RESTClient.Client;
using Acumatica.RESTClient.ContractBasedApi;
using Acumatica.RESTClient.ContractBasedApi.Model;

namespace Acumatica.MANUFACTURING_25_100_001.Model
{
	/// <summary>
	/// Corresponds to the screen <c>AM501000</c> in the Acumatica ERP
	/// </summary>
	public class RoughCutPlanning : Entity, ITopLevelEntity
	{

		public List<RoughCutPlanningDetail>? Detail { get; set; }

		/// <summary>
		/// Show/hide orders which are schedule status Firm
		/// <para>DAC: PX.Objects.AM.APSRoughCutProcessFilter</para>
		/// <para>Display Name: Exclude Firm Orders</para>
		/// </summary>
		public BooleanValue? ExcludeFirmOrders { get; set; }

		/// <summary>
		/// Show/hide planning type orders
		/// <para>DAC: PX.Objects.AM.APSRoughCutProcessFilter</para>
		/// <para>Display Name: Exclude Planning Orders</para>
		/// </summary>
		public BooleanValue? ExcludePlanningOrders { get; set; }

		/// <summary>
		/// <para>DAC: PX.Objects.AM.APSRoughCutProcessFilter</para>
		/// <para>Display Name: Action</para>
		/// <para>SQL Type: nchar(1)</para>
		/// </summary>
		public StringValue? ProcessAction { get; set; }

		/// <summary>
		/// During processing, should the selected orders be released (true)
		/// <para>DAC: PX.Objects.AM.APSRoughCutProcessFilter</para>
		/// <para>Display Name: Release Orders</para>
		/// </summary>
		public BooleanValue? ReleaseOrders { get; set; }

		public static class Expand
		{
			public const string Files = "Files";
			public const string Translations = "Translations";
			public const string Detail = "Detail";
			public const string Detail_Files = "Detail/Files";

			//Intentionally excluded
			//public const string All = "Files,Translations,Detail,Detail/Files";
		}
		public virtual string GetEndpointPath()
		{
			return "entity/MANUFACTURING/25.100.001";
		}
	}
}