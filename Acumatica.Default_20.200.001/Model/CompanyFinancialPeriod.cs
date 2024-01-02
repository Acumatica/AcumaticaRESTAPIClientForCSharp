using System.Collections.Generic;
using System.Runtime.Serialization;

using Newtonsoft.Json;

using Acumatica.RESTClient.Client;
using Acumatica.RESTClient.ContractBasedApi;
using Acumatica.RESTClient.ContractBasedApi.Model;

namespace Acumatica.Default_20_200_001.Model
{
	[DataContract]
	public class CompanyFinancialPeriod : Entity, ITopLevelEntity
	{

		[DataMember(Name="Company", EmitDefaultValue=false)]
		public StringValue? Company { get; set; }

		[DataMember(Name="Details", EmitDefaultValue=false)]
		public List<FinancialPeriodDetail>? Details { get; set; }

		[DataMember(Name="FinancialYear", EmitDefaultValue=false)]
		public StringValue? FinancialYear { get; set; }

		[DataMember(Name="NbrOfPeriods", EmitDefaultValue=false)]
		public ShortValue? NbrOfPeriods { get; set; }

		[DataMember(Name="StartDate", EmitDefaultValue=false)]
		public DateTimeValue? StartDate { get; set; }

		public virtual string GetEndpointPath()
		{
			return "entity/Default/20.200.001";
		}
	}
}