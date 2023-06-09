using System.Collections.Generic;
using System.Runtime.Serialization;

using Newtonsoft.Json;

using Acumatica.RESTClient.Client;
using Acumatica.RESTClient.ContractBasedApi;
using Acumatica.RESTClient.ContractBasedApi.Model;

namespace Acumatica.eCommerce_22_200_001.Model
{
	[DataContract]
	public class CaseRelatedCase : Entity
	{

		[DataMember(Name="CaseID", EmitDefaultValue=false)]
		public StringValue CaseID { get; set; }

		[DataMember(Name="Owner", EmitDefaultValue=false)]
		public StringValue Owner { get; set; }

		[DataMember(Name="ParentCaseID", EmitDefaultValue=false)]
		public StringValue ParentCaseID { get; set; }

		[DataMember(Name="RelationType", EmitDefaultValue=false)]
		public StringValue RelationType { get; set; }

		[DataMember(Name="Status", EmitDefaultValue=false)]
		public StringValue Status { get; set; }

		[DataMember(Name="Subject", EmitDefaultValue=false)]
		public StringValue Subject { get; set; }

		[DataMember(Name="Workgroup", EmitDefaultValue=false)]
		public StringValue Workgroup { get; set; }

	}
}