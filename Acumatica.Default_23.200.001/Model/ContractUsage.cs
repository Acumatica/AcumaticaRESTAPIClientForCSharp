using System;
using System.Collections.Generic;
using System.Runtime.Serialization;

using Newtonsoft.Json;

using Acumatica.RESTClient.Client;
using Acumatica.RESTClient.ContractBasedApi;
using Acumatica.RESTClient.ContractBasedApi.Model;

namespace Acumatica.Default_23_200_001.Model
{
	/// <summary>
	/// Corresponds to the screen CT303000 in the Acumatica ERP
	/// </summary>
	[DataContract]
	public class ContractUsage : Entity, ITopLevelEntity
	{

		[DataMember(Name="BilledTransactions", EmitDefaultValue=false)]
		public List<ContractUsageTransactionDetail>? BilledTransactions { get; set; }

		/// <summary>
		/// 
		/// Display Name:
		/// DAC Field Name: ContractID 
		/// DAC: PX.Objects.CT.UsageMaint+UsageFilter 
		/// </summary>
		/// <remarks>
		/// 
		/// </remarks>
		[DataMember(Name="ContractID", EmitDefaultValue=false)]
		public StringValue? ContractID { get; set; }

		/// <summary>
		/// 
		/// Display Name:
		/// DAC Field Name: InvFinPeriodID 
		/// DAC: PX.Objects.CT.UsageMaint+UsageFilter 
		/// </summary>
		/// <remarks>
		/// 
		/// </remarks>
		[DataMember(Name="PostPeriod", EmitDefaultValue=false)]
		public StringValue? PostPeriod { get; set; }

		[DataMember(Name="UnbilledTransactions", EmitDefaultValue=false)]
		public List<ContractUsageTransactionDetail>? UnbilledTransactions { get; set; }

		public virtual string GetEndpointPath()
		{
			return "entity/Default/23.200.001";
		}
	}
}