using System;
using System.Collections.Generic;

using Newtonsoft.Json;

using Acumatica.RESTClient.Client;
using Acumatica.RESTClient.ContractBasedApi;
using Acumatica.RESTClient.ContractBasedApi.Model;

namespace Acumatica.Default_26_200_001.Model
{
	/// <summary>
	/// Corresponds to the screen <c>PM208010</c> in the Acumatica ERP
	/// <para>Key Fields: ProjectTemplateID, ProjectTemplateTaskID</para>
	/// </summary>
	public class ProjectTemplateTask : Entity, ITopLevelEntity
	{

		#region Fields
		/// <summary>
		/// The identifier of the project to which the task belongs.
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

		/// <summary>
		/// The description of the task.
		/// <para>DAC: PX.Objects.PM.PMTask</para>
		/// <para>SQL Type: nvarchar(250)</para>
		/// </summary>
		public StringValue? Description { get; set; }

		public DateTimeValue? LastModifiedDateTime { get; set; }

		#endregion

		#region LinkedEntities
		public ProjectTaskBillingAndAllocationSettings? BillingAndAllocationSettings { get; set; }

		public ProjectTaskDefaultValues? DefaultValues { get; set; }

		public ProjectTemplateTaskProperties? Properties { get; set; }

		public VisibilitySettings? VisibilitySettings { get; set; }

		#endregion

		#region Details
		public List<AttributeValue>? Attributes { get; set; }

		#endregion

		protected override string GetDebuggerDisplay()
		{
			return $"{nameof(ProjectTemplateTask)} - \"{ProjectTemplateID}\" - \"{ProjectTemplateTaskID}\"";
		}

		/// <summary>
		/// Names that can be passed in the <c>$expand</c> parameter.
		/// <para>This endpoint uses system contract 5, where a nested entity is expanded
		/// as <c>Parent($expand=Child)</c> rather than <c>Parent/Child</c>, so only the names
		/// that can be expanded directly on this entity are listed here. Use the nested
		/// entity's own <c>Expand</c> class for the inner names.</para>
		/// </summary>
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
			return "entity/Default/26.200.001";
		}
	}
}