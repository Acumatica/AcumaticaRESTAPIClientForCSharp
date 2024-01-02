using System.Collections.Generic;
using System.Runtime.Serialization;

using Newtonsoft.Json;

using Acumatica.RESTClient.Client;
using Acumatica.RESTClient.ContractBasedApi;
using Acumatica.RESTClient.ContractBasedApi.Model;

namespace Acumatica.Default_22_200_001.Model
{
	[DataContract]
	public class PayPeriod : Entity, ITopLevelEntity
	{

		[DataMember(Name="LastModifiedDateTime", EmitDefaultValue=false)]
		public DateTimeValue? LastModifiedDateTime { get; set; }

		[DataMember(Name="NumberofPeriods", EmitDefaultValue=false)]
		public ShortValue? NumberofPeriods { get; set; }

		[DataMember(Name="Override", EmitDefaultValue=false)]
		public BooleanValue? Override { get; set; }

		[DataMember(Name="PayGroup", EmitDefaultValue=false)]
		public StringValue? PayGroup { get; set; }

		[DataMember(Name="PaymentPeriods", EmitDefaultValue=false)]
		public List<PaymentPeriod>? PaymentPeriods { get; set; }

		[DataMember(Name="StartDate", EmitDefaultValue=false)]
		public DateTimeValue? StartDate { get; set; }

		[DataMember(Name="Year", EmitDefaultValue=false)]
		public StringValue? Year { get; set; }

		public virtual string GetEndpointPath()
		{
			return "entity/Default/22.200.001";
		}
	}
}