using System;
using System.Collections.Generic;

using Newtonsoft.Json;

using Acumatica.RESTClient.Client;
using Acumatica.RESTClient.ContractBasedApi;
using Acumatica.RESTClient.ContractBasedApi.Model;

namespace Acumatica.Default_26_200_001.Model
{
	/// <summary>
	/// Corresponds to the screen <c>PM208000</c> in the Acumatica ERP
	/// <para>Key Fields: ProjectTemplateID</para>
	/// </summary>
	public class ProjectTemplate : Entity, ITopLevelEntity
	{

		#region Fields
		/// <summary>
		/// The project CD. This is a segmented key. Its format is configured on the Segmented Keys (CS202000) form.
		/// <para>DAC Field Name: ContractCD</para>
		/// <para>DAC: PX.Objects.PM.PMProject</para>
		/// <para>Display Name: Project ID</para>
		/// <para>SQL Type: nvarchar(30)</para>
		/// Key Field
		/// </summary>
		public StringValue? ProjectTemplateID { get; set; }

		/// <summary>
		/// The status of the project.
		/// <para>DAC: PX.Objects.PM.PMProject</para>
		/// <para>SQL Type: char(1)</para>
		/// </summary>
		public StringSingleSelectValue? Status { get; set; }

		/// <summary>
		/// The project description.
		/// <para>DAC: PX.Objects.PM.PMProject</para>
		/// <para>SQL Type: nvarchar(256)</para>
		/// </summary>
		public StringValue? Description { get; set; }

		public DateTimeValue? LastModifiedDateTime { get; set; }

		#endregion

		#region LinkedEntities
		public ProjectBillingAndAllocationSettings? BillingAndAllocationSettings { get; set; }

		public ProjectGLAccount? GLAccounts { get; set; }

		public ProjectProperties? ProjectProperties { get; set; }

		public VisibilitySettings? VisibilitySettings { get; set; }

		#endregion

		#region Details
		public List<AttributeValue>? Attributes { get; set; }

		public List<ProjectEmployee>? Employees { get; set; }

		public List<ProjectEquipment>? Equipments { get; set; }

		#endregion

		protected override string GetDebuggerDisplay()
		{
			return $"{nameof(ProjectTemplate)} - \"{ProjectTemplateID}\"";
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
			public const string Employees = "Employees";
			public const string Equipments = "Equipments";
			public const string GLAccounts = "GLAccounts";
			public const string ProjectProperties = "ProjectProperties";
			public const string VisibilitySettings = "VisibilitySettings";

			//Intentionally excluded
			//public const string All = "Files,Translations,Attributes,BillingAndAllocationSettings,Employees,Equipments,GLAccounts,ProjectProperties,VisibilitySettings";
		}
		public virtual string GetEndpointPath()
		{
			return "entity/Default/26.200.001";
		}
	}
}