using System.Collections.Generic;
using System.Runtime.Serialization;

using Newtonsoft.Json;

using Acumatica.RESTClient.Client;
using Acumatica.RESTClient.ContractBasedApi;
using Acumatica.RESTClient.ContractBasedApi.Model;

namespace Acumatica.eCommerce_22_200_001.Model
{
	[DataContract]
	public class WorkLocation : Entity, ITopLevelEntity
	{

		[DataMember(Name="Active", EmitDefaultValue=false)]
		public BooleanValue? Active { get; set; }

		[DataMember(Name="AddressInfo", EmitDefaultValue=false)]
		public Address? AddressInfo { get; set; }

		[DataMember(Name="LastModifiedDateTime", EmitDefaultValue=false)]
		public DateTimeValue? LastModifiedDateTime { get; set; }

		[DataMember(Name="UseAddressfromBranchID", EmitDefaultValue=false)]
		public StringValue? UseAddressfromBranchID { get; set; }

		[DataMember(Name="WorkLocationID", EmitDefaultValue=false)]
		public StringValue? WorkLocationID { get; set; }

		[DataMember(Name="WorkLocationName", EmitDefaultValue=false)]
		public StringValue? WorkLocationName { get; set; }

		public virtual string GetEndpointPath()
		{
			return "entity/eCommerce/22.200.001";
		}
	}
}