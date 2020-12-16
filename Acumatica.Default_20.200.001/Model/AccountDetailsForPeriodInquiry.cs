using Acumatica.RESTClient.Model;
using System.Collections.Generic;
using System.Runtime.Serialization;

namespace Acumatica.Default_20_200_001.Model
{
	[DataContract]
	public class AccountDetailsForPeriodInquiry : Entity_v4
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

	}
}