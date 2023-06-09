using System.Collections.Generic;
using System.Runtime.Serialization;

using Newtonsoft.Json;

using Acumatica.RESTClient.Client;
using Acumatica.RESTClient.ContractBasedApi;
using Acumatica.RESTClient.ContractBasedApi.Model;

namespace Acumatica.Default_20_200_001.Model
{
	[DataContract]
	public class ChangeOrderClass : Entity
	{

		[DataMember(Name="Active", EmitDefaultValue=false)]
		public BooleanValue Active { get; set; }

		[DataMember(Name="Attributes", EmitDefaultValue=false)]
		public List<BusinessAccountClassAttributeDetail> Attributes { get; set; }

		[DataMember(Name="ClassID", EmitDefaultValue=false)]
		public StringValue ClassID { get; set; }

		[DataMember(Name="Commitments", EmitDefaultValue=false)]
		public BooleanValue Commitments { get; set; }

		[DataMember(Name="CostBudget", EmitDefaultValue=false)]
		public BooleanValue CostBudget { get; set; }

		[DataMember(Name="Description", EmitDefaultValue=false)]
		public StringValue Description { get; set; }

		[DataMember(Name="LastModifiedDateTime", EmitDefaultValue=false)]
		public DateTimeValue LastModifiedDateTime { get; set; }

		[DataMember(Name="RevenueBudget", EmitDefaultValue=false)]
		public BooleanValue RevenueBudget { get; set; }

	}
}