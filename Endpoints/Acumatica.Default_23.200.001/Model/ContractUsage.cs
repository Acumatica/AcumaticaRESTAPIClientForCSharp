using System;
using System.Collections.Generic;

using Newtonsoft.Json;

using Acumatica.RESTClient.Client;
using Acumatica.RESTClient.ContractBasedApi;
using Acumatica.RESTClient.ContractBasedApi.Model;

namespace Acumatica.Default_23_200_001.Model
{
	/// <summary>
	/// Corresponds to the screen <c>CT303000</c> in the Acumatica ERP
	/// </summary>
	public class ContractUsage : Entity, ITopLevelEntity
	{

		public List<ContractUsageTransactionDetail>? BilledTransactions { get; set; }

		/// <summary>
		/// <para>DAC: PX.Objects.CT.UsageMaint+UsageFilter</para>
		/// </summary>
		public StringValue? ContractID { get; set; }

		/// <summary>
		/// <para>DAC Field Name: InvFinPeriodID</para>
		/// <para>DAC: PX.Objects.CT.UsageMaint+UsageFilter</para>
		/// </summary>
		public StringValue? PostPeriod { get; set; }

		public List<ContractUsageTransactionDetail>? UnbilledTransactions { get; set; }

		public static class Expand
		{
			public const string Files = "Files";
			public const string Translations = "Translations";
			public const string BilledTransactions = "BilledTransactions";
			public const string BilledTransactions_Files = "BilledTransactions/Files";
			public const string UnbilledTransactions = "UnbilledTransactions";
			public const string UnbilledTransactions_Files = "UnbilledTransactions/Files";

			//Intentionally excluded
			//public const string All = "Files,Translations,BilledTransactions,BilledTransactions/Files,UnbilledTransactions,UnbilledTransactions/Files";
		}
		public virtual string GetEndpointPath()
		{
			return "entity/Default/23.200.001";
		}
	}
}