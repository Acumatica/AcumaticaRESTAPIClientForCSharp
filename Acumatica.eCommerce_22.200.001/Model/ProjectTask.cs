using System.Collections.Generic;
using System.Runtime.Serialization;

using Newtonsoft.Json;

using Acumatica.RESTClient.Client;
using Acumatica.RESTClient.ContractBasedApi;
using Acumatica.RESTClient.ContractBasedApi.Model;

namespace Acumatica.eCommerce_22_200_001.Model
{
	[DataContract]
	public class ProjectTask : Entity, ITopLevelEntity
	{

		[DataMember(Name="ActivityHistory", EmitDefaultValue=false)]
		public List<ProjectActivity> ActivityHistory { get; set; }

		[DataMember(Name="Attributes", EmitDefaultValue=false)]
		public List<AttributeValue> Attributes { get; set; }

		[DataMember(Name="BillingAndAllocationSettings", EmitDefaultValue=false)]
		public ProjectTaskBillingAndAllocationSettings BillingAndAllocationSettings { get; set; }

		[DataMember(Name="CRMLink", EmitDefaultValue=false)]
		public ProjectTaskToCRMLink CRMLink { get; set; }

		[DataMember(Name="Default", EmitDefaultValue=false)]
		public BooleanValue Default { get; set; }

		[DataMember(Name="DefaultValues", EmitDefaultValue=false)]
		public ProjectTaskDefaultValues DefaultValues { get; set; }

		[DataMember(Name="Description", EmitDefaultValue=false)]
		public StringValue Description { get; set; }

		[DataMember(Name="ExternalRefNbr", EmitDefaultValue=false)]
		public StringValue ExternalRefNbr { get; set; }

		[DataMember(Name="LastModifiedDateTime", EmitDefaultValue=false)]
		public DateTimeValue LastModifiedDateTime { get; set; }

		[DataMember(Name="ProjectID", EmitDefaultValue=false)]
		public StringValue ProjectID { get; set; }

		[DataMember(Name="ProjectTaskID", EmitDefaultValue=false)]
		public StringValue ProjectTaskID { get; set; }

		[DataMember(Name="Properties", EmitDefaultValue=false)]
		public ProjectTaskProperties Properties { get; set; }

		[DataMember(Name="Status", EmitDefaultValue=false)]
		public StringValue Status { get; set; }

		[DataMember(Name="VisibilitySettings", EmitDefaultValue=false)]
		public VisibilitySettings VisibilitySettings { get; set; }

		public string GetEndpointPath()
		{
			return "entity/eCommerce/22.200.001";
		}
	}
}