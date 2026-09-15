using System;
using System.Collections.Generic;
using System.Runtime.Serialization;

using Newtonsoft.Json;

using Acumatica.RESTClient.Client;
using Acumatica.RESTClient.ContractBasedApi;
using Acumatica.RESTClient.ContractBasedApi.Model;

namespace Acumatica.Default_26_200_001.Model
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

		/// <summary>
		/// Names that can be passed in the <c>$expand</c> parameter.
		/// <para>This endpoint uses system contract 5, where a nested entity is expanded
		/// as <c>Parent($expand=Child)</c> rather than <c>Parent/Child</c>, so only the names
		/// that can be expanded directly on this entity are listed here. Use the nested
		/// entity's own <c>Expand</c> class for the inner names.</para>
		/// </summary>
		public static class Expand
		{
			public const string Files = "Files";
			public const string Translations = "Translations";
			public const string BilledTransactions = "BilledTransactions";
			public const string UnbilledTransactions = "UnbilledTransactions";

			//Intentionally excluded
			//public const string All = "Files,Translations,BilledTransactions,UnbilledTransactions";
		}
		public virtual string GetEndpointPath()
		{
			return "entity/Default/26.200.001";
		}
	}
}