using System;
using System.Collections.Generic;

using Newtonsoft.Json;

using Acumatica.RESTClient.Client;
using Acumatica.RESTClient.ContractBasedApi;
using Acumatica.RESTClient.ContractBasedApi.Model;

namespace Acumatica.Default_24_200_001.Model
{
	/// <summary>
	/// Corresponds to the screen <c>PM208000</c> in the Acumatica ERP
	/// <para>Key Fields: ProjectTemplateID</para>
	/// </summary>
	public class ProjectTemplate : Entity, ITopLevelEntity
	{

		public List<AttributeValue>? Attributes { get; set; }

		public ProjectBillingAndAllocationSettings? BillingAndAllocationSettings { get; set; }

		/// <summary>
		/// The project description.
		/// <para>DAC: PX.Objects.PM.PMProject</para>
		/// <para>SQL Type: nvarchar(255)</para>
		/// </summary>
		public StringValue? Description { get; set; }

		public List<ProjectEmployee>? Employees { get; set; }

		public List<ProjectEquipment>? Equipments { get; set; }

		public ProjectGLAccount? GLAccounts { get; set; }

		public DateTimeValue? LastModifiedDateTime { get; set; }

		public ProjectProperties? ProjectProperties { get; set; }

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
		public StringValue? Status { get; set; }

		public VisibilitySettings? VisibilitySettings { get; set; }

		public static class Expand
		{
			public const string Files = "Files";
			public const string Translations = "Translations";
			public const string Attributes = "Attributes";
			public const string BillingAndAllocationSettings = "BillingAndAllocationSettings";
			public const string Employees = "Employees";
			public const string Employees_Files = "Employees/Files";
			public const string Equipments = "Equipments";
			public const string Equipments_Files = "Equipments/Files";
			public const string GLAccounts = "GLAccounts";
			public const string GLAccounts_DefaultTaskForGLAccounts = "GLAccounts/DefaultTaskForGLAccounts";
			public const string GLAccounts_DefaultTaskForGLAccounts_Files = "GLAccounts/DefaultTaskForGLAccounts/Files";
			public const string ProjectProperties = "ProjectProperties";
			public const string VisibilitySettings = "VisibilitySettings";

			//Intentionally excluded
			//public const string All = "Files,Translations,Attributes,BillingAndAllocationSettings,Employees,Employees/Files,Equipments,Equipments/Files,GLAccounts,GLAccounts/DefaultTaskForGLAccounts,GLAccounts/DefaultTaskForGLAccounts/Files,ProjectProperties,VisibilitySettings";
		}
		public virtual string GetEndpointPath()
		{
			return "entity/Default/24.200.001";
		}
	}
}