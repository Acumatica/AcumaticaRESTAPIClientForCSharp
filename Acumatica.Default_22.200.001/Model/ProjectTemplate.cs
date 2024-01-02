using System;
using System.Collections.Generic;
using System.Runtime.Serialization;

using Newtonsoft.Json;

using Acumatica.RESTClient.Client;
using Acumatica.RESTClient.ContractBasedApi;
using Acumatica.RESTClient.ContractBasedApi.Model;

namespace Acumatica.Default_22_200_001.Model
{
	[DataContract]
	public class ProjectTemplate : Entity, ITopLevelEntity
	{

		[DataMember(Name="Attributes", EmitDefaultValue=false)]
		public List<AttributeValue>? Attributes { get; set; }

		[DataMember(Name="BillingAndAllocationSettings", EmitDefaultValue=false)]
		public ProjectBillingAndAllocationSettings? BillingAndAllocationSettings { get; set; }

		[DataMember(Name="Description", EmitDefaultValue=false)]
		public StringValue? Description { get; set; }

		[DataMember(Name="Employees", EmitDefaultValue=false)]
		public List<ProjectEmployee>? Employees { get; set; }

		[DataMember(Name="Equipments", EmitDefaultValue=false)]
		public List<ProjectEquipment>? Equipments { get; set; }

		[DataMember(Name="GLAccounts", EmitDefaultValue=false)]
		public ProjectGLAccount? GLAccounts { get; set; }

		[DataMember(Name="LastModifiedDateTime", EmitDefaultValue=false)]
		public DateTimeValue? LastModifiedDateTime { get; set; }

		[DataMember(Name="ProjectProperties", EmitDefaultValue=false)]
		public ProjectProperties? ProjectProperties { get; set; }

		[DataMember(Name="ProjectTemplateID", EmitDefaultValue=false)]
		public StringValue? ProjectTemplateID { get; set; }

		[DataMember(Name="Status", EmitDefaultValue=false)]
		public StringValue? Status { get; set; }

		[DataMember(Name="VisibilitySettings", EmitDefaultValue=false)]
		public VisibilitySettings? VisibilitySettings { get; set; }

		public virtual string GetEndpointPath()
		{
			return "entity/Default/22.200.001";
		}
	}
}