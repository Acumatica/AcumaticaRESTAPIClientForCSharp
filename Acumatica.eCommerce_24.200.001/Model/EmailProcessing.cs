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
	public class EmailProcessing : Entity, ITopLevelEntity
	{

		[DataMember(Name="Account", EmitDefaultValue=false)]
		public IntValue? Account { get; set; }

		[DataMember(Name="AccountEmailAccountID", EmitDefaultValue=false)]
		public StringValue? AccountEmailAccountID { get; set; }

		[DataMember(Name="AssignedToMe", EmitDefaultValue=false)]
		public BooleanValue? AssignedToMe { get; set; }

		[DataMember(Name="AssignedToOwner", EmitDefaultValue=false)]
		public StringValue? AssignedToOwner { get; set; }

		[DataMember(Name="IncludeFailed", EmitDefaultValue=false)]
		public BooleanValue? IncludeFailed { get; set; }

		[DataMember(Name="Result", EmitDefaultValue=false)]
		public List<EmailProcessingRow>? Result { get; set; }

		[DataMember(Name="Type", EmitDefaultValue=false)]
		public StringValue? Type { get; set; }

		public virtual string GetEndpointPath()
		{
			return "entity/eCommerce/24.200.001";
		}
	}
}