using System;
using System.Collections.Generic;
using System.Runtime.Serialization;

using Newtonsoft.Json;

using Acumatica.RESTClient.Client;
using Acumatica.RESTClient.ContractBasedApi;
using Acumatica.RESTClient.ContractBasedApi.Model;

namespace Acumatica.Default_25_200_001.Model
{
	/// <summary>
	/// Corresponds to the screen <c>CT303000</c> in the Acumatica ERP
	/// </summary>
	[DataContract]
	public class ContractUsage : Entity, ITopLevelEntity
	{

		[DataMember(Name="BilledTransactions", EmitDefaultValue=false)]
		public List<ContractUsageTransactionDetail>? BilledTransactions { get; set; }

		/// <summary>
		/// <para>DAC: PX.Objects.CT.UsageMaint+UsageFilter</para>
		/// </summary>
		[DataMember(Name="ContractID", EmitDefaultValue=false)]
		public StringValue? ContractID { get; set; }

		/// <summary>
		/// <para>DAC Field Name: InvFinPeriodID</para>
		/// <para>DAC: PX.Objects.CT.UsageMaint+UsageFilter</para>
		/// </summary>
		[DataMember(Name="PostPeriod", EmitDefaultValue=false)]
		public StringValue? PostPeriod { get; set; }

		[DataMember(Name="UnbilledTransactions", EmitDefaultValue=false)]
		public List<ContractUsageTransactionDetail>? UnbilledTransactions { get; set; }

		public static class Expand
		{
			public const string Files = "Files";
			public const string BilledTransactions = "BilledTransactions";
			public const string BilledTransactions_Files = "BilledTransactions/Files";
			public const string UnbilledTransactions = "UnbilledTransactions";
			public const string UnbilledTransactions_Files = "UnbilledTransactions/Files";

			//Intentionally excluded
			//public const string All = "Files,BilledTransactions,BilledTransactions/Files,UnbilledTransactions,UnbilledTransactions/Files";
		}
		public virtual string GetEndpointPath()
		{
			return "entity/Default/25.200.001";
		}
	}
}