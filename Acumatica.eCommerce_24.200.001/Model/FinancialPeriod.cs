using System;
using System.Collections.Generic;
using System.Runtime.Serialization;

using Newtonsoft.Json;

using Acumatica.RESTClient.Client;
using Acumatica.RESTClient.ContractBasedApi;
using Acumatica.RESTClient.ContractBasedApi.Model;

namespace Acumatica.eCommerce_24_200_001.Model
{
	[DataContract]
	public class FinancialPeriod : Entity, ITopLevelEntity
	{

		[DataMember(Name="CreatedDateTime", EmitDefaultValue=false)]
		public DateTimeValue? CreatedDateTime { get; set; }

		[DataMember(Name="Details", EmitDefaultValue=false)]
		public List<FinancialPeriodDetail>? Details { get; set; }

		[DataMember(Name="FinancialYear", EmitDefaultValue=false)]
		public StringValue? FinancialYear { get; set; }

		[DataMember(Name="LastModifiedDateTime", EmitDefaultValue=false)]
		public DateTimeValue? LastModifiedDateTime { get; set; }

		[DataMember(Name="NbrOfPeriods", EmitDefaultValue=false)]
		public ShortValue? NbrOfPeriods { get; set; }

		[DataMember(Name="StartDate", EmitDefaultValue=false)]
		public DateTimeValue? StartDate { get; set; }

		[DataMember(Name="UserDefinedPeriods", EmitDefaultValue=false)]
		public BooleanValue? UserDefinedPeriods { get; set; }

		public virtual string GetEndpointPath()
		{
			return "entity/eCommerce/24.200.001";
		}
	}
}