using System;
using System.Collections.Generic;
using System.Runtime.Serialization;

using Newtonsoft.Json;

using Acumatica.RESTClient.Client;
using Acumatica.RESTClient.ContractBasedApi;
using Acumatica.RESTClient.ContractBasedApi.Model;

namespace Acumatica.Default_23_200_001.Model
{
	/// <summary>
	/// Corresponds to the screen <c>PM208010</c> in the Acumatica ERP
	/// <para>Key Fields: ProjectTemplateID, ProjectTemplateTaskID</para>
	/// </summary>
	[DataContract]
	public class ProjectTemplateTask : Entity, ITopLevelEntity
	{

		[DataMember(Name="Attributes", EmitDefaultValue=false)]
		public List<AttributeValue>? Attributes { get; set; }

		[DataMember(Name="BillingAndAllocationSettings", EmitDefaultValue=false)]
		public ProjectTaskBillingAndAllocationSettings? BillingAndAllocationSettings { get; set; }

		[DataMember(Name="DefaultValues", EmitDefaultValue=false)]
		public ProjectTaskDefaultValues? DefaultValues { get; set; }

		/// <summary>
		/// The description of the task.
		/// <para>DAC: PX.Objects.PM.PMTask</para>
		/// <para>SQL Type: nvarchar(250)</para>
		/// </summary>
		[DataMember(Name="Description", EmitDefaultValue=false)]
		public StringValue? Description { get; set; }

		[DataMember(Name="LastModifiedDateTime", EmitDefaultValue=false)]
		public DateTimeValue? LastModifiedDateTime { get; set; }

		/// <summary>
		/// <para>DAC Field Name: ProjectID</para>
		/// <para>DAC: PX.Objects.PM.PMTask</para>
		/// <para>Display Name: Project ID</para>
		/// Key Field
		/// </summary>
		[DataMember(Name="ProjectTemplateID", EmitDefaultValue=false)]
		public StringValue? ProjectTemplateID { get; set; }

		/// <summary>
		/// The unique identifier of the task. This is a segmented key, which format is configured on the Segmented Keys (CS202000) form.
		/// <para>DAC Field Name: TaskCD</para>
		/// <para>DAC: PX.Objects.PM.PMTask</para>
		/// <para>Display Name: Task ID</para>
		/// <para>SQL Type: nvarchar(30)</para>
		/// Key Field
		/// </summary>
		[DataMember(Name="ProjectTemplateTaskID", EmitDefaultValue=false)]
		public StringValue? ProjectTemplateTaskID { get; set; }

		[DataMember(Name="Properties", EmitDefaultValue=false)]
		public ProjectTemplateTaskProperties? Properties { get; set; }

		[DataMember(Name="VisibilitySettings", EmitDefaultValue=false)]
		public VisibilitySettings? VisibilitySettings { get; set; }

		public static class Expand
		{
			public const string Files = "Files";
			public const string Attributes = "Attributes";
			public const string BillingAndAllocationSettings = "BillingAndAllocationSettings";
			public const string DefaultValues = "DefaultValues";
			public const string Properties = "Properties";
			public const string VisibilitySettings = "VisibilitySettings";

			//Intentionally excluded
			//public const string All = "Files,Attributes,BillingAndAllocationSettings,DefaultValues,Properties,VisibilitySettings";
		}
		public virtual string GetEndpointPath()
		{
			return "entity/Default/23.200.001";
		}
	}
}