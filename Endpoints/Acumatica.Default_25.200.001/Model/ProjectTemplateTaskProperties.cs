using System;
using System.Collections.Generic;

using Newtonsoft.Json;

using Acumatica.RESTClient.Client;
using Acumatica.RESTClient.ContractBasedApi;
using Acumatica.RESTClient.ContractBasedApi.Model;

namespace Acumatica.Default_25_200_001.Model
{
	public class ProjectTemplateTaskProperties : Entity
	{

		#region Fields
		/// <summary>
		/// A Boolean value that indicates (if set to true) that the task is default.
		/// <para>DAC Field Name: IsDefault</para>
		/// <para>DAC: PX.Objects.PM.PMTask</para>
		/// </summary>
		public BooleanValue? Default { get; set; }

		/// <summary>
		/// A Boolean value that indicates (if set to true) that this task should be automatically created when a template is assigned to the project. This field is used forproject templates.
		/// <para>DAC Field Name: AutoIncludeInPrj</para>
		/// <para>DAC: PX.Objects.PM.PMTask</para>
		/// <para>Display Name: Automatically Include in Project</para>
		/// </summary>
		public BooleanValue? AutomaticallyIncludeInProject { get; set; }

		/// <summary>
		/// The calculation method of the completion.
		/// <para>DAC Field Name: CompletedPctMethod</para>
		/// <para>DAC: PX.Objects.PM.PMTask</para>
		/// <para>Display Name: Completion Method</para>
		/// <para>SQL Type: char(1)</para>
		/// </summary>
		public StringValue? CompletionMethod { get; set; }

		/// <summary>
		/// The identifier of the employee that approves or rejects the activities created under the given task.
		/// <para>DAC Field Name: ApproverID</para>
		/// <para>DAC: PX.Objects.PM.PMTask</para>
		/// </summary>
		public StringValue? Approver { get; set; }

		#endregion

	}
}