using System;
using System.Collections.Generic;
using System.Runtime.Serialization;

using Newtonsoft.Json;

using Acumatica.RESTClient.Client;
using Acumatica.RESTClient.ContractBasedApi;
using Acumatica.RESTClient.ContractBasedApi.Model;

namespace Acumatica.ISVCB_21_200_001.Model
{
	[DataContract]
	public class EducatedResources : Entity, ITopLevelEntity
	{

		[DataMember(Name="BusinessAccount", EmitDefaultValue=false)]
		public StringValue? BusinessAccount { get; set; }

		[DataMember(Name="EducatedResourcesDetails", EmitDefaultValue=false)]
		public List<EducatedResourcesDetail>? EducatedResourcesDetails { get; set; }

		public static class Expand
		{
			public const string Files = "Files";
			public const string EducatedResourcesDetails = "EducatedResourcesDetails";
			public const string EducatedResourcesDetails_Files = "EducatedResourcesDetails/Files";

			//Intentionally excluded
			//public const string All = "Files,EducatedResourcesDetails,EducatedResourcesDetails/Files";
		}
		public virtual string GetEndpointPath()
		{
			return "entity/ISVCB/21.200.001";
		}
	}
}