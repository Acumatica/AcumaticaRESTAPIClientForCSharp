using System;
using System.Collections.Generic;

using Newtonsoft.Json;

using Acumatica.RESTClient.Client;
using Acumatica.RESTClient.ContractBasedApi;
using Acumatica.RESTClient.ContractBasedApi.Model;

namespace Acumatica.Default_25_200_001.Model
{
	/// <summary>
	/// Corresponds to the screen <c>PM208010</c> in the Acumatica ERP
	/// <para>Key Fields: ProjectTemplateID, ProjectTemplateTaskID</para>
	/// </summary>
	public class ProjectTemplateTask : Entity, ITopLevelEntity
	{

		public List<AttributeValue>? Attributes { get; set; }

		public ProjectTaskBillingAndAllocationSettings? BillingAndAllocationSettings { get; set; }

		public ProjectTaskDefaultValues? DefaultValues { get; set; }

		/// <summary>
		/// The description of the task.
		/// <para>DAC: PX.Objects.PM.PMTask</para>
		/// <para>SQL Type: nvarchar(250)</para>
		/// </summary>
		public StringValue? Description { get; set; }

		public DateTimeValue? LastModifiedDateTime { get; set; }

		/// <summary>
		/// <para>DAC Field Name: ProjectID</para>
		/// <para>DAC: PX.Objects.PM.PMTask</para>
		/// <para>Display Name: Project ID</para>
		/// Key Field
		/// </summary>
		public StringValue? ProjectTemplateID { get; set; }

		/// <summary>
		/// The unique identifier of the task. This is a segmented key, which format is configured on the Segmented Keys (CS202000) form.
		/// <para>DAC Field Name: TaskCD</para>
		/// <para>DAC: PX.Objects.PM.PMTask</para>
		/// <para>Display Name: Task ID</para>
		/// <para>SQL Type: nvarchar(30)</para>
		/// Key Field
		/// </summary>
		public StringValue? ProjectTemplateTaskID { get; set; }

		public ProjectTemplateTaskProperties? Properties { get; set; }

		public VisibilitySettings? VisibilitySettings { get; set; }

		public static class Expand
		{
			public const string Files = "Files";
			public const string Translations = "Translations";
			public const string Attributes = "Attributes";
			public const string BillingAndAllocationSettings = "BillingAndAllocationSettings";
			public const string DefaultValues = "DefaultValues";
			public const string Properties = "Properties";
			public const string VisibilitySettings = "VisibilitySettings";

			//Intentionally excluded
			//public const string All = "Files,Translations,Attributes,BillingAndAllocationSettings,DefaultValues,Properties,VisibilitySettings";
		}
		public virtual string GetEndpointPath()
		{
			return "entity/Default/25.200.001";
		}
	}
}