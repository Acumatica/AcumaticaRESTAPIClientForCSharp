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
	/// Corresponds to the screen PM208000 in the Acumatica ERP
	/// </summary>
	[DataContract]
	public class ProjectTemplate : Entity, ITopLevelEntity
	{

		[DataMember(Name="Attributes", EmitDefaultValue=false)]
		public List<AttributeValue>? Attributes { get; set; }

		[DataMember(Name="BillingAndAllocationSettings", EmitDefaultValue=false)]
		public ProjectBillingAndAllocationSettings? BillingAndAllocationSettings { get; set; }

		/// <summary>
		/// The project description.
		/// DAC: PX.Objects.PM.PMProject 
		/// SQL Type: nvarchar(255) 
		/// </summary>
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

		/// <summary>
		/// The project CD. This is a segmented key. Its format is configured on the Segmented Keys (CS202000) form.
		/// DAC Field Name: ContractCD 
		/// DAC: PX.Objects.PM.PMProject 
		/// Display Name: Project ID 
		/// SQL Type: nvarchar(30) 
		/// Key Field
		/// </summary>
		[DataMember(Name="ProjectTemplateID", EmitDefaultValue=false)]
		public StringValue? ProjectTemplateID { get; set; }

		/// <summary>
		/// The status of the project.
		/// DAC: PX.Objects.PM.PMProject 
		/// SQL Type: char(1) 
		/// </summary>
		[DataMember(Name="Status", EmitDefaultValue=false)]
		public StringValue? Status { get; set; }

		[DataMember(Name="VisibilitySettings", EmitDefaultValue=false)]
		public VisibilitySettings? VisibilitySettings { get; set; }

		public static class Expand
		{
			public const string Attributes = "Attributes";
			public const string BillingAndAllocationSettings = "BillingAndAllocationSettings";
			public const string Employees = "Employees";
			public const string Equipments = "Equipments";
			public const string GLAccounts = "GLAccounts";
			public const string GLAccounts_DefaultTaskForGLAccounts = "GLAccounts/DefaultTaskForGLAccounts";
			public const string ProjectProperties = "ProjectProperties";
			public const string VisibilitySettings = "VisibilitySettings";

			public const string All = "Attributes,BillingAndAllocationSettings,Employees,Equipments,GLAccounts,GLAccounts/DefaultTaskForGLAccounts,ProjectProperties,VisibilitySettings";
		}
		public virtual string GetEndpointPath()
		{
			return "entity/Default/24.200.001";
		}
	}
}