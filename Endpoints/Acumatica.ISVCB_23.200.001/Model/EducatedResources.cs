using System;
using System.Collections.Generic;
using System.Runtime.Serialization;

using Newtonsoft.Json;

using Acumatica.RESTClient.Client;
using Acumatica.RESTClient.ContractBasedApi;
using Acumatica.RESTClient.ContractBasedApi.Model;

namespace Acumatica.ISVCB_23_200_001.Model
{
	[DataContract]
	public class EducatedResources : Entity, ITopLevelEntity
	{

		[DataMember(Name="AccountID", EmitDefaultValue=false)]
		public IntValue? AccountID { get; set; }

		[DataMember(Name="AccountID_2", EmitDefaultValue=false)]
		public IntValue? AccountID_2 { get; set; }

		[DataMember(Name="AccountID_3", EmitDefaultValue=false)]
		public IntValue? AccountID_3 { get; set; }

		[DataMember(Name="Type", EmitDefaultValue=false)]
		public StringValue? Type { get; set; }

		[DataMember(Name="Type_2", EmitDefaultValue=false)]
		public StringValue? Type_2 { get; set; }

		[DataMember(Name="Class", EmitDefaultValue=false)]
		public StringValue? Class { get; set; }

		[DataMember(Name="Class_2", EmitDefaultValue=false)]
		public StringValue? Class_2 { get; set; }

		[DataMember(Name="Class_3", EmitDefaultValue=false)]
		public StringValue? Class_3 { get; set; }

		[DataMember(Name="Class_4", EmitDefaultValue=false)]
		public StringValue? Class_4 { get; set; }

		[DataMember(Name="Class_5", EmitDefaultValue=false)]
		public StringValue? Class_5 { get; set; }

		[DataMember(Name="Class_6", EmitDefaultValue=false)]
		public StringValue? Class_6 { get; set; }

		[DataMember(Name="ContactID", EmitDefaultValue=false)]
		public IntValue? ContactID { get; set; }

		[DataMember(Name="BusinessAccount", EmitDefaultValue=false)]
		public StringValue? BusinessAccount { get; set; }

		[DataMember(Name="Class_7", EmitDefaultValue=false)]
		public StringValue? Class_7 { get; set; }

		[DataMember(Name="Class_8", EmitDefaultValue=false)]
		public StringValue? Class_8 { get; set; }

		[DataMember(Name="Class_9", EmitDefaultValue=false)]
		public StringValue? Class_9 { get; set; }

		[DataMember(Name="Class_10", EmitDefaultValue=false)]
		public StringValue? Class_10 { get; set; }

		[DataMember(Name="EducatedResourcesDetails", EmitDefaultValue=false)]
		public List<EducatedResourcesDetail>? EducatedResourcesDetails { get; set; }

		public virtual string GetEndpointPath()
		{
			return "entity/ISVCB/23.200.001";
		}
	}
}