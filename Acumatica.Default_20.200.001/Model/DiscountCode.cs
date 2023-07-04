using System.Collections.Generic;
using System.Runtime.Serialization;

using Newtonsoft.Json;

using Acumatica.RESTClient.Client;
using Acumatica.RESTClient.ContractBasedApi;
using Acumatica.RESTClient.ContractBasedApi.Model;

namespace Acumatica.Default_20_200_001.Model
{
	[DataContract]
	public class DiscountCode : Entity, ITopLevelEntity
	{

		[DataMember(Name="ApplicableTo", EmitDefaultValue=false)]
		public StringValue ApplicableTo { get; set; }

		[DataMember(Name="CreatedDateTime", EmitDefaultValue=false)]
		public DateTimeValue CreatedDateTime { get; set; }

		[DataMember(Name="Description", EmitDefaultValue=false)]
		public StringValue Description { get; set; }

		[DataMember(Name="DiscountCodeID", EmitDefaultValue=false)]
		public StringValue DiscountCodeID { get; set; }

		[DataMember(Name="DiscountType", EmitDefaultValue=false)]
		public StringValue DiscountType { get; set; }

		[DataMember(Name="LastModifiedDateTime", EmitDefaultValue=false)]
		public DateTimeValue LastModifiedDateTime { get; set; }

		public string GetEndpointPath()
		{
			return "entity/Default/20.200.001";
		}
	}
}