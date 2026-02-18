using System;
using System.Collections.Generic;

using Newtonsoft.Json;

using Acumatica.RESTClient.Client;
using Acumatica.RESTClient.ContractBasedApi;
using Acumatica.RESTClient.ContractBasedApi.Model;

namespace Acumatica.Default_25_200_001.Model
{
	/// <summary>
	/// Corresponds to the screen <c>PM302000</c> in the Acumatica ERP
	/// <para>Key Fields: ProjectID, ProjectTaskID</para>
	/// </summary>
	public class ProjectTask : Entity, ITopLevelEntity
	{

		public List<ProjectActivity>? ActivityHistory { get; set; }

		public List<AttributeValue>? Attributes { get; set; }

		public ProjectTaskBillingAndAllocationSettings? BillingAndAllocationSettings { get; set; }

		public ProjectTaskToCRMLink? CRMLink { get; set; }

		/// <summary>
		/// Specifies (if set to true) that the task is default.
		/// <para>DAC Field Name: IsDefault</para>
		/// <para>DAC: PX.Objects.PM.PMTask</para>
		/// </summary>
		public BooleanValue? Default { get; set; }

		public ProjectTaskDefaultValues? DefaultValues { get; set; }

		/// <summary>
		/// The description of the task.
		/// <para>DAC: PX.Objects.PM.PMTask</para>
		/// <para>SQL Type: nvarchar(250)</para>
		/// </summary>
		public StringValue? Description { get; set; }

		public StringValue? ExternalRefNbr { get; set; }

		public DateTimeValue? LastModifiedDateTime { get; set; }

		/// <summary>
		/// <para>DAC: PX.Objects.PM.PMTask</para>
		/// <para>Display Name: Project ID</para>
		/// Key Field
		/// </summary>
		public StringValue? ProjectID { get; set; }

		/// <summary>
		/// The unique identifier of the task. This is a segmented key, which format is configured on the Segmented Keys (CS202000) form.
		/// <para>DAC Field Name: TaskCD</para>
		/// <para>DAC: PX.Objects.PM.PMTask</para>
		/// <para>Display Name: Task ID</para>
		/// <para>SQL Type: nvarchar(30)</para>
		/// Key Field
		/// </summary>
		public StringValue? ProjectTaskID { get; set; }

		public ProjectTaskProperties? Properties { get; set; }

		/// <summary>
		/// The task status.
		/// <para>DAC: PX.Objects.PM.PMTask</para>
		/// <para>SQL Type: char(1)</para>
		/// </summary>
		public StringValue? Status { get; set; }

		public VisibilitySettings? VisibilitySettings { get; set; }

		public static class Expand
		{
			public const string Files = "Files";
			public const string Translations = "Translations";
			public const string ActivityHistory = "ActivityHistory";
			public const string ActivityHistory_Files = "ActivityHistory/Files";
			public const string Attributes = "Attributes";
			public const string BillingAndAllocationSettings = "BillingAndAllocationSettings";
			public const string CRMLink = "CRMLink";
			public const string DefaultValues = "DefaultValues";
			public const string Properties = "Properties";
			public const string VisibilitySettings = "VisibilitySettings";

			//Intentionally excluded
			//public const string All = "Files,Translations,ActivityHistory,ActivityHistory/Files,Attributes,BillingAndAllocationSettings,CRMLink,DefaultValues,Properties,VisibilitySettings";
		}
		public virtual string GetEndpointPath()
		{
			return "entity/Default/25.200.001";
		}
	}
}