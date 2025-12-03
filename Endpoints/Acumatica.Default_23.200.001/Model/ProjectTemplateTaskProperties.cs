using System;
using System.Collections.Generic;
using System.Runtime.Serialization;

using Newtonsoft.Json;

using Acumatica.RESTClient.Client;
using Acumatica.RESTClient.ContractBasedApi;
using Acumatica.RESTClient.ContractBasedApi.Model;

namespace Acumatica.Default_23_200_001.Model
{
	[DataContract]
	public class ProjectTemplateTaskProperties : Entity
	{

		/// <summary>
		/// The EPEmployee that approves or rejects the activities created under the given task.
		/// <para>DAC Field Name: ApproverID</para>
		/// <para>DAC: PX.Objects.PM.PMTask</para>
		/// </summary>
		[DataMember(Name="Approver", EmitDefaultValue=false)]
		public StringValue? Approver { get; set; }

		/// <summary>
		/// Specifies (if set to true) that this task should be automatically created when a template is assigned to the project. This field is used for            project templates.
		/// <para>DAC Field Name: AutoIncludeInPrj</para>
		/// <para>DAC: PX.Objects.PM.PMTask</para>
		/// <para>Display Name: Automatically Include in Project</para>
		/// </summary>
		[DataMember(Name="AutomaticallyIncludeInProject", EmitDefaultValue=false)]
		public BooleanValue? AutomaticallyIncludeInProject { get; set; }

		/// <summary>
		/// The calculation method of the completion.
		/// <para>DAC Field Name: CompletedPctMethod</para>
		/// <para>DAC: PX.Objects.PM.PMTask</para>
		/// <para>Display Name: Completion Method</para>
		/// <para>SQL Type: char(1)</para>
		/// </summary>
		[DataMember(Name="CompletionMethod", EmitDefaultValue=false)]
		public StringValue? CompletionMethod { get; set; }

		/// <summary>
		/// Specifies (if set to true) that the task is default.
		/// <para>DAC Field Name: IsDefault</para>
		/// <para>DAC: PX.Objects.PM.PMTask</para>
		/// </summary>
		[DataMember(Name="Default", EmitDefaultValue=false)]
		public BooleanValue? Default { get; set; }

	}
}