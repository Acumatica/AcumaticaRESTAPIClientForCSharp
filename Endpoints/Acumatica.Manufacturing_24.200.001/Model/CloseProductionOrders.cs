using System;
using System.Collections.Generic;

using Newtonsoft.Json;

using Acumatica.RESTClient.Client;
using Acumatica.RESTClient.ContractBasedApi;
using Acumatica.RESTClient.ContractBasedApi.Model;

namespace Acumatica.Manufacturing_24_200_001.Model
{
	/// <summary>
	/// Corresponds to the screen <c>AM506000</c> in the Acumatica ERP
	/// </summary>
	public class CloseProductionOrders : Entity, ITopLevelEntity
	{

		public List<CloseProductionOrdersDetail>? Details { get; set; }

		/// <summary>
		/// <para>DAC Field Name: FinancialPeriodID</para>
		/// <para>DAC: PX.Objects.AM.FinancialPeriod</para>
		/// <para>SQL Type: char(6)</para>
		/// </summary>
		public StringValue? Period { get; set; }

		public static class Expand
		{
			public const string Files = "Files";
			public const string Translations = "Translations";
			public const string Details = "Details";
			public const string Details_Files = "Details/Files";

			//Intentionally excluded
			//public const string All = "Files,Translations,Details,Details/Files";
		}
		public virtual string GetEndpointPath()
		{
			return "entity/MANUFACTURING/24.200.001";
		}
	}
}