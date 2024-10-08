using System;
using System.Collections.Generic;
using System.Runtime.Serialization;

using Newtonsoft.Json;

using Acumatica.RESTClient.Client;
using Acumatica.RESTClient.ContractBasedApi;
using Acumatica.RESTClient.ContractBasedApi.Model;

namespace Acumatica.Default_24_200_001.Model
{
	/// <summary>
	/// Corresponds to the screen PM302000 in the Acumatica ERP
	/// </summary>
	[DataContract]
	public class ProjectTask : Entity, ITopLevelEntity
	{

		[DataMember(Name="ActivityHistory", EmitDefaultValue=false)]
		public List<ProjectActivity>? ActivityHistory { get; set; }

		[DataMember(Name="Attributes", EmitDefaultValue=false)]
		public List<AttributeValue>? Attributes { get; set; }

		[DataMember(Name="BillingAndAllocationSettings", EmitDefaultValue=false)]
		public ProjectTaskBillingAndAllocationSettings? BillingAndAllocationSettings { get; set; }

		[DataMember(Name="CRMLink", EmitDefaultValue=false)]
		public ProjectTaskToCRMLink? CRMLink { get; set; }

		/// <summary>
		/// Specifies (if set to true) that the task is default.
		/// DAC Field Name: IsDefault 
		/// DAC: PX.Objects.PM.PMTask 
		/// </summary>
		[DataMember(Name="Default", EmitDefaultValue=false)]
		public BooleanValue? Default { get; set; }

		[DataMember(Name="DefaultValues", EmitDefaultValue=false)]
		public ProjectTaskDefaultValues? DefaultValues { get; set; }

		/// <summary>
		/// The description of the task.
		/// DAC: PX.Objects.PM.PMTask 
		/// SQL Type: nvarchar(250) 
		/// </summary>
		[DataMember(Name="Description", EmitDefaultValue=false)]
		public StringValue? Description { get; set; }

		[DataMember(Name="ExternalRefNbr", EmitDefaultValue=false)]
		public StringValue? ExternalRefNbr { get; set; }

		[DataMember(Name="LastModifiedDateTime", EmitDefaultValue=false)]
		public DateTimeValue? LastModifiedDateTime { get; set; }

		/// <summary>
		/// DAC: PX.Objects.PM.PMTask 
		/// Display Name: Project ID 
		/// Key Field
		/// </summary>
		[DataMember(Name="ProjectID", EmitDefaultValue=false)]
		public StringValue? ProjectID { get; set; }

		/// <summary>
		/// The unique identifier of the task. This is a segmented key, which format is configured on the Segmented Keys (CS202000) form.
		/// DAC Field Name: TaskCD 
		/// DAC: PX.Objects.PM.PMTask 
		/// Display Name: Task ID 
		/// SQL Type: nvarchar(30) 
		/// Key Field
		/// </summary>
		[DataMember(Name="ProjectTaskID", EmitDefaultValue=false)]
		public StringValue? ProjectTaskID { get; set; }

		[DataMember(Name="Properties", EmitDefaultValue=false)]
		public ProjectTaskProperties? Properties { get; set; }

		/// <summary>
		/// The task status.
		/// DAC: PX.Objects.PM.PMTask 
		/// SQL Type: char(1) 
		/// </summary>
		[DataMember(Name="Status", EmitDefaultValue=false)]
		public StringValue? Status { get; set; }

		[DataMember(Name="VisibilitySettings", EmitDefaultValue=false)]
		public VisibilitySettings? VisibilitySettings { get; set; }

		public virtual string GetEndpointPath()
		{
			return "entity/Default/24.200.001";
		}
	}
}