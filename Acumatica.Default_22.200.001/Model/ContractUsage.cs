using System.Collections.Generic;
using System.Runtime.Serialization;

using Newtonsoft.Json;

using Acumatica.RESTClient.Client;
using Acumatica.RESTClient.ContractBasedApi;
using Acumatica.RESTClient.ContractBasedApi.Model;

namespace Acumatica.Default_22_200_001.Model
{
	[DataContract]
	public class ContractUsage : Entity, ITopLevelEntity
	{

		[DataMember(Name="BilledTransactions", EmitDefaultValue=false)]
		public List<ContractUsageTransactionDetail>? BilledTransactions { get; set; }

		[DataMember(Name="ContractID", EmitDefaultValue=false)]
		public StringValue? ContractID { get; set; }

		[DataMember(Name="PostPeriod", EmitDefaultValue=false)]
		public StringValue? PostPeriod { get; set; }

		[DataMember(Name="UnbilledTransactions", EmitDefaultValue=false)]
		public List<ContractUsageTransactionDetail>? UnbilledTransactions { get; set; }

		public virtual string GetEndpointPath()
		{
			return "entity/Default/22.200.001";
		}
	}
}