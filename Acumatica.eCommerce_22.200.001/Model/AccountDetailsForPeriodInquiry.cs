using System.Collections.Generic;
using System.Runtime.Serialization;

using Newtonsoft.Json;

using Acumatica.RESTClient.Client;
using Acumatica.RESTClient.ContractBasedApi;
using Acumatica.RESTClient.ContractBasedApi.Model;

namespace Acumatica.eCommerce_22_200_001.Model
{
	[DataContract]
	public class AccountDetailsForPeriodInquiry : Entity, ITopLevelEntity
	{

		[DataMember(Name="FromPeriod", EmitDefaultValue=false)]
		public StringValue FromPeriod { get; set; }

		[DataMember(Name="Ledger", EmitDefaultValue=false)]
		public StringValue Ledger { get; set; }

		[DataMember(Name="Results", EmitDefaultValue=false)]
		public List<AccountDetailsForPeriodInquiryDetail> Results { get; set; }

		[DataMember(Name="ToPeriod", EmitDefaultValue=false)]
		public StringValue ToPeriod { get; set; }

		[DataMember(Name="IncludeUnposted", EmitDefaultValue=false)]
		public BooleanValue IncludeUnposted { get; set; }

		[DataMember(Name="IncludeUnreleased", EmitDefaultValue=false)]
		public BooleanValue IncludeUnreleased { get; set; }

		public string GetEndpointPath()
		{
			return "entity/eCommerce/22.200.001";
		}
	}
}